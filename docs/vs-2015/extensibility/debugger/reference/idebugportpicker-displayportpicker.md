---
title: "IDebugPortPicker::DisplayPortPicker | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "DisplayPortPicker"
  - "IDebugPortPicker::DisplayPortPicker"
ms.assetid: 08511ef5-be64-4069-b169-a569cc94bc64
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugPortPicker::DisplayPortPicker
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Displays the specified dialog box that allows the user to select a port.  
  
## Syntax  
  
```cpp#  
HRESULT DisplayPortPicker(  
   HWND hwndParentDialog,  
   BSTR* pbstrPortId  
);  
```  
  
```csharp  
public int DisplayPortPicker(  
   int hwndParentDialog,  
   out string pbstrPortId  
);  
```  
  
#### Parameters  
 `hwndParentDialog`  
 [in] Handle for the parent dialog box.  
  
 `pbstrPortId`  
 [out] Port identifier string.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code. A return value of `S_FALSE` (or a return value of `S_OK` with the `BSTR` set to `NULL`) indicates that the user  clicked **Cancel**.  
  
## See Also  
 [IDebugPortPicker](../../../extensibility/debugger/reference/idebugportpicker.md)
