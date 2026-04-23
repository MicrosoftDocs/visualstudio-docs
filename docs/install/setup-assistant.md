---
title: Setup Assistant
description: When a project is loaded, Setup Assistant helps get what you need to build with ease.
ms.custom: vs-acquisition
ms.date: 3/10/2026
ms.subservice: installation
ms.topic: concept-article
helpviewer_keywords:
- dependency acquisition
- setup assistant
author: jasonchlus
ms.author: rosemalcolm
manager: mijacobs
---

# Prepare to build with Setup Assistant

Visual Studio supports multiple toolsets and SDKs. When a project is loaded, Setup Assistant automatically detects dependencies your project targets and makes it easy to install missing dependencies and/or retarget your project to the latest dependencies. If you’d rather not install or retarget right now, select **Ignore**, then choose **Apply**.

## C++ developers

Setup Assistant identifies MSVC toolsets and Windows SDKs your project targets. You can retarget your project to the latest version or install missing components with a single click directly in the Visual Studio Installer.

:::image type="content" source="./media/visualstudio/cpp-setup-assistant.png" alt-text="Screenshot of the C++ Setup Assistant." lightbox="./media/visualstudio/cpp-setup-assistant.png":::

## .NET developers

If your project uses a pinned *global.json* file, Setup Assistant provides a link that matches the pinned .NET SDK so you can quickly install it in your browser.

:::image type="content" source="./media/visualstudio/net-setup-assistant.png" alt-text="Screenshot of the C# Setup Assistant." lightbox="./media/visualstudio/net-setup-assistant.png":::

## Reopen the Setup Assistant dialog

You can reopen the Setup Assistant dialog anytime:

- In **Solution Explorer**, right-click the solution and select **Retarget solution**.

  :::image type="content" source="./media/visualstudio/retarget-solution.png" alt-text="Screenshot showing the Retarget solution command in the solution context menu.":::

- From the project toolbar dropdown, select **Retarget solution**.

  :::image type="content" source="./media/visualstudio/retarget-project.png" alt-text="Screenshot showing the Retarget project command in the project toolbar dropdown.":::
