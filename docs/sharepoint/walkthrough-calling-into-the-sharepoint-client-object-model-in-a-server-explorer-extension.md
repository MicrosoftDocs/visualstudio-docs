---
title: "Server Explorer: Extending the SharePoint Connections node"
titleSuffix: ""
description: In this walkthrough, see how to call the SharePoint client object model from an extension for the SharePoint Connections node in Server Explorer.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, client object model"
  - "SharePoint commands [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Walkthrough: Calling into the SharePoint client object model in a Server Explorer extension
  This walkthrough demonstrates how to call the SharePoint client object model from an extension for the **SharePoint Connections** node in **Server Explorer**. For more information about how to use the SharePoint client object model, see [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md).

 This walkthrough demonstrates the following tasks:

- Creating a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] extension that extends the **SharePoint Connections** node of **Server Explorer** in the following ways:

  - The extension adds a **Web Part Gallery** node under each SharePoint site node in **Server Explorer**. This new node contains child nodes that represent each Web Part in the Web Part gallery on the site.

  - The extension defines a new type of node that represents a Web Part instance. This new node type is the basis for the child nodes under the new **Web Part Gallery** node. The new Web Part node type displays information in the **Properties** window about the Web Part that the node represents.

- Building a Visual Studio Extension (VSIX) package to deploy the extension.

- Debugging and testing the extension.

> [!NOTE]
> The extension that you create in this walkthrough resembles the extension that you create in [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md). That walkthrough uses the SharePoint server object model, but this walkthrough accomplishes the same tasks by using the client object model.

## Prerequisites
 You need the following components on the development computer to complete this walkthrough:

- Supported editions of Windows, SharePoint, and Visual Studio.

- The Visual Studio SDK. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the extension. For more information, see [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

Knowledge of the following concepts is helpful, but not required, to complete the walkthrough:

- Using the SharePoint client object model. For more information, see [Managed Client Object Model](/previous-versions/office/developer/sharepoint-2010/ee537247(v=office.14)).

- Web parts in SharePoint. For more information, see [Web Parts Overview](/previous-versions/office/ms432401(v=office.14)).

## Create the projects
 To complete this walkthrough, you must create two projects:

- A VSIX project to create the VSIX package to deploy the **Server Explorer** extension.

- A class library project that implements the **Server Explorer** extension.

  Start the walkthrough by creating the projects.

#### To create the VSIX project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project**.

3. In the **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose **Extensibility**.

    > [!NOTE]
    > The **Extensibility** node is available only if you install the Visual Studio SDK. For more information, see the prerequisites section earlier in this topic.

4. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework.

     SharePoint tool extensions require features in this version of the .NET Framework.

5. Choose the **VSIX Project** template.

6. In the **Name** box, type **WebPartNode**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **WebPartNode** project to **Solution Explorer**.

#### To create the extension project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. In the  **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose **Windows**.

3. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework.

4. In the list of project templates, choose **Class Library**.

5. In the **Name** box, enter **WebPartNodeExtension**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **WebPartNodeExtension** project to the solution and opens the default Class1 code file.

6. Delete the Class1 code file from the project.

## Configure the extension project
 Before you write code to create the extension, you must add code files and assembly references to your project, and you must update the default namespace.

#### To configure the project

1. In the **WebPartNodeExtension** project, add two code files that are named SiteNodeExtension and WebPartNodeTypeProvider.

2. Open the shortcut menu for the WebPartNodeExtension project, and then choose **Add Reference**.

3. In the **Reference Manager - WebPartNodeExtension** dialog box, choose the **Framework** node, and then select the check boxes for the  System.ComponentModel.Composition and System.Windows.Forms assemblies.

4. Choose the **Extensions** node, select the check box for each of the following assemblies, and then choose the **OK** button:

    - Microsoft.SharePoint.Client

    - Microsoft.SharePoint.Client.Runtime

    - Microsoft.VisualStudio.SharePoint

5. Open the shortcut menu for the **WebPartNodeExtension** project, and then choose **Properties**.

     The **Project Designer** opens.

6. Choose the **Application** tab.

7. In the **Default namespace** box (C#) or **Root namespace** box (Visual Basic), enter **ServerExplorer.SharePointConnections.WebPartNode**.

## Create icons for the new nodes
 Create two icons for the **Server Explorer** extension: an icon for the new **Web Part Gallery** node and another icon for each child Web Part node under the **Web Part Gallery** node. Later in this walkthrough, you'll write code that associates these icons with the nodes.

#### To create icons for the nodes

1. In the **Project Designer** for the WebPartNodeExtension project, choose the **Resources** tab.

2. Choose the link **This project does not contain a default resources file. Click here to create one.**

     Visual Studio creates a resource file and opens it in the designer.

3. At the top of the designer, choose the arrow on the **Add Resource** menu command, and then choose **Add New Icon**.

4. Enter **WebPartsNode** for the new icon name, and then choose the **Add** button.

     The new icon opens in the **Image Editor**.

5. Edit the 16x16 version of the icon so that it has a design that you can easily recognize.

6. Open the shortcut menu for the 32x32 version of the icon, and then choose **Delete Image Type**.

7. Repeat steps 3 through 7 to add a second icon to the project resources, and name this icon **WebPart**.

8. In **Solution Explorer**, in the **Resources** folder for the **WebPartNodeExtension** project, choose *WebPartsNode.ico*.

9. In the **Properties** window, open the **Build Action** list, and then choose **Embedded Resource**.

10. Repeat the last two steps for *WebPart.ico*.

## Add the web part gallery node to Server Explorer
 Create a class that adds the new **Web Part Gallery** node to each SharePoint site node. To add the new node, the class implements the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> interface. Implement this interface whenever you want to extend the behavior of an existing node in **Server Explorer**, such as adding a new child node to a node.

#### To add the web part gallery node to Server Explorer

1. Paste the following code into the **SiteNodeExtension** code file for the **WebPartNodeExtension** project.

    > [!NOTE]
    > After you add this code, the project will have some compile errors. These errors will go away when you add code in later steps.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/webpartnode/webpartnodeextension/sitenodeextension.cs" id="Snippet1":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spextensibility.spexplorer.webpartnode.webpartnode/webpartnodeextension/sitenodeextension.vb" id="Snippet1":::

## Define a node type that represents a web part
 Create a class that defines a new type of node that represents a Web Part. Visual Studio uses this new node type to display child nodes under the **Web Part Gallery** node. Each of these child nodes represents a single Web Part on the SharePoint site.

 To define the new node type, the class implements the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider> interface. Implement this interface whenever you want to define a new type of node in **Server Explorer**.

#### To define the web part node type

1. Paste the following code into the **WebPartNodeTypeProvider** code file for the **WebPartNodeExtension** project.

     :::code language="csharp" source="../sharepoint/codesnippet/CSharp/webpartnode/webpartnodeextension/webpartnodetypeprovider.cs" id="Snippet2":::
     :::code language="vb" source="../sharepoint/codesnippet/VisualBasic/spextensibility.spexplorer.webpartnode.webpartnode/webpartnodeextension/webpartnodetypeprovider.vb" id="Snippet2":::

## Checkpoint
 At this point in the walkthrough, all the code for the **Web Part Gallery** node is now in the project. Build the **WebPartNodeExtension** project to make sure that it compiles without errors.

#### To build the project

1. In **Solution Explorer**, open the shortcut menu for the **WebPartNodeExtension** project, and then choose **Build**.

## Create a VSIX package to deploy the extension
 To deploy the extension, use the VSIX project in your solution to create a VSIX package. First, configure the VSIX package by modifying the source.extension.vsixmanifest file that's included in the project. Then create the VSIX package by building the solution.

#### To configure the VSIX package

1. In **Solution Explorer**, in the **WebPartNode** project, open **source.extension.vsixmanifest** file in the manifest editor.

     The source.extension.vsixmanifest file is the basis for the extension.vsixmanifest file that all VSIX packages require. For more information about this file, see [VSIX Extension Schema 1.0 Reference](/previous-versions/dd393700(v=vs.110)).

2. In the **Product Name** box, enter **Web Part Gallery Node for Server Explorer**.

3. In the **Author** box, enter **Contoso**.

4. In the **Description** box, enter **Adds a custom Web Part Gallery node to the SharePoint Connections node in Server Explorer**.

5. On the **Assets** tab of the editor, choose the **New** button.

6. In the **Add New Asset** dialog box, in the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

    > [!NOTE]
    > This value corresponds to the `MefComponent` element in the extension.vsixmanifest file. This element specifies the name of an extension assembly in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393736\(v\=vs.100\)).

7. In the **Source** list, choose **A project in current solution**.

8. In the **Project** list, choose **WebPartNodeExtension**, and then choose the **OK** button.

9. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the solution compiles without errors.

10. Make sure that the build output folder for the WebPartNode project now contains the WebPartNode.vsix file.

     By default, the build output folder is the ..\bin\Debug folder under the folder that contains your project file.

## Test the extension
 You are now ready to test the new **Web Part Gallery** node in **Server Explorer**. First, start to debug the extension project in an experimental instance of Visual Studio. Then use the new **Web Parts** node in the experimental instance of Visual Studio.

#### To start debugging the extension

1. Restart Visual Studio with administrative credentials, and then open the **WebPartNode** solution.

2. In the WebPartNodeExtension project, open the **SiteNodeExtension** code file, and then add a breakpoint to the first lines of code in the `NodeChildrenRequested` and `CreateWebPartNodes` methods.

3. Choose the **F5** key to start debugging.

     Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\11.0Exp\Extensions\Contoso\Web Part Gallery Node Extension for Server Explorer\1.0 and starts an experimental instance of Visual Studio. You'll test the project item in this instance of Visual Studio.

#### To test the extension

1. In the experimental instance of Visual Studio, on the menu bar, choose **View** > **Server Explorer**.

2. Verify that the SharePoint site that you want to use for testing appears under the **SharePoint Connections** node in **Server Explorer**. If it's not listed, follow these steps:

    1. Open the shortcut menu for **SharePoint Connections**, and then choose **Add Connection**.

    2. In the **Add SharePoint Connection** dialog box, enter the URL for the SharePoint site to which you want to connect, and then choose the **OK** button.

         To specify the SharePoint site on your development computer, type **http://localhost**.

3. Expand the site connection node (which displays the URL of your site), and then expand a child site node (for example, **Team Site**).

4. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `NodeChildrenRequested` method, and then choose the **F5** key to continue to debug the project.

5. In the experimental instance of Visual Studio, expand the **Web Part Gallery** node, which appears under the top-level site node.

6. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `CreateWebPartNodes` method, and then choose the **F5** key to continue to debug the project.

7. In the experimental instance of Visual Studio, verify that all the Web Parts on the connected site appear under the **Web Part Gallery** node in **Server Explorer**.

8. Open the shortcut menu for a Web Part, and then choose **Properties**.

9. In the **Properties** window, verify that details about the Web Part appear.

10. In **Server Explorer**, open the shortcut menu for the same Web Part, and then choose **Display Message**.

     In the message box that appears, choose the **OK** button.

## Uninstall the extension from Visual Studio
 After you finish testing the extension, uninstall it from Visual Studio.

#### To uninstall the extension

1. In the experimental instance of Visual Studio, on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose **Web Part Gallery Node for Server Explorer**, and then choose the **Uninstall** button.

3. In the dialog box that appears, choose the **Yes** button.

4. Choose the **Restart Now** button to complete the uninstallation.

     The project item is also uninstalled.

5. Close both instances of Visual Studio (the experimental instance and the instance of Visual Studio in which the WebPartNode solution is open).

## See also
- [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md)
- [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md)
- [Walkthrough: Extend Server Explorer to display web parts](../sharepoint/walkthrough-extending-server-explorer-to-display-web-parts.md)
- [Image Editor for Icons](/cpp/windows/image-editor-for-icons)
- [Creating an Icon or Other Image &#40;Image Editor for Icons&#41;](/cpp/windows/creating-an-icon-or-other-image-image-editor-for-icons)