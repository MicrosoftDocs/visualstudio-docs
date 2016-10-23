---
title: "IDiaSession::findInlineeLinesByLinenum"
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
ms.assetid: cf32ae7c-a0c8-4800-bc8f-d64fdd15fb06
caps.latest.revision: 3
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
# IDiaSession::findInlineeLinesByLinenum
Retrieves an enumeration that allows a client to iterate through the line number information of all functions that are inlined, directly or indirectly, in the specified source file and line number.  
  
## Syntax  
  
```cpp#  
HRESULT findInlineeLinesByVA (   
   IDiaSymbol*           compiland,  
   IDiaSourceFile*       file,  
   DWORD                 linenum,  
   DWORD                 column,  
   IDiaEnumLineNumbers** ppResult  
);  
```  
  
#### Parameters  
 `compiland`  
 [in] An [IDiaSymbol](../VS_debugger/IDiaSymbol.md) object that represents the compiland in which to search for the line numbers. This parameter cannot be `NULL`.  
  
 `file`  
 [in] An [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md) object that represents the source file in which to search. This parameter cannot be `NULL`.  
  
 `linenum`  
 [in] Specifies a one-based line number.  
  
> [!NOTE]
>  You cannot use zero to specify all lines (use the [IDiaSession::findLines](../VS_debugger/IDiaSession--findLines.md) method to find all lines).  
  
 `column`  
 [in] Specifies the column number. Use zero to specify all columns. A column is a byte offset into a line.  
  
 `ppResult`  
 [out] Returns an [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md) object that contains a list of the line numbers that were retrieved.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaSession](../VS_debugger/IDiaSession.md)   
 [IDiaSourceFile](../VS_debugger/IDiaSourceFile.md)   
 [IDiaSymbol](../VS_debugger/IDiaSymbol.md)   
 [SymTagEnum Enumeration](../VS_debugger/SymTagEnum.md)   
 [IDiaEnumLineNumbers](../VS_debugger/IDiaEnumLineNumbers.md)