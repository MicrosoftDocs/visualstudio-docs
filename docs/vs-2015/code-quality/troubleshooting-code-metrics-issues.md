---
title: "Troubleshooting Code Metrics Issues | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: troubleshooting
ms.assetid: f2fdb995-4888-4246-85dc-7bacadd45968
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Troubleshooting Code Metrics Issues
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You might encounter some of the following issues when you collect code metrics:

- [Changes in Visual Studio 2010 code complexity calculations](#Changes_in_Visual_Studio_2010_code_complexity_calculations)

## <a name="Changes_in_Visual_Studio_2010_code_complexity_calculations"></a> Changes in Visual Studio 2010 code complexity calculations
 For the same function, the code complexity metric calculated in [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] can be different from the metric calculated by earlier versions of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] for the following situations:

- The function contains one or more catch blocks. In previous versions of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)], catch blocks were not included in the calculation. In [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)], the complexity of each catch block is added to the complexity of the function.

- The function contains a switch (Select Case in VB) statement. Compiler differences between [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)] and earlier versions can generate different MSIL code for some switch statements that contain fall-through cases.

## See Also
 [Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)
