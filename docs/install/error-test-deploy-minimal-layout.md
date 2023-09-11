---
title: Error when testing or deploying minimal layout
titleSuffix: ''
description: Learn how to deploy minimal layout.
ms.date: 09/08/2023
ms.custom: vs-acquisition
ms.topic: 
f1_keywords:
- help menu
- deploying minimal layout
author: 
ms.author: 
ms.reviewer: khgupta, raviuppa, aartigoyle, v-sidong
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Error when testing or deploying minimal layout
 
_Applies to:_ &nbsp; Visual Studio 2022

## Symptoms 

After successfully creating a minimal layout, upon attempting to test it on a system, an error message like the following one is displayed: 

Snippet from the log:

```output
[3004:0006][2021-05-26T04:35:52] Unable to select suitable download engine. 
[3004:0006][2021-05-26T04:35:52] Unable to get download engine: Can not download. No suitable download engine found. 
[3004:0006][2021-05-26T04:35:52] Error 0x80131500: Unable to download the channel manifest from https://aka.ms/vs/17/release/channel. at Microsoft.VisualStudio.Setup.ChannelManager.<AddAsync>d__43.MoveNext() 
[3004:0006][2021-05-26T04:35:52] Error 0x80131500: Failed to initialize the app in AppInitializerService.InitializeChannelsAsync: Microsoft.VisualStudio.Setup.ChannelManifestDownloadException 
```

## Cause

The issue can occur if the upgrade was performed from a new profile, or if the content under the '%localappdata%\Microsoft\VisualStudio' folder was missing or corrupt. This folder hosts the channel manifest file, which contains details about the product and its upgrades. 

Ideally, this behavior should not occur when installing and updating Visual Studio using the same user account. Visual Studio creates the *_Channels* folder during the initial installation under 'C:\ProgramData\Microsoft\VisualStudio\Packages' and *%localappdata%\Microsoft\VisualStudio\Packages*. During the update process, Visual Studio compares the catalog and channel manifest files from these locations to ensure a smooth update. 

## Solution 

To resolve this issue, follow these steps: 

1. Copy the *_channels* folder located under *C:\ProgramData\Microsoft\VisualStudio\Packages*. 
1. Create a new folder named *Packages* under the *%localappdata%\Microsoft\VisualStudio* directory. 
1. Paste the *_channels* folder into the newly created *Packages* folder. 
1. Try running the update process again.