---
title: "ASSEMBLYLOCRESOLUTION"
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
  - "ASSEMBLYLOCRESOLUTION"
helpviewer_keywords: 
  - "ASSEMBLYLOCRESOLUTION enumeration"
ms.assetid: 0bcfe85c-5f37-4a9d-bf2b-141acd96ad67
caps.latest.revision: 9
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
# ASSEMBLYLOCRESOLUTION
Specifies where an assembly is located.  
  
## Syntax  
  
```cpp#  
enum enum_ASSEMBLYLOCRESOLUTION {  
   ALR_NAME      = 0x0,  
   ALR_USERDIR   = 0x1,  
   ALR_SHAREDDIR = 0x2,  
   ALR_REMOTEDIR = 0x4,  
};  
typedef DWORD ASSEMBLYLOCRESOLUTION;  
```  
  
```c#  
public enum enum_ASSEMBLYLOCRESOLUTION {  
   ALR_NAME      = 0x0,  
   ALR_USERDIR   = 0x1,  
   ALR_SHAREDDIR = 0x2,  
   ALR_REMOTEDIR = 0x4,  
};  
```  
  
## Members  
 ALR_NAME  
 Assembly is located in the current namespace.  
  
 ALR_USERDIR  
 Assembly is located in a user directory.  
  
 ALR_SHAREDDIR  
 Assembly is located in shared directory.  
  
 ALR_REMOTEDIR  
 Assembly is located in a remote directory.  
  
## Remarks  
 These values are returned by the [ResolveAssemblyRef](../extensibility/ipropertyproxyeeside--resolveassemblyref.md) and [GetManagedViewerCreationData](../extensibility/ipropertyproxyeeside--getmanagedviewercreationdata.md) methods.  
  
 These values can be combined with the `OR` operation.  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Enumerations](../extensibility/enumerations--visual-studio-debugging-.md)   
 [ResolveAssemblyRef](../extensibility/ipropertyproxyeeside--resolveassemblyref.md)   
 [GetManagedViewerCreationData](../extensibility/ipropertyproxyeeside--getmanagedviewercreationdata.md)