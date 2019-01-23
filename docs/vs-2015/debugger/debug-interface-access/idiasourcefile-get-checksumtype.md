---
title: "IDiaSourceFile::get_checksumType | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaSourceFile::get_checksumType method"
ms.assetid: 4c363e61-a6a9-409a-9cc0-d06eb2bee645
caps.latest.revision: 12
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# IDiaSourceFile::get_checksumType
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

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
|0|\<none>|No checksum present.|  
|1|`CALG_MD5`|checksum generated with the MD5 hashing algorithm.|  
|2|`CALG_SHA1`|checksum generated with the SHA1 hashing algorithm.|  
  
 The `CryptoAPI` labels are from the `ALG_ID` enumeration. For more information on hashing algorithms, consult the `CryptoAPI` section of the Microsoft [!INCLUDE[winsdkshort](../../includes/winsdkshort-md.md)].  
  
 To obtain the actual checksum bytes for the source file, call the [IDiaSourceFile::get_checksum](../../debugger/debug-interface-access/idiasourcefile-get-checksum.md) method.  
  
## See Also  
 [IDiaSourceFile](../../debugger/debug-interface-access/idiasourcefile.md)   
 [IDiaSourceFile::get_checksum](../../debugger/debug-interface-access/idiasourcefile-get-checksum.md)
