---
title: "IEEVisualizerDataProvider::CanSetObjectForVisualizer | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IEEVisualizerDataProvider::CanSetObjectForVisualizer"
helpviewer_keywords: 
  - "IEEVisualizerDataProvider::CanSetObjectForVisualizer method"
ms.assetid: 70fd3c6f-2f82-43a3-993b-c1dc8aa080bf
caps.latest.revision: 10
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
# IEEVisualizerDataProvider::CanSetObjectForVisualizer
This method determines whether the visualizer can have the data object it represents updated.  
  
## Syntax  
  
```cpp  
HRESULT CanSetObjectForVisualizer(  
   BOOL* b  
);  
```  
  
```c#  
int CanSetObjectForVisualizer(  
   out int b  
);  
```  
  
#### Parameters  
 `b`  
 [out] Nonzero (`TRUE`) if the object on the visualizer can be updated, zero (`FALSE`) if it cannot.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 An object might not be changeable if it is bound to read-only memory, for example.  
  
## See Also  
 [IEEVisualizerDataProvider](../../../extensibility/debugger/reference/ieevisualizerdataprovider.md)