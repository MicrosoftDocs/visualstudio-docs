---
title: "SccIsMultiCheckoutEnabled Function | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "SccIsMultiCheckoutEnabled"
helpviewer_keywords: 
  - "SccIsMultiCheckoutEnabled function"
ms.assetid: 6721639d-e475-4766-81b5-ee40a280fc70
caps.latest.revision: 13
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
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
# SccIsMultiCheckoutEnabled Function
This function checks whether the source control plug-in allows multiple checkouts on a file.  
  
## Syntax  
  
```cpp#  
SCCRTN SccIsMultiCheckoutEnabled(  
   LPVOID pContext,  
   LPBOOL pbMultiCheckout  
);  
```  
  
#### Parameters  
 pContext  
 [in] The source control plug-in context structure.  
  
 pbMultiCheckout  
 [out] Specifies whether multiple checkouts are enabled for this project (nonzero means that multiple checkouts are supported).  
  
## Return Value  
 The source control plug-in implementation of this function is expected to return one of the following values:  
  
|Value|Description|  
|-----------|-----------------|  
|SCC_OK|The check was successful.|  
|SCC_E_NONSPECIFICERROR<br /><br /> SCC_E_UNKNOWNERROR|Nonspecific failure.|  
  
## Remarks  
 The IDE makes two checks to determine if files can be checked out simultaneously by more than one user. First, the source control system must support multiple checkouts. The source control plug-in can specify this capability during initialization by specifying the `SCC_CAP_MULTICHECKOUT`. Thereafter, as a second check, the IDE calls this function to determine whether or not the current project supports multiple checkouts. If multiple checkouts are supported for the selected project, the plug-in returns a success code and sets `pbMultiCheckout` to nonzero (`TRUE`) or `FALSE`.  
  
## See Also  
 [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)