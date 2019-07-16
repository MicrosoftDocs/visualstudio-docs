---
title: "IDebugWindowsComputerPort2::GetComputerInfo | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "GetComputerInfo"
  - "IDebugWindowsComputerPort2::GetComputerInfo"
ms.assetid: 654910b2-c239-44c8-92fc-317680a5672f
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugWindowsComputerPort2::GetComputerInfo
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves information about the computer on which the debugger in running.  
  
## Syntax  
  
```cpp#  
HRESULT GetComputerInfo(  
   COMPUTER_INFO * pInfo  
);  
```  
  
```csharp  
public int GetComputerInfo(  
   out COMPUTER_INFO[] pInfo  
);  
```  
  
#### Parameters  
 `pInfo`  
 [out] Reference to a structure that contains the computer information.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugWindowsComputerPort2](../../../extensibility/debugger/reference/idebugwindowscomputerport2.md)   
 [COMPUTER_INFO](../../../extensibility/debugger/reference/computer-info.md)
