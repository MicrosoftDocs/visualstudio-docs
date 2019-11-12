---
title: Add commands and gestures to dependency diagrams
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "dependency diagrams, adding custom commands"
  - "dependency diagrams, adding custom gestures"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Add commands and gestures to dependency diagrams

You can define right-click menu commands and gesture handlers on dependency diagrams in Visual Studio. You can package these extensions into a Visual Studio Integration Extension (VSIX) that you can distribute to other Visual Studio users.

You can define several command and gesture handlers in the same Visual Studio project if you want. You can also combine several such projects into one VSIX. For example, you could define a single VSIX that includes layer commands, and a domain-specific language.

> [!NOTE]
> You can also customize architecture validation, in which users' source code is compared with dependency diagrams. You should define architecture validation in a separate Visual Studio project. You can add it to the same VSIX as other extensions. For more information, see [Add custom architecture validation to dependency diagrams](../modeling/add-custom-architecture-validation-to-layer-diagrams.md).

## Requirements

See [Requirements](../modeling/extend-layer-diagrams.md#requirements).

## Define a Command or Gesture in a New VSIX

The quickest method of creating an extension is to use the project template. This places the code and the VSIX manifest into the same project.

1. Create a new **Layer Designer Command Extension** or **Layer Designer Gesture Extension** project.

   The template creates a project that contains a small working example.

2. To test the extension, press **Ctrl**+**F5** or **F5**.

    An experimental instance of Visual Studio starts. In this instance, create a dependency diagram. Your command or gesture extension should work in this diagram.

3. Close the experimental instance and modify the sample code.

4. You can add more command or gesture handlers to the same project. For more information, see one of the following sections:

    [Defining a Menu Command](#command)

    [Defining a Gesture Handler](#gesture)

::: moniker range="vs-2017"

5. To install the extension in the main instance of Visual Studio, or on another computer, find the *.vsix* file in the *bin* directory. Copy it to the computer where you want to install it, and then double-click it. To uninstall it, choose **Extensions and Updates** on the **Tools** menu.

::: moniker-end

::: moniker range=">=vs-2019"

5. To install the extension in the main instance of Visual Studio, or on another computer, find the *.vsix* file in the *bin* directory. Copy it to the computer where you want to install it, and then double-click it. To uninstall it, choose **Manage Extensions** on the **Extensions** menu.

::: moniker-end

## Add a Command or Gesture to a separate VSIX

If you want to create one VSIX that contains commands, layer validators, and other extensions, we recommend that you create one project to define the VSIX, and separate projects for the handlers.

1. Create a new **Class Library** project. This project will contain command or gesture handler classes.

   > [!NOTE]
   > You can define more than one command or gesture handler class in one class library, but you should define layer validation classes in a separate class library.

2. Add or create a VSIX project in your solution. A VSIX project contains a file that's named **source.extension.vsixmanifest**.

3. In **Solution Explorer**, right-click the VSIX project and choose **Set as Startup Project**.

4. In **source.extension.vsixmanifest**, under **Assets**, add the command or gesture handler project as a MEF component.

    1. In the **Assets**.tab, choose **New**.

    2. At **Type**, select **Microsoft.VisualStudio.MefComponent**.

    3. At **Source**, select **Project in current solution** and select the name of your command or gesture handler project.

    4. Save the file.

5. Return to the command or gesture handler project and add the following project references:

   |**Reference**|**What this allows you to do**|
   |-|-|
   |Program Files\Microsoft Visual Studio [version]\Common7\IDE\Extensions\Microsoft\Architecture Tools\ExtensibilityRuntime\Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.dll|Create and edit layers|
   |Microsoft.VisualStudio.Uml.Interfaces|Create and edit layers|
   |Microsoft.VisualStudio.ArchitectureTools.Extensibility|Modify shapes on diagrams|
   |System.ComponentModel.Composition|Define components using Managed Extensibility Framework (MEF)|
   |Microsoft.VisualStudio.Modeling.Sdk.[version]|Define modeling extensions|
   |Microsoft.VisualStudio.Modeling.Sdk.Diagrams.[version]|Update shapes and diagrams|

6. Edit the class file in the C# class library project to contain the code for your extension. For more information, see one of the following sections:

     [Defining a Menu Command](#command)

     [Defining a Gesture Handler](#gesture)

7. To test the feature, press **Ctrl**+**F5** or **F5**.

   An experimental instance of Visual Studio opens. In this instance, create or open a dependency diagram.

8. To install the VSIX in the main instance of Visual Studio, or on another computer, find the **.vsix** file in the **bin** directory of the VSIX project. Copy it to the computer where you want to install the VSIX. Double-click the VSIX file in File Explorer.

## <a name="command"></a> Defining a Menu Command

You can add more menu command definitions to an existing gesture or command project. Each command is defined by a class that has the following characteristics:

- The class is declared as follows:

   `[LayerDesignerExtension]`

   `[Export(typeof(ICommandExtension))]`

   `public class`  *MyLayerCommand*  `: ICommandExtension { ... }`

- The namespace and the name of the class are unimportant.

- The methods that implement `ICommandExtension` are as follows:

  - `string Text {get;}` - The label that appears in the menu.

  - `void QueryStatus(IMenuCommand command)` - called when the user right-clicks the diagram, and determines whether the command should be visible and enabled for the user's current selection.

  - `void Execute(IMenuCommand command)` - called when the user selects the command.

- To determine the current selection, you can import `IDiagramContext`:

   `[Import]`

   `public IDiagramContext DiagramContext { get; set; }`

   `...`

   `DiagramContext.CurrentDiagram.SelectedShapes.Count()...`

To add a new command, create a new code file that contains the following sample. Then test and edit it.

```csharp
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using System.ComponentModel.Composition;
using System.Linq;

namespace MyLayerExtension // Change to your preference.
{
  // This is a feature for dependency diagrams:
  [LayerDesignerExtension]
  // This feature is a menu command:
  [Export(typeof(ICommandExtension))]
  // Change the class name to your preference:
  public class MyLayerCommand : ICommandExtension
  {
    [Import]
    public IDiagramContext DiagramContext { get; set; }

    [Import]
    public ILinkedUndoContext LinkedUndoContext { get; set; }

    // Menu command label:
    public string Text
    {
      get { return "Duplicate layers"; }
    }

    // Called when the user right-clicks the diagram.
    // Defines whether the command is visible and enabled.
    public void QueryStatus(IMenuCommand command)
    {
      command.Visible =
      command.Enabled = DiagramContext.CurrentDiagram
        .SelectedShapes.Count() > 0;
    }

    // Called when the user selects the command.
    public void Execute(IMenuCommand command)
    {
      // A selection of starting points:
      IDiagram diagram = this.DiagramContext.CurrentDiagram;
      ILayerModel lmodel = diagram.GetLayerModel();
      foreach (ILayer layer in lmodel.Layers)
      { // All layers in model.
      }
      // Updates should be performed in a transaction:
      using (ILinkedUndoTransaction t =
        LinkedUndoContext.BeginTransaction("copy selection"))
      {
        foreach (ILayer layer in
          diagram.SelectedShapes
            .Select(shape=>shape.GetLayerElement())
            .Where(element => element is ILayer))
        {
          ILayer copy = lmodel.CreateLayer(layer.Name + "+");
          // Position the shapes:
          IShape originalShape = layer.GetShape();
          copy.GetShape().Move(
            originalShape.XPosition + originalShape.Width * 1.2,
            originalShape.YPosition);
        }
        t.Commit();
      }
    }
  }
}
```

## <a name="gesture"></a> Defining a Gesture Handler

A gesture handler responds when the user drags items onto the dependency diagram, and when the user double-clicks anywhere in the diagram.

To your existing command or gesture handler VSIX project, you can add a code file that defines a gesture handler:

```csharp
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using System.ComponentModel.Composition;
using System.Linq;

namespace MyLayerExtensions // change to your preference
{
  [LayerDesignerExtension]
  [Export(typeof(IGestureExtension))]
  public class MyLayerGestureHandler : IGestureExtension
  {
  }
}
```

Notice the following points about gesture handlers:

- The members of `IGestureExtension` are as follows:

     **OnDoubleClick** - called when the user double-clicks anywhere on the diagram.

     **CanDragDrop** - called repeatedly as the user moves the mouse while dragging an item onto the diagram. It must work quickly.

     **OnDragDrop** - called when the user drops an item onto the diagram.

- The first argument to each method is an `IShape`, from which you can get the layer element. For example:

    ```csharp
    public void OnDragDrop(IShape target, IDataObject data)
    {
        ILayerElement element = target.GetLayerElement();
        if (element is ILayer)
        {
            // ...
        }
    }
    ```

- Handlers for some types of dragged item are already defined. For example, the user can drag items from Solution Explorer onto a dependency diagram. You cannot define a drag handler for these types of item. In these cases, your `DragDrop` methods will not be invoked.

## See also

- [Add custom architecture validation to dependency diagrams](../modeling/add-custom-architecture-validation-to-layer-diagrams.md)
