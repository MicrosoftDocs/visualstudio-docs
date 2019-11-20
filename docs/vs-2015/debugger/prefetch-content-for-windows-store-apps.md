---
title: "Prefetch content for Windows Store apps | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: b4481fef-3ebf-4f7d-9748-d43821a0ebac
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Prefetch content for Windows Store apps
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Applies to Windows only](../Image/windows_only_content.png "windows_only_content")  
  
 To make your Windows Store app more responsive, you can request Windows to preload some web content, such as web pages or images, into the app's [WinINet](https://msdn.microsoft.com/0a06f2af-957a-4dff-a8cc-187370181b5c)[WinINet](https://msdn.microsoft.com/library/aa383630.aspx)cache. This functionality is called prefetching. It’s especially effective for content that's used at startup but you can prefetch other frequently used content, too. The methods of the [Windows.Networking.BackgroundTransfer.ContentPrefetcher](https://msdn.microsoft.com/library/windows/apps/windows.networking.backgroundtransfer.contentprefetcher.aspx) class let you specify the URIs of the content that you want to preload.  
  
 Windows uses heuristics to determine when and if prefetching should occur and which resources will be downloaded. The heuristics take into account system network and power conditions, user app usage history, and the results of prior prefetch attempts. In Visual Studio, you can use the **Trigger Windows Store App Prefetch** command to force Windows to ignore the ContentPrefetcher heuristics and preload all of the specified web content. This can be useful if you want test the app's behavior or performance with the content to prefetch in a known state (either loaded or not loaded).  
  
## To force preloading of ContentPrefetcher specified resources  
 This procedure assumes that you have already set up the ContentPrefetcher functionality and specified the content URIs to preload in your app project. To force a preloading of content when the specified resources are new or modified, you have to start and stop the app before you choose the **Trigger Windows Store App Prefetch** command. You run the app first to register the URIs. **Trigger Windows Store App Prefetch** command then forces the ContentPrefetcher to download the content and add it the cache. In subsequent runs of the app, you can assume that the content is preloaded.  
  
1. Start the app to register the prefetch content URIs with the app. On the **Debug** menu, choose **Start Debugging** (Keyboard shortcut: F5).  
  
2. On the **Debug** menu, choose **Stop Debugging** (Keyboard shortcut: Shift + F5).  
  
3. On the **Debug** menu, choose **Other Debug Targets** and then choose **Trigger Windows Store App Prefetch**.  
  
   You can now debug, test, or analyze your app with the prefetched web resources.  
  
> [!NOTE]
> Repeat these steps whenever you add or modify the specified web content.  
  
## See Also  
 [Blog post: Triggering Prefetch for Windows Store Apps in Visual Studio 2013 Update 2](https://devblogs.microsoft.com/devops/triggering-prefetch-for-windows-store-apps-in-visual-studio-2013-update-2/)
