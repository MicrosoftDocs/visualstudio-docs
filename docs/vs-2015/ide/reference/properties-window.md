---
title: "Properties Window | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "properties [Visual Studio], Properties Window"
  - "handler functions, Properties window"
  - "handlers, Properties window"
  - "Windows messages"
  - "properties [Visual Studio], setting at design time"
  - "properties [Visual Studio], editing"
  - "Property Browser"
  - "Windows messages, adding message handlers"
  - "Properties window, overrides"
  - "virtual functions, Properties window"
  - "Properties window"
ms.assetid: e6e0fa4f-75c4-4a52-af15-281cd61876ca
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# Properties Window
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Use this window to view and change the design-time properties and events of selected objects that are located in editors and designers. You can also use the **Properties** window to edit and view file, project, and solution properties. You can find **Properties** Window on the **View** menu. You can also open it by pressing F4 or by typing **Properties** in the **Quick Launch** window.

 The **Properties** window displays different types of editing fields, depending on the needs of a particular property. These edit fields include edit boxes, drop-down lists, and links to custom editor dialog boxes. Properties shown in gray are read-only.

## UIElement List
 Object name
 Lists the currently selected object or objects. Only objects from the active editor or designer are visible. When you select multiple objects, only properties common to all selected objects appear.

 Categorized
 Lists all properties and property values for the selected object, by category. You can collapse a category to reduce the number of visible properties. When you expand or collapse a category, you see a plus (+) or minus (-) to the left of the category name. Categories are listed alphabetically.

 Alphabetical
 Alphabetically sorts all design-time properties and events for selected objects. To edit an undimmed property, click in the cell to its right and enter changes.

 Property Pages
 Displays the **Property Pages** dialog box or **Project Designer** for the selected item. Property Pages displays a subset, the same or a superset of the properties available in the **Properties** window. Use this button to view and edit properties related to your project's active configuration.

 Properties
 Displays the properties for an object. Many objects also have events that can be viewed using the **Properties** window.

 Sort by Property Source
 Groups properties by source, such as inheritance, applied styles, and bindings. Only available when editing XAML files in the designer.

 Events
 Displays the events for an object.

> [!NOTE]
> This **Properties** window toolbar control is only available when a form or control designer is active in the context of a [!INCLUDE[csprcs](../../includes/csprcs-md.md)] project. When editing XAML files, events appear on a separate tab of the properties window.

 Messages
 Lists all Windows messages. Allows you to add or delete specified handler functions for the messages provided for the selected class.

> [!NOTE]
> This **Properties** window toolbar control is only available when **Class View** is the active window in the context of a [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] project.

 Overrides
 Lists all virtual functions for the selected class and allows you to add or delete overriding functions.

> [!NOTE]
> This **Properties** window toolbar control is only available when **Class View** is the active window in the context of a [!INCLUDE[vcprvc](../../includes/vcprvc-md.md)] project.

 Description pane
 Shows the property type and a short description of the property. You can turn the description of the property off and on using the Description command on the shortcut menu.

> [!NOTE]
> This **Properties** window toolbar control is not available when editing XAML files in the designer.

 Thumbnail view
 Shows a visual representation of the currently selected element when editing XAML files in the designer.

 Search
 Provides a Search function for properties and events when editing XAML files in the designer. The search box responds to partial word searches and updates search results as you type.

## See Also
 [Project Properties Reference](../../ide/reference/project-properties-reference.md)
 [Customizing window layouts](../../ide/customizing-window-layouts-in-visual-studio.md)
