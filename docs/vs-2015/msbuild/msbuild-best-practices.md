---
title: "MSBuild Best Practices | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: msbuild
ms.topic: reference
helpviewer_keywords: 
  - "best practices, MSBuild"
  - "MSBuild, best practices"
ms.assetid: 90ef8693-e921-410a-a377-fe4d13f58c48
caps.latest.revision: 8
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# MSBuild Best Practices
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

We recommend the following best practices for writing MSBuild scripts:  
  
- Default property values are best handled by using the `Condition` attribute, and not by declaring a property whose default value can be overridden on the command line. For example, use  
  
     `<MyProperty Condition="$(MyProperty)" == ''>`  
  
     `MyDefaultValue`  
  
     `</MyProperty>`  
  
- Avoid wildcards when you select items. Instead, specify files explicitly. This makes it easier to track down errors that may occur when you add or delete files.  
  
## See Also  
 [Advanced Concepts](../msbuild/msbuild-advanced-concepts.md)
