---
title: AutoRecover, Environment, Options Dialog Box
description: Learn about the AutoRecover, Environment, Options dialog box and how it's used to specify whether or not to automatically back up files.
ms.date: 08/14/2020
ms.topic: reference
f1_keywords:
- VS.DialogAutoRestore
- VS.ToolsOptionsPages.Environment.AutoRecover
- VS.ToolsOptionsPages.Environment.Auto_Save_and_Restore
helpviewer_keywords:
- files, recovering
- AutoRecover page
- saving files, automatically
- files, saving automatically
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# AutoRecover, Environment, Options dialog box

Use this page in the **Options** dialog box to specify whether to automatically back up files or not. You can also specify if you want to restore modified files if Visual Studio shuts down unexpectedly.

To access this dialog box, go to **Tools** > **Options** > **Environment** > **AutoRecover**.

:::image type="content" source="media/autorecover-options.png" alt-text="Screenshot of the AutoRecover section in the Options dialog box":::

**Save AutoRecover information every [n] minutes**

::: moniker range=">=vs-2022"

Use this option to customize how often a file is automatically saved in the editor. For previously saved files, Visual Studio saves a copy of the file in ***%LocalAppData%\Microsoft\VisualStudio\BackupFiles\\[projectname]***. If the file is new and you haven't saved it yet, Visual Studio autosaves it by using a randomly generated file name.

::: moniker-end

::: moniker range="vs-2019"

Use this option to customize how often a file is automatically saved in the editor. For previously saved files, Visual Studio 2019 version 16.2 and later saves a copy of the file in ***%LocalAppData%\Microsoft\VisualStudio\BackupFiles\\[projectname]***. If the file is new and you haven't saved it yet, Visual Studio autosaves it by using a randomly generated file name.

> [!NOTE]
> If you are using Visual Studio 2019 version 16.1 or earlier, the file location is *%USERPROFILE%\Documents\Visual Studio [version]\Backup Files\\[projectname]*. For more information, see the [Visual Studio 2019 Release Notes History](/visualstudio/releases/2019/release-notes-history/) page.

::: moniker-end

**Keep AutoRecover information for [n] days**

Use this option to specify how long Visual Studio keeps files created for autorecovery.

### See also

- [Options dialog box](../../ide/reference/options-dialog-box-visual-studio.md)
