---
title: "IDiaAddressMap"
ms.custom: na
ms.date: 10/03/2016
ms.devlang: 
  - C++
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e6467529-508c-4328-85d7-89444ae4d1c1
caps.latest.revision: 10
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# IDiaAddressMap
Provides control over how the DIA SDK computes virtual and relative virtual addresses for debug objects.  
  
## Syntax  
  
```  
IDiaAddressMap : IUnknown  
```  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDiaAddressMap`.  
  
|Method|Description|  
|------------|-----------------|  
|[IDiaAddressMap::get_addressMapEnabled](../VS_debugger/IDiaAddressMap--get_addressMapEnabled.md)|Indicates whether an address map has been established for a particular session.|  
|[IDiaAddressMap::put_addressMapEnabled](../VS_debugger/IDiaAddressMap--put_addressMapEnabled.md)|Specifies whether the address map should be used to translate symbol addresses.|  
|[IDiaAddressMap::get_relativeVirtualAddressEnabled](../VS_debugger/IDiaAddressMap--get_relativeVirtualAddressEnabled.md)|Indicates whether the calculation and use of relative virtual addresses is enabled.|  
|[IDiaAddressMap::put_relativeVirtualAddressEnabled](../VS_debugger/IDiaAddressMap--put_relativeVirtualAddressEnabled.md)|Allows the client to enable or disable the calculation of relative virtual addresses.|  
|[IDiaAddressMap::get_imageAlign](../VS_debugger/IDiaAddressMap--get_imageAlign.md)|Retrieves the current image alignment.|  
|[IDiaAddressMap::put_imageAlign](../VS_debugger/IDiaAddressMap--put_imageAlign.md)|Sets the image alignment.|  
|[IDiaAddressMap::set_imageHeaders](../VS_debugger/IDiaAddressMap--set_imageHeaders.md)|Sets image headers to enable the translation of relative virtual addresses.|  
|[IDiaAddressMap::set_addressMap](../VS_debugger/IDiaAddressMap--set_addressMap.md)|Provides an address map to support image layout translations.|  
  
## Remarks  
 The control provided by this interface is encapsulated in two sets of data you supply: image headers and address maps. Most clients use the [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md) method to find the proper debug information for an image and the method can typically discover all of the necessary headers and maps data itself. However some clients implement specialized processing and searching for data. Such clients use the methods of the `IDiaAddressMap` interface to provide the DIA SDK with the search results.  
  
## Notes for Callers  
 This interface is available from the DIA session object. The client calls the `QueryInterface` method on DIA session object interface, usually [IDiaSession](../VS_debugger/IDiaSession.md), to retrieve the `IDiaAddressMap` interface.  
  
## Requirements  
 Header: Dia2.h  
  
 Library: diaguids.lib  
  
 DLL: msdia80.dll  
  
## See Also  
 [Interfaces (Debug Interface Access SDK)](../VS_debugger/Interfaces--Debug-Interface-Access-SDK-.md)   
 [IDiaDataSource::loadDataForExe](../VS_debugger/IDiaDataSource--loadDataForExe.md)   
 [IDiaSession](../VS_debugger/IDiaSession.md)