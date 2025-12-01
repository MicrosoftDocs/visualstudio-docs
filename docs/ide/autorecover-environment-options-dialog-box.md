---
title: Set AutoRecover options
description: Learn about the AutoRecover, Environment, Options dialog box and how it's used to specify whether or not to automatically back up files.
ms.date: 11/07/2025
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
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Set AutoRecover options

You can configure Visual Studio to automatically back up files or not. You can also specify if you want to restore modified files if Visual Studio shuts down unexpectedly.

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane, and expand the **All Settings** > **Environment** > **AutoRecover** section.

   :::image type="content" source="media/visualstudio/autorecover-options.png" alt-text="Screenshot of the AutoRecover section in the Visual Studio Options pane.":::

1. Select the **Automatically back up unsaved files** checkbox.

   Use this option to instruct Visual Studio to automatically save files that are open in the editor. For previously saved files, Visual Studio saves a copy of the file in *%LocalAppData%\Microsoft\VisualStudio\BackupFiles\\[projectname]*. If the file is new and unsaved, Visual Studio autosaves it by using a randomly generated file name.

1. Set the **Backup interval (minutes)** to the number of minutes between automatics file saves.

1. Set the **Autorecover information lifetime (days)** to the number of days a saved file can be auto-recovered from a backup. In other words, the maximum age of a backup. <!-- TBD: Confirm description -->

:::moniker-end
:::moniker range="vs-2022"

1. Open the **Tools** > **Options** dialog, and expand the **Environment** > **AutoRecover** section.

   :::image type="content" source="media/autorecover-options.png" alt-text="Screenshot of the AutoRecover section in the Options dialog.":::

2. Select the **Save AutoRecover information every [n] minutes** checkbox and specify the number of minutes.

   Use this option to customize how often a file is automatically saved in the editor. For previously saved files, Visual Studio saves a copy of the file in *%LocalAppData%\Microsoft\VisualStudio\BackupFiles\\[projectname]*. If the file is new and unsaved, Visual Studio autosaves it by using a randomly generated file name.

:::moniker-end
:::moniker range="<=vs-2019"

1. Open the **Tools** > **Options** dialog, and expand the **Environment** > **AutoRecover** section.

   :::image type="content" source="media/autorecover-options.png" alt-text="Screenshot of the AutoRecover section in the Options dialog.":::

2. Select the **Save AutoRecover information every [n] minutes** checkbox and specify the number of minutes.

   Use this option to customize how often a file is automatically saved in the editor. For previously saved files, Visual Studio 2019 version 16.2 and later saves a copy of the file in *%LocalAppData%\Microsoft\VisualStudio\BackupFiles\\[projectname]*. If the file is new and unsaved, Visual Studio autosaves it by using a randomly generated file name.

   > [!NOTE]
   > If you're using Visual Studio 2019 version 16.1 or earlier, the file location is *%USERPROFILE%\Documents\Visual Studio [version]\Backup Files\\[projectname]*. For more information, see the [Visual Studio 2019 Release Notes History](/visualstudio/releases/2019/release-notes-history/) page.

:::moniker-end
:::moniker range="<=vs-2022"

3. Select the **Keep AutoRecover information for [n] days** checkbox and specify the number of days.

   Use this option to specify how long Visual Studio keeps files created for autorecovery.

4. Select **OK**.

:::moniker-end

### See also

- [Options dialog box](../ide/reference/options-dialog-box-visual-studio.md)
