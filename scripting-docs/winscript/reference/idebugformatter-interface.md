---
title: "IDebugFormatter Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugFormatter interface"
ms.assetid: 022142d4-c8e1-47ae-b771-3e24953293e5
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugFormatter Interface
Allows a language or IDE to customize the conversion between VARIANT values or VARTYPE types and strings.  
  
 In addition to the methods inherited from `IUnknown`, the `IDebugFormatter` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IDebugFormatter::GetStringForVariant](../../winscript/reference/idebugformatter-getstringforvariant.md)|Returns a string that represents the given VARIANT value.|  
|[IDebugFormatter::GetVariantForString](../../winscript/reference/idebugformatter-getvariantforstring.md)|Returns a VARIANT containing the given string.|  
|[IDebugFormatter::GetStringForVarType](../../winscript/reference/idebugformatter-getstringforvartype.md)|Returns a string that represents the given VARTYPE value.|