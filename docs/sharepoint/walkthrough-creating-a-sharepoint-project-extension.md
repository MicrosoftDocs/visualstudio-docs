---
title: "Walkthrough: Creating a SharePoint Project Extension | Microsoft Docs"
description: Create a SharePoint project extension, which you can use to respond to project-level events, such as when a project is added, deleted, or renamed.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "projects [SharePoint development in Visual Studio], extending"
  - "SharePoint development in Visual Studio, extending projects"
  - "SharePoint projects, extending"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Create a SharePoint project extension
  This walkthrough illustrates how to create an extension for SharePoint projects. You can use a project extension to respond to project-level events such as when a project is added, deleted, or renamed. You can also add custom properties or respond when a property value changes. Unlike project item extensions, project extensions cannot be associated with a particular SharePoint project type. When you create a project extension, the extension loads when any kind of SharePoint project is opened in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

 In this walkthrough, you will create a custom Boolean property that is added to any SharePoint project created in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. When set to **True**, the new property adds, or maps, an Images resource folder to your project. When set to **False**, the Images folder is removed, if it exists. For more information, see [How to: add and remove mapped folders](../sharepoint/how-to-add-and-remove-mapped-folders.md).

 This walkthrough demonstrates the following tasks:

- Creating a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension for SharePoint projects that does the following:

  - Adds a custom project property to the Properties window. The property applies to any SharePoint project.

  - Uses the SharePoint project object model to add a mapped folder to a project.

  - Uses the [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] automation object model (DTE) to delete a mapped folder from the project.

- Building a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] Extension (VSIX) package to deploy the project property's extension assembly.

- Debugging and testing the project property.

## Prerequisites
 You need the following components on the development computer to complete this walkthrough:

- Supported editions of [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)], SharePoint and [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

- The [!INCLUDE[vssdk_current_long](../sharepoint/includes/vssdk-current-long-md.md)]. This walkthrough uses the **VSIX Project** template in the [!INCLUDE[TLA2#tla_sdk](../sharepoint/includes/tla2sharptla-sdk-md.md)] to create a VSIX package to deploy the project property extension. For more information, see [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

## Create the projects
 To complete this walkthrough, you must create two projects:

- A VSIX project to create the VSIX package to deploy the project extension.

- A class library project that implements the project extension.

  Start the walkthrough by creating the projects.

#### To create the VSIX project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Extensibility** node.

    > [!NOTE]
    > This node is available only if you install the Visual Studio SDK. For more information, see the prerequisites section earlier in this topic.

4. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework, and then choose the **VSIX Project** template.

5. In the **Name** box, enter **ProjectExtensionPackage**, and then choose the **OK** button.

     The **ProjectExtensionPackage** project appears in **Solution Explorer**.

#### To create the extension project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose **Windows**.

3. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework, and then choose the **Class Library** project template.

4. In the **Name** box, enter **ProjectExtension**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **ProjectExtension** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

## Configure the project
 Before you write code to create the project extension, add code files and assembly references to the extension project.

#### To configure the project

1. Add a code file that's named **CustomProperty** to the ProjectExtension project.

2. Open the shortcut menu for the **ProjectExtension** project,  and then choose **Add Reference**.

3. In the **Reference Manager - CustomProperty** dialog box, choose the **Framework** node, and then select the check box next to the System.ComponentModel.Composition and System.Windows.Forms assemblies.

4. Choose the **Extensions** node, select the check box next to the Microsoft.VisualStudio.SharePoint and EnvDTE assemblies, and then choose the **OK** button.

5. In **Solution Explorer**, under the **References** folder for the **ProjectExtension** project, choose **EnvDTE**.

6. In the **Properties** window, change the **Embed Interop Types** property to **False**.

## Define the new SharePoint project property
 Create a class that defines the project extension and the behavior of the new project property. To define the new project extension, the class implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> interface. Implement this interface whenever you want to define an extension for a SharePoint project. Also, add the <xref:System.ComponentModel.Composition.ExportAttribute> to the class. This attribute enables [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] to discover and load your <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> implementation. Pass the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectExtension> type to the attribute's constructor.

#### To define the new SharePoint project property

1. Paste the following code into the CustomProperty code file.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/projectextension/customproperty.vb" id="Snippet1":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/projectextension/customproperty.cs" id="Snippet1":::

## Build the solution
 Next, build the solution to make sure that it compiles without errors.

#### To build the solution

1. On the menu bar, choose **Build** > **Build Solution**.

## Create a VSIX package to deploy the project property extension
 To deploy the project extension, use the VSIX project in your solution to create a VSIX package. First, configure the VSIX package by modifying the source.extension.vsixmanifest file that is included in the VSIX project. Then, create the VSIX package by building the solution.

#### To configure and create the VSIX package

1. In **Solution Explorer**, open the shortcut menu for the source.extension.vsixmanifest file, and then choose the **Open** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] opens the file in the manifest designer. The information that appears in the **Metadata** tab also appears in the **Extensions and Updates**. All VSIX packages require the extension.vsixmanifest file. For more information about this file, see [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110)).

2. In the **Product Name** box, enter **Custom Project Property**.

3. In the **Author** box, enter **Contoso**.

4. In the **Description** box, enter **A custom SharePoint project property that toggles the mapping of the Images resource folder to the project**.

5. Choose the **Assets** tab, and then choose the **New** button.

     The **Add New Asset** dialog box appears.

6. In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

    > [!NOTE]
    > This value corresponds to the `MEFComponent` element in the extension.vsixmanifest file. This element specifies the name of an extension assembly in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393736\(v\=vs.100\)).

7. In the **Source** list, choose the **A project in current solution** option button.

8. In the **Project** list, choose **ProjectExtension**.

     This value identifies the name of the assembly that you're building in the project.

9. Choose **OK** to close the **Add New Asset** dialog box.

10. On the menu bar, choose **File** > **Save All** when you finish, and then close the manifest designer.

11. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the project compiles without errors.

12. In **Solution Explorer**, open the shortcut menu for the **ProjectExtensionPackage** project, and choose the **Open Folder in File Explorer** button.

13. In **File Explorer**, open the build output folder for the ProjectExtensionPackage project, and then verify that the folder contains a file that's named ProjectExtensionPackage.vsix.

     By default, the build output folder is the ..\bin\Debug folder under the folder that contains your project file.

## Test the project property
 You're now ready to test the custom project property. It's easiest to debug and test the new project property extension in an experimental instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. This instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] is created when you run a VSIX or other extensibility project. After you debug the project, you can install the extension on your system and then continue to debug and test it in a regular instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

#### To debug and test the extension in an experimental instance of Visual Studio

1. Restart [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] with administrative credentials, and then open the ProjectExtensionPackage solution.

2. Start a debug build of your project either by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Start Debugging**.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\11.0Exp\Extensions\Contoso\Custom Project Property\1.0 and starts an experimental instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

3. In the experimental instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], create a SharePoint project for a farm solution, and use the default values for the other values in the wizard.

    1. On the menu bar, choose **File** > **New** > **Project**.

    2. At the top of the **New Project** dialog box, choose **.NET Framework 3.5** in the list of versions of the .NET Framework.

         SharePoint tool extensions require features in this version of the [!INCLUDE[dnprdnshort](../sharepoint/includes/dnprdnshort-md.md)].

    3. Under the **Templates** node, expand the **Visual C#** or **Visual Basic** node, choose the **SharePoint** node, and then choose the **2010** node.

    4. Choose the **SharePoint 2010 Project** template, and then enter **ModuleTest** as the name of your project.

4. In **Solution Explorer**, choose the **ModuleTest** project node.

     A new custom property **Map Images Folder** appears in the **Properties** window with a default value of **False**.

5. Change the value of that property to **True**.

     An Images resource folder is added to the SharePoint project.

6. Change the value of that property back to **False**.

     If you choose the **Yes** button in the **Delete the Images folder?** dialog box, the Images resource folder is deleted from the SharePoint project.

7. Close the experimental instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

## See also
- [Extend SharePoint projects](../sharepoint/extending-sharepoint-projects.md)
- [How to: Add a property to SharePoint projects](../sharepoint/how-to-add-a-property-to-sharepoint-projects.md)
- [Convert between SharePoint project system types and other Visual Studio project types](../sharepoint/converting-between-sharepoint-project-system-types-and-other-visual-studio-project-types.md)
- [Save data in extensions of the SharePoint project system](../sharepoint/saving-data-in-extensions-of-the-sharepoint-project-system.md)
- [Associate custom data with SharePoint tools extensions](../sharepoint/associating-custom-data-with-sharepoint-tools-extensions.md)