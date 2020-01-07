---
title: Customizing Copy Behavior
ms.date: 11/04/2016
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Customizing Copy Behavior
In a domain-specific language (DSL) created with the Visual Studio Visualization and Modeling SDK, you can alter what happens when the user copies and pastes elements.

## Standard Copy and Paste Behavior
 To enable copying, set the **Enable Copy Paste** property of the **Editor** node in DSL Explorer.

 By default, when the user copies elements to the clipboard, the following elements are also copied:

- Embedded descendants of the selected elements. (That is, elements that are the targets of embedding relationships that are sourced at copied elements.)

- Relationship links between the copied elements.

  This rule applies recursively to the copied elements and links.

  ![Copied and pasted elements](../modeling/media/dslcopypastedefault.png)

  The copied elements and links are serialized and stored in an <xref:Microsoft.VisualStudio.Modeling.ElementGroupPrototype> (EGP), which is placed on the clipboard.

  An image of the copied elements is also placed on the clipboard. This allows the user to paste into other applications such as Word.

  The user can paste copied elements onto a target that can accept the elements according to the DSL Definition. For example, in a DSL generated from the components solution template, the user can paste ports onto components, but not onto the diagram; and can paste components onto the diagram, but not onto other components.

## Customizing Copy and Paste Behavior
 For more information about customizing the model by using program code, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

 **Enable or disable copy, cut, and paste.**
 In DSL Explorer, set the **Enable Copy Paste** property of the **Editor** node.

 **Copy links to the same target.** For example, to have a copied comment box linked to the same subject element.
 Set the **Propagates Copy** property of the role to **Propagate copy to link only**. For more information, see [Customizing Link Copy Behavior](#customizeLinks).

 Copy linked elements. For example, when you copy a new element, copies of any linked comment boxes are made as well.
 Set the **Propagates Copy** property of the role to **Propagate copy to link and opposite role player**. For more information, see [Customizing Link Copy Behavior](#customizeLinks).

 **Rapidly duplicate elements by copying and pasting.** Normally, the item you just copied is still selected, and you cannot paste the same type of element onto it.
 Add an Element Merge Directive to the domain class, and set it to forward merges to the parent class. This will have the same effect on drag operations. For more information, see [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md).

 \- or -

 Select the diagram before pasting the elements, by overriding `ClipboardCommandSet.ProcessOnPasteCommand()`. Add this code in a custom file in the DslPackage project:

```csharp
namespace Company.MyDsl {
using System.Linq;
using Microsoft.VisualStudio.Modeling.Diagrams;
using Microsoft.VisualStudio.Modeling.Shell;
partial class MyDslClipboardCommandSet
{
  protected override void ProcessOnMenuPasteCommand()
  {
 // Deselect the current selection after copying:
 Diagram diagram = (this.CurrentModelingDocView as SingleDiagramDocView).Diagram;
    this.CurrentModelingDocView
     .SelectObjects(1, new object[] { diagram }, 0);
  }
} }
```

 **Create additional links when the user pastes onto a selected target.** For example, when a comment box is pasted onto an element, a link is made between them.
 Add an Element Merge Directive to the target domain class, and set it to process the merge by adding links. This will have the same effect on drag operations. For more information, see [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md).

 \- or -

 Override `ClipboardCommandSet.ProcessOnPasteCommand()` to create the additional links after calling the base method.

 **Customize the formats in which elements can be copied** to external applications - for example, to add a border to the bitmap form.
 Override *MyDsl*`ClipboardCommandSet.ProcessOnMenuCopyCommand()` in the DslPackage project.

 **Customize how elements are copied to the clipboard by the copy command, but not in a drag operation.**
 Override *MyDsl*`ClipboardCommandSet.CopyModelElementsIntoElementGroupPrototype()` in the DslPackage project.

 **Preserve shape layout through copy and paste.**
 When the user copies multiple shapes, you can preserve their relative positions when they are pasted. This technique is demonstrated by the example at [VMSDK: Circuit Diagrams sample](https://code.msdn.microsoft.com/Visualization-Modeling-SDK-763778e8).

 To achieve this effect, add the shapes and connectors to the copied ElementGroupPrototype. The most convenient method to override is ElementOperations.CreateElementGroupPrototype(). To do this, add the following code to the Dsl project:

```csharp

public class MyElementOperations : DesignSurfaceElementOperations
{
  // Create an EGP to add to the clipboard.
  // Called when the elements to be copied have been
  // collected into an ElementGroup.
 protected override ElementGroupPrototype CreateElementGroupPrototype(ElementGroup elementGroup, ICollection<ModelElement> elements, ClosureType closureType)
  {
 // Add the shapes and connectors:
 // Get the elements already in the group:
    ModelElement[] mels = elementGroup.ModelElements
        .Concat(elementGroup.ElementLinks) // Omit if the paste target is not the diagram.
        .ToArray();
 // Get their shapes:
    IEnumerable<PresentationElement> shapes =
       mels.SelectMany(mel =>
            PresentationViewsSubject.GetPresentation(mel));
    elementGroup.AddRange(shapes);

 return base.CreateElementGroupPrototype
           (elementGroup, elements, closureType);
  }

 public MyElementOperations(IServiceProvider serviceProvider, ElementOps1Diagram diagram)
      : base(serviceProvider, diagram)
  { }
}

// Replace the standard ElementOperations
// singleton with your own:
partial class MyDslDiagram // EDIT NAME
{
 /// <summary>
 /// Singleton ElementOperations attached to this diagram.
 /// </summary>
 public override DesignSurfaceElementOperations ElementOperations
  {
 get
    {
 if (singleton == null)
      {
        singleton = new MyElementOperations(this.Store as IServiceProvider, this);
      }
 return singleton;
    }
  }
 private MyElementOperations singleton = null;
}
```

 **Paste shapes in a chosen location, such as the current cursor position.**
 When the user copies multiple shapes, you can preserve their relative positions when they are pasted. This technique is demonstrated by the example at [VMSDK: Circuit Diagrams sample](https://code.msdn.microsoft.com/Visualization-Modeling-SDK-763778e8).

 To achieve this effect, override `ClipboardCommandSet.ProcessOnMenuPasteCommand()` to use the location-specific version of `ElementOperations.Merge()`. To do this, add the following code in the DslPackage project:

```csharp

partial class MyDslClipboardCommandSet // EDIT NAME
{
   /// <summary>
    /// This method assumes we only want to paste things onto the diagram
    /// - not onto anything contained in the diagram.
    /// The base method pastes in a free space on the diagram.
    /// But if the menu was used to invoke paste, we want to paste in the cursor position.
    /// </summary>
    protected override void ProcessOnMenuPasteCommand()
    {

  NestedShapesSampleDocView docView = this.CurrentModelingDocView as NestedShapesSampleDocView;

      // Retrieve data from clipboard:
      System.Windows.Forms.IDataObject data = System.Windows.Forms.Clipboard.GetDataObject();

      Diagram diagram = docView.CurrentDiagram;
      if (diagram == null) return;

      if (!docView.IsContextMenuShowing)
      {
        // User hit CTRL+V - just use base method.

        // Deselect anything that's selected, otherwise
        // pasted item will be incompatible:
        if (!this.IsDiagramSelected())
        {
          docView.SelectObjects(1, new object[] { diagram }, 0);
        }

        // Paste into a convenient spare space on diagram:
    base.ProcessOnMenuPasteCommand();
      }
      else
      {
        // User right-clicked - paste at mouse position.

        // Utility class:
        DesignSurfaceElementOperations op = diagram.ElementOperations;

        ShapeElement pasteTarget = diagram;

        // Check whether what's in the paste buffer is acceptable on the target.
        if (pasteTarget != null && op.CanMerge(pasteTarget, data))
        {

        // Although op.Merge would be a no-op if CanMerge failed, we check CanMerge first
          // so that we don't create an empty transaction (after which Undo would be no-op).
          using (Transaction t = diagram.Store.TransactionManager.BeginTransaction("paste"))
          {
            PointD place = docView.ContextMenuMousePosition;
            op.Merge(pasteTarget, data, PointD.ToPointF(place));
            t.Commit();
          }
        }
      }
    }
  }
```

 **Let the user drag and drop elements.**
 See [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md).

## <a name="customizeLinks"></a> Customizing Link Copy Behavior
 When the user copies an element, the standard behavior is that any embedded elements are also copied. You can modify the standard copying behavior. In the DSL Definition, select a role at one side of a relationship and in the Properties window set the **Propagates Copy** value.

 ![Propagates Copy property of domain role](../modeling/media/dslpropagatescopy.png)

 There are three values:

- Do not propagate copy

- Propagate copy to link only - when the group is pasted, the new copy of this link will refer to the existing element at the other end of the link.

- Propagate copy to link and opposite role player - the copied group includes a copy of the element at the other end of the link.

  ![Effect of copying with PropagateCopyToLinkOnly](../modeling/media/dslpropagatecopy.png)

  The changes that you make will affect both the elements and the image that is copied.

## Programming Copy and Paste Behavior
 Many aspects of a DSL's behavior with regard to copy, paste, creation, and deletion of objects are governed by an instance of <xref:Microsoft.VisualStudio.Modeling.ElementOperations> that is coupled to the diagram. You can modify your DSL's behavior by deriving your own class from <xref:Microsoft.VisualStudio.Modeling.ElementOperations> and overriding the <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.ElementOperations%2A> property of your diagram class.

> [!TIP]
> For more information about customizing the model by using program code, see [Navigating and Updating a Model in Program Code](../modeling/navigating-and-updating-a-model-in-program-code.md).

 ![Sequence diagram for the Copy operation](../modeling/media/dslcopyseqdiagram.png)

 ![Sequence diagram of Paste operation](../modeling/media/dslpasteseqdiagram.png)

#### To define your own ElementOperations

1. In a new file in your DSL project, create a class that is derived from <xref:Microsoft.VisualStudio.Modeling.Diagrams.DesignSurfaceElementOperations>.

2. Add a partial class definition for your diagram class. The name of this class can be found in **Dsl\GeneratedCode\Diagrams.cs**.

    In the diagram class, override  <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram.ElementOperations%2A> to return an instance of your ElementOperations subclass. You should return the same instance at every call.

   Add this code in a custom code file in the DslPackage project:

```csharp

using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;

  public partial class MyDslDiagram
  {
    public override DesignSurfaceElementOperations ElementOperations
    {
      get
      {
        if (this.elementOperations == null)
        {
          this.elementOperations = new MyElementOperations(this.Store as IServiceProvider, this);
        }
        return this.elementOperations;
      }
    }
    private MyElementOperations elementOperations = null;
  }

  public class MyElementOperations : DesignSurfaceElementOperations
  {
    public MyElementOperations(IServiceProvider serviceProvider, MyDslDiagram diagram)
      : base(serviceProvider, diagram)
    { }
    // Overridden methods follow
  }
```

## Receiving items dragged from other models
 ElementOperations can also be used to define copy, move, deletion and drag-and-drop behavior. As a demonstration of the use of ElementOperations, the example given here defines custom drag-and-drop behavior. However, for that purpose you might consider the alternative approach described in [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md), which is more extensible.

 Define two methods in your ElementOperations class:

- `CanMerge(ModelElement targetElement, System.Windows.Forms.IDataObject data)` which determines whether the source element can be dragged onto the target shape, connector or diagram.

- `MergeElementGroupPrototype(ModelElement targetElement, ElementGroupPrototype sourcePrototype)` which combines the source element into the target.

### CanMerge()
 `CanMerge()` is called to determine feedback that should be given to the user as the mouse moves across the diagram. The parameters to the method are the element over which the mouse is hovering, and data about the source from which the drag operation has been performed. The user can drag from anywhere on the screen. Therefore, the source object can be of many different types and can be serialized in different formats. If the source is a DSL or UML model, the data parameter is the serialization of an <xref:Microsoft.VisualStudio.Modeling.ElementGroupPrototype>. Drag, copy and toolbox operations use ElementGroupPrototypes to represent fragments of models.

 An Element Group Prototype can contain any number of elements and links. Element types can be identified by their GUIDs. The GUID is of the shape that was dragged, not the underlying model element. In following example, `CanMerge()` returns true if a class shape from a UML diagram is dragged onto this diagram.

```csharp
public override bool CanMerge(ModelElement targetShape, System.Windows.Forms.IDataObject data)
 {
  // Extract the element prototype from the data.
  ElementGroupPrototype prototype = ElementOperations.GetElementGroupPrototype(this.ServiceProvider, data);
  if (targetShape is MyTargetShape && prototype != null &&
        prototype.RootProtoElements.Any(rootElement =>
          rootElement.DomainClassId.ToString()
          ==  "3866d10c-cc4e-438b-b46f-bb24380e1678")) // Guid of UML Class shapes
          // or SourceClass.DomainClassId
        return true;
   return base.CanMerge(targetShape, data);
 }
```

## MergeElementGroupPrototype()
 This method is called when the user drops an element onto a diagram, a shape, or a connector. It should merge the dragged content into the target element. In this example, the code determines whether it recognizes the combination of target and prototype types; if so, the method converts the dragged elements into a prototype of the elements that should be added to the model. The base method is called to perform the merge, either of the converted or unconverted elements.

```csharp
public override void MergeElementGroupPrototype(ModelElement targetShape, ElementGroupPrototype sourcePrototype)
{
  ElementGroupPrototype prototypeToMerge = sourcePrototype;
  MyTargetShape pel = targetShape as MyTargetShape;
  if (pel != null)
  {
    prototypeToMerge = ConvertDraggedTypeToLocal(pel, sourcePrototype);
  }
  if (prototypeToMerge != null)
    base.MergeElementGroupPrototype(targetShape, prototypeToMerge);
}
```

 This example deals with UML class elements dragged from a UML class diagram. The DSL is not designed to store UML classes directly, but instead, we create a DSL element for each dragged UML class. This would be useful, for example, if the DSL is an instance diagram. The user could drag classes onto the diagram to create instances of those classes.

```csharp

private ElementGroupPrototype ConvertDraggedTypeToLocal (MyTargetShape snapshot, ElementGroupPrototype prototype)
{
  // Find the UML project:
  EnvDTE.DTE dte = snapshot.Store.GetService(typeof(EnvDTE.DTE)) as EnvDTE.DTE;
  foreach (EnvDTE.Project project in dte.Solution.Projects)
  {
    IModelingProject modelingProject = project as IModelingProject;
    if (modelingProject == null) continue; // not a modeling project
    IModelStore store = modelingProject.Store;
    if (store == null) continue;
    // Look for the shape that was dragged:
    foreach (IDiagram umlDiagram in store.Diagrams())
    {
      // Get modeling diagram that implements UML diagram:
      Diagram diagram = umlDiagram.GetObject<Diagram>();
      Guid elementId = prototype.SourceRootElementIds.FirstOrDefault();
      ShapeElement shape = diagram.Partition.ElementDirectory.FindElement(elementId) as ShapeElement;
      if (shape == null) continue;
      IClass classElement = shape.ModelElement as IClass;
      if (classElement == null) continue;

      // Create a prototype of elements in my DSL, based on the UML element:
      Instance instance = new Instance(snapshot.Store);
      instance.Type = classElement.Name;
      // Pack them into a prototype:
      ElementGroup group = new ElementGroup(instance);
      return group.CreatePrototype();
    }
  }
  return null;
}
```

## Standard Copy Behavior
 The code in this section shows methods that can you can override to alter copying behavior. To help you see how to achieve your own customizations, this section shows code that overrides the methods involved in copying, but does not change the standard behavior.

 When the user presses CTRL+C or uses the Copy menu command, the method <xref:Microsoft.VisualStudio.Modeling.Shell.ClipboardCommandSet.ProcessOnMenuCopyCommand%2A> is called. You can see how this is set up in **DslPackage\Generated Code\CommandSet.cs**. For more information about how commands are set up, see [How to: Add a Command to the Shortcut Menu](../modeling/how-to-add-a-command-to-the-shortcut-menu.md).

 You can override ProcessOnMenuCopyCommand by adding a partial class definition of *MyDsl*`ClipboardCommandSet` in the DslPackage project.

```csharp
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;

partial class MyDslClipboardCommandSet
{
  /// <summary>
  /// Override ProcessOnMenuCopyCommand() to copy elements to the
  /// clipboard in different formats, or to perform additional tasks
  /// before or after copying - for example deselect the copied elements.
  /// </summary>
  protected override void ProcessOnMenuCopyCommand()
  {
    IList<ModelElement> selectedModelElements = this.SelectedElements;
    if (selectedModelElements.Count == 0) return;

    // System container for clipboard data.
    // The IDataObject can contain data in several formats.
    IDataObject dataObject = new DataObject();

    Bitmap bitmap = null; // For export to other programs.
    try
    {
      #region Create EGP for copying to a DSL.
      this.CopyModelElementsIntoElementGroupPrototype
                     (dataObject, selectedModelElements);
      #endregion

      #region Create bitmap for copying to another application.
      // Find all the shapes associated with this selection:
      List<ShapeElement> shapes = new List<ShapeElement>(
        this.ResolveExportedShapesForClipboardImages
              (dataObject, selectedModelElements));

      bitmap = this.CreateBitmapForClipboard(shapes);
      if (bitmap != null)
      {
        dataObject.SetData(DataFormats.Bitmap, bitmap);
      }
      #endregion

      // Add the data to the clipboard:
      Clipboard.SetDataObject(dataObject, true, 5, 100);
    }
    finally
    {
      // Dispose bitmap after SetDataObject:
      if (bitmap != null) bitmap.Dispose();
    }
  }
/// <summary>
/// Override this to customize the element group that is copied to the clipboard.
/// </summary>
protected override void CopyModelElementsIntoElementGroupPrototype(IDataObject dataObject, IList<ModelElement> selectedModelElements)
{
  return this.ElementOperations.Copy(dataObject, selectedModelElements);
}
}
```

 Each diagram has a singleton instance of ElementOperations. You can supply your own derivative. This file, which can be placed in the DSL project, would behave the same as the code that it overrides:

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;

namespace Company.MyDsl
{
  partial class MyDslDiagram
  {
    /// <summary>
    /// Singleton ElementOperations attached to this diagram.
    /// </summary>
    public override DesignSurfaceElementOperations ElementOperations
    {
      get
      {
        if (this.elementOperations == null)
        {
          this.elementOperations = new MyElementOperations(this.Store as IServiceProvider, this);
        }
        return this.elementOperations;
      }
    }
    private MyElementOperations elementOperations = null;
  }

  // Our own version of ElementOperations so that we can override:
  public class MyElementOperations : DesignSurfaceElementOperations
  {
    public MyElementOperations(IServiceProvider serviceProvider, ElementOps1Diagram diagram)
      : base(serviceProvider, diagram)
    { }

    /// <summary>
    /// Copy elements to the clipboard data.
    /// Provides a hook for adding custom data.
    /// </summary>
    public override void Copy(System.Windows.Forms.IDataObject data,
      ICollection<ModelElement> elements,
      ClosureType closureType,
      System.Drawing.PointF sourcePosition)
    {
      if (CanAddElementGroupFormat(elements, closureType))
      {
        AddElementGroupFormat(data, elements, closureType);
      }

      // Override these to store additional data:
      if (CanAddCustomFormat(elements, closureType))
      {
        AddCustomFormat(data, elements, closureType, sourcePosition);
      }
    }

    protected override void AddElementGroupFormat(System.Windows.Forms.IDataObject data, ICollection<ModelElement> elements, ClosureType closureType)
    {
      // Add the selected elements and those implied by the propagate copy rules:
      ElementGroup elementGroup = this.CreateElementGroup(elements, closureType);

      // Mark all the elements that are not embedded under other elements:
      this.MarkRootElements(elementGroup, elements, closureType);

      // Store in the clipboard data:
      ElementGroupPrototype elementGroupPrototype = this.CreateElementGroupPrototype(elementGroup, elements, closureType);
      data.SetData(ElementGroupPrototype.DefaultDataFormatName, elementGroupPrototype);
    }

    /// <summary>
    /// Override this to store additional elements in the element group:
    /// </summary>
    protected override ElementGroupPrototype CreateElementGroupPrototype(ElementGroup elementGroup, ICollection<ModelElement> elements, ClosureType closureType)
    {
      ElementGroupPrototype prototype = new ElementGroupPrototype(this.Partition, elementGroup.RootElements, elementGroup);
      return prototype;
    }

    /// <summary>
    /// Create an element group from the given starting elements, using the
    /// copy propagation rules specified in the DSL Definition.
    /// By default, this includes all the embedded descendants of the starting elements,
    /// and also includes reference links where both ends are already included.
    /// </summary>
    /// <param name="startElements">model elements to copy</param>
    /// <param name="closureType"></param>
    /// <returns></returns>
    protected override ElementGroup CreateElementGroup(ICollection<ModelElement> startElements, ClosureType closureType)
    {
      // ElementClosureWalker finds all the connected elements,
      // according to the propagate copy rules specified in the DSL Definition:
      ElementClosureWalker walker = new ElementClosureWalker(this.Partition,
        closureType, // Normally ClosureType.CopyClosure
        startElements,
        true, // Do not load other models.
        null, // Optional list of domain roles not to traverse.
        true); // Include relationship links where both ends are already included.

      walker.Traverse(startElements);
      IList<ModelElement> closureList = walker.ClosureList;
      Dictionary<object, object> closureContext = walker.Context;

      // create a group for this closure
      ElementGroup group = new ElementGroup(this.Partition);
      group.AddRange(closureList, false);

      // create the element group prototype for the group
      foreach (object key in closureContext.Keys)
      {
        group.SourceContext.ContextInfo[key] = closureContext[key];
      }

      return group;
    }
  }
}
```

## See also

- [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md)
- [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md)
- [Sample: VMSDK Circuit Diagrams sample](https://code.msdn.microsoft.com/Visualization-Modeling-SDK-763778e8)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]