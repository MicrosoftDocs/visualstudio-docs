---
title: GUIDs and IDs of Visual Studio Toolbars
description: View a list of GUID and ID values for the toolbars and the groups they contain, that are included in the Visual Studio integrated development environment (IDE).
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- visual studio groups
- toolbars
- visual studio toolbar
- id
- toolgar group
- tool window toolbar
- guid
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# GUIDs and IDs of Visual Studio toolbars

This topic enumerates the GUID and ID values of the toolbars that are included in the Visual Studio integrated development environment (IDE), and of the groups they contain. These values are defined in *.vsct* files that are installed as part of the Visual Studio SDK. For more information, see [IDE-defined commands, menus, and groups](../../extensibility/internals/ide-defined-commands-menus-and-groups.md).

> [!NOTE]
> Many of the toolbars available to Visual Studio are not defined by Visual Studio, and their GUID and ID values are not public. This topic lists only toolbars that are defined in Visual Studio SDK *.vsct* files.

 For more information about how to work with IDE objects that are defined in *.vsct* files, see [Extend menus and commands](../../extensibility/extending-menus-and-commands.md).

 The default toolbars provided by the Visual Studio IDE use the GUID `guidSHLMainMenu`, except where otherwise specified by using `GUID:ID` syntax.

## IDE toolbars
 The following toolbars are provided by the Visual Studio IDE. Toolbars can be displayed by selecting them on the **Toolbars** submenu of the **Tools** menu. Toolbars in tool windows are not included in this section.

 Only groups can descend directly from toolbars. To add a group, set its parent to the GUID and ID of the toolbar. To add a button to a toolbar, set its parent to a group on the toolbar.

|Toolbar|ID|
|-------------|--------|
|Standard|IDM_VS_TOOL_STANDARD|
|Build|IDM_VS_TOOL_BUILD|
|Text editor|IDM_VS_TOOL_TEXTEDITOR|
|Debug|guidVSDebugGroup:IDM_DEBUG_TOOLBAR|
|Debug location|guidVSDebugGroup:IDM_DEBUG_CONTEXT_TOOLBAR|

### Special toolbars
 These toolbars are defined by the Visual Studio IDE, but they serve specialized functions and do not host command groups.

|Toolbar|ID|
|-------------|--------|
|Add command|IDM_VS_TOOL_ADDCOMMAND|
|Undefined|IDM_VS_TOOL_UNDEFINED|
|XML schema|IDM_VS_TOOL_SCHEMA|
|XML data|IDM_VS_TOOL_DATA|

## Groups on the IDE toolbars
 To add a button to a standard toolbar, set one of the following groups as its parent. The groups are sorted by parent toolbar.

### Standard toolbar groups

|Name|ID|
|----------|--------|
|Save/Open|IDG_VS_TOOLSB_SAVEOPEN|
|Cut/Copy|IDG_VS_TOOLSB_CUTCOPY|
|Undo/Redo|IDG_VS_TOOLSB_UNDOREDO|
|Run/Build|IDG_VS_TOOLSB_RUNBUILD|
|Search|IDG_VS_TOOLSB_SEARCH|
|Windows|IDG_VS_TOOLSB_WINDOWS|
|New windows|IDG_VS_TOOLSB_NEWWINDOWS|
|Load/Save|IDG_VS_WINDOWUI_LOADSAVE|
|Gauge|IDG_VS_TOOLSB_GAUGE|

### Build toolbar groups

|Name|ID|
|----------|--------|
|Build bar|IDG_VS_BUILDBAR|
|Cancel|IDG_VS_BUILD_CANCEL|

### Text editor toolbar groups

|Name|ID|
|----------|--------|
|Completion|IDM_VS_TOOL_TEXTEDITOR|
|Indent|IDG_VS_EDITTOOLBAR_INDENT|
|Comment|IDG_VS_EDITTOOLBAR_COMMENT|
|Bookmarks|IDG_VS_EDITTOOLBAR_TEMPBOOKMARKS|

### Debug toolbar groups

|Name|ID|
|----------|--------|
|Execution|IDM_DEBUG_TOOLBAR|
|Stepping|IDG_DEBUG_TOOLBAR_STEPPING|
|Watch|IDG_DEBUG_TOOLBAR_WATCH|
|Windows|IDG_DEBUG_TOOLBAR_WINDOWS|

### Debug location toolbar groups

|Name|ID|
|----------|--------|
|Debug location|IDG_DEBUG_CONTEXT_TOOLBAR|

## Tool window toolbars
 Toolbars can appear directly in the IDE or in tool windows such as **Solution Explorer**. Because tool windows are not defined in *.vsct* files, tool window toolbars do not have defined parents. Instead, they are placed in code. The following table shows the toolbars that appear on tool windows in the IDE, and the command groups they contain.

> [!NOTE]
> Toolbars and groups use the GUID `guidSHLMainMenu`, except where otherwise specified by using GUID:ID syntax. Where a GUID is specified for a toolbar, it also applies to the groups that descend from that toolbar.

|Tool window|Toolbar|Groups|
|-----------------|-------------|------------|
|Solution Explorer|IDM_VS_TOOL_PROJWIN|IDG_VS_PROJ_TOOLBAR1..5|
|Server Explorer|guid_SE_MenuGroup:IDM_SE_TOOLBAR_SERVEREXPLORER|IDG_SE_TOOLBAR_REFRESH|
|Properties|IDM_VS_TOOL_PROPERTIES|IDG_VS_PROPERTIES_SORT<br /><br /> IDG_VS_PROPERTIES_PAGES|
|Class View|IDM_VS_TOOL_CLASSVIEW|IDG_VS_CLASSVIEW_FOLDERS<br /><br /> IDG_VS_CLASSVIEW_SEARCH<br /><br /> IDG_VS_CLASSVIEW_SETTINGS|
|Class View|IDM_VS_TOOL_CLASSVIEW_GO|IDG_VS_CLASSVIEW_SEARCH2|
|Object Browser|IDM_VS_TOOL_OBJBROWSER|IDG_VS_OBJBROWSER_SUBSETS<br /><br /> IDG_VS_OBJBROWSER_SEARCH<br /><br /> IDG_VS_OBJBROWSER_ADDREFERENCE<br /><br /> IDG_VS_OBJBROWSER_BROWSERSETTINGS|
|Object Browser|IDM_VS_TOOL_OBJECT_BROWSER_GO|IDG_VS_OBJBROWSER_SEARCH2|
|Output|IDM_VS_TOOL_OUTPUTWINDOW|IDG_VS_OUTPUTWINDOW_SELECT<br /><br /> IDG_VS_OUTPUTWINDOW_GOTO<br /><br /> IDG_VS_OUTPUTWINDOW_NEXTPREV<br /><br /> IDG_VS_OUTPUTWINDOW_CLEAR<br /><br /> IDG_VS_OUTPUTWINDOW_WORDWRAP|
|Find and Replace|IDM_VS_TOOL_UNIFIEDFIND|IDG_VS_FINDTAB<br /><br /> IDG_VS_REPLACETAB|
|Find Results 1|IDM_VS_TOOL_FINDRESULTS1|IDG_VS_FINDRESULTS1_GOTO<br /><br /> IDG_VS_FINDRESULTS1_NEXTPREV<br /><br /> IDG_VS_FINDRESULTS1_CLEAR<br /><br /> IDG_VS_FINDRESULTS1_STOPFIND|
|Find Results 2|IDM_VS_TOOL_FINDRESULTS2|IDG_VS_FINDRESULTS2_GOTO<br /><br /> IDG_VS_FINDRESULTS2_NEXTPREV<br /><br /> IDG_VS_FINDRESULTS2_CLEAR<br /><br /> IDG_VS_FINDRESULTS2_STOPFIND|
|Snippet|IDM_VS_TOOL_SNIPPETMENUS|IDG_VS_SNIPPET_REPL<br /><br /> IDG_VS_SNIPPET_REF<br /><br /> IDG_VS_SNIPPET_PROP|
|Bookmarks|IDM_VS_TOOL_BOOKMARKWIND|IDG_VS_BWNEWFOLDER<br /><br /> IDG_VS_BWNEXTBM<br /><br /> IDG_VS_BWNEXTBMF<br /><br /> IDG_VS_BWENABLE<br /><br /> IDG_VS_BWDELETE|
|Task List|IDM_VS_TOOL_TASKLIST|IDG_VS_TASKLIST_PROVIDERLIST|
|User Tasks|IDM_VS_TOOL_USERTASKS|IDG_VS_TASKLIST_PROVIDERLIST<br /><br /> IDG_VS_USERTASKS_EDIT|
|Error List|IDM_VS_TOOL_ERRORLIST|IDG_VS_ERRORLIST_ERRORGROUP<br /><br /> IDG_VS_ERRORLIST_WARNINGGROUP<br /><br /> IDG_VS_ERRORLIST_MESSAGEGROUP|
|Call Browser|IDM_VS_TOOL_CALLBROWSER1..16|IDG_VS_TOOLBAR_CALLBROWSER1_ACTIONS<br /><br /> IDG_VS_TOOLBAR_CALLBROWSER1_TYPE<br /><br /> IDG_VS_TOOLBAR_CALLBROWSER1_CBSETTINGS|
|Breakpoints|guidVSDebugGroup:IDM_BREAKPOINTS_WINDOW_TOOLBAR|IDG_BREAKPOINTS_WINDOW_NEW<br /><br /> IDG_BREAKPOINTS_WINDOW_DELETE<br /><br /> IDG_BREAKPOINTS_WINDOW_ALL<br /><br /> IDG_BREAKPOINTS_WINDOW_VIEW<br /><br /> IDG_BREAKPOINTS_WINDOW_EDIT<br /><br /> IDG_BREAKPOINTS_WINDOW_COLUMNS|
|Disassembly|guidVSDebugGroup:IDM_DISASM_WINDOW_TOOLBAR|IDG_DISASM_WINDOW_TOOLBAR|
|Memory 1-4|guidVSDebugGroup:IDM_MEMORY_WINDOW_TOOLBAR1...4|IDG_MEMORY_EXPRESSION1..4<br /><br /> IDG_MEMORY_COLUMNS1..4|
|Processes|guidVSDebugGroup:IDM_ATTACHED_PROCS_TOOLBAR|IDG_ATTACHED_PROCS_EXECCNTRL IDG_ATTACHED_PROCS_STEPPING<br /><br /> IDG_ATTACHED_PROCS_EXECCNTRL2<br /><br /> IDG_ATTACHED_PROCS_ATTACH<br /><br /> IDG_ATTACHED_PROCS_COLUMNS|

## See also
- [Add a menu controller to a toolbar](../../extensibility/adding-a-menu-controller-to-a-toolbar.md)
- [Add a toolbar to a tool window](../../extensibility/adding-a-toolbar-to-a-tool-window.md)
- [GUIDs and IDs of Visual Studio menus](../../extensibility/internals/guids-and-ids-of-visual-studio-menus.md)
