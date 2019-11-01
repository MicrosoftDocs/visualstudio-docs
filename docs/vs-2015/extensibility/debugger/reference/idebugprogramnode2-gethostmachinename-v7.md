---
title: "IDebugProgramNode2::GetHostMachineName_V7 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramNode2::GetHostMachineName"
helpviewer_keywords: 
  - "IDebugProgramNode2::GetHostMachineName_V7"
  - "IDebugProgramNode2::GetHostMachineNameIDebugProgramNode2::GetHostMachineName"
ms.assetid: a992f2c9-f68b-4146-8cc2-027753bf7ce6
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramNode2::GetHostMachineName_V7
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

DEPRECATED. DO NOT USE.  
  
## Syntax  
  
```cpp#  
HRESULT GetHostMachineName_V7 (   
   BSTR* pbstrHostMachineName  
);  
```  
  
```csharp  
int GetHostMachineName_V7 (   
   out string pbstrHostMachineName  
);  
```  
  
#### Parameters  
 `pbstrHostMachineName`  
 [out] Returns the name of the machine in which the program is running.  
  
## Return Value  
 An implementation should always return `E_NOTIMPL`.  
  
## Remarks  
  
> [!WARNING]
> As of [!INCLUDE[vsprvslong](../../../includes/vsprvslong-md.md)], this method is no longer used and should always return `E_NOTIMPL`.  
  
## See Also  
 [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md)
