---
title: Keyboard and Mouse Shortcuts for Class Designer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "vs.classdetails.window"
helpviewer_keywords:
  - "class diagrams, keyboard shortcuts"
  - "class diagrams, mouse shortcuts"
ms.assetid: c12d8dac-9902-4fde-b721-2a8116da53b7
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Keyboard and mouse shortcuts in the Class Diagram and Class Details window

You can use the keyboard in addition to the mouse to perform navigational actions in **Class Designer** and in the **Class Details** window.

## Use the mouse in Class Designer

The following mouse actions are supported in class diagrams:

|Mouse Combination|Context|Description|
| - |-------------|-----------------|
|Double-click|Shape elements|Opens the code editor.|
|Double-click|Lollipop connector|Expand/collapse lollipop.|
|Double-click|Lollipop connector label|Invokes **Show Interface** command.|
|Mouse Wheel|Class diagram|Scroll vertically.|
|**Shift** + Mouse Wheel|Class diagram|Scroll horizontally.|
|**Ctrl** + Mouse Wheel|Class diagram|Zoom.|
|**Ctrl**+**Shift** + click|Class diagram|Zoom.|

## Use the mouse in the Class Details window

Using a mouse, you can change the appearance of the **Class Details** window and the data it displays in the following ways:

- Clicking any editable cell lets you edit the contents of that cell. Your changes are reflected in all places that data is stored or displayed, including in the **Properties** window and in source code.

- Clicking any cell of a row causes the **Properties** window to display the properties for the element represented by that row.

- To change the width of a column, drag the boundary on the right side of the column heading until the column is the width you want.

- You can expand or collapse compartment or property nodes by clicking the arrow symbols to the left of the row.

- The **Class Details** window offers several buttons for creating new members in the current class and for navigating among the members' compartments in the **Class Details** window grid.

## Use the keyboard in Class Designer

The following keyboard actions are supported in class diagrams:

|Key|Context|Description|
|---------|-------------|-----------------|
|**Arrow keys**|Inside type shapes|Tree-style navigation on shape contents (wrapping around shape is supported). Left and right keys expand/collapse current item if it is expandable and navigate to parent if not (see tree-view navigation for detailed behavior).|
|**Arrow keys**|Top-level shapes|Moving shapes on the diagram.|
|**Shift**+**arrow keys**|Inside type shapes|Building continuous selection consisting of shape elements such as members, nested types, or compartments. These shortcuts do not support wrapping around.|
|**Home**|Inside type shapes|Navigate to the top-level shape title.|
|**Home**|Top-level shapes|Navigate to first shape on the diagram.|
|**End**|Inside type shapes|Navigate to last visible element inside the shape.|
|**End**|Top-level shapes|Navigate to the last shape on the diagram.|
|**Shift**+**Home**|Inside type shape|Selects elements within the shape starting with the current item and ending with the top-most item on the same shape.|
|**Shift**+**End**|Inside type shape|Same as **Shift**+**Home** but in top-down direction.|
|**Enter**|All contexts|Invokes default action on the shape which is also available via double-click. In most cases this is View Code but some elements define it differently (lollipops, compartment headers, lollipop labels).|
|**+** and **-**|All contexts|If currently focused element is expandable, these keys expand or collapse the element.|
|**>**|All contexts|On elements with children, this expands the element if it is collapsed and navigates to first child.|
|**<**|All contexts|Navigates to the parent element.|
|**Alt**+**Shift**+**L**|Inside type shapes + on type shapes.|Navigates to the lollipop of currently selected shape if it is present.|
|**Alt**+**Shift**+**B**|Inside type shapes + on type shapes.|If base type list is shown on the type shape and has more than one item, this toggles expansion state of the list (collapse/expand).|
|**Delete**|On type and comment shapes|Invokes **Remove from Diagram** command.|
|**Delete**|On everything else.|Invokes **Delete from Code** command (members, parameters, associations, inheritance, lollipop labels).|
|**Ctrl**+**Delete**|All contexts|Invokes **Delete from Code** command on selection.|
|**Tab**|All contexts|Navigates to next child within the same parent (supports wrapping).|
|**Shift**+**Tab**|All contexts|Navigates to previous child within the same parent (supports wrapping).|
|**Spacebar**|All contexts|Toggles selection on the current element.|

## Use the keyboard in the Class Details window

> [!NOTE]
> The following key bindings were chosen to specifically to mimic the experience of typing code.

Use the following keys to navigate the **Class Details** window:

|||
|-|-|
|Key|Result|
|**,** (comma)|If the cursor is in a parameter row, typing a comma moves the cursor to the Name field of the next parameter. If the cursor is in the last parameter row of a method, it moves the cursor to the \<add parameter> field, which you can use to create a new parameter.<br /><br /> If the cursor is elsewhere in the **Class Details** window, typing a comma literally adds a comma in the current field.|
|**;** (semicolon) or **)** (closing parenthesis)|Move the cursor to the Name field of the next member row in the **Class Details** window grid.|
|**Tab**|Moves the cursor to the next field, first moving left to right and then top to bottom. If the cursor is moving from a field in which you have typed text, **Class Details** processes that text and stores it if it does not produce an error.<br /><br /> If the cursor is on an empty field such as \<add parameter>, Tab moves it to the first field of the next row.|
|**Spacebar**|Moves the cursor to the next field, first moving left to right and then top to bottom. If the cursor is on an empty field such as \<add parameter>, it moves to the first field of the next row. Note that \<space> typed immediately after a comma is ignored.<br /><br /> If the cursor is in the Summary field, typing a space adds a space character.<br /><br /> If the cursor is in the Hide column of a given row, typing a space toggles the value of the Hide checkbox.|
|**Ctrl**+**Tab**|Switch to another document window. For example, switch from the **Class Details** window to an open code file.|
|**Esc**|If you have begun to type text in a field, pressing ESC acts as an undo key, reverting the field's contents to its previous value. If the Class Details Window has general focus, but no specific cell has focus, pressing ESC moves focus away from the **Class Details** window.|
|**Up arrow** and **down arrow**|These keys move the cursor from row to row vertically in the **Class Details** window grid.|
|**Left arrow**|If the cursor is in the Name column, pressing the left arrow collapses the current node in the hierarchy (if it is open).|
|**Right arrow**|If the cursor is in the Name column, pressing the right arrow expands the current node in the hierarchy (if it is collapsed).|

## See also

- [Create and configure type members](creating-and-configuring-type-members.md)
- [How to use the keyboard exclusively](../reference/how-to-use-the-keyboard-exclusively.md)
- [Default keyboard shortcuts in Visual Studio](../default-keyboard-shortcuts-in-visual-studio.md)
- [Keyboard shortcuts in Blend](../../xaml-tools/keyboard-shortcuts-in-blend.md)