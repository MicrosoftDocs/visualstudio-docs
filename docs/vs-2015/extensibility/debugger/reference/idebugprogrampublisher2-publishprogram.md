---
title: "IDebugProgramPublisher2::PublishProgram | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugProgramPublisher2::PublishProgram"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::PublishProgram"
ms.assetid: 92ff63f0-e869-4040-b3ae-b2c899e708ff
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugProgramPublisher2::PublishProgram
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This method makes a program available for debug engines (DEs) and the session debug manager.  
  
## Syntax  
  
```cpp  
HRESULT PublishProgram(  
   CONST_GUID_ARRAY Engines,  
   LPCOLESTR        szFriendlyName,  
   IUnknown*        pDebuggeeInterface  
);  
```  
  
```csharp  
int PublishProgram(  
   CONST_GUID_ARRAY Engines,  
   string           szFriendlyName,  
   object           pDebuggeeInterface  
);  
```  
  
#### Parameters  
 `Engines`  
 [in] An array of GUIDs for DEs that can launch or attach to this program.  
  
 `szFriendlyName`  
 [in] Friendly name for the program (this appears in menus or dialogs presented to the user).  
  
 `pDebuggeeInterface`  
 [in] `IUnknown` interface for the program (this value is used as a cookie to uniquely identify the program; this same value is used to "unpublish" the program)  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 To make a program no longer available for debugging, call [UnpublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogram.md).  
  
## See Also  
 [IDebugProgramPublisher2](../../../extensibility/debugger/reference/idebugprogrampublisher2.md)   
 [UnpublishProgram](../../../extensibility/debugger/reference/idebugprogrampublisher2-unpublishprogram.md)
