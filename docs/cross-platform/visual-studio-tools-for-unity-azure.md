---
title: "Visual Studio Tools for Unity Azure Walkthrough | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2017"
ms.reviewer: "crdun"
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7921D4C7-5526-42F5-8E03-82D3E33A893F
author: "dantogno"
ms.author: "v-davian"
manager: "crdun"
ms.workload: 
  - "azure"
  - "unity"
---

# Using Azure Easy Tables with Unity Walkthrough

![Sample game screenshot](media/vstu_azure-test-sample-game-image2.png)

## Introduction

Azure provides a scalable solution to storing telemetry and other game data in the cloud. With the release of Unity 2017, Unity's support for .NET 4.6 makes Azure integration simpler than ever by allowing use of the Azure Mobile Client SDK.

These steps will walk through the process of setting up a Unity project that leverages Azure for saving telemetry and leaderboard data in the cloud.

> [!NOTE]
> This project requires the "experimental" .NET 4.6 Mono scripting runtime in Unity 2017. [Unity has stated that soon this will be the default](https://forum.unity3d.com/threads/future-plans-for-the-mono-runtime-upgrade.464327/), however for now, it is still labeled as "experimental" and you may  experience issues.

> This walkthrough documents an example for connecting to an Azure Mobile App backend from a Unity PC build. At the time of this document's writing, there are known issues that block this project from functioning on the Mac and Android platforms. While these are known issues that will be fixed, the timeline is uncertain. For more information, visit the Unity [experimental scripting forum](https://forum.unity3d.com/forums/experimental-scripting-previews.107/).

## Download the completed project

The completed project is available on GitHub. However, the walkthrough will assume you are starting from an empty, new project and will provide links to download assets when necessary.

## Walkthrough Steps

1. [Configure Easy Tables in Azure](visual-studio-tools-for-unity-azure-configure.md)
2. [Create Easy Tables](visual-studio-tools-for-unity-azure-setup.md)
3. [Prepare the development environment](visual-studio-tools-for-unity-azure-prepare.md)
4. [Create data model classes](visual-studio-tools-for-unity-azure-data.md)
5. [Implement the Azure MobileServiceClient](visual-studio-tools-for-unity-azure-mobile-client.md)
6. [Update Unity Mono security certificate store](visual-studio-tools-for-unity-azure-security.md)
7. [Test the client connection](visual-studio-tools-for-unity-azure-connection.md)
7. [Import sample game assets](visual-studio-tools-for-unity-azure-game-assets.md)
8. [Test the sample game](visual-studio-tools-for-unity-azure-game.md)
9. [RaceScene explanation](visual-studio-tools-for-unity-azure-racescene.md)
10. [HeatmapScene explanation](visual-studio-tools-for-unity-azure-heatmapscene.md)
11. [LeaderboardScene explanation](visual-studio-tools-for-unity-azure-leaderboardscene.md)


## Next step
* [Configure Easy Tables in Azure](visual-studio-tools-for-unity-azure-configure.md)
