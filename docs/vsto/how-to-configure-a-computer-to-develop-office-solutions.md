---
title: "How to: Configure a computer to develop Office solutions"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "prerequisites [Office development in Visual Studio]"
  - "Office development in Visual Studio, installing tools"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Configure a computer to develop Office solutions
  To configure a development computer so that you can use the Microsoft Office developer tools in Visual Studio, follow the instructions in this topic. You must have administrative privileges on the development computer to perform these steps.

### To configure the development computer

1. Install a version of Visual Studio that includes the Office developer tools. The Office developer tools are installed by default. If you customize the Visual Studio installation by selecting which features to install, make sure that **Microsoft Office Developer Tools** is selected during setup. For more information about the versions of Visual Studio that include the Office developer tools, see [Configure a computer to develop Office solutions](../vsto/configuring-a-computer-to-develop-office-solutions.md).

2. Install a version of Office that is supported by the Office developer tools in Visual Studio. For more information, see [Configure a computer to develop Office solutions](../vsto/configuring-a-computer-to-develop-office-solutions.md).

     Make sure that you also install the PIAs for the version of Office that you install. The PIAs are installed with Office by default. If you modify Office setup, make sure that the **.NET Programmability Support** feature is selected for the applications you want to target.

3. If you have an English version of Visual Studio but use non-English settings for Windows, you can install the [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] language pack to see [!INCLUDE[vsto_runtime](../vsto/includes/vsto-runtime-md.md)] messages in the same language as Windows. Non-English versions of Visual Studio automatically install the language pack. The language pack is available from the [Microsoft download center](https://www.microsoft.com/download/details.aspx?id=54246).

## See also

- [Get started &#40;Office development in Visual Studio&#41;](../vsto/getting-started-office-development-in-visual-studio.md)
- [How to: Install the Visual Studio Tools for Office runtime redistributable](../vsto/how-to-install-the-visual-studio-tools-for-office-runtime-redistributable.md)
- [How to: Install Office primary interop assemblies](../vsto/how-to-install-office-primary-interop-assemblies.md)
