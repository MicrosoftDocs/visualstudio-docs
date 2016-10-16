---
title: "IEEVisualizerServiceProvider::CreateVisualizerService"
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
  - "IEEVisualizerServiceProvider::CreateVisualizerService"
helpviewer_keywords: 
  - "IEEVisualizerServiceProvider::CreateVisualizerService method"
ms.assetid: f366f7c9-358d-46c8-993f-32ff86539833
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
# IEEVisualizerServiceProvider::CreateVisualizerService
This method creates a visualizer service.  
  
## Syntax  
  
```cpp  
HRESULT CreateVisualizerService(  
   IDebugBinder*              binder,  
   IDebugSymbolProvider*      pSymProv,  
   IDebugAddress*             pAddress,  
   IEEVisualizerDataProvider* dataProvider,  
   IEEVisualizerService**     ppService  
);  
```  
  
```c#  
int CreateVisualizerService(  
   IDebugBinder binder,  
   IDebugSymbolProvider      pSymProv,  
   IDebugAddress             pAddress,  
   IEEVisualizerDataProvider dataProvider,  
   out IEEVisualizerService  ppService  
);  
```  
  
#### Parameters  
 `binder`  
 [in] The [IDebugBinder](../extensibility/idebugbinder.md) object passed to [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md).  
  
 `pSymProv`  
 [in] The [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md) object passed to `IDebugParsedExpression::EvaluateSync`.  
  
 `pAddress`  
 [in] The [IDebugAddress](../extensibility/idebugaddress.md) object passed to `IDebugParsedExression::EvaluateSync`.  
  
 `dataProvider`  
 [in] An object implementing the [IEEVisualizerDataProvider](../extensibility/ieevisualizerdataprovider.md) interface (supplied by the expression evaluator).  
  
 `ppService`  
 [out] The created service.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 The `binder`, `pSymProv`, and `pAddress` parameters were all passed to the `IDebugParsedExpression::EvaluateSync` method. `CreateVisualizerService` is to be called only from `IDebugParsedExpression::EvaluateSync` as part of an expression evaluator's support for type visualizers.  
  
## See Also  
 [IEEVisualizerServiceProvider](../extensibility/ieevisualizerserviceprovider.md)   
 [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md)   
 [IDebugBinder](../extensibility/idebugbinder.md)   
 [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)   
 [IEEVisualizerDataProvider](../extensibility/ieevisualizerdataprovider.md)