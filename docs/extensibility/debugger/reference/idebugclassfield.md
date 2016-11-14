---
title: "IDebugClassField | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugClassField"
helpviewer_keywords: 
  - "IDebugClassField interface"
ms.assetid: 49358cbc-8973-4862-9dcc-79b1248e6712
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
# IDebugClassField
This interface represents a class as a type.  
  
## Syntax  
  
```  
IDebugClassField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface on the same object that implements the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface. This interface is a specialization that represents a class type.  
  
## Notes for Callers  
 A number of interfaces have methods that can return this interface including [IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md), [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md), and [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md). Also, you can use [QueryInterface](/visual-cpp/atl/queryinterface) to obtain this interface from the [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interface if the [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) method returns the flag `FIELD_TYPE_CLASS`.  
  
## Methods in Vtable Order  
 In addition to the methods on the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) and [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md) interfaces, this interface implements the following:  
  
|Method|Description|  
|------------|-----------------|  
|[EnumBaseClasses](../../../extensibility/debugger/reference/idebugclassfield-enumbaseclasses.md)|Creates an enumerator for the base classes of this class.|  
|[DoesInterfaceExist](../../../extensibility/debugger/reference/idebugclassfield-doesinterfaceexist.md)|Determines if a specific interface is defined in the class.|  
|[EnumNestedClasses](../../../extensibility/debugger/reference/idebugclassfield-enumnestedclasses.md)|Creates an enumerator for the nested classes of this class.|  
|[GetEnclosingClass](../../../extensibility/debugger/reference/idebugclassfield-getenclosingclass.md)|Gets the class that encloses this class.|  
|[EnumInterfacesImplemented](../../../extensibility/debugger/reference/idebugclassfield-enuminterfacesimplemented.md)|Creates an enumerator for the interfaces implemented by this class.|  
|[EnumConstructors](../../../extensibility/debugger/reference/idebugclassfield-enumconstructors.md)|Creates an enumerator for the constructors of this class.|  
|[GetDefaultIndexer](../../../extensibility/debugger/reference/idebugclassfield-getdefaultindexer.md)|Gets the name of the default indexer.|  
|[EnumNestedEnums](../../../extensibility/debugger/reference/idebugclassfield-enumnestedenums.md)|Creates an enumerator for the nested enumerators of this class.|  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)