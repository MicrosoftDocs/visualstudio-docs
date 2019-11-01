---
title: Creating and Configuring Type Members (Class Designer)
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "vs.classdetails.method"
  - "vs.classdetails.property"
  - "vs.classdetails.parameter"
  - "vs.classdetails.event"
  - "vs.classdetails.field"
helpviewer_keywords:
  - "Class Designer [Visual Studio], member creation"
  - "type members, modifying in Class Designer"
  - "parameters [ASP.NET Web Services], adding to methods"
  - "type members, configuring"
  - "type members"
  - "members"
  - "type members, creating"
  - "members, creating"
  - "Class Designer [Visual Studio], type members"
  - "read-only information, displaying"
  - "members, configuring"
  - "methods [Visual Studio], adding parameters"
  - "Class Details window"
  - "Class Details window, member creation"
ms.assetid: 42af8738-3738-4ca7-82ff-edf573a68f96
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Create and configure type members in Class Designer

You can add these members to types on a class diagram and configure those members in the **Class Details** window:

|**Type**|**Members it can contain**|
|--------------| - |
|Class|method, property (for C# and Visual Basic), field, event (for C# and Visual Basic), constructor (method), destructor (method), constant|
|Enum|member|
|Interface|method, property, event (for C# and Visual Basic)|
|Abstract Class|method, property (for C# and Visual Basic), field, event (for C# and Visual Basic), constructor (method), destructor (method), constant|
|Structure (Struct in C#)|method, property (for C# and Visual Basic) field, event (for C# and Visual Basic), constructor (method), constant|
|Delegate|parameter|
|Module (VB Only)|method, property, field, event, constructor, constant|

> [!NOTE]
> Make property declaration more concise when a property's get and set accessors don't need additional logic by using auto-implemented properties (C# only). To show the full signature, from the **Class Diagram** menu choose **Change Members Format** > **Display Full Signature**. For more information about auto-implemented properties, see [Auto-Implemented Properties](/dotnet/csharp/programming-guide/classes-and-structs/auto-implemented-properties).

## Common tasks

|Task|Supporting content|
|----------| - |
|**Get started:** Before you create and configure type members, you must open the **Class Details** window.|- [Open the Class Details window](creating-and-configuring-type-members.md#open-the-class-details-window)<br />- [Class Details usage notes](creating-and-configuring-type-members.md#class-details-usage-notes)<br />- [Display of read-only information](creating-and-configuring-type-members.md#display-of-read-only-information)<br />- [Keyboard and mouse shortcuts in the Class Diagram and Class Details window](keyboard-and-mouse-shortcuts-in-the-class-diagram-and-class-details-window.md)|
|**Create and modify type members:** You can create new members, modify members, and add parameters to a method by using the **Class Details** window.|- [Create members](creating-and-configuring-type-members.md#create-members)<br />- [Modify type members](creating-and-configuring-type-members.md#modify-type-members)<br />- [Add parameters to methods](creating-and-configuring-type-members.md#add-parameters-to-methods)|

## Open the Class Details window

By default, the **Class Details** window appears automatically when you open a new class diagram. See [How to: Add class diagrams to projects](how-to-add-class-diagrams-to-projects.md)). You can also open the **Class Details** window in the following ways:

- Right-click on any class in the diagram to display a context menu, and then select **Class Details**.

- Select **View** > **Other Windows** > **Class Details** from the menu bar.

## Create members

You can create a member using any of the following tools:

- **Class Designer**

- **Class Details** window toolbar

- **Class Details** window

> [!NOTE]
> You can also create constructors and destructors using the procedures in this section. Please bear in mind that constructors and destructors are special kinds of methods, and as such, they appear in the **Methods** compartment in class diagram shapes and in the **Methods** section of the **Class Details** window grid.

> [!NOTE]
> The only entity you can add to a delegate is parameter. Note that the procedure entitled 'To Create a member using the **Class Details** window toolbar' is not valid for this action.

### Create a member using Class Designer

1. Right-click the type to which you want to add a member, point to **Add**, and then choose the type of member you want to add.

     A new member signature is created and added to the type. It is given a default name that you can change in **Class Designer**, the **Class Details** window, or in the **Properties** window.

2. Optionally, specify other details about the member, such as its type.

### Create a member using the Class Details window toolbar

1. On the diagram surface, select the type to which you want to add a member.

     The type obtains focus and its contents are displayed in the **Class Details** window.

2. In the **Class Details** window toolbar, click the top icon and select **New \<member>** from the drop-list.

     The cursor moves to the **Name** field in a row for the kind of member you want to add. For example, if you clicked **New Property**, the cursor moves to a new row in the **Properties** section of the **Class Details** window.

3. Type the name of the member you want to create and press Enter (or otherwise move focus, such as by pressing Tab).

     A new member signature is created and added to the type. The member now exists in code and is displayed in **Class Designer**, the **Class Details** window, and the Properties window.

4. Optionally, specify other details about the member, such as its type.

### Create a member using the Class Details window

1. On the diagram surface, select the type to which you want to add a member.

     The type obtains focus and its contents are displayed in the **Class Details** window.

2. In the **Class Details** window, in the section that contains the kind of member you want to add, click **\<add member>**. For example, if you want to add a field, click **\<add field>**.

3. Type the name of the member you want to create and press Enter.

     A new member signature is created and added to the type. The member now exists in code and is displayed in the **Class Designer**, the **Class Details** window, and the Properties window.

4. Optionally, specify other details about the member, such as its type.

    > [!NOTE]
    > You can also use keyboard shortcuts to create members. For more information, see [Keyboard and Mouse Shortcuts in the Class Diagram and Class Details window](keyboard-and-mouse-shortcuts-in-the-class-diagram-and-class-details-window.md).

## Modify type members

Class Designer enables you to modify the members of types that are displayed on the diagram. You can modify the members of any type displayed on a class diagram that are not read-only. You modify type members by using in-place editing on the design surface, Properties window, and the **Class Details** window.

All the members displayed in the **Class Details** window represent the members of the types on the class diagram. There are four kinds of members: methods, properties, fields, and events.

All member rows appear under headings that group the members by kind. For example, all properties appear under the heading **Properties**, which, as a node in the grid, can be collapsed or expanded.

Each member row displays the following elements:

- **Member Icon**

     Each kind of member is represented by its own icon. Point the mouse at the member icon to display the member's signature. Click the member icon or the whitespace to the left of the member icon to select the row.

- **Member Name**

     The **Name** column in a member row displays the name of the member. This name is also displayed in the **Name** property in the Properties window. Use this cell to change the name of any member that has read-write permissions.

     If the **Name** column is too narrow to show the whole name, pointing the mouse on the member name displays the entire name.

- **Member Type**

     The **MemberType** cell uses IntelliSense, which lets you select from a list of all the types available in the current project or referenced projects.

- **Member Modifier**

     Change the visibility modifier of a member to either `Public` (`public`), `Private` (`private`), `Friend` (`internal`) `Protected` (`protected`), `Protected Friend` (`protected internal`), or `Default`.

- **\<add member>**

     The last row in the **Class Details** window contains the text **\<add member>** in the **Name** cell. If you click this cell, you can create a new member. For more information, see [Create members](creating-and-configuring-type-members.md#create-members).

- **Member properties in the Properties window**

     The **Class Details** window displays a subset of the member properties that are displayed in the Properties window. Changing a property in one location will update the value of the property globally. This includes the display of its value in the other location.

- **Summary**

     The **Summary** cell exposes a summary of information about the member. Click the ellipsis in the **Summary** cell to view or edit information about the **Summary**, **Return Type**, and **Remarks** for the member.

- **Hide**

     When the **Hide** check box is selected, the member is not displayed in the type.

### To modify a type member

1. Using Class Designer, select a type.

2. If the **Class Details** window is not displayed, click the **Class Details** window button on the Class Designer toolbar.

3. Edit the values in the fields of the **Class Details** window grid. After each edit, press ENTER, or otherwise move focus away from the edited field, for example, by pressing TAB. Your edits reflect immediately in code.

    > [!NOTE]
    > If you want to modify only the name of a member, you can do so by using in-place editing.

## Add parameters to methods

Add parameters to methods using the **Class Details** window. Parameters can be configured to be required or optional. Providing a value for the **Optional Default** property of a parameter instructs the designer to generate code as an optional parameter.

Parameter rows contain the following items:

- **Name**

     The **Name** column in a parameter row displays the name of the parameter. This name is also displayed in the **Name** property in the Properties window. You can use this cell to change the name of any parameter with read-write permissions.

     Pointing at the parameter name displays the name of the parameter if the **Name** column is too narrow to show the entire name.

- **Type**

     The **Parameter Type** cell uses IntelliSense, which lets you choose from a list of all the types available in the current project or referenced projects.

- **Modifier**

     The **Modifier** cell in a parameter row accepts and displays the new modifier of the parameter. To enter a new parameter modifier, use the drop-down list box to select from **None**, **ref**, **out**, or **params** in C#, and **ByVal**, **ByRef**, or **ParamArray** in VB.

- **Summary**

     The **Summary** cell in a parameter row allows entering of code comments that appear in IntelliSense when entering the parameter into the code editor.

- **\<add parameter>**

     The last parameter row of a member contains the text **<add parameter\>** in the **Name** cell. Clicking this cell lets you create a new parameter. For more information, see [To add a parameter to a method](creating-and-configuring-type-members.md#add-parameters-to-methods).

The **Properties** window displays the same parameter properties displayed in the **Class Details** window: **Name**, **Type**, **Modifier**, **Summary**, as well as the **Optional Default** property. Changing a property in one location updates the value of the property globally, including the display of its value in the other location.

> [!NOTE]
> To add a parameter to a delegate, see [Create members](creating-and-configuring-type-members.md#create-members).

> [!NOTE]
> Although a destructor is a method, it cannot have parameters.

### To add a parameter to a method

1. On the diagram surface, click the type containing the method to which you want to add a parameter.

     The type obtains focus and its contents display in the **Class Details** window.

2. In the **Class Details** window, expand the row of the method to which you want to add a parameter.

     An indented parameter row appears, containing only a pair of parentheses and the words **\<add parameter>.**

3. Click **\<add parameter>**, type the name of the new parameter, and press **Enter**.

     The new parameter is added to the method and the method's code. It displays in the **Class Details** window and the Properties window.

4. Optionally, specify other details about the parameter, such as its type.

### To add an optional parameter to a method

1. On the diagram surface, click the type containing the method to which you want to add an optional parameter.

     The type obtains focus and its contents display in the **Class Details** window.

2. In the **Class Details** window, expand the row of the method to which you want to add an optional parameter.

     An indented parameter row appears, containing only a pair of parentheses and the words **\<add parameter>.**

3. Click **\<add parameter>**, type the name of the new parameter, and press **Enter**.

     The new parameter is added to the method and the method's code. It displays in the **Class Details** window and the Properties window.

4. In the Properties window, type a value for the **Optional Default** property. Setting a parameter's Optional Default property makes that parameter optional.

    > [!NOTE]
    > Optional parameters must be the last parameters in the parameter list.

## Class details usage notes

Please note the following tips for using the **Class Details** window.

### Editable and non-editable cells

All cells in the **Class Details** window are editable with a few exceptions:

- The entire type is read-only, when, for example, it resides in a referenced assembly. When you select the shape in the Class Designer, the **Class Details** window displays its details in a read-only state.

- For indexers, the name is read-only and the rest (type, modifier, summary) are editable.

- All generics have read-only parameters in the **Class Details** window. To change a generic parameter, edit its source code.

- The name of the type parameter that is defined on a generic type is read-only.

- When a type's code is broken (unparsable), **Class Details** window displays the type's contents as read-only.

### The Class Details window and source code

- You can view source code by right-clicking a shape in the **Class Details** window (or the Class Designer) and then clicking View Code. The source code file opens and scrolls to the selected element.

- Changing source code is immediately reflected in the display of signature information in the Class Designer and the **Class Details** window. If the **Class Details** window is closed at the time, the new information is visible the next time you open it.

- When a type's code is broken (unparsable), **Class Details** window displays the type's contents as read only.

### Clipboard functionality in the Class Details window

You can copy or cut fields or rows from the **Class Details** window and paste them into another type. You can cut a row only if it is not read-only. When you paste the row, **Class Details** window assigns a new name (derived from the name of the copied row) to avoid a conflict.

## Display of read-only information

Class Designer and the **Class Details** window can display the types (and members of types) for the following:

- a project that contains a class diagram

- a project referenced from a project that contains a class diagram

- an assembly referenced from a project that contains a class diagram

In the latter two cases, the referenced entity (a type or member) is read-only in the class diagram that represents it.

An entire project or portions of it, such as individual files, may be read-only. The most common cases in which a project or one of its files is read-only are when it is under source-code control (and not checked out), it exists in an external assembly, or when the operating system considers the files to be read-only.

**Source-Code Control**

Because a class diagram is saved as a file in a project, you need to check out the project in order to save any changes you make in Class Designer or the **Class Details** window.

**Read-Only Projects**

The project may be read-only for a reason other than source-code control. Closing the project displays a dialog box asking whether to overwrite the project file, discard changes (don't save) or cancel the close operation. If you choose to overwrite, project files are overwritten and made read-write. The new class diagram file is added.

**Read-Only Types**

If you try to save a project containing a type whose source-code file is read-only, the **Save of Read-Only File** dialog box appears, which gives you choices to save the file under a new name or new location, or to overwrite the read-only file. If you overwrite the file, the new copy is no longer read-only.

If a code file contains a syntax error, shapes displaying code in that file will be temporarily read-only until the syntax error is fixed. Shapes in this state display red text and a red icon which displays a tooltip reading "The source code file contains a parse error".

A referenced type (such as a .NET type), which exists under another project node or under a referenced-assembly node, is indicated on the Class Designer design surface as read-only. A local type, which exists in the project you have open, is read-write, and its shape on the Class Designer design surface is indicated as such.

Indexers are read-write in code and the **Class Details** window, but the indexer name is read-only.

You cannot edit partial methods by using the Class Designer or the **Class Details** window; you must use the Code Editor to edit them.

You cannot edit native C++ code by using the Class Designer or the **Class Details** window; you must use the Code Editor to edit native C++ code.

## See also

- [Viewing types and relationships](designing-and-viewing-classes-and-types.md)
- [Refactoring classes and types](refactoring-classes-and-types.md)
