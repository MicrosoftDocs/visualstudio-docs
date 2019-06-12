---
title: "IDebugSettingsCallback2::EnumEEs | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugSettingsCallback2::EnumEEs"
ms.assetid: 9f884c49-426f-461b-b547-9d909486e73f
caps.latest.revision: 8
ms.author: gregvanl
manager: jillfra
---
# IDebugSettingsCallback2::EnumEEs
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Enumerates the available expression evaluators given the language and vendor identifiers.  
  
## Syntax  
  
```cpp#  
HRESULT EnumEEs(  
   DWORD  celtBuffer,  
   GUID*  rgguidLang,  
   GUID*  rgguidVendor,  
   DWORD* pceltEEs  
);  
```  
  
```csharp  
public int EnumEEs(  
   uint       celtBuffer,  
   ref Guid   rgguidLang,  
   ref Guid   rgguidVendor,  
   ref uint[] pceltEEs  
);  
```  
  
#### Parameters  
 `celtBuffer`  
 [in] Number of elements in the `pceltEEs` buffer.  
  
 `rgguidLang`  
 [in, out] Unique identifier for the programming language.  
  
 `rgguidVendor`  
 [in, out] Unique identifier for the vendor.  
  
 `pceltEEs`  
 [in, out] Array of expression evaluators.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
