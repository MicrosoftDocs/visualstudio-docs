---
title: Visual Basic Defaults, Projects, Options Dialog Box
description: Learn how to use the Visual Basic Defaults page in the Projects and Solutions section to specify the default settings for Visual Basic project options.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Projects.VBDefaults
helpviewer_keywords:
- Option Explicit statement, setting in the IDE
- Option Compare statement, setting in the IDE
- Option Strict statement, setting in the IDE
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Visual Basic Defaults, Projects, Options Dialog Box

Specifies the default settings for Visual Basic project options. When a new project is created, the specified option statements will be added to the project header in the Code Editor. The options apply to all Visual Basic projects.

To access this dialog box, on the **Tools** menu, click **Options**, expand the **Projects and Solutions** folder, and then click **VB Defaults**.

 **Option Explicit**

Sets the compiler default so that explicit declarations of variables are required. By default, **Option Explicit** is set to **On**. For more information, see [/optionexplicit](/dotnet/visual-basic/reference/command-line-compiler/optionexplicit).

 **Option Strict**

Sets the compiler default so that explicit narrowing conversions are required and late binding is not allowed. By default, **Option Strict** is set to **Off**. For more information, see [/optionstrict](/dotnet/visual-basic/reference/command-line-compiler/optionstrict).

 **Option Compare**

Sets the compiler default for string comparisons: binary (case-sensitive) or text (case-insensitive.) By default, **Option Compare** is set to **Binary**. For more information, see [/optioncompare](/dotnet/visual-basic/reference/command-line-compiler/optioncompare).

 **Option Infer**

Sets the compiler default for local type inference. By default, **Option Infer** is set to **On** for newly created projects and to **Off** for migrated projects created in earlier versions of Visual Basic. For more information, see [/optioninfer](/dotnet/visual-basic/reference/command-line-compiler/optioninfer).

## See also

- [Solutions and Projects](../../ide/solutions-and-projects-in-visual-studio.md)
