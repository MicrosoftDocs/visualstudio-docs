---
title: "IDebugTypeFieldBuilder2"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "IDebugTypeFieldBuilder2 interface"
ms.assetid: 23911c5b-2bbf-4734-9976-87a0bd6ea36c
caps.latest.revision: 6
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
# IDebugTypeFieldBuilder2
Extends the **IDebugTypeFieldBuilder** to be able to create array types.  
  
## Syntax  
  
```  
IDebugTypeFieldBuilder2 : IDebugTypeFieldBuilder  
```  
  
## Notes for Callers  
 This interface can be obtained from the symbol provider.  
  
## Methods  
 In addition to the methods on the [IDebugTypeFieldBuilder](../extensibility/idebugtypefieldbuilder.md) interface, this interface implements the following method:  
  
|Method|Description|  
|------------|-----------------|  
|[CreateArrayOfType](../extensibility/idebugtypefieldbuilder2--createarrayoftype.md)|Creates an array of the specified type and size.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll