---
title: "Keyboard and Mouse Shortcuts in the Class Diagram and Class Details Window (Class Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.classdetails.window"
helpviewer_keywords:
  - "class diagrams, keyboard shortcuts"
  - "class diagrams, mouse shortcuts"
ms.assetid: c12d8dac-9902-4fde-b721-2a8116da53b7
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# Keyboard and Mouse Shortcuts in the Class Diagram and Class Details Window (Class Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the keyboard in addition to the mouse to perform navigational actions in Class Designer and in the **Class Details** window.

 **In this topic**

- [Using the Mouse in Class Designer](../ide/keyboard-and-mouse-shortcuts-in-the-class-diagram-and-class-details-window-class-designer.md#MouseClassDesigner)

- [Using the Mouse in the Class Details Window](../ide/keyboard-and-mouse-shortcuts-in-the-class-diagram-and-class-details-window-class-designer.md#MouseClassDetails)

- [Using the Keyboard in Class Designer](../ide/keyboard-and-mouse-shortcuts-in-the-class-diagram-and-class-details-window-class-designer.md#KeyboardClassDesigner)

- [Using the Keyboard in the Class Details Window](../ide/keyboard-and-mouse-shortcuts-in-the-class-diagram-and-class-details-window-class-designer.md#KeyboardClassDetails)

## <a name="MouseClassDesigner"></a> Using the Mouse in Class Designer
 The following mouse actions are supported in class diagrams:

|Mouse Combination|Context|Description|
|-----------------------|-------------|-----------------|
|Double-click|Shape elements|Opens the code editor.|
||Lollipop connector|Expand/collapse lollipop.|
||Lollipop connector label|Invokes **Show Interface** command.|
|Mouse Wheel|Class diagram|Scroll vertically.|
|SHIFT + Mouse Wheel|Class diagram|Scroll horizontally.|
|CTRL + Mouse Wheel|Class diagram|Zoom.|
|CTRL + Shift + click|Class diagram|Zoom.|

## <a name="MouseClassDetails"></a> Using the Mouse in the Class Details Window
 Using a mouse, you can change the appearance of the Class Details window and the data it displays, in the following ways:

- Clicking any editable cell lets you edit the contents of that cell. Your changes are reflected in all places that data is stored or displayed, including in the Properties window and in source code.

- Clicking any cell of a row causes the Properties window to display the properties for the element represented by that row.

- To change the width of a column, drag the boundary on the right side of the column heading until the column is the width you want.

- You can expand or collapse compartment or property nodes by clicking the arrow symbols to the left of the row.

- The Class Details Window offers several buttons for creating new members in the current class and for navigating among the members’ compartments in the Class Details Window grid. For more information, see Class Details Window Buttons.

## <a name="KeyboardClassDesigner"></a> Using the Keyboard in Class Designer
 The following keyboard actions are supported in class diagrams:

|Key|Context|Description|
|---------|-------------|-----------------|
|Arrow keys|Inside type shapes|Tree-style navigation on shape contents (wrapping around shape is supported). Left and right keys expand/collapse current item if it is expandable and navigate to parent if not (see tree-view navigation for detailed behavior).|
||Top-level shapes|Moving shapes on the diagram.|
|SHIFT+arrow keys|Inside type shapes|Building continuous selection consisting of shape elements such as members, nested types, or compartments. These shortcuts do not support wrapping around.|
|HOME|Inside type shapes|Navigate to the top-level shape title.|
||Top-level shapes|Navigate to first shape on the diagram.|
|END|Inside type shapes|Navigate to last visible element inside the shape.|
||Top-level shapes|Navigate to the last shape on the diagram.|
|SHIFT+HOME|Inside type shape|Selects elements within the shape starting with the current item and ending with the top-most item on the same shape.|
|SHIFT+END|Inside type shape|Same as SHIFT+HOME but in top-down direction.|
|ENTER|All contexts|Invokes default action on the shape which is also available via double-click. In most cases this is View Code but some elements define it differently (lollipops, compartment headers, lollipop labels).|
|+/-|All contexts|If currently focused element is expandable, these keys expand/collapse the element.|
|>|All contexts|On elements with children, this expands the element if it is collapsed and navigates to first child.|
|<|All contexts|Navigates to the parent element.|
|ALT+SHIFT+L|Inside type shapes + on type shapes.|Navigates to the lollipop of currently selected shape if it is present.|
|ALT+SHIFT+B|Inside type shapes + on type shapes.|If base type list is shown on the type shape and has more than one item, this toggles expansion state of the list (collapse/expand).|
|DELETE|On type and comment shapes|Invokes **Remove from Diagram** command.|
||On everything else.|Invokes **Delete from Code** command (members, parameters, associations, inheritance, lollipop labels).|
|CTRL+DELETE|All contexts|Invokes **Delete from Code** command on selection.|
|TAB|All contexts|Navigates to next child within the same parent (supports wrapping).|
|SHIFT+TAB|All contexts|Navigates to previous child within the same parent (supports wrapping).|
|SPACE|All contexts|Toggles selection on the current element.|

## <a name="KeyboardClassDetails"></a> Using the Keyboard in the Class Details Window

> [!NOTE]
> The following key bindings were chosen to specifically to mimic the experience of typing code.

 Use the following keys to navigate the Class Details window:

|||
|-|-|
|Key|Result|
|, (comma)|If the cursor is in a parameter row, typing a comma moves the cursor to the Name field of the next parameter. If the cursor is in the last parameter row of a method, it moves the cursor to the \<add parameter> field, which you can use to create a new parameter.<br /><br /> If the cursor is elsewhere in the Class Details Window, typing a comma literally adds a comma in the current field.|
|; (semicolon)<br /><br /> or<br /><br /> ) (close parenthesis)|Move the cursor to the Name field of the next member row in the Class Details Window grid.|
|Tab|Moves the cursor to the next field, first moving left to right and then top to bottom. If the cursor is moving from a field in which you have typed text, Class Details Window processes that text and stores it if it does not produce an error.<br /><br /> If the cursor is on an empty field such as \<add parameter>, Tab moves it to the first field of the next row.|
|\<space>|Moves the cursor to the next field, first moving left to right and then top to bottom. If the cursor is on an empty field such as \<add parameter>, it moves to the first field of the next row. Note that \<space> typed immediately after a comma is ignored.<br /><br /> If the cursor is in the Summary field, typing a space adds a space character.<br /><br /> If the cursor is in the Hide column of a given row, typing a space toggles the value of the Hide checkbox.|
|CTRL+Tab|Switch to another document window. For example, switch from the Class Details Window to an open code file.|
|ESC (Escape)|If you have begun to type text in a field, pressing ESC acts as an undo key, reverting the field's contents to its previous value. If the Class Details Window has general focus, but no specific cell has focus, pressing ESC moves focus away from the Class Details Window.|
|Up arrow and down arrow|These keys move the cursor from row to row vertically in the Class Details Window grid.|
|Left arrow|If the cursor is in the Name column, pressing the left arrow collapses the current node in the hierarchy (if it is open).|
|Right arrow|If the cursor is in the Name column, pressing the right arrow expands the current node in the hierarchy (if it is collapsed).|

## See Also
 [Creating and Configuring Type Members (Class Designer)](../ide/creating-and-configuring-type-members-class-designer.md)
