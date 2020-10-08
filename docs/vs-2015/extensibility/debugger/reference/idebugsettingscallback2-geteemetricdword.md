---
title: "IDebugSettingsCallback2::GetEEMetricDword | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "IDebugSettingsCallback2::GetEEMetricDword"
ms.assetid: c5f8f417-0ef0-4fd0-a779-b0a8ead4effe
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugSettingsCallback2::GetEEMetricDword
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Retrieves a value that corresponds to the specified metric of the expression evaluator.  
  
## Syntax  
  
```cpp#  
HRESULT GetEEMetricDword(  
   REFGUID guidLang,  
   REFGUID guidVendor,  
   LPCWSTR pszMetric,  
   DWORD*  pdwValue  
);  
```  
  
```csharp  
private int GetEEMetricDword(  
   ref Guid guidLang,  
   ref Guid guidVendor,  
   string   pszMetric,  
   out uint pdwValue  
);  
```  
  
#### Parameters  
 `guidLang`  
 [in] Unique identifier of the programming language.  
  
 `guidVendor`  
 [in] Unique identifier of the vendor.  
  
 `pszMetric`  
 [in] Name of the metric.  
  
 `pdwValue`  
 [out] Returns the value that corresponds to the metric string.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDebugSettingsCallback2](../../../extensibility/debugger/reference/idebugsettingscallback2.md)
