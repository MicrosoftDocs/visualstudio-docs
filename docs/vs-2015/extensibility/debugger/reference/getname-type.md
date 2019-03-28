---
title: "GETNAME_TYPE | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "GETNAME_TYPE"
helpviewer_keywords: 
  - "GETNAME_TYPE enumeration"
ms.assetid: 2f9f1679-e9e8-4c9c-ac90-aa07bfe69914
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# GETNAME_TYPE
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Specifies the name type of files to retrieve.  
  
## Syntax  
  
```cpp#  
enum enum_GETNAME_TYPE {   
   GN_NAME         = 0,  
   GN_FILENAME     = 1,  
   GN_BASENAME     = 2,  
   GN_MONIKERNAME  = 3,  
   GN_URL          = 4,  
   GN_TITLE        = 5,  
   GN_STARTPAGEURL = 6  
};  
typedef DWORD GETNAME_TYPE;  
```  
  
```csharp  
public enum enum_GETNAME_TYPE {   
   GN_NAME         = 0,  
   GN_FILENAME     = 1,  
   GN_BASENAME     = 2,  
   GN_MONIKERNAME  = 3,  
   GN_URL          = 4,  
   GN_TITLE        = 5,  
   GN_STARTPAGEURL = 6  
};  
```  
  
## Members  
 GN_NAME  
 Specifies a friendly name of the document or context.  
  
 GN_FILENAME  
 Specifies the full path of the document or context.  
  
 GN_BASENAME  
 Specifies a base file name instead of a full path of the document or context.  
  
 GN_MONIKERNAME  
 Specifies a unique name of the document or context in the form of a moniker.  
  
 GN_URL  
 Specifies a URL name of the document or context.  
  
 GN_TITLE  
 Specifies a title of the document, if one exists.  
  
 GN_STARTPAGEURL  
 Gets the starting page URL for processes.  
  
## Remarks  
 These values are passed as parameters to the [GetName](../../../extensibility/debugger/reference/idebugdocument2-getname.md), [GetName](../../../extensibility/debugger/reference/idebugdocumentcontext2-getname.md), and [GetName](../../../extensibility/debugger/reference/idebugprocess2-getname.md) methods to specify what kind of name to return.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)   
 [GetName](../../../extensibility/debugger/reference/idebugdocument2-getname.md)   
 [GetName](../../../extensibility/debugger/reference/idebugdocumentcontext2-getname.md)   
 [GetName](../../../extensibility/debugger/reference/idebugprocess2-getname.md)
