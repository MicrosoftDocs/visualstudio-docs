---
title: "IDebugArrayObject::GetElement"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugArrayObject::GetElement"
helpviewer_keywords: 
  - "IDebugArrayObject::GetElement method"
ms.assetid: 08b44341-7bf1-4a8c-8b79-98ae5785b195
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugArrayObject::GetElement
Gets an element of the array.  
  
## Syntax  
  
```cpp#  
HRESULT GetElement(   
   DWORD          dwIndex,  
   IDebugObject** ppElement  
);  
```  
  
```c#  
int GetElement(  
   [In] uint dwIndex,   
   out IDebugObject ppElement  
);  
```  
  
#### Parameters  
 `dwIndex`  
 [in] The element index.  
  
 `ppElement`  
 [out] Returns an [IDebugObject](../extensibility/idebugobject.md) interface that represents the element.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 This method sees all of the elements of an array object as a one-dimensional array, even if the array object is multi-dimensional. For example, given the array `myarray[3][2][6]` and a `dwIndex` parameter of 20, this method would return the element from `myarray[1][1][2]`, and a `dwIndex` parameter of 21 would return the element from `myarray[1][1][3]`. Use the [GetCount](../extensibility/idebugarrayobject--getcount.md) method to determine the total number of elements in the array.  
  
## See Also  
 [IDebugArrayObject](../extensibility/idebugarrayobject.md)