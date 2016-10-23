---
title: "IDiaEnumDebugStreamData::Next"
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
ms.assetid: 114171dd-38fd-4bd7-a702-8ff887ffc99b
caps.latest.revision: 7
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
# IDiaEnumDebugStreamData::Next
Retrieves a specified number of records in the enumerated sequence.  
  
## Syntax  
  
```cpp#  
HRESULT Next (   
   ULONG  celt,  
   DWORD  cbData,  
   DWORD* pcbData,  
   BYTE   data[],  
   ULONG* pceltFetched  
);  
```  
  
#### Parameters  
 celt  
 [in] The number of records to be retrieved.  
  
 cbData  
 [in] Size of the data buffer, in bytes.  
  
 pcbData  
 [out] Returns the number of bytes returned. If `data` is NULL, then `pcbData` contains the total number of bytes of data available for all requested records.  
  
 data[]  
 [out] A buffer that is to be filled with the debug stream record data.  
  
 pceltFetched  
 [in, out] Returns the number of records in `data`.  
  
## Return Value  
 If successful, returns `S_OK`. Returns `S_FALSE` if there are no more records. Otherwise, returns an error code.  
  
## See Also  
 [IDiaEnumDebugStreamData](../VS_debugger/IDiaEnumDebugStreamData.md)   
 [IDiaEnumDebugStreams::Next](../VS_debugger/IDiaEnumDebugStreams--Next.md)