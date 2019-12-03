---
title: "Define a gesture handler on a modeling diagram | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML - extending, double-click"
  - "UML - extending, drag and drop"
ms.assetid: e5e1d70a-3539-4321-a3b1-89e86e4d6430
caps.latest.revision: 36
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define a gesture handler on a modeling diagram
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can define commands that are performed when the user double-clicks or drags items onto a UML diagram. You can package these extensions into a Visual Studio Integration Extension ([VSIX](https://go.microsoft.com/fwlink/?LinkId=160780)) and distribute it to other Visual Studio users.

 If there is already a built-in behavior for the type of diagram and the type of element that you want to drag, you might not be able to add to or override this behavior.

## Requirements
 See [Requirements](../modeling/extend-uml-models-and-diagrams.md#Requirements).

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Creating a Gesture Handler
 To define a gesture handler for a UML designer, you must create a class that defines the behavior of the gesture handler, and embed that class in a Visual Studio Integration Extension (VSIX). The VSIX acts as a container that can install the handler. There are two alternative methods of defining a gesture handler:

- **Create a gesture handler in its own VSIX using a project template.** This is the quicker method. Use it if you do not want to combine your handler with other types of extension such as validation extensions, custom toolbox items, or menu commands.

- **Create separate gesture handler and VSIX projects.** Use this method if you want to combine several types of extension into the same VSIX. For example, if your gesture handler expects the model to observe specific constraints, you could embed it into the same VSIX as a validation method.

#### To create a gesture handler in its own VSIX

1. In the **New Project** dialog box, under **Modeling Projects**, select **Gesture Extension**.

2. Open the **.cs** file in the new project and modify the `GestureExtension` class to implement your gesture handler.

    For more information, see [Implementing the Gesture Handler](#Implementing).

3. Test the gesture handler by pressing F5. For more information, see [Executing the Gesture Handler](#Executing).

4. Install the gesture handler on another computer by copying the file **bin\\\*\\\*.vsix** that is built by your project. For more information, see [Installing and uninstalling an extension](#Installing).

   Here is the alternative procedure:

#### To create a separate class library (DLL) project for the gesture handler

1. Create a Class Library project, either in a new [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution, or in an existing solution.

   1. On the **File** menu, choose **New**, **Project**.

   2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then in the middle column choose **Class Library**.

2. Add the following references to your project.

    `Microsoft.VisualStudio.Modeling.Sdk.[version]`

    `Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]`

    `Microsoft.VisualStudio.ArchitectureTools.Extensibility`

    `Microsoft.VisualStudio.Uml.Interfaces`

    `System.ComponentModel.Composition`

    `System.Windows.Forms`

    `Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer` – You need this only if you are extending Layer diagrams. For more information, see [Extend layer diagrams](../modeling/extend-layer-diagrams.md).

3. Add a class file to the project and set its content to the following code.

   > [!NOTE]
   > Change the namespace and class name according to your preference.

   ```
   using System.ComponentModel.Composition;
   using System.Linq;
   using System.Collections.Generic;
   using Microsoft.VisualStudio.Modeling.Diagrams;
   using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;
   using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
   using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
   using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
   using Microsoft.VisualStudio.Uml.AuxiliaryConstructs;
   using Microsoft.VisualStudio.Modeling;
   using Microsoft.VisualStudio.Uml.Classes;
   // ADD other UML namespaces if required

   namespace MyGestureHandler // CHANGE
   {
     // DELETE any of these attributes if the handler
     // should not work with some types of diagram.
     [ClassDesignerExtension]
     [ActivityDesignerExtension]
     [ComponentDesignerExtension]
     [SequenceDesignerExtension]
     [UseCaseDesignerExtension]
     // [LayerDesignerExtension]

     // Gesture handlers must export IGestureExtension:
     [Export(typeof(IGestureExtension))]
     // CHANGE class name
     public class MyGesture1 : IGestureExtension
     {
       [Import]
       public IDiagramContext DiagramContext { get; set; }

       /// <summary>
       /// Called when the user double-clicks on the diagram
       /// </summary>
       /// <param name="targetElement"></param>
       /// <param name="diagramPointEventArgs"></param>
       public void OnDoubleClick(ShapeElement targetElement, DiagramPointEventArgs diagramPointEventArgs)
       {
         // CHANGE THIS CODE FOR YOUR APPLICATION.

         // Get the target shape, if any. Null if the target is the diagram.
         IShape targetIShape = targetElement.CreateIShape();

         // Do something...
       }

       /// <summary>
       /// Called repeatedly when the user drags from anywhere on the screen.
       /// Return value should indicate whether a drop here is allowed.
       /// </summary>
       /// <param name="targetMergeElement">References the element to be dropped on.</param>
       /// <param name="diagramDragEventArgs">References the element to be dropped.</param>
       /// <returns></returns>
       public bool CanDragDrop(ShapeElement targetMergeElement, DiagramDragEventArgs diagramDragEventArgs)
       {
         // CHANGE THIS CODE FOR YOUR APPLICATION.

         // Get the target element, if any. Null if the target is the diagram.
         IShape targetIShape = targetMergeElement.CreateIShape();

         // This example allows drag of any UML elements.
         return GetModelElementsFromDragEvent(diagramDragEventArgs).Count() > 0;
       }

       /// <summary>
       /// Execute the action to be performed on the drop.
       /// </summary>
       /// <param name="targetDropElement"></param>
       /// <param name="diagramDragEventArgs"></param>
       public void OnDragDrop(ShapeElement targetDropElement, DiagramDragEventArgs diagramDragEventArgs)
       {
         // CHANGE THIS CODE FOR YOUR APPLICATION.
       }

       /// <summary>
       /// Retrieves UML IElements from drag arguments.
       /// Works for drags from UML diagrams.
       /// </summary>
       private IEnumerable<IElement> GetModelElementsFromDragEvent
               (DiagramDragEventArgs dragEvent)
       {
         //ElementGroupPrototype is the container for
         //dragged and copied elements and toolbox items.
         ElementGroupPrototype prototype =
            dragEvent.Data.
            GetData(typeof(ElementGroupPrototype))
                 as ElementGroupPrototype;
         // Locate the originals in the implementation store.
         IElementDirectory implementationDirectory =
            dragEvent.DiagramClientView.Diagram.Store.ElementDirectory;

         return prototype.ProtoElements.Select(
           prototypeElement =>
           {
             ModelElement element = implementationDirectory
               .FindElement(prototypeElement.ElementId);
             ShapeElement shapeElement = element as ShapeElement;
             if (shapeElement != null)
             {
               // Dragged from a diagram.
               return shapeElement.ModelElement as IElement;
             }
             else
             {
               // Dragged from UML Model Explorer.
               return element as IElement;
             }
           });
       }

     }
   }

   ```

    For more information about what to put in the methods, see [Implementing the Gesture Handler](#Implementing).

   You must add your menu command to a VSIX project, which acts as a container for installing the command. If you want, you can include other components in the same VSIX.

#### To add a separate gesture handler to a VSIX project

1. You do not need this procedure if you have created the gesture handler with its own VSIX.

2. Create a VSIX project, unless your solution already has one.

    1. In **Solution Explorer**, on the shortcut menu of the solution, choose **Add**, **New Project**.

    2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then select **Extensibility**. In the middle column, choose **VSIX Project**.

3. Set the VSIX project as the startup project of the solution.

    - In Solution Explorer, in the shortcut menu of the VSIX project, choose **Set as StartUp project**.

4. In **source.extension.vsixmanifest**, add the gesture handler class library project as a MEF Component:

    1. On the **MetaData** tab, set a name for the VSIX.

    2. On the **Install Targets** tab, set the Visual Studio versions as the targets.

    3. On the **Assets** tab, choose a **New**, and in the dialog box, set:

         **Type** = **MEF Component**

         **Source** = **A project in current solution**

         **Project** = *Your class library project*

## <a name="Executing"></a> Executing the Gesture Handler
 For test purposes, execute your gesture handler in debug mode.

#### To test the gesture handler

1. Press **F5**, or on the **Debug** menu, click **Start Debugging**.

    An experimental instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] starts.

    **Troubleshooting**: If a new [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] does not start:

   - If you have more than one project, make sure that the VSIX project is set as the Startup project of the solution.

   - In Solution Explorer, on the shortcut menu of the startup or only project, choose Properties. In the project properties editor, choose the **Debug** tab. Make sure that the string in the **Start external program** field is the full pathname of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], typically:

        `C:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\devenv.exe`

2. In the experimental [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], open or create a modeling project, and open or create a modeling diagram. Use a diagram that belongs to one of the types listed in the attributes of your gesture handler class.

3. Double-click anywhere on the diagram. Your double-click handler should be called.

4. Drag an element from UML Explorer onto the diagram. Your drag handler should be called.

   **Troubleshooting**: If the gesture handler does not work, make sure that:

- The gesture handler project is listed as a MEF component in the **Assets** tab in **source.extensions.manifest** in the VSIX project.

- The parameters of all the `Import` and `Export` attributes are valid.

- The `CanDragDrop` method is not returning `false`.

- The type of model diagram you are using (UML class, sequence, and so on) is listed as one of the gesture handler class attributes [ClassDesignerExtension], [SequenceDesignerExtension] and so on.

- There is no built-in functionality already defined for this type of target and dropped element.

## <a name="Implementing"></a> Implementing the Gesture Handler

### The Gesture Handler Methods
 The gesture handler class implements and exports <xref:Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement.IGestureExtension>. The methods you need to define are as follows:

|||
|-|-|
|`bool CanDragDrop (ShapeElement target, DiagramDragEventArgs dragEvent)`|Return `true` to allow the source element referenced in `dragEvent` to be dropped on this target.<br /><br /> This method should not make changes to the model. It should work quickly, because it is used to determine the arrow state as the user moves the mouse.|
|`void OnDragDrop (ShapeElement target, DiagramDragEventArgs dragEvent)`|Update the model based on the source object referenced in `dragEvent`, and the target.<br /><br /> Called when the user releases the mouse after dragging.|
|`void OnDoubleClick (ShapeElement target, DiagramPointEventArgs pointEvent)`|`target` is the shape that the user double-clicked.|

 You can write handlers that can accept not only UML also a wide variety of other items, such as files, nodes in a .NET class view, and so on. The user can drag any of these items onto a UML diagram, provided you write an `OnDragDrop` method that can decode the serialized form of the items. The decoding methods vary from one type of item to another.

 The parameters of these methods are:

- `ShapeElement target`. The shape or diagram onto which the user has dragged something.

    `ShapeElement` is a class in the implementation that underlies the UML modeling tools. To reduce the risk of putting the UML model and diagrams into an inconsistent state, we recommend that you do not use the methods of this class directly. Instead, wrap the element in an `IShape`, and then use the methods described in [Display a UML model on diagrams](../modeling/display-a-uml-model-on-diagrams.md).

  - To obtain an `IShape`:

      ```
      IShape targetIShape = target.CreateIShape(target);
      ```

  - To obtain the model element that is targeted by the drag or double-click operation:

      ```
      IElement target = targetIShape.Element;
      ```

      You can cast this to a more specific type of element.

  - To obtain the UML model store that contains the UML model:

      ```
      IModelStore modelStore =
        targetIShape.Element.GetModelStore(); 
      ```

  - To obtain access to the host and service provider:

      ```
      target.Store.GetService(typeof(EnvDTE.DTE)) as EnvDTE.DTE
      ```

- `DiagramDragEventArgs eventArgs`. This parameter carries the serialized form of the source object of a drag operation:

    ```
    System.Windows.Forms.IDataObject data = eventArgs.Data;
    ```

     You can drag elements of many different kinds onto a diagram, from different parts of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], or from the Windows desktop. Different types of element are encoded in different ways in `IDataObject`. To extract the elements from it, refer to the documentation for the appropriate type of object.

     If your source object is a UML element dragged from UML Model Explorer or from another UML diagram, refer to [Get UML model elements from IDataObject](../modeling/get-uml-model-elements-from-idataobject.md).

### Writing the code of the methods
 For more information about writing the code to read and update the model, see [Programming with the UML API](../modeling/programming-with-the-uml-api.md).

 For information about accessing model information in a drag operation, see [Get UML model elements from IDataObject](../modeling/get-uml-model-elements-from-idataobject.md).

 If you are dealing with a sequence diagram, see also [Edit UML sequence diagrams by using the UML API](../modeling/edit-uml-sequence-diagrams-by-using-the-uml-api.md).

 In addition to the parameters of the methods, you can also declare an imported property in your class that provides access to the current diagram and model.

```
[Import] public IDiagramContext DiagramContext { get; set; }
```

 The declaration of `IDiagramContext` allows you to write code in your methods that accesses the diagram, current selection, and model:

```
IDiagram diagram = this.DiagramContext.CurrentDiagram;
foreach (IShape<IElement> shape in diagram.GetSelectedShapes<IElement>)
{ IElement element = shape.Element; ... }
IModelStore modelStore = diagram.ModelStore;
IModel model = modelStore.Root;
foreach (IDiagram diagram in modelStore.Diagrams) {...}
foreach (IElement element in modelStore.AllInstances<IUseCase>) {...}
```

 For more information, see [Navigate the UML model](../modeling/navigate-the-uml-model.md).

## <a name="Installing"></a> Installing and uninstalling an extension
 You can install a [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] extension both on your own computer and on other computers.

#### To install an extension

1. In your computer, find the **.vsix** file that was built by your VSIX project.

    1. In **Solution Explorer**, on the shortcut menu of the VSIX project, choose **Open Folder in Windows Explorer**.

    2. Locate the file **bin\\\*\\**_YourProject_**.vsix**

2. Copy the **.vsix** file to the target computer on which you want to install the extension. This can be your own computer or another one.

     The target computer must have one of the editions of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] that you specified in **source.extension.vsixmanifest**.

3. On the target computer, open the **.vsix** file.

     **Visual Studio Extension Installer** opens and installs the extension.

4. Start or restart [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)].

#### To uninstall an extension

1. On the **Tools** menu, choose **Extensions and Updates**.

2. Expand **Installed Extensions**.

3. Select the extension, and then choose **Uninstall**.

   Rarely, a faulty extension fails to load and creates a report in the error window, but does not appear in Extension Manager. In that case, you can remove the extension by deleting the file from:

   *%LocalAppData%* **\Local\Microsoft\VisualStudio\\[version]\Extensions**

## <a name="DragExample"></a> Example
 The following sample shows how to create lifelines in a sequence diagram, based on the parts and ports of a component, dragged from a component diagram.

 To test it, press F5. An experimental instance of Visual Studio opens. In this instance, open a UML model and create a component on a component diagram. Add to this component some interfaces and internal component parts. Select the interfaces and parts. Then drag the interfaces and parts onto a sequence diagram. (Drag from the component diagram up to the tab for the sequence diagram, and then down into the sequence diagram.) A lifeline will appear for each interface and part.

 For more information about binding interactions to sequence diagrams, see [Edit UML sequence diagrams by using the UML API](../modeling/edit-uml-sequence-diagrams-by-using-the-uml-api.md).

```
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.Uml.AuxiliaryConstructs;
using Microsoft.VisualStudio.Uml.Classes;
using Microsoft.VisualStudio.Uml.Interactions;
using Microsoft.VisualStudio.Uml.CompositeStructures;
using Microsoft.VisualStudio.Uml.Components;

/// <summary>
/// Creates lifelines from component ports and parts.
/// </summary>
[Export(typeof(IGestureExtension))]
[SequenceDesignerExtension]
public class CreateLifelinesFromComponentParts : IGestureExtension
{
  [Import]
  public IDiagramContext Context { get; set; }

  /// <summary>
  /// Called by the modeling framework when
  /// the user drops something on a target.
  /// </summary>
  /// <param name="target">The target shape or diagram </param>
  /// <param name="dragEvent">The item being dragged</param>
  public void OnDragDrop(ShapeElement target,
           DiagramDragEventArgs dragEvent)
  {
    ISequenceDiagram diagram = Context.CurrentDiagram
            as ISequenceDiagram;
    IInteraction interaction = diagram.Interaction;
    if (interaction == null)
    {
      // Sequence diagram is empty: create an interaction.
      interaction = diagram.ModelStore.Root.CreateInteraction();
      interaction.Name = Context.CurrentDiagram.Name;
      diagram.Bind(interaction);
    }
    foreach (IConnectableElement connectable in
       GetConnectablesFromDrag(dragEvent))
    {
      ILifeline lifeline = interaction.CreateLifeline();
      lifeline.Represents = connectable;
      lifeline.Name = connectable.Name;
    }
  }

  /// <summary>
  /// Called by the modeling framework to determine whether
  /// the user can drop something on a target.
  /// Must not change anything.
  /// </summary>
  /// <param name="target">The target shape or diagram</param>
  /// <param name="dragEvent">The item being dragged</param>
  /// <returns>true if this item can be dropped on this target</returns>
  public bool CanDragDrop(ShapeElement target,
           DiagramDragEventArgs dragEvent)
  {
    IEnumerable<IConnectableElement> connectables = GetConnectablesFromDrag(dragEvent);
    return connectables.Count() > 0;
  }

  ///<summary>
  /// Get dragged parts and ports of an IComponent.
  ///</summary>
  private IEnumerable<IConnectableElement>
    GetConnectablesFromDrag(DiagramDragEventArgs dragEvent)
  {
    foreach (IElement element in
      GetModelElementsFromDragEvent(dragEvent))
    {
      IConnectableElement part = element as IConnectableElement;
      if (part != null)
      {
        yield return part;
      }
    }
  }

  /// <summary>
  /// Retrieves UML IElements from drag arguments.
  /// Works for drags from UML diagrams.
  /// </summary>
  private IEnumerable<IElement> GetModelElementsFromDragEvent
          (DiagramDragEventArgs dragEvent)
  {
    //ElementGroupPrototype is the container for
    //dragged and copied elements and toolbox items.
    ElementGroupPrototype prototype =
       dragEvent.Data.
       GetData(typeof(ElementGroupPrototype))
            as ElementGroupPrototype;
    // Locate the originals in the implementation store.
    IElementDirectory implementationDirectory =
       dragEvent.DiagramClientView.Diagram.Store.ElementDirectory;

    return prototype.ProtoElements.Select(
      prototypeElement =>
      {
        ModelElement element = implementationDirectory
          .FindElement(prototypeElement.ElementId);
        ShapeElement shapeElement = element as ShapeElement;
        if (shapeElement != null)
        {
          // Dragged from a diagram.
          return shapeElement.ModelElement as IElement;
        }
        else
        {
          // Dragged from UML Model Explorer.
          return element as IElement;
        }
      });
  }

  public void OnDoubleClick(ShapeElement targetElement, DiagramPointEventArgs diagramPointEventArgs)
  {
  }
}

```

 The code of `GetModelElementsFromDragEvent()` is described in [Get UML model elements from IDataObject](../modeling/get-uml-model-elements-from-idataobject.md).

## See Also
 [Define and install a modeling extension](../modeling/define-and-install-a-modeling-extension.md)
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)
 [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)
 [Programming with the UML API](../modeling/programming-with-the-uml-api.md)
