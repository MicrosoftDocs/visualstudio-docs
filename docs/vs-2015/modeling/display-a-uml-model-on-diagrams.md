---
title: "Display a UML model on diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML API"
ms.assetid: adf1f1f2-2ad9-4ade-82de-c6a5194ab471
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
---
# Display a UML model on diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the program code for an extension to Visual Studio, you can control how model elements are displayed on diagrams. To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

In this topic:
- [To display an element on a diagram](#Display)

- [Accessing the shapes that represent an element](#GetShapes)

- [Moving and resizing shapes](#Moving)

- [To remove a shape from a diagram](#Removing)

- [Opening and creating diagrams](#Opening)

- [Example: Command for Aligning Shapes](#AlignCommand)

## <a name="Display"></a> To display an element on a diagram
 When you create an element such as a use case or an action, the user can see it in UML Model Explorer, but it does not always automatically appear in a diagram. In some cases, you must write code to display it. The following table summarizes the alternatives.

|Type of element|For example|To display this, your code must|
|---------------------|-----------------|-------------------------------------|
|Classifier|`Class`<br /><br /> `Component`<br /><br /> `Actor`<br /><br /> `Use Case`|Create associated shapes on specified diagrams. You can create any number of shapes for each classifier.<br /><br /> `diagram.Display<modelElementType>`<br /><br /> `(modelElement, parentShape,`<br /><br /> `xPosition , yPosition);`<br /><br /> Set `parentShape` to `null` for a shape at the top level of the diagram.<br /><br /> To display one shape inside another:<br /><br /> `IShape<IUseCase> usecaseShape =`<br /><br /> `useCaseDiagram.Display`<br /><br /> `(useCase,`<br /><br /> `subsystemShape,`<br /><br /> `subsystemShape.XPosition + 5,`<br /><br /> `subsystemShape.YPosition + 5);` **Note:**  If you perform Display inside an **ILinkedUndo** transaction, the method sometimes returns no `IShape`. But the shape is correctly created, and is accessible using `IElement.Shapes().`|
|Child of Classifier|Attribute, Operation,<br /><br /> Part, Port|Automatic - no code required.<br /><br /> It is displayed as part of the parent.|
|Behavior|Interaction (Sequence),<br /><br /> Activity|Bind the behavior to an appropriate diagram.<br /><br /> Each behavior can be bound to at most one diagram at a time.<br /><br /> For example:<br /><br /> `sequenceDiagram.Bind(interaction);`<br /><br /> `activityDiagram.Bind(activity);`|
|Child of behavior|Lifelines, messages, actions, object nodes|Automatic - no code required.<br /><br /> It is displayed if the parent is bound to a diagram.|
|Relationship|Association, generalization, flow, dependency|Automatic - no code required.<br /><br /> It is displayed on every diagram on which both ends are displayed.|

## <a name="GetShapes"></a> Accessing the shapes that represent an element
 The shape that represents an element belongs to the types:

 `IShape`

 `IShape<` *ElementType* `>`

 where *ElementType* is a type of the model element such as `IClass` or `IUseCase`.

|||
|-|-|
|`anElement.Shapes ()`|All the `IShapes` that represent this element in open diagrams.|
|`anElement.Shapes(aDiagram)`|All the `IShapes` that represent this element on a particular diagram.|
|`anIShape.GetElement()`|The `IElement` that the shape represents. You would normally cast it to a subclass of IElement.|
|`anIShape.Diagram`|The `IDiagram` that contains the shape.|
|`anIShape.ParentShape`|The shape that contains `anIShape`. For example, a port shape is contained within a component shape.|
|`anIShape.ChildShapes`|Shapes contained within an `IShape` or `IDiagram`.|
|`anIShape.GetChildShapes<IUseCase>()`|The shapes contained within an `IShape` or `IDiagram` that represent elements of the specified type, such as `IUseCase`.|
|`IShape iShape = ...;`<br /><br /> `IShape<IClass> classShape = iShape.ToIShape<IClass>();`<br /><br /> `IClass aClass = classShape.Element;`|Cast a generic `IShape` to a strongly typed `IShape<IElement>`.|
|`IShape<IClassifier> classifierShape;`<br /><br /> `IShape<IUseCase> usecaseShape =`<br /><br /> `classifierShape.ToIShape<IUseCase>();`|Cast a shape from one parameterized shape type to another.|

## <a name="Moving"></a> Moving and resizing shapes

|||
|-|-|
|`anIShape.Move(x, y, [width], [height])`|Move or resize a shape.|
|`IDiagram.EnsureVisible( IEnumerable<IShape> shapes, bool zoomToFit = false)`|Activate the window and scroll the diagram so that all the given shapes are visible. The shapes must all be on the diagram. If `zoomToFit` is true, the diagram will be scaled if necessary so that all of the shapes are visible.|

 For an example, see [Defining an Alignment Command](#AlignCommand).

## <a name="Removing"></a> To remove a shape from a diagram
 You can delete shapes of some types of element without deleting the element.

|Model Element|To remove the shape|
|-------------------|-------------------------|
|A classifier: a class, interface, enumeration, actor, use case or component|`shape.Delete();`|
|A behavior: interaction or activity|You can delete the diagram from the project. Use `IDiagram.FileName` to get the path.<br /><br /> This does not delete the behavior from the model.|
|Any other shape|You cannot explicitly delete other shapes from a diagram. The shape will automatically disappear if the element is deleted from the model, or if the parent shape is removed from the diagram.|

## <a name="Opening"></a> Opening and creating diagrams

### To access the user's current diagram from a command or gesture extension
 Declare this imported property in your class:

 `[Import]`

 `IDiagramContext Context { get; set; }`

 In a method, access the diagram:

 `IClassDiagram classDiagram =`

 `Context.CurrentDiagram as IClassDiagram;`

> [!NOTE]
> An instance of `IDiagram` (and its subtypes such as `IClassDiagram`) is valid only within the command you are processing. It is not recommended to keep an `IDiagram` object in a variable that persists while control is returned to the user.

 For more information, see [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

### To obtain a list of open diagrams
 A list of diagrams that are currently open in the project:

```
Context.CurrentDiagram.ModelStore.Diagrams()
```

## To access the diagrams in a project
 The [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] API can be used to open and create modeling projects and diagrams.

 Notice the cast from `EnvDTE.ProjectItem` to `IDiagramContext`.

```

      using EnvDTE; // Visual Studio API
...
[Import]
public IServiceProvider ServiceProvider { get; set; }
...
// Get Visual Studio API
DTE dte = ServiceProvider.GetService(typeof(DTE)) as DTE;
// Get current Visual Studio project
Project project = dte.ActiveDocument.ProjectItem.ContainingProject;
// Open and process every diagram in the project.
foreach (ProjectItem item in project.ProjectItems)
{
  // Cast ProjectItem to IDiagramContext
  IDiagramContext context = item as IDiagramContext;
  if (context == null)
  {
     // This is not a diagram file.
     continue;
  }
  // Open the file and give the window the focus.
  if (!item.IsOpen)
  {
      item.Open().Activate();
  }
  // Get the diagram.
  IDiagram diagram = context.CurrentDiagram;
  // Deal with specific diagram types.
  ISequenceDiagram seqDiagram = diagram as ISequenceDiagram;
  if (seqDiagram != null)
  { ... } } }
```

 Instances of `IDiagram` and its subtypes are not valid after you return control to [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

 You can also obtain the model store from a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project:

```

      Project project = ...;
IModelStore modelStore = (project as IModelingProject).Store;
```

## <a name="AlignCommand"></a> Example: Command for Aligning Shapes
 The following code implements a menu command that aligns shapes neatly. The user must first place two or more shapes in approximate alignment, either vertically or horizontally. Then the align command can be used to align their centers.

 To make the command available, add this code to a menu command project, and then deploy the resulting extension to your users. For more information, see [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;

namespace AlignCommand
{
  // Implements a command to align shapes in a UML class diagram.
  // The user first selects shapes that are roughly aligned either vertically or horizontally.
  // This command will straighten them up.

  // Place this file in a menu command extension project.
  // See https://msdn.microsoft.com/library/ee329481.aspx

  [Export(typeof(ICommandExtension))]
  [ClassDesignerExtension] // TODO: Add other diagram types if needed
  class CommandExtension : ICommandExtension
  {
    /// <summary>
    /// See https://msdn.microsoft.com/library/ee329481.aspx
    /// </summary>
    [Import]
    IDiagramContext context { get; set; }

    /// <summary>
    /// Transaction context.
    /// See https://msdn.microsoft.com/library/ee330926.aspx
    /// </summary>
    [Import]
    ILinkedUndoContext linkedUndo { get; set; }

    /// <summary>
    /// Called when the user selects the command.
    /// </summary>
    /// <param name="command"></param>
    public void Execute(IMenuCommand command)
    {
      Align(context.CurrentDiagram.SelectedShapes);
    }

    /// <summary>
    /// Called when the user right-clicks on the diagram.
    /// Determines whether the command is enabled.
    /// </summary>
    /// <param name="command"></param>
    public void QueryStatus(IMenuCommand command)
    {
      IEnumerable<IShape> currentSelection = context.CurrentDiagram.SelectedShapes;
      // Make it visible if there are shapes selected:
      command.Visible = currentSelection.Count() > 0 && !(currentSelection.FirstOrDefault() is IDiagram);

      // Make it enabled if there are two or more shapes that are roughly in line:
      command.Enabled = currentSelection.Count() > 1
        && (HorizontalAlignCenter(currentSelection) > 0.0
        || VerticalAlignCenter(currentSelection) > 0.0);

    }

    /// <summary>
    /// Title of the menu command.
    /// </summary>
    public string Text
    {
      get { return "Align Shapes"; }
    }

    /// <summary>
    /// Find a horizontal line that goes through a list of shapes.
    /// </summary>
    /// <param name="shapes"></param>
    /// <returns></returns>
    private static double HorizontalAlignCenter(IEnumerable<IShape> shapes)
    {
      double Y = -1.0;
      double top = 0.0, bottom = shapes.First().Bottom();
      foreach (IShape shape in shapes)
      {
        top = Math.Max(top, shape.Top());
        bottom = Math.Min(bottom, shape.Bottom());
      }
      if (bottom > top) Y = (bottom + top) / 2.0;
      return Y;
    }

    /// <summary>
    /// Find a vertical line that goes through a list of shapes.
    /// </summary>
    /// <param name="shapes"></param>
    /// <returns></returns>
    private static double VerticalAlignCenter(IEnumerable<IShape> shapes)
    {
      double X = -1.0;
      double left = 0.0, right = shapes.First().Right();
      foreach (IShape shape in shapes)
      {
        left = Math.Max(left, shape.Left());
        right = Math.Min(right, shape.Right());
      }
      if (right > left) X = (right + left) / 2.0;
      return X;
    }

    /// <summary>
    /// Line up those shapes that are roughly aligned.
    /// </summary>
    /// <param name="shapes"></param>
    private void Align(IEnumerable<IShape> shapes)
    {
      if (shapes.Count() > 1)
      {
        // The shapes must all overlap either horizontally or vertically.
        // Find a horizontal line that is covered by all the shapes:
        double Y = HorizontalAlignCenter(shapes);
        if (Y > 0.0) // Negative if they don't overlap.
        {
          // Adjust all the shape positions in one transaction:
          using (ILinkedUndoTransaction t = linkedUndo.BeginTransaction("align"))
          {
            foreach (IShape shape in shapes)
            {
              shape.AlignYCenter(Y);
            }
            t.Commit();
          }
        }
        else
        {
          // Find a vertical line that is covered by all the shapes:
          double X = VerticalAlignCenter(shapes);
          if (X > 0.0) // Negative if they don't overlap.
          {
            // Adjust all the shape positions in one transaction:
            using (ILinkedUndoTransaction t = linkedUndo.BeginTransaction("align"))
            {
              foreach (IShape shape in shapes)
              {
                shape.AlignXCenter(X);
              }
              t.Commit();
            }
          }
        }
      }
    }
  }

  /// <summary>
  /// Convenience extensions for IShape.
  /// </summary>
  public static class IShapeExtension
  {
    public static double Bottom(this IShape shape)
    {
      return shape.YPosition + shape.Height;
    }

    public static double Top(this IShape shape)
    {
      return shape.YPosition;
    }

    public static double Left(this IShape shape)
    {
      return shape.XPosition;
    }

    public static double Right(this IShape shape)
    {
      return shape.XPosition + shape.Width;
    }

    public static void AlignYCenter(this IShape shape, double Y)
    {
      shape.Move(shape.XPosition, Y - shape.YCenter());
    }

    public static void AlignXCenter(this IShape shape, double X)
    {
      shape.Move(X - shape.XCenter(), shape.YPosition);
    }

    /// <summary>
    /// We can adjust what bit of the shape we want to be aligned.
    /// The default is the center of the shape.
    /// </summary>
    /// <param name="shape"></param>
    /// <returns></returns>
    public static double YCenter(this IShape shape)
    {
        return shape.Height / 2.0;
    }

    /// <summary>
    /// We can adjust what bit of the shape we want to be aligned.
    /// The default is the center of the shape.
    /// </summary>
    /// <param name="shape"></param>
    /// <returns></returns>
    public static double XCenter(this IShape shape)
    {
        return shape.Width / 2.0;
    }
  }
}

```

## See Also
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)
 [Navigate the UML model](../modeling/navigate-the-uml-model.md)
 [Sample: Align Shapes on a Diagram menu command](https://go.microsoft.com/fwlink/?LinkId=213809)
 [Sample: Creating Elements, Shapes and Stereotypes](https://go.microsoft.com/fwlink/?LinkId=213811)
