---
title: Design, visualize, & refactor with Class Designer
description: Design, visualize, and refactor classes, other types, and their relationships in your code with Class Designer in Visual Studio.
ms.date: 01/07/2025
ms.topic: conceptual
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
---
# What is Class Designer?

With the **Class Designer** tool in Visual Studio, you can design, visualize, and refactor class diagrams in C#, Visual Basic, or C++ projects. Class diagrams show the code elements and their relationships in a visual design surface, which can help you better understand your project structure and reorganize your code.

> [!NOTE]
> Class Designer is not available in .NET Core and .NET 5 and later projects.

## About class diagrams

Here's what you can do with class diagrams, in more detail:

- **Design**: Edit your project's code by editing the class diagram. Add new elements and delete unwanted ones. Your changes are reflected in code.

- **Visualize**: Understand your project's structure by viewing the classes in your project on a diagram. Customize your diagram so that you can focus on the project details that you care about the most. Save your diagram to use later for demonstration or documentation.

- **Refactor**: Override methods, rename identifiers, refactor parameters, and implement interfaces and abstract classes.

## View types and relationships

Class diagrams show the details of types, for example, their constituent members, and the relationships between them. The visualization of these entities is a dynamic view into the code. This means that you can edit types in the designer and then see your edits reflected in the source code of the entity. Similarly, the class diagram is kept in sync with changes you make to code files.

> [!NOTE]
> If your project contains a class diagram and your project references a type that's located in another project, the class diagram doesn't show the referenced type until you build the project for that type. Likewise, the diagram doesn't display changes to the code of the external entity until you rebuild the project for that entity.

### Class diagram workflow

Class diagrams can help you understand the class structure of projects. These projects might have been created by other developers, or you just need a refresher on a project you created yourself. You can use class diagrams to customize, share, and present project information with others.

The first step in presenting project information is to create a class diagram that displays what you want to show. For more information, see [Add a class diagram](how-to-add-class-diagrams-to-projects.md). You can create multiple class diagrams for a project that can be used to display a distinct view of the project, a chosen subset of the project's types, or a chosen subset of the members of types.

In addition to defining what each class diagram shows, you can also change the way that information is presented; for more information, see [Customize class diagrams](how-to-customize-class-diagrams.md).

After you have fine-tuned one or more class diagrams, you can copy them into Microsoft Office documents and print them, or export them as image files. For more information, see [Copy class diagram elements to a Microsoft Office document](how-to-copy-class-diagram-elements-to-a-microsoft-office-document.md), [Print class diagrams](how-to-print-class-diagrams.md) and [Export class diagrams as images](how-to-export-class-diagrams-as-images.md).

> [!NOTE]
> Class Designer doesn't track the location of your source files, so changing your project structure or moving source files in the project can cause Class Designer to lose track of the type, especially the source type of a typedef, base classes, or association types. You might get an error, like **Class Designer is unable to display this type**. If you do, drag the modified or relocated source code to the class diagram again to redisplay it.

## Add class diagrams to projects

To design, edit, and refactor classes and other types, add a class diagram to your C#, Visual Basic, or C++ project. To visualize different parts of the code in a project, add multiple class diagrams to the project.

::: moniker range="<=vs-2019"

You can't create class diagrams from projects that share code across multiple apps. To create UML class diagrams, see [Create UML modeling projects and diagrams](https://devblogs.microsoft.com/devops/uml-designers-have-been-removed-layer-designer-now-supports-live-architectural-analysis/).

::: moniker-end

### Install the Class Designer component

If you haven't installed the **Class Designer** component, follow these steps to install it.

1. Open **Visual Studio Installer** from the Windows Start menu, or by selecting **Tools** > **Get Tools and Features** from the menu bar in Visual Studio.

   **Visual Studio Installer** opens.
   
1. If you already have Visual Studio installed, click the **Modify** button from the options.

1. Select the **Individual components** tab, and then scroll down to the **Code tools** category.

1. Select **Class Designer** and then select **Modify**.

   ::: moniker range="vs-2019"
   :::image type="content" source="media/vs-2019/class-designer-component.png" alt-text="Screenshot of the Class Designer component in the Visual Studio Installer." lightbox="media/vs-2019/class-designer-component.png":::
   ::: moniker-end
   ::: moniker range="vs-2022"
   :::image type="content" source="media/vs-2022/class-designer-component.png" alt-text="Screenshot of the Class Designer component in the Visual Studio Installer." lightbox="media/vs-2022/class-designer-component.png":::
   ::: moniker-end

   The **Class Designer** component starts installing.

## Add a blank class diagram to a project

1. In **Solution Explorer**, right-click the project node and then choose **Add** > **New Item**. Or, press **Ctrl**+**Shift**+**A**. If a small window appears with just the option to add a code file, choose the **Show All Templates** button.

   The **Add New Item** dialog opens.

1. Expand **General**, and then select **Class Diagram** from the template list. For Visual C++ projects, look in the **Utility** category to find the **Class Diagram** template.

   > [!NOTE]
   > If you don't see the **Class Diagram** template, [follow the steps](#install-the-class-designer-component) to install the **Class Designer** component for Visual Studio. As stated earlier in this article, Class Designer is not available for .NET Core and .NET 5 and later.

   The class diagram opens in Class Designer and appears as a file that has a *.cd* extension in **Solution Explorer**. You can drag shapes and lines to the diagram from **Toolbox**, or drag a project node from Solution Explorer to add the classes in that project.

To add multiple class diagrams, repeat the steps in this procedure.

### To display the contents of a complete project in a class diagram

Open a blank class diagram, then drag the project node from Solution Explorer to the class diagram surface. An auto-populated class diagram is created.

> [!IMPORTANT]
> Class Designer is not available in .NET Core projects.

## Customize class diagrams

You can change the way that class diagrams display information. You can customize the whole diagram or the individual types on the design surface.

For example, you can adjust the zoom level of an entire class diagram, change how individual type members are grouped and sorted, hide or show relationships, and move individual or sets of types anywhere on the diagram.

> [!NOTE]
> Customizing the way that shapes appear on the diagram doesn't change the underlying code for the types represented on the diagram.

The sections that contain type members, such as the **Properties** section in a class, are called compartments. You can hide or show individual compartments and type members.

### Zoom in and out of the class diagram

1. Open and select a class diagram file in **Class Designer**.

1. On the **Class Designer** toolbar, click the **Zoom In** or **Zoom Out** button to change the zoom level of the designer surface.

     or

     Specify a particular zoom value. You can use the **Zoom** drop down list or type a valid zoom level (valid range is between 10% and 400%).

    > [!NOTE]
    > Changing the zoom level doesn't affect the scale of your class diagram printout.

### Customize grouping and sorting of type members

1. Open and select a class diagram file in **Class Designer**.

1. Right-click an empty area on the design surface and point to **Group Members**.

1. Select one of the available options:

    - **Group by Kind** separates individual type members into a grouped list of Properties, Methods, Events, and Fields. The individual groups depend on the entities definition: for example, a class doesn't display any events group if there are no events yet defined for that class.

    - **Group by Access** separates individual type members into a grouped list based on the member's access modifiers. For example, Public and Private.

    - **Sort Alphabetically** displays the items that make up an entity as a single alphabetized list. The list is sorted in ascending order.

### Hide compartments on a type

1. Open and select a class diagram file in the **Class Designer**.

1. Right click the member category in the type you want to customize (for example, select the **Methods** node in a class.

1. Click **Hide Compartment**.

     The selected compartment disappears from the type container.

### Hide individual members on a type

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the member in the type you want to hide.

1. Click **Hide**.

     The selected member disappears from the type container.

### Show hidden compartments and members on a type

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the name of the type with the hidden compartment.

1. Click **Show All Members**.

     All hidden compartments and members appear in the type container.

### Hide relationships

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the association or inheritance line that you want to hide.

1. Click **Hide** for association lines, and click **Hide Inheritance Line** for inheritance lines.

1. Click **Show All Members**.

     All hidden compartments and members appear in the type container.

### Show hidden relationships

1. Open and select a class diagram file in **Class Designer**.

1. Right-click the type with the hidden association or inheritance.

   Click **Show All Members** for association lines, and click **Show Base Class** or **Show Derived Classes** for inheritance lines.

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

### To print a class diagram

1. Open the class diagram.

1. Click **Print** on the **File** menu.

The entire class diagram prints. You may need to adjust the settings in the **Page Setup** dialog box in order to print at an appropriate size.

## Add comments to class diagrams

You can use comment shapes to annotate class diagrams. A comment shape has one property, **Text**, into which you can type text. Comment shapes exist only on the diagram surface and not in code.

A comment resides on the class diagram view in **Class Designer**. If you open a second class diagram onto the same project, comments you created in the first view aren't visible. If you delete a diagram, all the comments it contained are also deleted.

You can resize a comment shape but you can't change other aspects of its appearance, such as its background color, font, or font size.

### To add a comment

1. Drag a comment from the **Class Designer Toolbox** onto the class diagram.

1. Click in the new comment shape on the diagram and type the text you want.

## Use the mouse and keyboard shortcuts in the Class Diagram and Class Details window

You can use the keyboard in addition to the mouse to perform navigational actions in **Class Designer** and in the **Class Details** window.

### Use the mouse in Class Designer

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

### Use the mouse in the Class Details window

Using a mouse, you can change the appearance of the **Class Details** window and the data it displays in the following ways:

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

> [!NOTE]
> The following key bindings mimic the experience of typing code.

Use the following keys to navigate the **Class Details** window:

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

> [!TIP]
> For a comprehensive list of keyboard shortcuts, see [Keyboard shortcuts in Visual Studio](../default-keyboard-shortcuts-in-visual-studio.md).

## Related content

- [Create types by using Class Designer](how-to-create-types.md)
- [Work with C++ code in Class Designer](working-with-visual-cpp-code.md)
