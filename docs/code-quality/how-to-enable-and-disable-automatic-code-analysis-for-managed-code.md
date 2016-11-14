---
title: "How to: Enable and Disable Automatic Code Analysis for Managed Code | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7c22d194-5fea-4f23-b02d-19344fa64a64
caps.latest.revision: 8
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# How to: Enable and Disable Automatic Code Analysis for Managed Code
You can configure Code Analysis to run before each build of a managed code project. You can set different Code Analysis properties for each [!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] configuration.  
  
### To enable or disable automatic code analysis  
  
1.  In **Solution Explorer**, right-click the project, and then click **Properties**.  
  
2.  In the properties dialog box for the project, click **Code Analysis**.  
  
3.  Specify the build type in **Configuration** and the target platform in **Platform**.  
  
4.  To enable or disable automatic code analysis, select or clear the **Enable Code Analysis on Build (defines CODE_ANALYSIS constant)** check box.