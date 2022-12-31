---
title: "Window Properties dialog box in Spy++"
description: Learn how to display properties for a window that is listed in Windows View. This article has links to other articles that document the properties.
ms.custom: SEO-VS-2020
ms.date: "11/04/2016"
ms.topic: "ui-reference"
helpviewer_keywords:
  - "Window Properties dialog box"
ms.assetid: c70e9429-fb0c-452a-9626-79f168393e44
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Window Properties dialog box

[!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Use this dialog box to find out more about a specific window. To display this dialog box, move the focus to the [Windows View](windows-view.md) window. Select any window node in the tree, then choose **Properties** from the **View** menu.

## General tab, Window Properties

Use the **General** tab to show information about the selected window. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Window Caption**|The text in the window caption, or text contained in a window if it is a control.|
|**Window Handle**|The unique ID of this window. Window handle numbers are reused; they identify a window only for the lifetime of that window.|
|**Window Proc**|The virtual address of the window procedure function for this window. This field also indicates whether this window is a Unicode window, and whether it is subclassed.|
|**Rectangle**|The bounding rectangle for the window. The size of the rectangle is also displayed. Units are pixels in screen coordinates.|
|**Restored Rect**|The bounding rectangle for the restored window. The size of the rectangle is also displayed. Restored Rect will differ from Rectangle only when the window is maximized or minimized. Units are pixels in screen coordinates.|
|**Client Rect**|The bounding rectangle for the window client area. The size of the rectangle is also displayed. Units are pixels relative to the top left of the window client area.|
|**Instance Handle**|The instance handle of the application. Instance handles are not unique.|
|**Control ID or Menu Handle**|If the window being displayed is a child window, the Control ID label is displayed. Control ID is an integer that identifies this child window's control ID. If the window being displayed is not a child window, the Menu Handle label is displayed. Menu Handle is an integer that identifies the handle of the menu associated with this window.|
|**User Data**|Application-specific data that is attached to this window structure.|
|**Window Bytes**|The number of extra bytes associated with this window. The meaning of these bytes is determined by the application. Expand the list box to see the byte values in DWORD format.|

## Styles tab, Window Properties

Use the **Styles** tab to show the styles applied to the selected window. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Window Styles**|A combination of window style codes and control styles if applicable.|
|**Extended Styles**|A combination of extended window style codes.|

## Windows tab, Window Properties

Use the **Windows** tab to show information on windows related to the selected window. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Next Window**|The handle of the next sibling window in the same sequence (Z-order) shown in the window tree view ("none" if there is no next window). Choose this entry to view the properties of the next window.|
|**Previous Window**|The handle of the previous sibling window in the same sequence (Z-order) shown in the window tree view ("none" if there is no previous window). Choose this entry to view the properties of the previous window.|
|**Parent Window**|The handle of this window's parent window ("none" if there is no parent). Choose this entry to view the properties of the parent window.|
|**First Child**|The handle of this window's first child window, in the sequence (Z-order) shown in the window tree view ("none" if there are no child windows). Choose this value to view the properties of the first child window.|
|**Owner Window**|The handle of this window's owner window. An application's main window typically owns system-modal dialog windows, for example ("none" if there is no owner). Choose this entry to view the properties of the owner window.|

## Class tab, Window Properties

Use the **Class** tab to show information on the class of the selected window. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Class Name**|The name (or ordinal number) of this window class.|
|**Class Styles**|A combination of class style codes.|
|**Class Bytes**|Application-specific data associated with this window class.|
|**Class Atom**|The atom for the class returned by the **RegisterClass** call.|
|**Instance Handle**|The instance handle of the module that registered the class. Instance handles are not unique.|
|**Window Bytes**|The number of extra bytes associated with each window of this class. The meaning of these bytes is determined by the application. Expand the list box to see the byte values in DWORD format.|
|**Window Proc**|The current address of the **WndProc** function for windows of this class. This differs from **Window Proc** on the **General** tab if the window is subclassed.|
|**Menu Name**|The name of the main menu that is associated with windows of this class ("none" if there is no menu).|
|**Icon Handle**|The handle for the icon that is associated with windows of this class ("none" if there is no icon).|
|**Cursor Handle**|The handle for the cursor that is associated with windows of this class ("none" if there is no cursor).|
|**Bkgnd Brush**|The handle for the background brush that is associated with windows of this class, or one of the predefined COLOR_* colors for painting the window background ("none" if there is no brush).|

## Process tab, Window Properties

Use the **Process** tab to identify the process of the selected window. The following settings are available:

|Entry|Description|
|-----------|-----------------|
|**Process ID**|The ID of the process that owns the thread that created this window. Choose this value to view the properties of this process.|
|**Thread ID**|The ID of the thread that created this window. Choose this value to view the properties of this thread.|

## Related sections

- [Window Search dialog box](window-search-dialog-box.md): Used to find the node for a specific window in Windows view.
- [Spy++ reference](spy-increment-reference.md): Includes sections describing each Spy++ menu and dialog box.
- [Using the Finder tool](how-to-use-the-finder-tool.md): Shows how this tool scans windows for properties or messages.
- [Searching for a window in Windows View](how-to-search-for-a-window-in-windows-view.md): Explains how to find a specific window in Windows View.
- [Windows View](windows-view.md): Displays a tree view of the available windows and controls.
- [Spy++ Views](spy-increment-views.md): Explains the Spy++ tree views of windows, messages, processes, and threads.
- [Using Spy++](using-spy-increment.md): Introduces the Spy++ tool and explains how it can be used.