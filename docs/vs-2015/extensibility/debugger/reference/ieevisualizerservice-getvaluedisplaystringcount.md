---
title: "IEEVisualizerService::GetValueDisplayStringCount | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IEEVisualizerService::GetValueDisplayStringCount"
  - "GetValueDisplayStringCount"
ms.assetid: d683a833-fbfb-4042-84df-6905124a268a
caps.latest.revision: 11
ms.author: "gregvanl"
manager: "ghogen"
---
# IEEVisualizerService::GetValueDisplayStringCount
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves the number of value strings to display for the specified property or field.  
  
## Syntax  
  
```cpp#  
HRESULT GetValueDisplayStringCount (  
   DWORD         displayKind,   
   IDebugField * propertyOrField,   
   ULONG *       pcelt  
);  
```  
  
```csharp  
int GetValueDisplayStringCount (  
   uint        displayKind,   
   IDebugField propertyOrField,   
   out ulong   pcelt  
);  
```  
  
#### Parameters  
 `displayKind`  
 [in] Value from the [DisplayKind](../../../extensibility/debugger/reference/displaykind.md) enumeration.  
  
 `propertyOrField`  
 [in] An [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface that represents a property or field.  
  
 `pcelt`  
 [out] Returns the number of value strings to display.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IEEVisualizerService](../../../extensibility/debugger/reference/ieevisualizerservice.md)

