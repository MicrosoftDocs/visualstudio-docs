---
title: "IDebugPortPicker | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugPortPicker interface"
ms.assetid: 8b7f6685-a3c5-4355-b706-c1b574f6ff84
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# IDebugPortPicker
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Represents a customized UI for selecting the port.  
  
## Syntax  
  
```  
IDebugPortPicker : IUnknown  
```  
  
## Notes for Implementers  
 This interface is implemented by port suppliers. A port supplier defines their port picker by exposing it as a CLSID and pointing the `metricPortPickerCLSID` metric at the exposed CLSID.  
  
## Methods  
 The following table shows the methods of `IDebugPortPicker`.  
  
|Method|Description|  
|------------|-----------------|  
|[DisplayPortPicker](../../../extensibility/debugger/reference/idebugportpicker-displayportpicker.md)|Displays the specified dialog box that allows the user to select a port.|  
|[SetSite](../../../extensibility/debugger/reference/idebugportpicker-setsite.md)|Sets the service provider.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
