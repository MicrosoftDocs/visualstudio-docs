---
title: Stage lines of code in Visual Studio
titleSuffix: ""
description: Stage multiple lines of code at one time or split changes across different commits by using Git from directly within Visual Studio.
ms.date: 05/16/2023
ms.topic: how-to
author: TerryGLee
ms.author: tglee
ms.manager: jmartens
ms.prod: visual-studio-windows
ms.technology: vs-ide-general
ms.custom: version-control
monikerRange: vs-2022
---
# Stage lines of code in Visual Studio

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Line-staging support, also known as [interactive staging](https://git-scm.com/book/en/v2/Git-Tools-Interactive-Staging), is now available in Visual Studio 2022 [version 17.3](/visualstudio/releases/2022/release-notes/). Line-staging lets you stage chunks of changes in your files right from the code editor. Line staging can also be helpful when you want to split changes across different commits.

:::image type="content" source="media/vs-2022/git-line-staging.png" alt-text="Screenshot of an example of line-staging support in Visual Studio 2022." lightbox="media/vs-2022/git-line-staging.png":::

## Color margin support

The first thing you might notice about line-staging support is how the editor visualizes Git changes on both the scroll bar and in the margin.

:::image type="content" source="media/vs-2022/git-color-margins.png " alt-text="Screenshot of the color margins in the Visual Studio 2022 editor." lightbox="media/vs-2022/git-color-margins.png":::

The colors and annotations make it easy to differentiate between saved and unsaved changes that you've added, deleted, or modified.

:::image type="content" source="media/vs-2022/git-color-margins-differentiated.png " alt-text="Screenshot of differentiated and annotated color margin examples in Visual Studio 2022." lightbox="media/vs-2022/git-color-margins-differentiated.png":::

> [!TIP]
> You can change the colors that Visual Studio displays to help you manage changes. Go to **Tools** > **Options** > **Environment** > **Fonts and Colors** and then choose from the following options:
> - Track additions in documents under source control
> - Track deletions in documents under source control
> - Track modifications in documents under source control
>
> :::image type="content" source="media/vs-2022/tools-options-fonts-colors-track-source-control.png" alt-text="Screenshot of the Options dialog box where you can change the colors Visual Studio uses for source control.":::

## Peek Difference support

Color margins are interactive. When you select a color margin, Visual Studio opens the **Peek Difference** user interface (UI) where you can view your changes in the editor without switching context. The Peek Difference UI summarizes the number of added and removed lines and makes it easy to navigate between changes by using the Up and Down arrows.

:::image type="content" source="media/vs-2022/git-peek-difference.png" alt-text="Screenshot of the Peek Difference user interface in Visual Studio as it relates to source control." lightbox="media/vs-2022/git-peek-difference.png":::

You can also access Peek Difference when you right-click a line that includes changes. A context menu appears where you can select **Peek Difference** from it. Or, you can use the **Alt**+**F8** keyboard shortcut.

:::image type="content" source="media/vs-2022/git-peek-difference-context-menu-inline.png" alt-text="Screenshot of the right-click context menu in Visual Studio where you can select Peek Difference." lightbox="media/vs-2022/git-peek-difference-context-menu-expanded.png":::

> [!NOTE]
> If you prefer an inline difference view, you can use the **Settings** control in the top-right corner of the **Diff** editor to switch to **Inline mode**.
>
> :::image type="content" source="media/vs-2022/git-diff-inline-mode.png" alt-text="Screenshot of the Diff options available from the gear icon, where you can select the 'Inline mode' option." lightbox="media/vs-2022/git-diff-inline-mode.png":::

> [!TIP]
> You can modify how Visual Studio interacts with code changes in the Peek Difference UI by using the **Click to peek in margin** option from  **Tools** > **Options** > **Text Editor** > **Advanced**.
> :::image type="content" source="media/vs-2022/text-editor-option-peek-in-margin.png" alt-text="Screenshot of the 'Click to peek in margin' setting.":::
> For example, you can change the default **Single click** setting to **Double click**, or you can select **None** to turn off the Peek Difference UI.

## Stage chunks of code

You can stage any chunk of code by using the Peek Difference user interface (UI). To do so, hover over the change you want to stage and select **Stage Change**. Alternatively, use the global **Stage** button if you want to stage *all* the changes you made to a document.

:::image type="content" source="media/vs-2022/git-stage-change.png" alt-text="Screenshot of the Stage Change option in Visual Studio 2022." lightbox="media/vs-2022/git-stage-change.png":::

If you prefer a full-screen difference view, you can switch to the **Diff** editor. Here's how: select the **Promote to Document** button :::image type="icon" source="media/vs-2022/promote-document-button.png" border="false"::: on the top-right corner of the [**Peek Difference** UI](#peek-difference-support). Or, you can use the **Ctrl**+**Alt**+**Home** keyboard shortcut. All the features that the Peek Difference UI provides are also available in the **Diff** editor.

:::image type="content" source="media/vs-2022/git-stage-change-difference.png" alt-text="Screenshot of the Stage Change difference view in Visual Studio 2022." lightbox="media/vs-2022/git-stage-change-difference.png":::

## Commit staged changes

After you've prepared your commit by reviewing and staging the changes you want to include, you can create your commit by using the **Git Changes** window. Next, enter a commit message and then select **Commit Staged**.

:::image type="content" source="media/vs-2022/git-commit-staged-changes-inline.png" alt-text="Screenshot of the Git Changes dialog in Visual Studio 2022." lightbox="media/vs-2022/git-commit-staged-changes-expanded.png":::

## Next steps

To continue your journey, visit the [Push to remote](git-push-remote.md) page.

## See also

- [Git experience in Visual Studio](git-with-visual-studio.md)
- [Visual Studio & GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)
