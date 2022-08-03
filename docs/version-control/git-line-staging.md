---
title: Stage lines of code in Visual Studio
titleSuffix: ""
description: Stage multiple lines of code at one time or split changes across different commits by using Git from directly within Visual Studio.
ms.date: 08/09/2022
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

Line-staging support, also known as interactive staging, is now available in Visual Studio 2022 [version 17.3](/visualstudio/releases/2022/release-notes/) and later. Now, you can stage chunks of changes in your files right from the editor. Line staging can also be helpful when you want to split changes across different commits.

:::image type="content" source="media/vs-2022/git-line-staging.png" alt-text="Screenshot of an example of line-staging support in Visual Studio 2022." lightbox="media/vs-2022/git-line-staging.png":::

## Color margin support

The first thing you might notice about line-staging support is how the Editor visualizes Git changes on both the scroll bar and in the margin.

:::image type="content" source="media/vs-2022/git-color-margins.png " alt-text="Screenshot of the color margins in Visual Studio 2022." lightbox="media/vs-2022/git-color-margins.png":::

The colors and annotations make it easy to differentiate between saved and unsaved changes that you've added, deleted, or modified.

:::image type="content" source="media/vs-2022/git-color-margins-differentiated.png " alt-text="Screenshot of differentiated and annotated color margin examples in Visual Studio 2022." lightbox="media/vs-2022/git-color-margins-differentiated.png":::

> [!TIP]
> You can change the colors that Visual Studio displays to help you manage changes. Go to **Tools** > **Options** > **Fonts and Colors** and then choose from the following options:
> - Track additions in documents under source control
> - Track deletions in documents under source control
> - Track modifications in documents under source control
>
> :::image type="content" source="media/vs-2022/tools-options-fonts-colors-track-source-control.png" alt-text="Screenshot of the Options dialog box where you can change the colors Visual Studio uses for source control.":::

## Peek Difference support



## Stage chunks of code

## Commit staged changes

## Next steps

To continue your journey, visit the [Push to remote](git-push-remote.md) page.

## See also

- [Git experience in Visual Studio](git-with-visual-studio.md)
- [Visual Studio & GitHub: Better together](https://visualstudio.microsoft.com/vs/github/)
