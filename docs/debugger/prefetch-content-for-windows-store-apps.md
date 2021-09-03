---
title: Debug using prefetched content in UWP apps | Microsoft Docs
description: To make your UWP app more responsive, use ContentPrefetcher to request Windows to prefetch web content. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - uwp
---
# Debug UWP apps using prefetched content in Visual Studio

 To make your UWP app more responsive, you can request Windows to preload some web content, such as web pages or images, into the app's [WinINet](/windows/desktop/WinInet/about-wininet) cache. This functionality is called prefetching. It's especially effective for content that's used at startup but you can prefetch other frequently used content, too. The methods of the [Windows.Networking.BackgroundTransfer.ContentPrefetcher](/uwp/api/Windows.Networking.BackgroundTransfer.ContentPrefetcher) class let you specify the URIs of the content that you want to preload. See the Windows SDK [Content prefetch sample](https://code.msdn.microsoft.com/windowsapps/ContentPrefetcher-Sample-432c8309) for examples of how to add ContentPrefetcher functionality to your app.

 Windows uses heuristics to determine when and if prefetching should occur and which resources will be downloaded. The heuristics take into account system network and power conditions, user app usage history, and the results of prior prefetch attempts. In Visual Studio, you can use the **Trigger Windows Store App Prefetch** command to force Windows to ignore the ContentPrefetcher heuristics and preload all of the specified web content. This can be useful if you want test the app's behavior or performance with the content to prefetch in a known state (either loaded or not loaded).

## To force preloading of ContentPrefetcher specified resources
 This procedure assumes that you have already set up the ContentPrefetcher functionality and specified the content URIs to preload in your app project. To force a preloading of content when the specified resources are new or modified, you have to start and stop the app before you choose the **Trigger Windows Store App Prefetch** command. You run the app first to register the URIs. **Trigger Windows Store App Prefetch** command then forces the ContentPrefetcher to download the content and add it the cache. In subsequent runs of the app, you can assume that the content is preloaded.

1. Start the app to register the prefetch content URIs with the app. On the **Debug** menu, choose **Start Debugging** (Keyboard shortcut: F5).

2. On the **Debug** menu, choose **Stop Debugging** (Keyboard shortcut: Shift + F5).

3. On the **Debug** menu, choose **Other Debug Targets** and then choose **Trigger Windows Store App Prefetch**.

   You can now debug, test, or analyze your app with the prefetched web resources.

> [!NOTE]
> Repeat these steps whenever you add or modify the specified web content.

## See also
- [Blog post: Triggering Prefetch for Windows Store Apps in Visual Studio 2013 Update 2](https://devblogs.microsoft.com/devops/triggering-prefetch-for-windows-store-apps-in-visual-studio-2013-update-2/)