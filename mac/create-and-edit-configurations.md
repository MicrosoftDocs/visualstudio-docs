---
title: "Creating and Editing Build Configurations"
description: "This article describes creating build configurations in Visual Studio for Mac"
author: heiligerdankgesang
ms.author: dominicn
ms.date: 09/18/2019
ms.assetid: CC1B72D6-12FF-4CCC-A9D4-00F2DC14589F
ms.custom: video
---

# Creating and editing build configurations

Build configurations give you precise control over a build allowing you to create configurations to cater to different testing and distribution situations. You can create build configurations for individual projects or on a solution-wide basis.

You can create new configurations and edit existing ones for both projects and solutions using the Project Options dialog.

>[!NOTE]
>This topic applies to Visual Studio for Mac. For Visual Studio on Windows, see [How to: Create and edit configurations](/visualstudio/ide/how-to-create-and-edit-configurations).

## Creating a project build configuration

To create a project build configuration, follow these steps:

1. Right-click on the project node and select **Options**. You can also double-click on the project node to bring up the Project Options dialog.

2. In the Project Options dialog, select **Build > Configurations**:

    ![Configurations manager in project options](media/create-and-edit-configurations-image2.png)

3. Select **Add** to create a new configuration. You can also copy any of the existing configurations.

Once you've created the configuration, you can use the **Build** section in the Project Options to adapt properties appropriate to your configuration:

![Configure build options](media/create-and-edit-configurations-image3.png)

## Creating a solution build configuration

To create a solution build configuration, follow these steps:

1. Right-click on the solution node and select **Options**. You can also double-click on the solution node to bring up the Solution Options dialog.

2. In the Solution Options dialog, select **Build > Configurations**:

    ![Configurations manager in solution options](media/create-and-edit-configurations-image1.png)

3. Select **Add** to create a new configuration. You can also copy any of the existing configurations.

Once you've created the configuration, you can use the **Build** section of the Project Options dialog for each of your projects to adapt properties appropriate to your configuration:

![Configure build options](media/create-and-edit-configurations-image3.png)

## Renaming a build configuration

To rename a configuration, select it from the Configuration list by navigating to **Build > Configurations** in the Project or Solution Options:

![configuration list](media/create-and-edit-configurations-image4.png)

Select the **Rename** button.

![rename dialog](media/create-and-edit-configurations-image5.png)

Then click **OK** to confirm.

## Related Video

> [!Video https://channel9.msdn.com/Shows/Visual-Studio-Toolbox/Visual-Studio-for-Mac-Launch-Multiple-Projects/player]

## See also

- [Create and edit build configurations (Visual Studio on Windows)](/visualstudio/ide/how-to-create-and-edit-configurations)