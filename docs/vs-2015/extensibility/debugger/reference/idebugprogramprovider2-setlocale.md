---
title: "IDebugProgramProvider2::SetLocale | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugProgramProvider2::SetLocale"
helpviewer_keywords: 
  - "IDebugProgramProvider2::SetLocale"
ms.assetid: b41d20a7-ba40-4c42-a450-16f413d6a04f
caps.latest.revision: 12
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugProgramProvider2::SetLocale
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugProgramProvider2::SetLocale](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugprogramprovider2-setlocale).  
  
Establishes a locale to be used for any locale-specific resources.  
  
## Syntax  
  
```cpp  
HRESULT SetLocale(  
   WORD wLangID  
);  
```  
  
```csharp  
int SetLocale(  
   ushort wLangID  
);  
```  
  
#### Parameters  
 `wLangID`  
 [in] Language ID to establish. For example, 1033 for English.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugProgramProvider2](../../../extensibility/debugger/reference/idebugprogramprovider2.md)

