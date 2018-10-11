---
title: "IDebugProgram2::GetEngineInfo | Microsoft Docs"
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
  - "IDebugProgram2::GetEngineInfo"
helpviewer_keywords: 
  - "IDebugProgram2::GetEngineInfo"
ms.assetid: 3a4f2dc0-e082-4d8d-aeaf-463ab09d279b
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugProgram2::GetEngineInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugProgram2::GetEngineInfo](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugprogram2-getengineinfo).  
  
Gets the name and GUID of the debug engine (DE) running this program.  
  
## Syntax  
  
```cpp#  
HRESULT GetEngineInfo(   
   BSTR* pbstrEngine,  
   GUID* pguidEngine  
);  
```  
  
```csharp  
int GetEngineInfo(   
   out string pbstrEngine,  
   out GUID   pguidEngine  
);  
```  
  
#### Parameters  
 `pbstrEngine`  
 [out] Returns the name of the DE running this program.  
  
 `pguidEngine`  
 [out] Returns the GUID of the DE running this program.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Each DE defines its own GUID for identification.  
  
## See Also  
 [IDebugProgram2](../../../extensibility/debugger/reference/idebugprogram2.md)

