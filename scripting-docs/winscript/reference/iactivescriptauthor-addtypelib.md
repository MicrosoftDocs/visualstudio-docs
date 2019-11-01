---
title: "IActiveScriptAuthor::AddTypeLib | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IActiveScriptAuthor.AddTypeLib"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IActiveScriptAuthor::AddTypeLib"
ms.assetid: d6696547-3eb5-4f31-9c5c-60aa29b6f083
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor::AddTypeLib
Adds a type library to the namespace for the script.  
  
## Syntax  
  
```cpp
HRESULT AddTypeLib(  
   REFGUID   rguidTypeLib,  
   DWORD     dwMajor,  
   DWORD     dwMinor,  
   DWORD     dwFlags  
);  
```  
  
#### Parameters  
 `rguidTypeLib`  
 [in] The CLSID (class identifier) of the type library to be added.  
  
 `dwMajor`  
 [in] The major version number.  
  
 `dwMinor`  
 [in] The minor version number.  
  
 `dwFlags`  
 [in] Not used.  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
 This method calls `LoadTypeLib` to load the type library. Upon success, this method calls `IActiveScriptAuthor::AddNamedItem` to add type information.  
  
## See also  
 [IActiveScriptAuthor Interface](../../winscript/reference/iactivescriptauthor-interface.md)   
 [IActiveScriptAuthor::AddNamedItem](../../winscript/reference/iactivescriptauthor-addnameditem.md)   
 [LoadTypeLib](/previous-versions/windows/desktop/api/oleauto/nf-oleauto-loadtypelib)