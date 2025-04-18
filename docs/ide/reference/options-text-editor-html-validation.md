---
title: Options, Text Editor, HTML (Web Forms), Validation
description: Learn how to use the Validation page in the HTML section to set preferences for how the HTML editor checks the syntax of HTML markup in your document.
ms.date: 1/15/2019
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Text_Editor.HTML.Validation
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
---
# Options, Text Editor, HTML (Web Forms), Validation

Use the **Validation** options page to set preferences for how the HTML editor checks the syntax of HTML markup in your document. To access this page, on the menu bar, choose **Tools** > **Options**, and then expand **Text Editor** > **HTML (Web Forms)** > **Validation**.

## Validation

- **Use doctype for validation schema detection**

   A schema determines which elements, attributes, and capitalization are valid in that schema. It also determines the tags and attributes that are available in IntelliSense.

   Select this option if you want Visual Studio to use the content of the page's **<!DOCTYPE>** declaration and **html** element to determine the schema. For example, if you select this option and the page has the declaration `<!DOCTYPE html>`, Visual Studio uses the HTML5 schema. However, if the **html** tag has an **xmlns** attribute, such as `<html xmlns="http://www.w3.org/1999/xhtml">`, Visual Studio uses the XHTML5 schema.

- **Target when no doctype found**

   Choose the schema to validate against when there's no **<!DOCTYPE>** declaration in the page.

  - **Show errors**

     Select the check box to enable validation. If the check box isn't selected, the editor doesn't mark validation errors.

     The other check boxes let you fine-tune validation by specifying individual types of errors that you want the editor to mark.

     > [!NOTE]
     > Some schemas do not offer options to mark individual types of errors. For example, if you choose **XHTML 1.1** as the target schema, all option check boxes are disabled. In this instance, all types of errors are marked.

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
