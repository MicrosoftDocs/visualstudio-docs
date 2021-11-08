---
title: "Create custom action project item with item template, part 1"
titleSuffix: ""
description: Using an item template, create a project item that can be added to a SharePoint project to create a custom action on a SharePoint site.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint project items, creating custom templates"
  - "SharePoint project items, defining your own types"
  - "project items [SharePoint development in Visual Studio], defining your own types"
  - "SharePoint development in Visual Studio, defining new project item types"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Create a custom action project item with an item template, Part 1
  You can extend the SharePoint project system in Visual Studio by creating your own project item types. In this walkthrough, you will create a project item that can be added to a SharePoint project to create a custom action on a SharePoint site. The custom action adds a menu item to the **Site Actions** menu of the SharePoint site.

 This walkthrough demonstrates the following tasks:

- Creating a Visual Studio extension that defines a new type of SharePoint project item for a custom action. The new project item type implements several custom features:

  - A shortcut menu that serves as a starting point for additional tasks related to the project item, such as displaying a designer for the custom action in Visual Studio.

  - Code that runs when a developer changes certain properties of the project item and the project that contains it.

  - A custom icon that appears next to the project item in **Solution Explorer**.

- Creating a Visual Studio item template for the project item.

- Building a Visual Studio Extension (VSIX) package to deploy the project item template and the extension assembly.

- Debugging and testing the project item.

  This is a stand-alone walkthrough. After you complete this walkthrough, you can enhance the project item by adding a wizard to the item template. For more information, see [Walkthrough: Create a custom action project item with an item template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md).

> [!NOTE]
> You can download a sample from [Github](https://github.com/SharePoint/PnP/tree/master/Samples/Workflow.Activities) that shows how to create custom activities for a workflow.

## Prerequisites
 You need the following components on the development computer to complete this walkthrough:

- Supported editions of Microsoft Windows, SharePoint and Visual Studio.

- The [!INCLUDE[vssdk_current_long](../sharepoint/includes/vssdk-current-long-md.md)]. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the project item. For more information, see [Extend the SharePoint Tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

  Knowledge of the following concepts is helpful, but not required, to complete the walkthrough:

- Custom actions in SharePoint. For more information, see [Custom Action](/previous-versions/office/developer/sharepoint-2010/ms458635(v=office.14)).

- Item templates in Visual Studio. For more information, see [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md).

## Create the projects
 To complete this walkthrough, you need to create three projects:

- A VSIX project. This project creates the VSIX package to deploy the SharePoint project item.

- An item template project. This project creates an item template that can be used to add the SharePoint project item to a SharePoint project.

- A class library project. This project implements a Visual Studio extension that defines the behavior of the SharePoint project item.

  Start the walkthrough by creating the projects.

#### To create the VSIX project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project**.

3. In the list at the top of the **New Project** dialog box, make sure that **.NET Framework 4.5** is selected.

4. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Extensibility** node.

    > [!NOTE]
    > The **Extensibility** node is available only if you install the Visual Studio SDK. For more information, see the prerequisites section earlier in this topic.

5. Choose the **VSIX Project** template.

6. In the **Name** box, enter **CustomActionProjectItem**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **CustomActionProjectItem** project to **Solution Explorer**.

#### To create the item template project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. In the list at the top of the **New Project** dialog box, make sure that **.NET Framework 4.5** is selected.

3. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Extensibility** node.

4. In the list of project templates, choose the **C# Item Template** or **Visual Basic Item Template** template.

5. In the **Name** box, enter **ItemTemplate**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **ItemTemplate** project to the solution.

#### To create the extension project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. In the list at the top of the **New Project** dialog box, make sure that **.NET Framework 4.5** is selected.

3. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, choose the **Windows** node, and then choose the **Class Library** project template.

4. In the **Name** box, enter **ProjectItemDefinition**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **ProjectItemDefinition** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

## Configure the extension project
 Before you write code to define the SharePoint project item type, you have to add code files and assembly references to the extension project.

#### To configure the project

1. In **Solution Explorer**, open the shortcut menu for the **ProjectItemDefinition** project, choose **Add**, then choose **New Item**.

2. In the list of project items, choose **Code File**.

3. In the **Name** box, enter the name **CustomAction** with the appropriate file name extension, and then choose the **Add** button.

4. In **Solution Explorer**, open the shortcut menu for the **ProjectItemDefinition** project, and then choose **Add Reference**.

5. In the **Reference Manager - ProjectItemDefinition** dialog box, choose the **Assemblies** node, and then choose the **Framework** node.

6. Select the check box next to each of the following assemblies:

    - System.ComponentModel.Composition

    - System.Windows.Forms

7. Choose the **Extensions** node, select the check box next to the Microsoft.VisualStudio.Sharepoint assembly, and then choose the **OK** button.

## Define the new SharePoint project item type
 Create a class that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface to define the behavior of the new project item type. Implement this interface whenever you want to define a new type of project item.

#### To define the new SharePoint project item type

1. In the ProjectItemDefinition project, open the CustomAction code file.

2. Replace the code in this file with the following code.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/customactionprojectitem/projectitemtypedefinition/customaction.cs" id="Snippet1":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/customactionprojectitem/projectitemdefinition/customaction.vb" id="Snippet1":::

## Create an icon for the project item in Solution Explorer
 When you create a custom SharePoint project item, you can associate an image (an icon or bitmap) with the project item. This image appears next to the project item in **Solution Explorer**.

 In the following procedure, you create an icon for the project item and embed the icon in the extension assembly. This icon is referenced by the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemIconAttribute> of the `CustomActionProjectItemTypeProvider` class that you created earlier.

#### To create a custom icon for the project item

1. In **Solution Explorer**, open the shortcut menu for the **ProjectItemDefinition** project, choose **Add**, and then choose **New Item...**.

2. In the list of project items, choose the **Icon File** item.

    > [!NOTE]
    > In Visual Basic projects, you must choose the **General** node to display the **Icon File** item.

3. In the **Name** box, enter **CustomAction_SolutionExplorer.ico**, and then choose the **Add** button.

     The new icon opens in the **Image Editor**.

4. Edit the 16x16 version of the icon file so that it has a design you can recognize, and then save the icon file.

5. In **Solution Explorer**, choose **CustomAction_SolutionExplorer.ico**.

6. In the **Properties** window, choose the arrow next to the **Build Action** property.

7. In the list that appears, choose **Embedded Resource**.

## Checkpoint
 At this point in the walkthrough, all the code for the project item is now in the project. Build the project to verify that it compiles without errors.

#### To build your project

1. Open the shortcut menu for the **ProjectItemDefinition** project and choose **Build**.

## Create a Visual Studio item template
 To enable other developers to use your project item, you must create a project template or item template. Developers use these templates in Visual Studio to create an instance of your project item by creating a new project, or by adding an item to an existing project. For this walkthrough, use the ItemTemplate project to configure your project item.

#### To create the item template

1. Delete the Class1 code file from the ItemTemplate project.

2. In the ItemTemplate project, open the *ItemTemplate.vstemplate* file.

3. Replace the contents of the file with the following XML, and then save and close the file.

    > [!NOTE]
    > The following XML is for a Visual C# item template. If you are creating a Visual Basic item template, replace the value of the `ProjectType` element with `VisualBasic`.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <VSTemplate Version="2.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Item">
      <TemplateData>
        <DefaultName>CustomAction</DefaultName>
        <Name>Custom Action</Name>
        <Description>SharePoint Custom Action by Contoso</Description>
        <ProjectType>CSharp</ProjectType>
        <SortOrder>1000</SortOrder>
        <Icon>ItemTemplate.ico</Icon>
        <ProvideDefaultName>true</ProvideDefaultName>
      </TemplateData>
      <TemplateContent>
        <ProjectItem ReplaceParameters="true" TargetFileName="$fileinputname$\Elements.xml">Elements.xml</ProjectItem>
        <ProjectItem ReplaceParameters="true" TargetFileName="$fileinputname$\SharePointProjectItem.spdata">CustomAction.spdata</ProjectItem>
      </TemplateContent>
    </VSTemplate>
    ```

     This file defines the contents and behavior of the item template. For more information about the contents of this file, see [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md).

4. In **Solution Explorer**, open the shortcut menu for the **ItemTemplate** project, choose **Add**, and then choose **New Item**.

5. In the **Add New Item** dialog box, choose the **Text File** template.

6. In the **Name** box, enter **CustomAction.spdata**, and then choose the **Add** button.

7. Add the following XML to the *CustomAction.spdata* file, and then save and close the file.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <ProjectItem Type="Contoso.CustomAction" DefaultFile="Elements.xml"
     xmlns="http://schemas.microsoft.com/VisualStudio/2010/SharePointTools/SharePointProjectItemModel">
      <Files>
        <ProjectItemFile Source="Elements.xml" Target="$fileinputname$\" Type="ElementManifest" />
      </Files>
    </ProjectItem>
    ```

     This file contains information about the files that are contained by the project item. The `Type` attribute of the `ProjectItem` element must be set to the same string that is passed to the <xref:Microsoft.VisualStudio.SharePoint.SharePointProjectItemTypeAttribute> on the project item definition (the `CustomActionProjectItemTypeProvider` class you created earlier in this walkthrough). For more information about the contents of *.spdata* files, see [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md).

8. In **Solution Explorer**, open the shortcut menu for the **ItemTemplate** project, choose **Add**, and then choose **New Item**.

9. In the **Add New Item** dialog box, choose the **XML File** template.

10. In the **Name** box, enter **Elements.xml**, and then choose the **Add** button.

11. Replace the contents of the *Elements.xml* file with the following XML, and then save and close the file.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <Elements Id="$guid8$" xmlns="http://schemas.microsoft.com/sharepoint/">
      <CustomAction Id="Replace this with a GUID or some other unique string"
                    GroupId="SiteActions"
                    Location="Microsoft.SharePoint.StandardMenu"
                    Sequence="1000"
                    Title="Replace this with your title"
                    Description="Replace this with your description" >
        <UrlAction Url="~site/Lists/Tasks/AllItems.aspx"/>
      </CustomAction>
    </Elements>
    ```

     This file defines a default custom action that creates a menu item on the **Site Actions** menu of the SharePoint site. When a user chooses the menu item, the URL specified in the `UrlAction` element opens in the web browser. For more information about the XML elements you can use to define a custom action, see [Custom Action Definitions](/sharepoint/dev/schema/custom-action-definition-schema).

12. Optionally, open the *ItemTemplate.ico* file and modify it so that it has a design that you can recognize. This icon will display next to the project item in the **Add New Item** dialog box.

13. In **Solution Explorer**, open the shortcut menu for the **ItemTemplate** project, and then choose **Unload Project**.

14. Open the shortcut menu for the **ItemTemplate** project again, and then choose **Edit ItemTemplate.csproj** or **Edit ItemTemplate.vbproj**.

15. Locate the following `VSTemplate` element in the project file.

    ```xml
    <VSTemplate Include="ItemTemplate.vstemplate">
    ```

16. Replace this `VSTemplate` element with the following XML, and then save and close the file.

    ```xml
    <VSTemplate Include="ItemTemplate.vstemplate">
      <OutputSubPath>SharePoint\SharePoint14</OutputSubPath>
    </VSTemplate>
    ```

     The `OutputSubPath` element specifies additional folders in the path under which the item template is created when you build the project. The folders specified here ensure that the item template will be available only when customers open the **Add New Item** dialog box, expand the **SharePoint** node, and then choose the **2010** node.

17. In **Solution Explorer**, open the shortcut menu for the **ItemTemplate** project, and then choose **Reload Project**.

## Create a VSIX package to deploy the project item
 To deploy the extension, use the VSIX project in your solution to create a VSIX package. First, configure the VSIX package by modifying the source.extension.vsixmanifest file that is included in the VSIX project. Then, create the VSIX package by building the solution.

#### To configure and create the VSIX package

1. In **Solution Explorer**, open the shortcut menu for the **source.extension.vsixmanifest** file in the CustomActionProjectItem project, and then choose **Open**.

     Visual Studio opens the file in the manifest editor. The source.extension.vsixmanifest file is the basis for the extension.vsixmanifest file that all VSIX packages require. For more information about this file, see [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110)).

2. In the **Product Name** box, enter **Custom Action Project Item**.

3. In the **Author** box, enter **Contoso**.

4. In the **Description** box, enter **A SharePoint project item that represents a custom action**.

5. On the **Assets** tab, choose the **New** button.

     The **Add New Asset** dialog box appears.

6. In the **Type** list, choose **Microsoft.VisualStudio.ItemTemplate**.

    > [!NOTE]
    > This value corresponds to the `ItemTemplate` element in the extension.vsixmanifest file. This element identifies the subfolder in the VSIX package that contains the project item template. For more information, see [ItemTemplate Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393681\(v\=vs.100\)).

7. In the **Source** list, choose **A project in current solution**.

8. In the **Project** list, choose **ItemTemplate**, and then choose the **OK** button.

9. In the **Assets** tab, choose the **New** button again.

     The **Add New Asset** dialog box appears.

10. In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

    > [!NOTE]
    > This value corresponds to the `MefComponent` element in the extension.vsixmanifest file. This element specifies the name of an extension assembly in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393736\(v\=vs.100\)).

11. In the **Source** list, choose **A project in current solution**.

12. In the **Project** list, choose **ProjectItemDefinition**.

13. Choose the **OK** button.

14. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the project compiles without errors.

15. Make sure that the build output folder for the CustomActionProjectItem project contains the CustomActionProjectItem.vsix file.

     By default, the build output folder is the ..\bin\Debug folder under the folder that contains the CustomActionProjectItem project.

## Test the project item
 You are now ready to test the project item. First, start debugging the CustomActionProjectItem solution in the experimental instance of Visual Studio. Then, test the **Custom Action** project item in a SharePoint project in the experimental instance of Visual Studio. Finally, build and run the SharePoint project to verify that the custom action works as expected.

#### To start debugging the solution

1. Restart Visual Studio with administrative credentials, and then open the CustomActionProjectItem solution.

2. Open the CustomAction code file, and then add a breakpoint to the first line of code in the `InitializeType` method.

3. Choose the **F5** key to start debugging.

     Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\10.0Exp\Extensions\Contoso\Custom Action Project Item\1.0 and starts an experimental instance of Visual Studio. You'll test the project item in this instance of Visual Studio.

#### To test the project item in Visual Studio

1. In the experimental instance of Visual Studio, on the menu bar, choose **File** > **New** > **Project**.

2. Expand **Visual C#** or **Visual Basic** (depending on the language that your item template supports), expand **SharePoint**, and then choose the **2010** node.

3. In the list of project templates, choose **SharePoint 2010 Project**.

4. In the **Name** box, enter **CustomActionTest**, and then choose the **OK** button.

5. In the **SharePoint Customization Wizard**, enter the URL of the site that you want to use for debugging, and then choose the **Finish** button.

6. In **Solution Explorer**, open the shortcut menu for the project node, choose **Add**, and then choose **New Item**.

7. In the **Add New Item** dialog box, choose the **2010** node under the **SharePoint** node.

     Verify that the **Custom Action** item appears in the list of project items.

8. Choose the **Custom Action** item, and then choose the **Add** button.

     Visual Studio adds an item that's named **CustomAction1** to your project and opens the *Elements.xml* file in the editor.

9. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `InitializeType` method.

10. Choose the **F5** key to continue to debug the project.

11. In the experimental instance of Visual Studio, in **Solution Explorer**, open the shortcut menu for the **CustomAction1** node, and then choose **View Custom Action Designer**.

12. Verify that a message box appears, and then choose the **OK** button.

     You can use this shortcut menu to provide additional options or commands for developers, such as displaying a designer for the custom action.

13. On the menu bar, choose **View** > **Output**.

     The **Output** window opens.

14. In **Solution Explorer**, open the shortcut menu for the **CustomAction1** item, and then change its name to **MyCustomAction**.

     In the **Output** window, a confirmation message appears. This message is written by the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemEvents.ProjectItemNameChanged> event handler that you defined in the `CustomActionProjectItemTypeProvider` class. You can handle this event and other project item events to implement custom behavior when the developer modifies the project item.

#### To test the custom action in SharePoint

1. In the experimental instance of Visual Studio, open the *Elements.xml* file that's a child of the **MyCustomAction** project item.

2. In the *Elements.xml* file, make the following changes, and then save the file:

    - In the `CustomAction` element, set the `Id` attribute to a GUID or some other unique string as the following example shows:

        ```xml
        Id="cd85f6a7-af2e-44ab-885a-0c795b52121a"
        ```

    - In the `CustomAction` element, set the `Title` attribute as the following example shows:

        ```xml
        Title="SharePoint Developer Center"
        ```

    - In the `CustomAction` element, set the `Description` attribute as the following example shows:

        ```xml
        Description="Opens the SharePoint Developer Center Web site."
        ```

    - In the `UrlAction` element, set the `Url` attribute as the following example shows:

        ```xml
        Url="https://docs.microsoft.com/sharepoint/dev/"
        ```

3. Choose the **F5** key.

     The custom action is packaged and deployed to the SharePoint site that's specified in the **Site URL** property of the project. The web browser opens to the default page of this site.

    > [!NOTE]
    > If the **Script Debugging Disabled** dialog box appears, choose the **Yes** button to continue to debug the project.

4. On the **Site Actions** menu, choose **SharePoint Developer Center**, verify that the browser opens the website `https://docs.microsoft.com/sharepoint/dev/`, and then close the web browser.

## Clean up the development computer
 After you finish testing the project item, remove the project item template from the experimental instance of Visual Studio.

#### To clean up the development computer

1. In the experimental instance of Visual Studio, on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose **Custom Action Project Item**, and then choose the **Uninstall** button.

3. In the dialog box that appears, choose the **Yes** button to confirm that you want to uninstall the extension.

4. Choose the **Restart Now** button to complete the uninstallation.

5. Close both the experimental instance of Visual Studio and the instance in which the CustomActionProjectItem solution is open.

## Next steps
 After you complete this walkthrough, you can add a wizard to the item template. When a user adds a Custom Action project item to a SharePoint project, the wizard collects information about the action (such as its location and the URL to navigate to when the action is chosen) and adds this information to the *Elements.xml* file in the new project item. For more information, see [Walkthrough: Create a custom action project item with an item template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md).

## See also

- [Walkthrough: Create a custom action project item with an item template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md)
- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Create item templates and project templates for SharePoint project items](../sharepoint/creating-item-templates-and-project-templates-for-sharepoint-project-items.md)
- [Use the SharePoint project service](../sharepoint/using-the-sharepoint-project-service.md)
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Image Editor for Icons](/cpp/windows/image-editor-for-icons)
- [Creating an Icon or Other Image &#40;Image Editor for Icons&#41;](/cpp/windows/creating-an-icon-or-other-image-image-editor-for-icons)