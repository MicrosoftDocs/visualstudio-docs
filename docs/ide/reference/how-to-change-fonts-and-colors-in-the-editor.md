---
title: Change editor fonts and colors
description: Learn how to change the default font face, adjust the font size, and change the foreground and background colors for various text display items in the code editor.
ms.date: 10/31/2021
ms.topic: how-to
helpviewer_keywords:
- editors, fonts
- text, color
- text, customizing in editors
- text, fonts
- editors, text color
ms.assetid: 3f7629d1-1cdf-4046-9a31-0632517f234d
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# How to: Change fonts and colors for the editor in Visual Studio

You can change the default font face, adjust the font size, and change the foreground and background colors for various text **Display items** in the code editor. When you change font settings, keep the following information in mind:

- The settings for **Font** and **Size** are global for all text elements in all Visual Studio editors.

- The names of fixed width fonts are listed in bold.

- **Item foreground**, **Item background**, and **Bold** options can be set for each type of text element. For example, if you change colors and select **Bold** for **Comment** and **Bookmarks**, other types of text elements will be unaffected.

> [!IMPORTANT]
> To learn how to customize the fonts and colors for the IDE and not just for the code editor, see the **[How to: Change fonts and colors in Visual Studio](../../ide/how-to-change-fonts-and-colors-in-visual-studio.md)** page.

## Change the default font face, size, and colors

::: moniker range=">=vs-2022"

1. Select **Options** from the **Tools** menu. Under **Environment**, select **Fonts and Colors**.

1. In **Show settings for**, select **Text Editor**.

   ![Screenshot of the Options dialog box to change fonts and colors in the editor](../../ide/media/vs-2022/fonts-colors-text-editor.png "Screenshot of the Options dialog box to change the fonts and colors in the editor")

1. Modify the **Font** and **Size** options to change the font face and size for all text elements in all editors.

1. Select the appropriate item in **Display items**, and then modify the **Item foreground** and **Item background** options.

    > [!TIP]
    > Click **Use Defaults** to reset to the default settings.

1. Select **OK**.

::: moniker-end

::: moniker range="<=vs-2019"

1. Select **Options** from the **Tools** menu. Under **Environment**, select **Fonts and Colors**.

1. In **Show settings for**, select **Text Editor**.

   ![Screenshot of the Options dialog box to change fonts and colors in the editor](../../ide/media/fonts-colors-text-editor.png "Screenshot of the Options dialog box to change the fonts and colors in the editor.")

1. Modify the **Font** and **Size** options to change the font face and size for all text elements in all editors.

1. Select the appropriate item in **Display items**, and then modify the **Item foreground** and **Item background** options.

    > [!TIP]
    > Click **Use Defaults** to reset to the default settings.

1. Click **OK**.

::: moniker-end

## Next steps

To learn more about the font and color changes you can make to the IDE by using the **Options** dialog box, see the [Fonts and Colors, Environment, Options Dialog Box](../../ide/reference/fonts-and-colors-environment-options-dialog-box.md) page.

## See also

- [Features of the code editor](../../ide/writing-code-in-the-code-and-text-editor.md)
- [How to: Change fonts and colors in Visual Studio](../../ide/how-to-change-fonts-and-colors-in-visual-studio.md)
