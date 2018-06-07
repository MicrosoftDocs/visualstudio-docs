---
title: "GetValidCompatibleFramework function"
ms.custom: ""
ms.date: "02/02/2017"
ms.technology: 
  - "office-development"
ms.topic: "conceptual"
dev_langs: 
  - "VB"
  - "CSharp"
author: TerryGLee
ms.author: tglee
manager: douge
ms.workload: 
  - "office"
---
# GetValidCompatibleFramework function
  This API supports the Office infrastructure and isn't intended to be used directly from your code.  
  
## Syntax  
  
```c  
HRESULT WINAPI GetValidCompatibleFramework(  
    LPCWSTR lpwszCompatibleFrameworksXML,  
    BSTR* pbstrValidFrameworkTag  
);  
```  
  
### Parameters  
|Parameter|Description|  
|---------------|-----------------|  
|*lpwszCompatibleFrameworksXML*|Don't use.|  
|*pbstrValidFrameworkTag*|Don't use.|  
  
## Return value  
 If the function succeeds, it returns **S_OK**. If the function fails, it returns an error code.  
  
  