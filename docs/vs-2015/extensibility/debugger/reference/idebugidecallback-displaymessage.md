---
title: "IDebugIDECallback::DisplayMessage | Microsoft Docs"
ms.custom: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugIDECallback::DisplayMessage"
ms.assetid: c19b48ee-b370-4fce-91fe-f82bf1e63179
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugIDECallback::DisplayMessage
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The latest version of this topic can be found at [IDebugIDECallback::DisplayMessage](https://docs.microsoft.com/visualstudio/extensibility/debugger/reference/idebugidecallback-displaymessage).  
  
Sends the specified message string to the debugger's output window.  
  
## Syntax  
  
```cpp#  
HRESULT DisplayMessage (  
   LPCOLESTR szMessage  
);  
```  
  
```csharp  
int DisplayMessage (  
   string szMessage  
);  
```  
  
#### Parameters  
 `szMessage`  
 [in] Message string to display in the debugger's output window.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugIDECallback](../../../extensibility/debugger/reference/idebugidecallback.md)

