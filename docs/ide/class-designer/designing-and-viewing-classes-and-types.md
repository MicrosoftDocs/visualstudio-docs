---
title: Design, visualize, & refactor with Class Designer
description: Design, visualize, and refactor classes, other types, and their relationships in your code with Class Designer in Visual Studio.
ms.date: 02/23/2026
ms.topic: concept-article
f1_keywords:
- vs.classdesigner.diagram
- vs.classdesigner.enum
- vs.classdesigner.exportdialog
- vs.classdesigner.comment
- vs.classdetails.window
helpviewer_keywords:
- Class Designer [Visual Studio]
- Class Designer, about Class Designer
- types [Visual Studio], viewing
- classes [Visual Studio], viewing
- class designer
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ai-usage: ai-assisted
ms.custom: "awp-ai"
---
# Design, visualize, and refactor classes with Class Designer

Use **Class Designer** in Visual Studio to visualize your code structure, design new classes, and refactor existing types—all from an interactive diagram.

With Class Designer, you can create class diagrams that show code elements and their relationships on a visual design surface. This view helps you understand your project structure and reorganize your code more effectively.

## Prerequisites

- Visual Studio with the **Class Designer** component installed. See [Install the Class Designer component](#install-the-class-designer-component).
- A C#, Visual Basic, or C++ project that targets .NET Framework. Class Designer doesn't support .NET Core, .NET 5, or later.

## What you can do with class diagrams

Class diagrams support three main workflows:

- **Design**: Edit your project's code by editing the class diagram. Add new elements and delete unwanted ones. Your changes are reflected in code.

- **Visualize**: Understand your project's structure by viewing classes on a diagram. Customize your diagram to focus on the details that matter most. Save diagrams for documentation or presentations.

- **Refactor**: Override methods, rename identifiers, refactor parameters, and implement interfaces and abstract classes.

## View types and relationships

Class diagrams display type details—including members, properties, and methods—along with the relationships between types. The diagram provides a dynamic, two-way view of your code:

- Edit types in the designer, and your changes appear in the source code.
- Edit source code files, and the class diagram updates automatically.

If your project references a type in another project, the class diagram doesn't show that type until you build the referenced project. Likewise, the diagram doesn't display changes to external code until you rebuild that project.

### Typical workflow

Class diagrams help you understand code structure, whether you're working with code created by other developers or revisiting your own projects. Use class diagrams to customize, share, and present project information.

To get started, [add a class diagram](how-to-add-class-diagrams-to-projects.md) that displays the types you want to explore. You can create multiple class diagrams per project to show different views—a subset of types, specific members, or the entire project structure.

You can also [customize how class diagrams display information](how-to-customize-class-diagrams.md), including grouping, sorting, and visibility options.

When your diagrams are ready, you can:

- [Copy diagram elements to Microsoft Office documents](how-to-copy-class-diagram-elements-to-a-microsoft-office-document.md)
- [Print class diagrams](how-to-print-class-diagrams.md)
- [Export diagrams as images](how-to-export-class-diagrams-as-images.md)

Class Designer doesn't track source file locations. If you move or rename source files, Class Designer might lose track of types (especially typedefs, base classes, or association types) and display an error like **Class Designer is unable to display this type**. To fix this, drag the modified or relocated source file onto the class diagram to redisplay the type.

## Add class diagrams to projects

Add a class diagram to your project to start designing, editing, and refactoring classes. You can add multiple diagrams to visualize different parts of your codebase.


### Install the Class Designer component

If you don't have the **Class Designer** component installed, follow these steps:

1. Open **Visual Studio Installer** from the Windows Start menu, or by selecting **Tools** > **Get Tools and Features** from the menu bar in Visual Studio.

   **Visual Studio Installer** opens.
   
1. If you already have Visual Studio installed, select **Modify**.

1. Select the **Individual components** tab, and then scroll down to the **Code tools** category.

1. Select **Class Designer** and then select **Modify**.

   ::: moniker range=">=vs-2022"
   :::image type="content" source="media/vs-2022/class-designer-component.png" alt-text="Screenshot of the Class Designer component in the Visual Studio Installer." lightbox="media/vs-2022/class-designer-component.png":::
   ::: moniker-end

   The **Class Designer** component starts installing.

1. When installation completes, restart Visual Studio. The **Class Diagram** template is now available in the **Add New Item** dialog.

## Add a blank class diagram to a project

1. In **Solution Explorer**, right-click the project node and then choose **Add** > **New Item**. Or, press **Ctrl**+**Shift**+**A**. If a small window appears with just the option to add a code file, choose the **Show All Templates** button.

   The **Add New Item** dialog opens.

1. Expand **General**, and then select **Class Diagram** from the template list. For Visual C++ projects, look in the **Utility** category to find the **Class Diagram** template.

   If you don't see the **Class Diagram** template, [install the Class Designer component](#install-the-class-designer-component) first.

   The class diagram opens in Class Designer and appears as a file that has a *.cd* extension in **Solution Explorer**. You can drag shapes and lines to the diagram from **Toolbox**, or drag a project node from Solution Explorer to add the classes in that project.

To add multiple class diagrams, repeat the steps in this procedure.

### Display the contents of a complete project

To create a class diagram that shows all types in a project:

1. Open a blank class diagram.
1. Drag the project node from **Solution Explorer** to the class diagram surface.

An auto-populated class diagram is created with all types from the project.

## Customize class diagrams

Customize how class diagrams display information to focus on what matters most for your task. You can adjust the entire diagram or individual types.

Customization options include:

- Adjust the zoom level
- Change how members are grouped and sorted
- Hide or show relationships
- Move types anywhere on the diagram

Customizing the diagram appearance doesn't change the underlying code.

The sections that contain type members, such as the **Properties** section in a class, are called *compartments*. You can hide or show individual compartments and type members.

### Zoom in and out

1. Open and select a class diagram file in **Class Designer**.

1. On the **Class Designer** toolbar, select **Zoom In** or **Zoom Out** to change the zoom level.

   Alternatively, use the **Zoom** dropdown list or type a zoom value (10% to 400%).

Changing the zoom level doesn't affect the scale of printed diagrams.

### Customize grouping and sorting of type members

1. Open and select a class diagram file in **Class Designer**.

1. Right-click an empty area on the design surface and point to **Group Members**.

1. Select one of the available options:

    - **Group by Kind** separates individual type members into a grouped list of Properties, Methods, Events, and Fields. The individual groups depend on the entities definition: for example, a class doesn't display any events group if there are no events yet defined for that class.

    - **Group by Access** separates individual type members into a grouped list based on the member's access modifiers. For example, Public and Private.

    - **Sort Alphabetically** displays the items that make up an entity as a single alphabetized list. The list is sorted in ascending order.

### Hide compartments on a type

1. Open and select a class diagram file in the **Class Designer**.

1. Right-click the member category in the type you want to customize (for example, select the **Methods** node in a class).

1. Select **Hide Compartment**.

   The selected compartment disappears from the type container.

### Hide individual members on a type

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the member in the type you want to hide.

1. Select **Hide**.

   The selected member disappears from the type container.

### Show hidden compartments and members on a type

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the name of the type with the hidden compartment.

1. Select **Show All Members**.

   All hidden compartments and members appear in the type container.

### Hide relationships

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the association or inheritance line that you want to hide.

1. Select **Hide** for association lines, or select **Hide Inheritance Line** for inheritance lines.

   The selected relationship line disappears from the diagram.

### Show hidden relationships

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the type with the hidden association or inheritance.

1. Select **Show All Members** for association lines, or select **Show Base Class** or **Show Derived Classes** for inheritance lines.

   The hidden relationship lines reappear on the diagram.

### Remove a shape from a class diagram
You can remove a type shape from the class diagram without affecting the type's underlying code. Removing type shapes from a class diagram affects only that diagram: the underlying code that defines the type and other diagrams that display the type aren't affected.

1. On the class diagram, select the type shape you want to remove from the diagram.

1. On the **Edit** menu, choose **Remove from Diagram**.

     The type shape and any lines of association or inheritance connected to the shape no longer appear on the diagram.

### Delete a type shape and its underlying code

1. Right-click the shape on the design surface.

1. Select **Delete Code** from the context menu.

     The shape is removed from the diagram and its underlying code is deleted from the project.

## Copy class diagram elements to a Microsoft Office document

You can copy shapes from a .NET class diagram (*.cd* file) to other documents. You'll either get a copy of the shape or its underlying code, based on the kind of document where you paste it. To copy shapes from UML class diagrams in a modeling project, see [Export diagrams as images](../../modeling/export-diagrams-as-images.md).

### Copy a single element

Right-click the shape and choose **Copy Image**.

### Copy several elements

1. Select the shapes on the diagram that you want to copy.

1. Right-click your selection and choose **Copy Image**.

### Copy all the elements in a class diagram

1. Right-click the diagram surface and choose **Select All**, or press **Ctrl**+**A**.

1. On the **Edit** menu, select **Copy Image**.

You can also choose **Copy** instead of **Copy Image**. **Copy** copies the image as a regular bitmap. **Copy Image** copies the image as a vector-based image, which is better for most Office applications.

## Export class diagrams as images

To export a class diagram that you created from code in a project, save the diagram as an image. If you want to export UML class diagrams instead, see [Export diagrams as images](../../modeling/export-diagrams-as-images.md).

### Export a diagram

1. Open your class diagram (*.cd*) file.

1. From the **Class Diagram** menu or the diagram surface shortcut menu, choose **Export Diagram as Image**.

1. Select a diagram.

1. Select the format that you want.

1. Choose **Export** to finish exporting.

To automatically update exported images that are linked from other documents, export the diagram again in Visual Studio.

## Print class diagrams

You can print a class diagram using the print feature of Visual Studio.

### Print a class diagram

1. Open the class diagram.

1. Select **File** > **Print**.

   The entire class diagram prints. You might need to adjust the settings in the **Page Setup** dialog box to print at an appropriate size.

## Add comments to class diagrams

You can use comment shapes to annotate class diagrams. A comment shape has one property, **Text**, into which you can type text. Comment shapes exist only on the diagram surface and not in code.

A comment resides on the class diagram view in **Class Designer**. If you open a second class diagram onto the same project, comments you created in the first view aren't visible. If you delete a diagram, all the comments it contained are also deleted.

You can resize a comment shape but you can't change other aspects of its appearance, such as its background color, font, or font size.

### Add a comment

1. Drag a comment from the **Class Designer Toolbox** onto the class diagram.

1. Select the new comment shape on the diagram and type the text you want.

   The comment appears on the diagram surface.

## Keyboard and mouse shortcuts

Use keyboard shortcuts and mouse actions (or another pointing device) to navigate efficiently in **Class Designer** and the **Class Details** window. These shortcuts help you work faster without switching to menu commands.

### Use the mouse in Class Designer

The following pointing device actions are supported in class diagrams:

|Mouse Combination|Context|Description|
| - |-------------|-----------------|
|Double-click|Shape elements|Opens the code editor.|
|Double-click|Lollipop connector|Expand/collapse lollipop.|
|Double-click|Lollipop connector label|Invokes **Show Interface** command.|
|Mouse Wheel|Class diagram|Scroll vertically.|
|**Shift** + Mouse Wheel|Class diagram|Scroll horizontally.|
|**Ctrl** + Mouse Wheel|Class diagram|Zoom.|
|**Ctrl**+**Shift** + click|Class diagram|Zoom.|

### Use the mouse in the Class Details window

Using a mouse or other pointing device, you can change the appearance of the **Class Details** window and the data it displays in the following ways:

- Clicking any editable cell lets you edit the contents of that cell. Your changes are reflected in all places that data is stored or displayed, including in the **Properties** window and in source code.

- Clicking any cell of a row causes the **Properties** window to display the properties for the element represented by that row.

- To change the width of a column, drag the boundary on the right side of the column heading until the column is the width you want.

- You can expand or collapse compartment or property nodes by clicking the arrow symbols to the left of the row.

- The **Class Details** window offers several buttons for creating new members in the current class and for navigating among the members' compartments in the **Class Details** window grid.

### Use the keyboard in Class Designer

The following keyboard actions are supported in class diagrams:

|Key|Context|Description|
|---------|-------------|-----------------|
|**Arrow keys**|Inside type shapes|Tree-style navigation on shape contents (wrapping around shape is supported). Left and right keys expand/collapse current item if it's expandable and navigate to parent if not (see tree-view navigation for detailed behavior).|
|**Arrow keys**|Top-level shapes|Moving shapes on the diagram.|
|**Shift**+**arrow keys**|Inside type shapes|Building continuous selection consisting of shape elements such as members, nested types, or compartments. These shortcuts do not support wrapping around.|
|**Home**|Inside type shapes|Navigate to the top-level shape title.|
|**Home**|Top-level shapes|Navigate to first shape on the diagram.|
|**End**|Inside type shapes|Navigate to last visible element inside the shape.|
|**End**|Top-level shapes|Navigate to the last shape on the diagram.|
|**Shift**+**Home**|Inside type shape|Selects elements within the shape starting with the current item and ending with the top-most item on the same shape.|
|**Shift**+**End**|Inside type shape|Same as **Shift**+**Home** but in top-down direction.|
|**Enter**|All contexts|Invokes default action on the shape, which is also available via double-click. In most cases this is View Code but some elements define it differently (lollipops, compartment headers, lollipop labels).|
|**+** and **-**|All contexts|If currently focused element is expandable, these keys expand or collapse the element.|
|**>**|All contexts|On elements with children, this expands the element if it's collapsed and navigates to first child.|
|**<**|All contexts|Navigates to the parent element.|
|**Alt**+**Shift**+**L**|Inside type shapes + on type shapes.|Navigates to the lollipop of currently selected shape if it's present.|
|**Alt**+**Shift**+**B**|Inside type shapes + on type shapes.|If base type list is shown on the type shape and has more than one item, this toggles expansion state of the list (collapse/expand).|
|**Delete**|On type and comment shapes|Invokes **Remove from Diagram** command.|
|**Delete**|On everything else.|Invokes **Delete from Code** command (members, parameters, associations, inheritance, lollipop labels).|
|**Ctrl**+**Delete**|All contexts|Invokes **Delete from Code** command on selection.|
|**Tab**|All contexts|Navigates to next child within the same parent (supports wrapping).|
|**Shift**+**Tab**|All contexts|Navigates to previous child within the same parent (supports wrapping).|
|**Spacebar**|All contexts|Toggles selection on the current element.|

### Use the keyboard in the Class Details window

The following key bindings mimic the experience of typing code. Use these keys to navigate the **Class Details** window:

|Key|Result|
|-|-|
|**,** (comma)|If the cursor is in a parameter row, typing a comma moves the cursor to the Name field of the next parameter. If the cursor is in the last parameter row of a method, it moves the cursor to the \<add parameter> field, which you can use to create a new parameter.<br /><br /> If the cursor is elsewhere in the **Class Details** window, typing a comma literally adds a comma in the current field.|
|**;** (semicolon) or **)** (closing parenthesis)|Move the cursor to the Name field of the next member row in the **Class Details** window grid.|
|**Tab**|Moves the cursor to the next field, first moving left to right and then top to bottom. If the cursor is moving from a field in which you have typed text, **Class Details** processes that text and stores it if it doesn't produce an error.<br /><br /> If the cursor is on an empty field such as \<add parameter>, Tab moves it to the first field of the next row.|
|**Spacebar**|Moves the cursor to the next field, first moving left to right and then top to bottom. If the cursor is on an empty field such as \<add parameter>, it moves to the first field of the next row. Note that \<space> typed immediately after a comma is ignored.<br /><br /> If the cursor is in the Summary field, typing a space adds a space character.<br /><br /> If the cursor is in the Hide column of a given row, typing a space toggles the value of the Hide checkbox.|
|**Ctrl**+**Tab**|Switch to another document window. For example, switch from the **Class Details** window to an open code file.|
|**Esc**|If you have begun to type text in a field, pressing ESC acts as an undo key, reverting the field's contents to its previous value. If the Class Details Window has general focus, but no specific cell has focus, pressing ESC moves focus away from the **Class Details** window.|
|**Up arrow** and **down arrow**|These keys move the cursor from row to row vertically in the **Class Details** window grid.|
|**Left arrow**|If the cursor is in the Name column, pressing the left arrow collapses the current node in the hierarchy (if it's open).|
|**Right arrow**|If the cursor is in the Name column, pressing the right arrow expands the current node in the hierarchy (if it's collapsed).|

For a comprehensive list of keyboard shortcuts, see [Keyboard shortcuts in Visual Studio](../default-keyboard-shortcuts-in-visual-studio.md).

## Related content

- [Add class diagrams to projects](how-to-add-class-diagrams-to-projects.md)
- [Create types by using Class Designer](how-to-create-types.md)
- [Work with C++ code in Class Designer](working-with-visual-cpp-code.md)
- [Refactor classes and types](refactoring-classes-and-types.md)
- [Keyboard shortcuts in Visual Studio](../default-keyboard-shortcuts-in-visual-studio.md)
