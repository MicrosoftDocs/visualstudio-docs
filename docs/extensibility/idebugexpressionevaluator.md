---
title: "IDebugExpressionEvaluator"
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
  - "IDebugExpressionEvaluator"
helpviewer_keywords: 
  - "IDebugExpressionEvaluator interface"
ms.assetid: 0636d8c3-625a-49fa-94b6-516f22b7e1bc
caps.latest.revision: 14
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
# IDebugExpressionEvaluator
> [!IMPORTANT]
>  In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 This interface represents the expression evaluator.  
  
## Syntax  
  
```  
IDebugExpressionEvaluator : IUnknown  
```  
  
## Notes for Implementers  
 The expression evaluator must implement this interface.  
  
## Notes for Callers  
 To obtain this interface, instantiate the expression evaluator through the `CoCreateInstance` method by using the class ID (CLSID) of the evaluator. See the Example.  
  
## Methods in Vtable Order  
 The following table shows the methods of `IDebugExpressionEvaluator`.  
  
|Method|Description|  
|------------|-----------------|  
|[Parse](../extensibility/idebugexpressionevaluator--parse.md)|Converts an expression string to a parsed expression.|  
|[GetMethodProperty](../extensibility/idebugexpressionevaluator--getmethodproperty.md)|Gets the local variables, arguments, and other properties of a method.|  
|[GetMethodLocationProperty](../extensibility/idebugexpressionevaluator--getmethodlocationproperty.md)|Converts a method location and offset into a memory address.|  
|[SetLocale](../extensibility/idebugexpressionevaluator--setlocale.md)|Determines which language to use to create printable results.|  
|[SetRegistryRoot](../extensibility/idebugexpressionevaluator--setregistryroot.md)|Sets the registry root. Used for side-by-side debugging.|  
  
## Remarks  
 In a typical situation, the debug engine (DE) instantiates the expression evaluator (EE) as a result of a call to [ParseText](../extensibility/idebugexpressioncontext2--parsetext.md). Because the DE knows the language and vendor of the EE it wants to use, the DE gets the EE's CLSID from the registry (the [SDK Helpers for Debugging](../extensibility/sdk-helpers-for-debugging.md) function, `GetEEMetric`, helps with this retrieval).  
  
 After the EE is instantiated, the DE calls [Parse](../extensibility/idebugexpressionevaluator--parse.md) to parse the expression and store it in an [IDebugParsedExpression](../extensibility/idebugparsedexpression.md) object. Later, a call to [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md) evaluates the expression.  
  
## Requirements  
 Header: ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## Example  
 This example shows how to instantiate the expression evaluator given a symbol provider and an address in the source code. This example uses a function, `GetEEMetric`, from the [SDK Helpers for Debugging](../extensibility/sdk-helpers-for-debugging.md) library, dbgmetric.lib.  
  
```cpp#  
IDebugExpressionEvaluator GetExpressionEvaluator(IDebugSymbolProvider pSymbolProvider,  
                                                 IDebugAddress *pSourceAddress)  
{  
    // This is typically defined globally but is specified here just  
    // for this example.  
    static const WCHAR strRegistrationRoot[] = L"Software\\Microsoft\\VisualStudio\\8.0Exp";  
  
    IDebugExpressionEvaluator *pEE = NULL;  
    if (pSymbolProvider != NULL && pSourceAddress != NULL) {  
        HRESULT hr         = S_OK;  
        GUID  languageGuid = { 0 };  
        GUID  vendorGuid   = { 0 };  
  
        hr = pSymbolProvider->GetLanguage(pSourceAddress,  
                                          &languageGuid,  
                                          &vendorGuid);  
        if (SUCCEEDED(hr)) {  
            CLSID clsidEE      = { 0 };  
            CComPtr<IDebugExpressionEvaluator> spExpressionEvaluator;  
            // Get the expression evaluator's CLSID from the registry.  
            ::GetEEMetric(languageGuid,  
                          vendorGuid,  
                          metricCLSID,  
                          &clsidEE,  
                          strRegistrationRoot);  
            if (!IsEqualGUID(clsidEE,GUID_NULL)) {  
                // Instantiate the expression evaluator.  
                spExpressionEvaluator.CoCreateInstance(clsidEE);  
            }  
            if (spExpressionEvaluator != NULL) {  
                pEE = spExpressionEvaluator.Detach();  
            }  
        }  
    }  
    return pEE;  
}  
```  
  
## See Also  
 [Expression Evaluation Interfaces](../extensibility/expression-evaluation-interfaces.md)   
 [ParseText](../extensibility/idebugexpressioncontext2--parsetext.md)   
 [IDebugParsedExpression](../extensibility/idebugparsedexpression.md)   
 [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md)   
 [SDK Helpers for Debugging](../extensibility/sdk-helpers-for-debugging.md)