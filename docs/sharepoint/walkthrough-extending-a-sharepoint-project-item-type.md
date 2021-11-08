---
title: "Walkthrough: Extending a SharePoint Project Item Type | Microsoft Docs"
description: In this walkthrough, create an extension for a SharePoint project item type, such as the business data connectivity (BDC) model project item.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "project items [SharePoint development in Visual Studio], extending"
  - "SharePoint project items, extending"
  - "SharePoint development in Visual Studio, extending project items"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Extend a SharePoint project item type
  You can use the **Business Data Connectivity Model** project item to create a model for the Business Data Connectivity (BDC) service in SharePoint. By default, when you create a model by using this project item, the data in the model is not displayed to users. You must also create an external list in SharePoint to enable users to view the data.

 In this walkthrough, you will create an extension for the **Business Data Connectivity Model** project item. Developers can use the extension to create an external list in their project that displays the data in the BDC model. This walkthrough demonstrates the following tasks:

- Creating a Visual Studio extension that performs two main tasks:

  - It generates an external list that displays the data in a BDC model. The extension uses the object model for the SharePoint project system to generate an *Elements.xml* file that defines the list. It also adds the file to the project so that it is deployed together with the BDC model.

  - It adds a shortcut menu item to the **Business Data Connectivity Model** project items in **Solution Explorer**. Developers can click this menu item to generate an external list for the BDC model.

- Building a Visual Studio Extension (VSIX) package to deploy the extension assembly.

- Testing the extension.

## Prerequisites
 You need the following components on the development computer to complete this walkthrough:

- Supported editions of Microsoft Windows, SharePoint and Visual Studio.

- The [!include[vssdk_current_long](../sharepoint/includes/vssdk-current-long-md.md)]. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the project item. For more information, see [Extend the SharePoint Tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

  Knowledge of the following concepts is helpful, but not required, to complete the walkthrough:

- The BDC service in [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)]. For more information, see [BDC Architecture](/previous-versions/office/developer/sharepoint-2010/ee558876(v=office.14)).

- The XML schema for BDC models. For more information, see [BDC Model Infrastructure](/previous-versions/office/developer/sharepoint-2010/ee556378(v=office.14)).

## Create the projects
 To complete this walkthrough, you need to create two projects:

- A VSIX project to create the VSIX package to deploy the project item extension.

- A class library project that implements the project item extension.

  Start the walkthrough by creating the projects.

#### To create the VSIX project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Extensibility** node.

    > [!NOTE]
    > The **Extensibility** node is available only if you install the Visual Studio SDK. For more information, see the prerequisites section earlier in this topic.

4. In the list at the top of the **New Project** dialog box, choose **.NET Framework 4.5**.

     SharePoint tools extensions require features in this version of the .NET Framework.

5. Choose the **VSIX Project** template.

6. In the **Name** box, enter **GenerateExternalDataLists**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **GenerateExternalDataLists** project to **Solution Explorer**.

7. If the source.extension.vsixmanifest file doesn't open automatically, open its shortcut menu in the GenerateExternalDataLists project, and then choose **Open**

8. Verify that the source.extension.vsixmanifest file has a non-blank entry (enter Contoso) for the Author field, save the file, and then close it.

#### To create the extension project

1. In **Solution Explorer**, open the shortcut menu for the **GenerateExternalDataLists** solution node, choose **Add**, and then choose **New Project**.

2. In the **Add New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Windows** node.

3. In the list at the top of the dialog box, choose **.NET Framework 4.5**.

4. In the list of project templates, choose **Class Library**.

5. In the **Name** box, enter **BdcProjectItemExtension**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **BdcProjectItemExtension** project to the solution and opens the default Class1 code file.

6. Delete the Class1 code file from the project.

## Configure the extension project
 Before you write code to create the project item extension, add code files and assembly references to the extension project.

#### To configure the project

1. In the BdcProjectItemExtension project, add two code files that have the following names:

    - ProjectItemExtension

    - GenerateExternalDataLists

2. Choose the BdcProjectItemExtension project, and then, on the menu bar, choose **Project** > **Add Reference**.

3. Under the **Assemblies** node, choose the **Framework** node, and the select the check box for each of the following assemblies:

    - System.ComponentModel.Composition

    - WindowsBase

4. Under the **Assemblies** node, choose the **Extensions** node, and then select the check box for the following assembly:

    - Microsoft.VisualStudio.SharePoint

5. Choose the **OK** button.

## Define the project item extension
 Create a class that defines the extension for the **Business Data Connectivity Model** project item. To define the extension, the class implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeExtension> interface. Implement this interface whenever you want to extend an existing type of project item.

#### To define the project item extension

1. Paste the following code into the ProjectItemExtension code file.

    > [!NOTE]
    > After you add this code, the project will have some compile errors. These errors will go away when you add code in later steps.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/generateexternaldatalists/bdcprojectitemextension/projectitemextension.cs" id="Snippet1":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/generateexternaldatalists/bdcprojectitemextension/projectitemextension.vb" id="Snippet1":::

## Create the external data lists
 Add a partial definition of the `GenerateExternalDataListsExtension` class that creates an external data list for each entity in the BDC model. To create the external data list, this code first reads the entity data in the BDC model by parsing the XML data in the BDC model file. Then, it creates a list instance that is based on the BDC model and adds this list instance to the project.

#### To create the external data lists

1. Paste the following code into the GenerateExternalDataLists code file.

     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/generateexternaldatalists/bdcprojectitemextension/generateexternaldatalists.vb" id="Snippet2":::
     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/generateexternaldatalists/bdcprojectitemextension/generateexternaldatalists.cs" id="Snippet2":::

## Checkpoint
 At this point in the walkthrough, all the code for the project item extension is now in the project. Build the solution to make sure that the project compiles without errors.

#### To build the solution

1. On the menu bar, choose **Build** > **Build Solution**.

## Create a VSIX package to deploy the project item extension
 To deploy the extension, use the VSIX project in your solution to create a VSIX package. First, configure the VSIX package by modifying the source.extension.vsixmanifest file that is included in the VSIX project. Then, create the VSIX package by building the solution.

#### To configure and create the VSIX package

1. In **Solution Explorer**, open the shortcut menu for the source.extension.vsixmanifest file in the GenerateExternalDataLists project, and then choose **Open**.

     Visual Studio opens the file in the manifest editor. The source.extension.vsixmanifest file is the basis for the extension.vsixmanifest file is required by all VSIX packages. For more information about this file, see [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110)).

2. In the **Product Name** box, enter **External Data List Generator**.

3. In the **Author** box, enter **Contoso**.

4. In the **Description** box, enter **An extension for Business Data Connectivity Model project items that can be used to generate external data lists**.

5. On the **Assets** tab of the editor, choose the **New** button.

     The **Add New Asset** dialog box appears.

6. In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

    > [!NOTE]
    > This value corresponds to the `MefComponent` element in the extension.vsixmanifest file. This element specifies the name of an extension assembly in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393736\(v\=vs.100\)).

7. In the **Source** list, choose **A project in current solution**.

8. In the **Project** list, choose **BdcProjectItemExtension**, and then choose the **OK** button.

9. On the menu bar, choose **Build** > **Build Solution**.

10. Make sure that the project compiles and builds without errors.

11. Make sure that the build output folder for the GenerateExternalDataLists project now contains the GenerateExternalDataLists.vsix file.

     By default, the build output folder is the ..\bin\Debug folder under the folder that contains your project file.

## Test the project item extension
 You are now ready to test the project item extension. First, start debugging the extension project in the experimental instance of Visual Studio. Then, use the extension in the experimental instance of Visual Studio to generate an external list for a BDC model. Finally, open the external list on the SharePoint site to verify that it works as expected.

#### To start debugging the extension

1. If necessary, restart Visual Studio with administrative credentials, and then open the GenerateExternalDataLists solution.

2. In the BdcProjectItemExtension project, open the ProjectItemExtension code file, and then add a breakpoint to the line of code in the `Initialize` method.

3. Open the GenerateExternalDataLists code file, and then add a breakpoint to the first line of code in the `GenerateExternalDataLists_Execute` method.

4. Start debugging by choosing the **F5** key or, on the menu bar, choosing **Debug** > **Start Debugging**.

     Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\10.0Exp\Extensions\Contoso\External Data List Generator\1.0 and starts an experimental instance of Visual Studio. You will test the project item in this instance of Visual Studio.

#### To test the extension

1. In the experimental instance of Visual Studio, on the menu bar, choose **File** > **New** > **Project**.

2. In the **New Project** dialog box, expand the **Templates** node, expand the **Visual C#** node, expand the **SharePoint** node, and then choose **2010**.

3. In the list at the top of the dialog box, make sure that **.NET Framework 3.5** is selected. Projects for [!INCLUDE[moss_14_long](../sharepoint/includes/moss-14-long-md.md)] require this version of the .NET Framework.

4. In the list of project templates, choose **SharePoint 2010 Project**.

5. In the **Name** box, enter **SharePointProjectTestBDC**, and then choose the **OK** button.

6. In the SharePoint Customization Wizard, enter the URL of the site that you want to use for debugging, choose **Deploy as a farm solution**, and then choose the **Finish** button.

7. Open the shortcut menu for the SharePointProjectTestBDC project, choose **Add**, and then choose **New Item**.

8. In the **Add NewItem - SharePointProjectTestBDC** dialog box, expand the installed language node, expand the **SharePoint** node.

9. Choose the **2010** node, and then choose the **Business Data Connectivity Model (Farm Solution only)** template.

10. In the **Name** box, enter **TestBDCModel**, and then choose the **Add** button.

11. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set in the `Initialize` method of the ProjectItemExtension code file.

12. In the stopped instance of Visual Studio, choose the **F5** key, or on menu bar, choose **Debug** > **Continue** to continue to debug the project.

13. In the experimental instance of Visual Studio, choose the **F5** key, or, on the menu bar, choose **Debug** > **Start Debugging** to build, deploy, and run the **TestBDCModel** project.

     The web browser opens to the default page of the SharePoint site that's specified for debugging.

14. Verify that the **Lists** section in the Quick Launch area doesn't yet contain a list that's based on the default BDC model in the project. You must first create an external data list, either by using the SharePoint user interface or by using the project item extension.

15. Close the web browser.

16. In the instance of Visual Studio that has the TestBDCModel project open, open the shortcut menu for the **TestBDCModel** node in **Solution Explorer**, and then choose **Generate External Data List**.

17. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set in the `GenerateExternalDataLists_Execute` method. Choose the **F5** key, or, on the menu bar, choose **Debug** > **Continue** to continue to debug the project.

18. The experimental instance of Visual Studio adds a list instance that's named **Entity1DataList** to the TestBDCModel project, and the instance also generates a feature that's named **Feature2** for the list instance.

19. Choose the **F5** key, or, on the menu bar, choose **Debug** > **Start Debugging** to build, deploy, and run the TestBDCModel project.

     The web browser opens to the default page of the SharePoint site that's used for debugging.

20. In the **Lists** section of the Quick Launch area, choose the **Entity1DataList** list.

21. Verify that the list contains columns that are named Identifier1 and Message, in addition to one item that has an Identifier1 value of 0 and a Message value of Hello World.

     The **Business Data Connectivity Model** project template generates the default BDC model that provides all of this data.

22. Close the web browser.

## Clean up the development computer
 After you finish testing the project item extension, remove the external list and BDC model from the SharePoint site and remove the project item extension from Visual Studio.

#### To remove the external data list from the SharePoint site

1. In the Quick Launch area of the SharePoint site, choose the **Entity1DataList** list.

2. In the Ribbon on the SharePoint site, choose the **List** tab.

3. On the **List** tab, in the **Settings** group, choose **List Settings**.

4. Under **Permissions and Management**, choose **Delete this list**, and then choose **OK** to confirm that you want to send the list to the Recycle Bin.

5. Close the web browser.

#### To remove the BDC model from the SharePoint site

1. In the experimental instance of Visual Studio, on the menu bar, choose **Build** > **Retract**.

     Visual Studio removes the BDC model from the SharePoint site.

#### To remove the project item extension from Visual Studio

1. In the experimental instance of Visual Studio, on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose **External Data List Generator**, and then choose the **Uninstall** button.

3. In the dialog box that appears, choose **Yes** to confirm that you want to uninstall the extension.

4. Choose **Restart Now** to complete the uninstallation.

5. Close both instances of Visual Studio (the experimental instance and the instance in which the GenerateExternalDataLists solution is open).

## See also
- [Extend the SharePoint project system](../sharepoint/extending-the-sharepoint-project-system.md)
- [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md)
- [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)