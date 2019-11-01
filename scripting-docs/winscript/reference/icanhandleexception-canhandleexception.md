---
title: "ICanHandleException::CanHandleException | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "ICanHandleException.CanHandleException"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "ICanHandleException::CanHandleException"
ms.assetid: 0fc703bf-9518-487e-af20-00e073b640f1
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ICanHandleException::CanHandleException
Determines if the caller of the script engine can handle a specified exception.  
  
## Syntax  
  
```cpp
HRESULT CanHandleException(  
   EXCEPINFO*  pExcepInfo,  
   VARIANT*    pvar  
);  
```  
  
#### Parameters  
 `pExcepInfo`  
 [in] Pointer to an `EXCEPINFO` structure containing the information that will be reported if no exception handler is found.  
  
 `pvar`  
 [in] A value associated with the exception, such as the value thrown by a `throw` statement. This parameter may be `NULL`.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The caller can handle the exception|  
|`E_FAIL`|The caller cannot handle the exception.|  
  
## Remarks  
 If a call to `IDispatchEx::InvokeEx`, or a similar method, results in an exception, the script engine checks for a caller in the script's caller chain that supports the `ICanHandleException` interface and indicates that it can handle the exception. If no caller can handle the exception, the script engine halts.  
  
## See also  
 [ICanHandleException Interface](../../winscript/reference/icanhandleexception-interface.md)   
 [IDispatchEx::InvokeEx](../../winscript/reference/idispatchex-invokeex.md)