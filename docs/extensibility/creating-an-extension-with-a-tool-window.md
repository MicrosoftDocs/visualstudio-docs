---
title: Creating an Extension with a Tool Window | Microsoft Docs
description: Learn how to use the VSIX project template and the Custom Tool Window item template to create an extension with a tool window.
ms.custom: SEO-VS-2020
ms.date: 3/16/2019
ms.topic: how-to
ms.assetid: 585b0a3a-f85b-4f92-81bb-9ca499bb8a89
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Create an extension with a tool window

In this procedure, you learn how to use the VSIX project template and the **Custom Tool Window** item template to create an extension with a tool window.

## Prerequisites

 Starting in Visual Studio 2015, you do not install the Visual Studio SDK from the download center. It is included as an optional feature in Visual Studio setup. You can also install the VS SDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

### Create a tool window

1. Create a VSIX project named **FirstWindow**. You can find the VSIX project template in the **New Project** dialog by searching for "vsix".

2. When the project opens, add a tool window item template named **MyWindow**. In the **Solution Explorer**, right-click the project node and select **Add** > **New Item**. In the **Add New Item** dialog, go to **Visual C#** > **Extensibility** and select **Custom Tool Window**. In the **Name** field at the bottom of the window, change the tool window file name to *MyWindow.cs*.

3. Build the project and start debugging.

   The experimental instance of Visual Studio appears. For more information about the experimental instance, see [The experimental instance](../extensibility/the-experimental-instance.md).

4. In the experimental instance, go to **View** > **Other Windows**.

   You should see a menu item for **MyWindow**. Click it.

   You should see a tool window with the title **MyWindow** and a button saying **Click Me!.**
