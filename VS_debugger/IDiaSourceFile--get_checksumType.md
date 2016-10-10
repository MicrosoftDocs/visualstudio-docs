---
title: "IDiaSourceFile::get_checksumType"
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
ms.assetid: 4c363e61-a6a9-409a-9cc0-d06eb2bee645
caps.latest.revision: 9
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
# IDiaSourceFile::get_checksumType
Retrieves the checksum type.  
  
## Syntax  
  
```cpp#  
HRESULT get_checksumType (   
   DWORD* pRetVal  
);  
```  
  
#### Parameters  
 `pRetVal`  
 [out] Returns the checksum type.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The checksum type is a value that can be mapped to a checksum algorithm. For example, the standard PDB file format can typically have one of the following values:  
  
|Checksum Type|CryptoAPI Label|Description|  
|-------------------|---------------------|-----------------|  
|0|<none\>|No checksum present.|  
|1|`CALG_MD5`|checksum generated with the MD5 hashing algorithm.|  
|2|`CALG_SHA1`|checksum generated with the SHA1 hashing algorithm.|  
  
 The `CryptoAPI` labels are from the `ALG_ID` enumeration. For more information on hashing algorithms, consult the `CryptoAPI` section of the Microsoft Windows SDK.  
  
 To obtain the actual checksum bytes for the source file, call the [IDiaSourceFile::get_checksum](../VS_debugger/IDiaSourceFile--get_checksum.md) method.  
  
## See Also  
 [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md)   
 [IDiaSourceFile::get_checksum](../VS_debugger/IDiaSourceFile--get_checksum.md)