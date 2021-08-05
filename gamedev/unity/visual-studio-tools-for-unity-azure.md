---
title: "Programming with Visual Studio Tools for Unity and Azure | Microsoft Docs"
description: Program with Visual Studio Tools for Unity and Azure. Azure provides a scalable solution for storing telemetry and other game data in the cloud.
ms.custom: ""
ms.date: "12/18/2017"
ms.reviewer: "crdun"
ms.technology: vs-unity-tools
ms.prod: visual-studio-dev16
ms.topic: "conceptual"
ms.assetid: 7921D4C7-5526-42F5-8E03-82D3E33A893F
author: therealjohn
ms.author: johmil
manager: "crdun"
ms.workload:
  - "azure"
  - "unity"
---

# Program with Unity and Azure

Azure provides a scalable solution to storing telemetry and other game data in the cloud. With the release of Unity 2017, Unity's experimental support for .NET 4.6 makes Azure integration simpler than ever by allowing use of Azure .NET SDKs.

## Experimental Azure SDKs

> [!NOTE]
> These SDKs are unsupported, but provided to help customers try out Unity's experimental .NET 4.6 support.

Visit [The Sandbox](/sandbox/) to try the following experimental Azure SDKs with Unity:

* [Azure Storage SDK for Unity](/sandbox/gamedev/unity/azure-storage-unity?wt.mc_id=azgamedev-sandbox-brpeek)
* [Azure Event Hubs SDK for Unity](/sandbox/gamedev/unity/azure-event-hubs-unity?WT.mc_id=azgamedev-sandbox-brpeek)
* [Azure Mobile Apps SDK for Unity](/sandbox/gamedev/unity/azure-mobile-apps-unity?WT.mc_id=azgamedev-sandbox-brpeek)

## Azure SDK sample

There is also a [simple sample game](/sandbox/gamedev/unity/samples/azure-mobile-apps-unity-racer)
using the Azure Easy Tables SDK and Unity. The game uses Azure Easy Tables data storage to track the high score leaderboard and store in-game telemetry, and is available for [download from GitHub](https://github.com/BrianPeek/AzureSamples-Unity).

![Sample game screenshot](media/vs/vstu-azure-test-sample-game-image2.png)
