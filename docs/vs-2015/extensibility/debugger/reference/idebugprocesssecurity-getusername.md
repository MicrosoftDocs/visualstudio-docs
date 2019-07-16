---
title: "IDebugProcessSecurity::GetUserName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugProcessSecurity::GetUserName"
ms.assetid: c73c60ac-da6e-45ae-8f04-95353a24ca3e
caps.latest.revision: 5
ms.author: gregvanl
manager: jillfra
---
# IDebugProcessSecurity::GetUserName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the user name from the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT GetUserName(  
    BSTR *pbstrUserName  
);  
```  
  
```csharp  
int GetUserName (  
    string pbstrUserName  
);  
```  
  
#### Parameters  
 `pbstrUserName`  
 [out] A string containing the user name.  
  
## Return Value  
 If the method succeeds, it returns `S_OK`. Otherwise it returns an error code.  
  
## Remarks  
 `GetUserName` returns the user name that is displayed in the **User Name** column of the **Attach to Process** dialog box. To view the **Attach to Process** dialog box, click **Attach to Process** on the **Tools** menu in the [!INCLUDE[vsprvs](../../../includes/vsprvs-md.md)] integrated development environment (IDE).  
  
## See Also  
 [IDebugProcessSecurity](../../../extensibility/debugger/reference/idebugprocesssecurity.md)
