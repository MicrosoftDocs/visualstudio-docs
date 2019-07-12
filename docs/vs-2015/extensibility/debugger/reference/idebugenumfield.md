---
title: "IDebugEnumField | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugEnumField"
helpviewer_keywords: 
  - "IDebugEnumField interface"
ms.assetid: 42f685bf-0f39-47f4-98b0-6022efe2bf97
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugEnumField
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

This interface represents an enumeration type.  
  
## Syntax  
  
```  
IDebugEnumField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface to represent an enumeration.  
  
## Notes for Callers  
 Use [QueryInterface](https://msdn.microsoft.com/library/62fce95e-aafa-4187-b50b-e6611b74c3b3) to obtain this interface from the [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface if [GetKind](../../../extensibility/debugger/reference/idebugfield-getkind.md) returns `FIELD_TYPE_ENUM`.  
  
## Methods in VTable order  
 In addition to the methods on the `IDebugField` and `IDebugContainerField` interfaces, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetUnderlyingSymbol](../../../extensibility/debugger/reference/idebugenumfield-getunderlyingsymbol.md)|Returns an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) describing the name for this enumeration type.|  
|[GetStringFromValue](../../../extensibility/debugger/reference/idebugenumfield-getstringfromvalue.md)|Returns the name of the enumeration constant associated with the given value.|  
|[GetValueFromString](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstring.md)|Returns the value associated with the given enumeration constant name|  
|[GetValueFromStringCaseInsensitive](../../../extensibility/debugger/reference/idebugenumfield-getvaluefromstringcaseinsensitive.md)|Returns the value associated with the given enumeration constant name but ignoring case.|  
  
## Remarks  
 It is the underlying symbol that is actually bound to a location with [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../../../extensibility/debugger/reference/symbol-provider-interfaces.md)   
 [IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)   
 [IDebugField](../../../extensibility/debugger/reference/idebugfield.md)   
 [Bind](../../../extensibility/debugger/reference/idebugbinder-bind.md)
