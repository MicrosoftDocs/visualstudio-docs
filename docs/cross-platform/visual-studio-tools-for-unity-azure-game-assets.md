---
title: "Visual Studio Tools for Unity Azure Walkthrough Game Assets | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2017"
ms.reviewer: "crdun"
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: C06FAB2E-F592-4EFF-B96A-58858C92DCEB
author: "dantogno"
ms.author: "v-davian"
manager: "crdun"
ms.workload: 
  - "azure"
  - "unity"
---

# Import sample game assets

Now that the core functionality has been tested and demonstrated to work, it's time to import the sample game assets.

## Import package

1. Download the [sample game assets package](https://github.com/dantogno/UnityAzureSample/blob/master/Azure%20Easy%20tables%20sample%20game%20assets.unitypackage).

2. Ensure your Unity project is open, then navigate to the download location and double click the file. This will bring up the import dialog in Unity.

3. Click **All** and then click **Import**. Wait for the resulting progress bars to complete.

  ![Import package](media/vstu_azure-import-sample-assets-image1.png)

## Add scenes to Build Settings

Once the files have completed importing, the required scene files must be added in the Unity project's Build Settings.

1. In the Unity Project window, navigate to the **Azure Easy Tables sample game assets/Scenes** directory.

2. From the Unity menu, select **File > Build Settings...**. This will display the Build Settings dialog.

3. Drag the **HeatmapScene**, **LeaderboardScene**, **MenuScene**, and **RaceScene** files from the Project window into the **Scenes In Build** section of the Build Settings dialog.

  ![Import package](media/vstu_azure-import-sample-assets-image2.png)

4. From the Unity menu, select **File > Save Project** to ensure the build settings are saved.

## Next step

* [Test the sample game](visual-studio-tools-for-unity-azure-game.md)