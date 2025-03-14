---
title: Visual Studio Tools for Office Runtime Lifecycle Policy
description: Explore the support lifecycle policy for the Visual Studio Tools for Office Runtime, including available versions and release dates.
titleSuffix: ""
ms.date: "10/4/2021"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Office development in Visual Studio, getting started"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Visual Studio Tools for Office Runtime

## Visual Studio Tools for Office Support Statement

The Visual Studio Tools for Office (VSTO) Runtime Add-Ins platform is supported and serviced in Office with .NET Framework 4.8 as the last major version. If you have existing .NET Framework solutions that you are maintaining, there is no need to move them to .NET.

However, VSTO Add-Ins cannot be created with .NET due to technical limitations with running .NET and .NET Framework in the same process. Microsoft will not update the VSTO platform to use .NET. You can take advantage of .NET, including ASP.NET Core, to create the server side of Office Web Add-ins.

The VSTO Add-Ins platform was built before today’s cross-platform world. Moving forward, to take advantage of opportunities with cloud-centered, cross-platform, and cross-device development, we recommend using the cross-platform JavaScript APIs. More can be found at [Office Add-ins platform overview](/office/dev/add-ins/overview/office-add-ins).

## Visual Studio Tools for Office Runtime Lifecycle

The Visual Studio 2010 Tools for Office Runtime (VSTO Runtime) ships with various versions of Visual Studio and Microsoft Office and follows the support lifecycle of the parent product.

It's also [available to download](https://aka.ms/VSTORuntimeDownload) and install independently. The versions of VSTO Runtime that are available on the download center follow the support lifecycle of the latest version of Microsoft Office that was available at the time of its release.

Developers should install the latest version of the VSTO Runtime with their applications. It's only supported when running with supported versions Office. If the VSTO Runtime needs to be serviced, only the latest version will be updated.

## VSTO Runtime Versions
The following list contains the VSTO Runtime releases and the corresponding version of Office for which its support lifecycle follows: 

| VSTO Runtime version | Release date | Microsoft Office version |
| --- | --- | --- |
| 10.0.21022 | 07/15/2010 | Microsoft Office 2010 |
| 10.0.40303 | 12/21/2012 | Microsoft Office 2010 SP1 |
| 10.0.31007 | 06/15/2011 | Microsoft Office 2010 Sp1 |
| 10.0.40305 | 05/01/2013 | Microsoft Office 2010 Sp2 |
| 10.0.31129 | 01/09/2013 | Microsoft Office 2013 |
| 10.0.40309 | 06/18/2013 | Microsoft Office 2013 |
| 10.0.40820 | 10/16/2013 | Microsoft Office 2013 |
| 10.0.50325 | 04/10/2014 | Microsoft Office 2013 SP1 |
| 10.0.60301 | 09/22/2015 | Microsoft Office 2016 |
| 10.0.60715 | 07/20/2015 | Microsoft Office 2016 |
| 10.0.60724 | 07/24/2015 | Microsoft Office 2016 |
| 10.0.60825 | 11/19/2016 | Microsoft Office 2016 |
| 10.0.60828 | 01/12/2018 | Microsoft Office 2019 / <br>Microsoft Office 2021 / <br>Office 365 |
| 10.0.60910 | 08/08/2023 | Microsoft Office 2013 / <br>Microsoft Office 2016 / <br>Microsoft Office 2019 / <br>Microsoft Office 2021 / <br>Office 365 |
| 10.0.60912 | 11/01/2023 | Microsoft Office 2019 / <br>Microsoft Office 2021 / <br>Office 365 |
| 10.0.60917 | 02/28/2024 | Microsoft Office 2019 / <br>Microsoft Office 2021 / <br>Office 365 |

For more information on the Office Support Lifecycle, see [Lifecycle FAQ - Office, Office 365, and Microsoft 365](/lifecycle/faq/office).
