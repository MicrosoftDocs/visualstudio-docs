---
title: "IDebugPortPicker::SetSite | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugPortPicker::SetSite"
ms.assetid: 7319e187-adfe-4b3f-aec9-521356fb5a8a
caps.latest.revision: 6
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
# IDebugPortPicker::SetSite
Sets the service provider.  
  
## Syntax  
  
```cpp#  
HRESULT SetSite(  
   IServiceProvider * pSP  
);  
```  
  
```c#  
public int SetSite(  
   IServiceProvider pSP  
);  
```  
  
#### Parameters  
 `pSP`  
 [in] Reference to the interface of the service provider.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method will be called before any other methods are called.  
  
## See Also  
 [IDebugPortPicker](../../../extensibility/debugger/reference/idebugportpicker.md)