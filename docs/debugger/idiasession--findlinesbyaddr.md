---
title: "IDiaSession::findLinesByAddr"
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
  - "IDiaSession::findLinesByAddr method"
ms.assetid: 640403c0-14cf-403c-ad19-38b3bdc28ca8
caps.latest.revision: 8
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
# IDiaSession::findLinesByAddr
Retrieves the lines in a specified compiland that contain a specified address.  
  
## Syntax  
  
```cpp#  
HRESULT findLinesByAddr (   
   DWORD                 seg,  
   DWORD                 offset,  
   DWORD                 length,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `seg`  
 [in] Specifies the section component of the specific address.  
  
 `offset`  
 [in] Specifies the offset component of the specific address.  
  
 `length`  
 [in] Specifies the number of bytes of address range to cover with this query.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumLineNumbers](../debugger/idiaenumlinenumbers.md) object that contains a list of all the line numbers that cover the specified address range.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Example  
 This example shows a function that obtains all line numbers contained in a function using the function's address and length.  
  
```cpp#  
IDiaEnumLineNumbers* GetLineNumbersByAddr(IDiaSymbol *pFunc,  
                                          IDiaSession *pSession)  
{  
    IDiaEnumLineNumbers* pEnum = NULL;  
    DWORD                seg;  
    DWORD                offset;  
    ULONGLONG            length;  
  
    if (pFunc->get_addressSection ( &seg ) == S_OK &&  
        pFunc->get_addressOffset ( &offset ) == S_OK)  
    {  
        pFunc->get_length ( &length );  
        pSession->findLinesByAddr( seg, offset, static_cast<DWORD>( length ), &pEnum );  
    }  
    return(pEnum);  
}  
```  
  
## See Also  
 [IDiaEnumLineNumbers](../debugger/idiaenumlinenumbers.md)   
 [IDiaSession](../debugger/idiasession.md)   
 [IDiaSession::findLinesByVA](../debugger/idiasession--findlinesbyva.md)