---
title: "IDebugGenericFieldDefinition"
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
  - "IDebugGenericFieldDefinition interface"
ms.assetid: b5a853b7-221e-4d62-8948-07423089d75d
caps.latest.revision: 7
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
# IDebugGenericFieldDefinition
Represents the definition of a field for a managed code generic type.  
  
## Syntax  
  
```  
IDebugGenericFieldDefinition : IUnknown  
```  
  
## Methods  
 This interface implements the following methods:  
  
|Method|Description|  
|------------|-----------------|  
|[ConstructInstantiation](../extensibility/idebuggenericfielddefinition--constructinstantiation.md)|Constructs a field instance given an array of type arguments.|  
|[GetFormalTypeParams](../extensibility/idebuggenericfielddefinition--getformaltypeparams.md)|Retrieves the type parameters given the number of parameters.|  
|[TypeParamCount](../extensibility/idebuggenericfielddefinition--typeparamcount.md)|Retrieves the number of type parameters associated with the generic field.|  
  
## Requirements  
 Header: Sh.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll