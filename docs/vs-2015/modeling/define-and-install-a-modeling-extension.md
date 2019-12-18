---
title: "Define and install a modeling extension | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML - extending"
  - "UML model, extending"
ms.assetid: 82a58dc5-c7cf-4521-a6da-7ff09cd0de9d
caps.latest.revision: 39
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define and install a modeling extension
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can define extensions to modeling diagrams. In this manner, you can adapt the diagrams and models to your own needs. For example, you can define menu commands, UML profiles, validation constraints and toolbox items. You can define several components in a single extension. You can also distribute these extensions to other Visual Studio users in the form of a [Visual Studio Integration Extension (VSIX)](https://go.microsoft.com/fwlink/?LinkId=160780). You can create a VSIX using a VSIX project in Visual Studio.

## Requirements
 See [Requirements](../modeling/extend-uml-models-and-diagrams.md#Requirements).

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Creating a Modeling Extension Solution
 To define a modeling extension, you must create a solution containing these projects:

- A [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Integration Extension (VSIX) project. This generates a file that acts as an installer for the components of your extension.

- A class library project, required for components that include program code.

  If you want to make an extension that has several components, you can develop them in a single solution. You need only one VSIX project.

  Components that do not require code, such as custom toolbox items and custom UML profiles, can be added directly to the VSIX project without using separate class library projects. Components that require program code are more easily defined in a separate class library project. Components that require code include gesture handlers, menu commands, and validation code.

#### To create a class library project for menu commands, gesture handlers, or validation

1. On the **File** menu, choose **New**, **Project**.

2. Under **Installed Templates**, select **Visual C#** or **Visual Basic**, then choose **Class Library**.

#### To create a VSIX project

1. If you are creating a component with code, it is easiest to create the class library project first. You will add your code to that project.

2. Create a VSIX project.

    1. In **Solution Explorer**, in the shortcut menu of the solution, choose **Add**, **New Project**.

    2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then select **Extensibility**. In the middle column, choose **VSIX Project**.

3. Set the VSIX project as the startup project of the solution.

    - In Solution Explorer, on the shortcut menu of the VSIX project choose **Set as StartUp project**.

4. Open **source.extension.vsixmanifest**. The file opens in the manifest editor.

5. On the **MetaData** tab, set the name and descriptive fields of the VSIX.

6. On the **Install Targets** tab, choose **New** and set the Visual Studio versions as the targets.

7. On the **Assets** tab, add your components to the Visual Studio extension.

    1. Choose **New**.

    2. For a component with code, set these fields in the **Add New Asset** dialog box:

        |||
        |-|-|
        |**Type** =|**Microsoft.VisualStudio.MefComponent**|
        |**Source** =|**A project in current solution**|
        |**Project** =|*Your class library project*|
        |**Embed in this folder** =|*(empty)*|

         For other component types, see the links in the next section.

## Developing the Component
 For each component such as a menu command or gesture handler, you must define a separate handler. You can put several handlers in the same class library project. The following table summarizes the different kinds of handler.

|Extension type|Topic|How each component is typically declared|
|--------------------|-----------|----------------------------------------------|
|Menu Command|[Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)|`[ClassDesignerExtension]`<br /><br /> `// or other diagram types`<br /><br /> `[Export(typeof(ICommandExtension))]`<br /><br /> `public class MyCommand : ICommandExtension`<br /><br /> `{...`|
|Drag-and-drop or double-click|[Define a gesture handler on a modeling diagram](../modeling/define-a-gesture-handler-on-a-modeling-diagram.md)|`[ClassDesignerExtension]`<br /><br /> `// or other diagram types`<br /><br /> `[Export(typeof(IGestureExtension))]`<br /><br /> `public class MyGesture : IGestureExtension`<br /><br /> `{...`|
|Validation Constraint|[Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)|`[Export(typeof(     System.Action<ValidationContext, object>))]`<br /><br /> `[ValidationMethod(ValidationCategories.Save`<br /><br /> `&#124; ValidationCategories.Menu)]`<br /><br /> `public void ValidateSomething`<br /><br /> `(ValidationContext context, IClassifier elementToValidate)`<br /><br /> `{...}`|
|Work Item link event handler|[Define a work item link handler](../modeling/define-a-work-item-link-handler.md)|`[Export(typeof(ILinkedWorkItemExtension))]`<br /><br /> `public class MyWorkItemEventHandler : ILinkedWorkItemExtension`<br /><br /> `{...`|
|UML Profile|[Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)|(To be defined)|
|Toolbox Item|[Define a custom modeling toolbox item](../modeling/define-a-custom-modeling-toolbox-item.md)|(To be defined)|

## Running an Extension During its Development

#### To run an extension during its development

1. In the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] **Debug** menu, choose **Start Debugging**.

     The project builds, and a new instance of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] starts in Experimental mode.

    - Alternatively you can choose **Start Without Debugging**. This reduces the time taken to start the program.

2. Create or open a modeling project in the experimental instance of Visual Studio, and create or open a diagram.

     Your extension will load and run.

3. If you used **Start Without Debugging** but you want to use the debugger, go back to the main instance of Visual Studio. On the **Debug** menu, click **Attach to Process**. In the dialog box, select the experimental instance of Visual Studio, which has the program name **devenv**.

## <a name="Installing"></a> Installing and uninstalling an extension
 Perform the following steps to run your extension in the main instance of Visual Studio either on your own computer or on other computers.

1. In your computer, find the **.vsix** file that was built by your extension project.

    1. In **Solution Explorer**, on the shortcut menu of your project, and then choose **Open Folder in Windows Explorer**.

    2. Locate the file **bin\\\*\\**_YourProject_**.vsix**

2. Copy the **.vsix** file to the target computer on which you want to install the extension. This can be your own computer or another one.

    - The target computer must have one of the editions of Visual Studio that you specified on the **Installation Targets** tab of **source.extension.vsixmanifest**.

3. On the target computer, open the **.vsix** file, for example by double-clicking it.

     **Visual Studio Extension Installer** opens and installs the extension.

4. Start or restart Visual Studio.

#### To uninstall an extension

1. On the **Tools** menu, click **Extensions and Updates**.

2. Expand **Installed Extensions**.

3. Select the extension, and then click **Uninstall**.

   Rarely, a faulty extension fails to load and creates a report in the error window, but does not appear in Extension Manager. In that case, you can remove the extension by deleting the file from the following location where *%LocalAppData%* is typically *DriveName*:\Users\\*UserName*\AppData\Local:

   *%LocalAppData%* **\Microsoft\VisualStudio\\[version]\Extensions**

## See Also
 [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)
 [Define a custom modeling toolbox item](../modeling/define-a-custom-modeling-toolbox-item.md)
 [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)
 [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)
