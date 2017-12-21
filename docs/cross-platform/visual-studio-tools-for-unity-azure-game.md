---
title: "Visual Studio Tools for Unity Azure Walkthrough Game| Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2017"
ms.reviewer: "crdun"
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: DA86FC7F-E456-4DFC-84BF-D780421508B9
author: "dantogno"
ms.author: "v-davian"
manager: "crdun"
ms.workload: 
  - "azure"
  - "unity"
---

# Test the sample game

The sample game is a simple racing game that records data about the player's behavior and stores it in Azure Easy Tables. The sample game also includes scenes that read the data from Azure and visualize it for the player.

This section will simply explain how to play the sample game and ensure it's functioning correctly. The next sections will go into more detail explaining how the sample game works.

## Starting the game

1. In the Unity Project window, navigate to the **Assets/Azure Easy Tables sample game assets/Scenes** folder.

2. Double click the **MenuScene** to open it.

3. In the Unity Game window, click the **aspect ratio dropdown** and choose **16:9**.

  ![Set aspect ratio](media/vstu_azure-test-sample-game-image1.png)

4. Click the **Play** button to run the game in the Unity editor.


## Complete a race

Before viewing the leaderboard or heatmap, it's best to create some sample data by completing the race at least once.

1. With the game running in the Unity editor, click the **Race!** button to start a new race.

2. Use **WASD** or the **arrow keys** to drive the car and complete a clockwise lap around the track. For the sake of example, be sure to crash into some walls along the way. Debug output in the Unity console should indicate when a collision has been recorded.

  >[!NOTE]
  > If you manage to flip the car and are unable to continue, click **Restart**. Data is only sent to Azure upon completing a lap.

  ![Start a race](media/vstu_azure-test-sample-game-image2.png)

3. After crossing the checkered finish line, the game should display a **Finished** message. At this point, crash data will be uploaded to Azure.

4. If you have completed one of the top 10 fastest lap times, you will be prompted to enter a name for a high score. Enter your name and click **Submit**.

  ![Start a race](media/vstu_azure-test-sample-game-image3.png)

## View the heatmap

1. Click the **View Crash Heatmap** button from the race scene or select **Crash Heatmap** from the main menu.

2. The heatmap scene loads data from the CrashInfo table in Azure and displays a transparent red sphere at locations where players have collided with the walls of the race track. If multiple crashes occur in an overlapping area, the spheres should appear brighter.

  ![Heatmap](media/vstu_azure-test-sample-game-image4.png)

## View the leaderboard

1. Click the **Leaderboard** button from the race scene or main menu.

2. The leaderboard scene loads high score data from the HighScoreInfo table in Azure and displays a player name and lap time for each high score entry.

  ![Leaderboard](media/vstu_azure-test-sample-game-image5.png)

## Next step

* [RaceScene explanation](visual-studio-tools-for-unity-azure-racescene.md)
