---
title: "Define a menu command on a modeling diagram | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML - extending, menu commands"
ms.assetid: 79c277de-5871-4fc7-9701-55eec5c3cd46
caps.latest.revision: 63
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define a menu command on a modeling diagram
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can define additional menu items on the shortcut menus of a UML diagram. You can control whether the menu command appears and is enabled on the shortcut menu of any element on the diagram, and you can write code that runs when the user chooses the menu item. You can package these extensions into a Visual Studio Integration Extension ([VSIX](https://go.microsoft.com/fwlink/?LinkId=160780)) and distribute it to other Visual Studio users.

## Requirements
 See [Requirements](../modeling/extend-uml-models-and-diagrams.md#Requirements).

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Defining the menu command
 To create a menu command for a UML designer, you must create a class that defines the behavior of the command, and embed the class in a Visual Studio Integration Extension (VSIX). The VSIX acts as a container that can install the command. There are two alternative methods of defining a menu command:

- **Create a menu command in its own VSIX using a project template.** This is the quicker method. Use it if you do not want to combine your menu commands with other types of extension such as validation extensions, custom toolbox items, or gesture handlers.

- **Create separate menu command and VSIX projects.** Use this method if you want to combine several types of extension into the same VSIX. For example, if your menu command expects the model to observe specific constraints, you could embed it into the same VSIX as a validation method.

#### To create a menu command in its own VSIX

1. In the **New Project** dialog box, under **Modeling Projects**, select **Command Extension**.

2. Open the **.cs** file in the new project and modify the `CommandExtension` class to implement your command.

    For more information, see [Implementing the Menu Command](#Implementing).

3. You can add additional commands to this project by defining new classes.

4. Test the menu command by pressing F5. For more information, see [Executing the Menu Command](#Executing).

5. Install the menu command on another computer by copying the file **bin\\\*\\\*.vsix** that is built by your project. For more information, see [Installing and uninstalling an extension](#Installing).

   Here is the alternative procedure:

#### To create a menu command in a separate class library (DLL) project

1. Create a Class Library project, either in a new Visual Studio solution, or in an existing solution.

   1. On the **File** menu, choose **New**, **Project**.

   2. Under **Installed Templates**, select **Visual C#** or **Visual Basic**. In the middle column, choose **Class Library**.

   3. Set **Solution** to indicate whether you want to create a new solution or to add a component to a VSIX solution that you have already opened.

   4. Set the project Name and Location and click OK.

2. Add the following references to your project.

   |                                                                                                    Reference                                                                                                    |                                                                                                  What this allows you to do                                                                                                  |
   |-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |                                                                                        System.ComponentModel.Composition                                                                                        |                                         Define components by using [Managed Extensibility Framework (MEF)](https://msdn.microsoft.com/library/6c61b4ec-c6df-4651-80f1-4854f8b14dde).                                          |
   |                                                                                      Microsoft.VisualStudio.Uml.Interfaces                                                                                      |                                                                                        Read and change properties of model elements.                                                                                         |
   |                                                                             Microsoft.VisualStudio.ArchitectureTools.Extensibility                                                                              |                                                                                      Create model elements, modify shapes on diagrams.                                                                                       |
   |                                                                                  Microsoft.VisualStudio.Modeling.Sdk.[version]                                                                                  | Define model event handlers.<br /><br /> Encapsulate series of changes to your model. For more information, see [Link UML model updates by using transactions](../modeling/link-uml-model-updates-by-using-transactions.md). |
   |                                                            Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]<br /><br /> (not always required)                                                             |                                                                                   Access additional diagram elements for gesture handlers.                                                                                   |
   | Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer<br /><br /> Required only for commands on layer diagrams. For more information, see [Extend layer diagrams](../modeling/extend-layer-diagrams.md). |                                                                                             Define commands on a Layer diagram.                                                                                              |

3. Add a class file to the project and set its content to the following code.

   > [!NOTE]
   > Change the namespace, class name, and the value returned by `Text` to your preference.
   >
   >  If you define multiple commands, they appear on the menu in alphabetical order of the class names.

   ```
   using System.ComponentModel.Composition;
   using System.Linq;
   using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
   using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
   using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
   using Microsoft.VisualStudio.Uml.AuxiliaryConstructs;
   using Microsoft.VisualStudio.Uml.Classes;
       // ADD other UML namespaces if required

   namespace UMLmenu1 // CHANGE
   {
     // DELETE any of these attributes if the command
     // should not appear in some types of diagram.
     [ClassDesignerExtension]
     [ActivityDesignerExtension]
     [ComponentDesignerExtension]
     [SequenceDesignerExtension]
     [UseCaseDesignerExtension]
     // [LayerDesignerExtension]

     // All menu commands must export ICommandExtension:
     [Export (typeof(ICommandExtension))]
     // CHANGE class name – determines order of appearance on menu:
     public class Menu1 : ICommandExtension
     {
       [Import]
       public IDiagramContext DiagramContext { get; set; }

       public void QueryStatus(IMenuCommand command)
       { // Set command.Visible or command.Enabled to false
         // to disable the menu command.
         command.Visible = command.Enabled = true;
       }

       public string Text
       {
         get { return "MENU COMMAND LABEL"; }
       }

       public void Execute(IMenuCommand command)
       {
         // A selection of starting points:
         IDiagram diagram = this.DiagramContext.CurrentDiagram;
         foreach (IShape<IElement> shape in diagram.GetSelectedShapes<IElement>())
         { IElement element = shape.Element; }
         IModelStore modelStore = diagram.ModelStore;
         IModel model = modelStore.Root;
         foreach (IElement element in modelStore.AllInstances<IClass>())
         { }
       }
     }
   }
   ```

    For more information about what to put in the methods, see [Implementing the Menu Command](#Implementing).

   You must add your menu command to a VSIX project, which acts as a container for installing the command. If you want, you can include other components in the same VSIX.

#### To add a menu command to a VSIX project

1. You do not need this procedure if you have created the menu command with its own VSIX.

2. Create a VSIX project, unless your solution already has one.

    1. In **Solution Explorer**, on the shortcut menu of the solution, choose **Add**, **New Project**.

    2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then choose **Extensibility**. In the middle column, choose **VSIX Project**.

3. In Solution Explorer, on the shortcut menu of the VSIX project, choose **Set as StartUp project**.

4. Open **source.extension.vsixmanifest**.

    1. On the **MetaData** tab, set a name for the VSIX.

    2. On the **Install Targets** tab, set the Visual Studio versions as the targets.

    3. On the **Assets** tab, choose a **New**, and in the dialog box, set:

         **Type** = **MEF Component**

         **Source** = **A project in current solution**

         **Project** = *Your class library project*

## <a name="Implementing"></a> Implementing the Menu Command
 The menu command class implements the required methods for <xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement.ICommandExtension>.

|||
|-|-|
|`string Text { get; }`|Return the label of your menu item.|
|`void QueryStatus(IMenuCommand command);`|Called when the user right-clicks in the diagram.<br /><br /> This method should not change the model.<br /><br /> Use `DiagramContext.CurrentDiagram.SelectedShapes` to determine whether you want the command to appear and be enabled.<br /><br /> Set:<br /><br /> -   `command.Visible` to `true` if the command must appear in the menu when the user right-clicks in the diagram<br />-   `command.Enabled` to `true` if the user can click the command in the menu<br />-   `command.Text` to set the menu label dynamically|
|`void Execute (IMenuCommand command);`|Called when the user clicks your menu item, if it is visible and enabled.|

### Accessing the Model in Code
 Including the following declaration in your menu command class:

```
[Import] public IDiagramContext DiagramContext { get; set; }
```

 ...

 The declaration of `IDiagramContext` allows you to write code in your methods that accesses the diagram, current selection, and model:

```
IDiagram diagram = this.DiagramContext.CurrentDiagram;
foreach (IShape<IElement> shape in diagram.GetSelectedShapes<IElement>())
{ IElement element = shape.Element; ... }
IModelStore modelStore = diagram.ModelStore;
IModel model = modelStore.Root;
foreach (IElement element in modelStore.AllInstances<IUseCase>()) {...}
```

### Navigating and Updating the Model
 The elements of the UML model are all available through the API. From the current selection or from the root of the model, you can access all the other elements. For more information, see [Navigate the UML model](../modeling/navigate-the-uml-model.md) and [Programming with the UML API](../modeling/programming-with-the-uml-api.md).

 If you are dealing with a sequence diagram, see also [Edit UML sequence diagrams by using the UML API](../modeling/edit-uml-sequence-diagrams-by-using-the-uml-api.md).

 The API also allows you to change the properties of elements, delete elements and relationships, and create new elements and relationships.

 By default, each change that you make in your Execute method will be performed in a separate transaction. The user will be able to undo each change separately. If you want to group the changes into a single transaction, use a <xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement.ILinkedUndoTransaction> as described in [Link UML model updates by using transactions](../modeling/link-uml-model-updates-by-using-transactions.md).

### Use the UI Thread for Updates
 In some cases it can be useful to make updates to the model from a background thread. For example, if your command loads data from a slow resource, you can perform the loading in a brackground thread so that the user can see the changes while they are in progress, and cancel the operation if it is necessary.

 However, you should be aware that the model store is not thread safe. You should always use the user interface (UI) thread to make updates, and if it is possible, prevent the user from making edits while the background operation is in progress. For an example, see [Update a UML model from a background thread](../modeling/update-a-uml-model-from-a-background-thread.md).

## <a name="Executing"></a> Executing the Menu Command
 For test purposes, execute your command in debug mode.

#### To test the menu command

1. Press **F5**, or on the **Debug** menu, choose **Start Debugging**.

     An experimental instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] starts.

     **Troubleshooting**: If a new [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] does not start:

    - If you have more than one project, make sure that the VSIX project is set as the Startup project of the solution.

    - In Solution Explorer, on the shortcut menu of the startup or only project, choose **Properties**. In the project properties editor, select the **Debug** tab. Make sure that the string in the **Start external program** field is the full pathname of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], typically:

         `C:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\devenv.exe`

2. In the experimental [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], open or create a modeling project, and open or create a modeling diagram. Use a diagram that belongs to one of the types that are listed in the attributes of your menu command class.

3. Open the shortcut menu anywhere on the diagram. Your command should appear in the menu.

     **Troubleshooting**: If the command does not appear on the menu, make sure that:

    - The menu command project is listed as a MEF component in the **Assets** tab in **source.extensions.manifest** in the VSIX project.

    - The parameters of the `Import` and `Export` attributes are valid.

    - The `QueryStatus` method is not setting the `command`.`Enabled` or `Visible` fields to `false`.

    - The type of model diagram that you are using (UML class, sequence, and so on) is listed as one of the menu command class attributes `[ClassDesignerExtension]`, `[SequenceDesignerExtension]` and so on.

## <a name="Installing"></a> Installing and uninstalling an extension
 You can install a [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] extension both on your own computer and on other computers.

#### To install an extension

1. In your computer, find the **.vsix** file that was built by your VSIX project.

    1. In **Solution Explorer**, on the shortcut menu of the VSIX project, choose **Open Folder in Windows Explorer**.

    2. Locate the file **bin\\\*\\**_YourProject_**.vsix**

2. Copy the **.vsix** file to the target computer on which you want to install the extension. This can be your own computer or another one.

     The target computer must have one of the editions of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] that you specified in **source.extension.vsixmanifest**.

3. On the target computer, open the **.vsix** file, for example by double-clicking it.

     **Visual Studio Extension Installer** opens and installs the extension.

4. Start or restart [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)].

#### To uninstall an extension

1. On the **Tools** menu, choose **Extensions and Updates**.

2. Expand **Installed Extensions**.

3. Select the extension, and then choose **Uninstall**.

   Rarely, a faulty extension fails to load and creates a report in the error window, but does not appear in Extension Manager. In that case, you can remove the extension by deleting the file from:

   *%LocalAppData%* **\Local\Microsoft\VisualStudio\\[version]\Extensions**

## <a name="MenuExample"></a> Example
 The following example shows the code for a menu command that will interchange the names of two elements on a class diagram. This code must be built in a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension project and installed as described in the previous sections.

```
using System.Collections.Generic; // for IEnumerable
using System.ComponentModel.Composition;
  // for [Import], [Export]
using System.Linq; // for IEnumerable extensions
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
  // for IDiagramContext
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
  // for designer extension attributes
using Microsoft.VisualStudio.Modeling.Diagrams;
  // for ShapeElement
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
  // for IGestureExtension, ICommandExtension, ILinkedUndoContext
using Microsoft.VisualStudio.Uml.Classes;
  // for class diagrams, packages

/// <summary>
/// Extension to swap names of classes in a class diagram.
/// </summary>
namespace SwapClassNames
{
  // Declare the class as an MEF component:
  [Export(typeof(ICommandExtension))]
  [ClassDesignerExtension]
  // Add more ExportMetadata attributes to make
  // the command appear on diagrams of other types.
  public class NameSwapper : ICommandExtension
  {
  // MEF required interfaces:
  [Import]
  public IDiagramContext Context { get; set; }
  [Import]
  public ILinkedUndoContext LinkedUndoContext { get; set; }

  /// <summary>
  /// Swap the names of the currently selected elements.
  /// </summary>
  /// <param name="command"></param>
  public void Execute(IMenuCommand command)
  {
    // Get selected shapes that are IClassifiers -
    // IClasses, IInterfaces, IEnumerators.
    var selectedShapes = Context.CurrentDiagram
     .GetSelectedShapes<IClassifier>();
    if (selectedShapes.Count() < 2) return;

    // Get model elements displayed by shapes.
    IClassifier firstElement = selectedShapes.First().Element;
    IClassifier lastElement = selectedShapes.Last().Element;

    // Do the swap in a transaction so that user
    // cannot undo one change without the other.
    using (ILinkedUndoTransaction transaction =
    LinkedUndoContext.BeginTransaction("Swap names"))
    {
    string firstName = firstElement.Name;
    firstElement.Name = lastElement.Name;
    lastElement.Name = firstName;
    transaction.Commit();
    }
  }

  /// <summary>
  /// Called by Visual Studio to determine whether
  /// menu item should be visible and enabled.
  /// </summary>
  public void QueryStatus(IMenuCommand command)
  {
    int selectedClassifiers = Context.CurrentDiagram
     .GetSelectedShapes<IClassifier>().Count();
    command.Visible = selectedClassifiers > 0;
    command.Enabled = selectedClassifiers == 2;
  }

  /// <summary>
  /// Name of the menu command.
  /// </summary>
  public string Text
  {
    get { return "Swap Names"; }
  }
  }

}
```

## See Also
 [Define and install a modeling extension](../modeling/define-and-install-a-modeling-extension.md)
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)
 [Define a gesture handler on a modeling diagram](../modeling/define-a-gesture-handler-on-a-modeling-diagram.md)
 [Define a custom modeling toolbox item](../modeling/define-a-custom-modeling-toolbox-item.md)
 [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)
 [Edit UML sequence diagrams by using the UML API](../modeling/edit-uml-sequence-diagrams-by-using-the-uml-api.md)
 [Programming with the UML API](../modeling/programming-with-the-uml-api.md)
 [Sample: Command to Align Shapes on a UML Diagram](https://go.microsoft.com/fwlink/?LinkID=213809)
