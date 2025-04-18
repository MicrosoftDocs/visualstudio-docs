---
title: Options, Text Editor, HTML (Web Forms), Formatting
description: Learn how to use the Formatting page in the HTML section to set HTML project options for formatting code in the Code Editor.
ms.date: 1/15/2019
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.HTML.Format
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
---
# Options, Text Editor, HTML (Web Forms), Formatting

Use the **Formatting** options page to set HTML project options for formatting code in the Code Editor. To access this page, on the menu bar, choose **Tools** > **Options**, and then expand **Text Editor** > **HTML (Web Forms)** > **Formatting**.

## Capitalization

When these options are selected, the Source view and XML editors apply a default case format to the names of elements and attributes when the elements are first created and during automatic formatting. The **Apply Automatic Formatting** settings determine the time at which automatic reformatting occurs.

> [!WARNING]
> XML is case-sensitive. Setting a default case can impact XML parsers.

### UIElement list

**Server tag, Server attributes**

These options specify how the markup for Web server controls is capitalized.

|Option|Result|
|---------------------------------|------------------------------|
|**As entered**|Element case is exactly as you enter it.|
|**Uppercase**|Element names are reformatted to uppercase.|
|**Lowercase**|Element names are reformatted to lowercase.|
|**Assembly definition**|Element case is determined by how the element is defined in the corresponding type class.|

**Client tag, Client attributes**

These options specify whether automatic formatting changes the names of HTML attributes and properties to uppercase or lowercase, or keeps them as entered.

|Option|Result|
|---------------------------------|------------------------------|
|**As entered**|Attribute case is exactly as you enter it.|
|**Uppercase**|Attribute names are reformatted to uppercase.|
|**Lowercase**|Attribute names are reformatted to lowercase.|

## Automatic formatting options

These options cause the Source view editor to add or remove physical line breaks during automatic formatting. You can also specify whether the editor adds quotes around attributes.

> [!NOTE]
> These settings do not alter white space within XML markup.

### UIElement list

- **Insert attribute value quotes when typing**

   When this option is selected, the editor automatically puts quotation marks around attributes as you're typing (for example: ID="Select1"). Clear this option if you prefer to insert quotation marks into your markup manually.

   > [!NOTE]
   > Whether or not this option is selected, all existing quotation marks in your markup are retained; quotation marks are never removed.

- **Insert attribute value quotes when formatting**

   When this option is selected, automatic formatting adds quotation marks around attribute values (for example: ID="Select1").

   > [!NOTE]
   > Whether or not this option is selected, all existing quotation marks in your markup are retained.

- **Auto insert close tag**

   When this option is selected, the editor automatically creates a closing tag (for example, **\</b>**) when you close the opening tag.

## Tag wrapping

These options determine whether the editor breaks tags up into lines if they go beyond a certain length.

### UIElement list

- **Wrap tags when exceeding specified length**

   When selected, the editor breaks tags across lines if the tag goes beyond the length you specify in the **Length** text box. This action occurs only when formatting the tag, not when you're typing a new tag.

   > [!NOTE]
   > The value you specify is used as a minimum value. The editor does not break up individual attributes.

- **Length**

   Specifies the number of characters to display in a line before wrapping. This input box is disabled unless the **Wrap tags when exceeding specified length** box is checked.

- **Tag Specific Options**

   Displays the **Tag Specific Options** dialog box, which lets you set formatting options for individual tags or groups of tags.

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
