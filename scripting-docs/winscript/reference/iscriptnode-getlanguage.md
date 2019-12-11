---
title: "IScriptNode::GetLanguage | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IScriptNode.GetLanguage"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IScriptNode::GetLanguage"
ms.assetid: 089715fd-6746-474e-94ed-2e57ee4bc0da
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IScriptNode::GetLanguage
Returns the scripting language that is used by the current script node.  
  
## Syntax  
  
```cpp
HRESULT GetLanguage(  
   BSTR               *pbstr  
);  
```  
  
#### Parameters  
 `pbstr`  
 [out] Returns "JScript" if the script node uses JScript, or "VBScript" if the script node uses Visual Basic Scripting Edition (VBScript).  
  
## Return Value  
 An `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
  
## Remarks  
  
## See also  
 [IScriptNode Interface](../../winscript/reference/iscriptnode-interface.md)