---
title: "Installing the R Tools for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: 10/20/2017
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-r"
ms.tgt_pltfrm: ""
ms.devlang: r
ms.topic: "article"
caps.latest.revision: 1
author: "kraigb"
ms.author: "kraigb"
manager: ghogen
ms.workload: 
  - "data-science"
---

# How to install R Tools for Visual Studio

In this topic:

- [Supported versions of Visual Studio](#supported-versions-of-visual-studio)
- [Installing RTVS in Visual Studio 2017](#installing-rtvs-in-visual-studio-2017)
- [Installing RTVS in Visual Studio 2015](#installing-rtvs-in-visual-studio-2015)
- [Offline installation](#offline-installation-of-visual-studio-and-rtvs)

> [!Note]
> After installing R Tools, you may want to configure Visual Studio for an optimized data scientist layout, as described on the [Options](options.md) topic.

## Supported versions of Visual Studio

R Tools for Visual Studio (RTVS) is supported on Windows with the Community (free), Professional, and Enterprise editions of both [Visual Studio 2017](https://www.visualstudio.com/downloads/) and [Visual Studio 2015 Update 3 (or higher)](http://go.microsoft.com/fwlink/?LinkId=691129) (direct download).

RTVS is not presently supported on Visual Studio for Mac.

RTVS does not install if you have only the Visual Studio Shell that's included with products such as Visual Studio Test Professional and SQL Server Management Studio. Visual Studio Shell lacks the necessary components for RTVS.

## Installing RTVS in Visual Studio 2017

1. Run the Visual Studio installer. (See [Downloads](https://www.visualstudio.com/downloads/) if you don't yet have Visual Studio installed.) On Windows 7, be sure that your installer is updated to show Visual Studio version *15.2 build 26430.12* or later.

1. Select the **Data science and analytical applications** workload:

    ![Data science and analytical applications workload in VS2017](media/installation-data-science-workload.png)

1. Set any additional options on the right side under the same workload name. By default, this workload includes F# and Python support. For R, minimum requirements are **R language support**, **Runtime support for R development**, and **Microsoft R client**.

RTVS is installed in: `%ProgramFiles(x86)%\Microsoft Visual Studio\<version>\<edition>Common7\IDE\Extensions\Microsoft\R Tools for Visual Studio` where `<version>` is typically `2017` and `<edition>` is `Community`, `Professional`, or `Enterprise`.

## Installing RTVS in Visual Studio 2015

With Visual Studio 2015, you need to install an R interpreter and the R Tools separately.

### Install an R interpreter

RTVS requires a 64-bit installation of R version 3.2.1 or higher from one or more of the following sources:

- [Microsoft R Open](https://mran.microsoft.com/download/)
- [Microsoft R Client](/machine-learning-server/r-client/what-is-microsoft-r-client)
- [CRAN R](https://cran.r-project.org/bin/windows/base/)

Microsoft R Open and CRAN R both allow for multiple side-by-side versions. Microsoft R Client, however, supports only one version and always uses the latest one you installed.

### Install the R tools

Download the current RTVS for Visual Studio 2015 from [https://aka.ms/rtvs-current](https://aka.ms/rtvs-current). RTVS checks for a suitable version of Visual Studio and helps you install an R interpreter if you haven't already.

> [!Note]
> The standalone RTVS installer works only with Visual Studio 2015; with Visual Studio 2017, install R support through the [Data Science and Analytical Applications workload](#installing-rtvs-in-visual-studio-2017) as described earlier.

RTVS for Visual Studio 2015 is installed in: `%ProgramFiles(x86)%\Microsoft Visual Studio 14\Common7\IDE\Extensions\Microsoft\R Tools for Visual Studio`

## Offline installation of Visual Studio and RTVS

Offline installation is suitable for computers that are not connected to the Internet:

1. Follow the instructions to create an offline installer for your version of Visual Studio: 

    - [Visual Studio 2017](../install/create-an-offline-installation-of-visual-studio.md)
    - [Visual Studio 2015](https://msdn.microsoft.com/library/mt706497.aspx)

1. For Visual Studio 2015, download the offline RTVS installers from [https://aka.ms/rtvs-current-zip](https://aka.ms/rtvs-current-zip) and [https://aka.ms/rtvs-remote-zip](https://aka.ms/rtvs-remote-zip). 

1. Install Visual Studio and RTVS from the offline installers.

## See also

- [Getting started with R](getting-started-with-r.md)
- [R Tools sample projects](getting-started-samples.md)
- [Getting help](getting-started-help.md)
- [Option settings](options.md)
- [Microsoft Machine Learning Server (formerly R Server)](/machine-learning-server/)