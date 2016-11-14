---
title: "IDebugProcessSecurity::GetUserName | Microsoft Docs"
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
  - "IDebugProcessSecurity::GetUserName"
ms.assetid: c73c60ac-da6e-45ae-8f04-95353a24ca3e
caps.latest.revision: 4
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
# IDebugProcessSecurity::GetUserName
Gets the user name from the port supplier.  
  
## Syntax  
  
```cpp#  
HRESULT GetUserName(  
    BSTR *pbstrUserName  
);  
```  
  
```c#  
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
 `GetUserName` returns the user name that is displayed in the **User Name** column of the **Attach to Process** dialog box. To view the **Attach to Process** dialog box, click **Attach to Process** on the **Tools** menu in the [!INCLUDE[vsprvs](../../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE).  
  
## See Also  
 [IDebugProcessSecurity](../../../extensibility/debugger/reference/idebugprocesssecurity.md)