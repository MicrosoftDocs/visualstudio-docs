---
title: "Setup Visual Studio for Mac Tools for Unity"
description: "Setting up and installing Unity tools for use in Visual Studio for Mac"
author: dantogno
ms.author: v-davian
ms.date: 07/17/2017
ms.assetid: 83FDD7A3-5D16-4B4B-9080-078E3FB5C623
---
# Setup Visual Studio for Mac Tools for Unity

This section explains how to get started using Visual Studio for Mac Tools for Unity.

## Install Visual Studio for Mac

Download and install Visual Studio for Mac. All editions of Visual Studio for Mac support Visual Studio for Mac Tools for Unity, including the free Community edition:

* Download Visual Studio for Mac from [visualstudio.com](https://www.visualstudio.com/).
* Visual Studio for Mac Tools for Unity are installed automatically during the installation process.
* Follow the steps in the [installation guide](installation.md) for additional installation help.

## Confirm that the Visual Studio for Mac Tools for Unity extension is enabled

While the Visual Studio for Mac Tools for Unity extension should be enabled by default, you can confirm this and check the installed version number:

1.  From the Visual Studio menu, select **Extensions...**.

  ![Select Extensions](media/setup-vsmac-tools-unity-image1.png)

2.  Expand the Game Development section and confirm the Visual Studio for Mac Tools for Unity entry.

  ![View Unity Entry](media/setup-vsmac-tools-unity-image2.png)

## Install Unity

Visual Studio for Mac Tools for Unity requires Unity version 5.6.1 or above. All Unity plans work with Visual Studio Tools for Unity, including the free Personal plan. Download Unity from [store.unity.com](https://store.unity.com/).

> [!NOTE]
> To verify that Visual Studio Tools for Unity are enabled in your version of Unity, select **About Unity** from the Unity menu and look for the text "Microsoft Visual Studio Tools for Unity enabled" in the bottom-left of the dialog.
>
>   ![About Unity](media/setup-vsmac-tools-unity-image3.png)

## Configure Unity for use with Visual Studio for Mac

Visual Studio must be set as the external script editor in Unity:

1.	Select **Preferences...** from the Unity menu.

  ![Select Preferences](media/setup-vsmac-tools-unity-image4.png)

2.	In the Preferences dialog, select the **External Tools** tab.

3.	From the External Script Editor dropdown list, choose **Visual Studio** if it is listed, otherwise select **Browse...**.

  ![Select Visual Studio](media/setup-vsmac-tools-unity-image5.png)

4.	If **Browse...** was selected, navigate to the Applications directory and select Visual Studio and then click **Open**.

  ![Select Open](media/setup-vsmac-tools-unity-image6.png)

5.	Once Visual Studio is selected in the **External Script Editor** list, close the Preferences dialog to complete the configuration process.
