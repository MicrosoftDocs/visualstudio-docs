---
title: "IDebugSyncOperation::InProgressAbort | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDebugSyncOperation.InProgressAbort"
apilocation: 
  - "jscript.dll"
helpviewer_keywords: 
  - "IDebugSyncOperation::InProgressAbort"
ms.assetid: bfd0889c-b627-4843-b1c6-b6b918f42d61
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugSyncOperation::InProgressAbort
Cancels an operation in progress on another thread.  
  
## Syntax  
  
```cpp
HRESULT InProgressAbort();  
```  
  
#### Parameters  
 This method takes no parameters.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_NOTIMPL`|The operation cannot be cancelled.|  
|`E_ABORT`|The operation could not be completed.|  
  
## Remarks  
 The Process Debug Manager calls this method from within the debugger thread to cancel an operation that is in progress in another thread.  
  
 If the `InProgressAbort` method cannot complete the operation, it returns `E_ABORT` as soon as possible. This method can return `E_NOTIMPL` if the operation cannot be cancelled.  
  
## See also  
 [IDebugSyncOperation Interface](../../winscript/reference/idebugsyncoperation-interface.md)