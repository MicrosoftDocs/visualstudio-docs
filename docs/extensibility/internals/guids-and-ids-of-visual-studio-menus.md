---
title: GUIDs and IDs of Visual Studio Menus
description: View a list of GUID and ID values for the menus and groups on the Visual Studio menu bar included in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- visual studio menus
- visual studio groups
- id
- existing menus
- guid
- menus
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# GUIDs and IDs of Visual Studio menus

This article enumerates the GUID and ID values of the menus and groups on the Visual Studio menu bar. These values are defined in *.vsct* files that are installed as part of the Visual Studio SDK. For more information, see [IDE-defined commands, menus, and groups](../../extensibility/internals/ide-defined-commands-menus-and-groups.md).

 For more information about how to work with integrated development environment (IDE) objects that are defined in *.vsct* files, see [Extend menus and commands](../../extensibility/extending-menus-and-commands.md).

 The menus and groups on the Visual Studio menu bar use the GUID `guidSHLMainMenu`. The menu bar itself has an ID of `IDM_VS_TOOL_MAINMENU`.

## Groups on the Visual Studio menu bar
 To add a menu to the menu bar, set one of these groups as its parent.

|Group|ID|
|-----------|--------|
|File/Edit/View|IDG_VS_MM_FILEEDITVIEW|
|Refactoring|IDG_VS_MM_REFACTORING:|
|Project|IDG_VS_MM_PROJECT|
|Build|IDG_VS_MM_BUILDDEBUGRUN|
|Format/Tools|IDG_VS_MM_TOOLSADDINS|
|Window/Help/Community|IDG_VS_MM_WINDOWHELP|
|Addins|IDG_VS_MM_MACROS|
|FullScreenBar|IDG_VS_MM_FULLSCREENBAR|

## Menus on the Visual Studio menu bar
 To add a group to an existing Visual Studio menu, set one of the following menus as its parent. Submenus are not included in this list.

|Menu|ID|
|----------|--------|
|File|IDM_VS_MENU_FILE|
|Edit|IDM_VS_MENU_EDIT|
|View|IDM_VS_MENU_VIEW|
|Refactor|IDM_VS_MENU_REFACTORING|
|Project|IDM_VS_MENU_PROJECT|
|Build|IDM_VS_MENU_BUILD|
|Format|IDM_VS_MENU_FORMAT|
|Tools|IDM_VS_MENU_TOOLS|
|Extensions|IDM_VS_MENU_EXTENSIONS|
|Window|IDM_VS_MENU_WINDOW|
|Addins|IDM_VS_MENU_ADDINS|
|Community|IDM_VS_MENU_COMMUNITY|
|Help|IDM_VS_MENU_HELP|

## Groups on Visual Studio menus
 The following lists show the groups that descend directly from menus on the Visual Studio menu bar. The quickest way to add a command to a Visual Studio menu is to set one of these groups as the parent. Groups that descend from submenus do not appear in this section.

### File menu groups

|Group|ID|
|-----------|--------|
|New/Open|IDG_VS_FILE_FILE|
|Add|IDG_VS_FILE_ADD|
|Solution|IDG_VS_FILE_SOLUTION|
|Misc|IDG_VS_FILE_MISC|
|Save|IDG_VS_FILE_SAVE|
|Rename|IDG_VS_FILE_RENAME|
|Browser|IDG_VS_FILE_BROWSER|
|Print|IDG_VS_FILE_PRINT|
|Most Recently Used|IDG_VS_FILE_MRU|
|Move|IDG_VS_FILE_MOVE|
|Exit|IDG_VS_FILE_EXIT|

### Edit menu groups

|Group|ID|
|-----------|--------|
|Undo/Redo|IDG_VS_EDIT_UNDOREDO|
|Cut/Copy/Paste|IDG_VS_EDIT_CUTCOPY|
|Select|IDG_VS_EDIT_SELECT|
|GoTo|IDG_VS_EDIT_GOTO|
|Find|IDG_VS_EDIT_FIND|
|Objects|IDG_VS_EDIT_OBJECTS|
|OLE Verbs|IDG_VS_EDIT_OLEVERBS|
|Command Well|IDG_VS_EDIT_COMMANDWELL|

### Refactor menu groups

|Group|ID|
|-----------|--------|
|Common|IDG_REFACTORING_COMMON|
|Advanced|IDG_REFACTORING_ADVANCED|

### View menu groups

|Group|ID|
|-----------|--------|
|Form Code|IDG_VS_VIEW_FORMCODE|
|Browser|IDG_VS_VIEW_BROWSER|
|Define Views|IDG_VS_VIEW_DEFINEVIEWS|
|Windows|IDG_VS_VIEW_WINDOWS|
|Architect Windows|IDG_VS_VIEW_ARCH_WINDOWS|
|Organization Windows|IDG_VS_VIEW_ORG_WINDOWS|
|Code Browser|IDG_VS_VIEW_CODEBROWSENAV_WINDOWS|
|Dev Windows|IDG_VS_VIEW_DEV_WINDOWS|
|Toolbars|IDG_VS_VIEW_TOOLBARS|
|Symbols|IDG_VS_VIEW_SYMBOLNAVIGATE|
|Navigate|IDG_VS_VIEW_NAVIGATE|
|Small Navigate|IDG_VS_VIEW_SMALLNAVIGATE|
|Object Browser|IDG_VS_VIEW_OBJBRWSR|
|Command Well|IDG_VS_VIEW_COMMANDWELL|
|Property Pages|IDG_VS_VIEW_PROPPAGES|
|Refresh|IDG_VS_VIEW_REFRESH|

### Project menu groups

|Group|ID|
|-----------|--------|
|Miscellaneous Add|IDG_VS_PROJ_MISCADD|
|Add|IDG_VS_PROJ_ADD|
|Folder|IDG_VS_PROJ_FOLDER|
|Unload/Reload|IDG_VS_PROJ_UNLOADRELOAD|
|Reference|IDG_VS_PROJ_REFERENCE|
|Options|IDG_VS_PROJ_OPTIONS|
|Settings|IDG_VS_PROJ_SETTINGS|

### Build menu groups

|Group|ID|
|-----------|--------|
|Solution|IDG_VS_BUILD_SOLUTION|
|Selection|IDG_VS_BUILD_SELECTION|
|Profile Guided Optimization|IDG_VS_PGO_SELECTION|
|Miscellaneous|IDG_VS_BUILD_MISC|
|Cancel|IDG_VS_BUILD_CANCEL|

### Tools menu groups

|Group|ID|
|-----------|--------|
|Command Line|IDG_VS_TOOLS_CMDLINE|
|Snippets|IDG_VS_TOOLS_SNIPPETS|
|Object Subset|IDG_VS_TOOLS_OBJSUBSET|
|Options|IDG_VS_TOOLS_OPTIONS|
|Other 2|IDG_VS_TOOLS_OTHER2|
|External Tools|IDG_VS_TOOLS_EXT_TOOLS|
|External Customizations|IDG_VS_TOOLS_EXT_CUST|

### Window menu groups

|Group|ID|
|-----------|--------|
|New|IDG_VS_WINDOW_NEW|
|Dock/Close|IDG_VS_DOCKCLOSE|
|Dock/Hide|IDG_VS_DOCKHIDE|
|Arrange|IDG_VS_WINDOW_ARRANGE|
|Navigation|IDG_VS_WINDOW_NAVIGATION|
|List|IDG_VS_WINDOW_LIST|

### Help menu groups

|Group|ID|
|-----------|--------|
|Samples|IDG_VS_HELP_SAMPLES|
|Support|IDG_VS_HELP_SUPPORT|
|About|IDG_VS_HELP_ABOUT|

## Submenus of Visual Studio menus
 The following hierarchy shows the submenus that are associated with the menus on the Visual Studio menu bar. Because only a group can have a menu as its parent, every submenu must descend from a group on a menu, instead of directly from the menu. For more information about the relationship between menus, groups, and submenus, see [Add a submenu to a menu](../../extensibility/adding-a-submenu-to-a-menu.md).

> [!NOTE]
> The names of the menus on the Visual Studio menu bar are not separately shown in this hierarchy because they can be inferred from the naming convention for groups in the IDE, as follows: *IDG_VS_\<Menu Name\>_\<Group Name\>*.

|Parent group|Submenu|Child groups|
|------------------|-------------|------------------|
|IDG_VS_FILE_FILE|IDM_VS_CSCD_NEW|IDG_VS_FILE_NEW_CASCADE|
||IDM_VS_CSCD_OPEN|IDG_VS_FILE_OPENP_CASCADE|
|||IDG_VS_FILE_OPENF_CASCADE|
|IDG_VS_FILE_ADD|IDM_VS_CSCD_ADD|IDG_VS_FILE_ADD_PROJECT_NEW|
|||IDG_VS_FILE_ADD_PROJECT_EXI|
|IDG_VS_FILE_MRU|IDM_VS_CSCD_FILEMRU|IDG_VS_FILE_FMRU_CASCADE|
||IDM_VS_CSCD_PROJMRU|IDG_VS_FILE_PMRU_CASCADE|
|IDG_VS_FILE_MOVE|IDM_VS_CSCD_MOVETOPRJ|IDG_VS_FILE_MOVE_CASCADE|
|||IDG_VS_FILE_MOVE_PICKER|
|IDG_VS_VIEW_DEV_WINDOWS|IDM_VS_CSCD_FINDRESULTS|IDG_VS_WNDO_FINDRESULTS|
||IDM_VS_CSCD_WINDOWS|IDG_VS_VIEW_CALLBROWSER|
|||IDG_VS_WNDO_OTRWNDWS1...6|
|||IDG_VS_WNDO_WINDOWS2|
|IDG_VS_VIEW_TOOLBARS|IDM_VS_CSCD_COMMANDBARS||
|IDG_VS_EDIT_GOTO|IDM_VS_EDITOR_FIND_MENU||
|IDG_VS_EDIT_OBJECTS|IDM_VS_CSCD_MNUDES|IDG_VS_MNUDES_INSERT|
|||IDG_VS_MNUDES_EDITNAMES|
||IDM_VS_CSCD_OLEVERBS|IDG_VS_EDIT_OLEVERBS|
|IDG_VS_BUILD_SELECTION|IDM_VS_CSCD_BUILD|IDG_VS_BUILD_CASCADE|
|||IDG_VS_BUILD_PROJPICKER|
||IDM_VS_CSCD_REBUILD|IDG_VS_REBUILD_CASCADE|
|||IDG_VS_REBUILD_PROJPICKER|
||IDM_VS_CSCD_PROJONLY|IDG_VS_PROJONLY_CASCADE|
||IDM_VS_CSCD_CLEAN|IDG_VS_CLEAN_CASCADE|
|||IDG_VS_CLEAN_PROJPICKER|
||IDM_VS_CSCD_DEPLOY|IDG_VS_DEPLOY_CASCADE|
|||IDG_VS_DEPLOY_PROJPICKER|
|IDG_VS_PGO_SELECTION|IDM_VS_CSCD_PGO_BUILD|IDG_VS_PGO_BUILD_CASCADE_BUILD|
|||IDG_VS_PGO_BUILD_CASCADE_RUN|

## See also
- [GUIDs and IDs of Visual Studio toolbars](../../extensibility/internals/guids-and-ids-of-visual-studio-toolbars.md)
- [GUIDs and IDs of Visual Studio commands](../../extensibility/internals/guids-and-ids-of-visual-studio-commands.md)
- [Visual Studio command table (.vsct) files](../../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
