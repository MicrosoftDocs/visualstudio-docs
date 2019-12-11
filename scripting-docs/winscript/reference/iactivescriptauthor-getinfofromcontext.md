---
title: "IActiveScriptAuthor::GetInfoFromContext | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.GetInfoFromContext"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::GetInfoFromContext"
ms.assetid: 9891b095-6eb5-4473-87c0-c2e5cd2afc1a
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::GetInfoFromContext
Returns type information and anchor positions for a given character in a block of code. This provides information for member IntelliSense, global lists, and parameter tips.  
  
## Syntax  
  
```cpp
HRESULT GetInfoFromContext(  
   LPCOLESTR  pszCode,  
   ULONG      cchCode,  
   ULONG      ichCurrentPosition,  
   DWORD      dwListTypesRequested,  
   DWORD      *pdwListTypesProvided,  
   ULONG      *pichListAnchorPosition,  
   ULONG      *pichFuncAnchorPosition,  
   MEMBERID   *pmemid,  
   LONG       *piCurrentParameter,  
   IUnknown   **ppunk  
);  
```  
  
#### Parameters  
 `pszCode`  
 [in] The address of the code block string used to generate the information results.  
  
 `cchCode`  
 [in] The length of the code block.  
  
 `ichCurrentPosition`  
 [in] The character's position relative to the start of the block.  
  
 `dwListTypesRequested`  
 [in] The list types requested. Can be a combination of the following values:  
  
|Constant|Value|Description|  
|--------------|-----------|-----------------|  
|SCRIPT_CMPL_NOLIST|0x0000|No list.|  
|SCRIPT_CMPL_MEMBERLIST|0x0001|Member list.|  
|SCRIPT_CMPL_ENUMLIST|0x0002|Enum list.|  
|SCRIPT_CMPL_PARAMLIST|0x0004|Call method parameter list.|  
|SCRIPT_CMPL_GLOBALLIST|0x0008|Global list.|  
  
 The SCRIPT_CMPL_GLOBALLIST type is treated as a default completion item that can be combined by using the OR operator with other completion items. The script authoring engine first tries to populate type information for other completion list items. If that fails, the engine populates for SCRIPT_CMPL_GLOBALLIST.  
  
 `pdwListTypesProvided`  
 [out] The type of list provided.  
  
 `pichListAnchorPosition`  
 [out] The start index of the context that contains the current position. The start index is relative to the start of the block.  
  
 This is populated only when `dwListTypesRequested` includes SCRIPT_CMPL_MEMBERLIST, SCRIPT_CMPL_ENUMLIST, or SCRIPT_CMPL_GLOBALLIST. For other requested list types, the result is undefined.  
  
 `pichFuncAnchorPosition`  
 [out] The start index of the function call that contains the current position. The start index is relative to the start of the block.  
  
 This is populated only when the context that contains the current position is a function call, and when `dwListTypesRequested` includes SCRIPT_CMPL_PARAMLIST. Otherwise, the result is undefined.  
  
 `pmemid`  
 [out] The MEMBERID of the function, as defined by a type in the `IProvideMultipleClassInfo``ppunk` out parameter.  
  
 This is populated only when `dwListTypesRequested` includes SCRIPT_CMPL_PARAMLIST.  
  
 `piCurrentParameter`  
 [out] The index of the parameter that contains the current position. If the current position is on the function name, -1 is returned.  
  
 The `piCurrentParameter` value is populated only when `dwListTypesRequested` includes SCRIPT_CMPL_PARAMLIST.  
  
 `ppunk`  
 The type information, which is provided in the form of an `IProvideMultipleClassInfo` object.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IProvideMultipleClassInfo Interface](/dotnet/api/microsoft.visualstudio.ole.interop.iprovidemultipleclassinfo)   
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)