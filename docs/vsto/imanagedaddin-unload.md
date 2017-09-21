---
title: "IManagedAddin::Unload | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "Unload method"
  - 
ms.assetid: 40a73f07-2605-4745-8ac5-0a0189167fd7
caps.latest.revision: 8
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# IManagedAddin::Unload
  Called just before a managed VSTO Add-in is unloaded.  
  
## Syntax  
  
```  
HRESULT Unload();  
```  
  
## Return Value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 This method is not called by current versions of Microsoft Office. This method is reserved for future use.  
  
## See Also  
 [IManagedAddin Interface](../vsto/imanagedaddin-interface.md)   
 [IManagedAddin::Load](../vsto/imanagedaddin-load.md)  
  
  