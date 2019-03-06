---
title: Support for Arabic and Hebrew apps
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
  - "Hebrew character display, creating applications"
  - "bidirectional language support, about bidirectional language support"
  - "Arabic language, creating applications"
ms.assetid: b56f9795-ed8d-4452-9d49-8ca0b0145d86
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Create applications in bidirectional languages

You can use Visual Studio to create applications that correctly display text in languages written right-to-left, including Arabic and Hebrew. For some features, you can simply set properties. In other cases, you must implement features in code.

> [!NOTE]
> In order to enter and display bidirectional languages, you must be working with a version of Windows that is configured with the appropriate language. This can either be an English version of Windows with the appropriate language pack installed, or the appropriately localized version of Windows.

## Types of applications that support bidirectional languages

-  Windows apps

   You can create fully bidirectional applications that include support for bidirectional text, right-to-left reading order, and mirroring (reversing the layout of windows, menus, dialog boxes, and so on). Except for mirroring, these features are available by default or as property settings. Mirroring is supported inherently for some features, such as message boxes. However, in other cases you must implement mirroring in code. For more information, see [bidirectional support for Windows Forms applications](/dotnet/framework/winforms/advanced/bi-directional-support-for-windows-forms-applications).

-  Web apps

   Web services support sending and receiving UTF-8 and Unicode text, making them suitable for applications that involve bidirectional languages. Web client applications rely on browsers for their user interface, so the degree of bidirectional support in a web application is dependent on how well the user's browser supports those bidirectional features. In Visual Studio, you can create applications with support for Arabic or Hebrew text, right-to-left reading order, file encoding, and local culture settings. For more information, see [Bidirectional support for ASP.NET web applications](https://msdn.microsoft.com/Library/5576f9b1-9b86-41ef-8354-092d366bcd03).

Console apps do not include text support for bidirectional languages. This is a consequence of how Windows works with console applications.

## Fully supported features

At design time in Visual Studio, you can use bidirectional languages in these ways:

- **Text entry**

   Visual Studio supports Unicode, so if your system is set to the appropriate locale and input language, you can enter text in Arabic or Hebrew. (Arabic support includes Kashida and Diacritics.)

- **Object names**

   You can use bidirectional languages to assign names to solutions, projects, files, folders, and so on. In code, you can use bidirectional languages for the names of variables, classes, object, attributes, metadata, and other elements.

- **File encoding**

   You can save and open files with a language-specific or Unicode encoding. For more information, see [How to: Save and open files with encoding](../ide/how-to-save-and-open-files-with-encoding.md).

## Features with limited support

### Right-to-left reading order

By default, text-entry controls in Visual Studio use left-to-right reading order. In most cases, you can use standard Windows gestures to switch reading order. For example, you can press **Ctrl**+**RightShift** to switch the **Properties** window to support right-to-left reading order for property values. However, right-to-left reading order is not supported everywhere in Visual Studio:

- Check boxes, drop-down lists, and other controls in Visual Studio dialog boxes always use left-to-right reading order.

- The code editor (and text editor) does not support right-to-left reading order. You can enter text in a bidirectional language, but the reading order is always left-to-right.

## Arabic or Hebrew object names

You can use Arabic or Hebrew text to assign names to folders, variables, or other objects. When working with Arabic, you can use any Arabic characters including Kashida and Diacritics.

The following elements can be named using Arabic or Hebrew and are handled correctly in Visual Studio:

- Solution, project, and file names, including any folders you include in the project path. **Solution Explorer** displays solution and element names correctly.

- File contents. You can open or save files with Unicode encoding or with a selected code page.

    > [!NOTE]
    > The code editor does not support right-to-left reading order.

- Data elements. **Server Explorer** displays these elements correctly and allows you to edit them.

- Elements copied to the Windows Clipboard.

- Attributes and metadata.

- Property values. You can use Arabic or Hebrew text in the **Properties** window. The window allows you to switch between right-to-left and left-to-right reading order using standard Windows keystrokes (**Ctrl**+**RightShift** for right-to-left, and **Ctrl**+**LeftShift** for left-to-right).

- Code and literal text. In the code editor, you can use Arabic or Hebrew to name classes, functions, variables, properties, string literals, attributes, and so on. However, the editor does not support right-to-left reading order; text always starts at the left margin.

    > [!TIP]
    > You should place string literals in resource files instead of hard-coding them into your programs. For more information, see [Resources in desktop apps (.NET Framework)](/dotnet/framework/resources/index).

    > [!NOTE]
    > You must be consistent in how you refer to objects named in Arabic and Hebrew. For example, if you use Kashida in naming an Arabic variable, you must always use Kashida when referring to that variable or errors will result.

- Code comments. You can create comments in Arabic or Hebrew. You can also use these languages in the comment builder tool.