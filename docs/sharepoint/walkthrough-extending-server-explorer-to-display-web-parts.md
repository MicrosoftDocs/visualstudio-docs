---
title: "Walkthrough: Extending Server Explorer to Display Web Parts | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint Connections [SharePoint development in Visual Studio], extending a node"
  - "SharePoint commands"
  - "SharePoint development in Visual Studio, extending SharePoint Connections node in Server Explorer"
  - "SharePoint Connections [SharePoint development in Visual Studio], creating a new node type"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Extend Server Explorer to display web parts
  In Visual Studio, you can use the **SharePoint Connections** node of **Server Explorer** to view components on SharePoint sites. However, **Server Explorer** doesn't display some components by default. In this walkthrough, you'll extend **Server Explorer** so that it displays the Web Part gallery on each connected SharePoint site.

 This walkthrough demonstrates the following tasks:

- Creating a Visual Studio extension that extends **Server Explorer** in the following ways:

  - The extension adds a **Web Part Gallery** node under each SharePoint site node in **Server Explorer**. This new node contains child nodes that represent each Web Part in the Web Part gallery on the site.

  - The extension defines a new type of node that represents a Web Part instance. This new node type is the basis for the child nodes under the new **Web Part Gallery** node. The new Web Part node type displays information in the **Properties** window about the Web Part that it represents. The node type also includes a custom shortcut menu item that you can use as a starting point for performing other tasks that relate to the Web Part.

- Create two custom SharePoint commands that the extension assembly calls. SharePoint commands are methods that can be called by extension assemblies to use APIs in the server object model for SharePoint. In this walkthrough, you create commands that retrieve Web Part information from the local SharePoint site on the development computer. For more information, see [Call into the SharePoint object models](../sharepoint/calling-into-the-sharepoint-object-models.md).

- Building a Visual Studio Extension (VSIX) package to deploy the extension.

- Debugging and testing the extension.

> [!NOTE]
> For an alternate version of this walkthrough that uses the client object model for SharePoint instead of its server object model, see [Walkthrough: Call into the SharePoint client object model in a Server Explorer extension](../sharepoint/walkthrough-calling-into-the-sharepoint-client-object-model-in-a-server-explorer-extension.md).

## Prerequisites
 You need the following components on the development computer to complete this walkthrough:

- Supported editions of Windows, SharePoint and Visual Studio.

- The Visual Studio SDK. This walkthrough uses the **VSIX Project** template in the SDK to create a VSIX package to deploy the project item. For more information, see [Extend the SharePoint tools in Visual Studio](../sharepoint/extending-the-sharepoint-tools-in-visual-studio.md).

  Knowledge of the following concepts is helpful, but not required, to complete the walkthrough:

- Using the server object model for SharePoint. For more information, see [Using the SharePoint Foundation Server-Side Object Model](/previous-versions/office/developer/sharepoint-2010/ee538251(v=office.14)).

- Web Parts in SharePoint solutions. For more information, see [Web Parts Overview](/previous-versions/office/ms432401(v=office.14)).

## Create the projects
 To complete this walkthrough, you must create three projects:

- A VSIX project to create the VSIX package to deploy the extension.

- A class library project that implements the extension. This project must target the .NET Framework 4.5.

- A class library project that defines the custom SharePoint commands. This project must target the.NET Framework 3.5.

  Start the walkthrough by creating the projects.

#### To create the VSIX project

1. Start [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. On the menu bar, choose **File** > **New** > **Project**.

3. In the  **New Project** dialog box, expand the **Visual C#** or **Visual Basic** nodes, and then choose the **Extensibility** node.

    > [!NOTE]
    > The **Extensibility** node is available only if you install the Visual Studio SDK. For more information, see the prerequisites section earlier in this topic.

4. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework.

5. Choose the **VSIX Project** template, name the project **WebPartNode**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **WebPartNode** project to **Solution Explorer**.

#### To create the extension project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. In the **New Project** dialog box, expand the **Visual C#** node or **Visual Basic** node, and then the choose **Windows** node.

3. At the top of the dialog box, choose **.NET Framework 4.5** in the list of versions of the .NET Framework.

4. In the list of project templates, choose **Class Library**, name the project **WebPartNodeExtension**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **WebPartNodeExtension** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

#### To create the SharePoint commands project

1. In **Solution Explorer**, open the shortcut menu for the solution node, choose **Add**, and then choose **New Project**.

2. In the  **New Project** dialog box, expand the **Visual C#** node or **Visual Basic** node, and then choose the **Windows** node.

3. At the top of the dialog box, choose **.NET Framework 3.5** in the list of versions of the .NET Framework.

4. In the list of project templates, choose **Class Library**, name the project **WebPartCommands**, and then choose the **OK** button.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the **WebPartCommands** project to the solution and opens the default Class1 code file.

5. Delete the Class1 code file from the project.

## Configure the projects
 Before you write code to create the extension, you must add code files and assembly references, and configure the project settings.

#### To configure the WebPartNodeExtension project

1. In the WebPartNodeExtension project, add four code files that have the following names:

    - SiteNodeExtension

    - WebPartNodeTypeProvider

    - WebPartNodeInfo

    - WebPartCommandIds

2. Open the shortcut menu for the **WebPartNodeExtension** project, and then choose **Add Reference**.

3. In the **Reference Manager - WebPartNodeExtension** dialog box, choose the **Framework** tab, and then select the check box for each of the following assemblies:

    - System.ComponentModel.Composition

    - System.Windows.Forms

4. Choose the **Extensions** tab, select the check box for the Microsoft.VisualStudio.SharePoint assembly, and then choose the **OK** button.

5. In **Solution Explorer**, open the shortcut menu for the **WebPartNodeExtension** project node, and then choose **Properties**.

     The **Project Designer** opens.

6. Choose the **Application** tab.

7. In the **Default namespace** box (C#) or **Root namespace** box ([!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)]), enter **ServerExplorer.SharePointConnections.WebPartNode**.

#### To configure the webpartcommands project

1. In the WebPartCommands project, add a code file that's named WebPartCommands.

2. In **Solution Explorer**, open the shortcut menu for the **WebPartCommands** project node, choose **Add**, and then choose **Existing Item**.

3. In the **Add Existing Item** dialog box, browse to the folder that contains the code files for the WebPartNodeExtension project, and then choose the WebPartNodeInfo and WebPartCommandIds code files.

4. Choose the arrow next to the **Add** button, and then choose **Add As Link** in the menu that appears.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] adds the code files to the WebPartCommands project as links. As a result, the code files are located in the WebPartNodeExtension project, but the code in the files are also compiled in the WebPartCommands project.

5. Open the shortcut menu for the **WebPartCommands** project again, and choose **Add Reference**.

6. In the **Reference Manager - WebPartCommands** dialog box, choose the **Extensions** tab, select the check box for each of the following assemblies, and then choose the **OK** button:

    - Microsoft.SharePoint

    - Microsoft.VisualStudio.SharePoint.Commands

7. In **Solution Explorer**, open the shortcut menu for the **WebPartCommands** project again, and then choose **Properties**.

     The **Project Designer** opens.

8. Choose the **Application** tab.

9. In the **Default namespace** box (C#) or **Root namespace** box ([!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)]), enter **ServerExplorer.SharePointConnections.WebPartNode**.

## Create icons for the new nodes
 Create two icons for the **Server Explorer** extension: an icon for the new **Web Part Gallery** node, and another icon for each child Web Part node under the **Web Part Gallery** node. Later in this walkthrough, you will write code that associates these icons with the nodes.

#### To create icons for the nodes

1. In **Solution Explorer**, open the shortcut menu for the **WebPartNodeExtension** project, and then choose **Properties**.

2. The **Project Designer** opens.

3. Choose the **Resources** tab, and then choose the **This project does not contain a default resources file. Click here to create one** link.

     [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] creates a resource file and opens it in the designer.

4. At the top of the designer, choose the arrow next to the **Add Resource** menu command, and then choose **Add New Icon** in the menu that appears.

5. In the **Add New Resource** dialog box, name the new icon **WebPartsNode**, and then choose the **Add** button.

     The new icon opens in the **Image Editor**.

6. Edit the 16x16 version of the icon so that it has a design that you can easily recognize.

7. Open the shortcut menu for the 32x32 version of the icon, and then choose **Delete Image Type**.

8. Repeat steps 5 through 8 to add a second icon to the project resources, and name this icon **WebPart**.

9. In **Solution Explorer**, under the **Resources** folder for the **WebPartNodeExtension** project, open the shortcut menu for **WebPartsNode.ico**.

10. In the **Properties** window, choose the arrow next to **Build Action**, and then choose **Embedded Resource** on the menu that appears.

11. Repeat the last two steps for **WebPart.ico**.

## Add the Web Part Gallery node to Server Explorer
 Create a class that adds the new **Web Part Gallery** node to each SharePoint site node. To add the new node, the class implements the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeExtension> interface. Implement this interface whenever you want to extend the behavior of an existing node in **Server Explorer**, such as adding a child node to a node.

#### To add the Web Part Gallery node to Server Explorer

1. In the WebPartNodeExtension project, open the SiteNodeExtension code file, and then paste the following code into it.

    > [!NOTE]
    > After you add this code, the project will have some compile errors, but they'll go away when you add code in later steps.

     [!code-csharp[SPExtensibility.SPExplorer.WebPartNodeWithCommands#1](../sharepoint/codesnippet/CSharp/WebPartNode/webpartnodeextension/sitenodeextension.cs#1)]
     [!code-vb[SPExtensibility.SPExplorer.WebPartNodeWithCommands#1](../sharepoint/codesnippet/VisualBasic/spextensibility.spexplorer.webpartnodewithcommands.webpartnode/webpartnodeextension/sitenodeextension.vb#1)]

## Define a node type that represents a web part
 Create a class that defines a new type of node that represents a Web Part. Visual Studio uses this new node type to display child nodes under the **Web Part Gallery** node. Each child node represents a single Web Part on the SharePoint site.

 To define the new node type, the class implements the <xref:Microsoft.VisualStudio.SharePoint.Explorer.IExplorerNodeTypeProvider> interface. Implement this interface whenever you want to define a new type of node in **Server Explorer**.

#### To define the web part node type

1. In the WebPartNodeExtension project, open the WebPartNodeTypeProvder code file, and then paste the following code into it.

     [!code-vb[SPExtensibility.SPExplorer.WebPartNodeWithCommands#2](../sharepoint/codesnippet/VisualBasic/spextensibility.spexplorer.webpartnodewithcommands.webpartnode/webpartnodeextension/webpartnodetypeprovider.vb#2)]
     [!code-csharp[SPExtensibility.SPExplorer.WebPartNodeWithCommands#2](../sharepoint/codesnippet/CSharp/WebPartNode/webpartnodeextension/webpartnodetypeprovider.cs#2)]

## Define the web part data class
 Define a class that contains data about a single Web Part on the SharePoint site. Later in this walkthrough, you will create a custom SharePoint command that retrieves data about each Web Part on the site and then assigns the data to instances of this class.

#### To define the web part data class

1. In the WebPartNodeExtension project, open the WebPartNodeInfo code file, and then paste the following code into it.

     [!code-vb[SPExtensibility.SPExplorer.WebPartNodeWithCommands#3](../sharepoint/codesnippet/VisualBasic/spextensibility.spexplorer.webpartnodewithcommands.webpartnode/webpartnodeextension/webpartnodeinfo.vb#3)]
     [!code-csharp[SPExtensibility.SPExplorer.WebPartNodeWithCommands#3](../sharepoint/codesnippet/CSharp/WebPartNode/webpartnodeextension/webpartnodeinfo.cs#3)]

## Define the IDs for the SharePoint commands
 Define several strings that identify the custom SharePoint commands. You will implement these commands later in this walkthrough.

#### To define the command IDs

1. In the WebPartNodeExtension project, open the WebPartCommandIds code file, and then paste the following code into it.

     [!code-csharp[SPExtensibility.SPExplorer.WebPartNodeWithCommands#4](../sharepoint/codesnippet/CSharp/WebPartNode/webpartnodeextension/webpartcommandids.cs#4)]
     [!code-vb[SPExtensibility.SPExplorer.WebPartNodeWithCommands#4](../sharepoint/codesnippet/VisualBasic/spextensibility.spexplorer.webpartnodewithcommands.webpartnode/webpartnodeextension/webpartcommandids.vb#4)]

## Create the custom SharePoint commands
 Create custom commands that call into the server object model for SharePoint to retrieve data about the Web Parts on the SharePoint site. Each command is a method that has the <xref:Microsoft.VisualStudio.SharePoint.Commands.SharePointCommandAttribute> applied to it.

#### To define the SharePoint commands

1. In the WebPartCommands project, open the WebPartCommands code file, and then paste the following code into it.

     [!code-csharp[SPExtensibility.SPExplorer.WebPartNodeWithCommands#6](../sharepoint/codesnippet/CSharp/WebPartNode/WebPartCommands/WebPartCommands.cs#6)]
     [!code-vb[SPExtensibility.SPExplorer.WebPartNodeWithCommands#6](../sharepoint/codesnippet/VisualBasic/spextensibility.spexplorer.webpartnodewithcommands.webpartnode/webpartcommands/webpartcommands.vb#6)]

## Checkpoint
 At this point in the walkthrough, all the code for the **Web Part Gallery** node and the SharePoint commands are now in the projects. Build the solution to make sure that both projects compile without errors.

#### To build the solution

1. On the menu bar, choose **Build** > **Build Solution**.

    > [!WARNING]
    > At this point, the WebPartNode project may have a build error because the VSIX manifest file doesn't have a value for Author. This error will go away when you add a value in later steps.

## Create a VSIX package to deploy the extension
 To deploy the extension, use the VSIX project in your solution to create a VSIX package. First, configure the VSIX package by modifying the source.extension.vsixmanifest file in the VSIX project. Then, create the VSIX package by building the solution.

#### To configure the VSIX package

1. In **Solution Explorer**, under the WebPartNode project, open the **source.extension.vsixmanifest** file in the manifest editor.

     The source.extension.vsixmanifest file is the basis for the extension.vsixmanifest file that all VSIX packages require. For more information about this file, see [VSIX Extension Schema 1.0 Reference](https://msdn.microsoft.com/76e410ec-b1fb-4652-ac98-4a4c52e09a2b).

2. In the **Product Name** box, enter **Web Part Gallery Node for Server Explorer**.

3. In the **Author** box, enter **Contoso**.

4. In the **Description** box, enter **Adds a custom Web Part Gallery node to the SharePoint Connections node in Server Explorer. This extension uses a custom SharePoint command to call into the server object model.**

5. Choose the **Assets** tab of the editor, and then choose the **New** button.

     The **Add New Asset** dialog box appears.

6. In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

    > [!NOTE]
    > This value corresponds to the `MefComponent` element in the extension.vsixmanifest file. This element specifies the name of an extension assembly in the VSIX package. For more information, see [MEFComponent Element (VSX Schema)](/previous-versions/visualstudio/visual-studio-2010/dd393736\(v\=vs.100\)).

7. In the  **Source** list, choose **A project in current solution**.

8. In the **Project** list, choose **WebPartNodeExtension** and then choose the **OK** button.

9. In the manifest editor, choose the **New** button again.

     The **Add New Asset** dialog box appears.

10. In the **Type** box, enter **SharePoint.Commands.v4**.

    > [!NOTE]
    > This element specifies a custom extension that you want to include in the Visual Studio extension. For more information, see [Asset Element (VSX Schema)](https://msdn.microsoft.com/9fcfc098-edc7-484b-9d4c-acd17829d737).

11. In the **Source** list, choose the **A project in current solution** list item.

12. In the **Project** list, choose **WebPartCommands**, and then choose the **OK** button.

13. On the menu bar, choose **Build** > **Build Solution**, and then make sure that the solution compiles without errors.

14. Make sure that the build output folder for the WebPartNode project now contains the WebPartNode.vsix file.

     By default, the build output folder is the ..\bin\Debug folder under the folder that contains your project file.

## Test the extension
 You're now ready to test the new **Web Part Gallery** node in **Server Explorer**. First, start debugging the extension in an experimental instance of Visual Studio. Then, use the new **Web Parts** node in the experimental instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

#### To start debugging the extension

1. Restart [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] with administrative credentials, and then open the WebPartNode solution.

2. In the WebPartNodeExtension project, open the SiteNodeExtension code file, and then add a breakpoint to the first line of code in the `NodeChildrenRequested` and `CreateWebPartNodes` methods.

3. Choose the **F5** key to start debugging.

     Visual Studio installs the extension to %UserProfile%\AppData\Local\Microsoft\VisualStudio\11.0Exp\Extensions\Contoso\Web Part Gallery Node Extension for Server Explorer\1.0 and starts an experimental instance of Visual Studio. You will test the project item in this instance of Visual Studio.

#### To test the extension

1. In the experimental instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], on the menu bar, choose **View** > **Server Explorer**.

2. Perform the following steps if the SharePoint site that you want to use for testing doesn't appear under the **SharePoint Connections** node in **Server Explorer**:

    1. In **Server Explorer**, open the shortcut menu for **SharePoint Connections**, and then choose **Add Connection**.

    2. In the **Add SharePoint Connection** dialog box, enter the URL for the SharePoint site to which you want to connect, and then choose the **OK** button.

         To specify the SharePoint site on your development computer, enter **http://localhost**.

3. Expand the site connection node (which displays the URL of your site), and then expand a child site node (for example, **Team Site**).

4. Verify that the code in the other instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] stops on the breakpoint that you set earlier in the `NodeChildrenRequested` method, and then choose **F5** to continue to debug the project.

5. In the experimental instance of Visual Studio, verify that a new node named **Web Part Gallery** appears under the top-level site node, and then expand the **Web Part Gallery** node.

6. Verify that the code in the other instance of Visual Studio stops on the breakpoint that you set earlier in the `CreateWebPartNodes` method, and then choose the **F5** key to continue to debug the project.

7. In the experimental instance of Visual Studio, verify that all Web Parts on the connected site appear under the **Web Part Gallery** node in **Server Explorer**.

8. In **Server Explorer**, open the shortcut menu for one of the Web Parts, and then choose **Properties**.

9. In the instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] that you're debugging, verify that details about the Web Part appear in the **Properties** window.

## Uninstall the extension from Visual Studio
 After you finish testing the extension, uninstall the extension from Visual Studio.

#### To uninstall the extension

1. In the experimental instance of [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], on the menu bar, choose **Tools** > **Extensions and Updates**.

     The **Extensions and Updates** dialog box opens.

2. In the list of extensions, choose **Web Part Gallery Node Extension for Server Explorer**, and then choose the **Uninstall** button.

3. In the dialog box that appears, choose the **Yes** button to confirm that you want to uninstall the extension, and then choose the **Restart Now** button to complete the uninstallation.

4. Close both instances of Visual Studio (the experimental instance and the instance of Visual Studio in which the WebPartNode solution is open).

## See also
- [Extend the SharePoint connections node in Server Explorer](../sharepoint/extending-the-sharepoint-connections-node-in-server-explorer.md)
- [Walkthrough: Call into the SharePoint client object model in a Server Explorer extension](../sharepoint/walkthrough-calling-into-the-sharepoint-client-object-model-in-a-server-explorer-extension.md)
- [Image Editor for Icons](/cpp/windows/image-editor-for-icons)
- [Creating an Icon or Other Image &#40;Image Editor for Icons&#41;](/cpp/windows/creating-an-icon-or-other-image-image-editor-for-icons)
