---
title: "IDebugBinder3"
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
  - "IDebugBinder3"
helpviewer_keywords: 
  - "IDebugBinder3 interface"
ms.assetid: 92353a74-dc74-4f93-8762-61d6b220478c
caps.latest.revision: 12
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
# IDebugBinder3
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface provides access to types, aliases, and custom visualizer services.  
  
## Syntax  
  
```  
IDebugBinder3 : IDebugBinder  
```  
  
## Notes for Implementers  
 A debug engine implements this interface to support aliases, custom visualizer services, and access to object type information.  
  
## Notes for Callers  
 An [IDebugBinder](../extensibility/idebugbinder.md) interface obtains this interface by using [QueryInterface](../Topic/QueryInterface.md).  
  
## Methods in Vtable order  
 In addition to the methods provided by the [IDebugBinder](../extensibility/idebugbinder.md) interface, this interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[GetMemoryObject](../extensibility/idebugbinder3--getmemoryobject.md)|Retrieves a memory object representing the memory to which this object is bound.|  
|[GetExceptionObjectAndType](../extensibility/idebugbinder3--getexceptionobjectandtype.md)|Retrieves the exception associated with this object (if any),|  
|[FindAlias](../extensibility/idebugbinder3--findalias.md)|Retrieves an alias given its name,|  
|[GetAllAliases](../extensibility/idebugbinder3--getallaliases.md)|Retrieves an array of all aliases for this object,|  
|[GetTypeArgumentCount](../extensibility/idebugbinder3--gettypeargumentcount.md)|Gets the number of argument types associated with this object,|  
|[GetTypeArguments](../extensibility/idebugbinder3--gettypearguments.md)|Retrieves a list of argument types associated with this object,|  
|[GetEEService](../extensibility/idebugbinder3--geteeservice.md)|Gets an interface to a visualizer service,|  
|[GetMemoryContext64](../extensibility/idebugbinder3--getmemorycontext64.md)|Converts either an object location or a 64-bit memory address to a memory context.|  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Expression Evaluation Interfaces](../extensibility/expression-evaluation-interfaces.md)   
 [IDebugBinder](../extensibility/idebugbinder.md)