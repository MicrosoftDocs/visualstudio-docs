---
title: "IDiaAddressMap::set_imageHeaders"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaAddressMap::set_imageHeaders method"
ms.assetid: a46b9d0e-43e6-433f-b2c7-aa203981e4e4
caps.latest.revision: 7
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# IDiaAddressMap::set_imageHeaders
Sets image headers to enable relative virtual address translation.  
  
## Syntax  
  
```cpp#  
HRESULT set_imageHeaders (   
   DWORD cbData,  
   BYTE  data[],  
   BOOL  originalHeaders  
);  
```  
  
#### Parameters  
 cbData  
 [in] Number of bytes of header data. Must be `n*sizeof(IMAGE_SECTION_HEADER)` where `n` is the number of section headers in the executable.  
  
 data[]  
 [in] An array of  `IMAGE_SECTION_HEADER` structures to be used as the image headers.  
  
 originalHeaders  
 [in] Set to `FALSE` if the image headers are from the new image, `TRUE` if they reflect the original image prior to an upgrade. Typically, this would be set to `TRUE` only in combination with calls to the [IDiaAddressMap::set_addressMap](../debugger/idiaaddressmap--set_addressmap.md) method.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The `IMAGE_SECTION_HEADER` structure is declared in Winnt.h and represents the image section header format of the executable.  
  
 Relative virtual address calculations depend upon the `IMAGE_SECTION_HEADER` values. Usually, the DIA retrieves these from the program database (.pdb) file. If these values are missing, the DIA is unable to calculate relative virtual addresses and the [IDiaAddressMap::get_relativeVirtualAddressEnabled](../debugger/idiaaddressmap--get_relativevirtualaddressenabled.md) method returns `FALSE`. The client must then call the [IDiaAddressMap::put_relativeVirtualAddressEnabled](../debugger/idiaaddressmap--put_relativevirtualaddressenabled.md) method to enable the relative virtual address calculations after providing the missing image headers from the image itself.  
  
## See Also  
 [IDiaAddressMap](../debugger/idiaaddressmap.md)   
 [IDiaAddressMap::set_addressMap](../debugger/idiaaddressmap--set_addressmap.md)   
 [IDiaAddressMap::get_relativeVirtualAddressEnabled](../debugger/idiaaddressmap--get_relativevirtualaddressenabled.md)   
 [IDiaAddressMap::put_relativeVirtualAddressEnabled](../debugger/idiaaddressmap--put_relativevirtualaddressenabled.md)