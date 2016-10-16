---
title: "IDebugMessageEvent2::GetMessage"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugMessageEvent2::GetMessage"
helpviewer_keywords: 
  - "GetMessage method"
  - "IDebugMessageEvent2::GetMessage method"
ms.assetid: 9fca7285-f7f1-422d-8565-92bf0e0db60a
caps.latest.revision: 11
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
# IDebugMessageEvent2::GetMessage
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
  
```c#  
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
 [out] Returns a value from the [MESSAGETYPE](../extensibility/messagetype.md) enumeration that describes the type of the message.  
  
 `pbstrMessage`  
 [out] Returns the message.  
  
 `pdwType`  
 [out] Returns the type of the message, using the conventions of the Win32 `MessageBox` function. See the [AfxMessageBox](../Topic/AfxMessageBox.md) function for details.  
  
 `pbstrHelpFileName`  
 [in, out] Returns the help file name. May be a null (C++) or empty (C#) value if there is no help file.  
  
 `pdwHelpId`  
 [in, out] Returns the help identifier. May be 0 if there is no help associated with this message.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugMessageEvent2](../extensibility/idebugmessageevent2.md)   
 [MESSAGETYPE](../extensibility/messagetype.md)   
 [AfxMessageBox](../Topic/AfxMessageBox.md)