---
title: "Troubleshooting Code Metrics Issues | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: f2fdb995-4888-4246-85dc-7bacadd45968
caps.latest.revision: 4
author: "erickson-doug"
ms.author: "douge"
manager: "douge"
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
# Troubleshooting Code Metrics Issues
You might encounter some of the following issues when you collect code metrics:  
  
-   [Changes in Visual Studio 2010 code complexity calculations](#Changes_in_Visual_Studio_2010_code_complexity_calculations)  
  
##  <a name="Changes_in_Visual_Studio_2010_code_complexity_calculations"></a> Changes in Visual Studio 2010 code complexity calculations  
 For the same function, the code complexity metric calculated in [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] can be different from the metric calculated by earlier versions of [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] for the following situations:  
  
-   The function contains one or more catch blocks. In previous versions of [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)], catch blocks were not included in the calculation. In [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)], the complexity of each catch block is added to the complexity of the function.  
  
-   The function contains a switch (Select Case in VB) statement. Compiler differences between [!INCLUDE[vs_dev10_long](../code-quality/includes/vs_dev10_long_md.md)] and earlier versions can generate different MSIL code for some switch statements that contain fall-through cases.  
  
## See Also  
 [Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)