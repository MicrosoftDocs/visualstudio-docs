---
title: "Installing the R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 4/10/2017
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 3ff60292-1b88-4ee9-b2b2-edd957f1a519
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: "ghogen"
translation.priority.ht:
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---

# How to install R Tools for Visual Studio

In this topic:

- [Supported versions of Visual Studio](#prerequisites)
- [Install an R interpreter](#install-an-r-interpreter)
- [Install R Tools](#install-r-tools)
- [Offline installation](#offline-installation)


## Supported versions of Visual Studio

R Tools for Visual Studio (RTVS) is supported on the Community, Professional, and Enterprise editions of [Visual Studio 2015 Update 3 (or higher)](http://go.microsoft.com/fwlink/?LinkId=691129) and [Visual Studio 2017](https://www.visualstudio.com/downloads/). 

RTVS will not install if you have only the Visual Studio Shell that's included with other products such as Visual Studio Test Professional and SQL Server Management Studio. This is because Visual Studio Shell lacks the necessary components for RTVS.

## Install an R interpreter

RTVS requires a 64-bit installation of R version 3.2.1 or higher from one of the following sources:

* [Microsoft R Open](https://mran.microsoft.com/download/)
* [Microsoft R Client](https://msdn.microsoft.com/microsoft-r/r-client-get-started)
* [CRAN R](https://cran.r-project.org/bin/windows/base/)

If you don't have an R distribution installed before you install RTVS, you will be prompted to install an R distribution during setup.

## Install the R tools

Download the current RTVS from [https://aka.ms/rtvs-current](https://aka.ms/rtvs-current). RTVS will check for a suitable version of Visual Studio and will also help you install an R interpreter if you haven't already.

RTVS will be installed in the following locations:
- Visual Studio 2017: `%ProgramFiles(x86)%\Microsoft Visual Studio <VS version>\Common7\IDE\Extensions\Microsoft\R Tools for Visual Studio`
- Visual Studio 2015: `%ProgramFiles(x86)%\Microsoft Visual Studio 14\Common7\IDE\Extensions\Microsoft\R Tools for Visual Studio`

## Offline installation of Visual Studio and RTVS

Offline installation is suitable for computers that are not connected to the Internet:

1. Follow the instructions to create an offline installer for your version of Visual Studio as below. 

- [Visual Studio 2017](../install/create-an-offline-installation-of-visual-studio)
 -[Visual Studio 2015](https://msdn.microsoft.com/library/mt706497.aspx)

1. Install Visual Studio from the offline installer.
1. [Download RTVS](https://aka.ms/rtvs-current) and install it as usual.


## Where is RTVS installed?

R Tools for Visual Studio installs in this folder:



## Try the samples

Once you've installed RTVS, try some of the samples from Github:

[Samples documentation](samples.md)


## Window Layout for Data Scientists in Visual Studio

Visual Studio is a fantastic developer tool, and its user interface is optimized around the needs of a developer. We realize that data scientists have different needs, so we've come up with a streamlined experience that is tailored for the needs of data scientists.

We know that some of you prefer to retain your existing Visual Studio settings, so we leave things this way by default. However, for those of you who want our tailored experience, enabling it is really easy to do. Just run the Data Science Settings from the R Tools menu:

![](media/installation-data-scientist-layout.png)

> [!Important]		
> Save your current settings if you want to revert back to them using this command: Tools > Import and Export Settings.

After running this command, you'll have a Visual Studio layout that resembles this:

![](media/installation-data-scientist-layout-result.png)
