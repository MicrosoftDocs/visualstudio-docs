---
title: Identify and customize keyboard shortcuts
description: Learn how to identify keyboard shortcuts for Visual Studio commands, customize those shortcuts, and export them for others to use.
ms.date: 1/29/2025
ms.topic: how-to
f1_keywords:
- VS.ToolsOptionsPages.Environment.Keyboard
helpviewer_keywords:
- keyboard shortcuts [Visual Studio], customizing
- importing shortcut keys [Visual Studio]
- shortcut key combinations [Visual Studio]
- commands [Visual Studio], shortcut keys
- custom shortcut keys [Visual Studio]
- customizing keyboard shortcuts [Visual Studio]
- exporting shortcut keys [Visual Studio]
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Identify and customize keyboard shortcuts in Visual Studio

You can identify keyboard shortcuts for Visual Studio commands, customize those shortcuts, and export them for others to use. Many shortcuts always invoke the same commands, but the behavior of a shortcut might vary based on the following conditions:

- Which default environment settings you choose the first time that you open Visual Studio&mdash;for example, General development or Visual C#. For more information about changing or resetting your settings, see [Customize the Visual Studio IDE](personalizing-the-visual-studio-ide.md).

- Whether you've customized the shortcut's behavior.

- Which context you're in when you choose the shortcut. For example, the **F2** shortcut invokes the `Edit.EditCell` command if you're using the **Settings Designer**, and it invokes the `File.Rename` command if you're using **Solution Explorer**.

Regardless of settings, customization, and context, you can always find and change a keyboard shortcut in the **Options** dialog box. You can also look up the default keyboard shortcuts for several dozen commands in [Popular keyboard shortcuts](default-keyboard-shortcuts-in-visual-studio.md#popular-keyboard-shortcuts-for-visual-studio). For a complete list of all the shortcuts and their commands, see [Keyboard shortcuts in Visual Studio](default-keyboard-shortcuts-in-visual-studio.md).

If a shortcut is assigned to a command in the **Global** context and no other contexts, that shortcut always invokes that command. But a shortcut can be assigned to one command in the Global context and a different command in a specific context. If you use such a shortcut when you're in the specific context, the shortcut invokes the command for the specific context, not the Global context. For a complete list of all default shortcuts, see [Global shortcuts](default-keyboard-shortcuts-in-visual-studio.md#global-shortcuts).

> [!NOTE]
> The names and locations of menu commands and the options that appear in dialog boxes might change based on your settings and your Visual Studio edition. This page is based on the **General** development settings profile.

## Identify a keyboard shortcut

1. On the menu bar, choose **Tools** > **Options**.

1. Expand **Environment**, and then choose **Keyboard**.

    :::image type="content" source="media/tools-options-environment-keyboard.png" alt-text="Screenshot of Environment options in Visual Studio with the Keyboard option selected.":::

1. In the **Show commands containing** box, enter all or part of the name of the command without spaces.

   For example, you can find commands for `solutionexplorer`.

1. In the list, choose the correct command.

    For example, you can choose `View.SolutionExplorer`.

1. If the command has a keyboard shortcut, it appears in the **Shortcuts for selected command** list.

    :::image type="content" source="media/view-solution-explorer-command-shortcut.png" alt-text="Screenshot of the keyboard shortcut for the View.SolutionExplorer command.":::

## Customize a keyboard shortcut

1. On the menu bar, choose **Tools** > **Options**.

1. Expand **Environment**, and then choose **Keyboard**.

1. Optional: Filter the list of commands by entering all or part of the name of the command, without spaces, in the **Show commands containing** box.

1. In the list, choose the command to which you want to assign a keyboard shortcut.

   In the **Use new shortcut in** dropdown, choose the feature area in which you want to use the shortcut.

   For example, you can choose **Global** if you want the shortcut to work in all contexts. You can use any shortcut that isn't mapped (as Global) in another editor. Otherwise, the editor overrides the shortcut.

   > [!NOTE]
   > You can't assign the following keys as part of a keyboard shortcut in **Global**:
   >
   > - **Enter**, **Tab**, **Caps Lock**
   > - **PrntScn**/**SysRq**, **ScrLk**, **Pause/Break**
   > - **Insert**, **Home**, **End**, **Pg Up**, **Pg Dn**
   > - The Windows logo key, the Application key, any of the Arrow keys
   > - **NumLock**, **Delete**, or **Clear** on the numeric keypad
   > - The **Ctrl+Alt+Delete** key combination

1. In the **Press shortcut keys** box, enter the shortcut that you want to use.

    > [!NOTE]
    > You can create a shortcut that combines a letter with the **Alt** key, the **Ctrl** key, or both. You can also create a shortcut that combines the **Shift** key and a letter with the **Alt** key, the **Ctrl** key, or both.

     If a shortcut is already assigned to another command, it appears in the **Shortcut currently used by** box. In that case, choose the **Backspace** key to delete that shortcut you entered before you try a different one.

    :::image type="content" source="../ide/media/reassign-shortcut.png" alt-text="Screenshot that shows an example of how to specify a different shortcut for a command.":::

1. Choose the **Assign** button.

    > [!NOTE]
    > If you specify a different shortcut for a command, select **Assign**, and then choose **Cancel** to close the dialog box. The shortcut you assigned isn't reverted.

## Share custom keyboard shortcuts

You can share your custom keyboard shortcuts by exporting them to a file and then giving the file to others so that they can import the data.

### Export only keyboard shortcuts

1. On the menu bar, choose **Tools** > **Import and Export Settings**.

1. Choose **Export selected environment settings**, and then choose **Next**.

1. Under **What settings do you want to export?**, clear the **All Settings** check box, expand **Options**, and then expand **Environment**.

1. Select the **Keyboard** check box, and then choose **Next**.

    :::image type="content" source="../ide/media/export-shortcuts.png" alt-text="Screenshot that shows an example of how to export only customized keyboard shortcuts.":::

1. In the **What do you want to name your settings file** and **Store my settings file in this directory** boxes, either leave the default values or specify different values, and then choose **Finish**.

> [!NOTE]
> By default, your shortcuts are saved in a file in the following location:
>
> *%USERPROFILE%\AppData\Local\Microsoft\VisualStudio\1x.0_xxxxxxxx\Settings*
>
> For Visual Studio 2022, the `1x.0_xxxxxxxx` folder would start with the numerals 17.0 followed by a set of alphanumeric characters that are specific to your installation. Similarly, for Visual Studio 2019, the folder would start with the numerals 16.0.
>
> The name of the file itself reflects the date when you exported the settings, and the extension is *.vssettings*.

### Import only keyboard shortcuts

1. On the menu bar, choose **Tools** > **Import and Export Settings**.

1. Choose the **Import selected environment settings** option button, and then choose **Next**.

1. Choose the **No, just import new settings, overwriting my current settings** option button, and then choose **Next**.

1. Under **My Settings**, choose the file that contains the shortcuts that you want to import, or choose the **Browse** button to locate the correct file.

1. Choose **Next**.

1. Under **Which settings do you want to import?**, clear the **All Settings** check box, expand **Options**, and then expand **Environment**.

1. Select the **Keyboard** check box, and then choose **Finish**.

    :::image type="content" source="../ide/media/import-shortcuts.png" alt-text="Screenshot that shows an example of how to import only customized keyboard shortcuts.":::

## Related content

- [Change fonts, colors, and themes in Visual Studio](../ide/how-to-change-fonts-and-colors-in-visual-studio.md)
- [Extended function key support limitation](https://developercommunity.visualstudio.com/t/Allow-the-F17-F24-keys-to-be-used-for-ke/10482857?q=fn+keys+f16-f19)
