---
title: Stage lines of code in Visual Studio
titleSuffix: ""
description: Stage multiple lines of code at the same time or split changes across different commits by using Git from directly within Visual Studio.
ms.date: 9/10/2025
ms.topic: concept-article
author: ghogen
ms.author: ghogen
ms.manager: mijacobs
ms.subservice: general-ide
monikerRange: >=vs-2022

#customer intent: As a developer, I want to use Git features in Visual Studio so I can stage multiple lines of code at the same time or split changes across different commits. 
---

# Stage lines of code in Visual Studio

:::moniker range="visualstudio"
Line-staging support, also known as [interactive staging](https://git-scm.com/book/en/v2/Git-Tools-Interactive-Staging) lets you stage chunks of changes in your files right from the code editor. Line staging can also be helpful when you want to split changes across different commits.
:::moniker-end

:::moniker range="vs-2022"
Line-staging support, also known as [interactive staging](https://git-scm.com/book/en/v2/Git-Tools-Interactive-Staging), is available in Visual Studio 2022 [version 17.3](/visualstudio/releases/2022/release-notes-v17.3) and later. Line-staging lets you stage chunks of changes in your files right from the code editor. Line staging can also be helpful when you want to split changes across different commits.
:::moniker-end

:::image type="content" source="media/vs-2022/git-line-staging.png" border="false" alt-text="Screenshot of an example of Git line-staging support in Visual Studio 2022." lightbox="media/vs-2022/git-line-staging.png":::

:::moniker range="vs-2022"
You can use the hover option to also *unstage* changes, line by line.
:::moniker-end

:::moniker range="vs-2022"
Starting with Visual Studio 2022 [version 17.6](/visualstudio/releases/2022/release-notes-v17.6), you can use the hover option to also *unstage* changes, line by line.
:::moniker-end

:::image type="content" source="media/vs-2022/git-line-unstaging.png" border="false" alt-text="Screenshot of an example of how to unstage changes for Git in Visual Studio 2022.":::

## Observe staged changes with color margins

The first thing you might notice about line-staging support is how the editor visualizes Git changes in the scroll bar and also in the margin.

:::image type="content" source="media/vs-2022/git-color-margins.png" border="false" alt-text="Screenshot of the color margins in the Visual Studio 2022 editor." lightbox="media/vs-2022/git-color-margins.png":::

The colors and annotations make it easy to differentiate between saved and unsaved changes that you added, deleted, or modified.

:::image type="content" source="media/vs-2022/git-color-margins-differentiated.png" border="false" alt-text="Screenshot of differentiated and annotated color margin examples in Visual Studio 2022." lightbox="media/vs-2022/git-color-margins-differentiated.png":::

### Configure color margin settings

You can change the colors that Visual Studio displays to help you manage changes. In the **Tools** > **Options** dialog, go to the **Environment** > **Fonts and Colors** section, and configure the following **Display items** options:

- **Track additions in documents under source control**
- **Track deletions in documents under source control**
- **Track modifications in documents under source control**

:::image type="content" source="media/vs-2022/tools-options-fonts-colors-track-source-control.png" border="false" alt-text="Screenshot of the Options dialog where you can change the colors Visual Studio uses for source control.":::

## View staged changes with Peek Difference 

Color margins are interactive. When you select a color margin, Visual Studio opens the **Peek Difference** user interface (UI) where you can view your changes in the editor without switching context. The Peek Difference UI summarizes the number of added and removed lines and makes it easy to switch between changes by using the Up and Down arrows.

:::image type="content" source="media/vs-2022/git-peek-difference.png" border="false" alt-text="Screenshot of the Peek Difference user interface in Visual Studio as it relates to source control." lightbox="media/vs-2022/git-peek-difference.png":::

You can also access Peek Difference when you right-click a line of code that has changes. You can select **Peek Difference** from the context menu or use the **Alt**+**F8** keyboard shortcut.

:::image type="content" source="media/vs-2022/git-peek-difference-context-menu-inline.png" border="false" alt-text="Screenshot of the right-click context menu in Visual Studio where you can select Peek Difference." lightbox="media/vs-2022/git-peek-difference-context-menu-expanded.png":::

> [!NOTE]
> If you prefer an inline difference view, you can use the **Settings** control in the top-right corner of the **Diff** editor to switch to **Inline mode**.
>
> :::image type="content" source="media/vs-2022/git-diff-inline-mode.png" border="false" alt-text="Screenshot of the Diff options available from the gear icon, where you can select the 'Inline mode' option." lightbox="media/vs-2022/git-diff-inline-mode.png":::

### Configure Peek Difference settings

You can modify how Visual Studio interacts with code changes in the Peek Difference UI. The **Click to peek in margin** option is available on the **Tools** > **Options** > **Text Editor** > **Advanced** page.

:::image type="content" source="media/vs-2022/text-editor-option-peek-in-margin.png" border="false" alt-text="Screenshot of the 'Click to peek in margin' Text Editor setting.":::

You can change the default **Single click** setting to **Double click**, or you can select **None** to turn off the Peek Difference UI.

## Stage chunks of code

You can stage any chunk of code by using the Peek Difference UI. Hover over the change to stage and select **Stage Change**. If you want to stage *all* the changes you made to a document, you can use the global **Stage** action.

:::image type="content" source="media/vs-2022/git-stage-change.png" border="false" alt-text="Screenshot of the Stage Change option in Visual Studio 2022." lightbox="media/vs-2022/git-stage-change.png":::

> [!NOTE]
> If you prefer a full-screen difference view, you can switch to the **Diff** editor with the **Promote to Document** :::image type="icon" source="media/vs-2022/promote-document-button.png" border="false"::: icon at the top-right of the [**Peek Difference** UI](#view-staged-changes-with-peek-difference), or use the **Ctrl**+**Alt**+**Home** keyboard shortcut. All features provided by the Peek Difference UI are also available in the **Diff** editor. The following image shows the **Diff** editor view:
> 
> :::image type="content" source="media/vs-2022/git-stage-change-difference.png" border="false" alt-text="Screenshot of the Stage Change difference view in Visual Studio 2022." lightbox="media/vs-2022/git-stage-change-difference.png":::

You can enable or disable the staging controls in the difference view by clicking the **Show staging controls** button.

## Commit staged changes

After you prepare your commit by reviewing and staging the desired changes, you can create your commit by using the **Git Changes** window. Enter a commit message and select **Commit Staged** to complete the process:

:::image type="content" source="media/vs-2022/git-commit-staged-changes-inline.png" border="false" alt-text="Screenshot of the Git Changes dialog in Visual Studio 2022." lightbox="media/vs-2022/git-commit-staged-changes-expanded.png":::

## Related content

- [Push to remote](git-push-remote.md)
- Learn [about Git in Visual Studio](git-with-visual-studio.md)
