---
title: 'Display URLs as Links in the Editor'
description: Display URLs in your code as active links in the Visual Studio Code Editor and enable link underlining, tooltips, and keyboard quick access functions.
ms.date: 11/19/2025
ms.topic: how-to
helpviewer_keywords:
- URLs, opening
- Code Editor, displaying URLs
- editors, displaying URLs
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Display URLs as Links in the Editor

You can choose to have the Code Editor treat Uniform Resource Locators (URLs) in your code as active links. When you use this feature, URLs:

- Appear underlined.

- Display a **ToolTip** when you hover over them.

- Attempt to open the website indicated when you **Ctrl**+**click** on the link. By default, the website is displayed in the internal web browser.

## Display URLs as links

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane, and expand the **All Settings** > **Languages** section.

1. Expand the language section you're using (such as **C#** or **Visual Basic**) and then expand the **General** section.

1. Select the **Enable single-click URL navigation** checkbox.

You can also configure URLs as links for all supported programming languages. Expand the **All Settings** > **Languages** > **Defaults** > **General** section and select or clear the **Enable single-click URL navigation** option.

:::moniker-end
:::moniker range="<=vs-2022"

1. On the Visual Studio menu bar, select **Tools** > **Options**.

1. In the **Options** dialog, expand the **Text Editor** section.

1. Expand the language section you're using (such as **C#** or **Visual Basic**) and then expand the **General** section.

1. Select the **Enable single-click URL navigation** checkbox, and then select **OK**.

You can also configure URLs as links for all supported programming languages. Expand the **Text Editor** > **All Languages** > **General** section and select the **Enable single-click URL navigation** option.

:::moniker-end

## Related content

- [Features of the code editor](../../ide/writing-code-in-the-code-and-text-editor.md)
