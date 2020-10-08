---
title: "Constants (Debug Interface Access SDK) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: reference
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "constants, DIA SDK"
  - "DIA SDK, constants"
ms.assetid: aca4ec77-bc08-4cdd-a6ce-8d4a28ea5ea3
caps.latest.revision: 10
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Constants (Debug Interface Access SDK)
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

These string constants can be used to identify various sections of a program debug database (PDB) file through the DIA SDK.  
  
## Constants  
 The following are declared as C/C++ macros.  
  
|Macro|Value|  
|-----------|-----------|  
|`DiaTable_Symbols`|L"Symbols"|  
|`DiaTable_Sections`|L"Sections"|  
|`DiaTable_SrcFiles`|L"SourceFiles"|  
|`DiaTable_LineNums`|L"LineNumbers"|  
|`DiaTable_SegMap`|L"SegmentMap"|  
|`DiaTable_Dbg`|L"Dbg"|  
|`DiaTable_InjSrc`|L"InjectedSource"|  
|`DiaTable_FrameData`|L"FrameData"|  
  
## Example  
 Here is an example using one of these symbols:  
  
```cpp#  
HRESULT GetSymbolTable(IDiaEnumTables *pEnumTables, IDiaTable **pTable)  
{  
    HRESULT hr;  
    VARIANT var;  
    var.vt      = VT_BSTR;  
    var.bstrVal = SysAllocString( DiaTable_Symbols );  
    hr = pEnumTables->Item( var, pTable );  
    return(hr);  
}  
```  
  
## Requirements  
 Header: dia2.h  
  
## See Also  
 [Reference](../../debugger/debug-interface-access/debug-interface-access-sdk-reference.md)   
 [Enumerations and Structures](../../debugger/debug-interface-access/enumerations-and-structures.md)   
 [Interfaces (Debug Interface Access SDK)](../../debugger/debug-interface-access/interfaces-debug-interface-access-sdk.md)   
 [IDiaEnumTables::Item](../../debugger/debug-interface-access/idiaenumtables-item.md)
