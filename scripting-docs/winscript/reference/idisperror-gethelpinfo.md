---
title: "IDispError::GetHelpInfo | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname: 
  - "IDispError.GetHelpInfo"
apilocation: 
  - "scrobj.dll"
helpviewer_keywords: 
  - "IDispError::GetHelpInfo"
ms.assetid: a146df13-eda4-4e56-8bf0-cf9886a2150f
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDispError::GetHelpInfo
Returns the path of the Help file and the context ID of the topic that explains the error, if possible.  
  
## Syntax  
  
```cpp
HRESULT GetHelpInfo(  
   BSTR*  pbstrFileName,  
   DWORD*  pdwContext  
);  
```  
  
#### Parameters  
 `pbstrFileName`  
 [out] String containing the fully qualified path of the Help file. If there is no Help file or an error occurs, the return value is NULL.  
  
 `pdwContext`  
 [out] The Help context ID for the error. If there is no Help file (if `pbstrFileName` is NULL), this parameter has no meaning.  
  
## Return Value  
 The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.  
  
|Value|Description|  
|-----------|-----------------|  
|`S_OK`|The method succeeded.|  
|`E_FAIL`|A provider-specific error occurred.|  
|`E_INVALIDARG`|`pbstrFileName` or `pdwContext` was NULL.|  
|`E_OUTOFMEMORY`|The provider was unable to allocate sufficient memory in which to return the Help file path.|  
  
## Remarks  
 This method returns the path of the Help file and the context ID of the topic that explains the error, if possible.  
  
> [!NOTE]
> This method is not implemented.  
  
## See also  
 [IDispError Interface](../../winscript/reference/idisperror-interface.md)