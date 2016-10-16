---
title: "IDebugPortPicker"
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
  - "IDebugPortPicker interface"
ms.assetid: 8b7f6685-a3c5-4355-b706-c1b574f6ff84
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
# IDebugPortPicker
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
|[DisplayPortPicker](../extensibility/idebugportpicker--displayportpicker.md)|Displays the specified dialog box that allows the user to select a port.|  
|[SetSite](../extensibility/idebugportpicker--setsite.md)|Sets the service provider.|  
  
## Requirements  
 Header: Msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll