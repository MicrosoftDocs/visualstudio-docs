---
title: "Extend your DSL by using MEF | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 3e7be79a-53ab-4d79-863a-bef8d27839bd
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# Extend your DSL by using MEF
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can extend your domain-specific language (DSL) by using Managed Extensibility Framework (MEF). You or other developers will be able to write extensions for the DSL without changing the DSL definition and program code. Such extensions include menu commands, drag-and-drop handlers, and validation. Users will be able to install your DSL, and then optionally install extensions for it.

 In addition, when you enable MEF in your DSL, it can be easier for you to write some of the features of your DSL, even if they are all built together with the DSL.

 For more information about MEF, see [Managed Extensibility Framework (MEF)](https://msdn.microsoft.com/library/6c61b4ec-c6df-4651-80f1-4854f8b14dde).

### To enable your DSL to be extended by MEF

1. Create a new folder named **MefExtension** inside the **DslPackage** project. Add the following files to it:

    File name: `CommandExtensionVSCT.tt`

   > [!IMPORTANT]
   > Set the GUID in this file to be the same as the GUID CommandSetId that is defined in DslPackage\GeneratedCode\Constants.tt

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#
   // CmdSet Guid must be defined before master template is included
   // This Guid must be kept synchronized with the CommandSetId Guid in Constants.tt
   Guid guidCmdSet = new Guid ("00000000-0000-0000-0000-000000000000");
   string menuidCommandsExtensionBaseId="0x4000";
   #>
   <#@ include file="DslPackage\CommandExtensionVSCT.tt" #>
   ```

    File name: `CommandExtensionRegistrar.tt`

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#@ include file="DslPackage\CommandExtensionRegistrar.tt" #>
   ```

    File name: `ValidationExtensionEnablement.tt`

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#@ include file="DslPackage\ValidationExtensionEnablement.tt" #>
   ```

    File name: `ValidationExtensionRegistrar.tt`

    If you add this file, you must enable validation in your DSL by using at least one of the switches in **EditorValidation** in DSL Explorer.

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#@ include file="DslPackage\ValidationExtensionRegistrar.tt" #>
   ```

    File name: `PackageExtensionEnablement.tt`

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#@ include file="DslPackage\PackageExtensionEnablement.tt" #>
   ```

2. Create a new folder named **MefExtension** inside the **Dsl** project. Add the following files to it:

    File name: `DesignerExtensionMetaDataAttribute.tt`

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#@ include file="Dsl\DesignerExtensionMetadataAttribute.tt" #>
   ```

    File name: `GestureExtensionEnablement.tt`

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#@ include file="Dsl\GestureExtensionEnablement.tt" #>
   ```

    File name: `GestureExtensionController.tt`

   ```
   <#@ Dsl processor="DslDirectiveProcessor" requires="fileName='..\..\Dsl\DslDefinition.dsl'" #>
   <#@ include file="Dsl\GestureExtensionController.tt" #>
   ```

3. Add the following line to the existing file that is named **DslPackage\Commands.vsct**:

   ```
   <Include href="MefExtension\CommandExtensionVSCT.vsct"/>
   ```

    Insert the line after the existing `<Include>` directive.

4. `Open DslDefinition.dsl.`

5. In DSL Explorer, select **Editor\Validation**.

6. In the Properties window, make sure that at least one of the properties named **Uses...** is `true`.

7. In the Solution Explorer toolbar, click **Transform All Templates**.

    Subsidiary files appear underneath each of the files that you added.

8. Build and run the solution to verify that it is still working.

   Your DSL is now MEF-enabled. You can write menu commands, gestures handlers, and validation constraints as MEF extensions. You can write these extensions in your DSL solution together with other custom code. In addition, you or other developers can write separate [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extensions that extend your DSL.

## Creating an extension for a MEF-enabled DSL
 If you have access to a MEF-enabled DSL created by yourself or someone else, you can write extensions for it. The extensions can be used to add menu commands, gestures handlers, or validation constraints. To author these extensions, you use a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension (VSIX) solution. The solution has two parts: a class library project that builds the code assembly, and a VSIX project that packages the assembly.

#### To create a DSL extension VSIX

1. Create a new class library project. To do this, in the **New Project** dialog box, select **Visual Basic** or **Visual C#** and then select **Class Library**.

2. In the new class library project, add a reference to the assembly of the DSL.

   - This assembly usually has a name that ends with ".Dsl.dll".

   - If you have access to the DSL project, you can find the assembly file under the directory **Dsl\\bin\\\***

   - If you have access to the DSL VSIX file, you can find the assembly by changing the file name extension of the VSIX file to ".zip". Decompress the .zip file.

3. Add references to the following .NET assemblies:

   - Microsoft.VisualStudio.Modeling.Sdk.11.0.dll

   - Microsoft.VisualStudio.Modeling.Sdk.Diagrams.11.0.dll

   - Microsoft.VisualStudio.Modeling.Sdk.Shell.11.0.dll

   - System.ComponentModel.Composition.dll

   - System.Windows.Forms.dll

4. Create a VSIX project in the same solution. To do this, in the **New Project** dialog box, expand **Visual Basic** or **Visual C#**, click **Extensibility**, and then select **VSIX project**.

5. In Solution Explorer, right-click the VSIX project and then click **Set as StartUp Project**.

6. In the new project, open **source.extension.vsixmanifest**.

7. Click **Add Content**. In the dialog box, set **Content Type** to **MEF Component**, and **Source Project** to your class library project.

8. Add a VSIX reference to the DSL.

   1. In **source.extension.vsixmanifest**, click **Add Reference**

   2. In the dialog box, click **Add Payload** and then locate the VSIX file of the DSL. The VSIX file is built in the DSL solution, in **DslPackage\\bin\\\***.

       This lets users install the DSL and your extension at the same time. If the user has already installed the DSL, only your extension will be installed.

9. Review and update the other fields of **source.extension.vsixmanifest**. Click **Select Editions** and verify that the correct [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] editions are set.

10. Add code to the class library project. Use the examples in the next section as a guide.

     You can add any number of command, gesture, and validation classes.

11. To test the extension, press **F5**. In the experimental instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], create or open an example file of the DSL.

## Writing MEF extensions for DSLs
 You can write extensions in the assembly code project of a separate DSL extension solution. You can also use MEF in your DslPackage project, as a convenient way to write commands, gestures, and validation code as part of the DSL.

### Menu Commands
 To write a menu command, define a class that implements <xref:Microsoft.VisualStudio.Modeling.ExtensionEnablement.ICommandExtension> and prefix the class with the attribute that is defined in your DSL, named *YourDsl*`CommandExtension`. You can write more than one menu command class.

 `QueryStatus()` is called whenever the user right-clicks the diagram. It should inspect the current selection and set `command.Enabled` to indicate when the command is applicable.

```
using System.ComponentModel.Composition;
using System.Linq;
using Company.MyDsl; // My DSL
using Company.MyDsl.ExtensionEnablement; // My DSL
using Microsoft.VisualStudio.Modeling; // Transactions
using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement; // IVsSelectionContext
using Microsoft.VisualStudio.Modeling.ExtensionEnablement; // ICommandExtension

namespace MyMefExtension
{
  // Defined in Dsl\MefExtension\DesignerExtensionMetaDataAttribute.cs:
  [MyDslCommandExtension]
  public class MyCommandClass : ICommandExtension
  {
    /// <summary>
    /// Provides access to current document and selection.
    /// </summary>
    [Import]
    IVsSelectionContext SelectionContext { get; set; }

    /// <summary>
    /// Called when the user selects this command.
    /// </summary>
    /// <param name="command"></param>
    public void Execute(IMenuCommand command)
    {
      // Transaction is required if you want to update elements.
      using (Transaction t = SelectionContext.CurrentStore
              .TransactionManager.BeginTransaction("fix names"))
      {
        foreach (ExampleShape shape in SelectionContext.CurrentSelection)
        {
          ExampleElement element = shape.ModelElement as ExampleElement;
          element.Name = element.Name + " !";
        }
        t.Commit();
      }
    }

    /// <summary>
    /// Called when the user right-clicks the diagram.
    /// Determines whether the command should appear.
    /// This method should set command.Enabled and command.Visible.
    /// </summary>
    /// <param name="command"></param>
    public void QueryStatus(IMenuCommand command)
    {
      command.Enabled =
        command.Visible = (SelectionContext.CurrentSelection.OfType<ExampleShape>().Count() > 0);
    }

    /// <summary>
    /// Called when the user right-clicks the diagram.
    /// Determines the text of the command in the menu.
    /// </summary>
    public string Text
    {
      get { return "My menu command"; }
    }
  }
}

```

### Gesture Handlers
 A gesture handler can deal with objects dragged onto the diagram from anywhere, inside or outside [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. The following example lets the user drag files from Windows Explorer onto the diagram. It creates elements that contain the file names.

 You can write handlers to deal with drags from other DSL models and UML models. For more information, see [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md).

```

using System.ComponentModel.Composition;
using System.Linq;
using Company.MyDsl;
using Company.MyDsl.ExtensionEnablement;
using Microsoft.VisualStudio.Modeling; // Transactions
using Microsoft.VisualStudio.Modeling.Diagrams;
using Microsoft.VisualStudio.Modeling.Diagrams.ExtensionEnablement;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;

namespace MefExtension
{
  [MyDslGestureExtension]
  class MyGestureExtension : IGestureExtension
  {
    public void OnDoubleClick(ShapeElement targetElement, DiagramPointEventArgs diagramPointEventArgs)
    {
      System.Windows.Forms.MessageBox.Show("double click!");
    }

    /// <summary>
    /// Called when the user drags anything over the diagram.
    /// Return true if the dragged object can be dropped on the current target.
    /// </summary>
    /// <param name="targetMergeElement">The shape or diagram that the mouse is currently over</param>
    /// <param name="diagramDragEventArgs">Data about the dragged element.</param>
    /// <returns></returns>
    public bool CanDragDrop(ShapeElement targetMergeElement, DiagramDragEventArgs diagramDragEventArgs)
    {
      // This handler only allows items to be dropped onto the diagram:
      return targetMergeElement is MefDsl2Diagram &&
      // And only accepts files dragged from Windows Explorer:
        diagramDragEventArgs.Data.GetFormats().Contains("FileNameW");
    }

    /// <summary>
    /// Called when the user drops an item onto the diagram.
    /// </summary>
    /// <param name="targetDropElement"></param>
    /// <param name="diagramDragEventArgs"></param>
    public void OnDragDrop(ShapeElement targetDropElement, DiagramDragEventArgs diagramDragEventArgs)
    {
      MefDsl2Diagram diagram = targetDropElement as MefDsl2Diagram;
      if (diagram == null) return;

      // This handler only accepts files dragged from Windows Explorer:
      string[] draggedFileNames = diagramDragEventArgs.Data.GetData("FileNameW") as string[];
      if (draggedFileNames == null || draggedFileNames.Length == 0) return;

      using (Transaction t = diagram.Store.TransactionManager.BeginTransaction("file names"))
      {
        // Create an element to represent each file:
        foreach (string fileName in draggedFileNames)
        {
          ExampleElement element = new ExampleElement(diagram.ModelElement.Partition);
          element.Name = fileName;

          // This method of adding the new element allows the position
          // of the shape to be specified:
          ElementGroup group = new ElementGroup(element);
          diagram.ElementOperations.MergeElementGroupPrototype(
            diagram, group.CreatePrototype(), PointD.ToPointF(diagramDragEventArgs.MousePosition));
        }
        t.Commit();
      }
    }
  }
}

```

### Validation constraints
 Validation methods are marked by the `ValidationExtension` attribute that is generated by the DSL, and also by <xref:Microsoft.VisualStudio.Modeling.Validation.ValidationMethodAttribute>. The method can appear in any class that is not marked by an attribute.

 For more information, see [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md).

```
using Company.MyDsl;
using Company.MyDsl.ExtensionEnablement;
using Microsoft.VisualStudio.Modeling.Validation;

namespace MefExtension
{
  class MyValidationExtension // Can be any class.
  {
    // SAMPLE VALIDATION METHOD.
    // All validation methods have the following attributes.

    // Specific to the extended DSL:
    [MyDslValidationExtension]

    // Determines when validation is applied:
    [ValidationMethod(
       ValidationCategories.Save
     | ValidationCategories.Open
     | ValidationCategories.Menu)]

    /// <summary>
    /// When validation is executed, this method is invoked
    /// for every element in the model that is an instance
    /// of the second parameter type.
    /// </summary>
    /// <param name="context">For reporting errors</param>
    /// <param name="elementToValidate"></param>
    private void ValidateClassNames
      (ValidationContext context,
       // Type determines to what elements this will be applied:
       ExampleElement elementToValidate)
    {
      // Write code here to test values and links.
      if (elementToValidate.Name.IndexOf(' ') >= 0)
      {
        // Log any unacceptable values:
        context.LogError(
          // Description:
          "Name must not contain spaces"
          // Error code unique to this type of error:
          , "MyDsl001"
          // Element to highlight when user double-clicks error:
          , elementToValidate);
} } } }

```

## See Also
 [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md)
 [Managed Extensibility Framework (MEF)](https://msdn.microsoft.com/library/6c61b4ec-c6df-4651-80f1-4854f8b14dde)
 [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md)
 [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md)
