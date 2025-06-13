---
title: IDE-Defined Commands for Extending Project Systems
description: Learn about the commands and command groups defined in the Visual Studio integrated development environment (IDE) that are used for extending project systems. 
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- commands, project systems
- project systems, environment-defined commands
author: maiak
ms.author: maiak
manager: mijacobs
ms.subservice: extensibility-integration
---
# IDE-Defined Commands for Extending Project Systems

When you want to extend project systems, you can use commands and command groups provided by the Visual Studio IDE.

 The following sections list command items that are especially useful for extending project systems.

## Command Menus
 The following table shows the command menus that are useful locations for you to put high-level commands that invoke a project extender.

|Command menu|Description|
|------------------|-----------------|
|IDM_VS_MENU_PROJECT|The **Project** top-level menu.|
|IDM_VS_TOOL_PROJWIN|The **Solution Explorer** toolbar.|

## Shortcut Menus
 The following table shows the shortcut menus that apply when a single node is selected in the **Solution Explorer**, or when there are multiple homogeneous selections in the **Solution Explorer**, which is when all selected nodes are of the same type.

|Shortcut menu|Description|
|-------------------|-----------------|
|<xref:Microsoft.VisualStudio.Shell.VsMenus.IDM_VS_CTXT_PROJNODE>|Applies when the project node is selected.|
|<xref:Microsoft.VisualStudio.Shell.VsMenus.IDM_VS_CTXT_ITEMNODE>|Applies when a file is selected.|
|<xref:Microsoft.VisualStudio.Shell.VsMenus.IDM_VS_CTXT_FOLDERNODE>|Applies when a folder is selected.|
|IDM_VS_CTXT_WEBREFFOLDER|Applies when the Web Reference folder is selected.|
|<xref:Microsoft.VisualStudio.Shell.VsMenus.IDM_VS_CTXT_REFERENCEROOT>|Applies when the references root node called "References" is selected.|
|<xref:Microsoft.VisualStudio.Shell.VsMenus.IDM_VS_CTXT_REFERENCE>|Applies when reference nodes are selected; these include assembly, COM, and project references only. Does not include Web references.|

 The following table shows the shortcut menus that apply when the selection in the **Solution Explorer** spans multiple hierarchies,

|Shortcut menu|Description|
|-------------------|-----------------|
|IDM_VS_CTXT_XPROJ_SLNPROJ|Applies when the current selection contains the solution node and root project nodes.|
|IDM_VS_CTXT_XPROJ_SLNITEM|Applies when the current selection contains the solution node and project items.|
|IDM_VS_CTXT_XPROJ_MULTIPROJ|Applies when the current selection consists of multiple root project nodes only.|
|IDM_VS_CTXT_XPROJ_PROJITEM|Applies when the current selection contains a mix of root project nodes and project items. Additionally, the selection may contain the solution node.|
|IDM_VS_CTXT_XPROJ_MULTIITEM|Applies when the current selection contains project items from multiple projects in the solution, or when items of different types are selected in the same project.|

## Command Groups
 The following table shows the command groups that you can use when you extend projects, and that you can access through the <xref:Microsoft.VisualStudio.Shell.VsMenus.IDM_VS_CTXT_PROJNODE> shortcut menu.

|Command group|Description|
|-------------------|-----------------|
|IDG_VS_CTXT_PROJECT_BUILD|Commands for building, rebuilding, and deploying the project.|
|IDG_VS_CTXT_COMPILELINK|Commands for compiling and linking the project.|
|IDG_VS_CTXT_PROJECT_CONFIG|Commands that set project configuration and build order.|
|IDG_VS_CTXT_PROJECT_ADD|Commands that add items to the project.|
|IDG_VS_CTXT_PROJECT_START|Commands that set the startup project associated with the F5 key.|
|IDG_VS_CTXT_PROJECT_SAVE|Commands for saving project items.|
|IDG_VS_CTXT_PROJECT_DEBUG|Commands for debugging.|
|IDG_VS_CTXT_PROJECT_SCC|Commands for source control.|
|IDG_VS_CTXT_PROJECT_TRANSFER|Commands for cut, copy and paste operations.|
|IDG_VS_CTXT_PROJECT_PROPERTIES|Commands that provide access to the **Project Properties** dialog box.|

## See also

- [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)
- [Creating Reusable Groups of Buttons](../../extensibility/creating-reusable-groups-of-buttons.md)
