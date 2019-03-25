---
title: "IActiveScriptSiteUIControl::GetUIBehavior Method | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: 9a944335-856a-4c6b-b2bc-8872542941b7
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptSiteUIControl::GetUIBehavior Method
Gets a [SCRIPTUICHANDLING Enumeration](../../winscript/reference/scriptuichandling-enumeration.md) that represents the way that a UI control should be handled.  
  
## Syntax  
  
```cpp
HRESULT GetUIBehavior(     [in] SCRIPTUICITEM UicItem,     [out] SCRIPTUICHANDLING * pUicHandling );   
```  
  
#### Parameters  
 `UicItem`  
 The type of the control.  
  
 `pUicHandling`  
 The way the control should be handled.