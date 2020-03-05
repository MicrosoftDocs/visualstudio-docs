---
title: "Edit UML sequence diagrams by using the UML API | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML activity diagrams, programming"
ms.assetid: 8cdd0203-85ef-4c62-9abc-da4cb26fa504
caps.latest.revision: 27
author: jillre
ms.author: jillfra
manager: jillfra
---
# Edit UML sequence diagrams by using the UML API
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

An interaction is a sequence of messages between a set of lifelines. An interaction is displayed on a UML sequence diagram.

 For full details of the API, see [Microsoft.VisualStudio.Uml.Interactions](/previous-versions/dd493373(v=vs.140)).

 For a more general introduction to writing commands and gesture handlers for UML diagrams, see [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

## Basic Code

### Namespace imports
 You must include the following `using` statements:

```
using Microsoft.VisualStudio.Uml.Classes;
   // for basic UML types such as IPackage
using Microsoft.VisualStudio.Uml.Interactions;
   // for interaction types
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
   // to create elements and use additional functions
```

 If you are creating menu commands and gesture handlers, you will also need:

```
using System.ComponentModel.Composition;
   // for Import and Export
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
   // for ICommandExtension
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
   // for diagrams and context
```

 For more information, see [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

### Getting the context
 If you are editing an interaction as part of a command or gesture handler in a sequence diagram, you can obtain a reference to the context. For example:

```
[SequenceDesignerExtension]
[Export(typeof(ICommandExtension))]
public class MySequenceDiagramCommand : ICommandExtension
{
    [Import]
    public IDiagramContext Context { get; set; }
    public void QueryStatus (IMenuCommand command)
    {
      ISequenceDiagram sequenceDiagram =
          Context.CurrentDiagram as ISequenceDiagram;
         ...
```

### Generated and UML Sequence Diagrams
 There are two kinds of sequence diagrams: those that are manually created in a UML modeling project, and those that were generated from program code. Use the `UmlMode` property to discover which sequence diagram you have.

> [!NOTE]
> This property returns false only for sequence diagrams generated from code using Visual Studio 2013 and earlier. This includes code-generated sequence diagrams migrated from 2013 and earlier. This version of Visual Studio doesn't support generating new sequence diagrams.

 For example, if you want to make a menu command that is only visible on UML sequence diagrams, then the `QueryStatus()` method could include the following statement:

```
command.Enabled = command.Visible =
      sequenceDiagram != null && sequenceDiagram.UmlMode;
```

 On a generated sequence diagram, lifelines, messages, and other elements are mostly the same as on a UML sequence diagram. In a UML model, the Model Store has a root, which is the Model that owns all the other elements. But a generated interaction exists in its own Model Store, which has a null root:

```
IModel rootModel = sequenceDiagram.ModelStore.Root;
    // !sequenceDiagram.UmlMode == (rootModel == null)
```

## To create and display an Interaction
 Create the interaction as a child of a package or model.

 For example, if you are developing a command that might be performed on a blank sequence diagram, you should always begin by checking whether the interaction exists.

```
public void Execute (IMenuCommand command)
{
    ISequenceDiagram sequenceDiagram =
         Context.CurrentDiagram as ISequenceDiagram;
    if (sequenceDiagram == null) return;
    // Get the diagram's interaction:
    IInteraction interaction = sequenceDiagram.Interaction;
    // A new sequence diagram might have no interaction:
    if (interaction == null)
    {
       // Get the home package or model of the diagram:
       IPackage parentPackage = sequenceDiagram.GetObject<IPackage>();
       interaction = parentPackage.CreateInteraction();
       // Display the interaction on the sequence diagram:
       sequenceDiagram.Bind(interaction);
    }
```

## Updating an Interaction and its Layout
 When you update an Interaction, always end your operation by updating its layout using one of the following methods:

- `ISequenceDiagram.UpdateShapePositions()` adjusts the positions of shapes that have recently been inserted or moved, and their neighboring shapes.

- `ISequenceDiagram.Layout([SequenceDiagramLayoutKinds])` redraws the whole diagram. You can use the parameter to specify repositioning of the lifelines, the messages, or both.

  This is particularly important when you insert new elements or move existing elements. They will not be in the correct positions on the diagram until you have performed one of these operations. You only need to call one of these operations once at the end of a series of changes.

  To avoid bemusing the user who performs an undo after your command, use an `ILinkedUndoTransaction` to enclose your changes and the final `Layout()` or `UpdateShapePositions()` operations. For example:

```
using (ILinkedUndoTransaction transaction = LinkedUndoContext.BeginTransaction("create loop"))
{
  Interaction.CreateCombinedFragment(InteractionOperatorKind.Loop, messages);
  Diagram.UpdateShapePositions();
  transaction.Commit();
}
```

 To use an `ILinkedUndoTransaction`, you must make this declaration in your class:

```
[Import] ILinkedUndoContext LinkedUndoContext { get; set; }
```

 For more information, see [Link UML model updates by using transactions](../modeling/link-uml-model-updates-by-using-transactions.md).

## Building an Interaction

### To create lifelines

```
ILifeline lifeline = interaction.CreateLifeline();
```

 A lifeline represents a connectable element, that is, an instance of a type. For example, if the interaction is used to show how a component delegates incoming messages to its internal parts, the lifelines can represent the ports and parts of the component:

```
foreach (IConnectableElement part in
            component.Parts
           .Concat<IConnectableElement>(component.OwnedPorts))
{
   ILifeline lifeline = interaction.CreateLifeline();
   lifeline.Represents = part;
}
```

 Alternatively, if the interaction shows an arbitrary set of objects, you can create a property or other `IConnectableElement` in the interaction itself:

```
ILifeline lifeline = interaction.CreateLifeline();
IProperty property1 = interaction.CreateProperty();
property1.Type = model.CreateInterface();
property1.Type.Name = "Type 1";
lifeline.Represents = property1;
```

 As a further alternative, you can set the name and type of a lifeline without linking it to a connectable element:

```
ILifeline lifeline = interaction.CreateLifeline();
lifeline.Name = "c1";
lifeline.SetInstanceType("Customer");
System.Diagnostics.Debug.Assert(
           lifeline.GetDisplayName() == "c1:Customer"  );
```

### To create messages
 To create a message, you must identify insertion points on the source and target lifelines. For example:

```
interaction.CreateMessage( sourceInsertionPoint,
                           targetInsertionPoint,
                           MessageKind.Complete,
                           MessageSort.ASynchCall)
```

 To create a message that has an undefined source or undefined target:

```
interaction.CreateLostFoundMessage(MessageKind.Found, insertionPoint);
```

 There are several messages that you can use to identify insertion points at all the key points on a lifeline:

|Method on ILifeline|Use it to insert at this point|
|-------------------------|------------------------------------|
|`FindInsertionPointAtTop()`|The top of the lifeline.|
|`FindInsertionPointAtBottom()`|The bottom of the lifeline.|
|`FindInsertionPointAfterMessage`<br /><br /> `(IMessage previous)`|A point immediately after the specified message.|
|`FindInsertionPointAfterExecutionSpecification`<br /><br /> `(IExecutionSpecification previous)`|The point can be either on the lifeline, or on a parent execution specification block.|
|`FindInsertionPointAfterInteractionUse`<br /><br /> `(IInteractionUse previous)`|A point following an Interaction Use.|
|`FindInsertionPointAfterCombinedFragment`<br /><br /> `(ICombinedFragment previous)`|A point following a Combined Fragment.|
|`FindInsertionPoint(IExecutionSpecification block)`|The top of an execution block.|
|`FindInsertionPoint(IInteractionOperand fragment)`|The top of an operand of a combined fragment.|

 When you create messages, take care to avoid defining a message that would cross over another message.

### To Create Combined Fragments and Interaction Uses
 You can create combined fragments and Interaction Uses by specifying an insertion point on each lifeline that must be covered by the element. Take care to avoid specifying a set of points that would cross over an existing message or fragment.

```
Interaction.CreateCombinedFragment(InteractionOperatorKind.Loop,
  Interaction.Lifelines.Select(lifeline => lifeline.FindInsertionPointAtTop()));
Interaction.CreateInteractionUse(
  Interaction.Lifelines.Select(lifeline => lifeline.FindInsertionPointAtTop()));
```

 You can also create a combined fragment that covers an existing set of messages. The messages must all be sourced at the same lifeline or execution block.

```
ICombinedFragment cf = Interaction.CreateCombinedFragment(
  InteractionOperatorKind.Loop,
  Interaction.Lifelines.First().GetAllOutgoingMessages());
```

 A combined fragment is always created with a single operand. To create a new operand, you must specify the existing operand that you want to insert before or after, and whether you want to insert after it or before it:

```
// Create an additional operand before the first
cf.CreateInteractionOperand(cf.Operands.First(), false);
// Create an additional operand after the last:
cf.CreateInteractionOperand(cf.Operands.Last(), true);
```

## Troubleshooting
 Shapes will appear in incorrect positions if changes are not completed with an `UpdateShapePositions()` or `Layout()` operation.

 Most other problems are caused by insertion points being misaligned, so that new messages or fragments would have to cross over others. The symptoms can be that no change is performed, or an exception is thrown. The exception might not be thrown until the `UpdateShapePositions()` or `Layout()` operation is performed.

## See also

- [Microsoft.VisualStudio.Uml.Interactions](/previous-versions/dd493373(v=vs.140))
- [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)
- [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)
- [Define a custom modeling toolbox item](../modeling/define-a-custom-modeling-toolbox-item.md)
- [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)
- [Programming with the UML API](../modeling/programming-with-the-uml-api.md)
