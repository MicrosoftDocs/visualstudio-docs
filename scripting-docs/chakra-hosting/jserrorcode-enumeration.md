---
title: "JsErrorCode Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "jsrt/JsErrorCode"
helpviewer_keywords: 
  - "JsErrorCode enumeration"
ms.assetid: 4902f3f3-47a5-4e74-9c29-f96eeecbcda9
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# JsErrorCode Enumeration
An error code returned from a Chakra hosting API.  
  
## Syntax  
  
```  
enum JsErrorCode : unsigned int;  
```  
  
## Members  
  
### Values  
  
|Name|Description|  
|----------|-----------------|  
|`JsErrorAlreadyDebuggingContext`|The context cannot be put into a debug state because it is already in a debug state.|  
|`JsErrorAlreadyProfilingContext`|The context cannot start profiling because it is already profiling.|  
|`JsErrorArgumentNotObject`|A hosting API that operates on object values was called with a non-object value.|  
|`JsErrorBadSerializedScript`|A bad serialized script was used, or the serialized script was serialized by a different version of the Chakra engine.|  
|`JsErrorCannotDisableExecution`|Runtime does not support reliable script interruption.|  
|`JsErrorCannotSerializeDebugScript`|Scripts cannot be serialized in debug contexts.|  
|`JsErrorCategoryEngine`|Category of errors that relates to errors occurring within the engine itself.|  
|`JsErrorCategoryFatal`|Category of errors that are fatal and signify failure of the engine.|  
|`JsErrorCategoryScript`|Category of errors that relates to errors in a script.|  
|`JsErrorCategoryUsage`|Category of errors that relates to incorrect usage of the API itself.|  
|`JsErrorFatal`|A fatal error in the engine has occurred.|  
|`JsErrorHeapEnumInProgress`|A heap enumeration is currently underway in the script context.|  
|`JsErrorIdleNotEnabled`|Idle notification given when the host did not enable idle processing.|  
|`JsErrorInDisabledState`|The runtime is in a disabled state.|  
|`JsErrorInExceptionState`|The engine is in an exception state and no APIs can be called until the exception is cleared.|  
|`JsErrorInObjectBeforeCollectCallback`|The operation is not supported in an object before collect callback.<br /><br /> This enumeration value is supported only in Edge mode.|  
|`JsErrorInProfileCallback`|A script context is in the middle of a profile callback.|  
|`JsErrorInThreadServiceCallback`|A thread service callback is currently underway.|  
|`JsErrorInvalidArgument`|An argument to a hosting API was invalid.|  
|`JsErrorNoCurrentContext`|The hosting API requires that a context be current, but there is no current context.|  
|`JsErrorNotImplemented`|A hosting API is not yet implemented.|  
|`JsErrorNullArgument`|An argument to a hosting API was null in a context where null is not allowed.|  
|`JsErrorObjectNotInspectable`|Object cannot be unwrapped to `IInspectable` pointer.<br /><br /> This enumeration value is supported only in Edge mode.|  
|`JsErrorOutOfMemory`|The Chakra engine has run out of memory.|  
|`JsErrorPropertyNotSymbol`|A hosting API that operates on symbol property ids but was called with a non-symbol property id. The error code is returned by `JsGetSymbolFromPropertyId` if the function is called with non-symbol property id.<br /><br /> This enumeration value is supported only in Edge mode.|  
|`JsErrorPropertyNotString`|A hosting API that operates on string property ids but was called with a non-string property id. The error code is returned by existing `JsGetPropertyNamefromId` if the function is called with non-string property id.<br /><br /> This enumeration value is supported only in Edge mode.|  
|`JsErrorRuntimeInUse`|A runtime that is still in use cannot be disposed.|  
|`JsErrorScriptCompile`|JavaScript failed to compile.|  
|`JsErrorScriptEvalDisabled`|A script was terminated because it tried to use `eval` or `function` and eval was disabled.|  
|`JsErrorScriptException`|A JavaScript exception occurred while running a script.|  
|`JsErrorScriptTerminated`|A script was terminated due to a request to suspend a runtime.|  
|`JsErrorWrongRuntime`|A hosting API was called with object created on different JavaScript runtime.|  
|`JsErrorWrongThread`|A hosting API was called on the wrong thread.|  
|`JsNoError`|Success error code.|  
  
## Requirements  
 **Header:** jsrt.h  
  
## See Also  
 [Reference (JavaScript Runtime)](../chakra-hosting/reference-javascript-runtime.md)