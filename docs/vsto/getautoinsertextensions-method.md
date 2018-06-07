---
title: "GetAutoInsertExtensions method"
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
# GetAutoInsertExtensions method
  Gets information about the apps for Office that are to be automatically inserted during debugging.  
  
 This method is reserved for future use.  
  
## Syntax  
  
```c  
HRESULT GetAutoInsertExtensions(  
    [out, retval] SAFEARRAY(BSTR)* psaExtensionNames  
);  
```  
  
### Parameters  
  
|Parameter|Description|  
|---------------|-----------------|  
|*psaExtensionNames*|The extension names of the apps for Office.|  
  
## Return value  
 An HRESULT value that indicates whether the method completed successfully.  
  
## Remarks  
 Each app for Office to be inserted is returned as an Office application extension name, which corresponds to a value under **HKEY_CURRENT_USER\Software\Microsoft\Office\WEF\Developer**. The host must look up these values in the registry and then automatically insert the extensions.  
  
  