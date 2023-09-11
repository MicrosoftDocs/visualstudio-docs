---
title: Unable to update Visual Studio using the help menu
titleSuffix: ''
description: Learn how to update Visual Studio using the help menu.
ms.date: 09/08/2023
ms.custom: vs-acquisition
ms.topic: 
f1_keywords:
- help menu
- update Visual Studio
author: 
ms.author: 
ms.reviewer: khgupta, raviuppa, aartigoyle, v-sidong
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Unable to update using the Help menu 

_Applies to:_ &nbsp; Visual Studio Professional 2022 

## Symptoms 

Unable to update Visual Studio to the latest version using the **Help** menu in the IDE: **Help** > **Check for Updates** > **Update option**. 

You may also see following error in the logs: 

```output
Error 0x80070057: Failed to read instance f9a94122 
at System.ThrowHelper.ThrowArgumentException(ExceptionResource resource) 
at System.Collections.Generic.Dictionary`2.Insert(TKey key, TValue value, Boolean add) 
at System.Linq.Enumerable.ToDictionary[TSource,TKey,TElement](IEnumerable`1 source, Func`2 keySelector, Func`2 elementSelector, IEqualityComparer`1 comparer) 
at Microsoft.VisualStudio.Setup.Installer.Extensions.GetReleaseNotesUris(IChannel channel) 
at Microsoft.VisualStudio.Setup.Installer.Models.Readers.ChannelReader.ReadFromChannel(ChannelNode`1 channelProduct) 
at Microsoft.VisualStudio.Setup.Installer.Models.Readers.ProductSummaryReader.ReadFromInstance(IInstance instance) 
at Microsoft.VisualStudio.Setup.Installer.Services.ProductsProviderService.TryGetInstalledProductSummary(IInstance instance) 

[4b94:000d][2022-11-23T12:02:45] Warning: Failed to initialize the update dialog: No instance registered for path "C:\Program Files\Microsoft Visual Studio\2022\Professional" 
[4b94:0001][2022-11-23T12:02:45] Navigate to Page: Final, Action: None, Message: The operation did not complete successfully 
```

## Cause 

This issue occurs when using an outdated version of the Visual Studio installer (older than 3.1.2188) that is not compatible with the Visual Studio 2022. The error code 0x80070057 indicates that the installer is unable to read certain parameters. The older version of the Visual Studio installer is unable to recognize and process the new parameters introduced in the latest updates. 

## Solution 

1. Download [vs_Professional.exe](https://aka.ms/vs/17/release/vs_Professional.exe) and save it to the *C:\Temp folder.menu*.

1. Delete the *C:\Program Files (x86)\Microsoft Visual Studio\Installer* folder or update the Visual Studio installer by right-clicking on *C:\Temp\vs_Professional.exe* and selecting **Run as Administrator**. 

1. Select the **Update** button to initiate the update process.