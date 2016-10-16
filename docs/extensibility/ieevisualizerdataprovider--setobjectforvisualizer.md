---
title: "IEEVisualizerDataProvider::SetObjectForVisualizer"
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
  - "IEEVisualizerDataProvider::SetObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::SetObjectForVisualizer method"
ms.assetid: 40dad2be-57ff-4f74-9d82-c48039c125c4
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
# IEEVisualizerDataProvider::SetObjectForVisualizer
This method changes the object that the visualizer represents.  
  
## Syntax  
  
```cpp  
HRESULT SetObjectForVisualizer(  
   IDebugObject*  pNewObject,  
   BSTR*          error,  
   IDebugObject** pException  
);  
```  
  
```c#  
int SetObjectForVisualizer(  
   IDebugObject     pNewObject,  
   out string       error,  
   out IDebugObject pException  
);  
```  
  
#### Parameters  
 `pNewObject`  
 [in] The object to set.  
  
 `error`  
 [out] If there was an error setting the object, this string holds the error message.  
  
 `pException`  
 [out] If there was an error, this object holds the exception information.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 It is up to the implementer to determine how error information is returned. However, it is possible that some callers may only look to see if an exception object was returned to know there was an error, so this method should always return an exception object if there was an error. The error string should also be supplied in case the caller wants to make use of it.  
  
## See Also  
 [IEEVisualizerDataProvider](../extensibility/ieevisualizerdataprovider.md)   
 [IDebugObject](../extensibility/idebugobject.md)