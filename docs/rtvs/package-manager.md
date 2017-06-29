---
title: "Package Manager in the R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 4/26/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 93accb9a-1ef8-4806-baa4-02477c2d7ef0
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "es-es"
  - "ja-jp"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
  - "ko-kr"
  - "cs-cz"
  - "de-de"
  - "fr-fr"
  - "it-it"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---

# Package manager

The R Tools for Visual Studio (RTVS) package manager is a UI for managing the R packages. To open it, select **R Tools > Windows > Packages** or pressing Ctrl+7.

The package manager has three tabs as described below. All the tabs display a list of relevant packages on the left and specific details for the selected package on the right, including the package's version, description, license, install location, and links to other relevant information. The search box on the upper right lets you filter the list.

> [!Tip]
> The term in the search box remains in effect as you switch between tabs.

- **Available** lets you browse packages to install. If the package is already installed, tne **Install** button on the right will change to **Uninstall**.

    ![Available packages tab in the R Tools for Visual Studio package manager](media/package-manager-available.png)

- **Installed** shows all installed and loaded packages. A green dot next to a package indicates that it's loaded into the R session. The red X icon in the left-hand list or the **Uninstall** button on the right can be used to uninstall the package. A blue up arrow to the right of an installed package updates the package if a newer version is available.

    ![Installed packages tab in the R Tools for Visual Studio package manager](media/package-manager-installed.png)

- **Loaded** displays only those packages that are loaded into the R session, and thus all will appear with a green dot. You can also uninstall and update packages here.

    ![Loaded packages tab in the R Tools for Visual Studio package manager](media/package-manager-loaded.png)

## Package locations

Packages are installed in the following locations:

- Core packages that are included with RTVS are installed in `C:\Program Files\Microsoft\R Client\R_SERVER\library`
- Additional packages are installed to `%userprofile%\Documents\R\win-library\3.3`
