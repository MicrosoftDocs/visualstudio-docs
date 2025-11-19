---
title: Display line numbers for code
description: Turn line numbering for your code on and off in the Visual Studio code editor. Line numbers can be useful as a reference.
ms.date: 11/19/2025
ms.topic: how-to
helpviewer_keywords:
- line numbers, displaying
- Code Editor, line numbers
- editors, line numbers
- code, line number displaying
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to know how to toggle line numbers in my code so that I can use the numbers as a reference.
---

# Display line numbers in the editor

This article describes how to show or hide line numbers in your code. 

> [!NOTE]
> If you enable line numbering, the line numbers you see aren't added to your code. The numbers are displayed in the view for reference only.

:::moniker range="visualstudio"

1. Open the **Tools** > **Options** pane, and expand the **All Settings** > **Languages** section.

1. Expand the language section you're using (such as **C#** or **Visual Basic**) and then expand the **General** section.

1. Select the **Line numbers** checkbox to show line numbers, or clear the checkbox to hide line numbers.

   :::image type="content" source="./media/visualstudio/line-numbers-option.png" alt-text="Screenshot that shows how to enable line numbering for a specific language.":::

You can also configure line numbering for all supported programming languages. Expand the **All Settings** > **Languages** > **Defaults** > **General** section and select or clear the **Line numbers** option.

:::moniker-end
:::moniker range="<=vs-2022"

1. On the Visual Studio menu bar, select **Tools** > **Options**.

1. In the **Options** dialog, expand the **Text Editor** section.

1. Expand the language section you're using (such as **C#** or **Visual Basic**) and then expand the **General** section.

1. Select the **Line numbers** checkbox to show line numbers, or clear the checkbox to hide line numbers.

   :::image type="content" source="./media/line-numbers-option.png" alt-text="Screenshot of the Options dialog that you can use to show or hide line numbers in the Visual Studio editor.":::

1. Select **OK**.

You can also configure line numbering for all supported programming languages. Expand the **Text Editor** > **All Languages** > **General** section and select or clear the **Line numbers** option.

:::moniker-end

Another way to access the **Line numbers** option for all supported programming languages is to use the Visual Studio [Search](../visual-studio-search.md) feature.

1. Select **Ctrl**+**q** to open the Search box, and enter _line numbers_.

:::moniker range="visualstudio"

2. In the results list, double-click the **Line numbers** (languages.defaults.general.lineNumbers) entry.

   :::image type="content" source="media/visualstudio/line-numbers-search-box.png" alt-text="Screenshot that shows how to use the Search feature to configure the default line numbers setting.":::

:::moniker-end
:::moniker range="<=vs-2022"

2. In the results list, double-click the **Turn line numbers on or off** entry.

   :::image type="content" source="media/line-numbers-search-box.png" alt-text="Screenshot that shows how to use the Search feature to configure line numbers for all programming languages.":::

:::moniker-end

## Related content

- [Features of the code editor](../../ide/writing-code-in-the-code-and-text-editor.md)
