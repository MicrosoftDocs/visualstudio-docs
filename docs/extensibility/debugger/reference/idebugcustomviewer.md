---
description: "This interface enables an expression evaluator (EE) to display a property's value in whatever format is necessary."
title: IDebugCustomViewer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugCustomViewer
helpviewer_keywords:
- IDebugCustomViewer interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCustomViewer

This interface enables an expression evaluator (EE) to display a property's value in whatever format is necessary.

## Syntax

```
IDebugCustomViewer : IUknown
```

## Notes for Implementers
An EE implements this interface to display a property's value in a custom format.

## Notes for Callers
A call to COM's `CoCreateInstance` function instantiates this interface. The `CLSID` passed to `CoCreateInstance` is obtained from the registry. A call to [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md) obtains the location in the registry. See Remarks for details as well as the Example.

## Methods in Vtable Order
This interface implements the following method:

|Method|Description|
|------------|-----------------|
|[DisplayValue](../../../extensibility/debugger/reference/idebugcustomviewer-displayvalue.md)|Does whatever is necessary to display a given value.|

## Remarks
This interface is used when a property's value cannot be displayed by normal means—for example, with a data table or another complex property type. A custom viewer, as represented by the `IDebugCustomViewer` interface, is different from a type visualizer, which is an external program for displaying data of a specific type regardless of the EE. The EE implements a custom viewer that is specific to that EE. A user selects which type of visualizer to use, be it a type visualizer or a custom viewer. See [Visualizing and Viewing Data](../../../extensibility/debugger/visualizing-and-viewing-data.md) for details on this process.

A custom viewer is registered in the same way as an EE and, therefore, requires a language GUID and a vendor GUID. The exact metric (or registry entry name) is known only to the EE. This metric is returned in the [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md) structure, which in turn is returned by a call to [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md). The value stored in the metric is the `CLSID` that is passed to COM's `CoCreateInstance` function (see the Example).

The [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md) function, `SetEEMetric`, can be used to register a custom viewer. See the "Expression Evaluators" registry section of `Debugging SDK Helpers` for the specific registry keys that a custom viewer needs. Note that a custom viewer needs only one metric (which is defined by the EE's implementer) whereas an expression evaluator requires several predefined metrics.

Normally, a custom viewer provides a read-only view of the data, since the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface supplied to [DisplayValue](../../../extensibility/debugger/reference/idebugcustomviewer-displayvalue.md) has no methods for changing the property's value except as a string. In order to support changing arbitrary blocks of data, the EE implements a custom interface on the same object that implements the `IDebugProperty3` interface. This custom interface would then provide the methods needed to change an arbitrary block of data.

## Requirements
Header: msdbg.h

Namespace: Microsoft.VisualStudio.Debugger.Interop

Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## Example
This example shows how to get the first custom viewer from a property if that property has any custom viewers.

```cpp
IDebugCustomViewer *GetFirstCustomViewer(IDebugProperty2 *pProperty)
{
    // This string is typically defined globally.  For this example, it
    // is defined here.
    static const WCHAR strRegistrationRoot[] = L"Software\\Microsoft\\VisualStudio\\8.0Exp";
    IDebugCustomViewer *pViewer = NULL;
    if (pProperty != NULL) {
        CComQIPtr<IDebugProperty3> pProperty3(pProperty);
        if (pProperty3 != NULL) {
            HRESULT hr;
            ULONG viewerCount = 0;
            hr = pProperty3->GetCustomViewerCount(&viewerCount);
            if (viewerCount > 0) {
                ULONG viewersFetched = 0;
                DEBUG_CUSTOM_VIEWER viewerInfo = { 0 };
                hr = pProperty3->GetCustomViewerList(0,
                                                     1,
                                                     &viewerInfo,
                                                     &viewersFetched);
                if (viewersFetched == 1) {
                    CLSID clsidViewer = { 0 };
                    CComPtr<IDebugCustomViewer> spCustomViewer;
                    // Get the viewer's CLSID from the registry.
                    ::GetEEMetric(viewerInfo.guidLang,
                                  viewerInfo.guidVendor,
                                  viewerInfo.bstrMetric,
                                  &clsidViewer,
                                  strRegistrationRoot);
                    if (!IsEqualGUID(clsidViewer,GUID_NULL)) {
                        // Instantiate the custom viewer.
                        spCustomViewer.CoCreateInstance(clsidViewer);
                        if (spCustomViewer != NULL) {
                            pViewer = spCustomViewer.Detach();
                        }
                    }
                }
            }
        }
    }
    return(pViewer);
}
```

## See also
- [Core Interfaces](../../../extensibility/debugger/reference/core-interfaces.md)
- [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md)
- [SDK Helpers for Debugging](../../../extensibility/debugger/reference/sdk-helpers-for-debugging.md)
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
