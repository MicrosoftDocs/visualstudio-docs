---
title: include
description: include
author: ghogen
ms.subservice: azure-development
ms.author: ghogen
ms.topic: include
ms.date: 05/14/2026
---

1. In the Visual Studio start window, select **Create a new project**.

1. Select **ASP.NET Core Web App**, and then select **Next**.

1. Enter a name for your new application (or use the default name), specify the location on disk, and then select **Next**.

1. Select the .NET version you want to target. If you're not sure, [choose the LTS (long-term support) release](https://dotnet.microsoft.com/download/dotnet).

1. Choose whether you want SSL support by selecting or clearing the **Configure for HTTPS** checkbox.

1. Select the checkbox to enable Docker container support.

   ::: moniker range="visualstudio"

   :::image type="content" source="../../media/create-aspnet5-app/visualstudio/asp-net-enable-docker-support-visual-studio.png" alt-text="Screenshot that shows the container support checkbox in Visual Studio.":::

   ::: moniker-end

   ::: moniker range="vs-2022"

   :::image type="content" source="../../media/create-aspnet5-app/asp-net-enable-docker-support-visual-studio.png" alt-text="Screenshot that shows how to create a new asp dot net Core web app project in Visual Studio 2022.":::

   ::: moniker-end

1. Use the **Docker OS** dropdown list to select the type of container you want: **Windows** or **Linux**.

1. Select **Create** to complete the process.
