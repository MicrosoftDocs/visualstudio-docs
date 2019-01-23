---
title: "IDebugProgramHost2::GetHostName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramHost2::GetHostName"
helpviewer_keywords: 
  - "IDebugProgramHost2::GetHostName"
ms.assetid: 48bbb089-e59a-471a-9965-24b42a8dabf3
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramHost2::GetHostName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the title, friendly name, or file name of the hosting process of this program.  
  
## Syntax  
  
```cpp#  
HRESULT GetHostName(   
   DWORD dwType,  
   BSTR* pbstrHostName  
);  
```  
  
```csharp  
int GetHostName(   
   uint dwType,  
   out string pbstrHostName  
);  
```  
  
#### Parameters  
 `dwType`  
 [in] A value from the [GETHOSTNAME_TYPE](../../../extensibility/debugger/reference/gethostname-type.md) enumeration.  
  
 `pbstrHostName`  
 [out] Returns the requested name of the hosting process.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 In a typical implementation of this method, the `dwType` parameter is ignored and a friendly name of the host machine is returned. Another possible implementation is to pass the `dwType` parameter to a call to the [GetHostName](../../../extensibility/debugger/reference/idebugprogramnode2-gethostname.md) method to get the name.  
  
## See Also  
 [IDebugProgramHost2](../../../extensibility/debugger/reference/idebugprogramhost2.md)   
 [GetHostName](../../../extensibility/debugger/reference/idebugprogramnode2-gethostname.md)
