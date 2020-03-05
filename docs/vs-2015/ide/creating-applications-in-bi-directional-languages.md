---
title: "Creating Applications in Bi-directional Languages | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Hebrew character display, creating applications"
  - "bi-directional language support, about bi-directional language support"
  - "Arabic language, creating applications"
ms.assetid: b56f9795-ed8d-4452-9d49-8ca0b0145d86
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: jillfra
---
# Creating Applications in Bi-directional Languages
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use Visual Studio to create applications that correctly display text in languages written right-to-left, including Arabic and Hebrew. For some features, you can simply set properties. In other cases, you must implement features in code.

> [!NOTE]
> In order to enter and display bi-directional languages, you must be working with a version of Windows that is configured with the appropriate language. This can either be an English version of Windows with the appropriate language pack installed, or the appropriately localized version of Windows.

## Types of Application that Support Bi-Directional Languages

1. Windows applications. You can create fully bi-directional applications that include support for bi-directional text, right-to-left reading order, and mirroring (reversing the layout of windows, menus, dialog boxes, and so on). Except for mirroring, these features are available by default or as property settings. Mirroring is supported inherently for some features, such as message boxes. However, in other cases you must implement mirroring in code. For more information, see [Bi-Directional Support for Windows Forms Applications](https://msdn.microsoft.com/library/7b622fa4-f390-4e4d-b624-83a1917cccf2).

2. Web applications. Web services support and receiving sending UTF-8 and Unicode text, making them suitable for applications involving bi-directional languages. Web client applications rely on browsers for their user interface, so the degree of bi-directional support in a Web application is dependent on how well the user's browser supports those bi-directional features. In Visual Studio, you can create applications with support for Arabic or Hebrew text, right-to-left reading order, file encoding, and local culture settings. For more information, see [Bidirectional Support for ASP.NET Web Applications](https://msdn.microsoft.com/library/5576f9b1-9b86-41ef-8354-092d366bcd03).

3. Console applications. Console applications do not include text support for bi-directional languages. This is a consequence of how Windows works with console applications.

## Visual Studio Features That Are Fully Supported
 At design time in Visual Studio, you can use bi-directional languages in these ways:

- **Text entry** Visual Studio supports Unicode, so if your system is set to the appropriate locale and input language, you can enter text in Arabic or Hebrew. (Arabic support includes Kashida and Diacritics.)

- **Object names** You can use bi-directional languages to assign names to solutions, projects, files, folders, and so on. In code, you can use bi-directional languages for the names of variables, classes, object, attributes, metadata, and other elements.

- **File encoding** You can save and open files with a language-specific or Unicode encoding. For more information, see [How to: Save and Open Files with Encoding](../ide/how-to-save-and-open-files-with-encoding.md).

## Features with Limited or No Support
 Other features common to bi-directional language applications are not fully supported in Visual Studio, or in some cases, not at all. These include:

- **Right-to-left reading order** By default, text-entry controls you use in Visual Studio use left-to-right reading order. In most cases, you can use standard Windows gestures to switch reading order. For example, you can press Ctrl+Right Shift to switch the Properties window to support right-to-left reading order for property values.

  However, right-to-left reading order is not supported everywhere in Visual Studio. Exceptions include:

  - Check boxes, drop-down lists, and other controls in Visual Studio dialog boxes always use left-to-right reading order.

  - The code editor (and text editor) does not support right-to-left reading order. You can enter text in a bi-directional language, but the reading order is always left-to-right.

## Naming Things Using Arabic or Hebrew Text
 You can use Arabic or Hebrew text to assign names to folders, variables, or other objects. When working with Arabic, you can use any Arabic characters including Kashida and Diacritics.

 The following elements can be named using Arabic or Hebrew and will be handled correctly in Visual Studio:

- Solution, project, and file names, including any folders you include in the project path. Solution Explorer will display solution and element names correctly.

- File contents. You can open or save files with Unicode encoding or with a selected code page.

    > [!NOTE]
    > The code editor is a special case. For details, see below.

- Data elements. **Server Explorer** will display these elements correctly and allow you to edit them.

- Elements copied to the Windows Clipboard.

- Attributes and metadata.

- Property values. You can use Arabic or Hebrew text in the Properties window. The window allows you to switch between right-to-left and left-to-right reading order using standard Windows keystrokes (CTRL+RightShift for right-to-left, and CTRL+LeftShift for left-to-right).

- Code and literal text. In the code editor (which is also the text editor), you can use Arabic or Hebrew to name classes, functions, variables, properties, string literals, attributes, and so on. However, the editor does not support right-to-left reading order; text always starts at the left margin.

    > [!TIP]
    > It is recommended that you place string literals in resource files instead of hard-coding them into your programs. For more information, see [Walkthrough: Localizing Windows Forms](https://msdn.microsoft.com/9a96220d-a19b-4de0-9f48-01e5d82679e5).

    > [!NOTE]
    > You must be consistent in how you refer to objects named in these languages. For example, if you use Kashida in naming an Arabic variable, you must always use Kashida when referring to that variable, or errors will result.

- Code comments. You can create comments in Arabic or Hebrew. You can also use these languages in the comment builder tool.

## See Also
 [Bi-Directional Support for Windows Forms Applications](https://msdn.microsoft.com/library/7b622fa4-f390-4e4d-b624-83a1917cccf2)
 [Bidirectional Support for ASP.NET Web Applications](https://msdn.microsoft.com/library/5576f9b1-9b86-41ef-8354-092d366bcd03)
 [Globalizing Applications](../ide/globalizing-applications.md)
 [Localizing Applications](../ide/localizing-applications.md)
