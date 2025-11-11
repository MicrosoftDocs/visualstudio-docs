---
title: Setup Assistant
description: When a project is loaded, Setup Assistant helps get what you need to build with ease.
ms.custom: vs-acquisition
ms.date: 11/7/2025
ms.subservice: installation
ms.topic: article
helpviewer_keywords:
- dependency acquisition
- setup assistant
author: jasonchlus
ms.author: meghaanand
manager: mijacobs
---

# Prepare to build with Setup Assistant

Visual Studio supports multiple toolsets and SDKs. When a project is loaded, Setup Assistant automatically detects dependencies your project targets and makes it easy to install any specific missing dependencies and/or retarget your project to the latest dependencies. If you don't want to retarget or install targeted dependencies, you can simply select **Ignore** and **Apply**.

## C++ developers

Setup Assistant identifies MSVC toolsets and Windows SDKs your project targets. You can retarget your project to the latest version or install any missing components with a single click directly in the Visual Studio Installer. 

:::image type="content" source="./media/visualstudio/setup-assistant-cpp.png" alt-text="Screenshot of the C++ Setup Assistant.":::

## .NET developers

If your project uses a pinned *global.json* file, Setup Assistant provides a link matching the pinned .NET SDK, for quick installation in your browser. 

<img width="1404" height="434" alt="image" src="https://github.com/user-attachments/assets/082f6b9b-547f-419b-ac5b-b39eaa99411b" />
