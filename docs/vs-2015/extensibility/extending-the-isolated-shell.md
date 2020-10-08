---
title: "Extending the Isolated Shell | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, isolated mode"
ms.assetid: 9a641d8f-211e-4486-a1b1-4a89fafe7ee8
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Extending the Isolated Shell
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can extend the Visual Studio isolated shell by adding a VSPackage, a Managed Extensibility Framework (MEF) component part, or a generic VSIX project to your isolated shell application.  
  
> [!NOTE]
> The following steps presuppose that you have created a basic isolated shell application by using the Visual Studio Shell Isolated project template. For more information about this project template, see [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md).  
  
## Locations for the Visual Studio Package Project Template  
 The Visual Studio Package project template can be found in three different locations in the **New Project** dialog:  
  
1. Under **Visual Basic**, **Extensibility**. The default language of the project is Visual Basic.  
  
2. Under **Visual C#**, **Extensibility**. The default language of the project is C#.  
  
3. Under **Other Project Types**, **Extensibility**. The default language of the project is C++.  
  
## Adding a VSPackage  
 You can add a VSPackage to your isolated shell application. The following steps show how to create one that adds menu commands.  
  
#### To add a new VSPackage  
  
1. Add a Visual Studio Package project named `MenuCommandsPackage`.  
  
2. On the **Basic VSPackage Information** page of the wizard, set **Company name** to `Fabrikam` and **VSPackage name** to `FabrikamMenuCommands`. Choose the **Next** button.  
  
3. On the next page, select **Menu Command** and then choose **Next**.  
  
4. On the next page, set **Command name** to `Fabrikam Command` and **Command ID** to `cmdidFabrikamCommand`, and then choose **Next**.  
  
5. On the **Select Test Project Options** page, clear the test options, and then choose the **Finish** button.  
  
6. In the ShellExtensionsVSIX project, open the source.extension.vsixmanifest file.  
  
     The **Assets** section should contain an entry for the VSShellStub.AboutBoxPackage project.  
  
7. Choose the **New** button.  
  
8. In the **Add New Asset** window, in the **Type** list, select **Microsoft.VisualStudio.VsPackage**.  
  
9. In the **Source** list, make sure that **A project in the current solution** is selected. In the **Project** list box, select **MenuCommandsPackage**.  
  
10. Save and close the file.  
  
11. Rebuild the solution and start debugging the isolated shell.  
  
12. On the menu bar, choose **Tools** menu, then **Fabrikam Command**.  
  
     A message box should appear.  
  
13. Stop debugging the application.  
  
## Adding a MEF Component Part  
 The following steps show how to add a MEF component part to your isolated shell application.  
  
#### To add a MEF component  
  
1. In the **Add New Project** dialog box, under **Visual C#**, **Extensibility**, use the **Editor Margin** template to add a project. Name it `ShellEditorMargin`.  
  
2. In the ShellExtensionsVSIX project, open the Source.extension.vsixmanifest file in the Design view, not the Code view.  
  
3. In the `Asset` section, choose **Add Content**.  
  
4. In the **Add New Asset** window, in the **Type** list, select **Microsoft.VisualStudio.MefComponent**.  
  
5. In the **Source** list, make sure that **A project in the current solution** is selected. In the **Project** list box, select **ShellEditorMargin**.  
  
6. Save and close the file.  
  
7. Rebuild the solution and start debugging the isolated shell.  
  
8. Open a text file.  
  
     A green margin that contains the words "Hello world!" should be displayed at the bottom of the text file window.  
  
9. Stop debugging the application.  
  
## Adding a Generic VSIX Project  
  
#### To add a generic VSIX project  
  
1. In the **Add New Project** dialog box, under **Visual C#**, **Extensibility**, use the **VSIXProject** template to add a project. Name it `EmptyVSIX`.  
  
2. In the ShellExtensionsVSIX project, open the Source.extensions.vsixmanifest file in the Design view, not the Code view.  
  
3. In the `Assets` section, choose **New**.  
  
4. In the **Add New Asset** window, in the **Type** list, select the kind of content you want to add.  
  
5. In **Source**, make sure that the **A project in current solution** option is selected. In the list box, select the name of your VSIX project.  
  
6. Save and close the file.  
  
7. If this project includes compiled code, you must edit the project so that the assembly is included in the output.  
  
    1. Unload the VSIX project and open the project file.  
  
    2. In the first `<PropertyGroup>` block, change the value of `<CopyBuildOutputToOutputDirectory>` to `true`.  
  
    3. Save and reload the project.  
  
8. Build and run the solution.  
  
## See Also  
 [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md)
