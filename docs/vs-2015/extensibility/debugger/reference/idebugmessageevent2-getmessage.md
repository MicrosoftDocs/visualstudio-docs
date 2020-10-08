---
title: "IDebugMessageEvent2::GetMessage | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugMessageEvent2::GetMessage"
helpviewer_keywords: 
  - "GetMessage method"
  - "IDebugMessageEvent2::GetMessage method"
ms.assetid: 9fca7285-f7f1-422d-8565-92bf0e0db60a
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# IDebugMessageEvent2::GetMessage
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the message to be displayed.  
  
## Syntax  
  
```cpp#  
HRESULT GetMessage(   
   MESSAGETYPE* pMessageType,  
   BSTR*        pbstrMessage,  
   DWORD*       pdwType,  
   BSTR*        pbstrHelpFileName,  
   DWORD*       pdwHelpId  
);  
```  
  
```csharp  
int GetMessage(   
   out enum_MESSAGETYPE pMessageType,  
   out string           pbstrMessage,  
   out uint             pdwType,  
   out string           pbstrHelpFileName,  
   out uint             dwHelpId  
);  
```  
  
#### Parameters  
 `pMessageType`  
 [out] Returns a value from the [MESSAGETYPE](../../../extensibility/debugger/reference/messagetype.md) enumeration that describes the type of the message.  
  
 `pbstrMessage`  
 [out] Returns the message.  
  
 `pdwType`  
 [out] Returns the type of the message, using the conventions of the Win32 `MessageBox` function. See the [AfxMessageBox](https://msdn.microsoft.com/library/d66d0328-cdcc-48f6-96a4-badf089099c8) function for details.  
  
 `pbstrHelpFileName`  
 [in, out] Returns the help file name. May be a null (C++) or empty (C#) value if there is no help file.  
  
 `pdwHelpId`  
 [in, out] Returns the help identifier. May be 0 if there is no help associated with this message.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugMessageEvent2](../../../extensibility/debugger/reference/idebugmessageevent2.md)   
 [MESSAGETYPE](../../../extensibility/debugger/reference/messagetype.md)   
 [AfxMessageBox](https://msdn.microsoft.com/library/d66d0328-cdcc-48f6-96a4-badf089099c8)
