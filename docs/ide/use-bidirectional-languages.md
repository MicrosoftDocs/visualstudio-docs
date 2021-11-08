---
title: Support for Arabic and Hebrew
description: Learn how to display Arabic and Hebrew text and enter bidirectional text for object names and values.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- Hebrew character display [Visual Studio]
- bidirectional language support
- Arabic, creating applications
ms.assetid: b56f9795-ed8d-4452-9d49-8ca0b0145d86
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Support for bidirectional languages in Visual Studio

Visual Studio can display Arabic and Hebrew text correctly and lets you enter bidirectional text for object names and values.

> [!NOTE]
> In order to enter and display bidirectional languages, you must be working with a version of Windows that is configured with the appropriate language. This can either be an English version of Windows with the appropriate language pack installed, or the appropriately localized version of Windows.

## Fully supported features

At design time in Visual Studio, you can use bidirectional languages while entering text, naming objects, and when saving and opening files.

### Text entry

Visual Studio supports Unicode, so if your system is set to the appropriate locale and input language, you can enter text in Arabic or Hebrew. (Arabic support includes Kashida and Diacritics.)

### Arabic or Hebrew object names

You can use bidirectional languages to assign names to solutions, projects, files, folders, and so on. In code, you can use bidirectional languages for the names of variables, classes, object, attributes, metadata, and other elements. When working with Arabic, you can use any Arabic characters including Kashida and Diacritics.

The following elements can be named using Arabic or Hebrew and are handled correctly by Visual Studio:

- Solution, project, and file names, including any folders you include in the project path.

   **Solution Explorer** displays solution and element names correctly.

- File contents.

   You can open or save files with Unicode encoding or with a selected code page.

- Data elements.

   **Server Explorer** displays these elements correctly and you can edit them.

- Elements copied to the Windows Clipboard.

- Attributes and metadata.

- Property values.

   You can use Arabic or Hebrew text in the **Properties** window. The window allows you to switch between right-to-left and left-to-right reading order using standard Windows keystrokes (**Ctrl**+**RightShift** for right-to-left, and **Ctrl**+**LeftShift** for left-to-right).

- Code and literal text.

   In the code editor, you can use Arabic or Hebrew to name classes, functions, variables, properties, string literals, attributes, and so on. However, the editor does not support right-to-left reading order; text always starts at the left margin.

   > [!TIP]
   > You should place string literals in resource files instead of hard-coding them into your programs. For more information, see [Resources in desktop apps (.NET Framework)](/dotnet/framework/resources/index).

   > [!NOTE]
   > You must be consistent in how you refer to objects named in Arabic and Hebrew. For example, if you use Kashida in naming an Arabic variable, you must always use Kashida when referring to that variable or errors will result.

- Code comments. You can create comments in Arabic or Hebrew. You can also use these languages in the comment builder tool.

### File encoding

You can save and open files with a language-specific or Unicode encoding. For more information, see [How to: Save and open files with encoding](../ide/how-to-save-and-open-files-with-encoding.md).

## Right-to-left reading order

Visual Studio has limited support for right-to-left reading order. By default, text-entry controls in Visual Studio use left-to-right reading order. In most cases, you can use standard Windows gestures to switch reading order. For example, you can press **Ctrl**+**RightShift** to switch the **Properties** window to support right-to-left reading order for property values.

Right-to-left reading order is not supported in the following places in Visual Studio:

- Check boxes, drop-down lists, and other controls in Visual Studio dialog boxes always use left-to-right reading order.

- The code editor (and text editor) does not support right-to-left reading order. You can enter text in a bidirectional language, but the reading order is always left-to-right.

## See also

- [Develop globalized and localized apps](globalizing-and-localizing-applications.md)
