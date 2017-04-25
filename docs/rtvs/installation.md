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
- [Installation in Visual Studio 2017](#installation-in-visual-studio-2017)
- [Installation in Visual Studio 2015](#installation-in-visual-studio-2015)
- [Offline installation](#offline-installation)

> [!Note]
> After installing R Tools, you may want to configure Visual Studio for an optimized data scientist layout, as described on the [Options](options.md#data-scientist-layout) topic.

## Supported versions of Visual Studio

R Tools for Visual Studio (RTVS) is supported on the Community, Professional, and Enterprise editions of [Visual Studio 2015 Update 3 (or higher)](http://go.microsoft.com/fwlink/?LinkId=691129) and [Visual Studio 2017](https://www.visualstudio.com/downloads/). 

RTVS will not install if you have only the Visual Studio Shell that's included with other products such as Visual Studio Test Professional and SQL Server Management Studio. This is because Visual Studio Shell lacks the necessary components for RTVS.


## Installing RTVS in Visual Studio 2017

1. Run the Visual Studio installer.
2. Select the **Data science and analytical applications** workload:

    [Data science and analytical applications workload in VS2017](media/installation-data-science-workload.png)

3. Set any additional options on the right side under the same workload name. Note that by default, this workload includes F# and Python support. For R, you must at a minimum select **R language support**, **Runtime support for R development**, and **Microsoft R client**.

RTVS is installed in `%ProgramFiles(x86)%\Microsoft Visual Studio <VS version>\Common7\IDE\Extensions\Microsoft\R Tools for Visual Studio`.


## Installing RTVS in Visual Studio 2015

With Visual Studio 2015, you need to install an R interpreter and the R Tools separately.

### Install an R interpreter

RTVS requires a 64-bit installation of R version 3.2.1 or higher from one of the following sources:

* [Microsoft R Open](https://mran.microsoft.com/download/)
* [Microsoft R Client](https://msdn.microsoft.com/microsoft-r/r-client-get-started)
* [CRAN R](https://cran.r-project.org/bin/windows/base/)

If you don't have an R distribution installed before you install RTVS, you will be prompted to install an R distribution during setup.

## Install the R tools

Download the current RTVS from [https://aka.ms/rtvs-current](https://aka.ms/rtvs-current). RTVS will check for a suitable version of Visual Studio and will also help you install an R interpreter if you haven't already.

RTVS is installed in `%ProgramFiles(x86)%\Microsoft Visual Studio 14\Common7\IDE\Extensions\Microsoft\R Tools for Visual Studio`.

## Offline installation of Visual Studio and RTVS

Offline installation is suitable for computers that are not connected to the Internet:

1. Follow the instructions to create an offline installer for your version of Visual Studio as below. 

- [Visual Studio 2017](../install/create-an-offline-installation-of-visual-studio.md)
 -[Visual Studio 2015](https://msdn.microsoft.com/library/mt706497.aspx)

1. Install Visual Studio from the offline installer.
1. [Download RTVS](https://aka.ms/rtvs-current) and install it as usual.

## See also

- [Getting started with R](getting-started-with-r.md)
- [R Tools sample projects](samples.md)
- [Getting help](getting-help.md)
- [Option settings](options.md)
