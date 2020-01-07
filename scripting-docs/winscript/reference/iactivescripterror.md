---
title: "IActiveScriptError | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptError interface"
ms.assetid: c8e0288d-38ff-4145-a7e3-f8cdfb72eefe
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptError
An object implementing this interface is passed to the [IActiveScriptSite::OnScriptError](../../winscript/reference/iactivescriptsite-onscripterror.md) method whenever the scripting engine encounters an unhandled error. The host then calls methods on this object to obtain information about the error that occurred.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptError::GetExceptionInfo](../../winscript/reference/iactivescripterror-getexceptioninfo.md)|Retrieves information about an error.|  
|[IActiveScriptError::GetSourcePosition](../../winscript/reference/iactivescripterror-getsourceposition.md)|Retrieves the location in the source code where an error occurred.|  
|[IActiveScriptError::GetSourceLineText](../../winscript/reference/iactivescripterror-getsourcelinetext.md)|Retrieves the line in the source file where an error occurred.|  
  
## See also  
 [Active Script Interfaces](../../winscript/reference/active-script-interfaces.md)