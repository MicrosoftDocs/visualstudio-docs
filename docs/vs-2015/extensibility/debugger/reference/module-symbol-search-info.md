---
title: "MODULE_SYMBOL_SEARCH_INFO | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "MODULE_SYMBOL_SEARCH_INFO"
helpviewer_keywords: 
  - "MODULE_SYMBOL_SEARCH_INFO structure"
ms.assetid: 432aff03-08a5-4c5a-b2d5-e212090fc70a
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# MODULE_SYMBOL_SEARCH_INFO
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Contains status information about symbol search paths that have been searched.  
  
## Syntax  
  
```cpp#  
typedef struct _tagSYMBOL_SEARCH_INFO  
{  
   SYMBOL_SEARCH_INFO_FIELDS dwValidFields;  
   BSTR                      bstrVerboseSearchInfo;  
} MODULE_SYMBOL_SEARCH_INFO;  
```  
  
```csharp  
public struct MODULE_SYMBOL_SEARCH_INFO {  
   public uint   dwValidFields;  
   public string bstrVerboseSearchInfo;  
}  
```  
  
#### Parameters  
 `dwValidFields`  
 A combination of flags from the [SYMBOL_SEARCH_INFO_FIELDS](../../../extensibility/debugger/reference/symbol-search-info-fields.md) enumeration specifying the kind of search information described in this structure.  
  
 `bstrVerboseSearchInfo`  
 Search path and results concatenated into a single string.  
  
## Remarks  
 This structure is returned from a call to the [GetSymbolInfo](../../../extensibility/debugger/reference/idebugmodule3-getsymbolinfo.md) method.  
  
 If the `bstrVerboseSearchInfo` field is not empty, then it contains a list of paths searched and the results of that search. The list is formatted with a path, followed by ellipses ("..."), followed by the result. If there is more than one path result pair, then each pair is separated by a "\r\n" (carriage-return/linefeed) pair. The pattern looks like this:  
  
 \<path>...\<result>\r\n\<path>...\<result>\r\n\<path>...\<result>  
  
 Note that the last entry does not have a \r\n sequence.  
  
 Here is a possible `bstrVerboseSearchInfo` string that has been sent to standard out.  
  
 `c:\symbols\user32.pdb... File not found.`  
  
 `c:\winnt\symbols\user32.pdb... Version does not match.`  
  
 `\\symbols\symbols\user32.dll\0a8sd0ad8ad\user32.pdb... Symbols loaded.`  
  
## Requirements  
 Header: msdbg.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [Structures and Unions](../../../extensibility/debugger/reference/structures-and-unions.md)   
 [GetSymbolInfo](../../../extensibility/debugger/reference/idebugmodule3-getsymbolinfo.md)
