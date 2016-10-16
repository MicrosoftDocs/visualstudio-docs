---
title: "IDebugEnumField"
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
  - "IDebugEnumField"
helpviewer_keywords: 
  - "IDebugEnumField interface"
ms.assetid: 42f685bf-0f39-47f4-98b0-6022efe2bf97
caps.latest.revision: 8
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
# IDebugEnumField
This interface represents an enumeration type.  
  
## Syntax  
  
```  
IDebugEnumField : IDebugContainerField  
```  
  
## Notes for Implementers  
 A symbol provider implements this interface to represent an enumeration.  
  
## Notes for Callers  
 Use [QueryInterface](../Topic/QueryInterface.md) to obtain this interface from the [IDebugField](../extensibility/idebugfield.md) interface if [GetKind](../extensibility/idebugfield--getkind.md) returns `FIELD_TYPE_ENUM`.  
  
## Methods in VTable order  
 In addition to the methods on the `IDebugField` and `IDebugContainerField` interfaces, this interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[GetUnderlyingSymbol](../extensibility/idebugenumfield--getunderlyingsymbol.md)|Returns an [IDebugField](../extensibility/idebugfield.md) describing the name for this enumeration type.|  
|[GetStringFromValue](../extensibility/idebugenumfield--getstringfromvalue.md)|Returns the name of the enumeration constant associated with the given value.|  
|[GetValueFromString](../extensibility/idebugenumfield--getvaluefromstring.md)|Returns the value associated with the given enumeration constant name|  
|[GetValueFromStringCaseInsensitive](../extensibility/idebugenumfield--getvaluefromstringcaseinsensitive.md)|Returns the value associated with the given enumeration constant name but ignoring case.|  
  
## Remarks  
 It is the underlying symbol that is actually bound to a location with [Bind](../extensibility/idebugbinder--bind.md).  
  
## Requirements  
 Header: sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Symbol Provider Interfaces](../extensibility/symbol-provider-interfaces.md)   
 [IDebugContainerField](../extensibility/idebugcontainerfield.md)   
 [IDebugField](../extensibility/idebugfield.md)   
 [Bind](../extensibility/idebugbinder--bind.md)