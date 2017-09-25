---
title: "GetValidCompatibleFramework Function | Microsoft Docs"
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
ms.assetid: dfb365c0-5ffc-4290-ab8b-bd347e0f0db9
caps.latest.revision: 7
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# GetValidCompatibleFramework Function
  This API supports the Office infrastructure and isn't intended to be used directly from your code.  
  
## Syntax  
  
```  
HRESULT WINAPI GetValidCompatibleFramework(  
    LPCWSTR lpwszCompatibleFrameworksXML,  
    BSTR* pbstrValidFrameworkTag  
);  
```  
  
#### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*lpwszCompatibleFrameworksXML*|Don't use.|  
|*pbstrValidFrameworkTag*|Don't use.|  
  
## Return Value  
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.  
  
  