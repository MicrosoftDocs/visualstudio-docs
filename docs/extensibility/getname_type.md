---
title: "GETNAME_TYPE"
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
  - "GETNAME_TYPE"
helpviewer_keywords: 
  - "GETNAME_TYPE enumeration"
ms.assetid: 2f9f1679-e9e8-4c9c-ac90-aa07bfe69914
caps.latest.revision: 10
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
# GETNAME_TYPE
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
  
```c#  
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
 These values are passed as parameters to the [GetName](../extensibility/idebugdocument2--getname.md), [GetName](../extensibility/idebugdocumentcontext2--getname.md), and [GetName](../extensibility/idebugprocess2--getname.md) methods to specify what kind of name to return.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [GetName](../extensibility/idebugdocument2--getname.md)   
 [GetName](../extensibility/idebugdocumentcontext2--getname.md)   
 [GetName](../extensibility/idebugprocess2--getname.md)