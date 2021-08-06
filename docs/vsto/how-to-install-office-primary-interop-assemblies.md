---
title: "How to: Install Office primary interop assemblies"
description: Learn how to install the Microsoft Office primary interop assemblies (PIAs) when you install Office.
ms.custom: SEO-VS-2020
ms.date: "08/14/2019"
ms.topic: "how-to"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "primary interop assemblies [Office development in Visual Studio], installing"
  - "Office primary interop assemblies, installing"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# How to: Install Office primary interop assemblies
  Install the Microsoft Office primary interop assemblies (PIAs) when you install Office.

[!include[Add-ins note](includes/addinsnote.md)]

## To install the PIAs when you install Office

1. Ensure that you have a version of the .NET Framework that is no older than 2.0.

2. Install Microsoft Office and make sure that the **.NET Programmability Support** feature is selected for the applications you want to extend (this feature is included in the default installation).

    > [!WARNING]
    > By default, PIA's are embedded in your solution when you build it so you don't have to distribute PIAs to users as a prerequisite to using your VSTO Add-in or customization.

## See also
- [Office primary interop assemblies](../vsto/office-primary-interop-assemblies.md)
- [How to: Target Office applications through primary interop assemblies](../vsto/how-to-target-office-applications-through-primary-interop-assemblies.md)
- [How to: Configure a computer to develop Office solutions](../vsto/how-to-configure-a-computer-to-develop-office-solutions.md)
- [How to: Install the Visual Studio Tools for Office runtime redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md)
- [Office solutions development overview &#40;VSTO&#41;](../vsto/office-solutions-development-overview-vsto.md)
- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
