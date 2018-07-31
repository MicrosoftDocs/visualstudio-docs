---
title: "How to: Open multiple solutions"
description: This document provides ways to open more than one solution in or more than one of Visual Studio for Mac.
author: asb3993
ms.author: amburns
ms.date: 07/19/2018
ms.assetid: 592BA4E3-8DEF-4FCD-8BA0-519A4CEEE03E
---

# Opening multiple solutions or instances of Visual Studio for Mac

By default, all applications on a Mac, including Visual Studio for Mac, are _single-instance_ apps. This means that if the application you want to use is already open (illustrated by a "dot" under the icon in the dock), clicking on the icon again will open the running instance, rather than a new one.  If you require additional instances of the application, you can prompt the system to open it for you, as described in the [next section](#open-a-second-instance-of-visual-studio-for-mac).

In addition, when you open a solution, the default behavior is to open the solution in a new workspace and close the current workspace (if necessary). You can override this default behavior by keeping the current workspace open, as described in the [Open a second solution](#open-a-second-solution-inside-a-single-instance) section.

## Open a second instance of Visual Studio for Mac

To open a second instance of the IDE, open the **Terminal** application and enter the following line:

```bash
open -n "/Applications/Visual Studio.app"
```

## Open a second solution inside a single instance

To open a second solution alongside your first solution, use the following steps:

1. With your first solution already open, select **File > Open**.
2. Browse the file system to find the existing solution.
3. Select the **.sln** file and press the **Options** button:
    
    ![location of options button](media/open-multiple-solutions-image3.png)
4. Unselect the **Close current workspace** box:

    ![screenshot of current workspace](media/open-multiple-solutions-image1.png)

1. Press the Open button to open the second solution in the Solution Pad.

**Alternatively**, if you've recently opened the solution, you can use the following steps:

1. Go to the File > Recent Solutions menu item:

    ![screenshot of Recent Solutions menu](media/open-multiple-solutions-image2.png)

1. Hold down the **Ctrl** key and select the solution. This combination opens the second Solution in the Solution Pad.