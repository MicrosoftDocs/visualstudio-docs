---
title: Visualizing and Viewing Data
description: Learn how type visualizers and custom viewers present data to a developer. The expression evaluator supports third-party type visualizers.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- debugging [Debugging SDK], viewing data
- debugging [Debugging SDK], visualizing data
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Visualizing and viewing data

Type visualizers and custom viewers present data in a way that is quickly meaningful to a developer. The expression evaluator (EE) can support third-party type visualizers as well as supply its own custom viewers.

 Visual Studio determines how many type visualizers and custom viewers are associated with the object's type by calling the [GetCustomViewerCount](../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md) method. If there is at least one type visualizer or custom viewer available, Visual Studio calls the [GetCustomViewerList](../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md) method to retrieve a list of those visualizers and viewers (actually, a list of s that implements the visualizers and viewers) and presents them to the user.

## Supporting type visualizers
 There are a number of interfaces that the EE must implement to support type visualizers. These interfaces can be broken down into two broad categories: interfaces that list the type visualizers and interfaces that access the property data.

### Listing type visualizers
 The EE supports listing the type visualizers in its implementation of `IDebugProperty3::GetCustomViewerCount` and `IDebugProperty3::GetCustomViewerList`. These methods pass the call to the corresponding methods [GetCustomViewerCount](../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewercount.md) and [GetCustomViewerList](../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md).

 The [IEEVisualizerService](../../extensibility/debugger/reference/ieevisualizerservice.md) is obtained by calling [CreateVisualizerService](../../extensibility/debugger/reference/ieevisualizerserviceprovider-createvisualizerservice.md). This method requires the [IDebugBinder3](../../extensibility/debugger/reference/idebugbinder3.md) interface, which is obtained from the [IDebugBinder](../../extensibility/debugger/reference/idebugbinder.md) interface passed to [EvaluateSync](../../extensibility/debugger/reference/idebugparsedexpression-evaluatesync.md). `IEEVisualizerServiceProvider::CreateVisualizerService` also requires the [IDebugSymbolProvider](../../extensibility/debugger/reference/idebugsymbolprovider.md) and [IDebugAddress](../../extensibility/debugger/reference/idebugaddress.md) interfaces, which were passed to `IDebugParsedExpression::EvaluateSync`. The final interface required to create the `IEEVisualizerService` interface is the [IEEVisualizerDataProvider](../../extensibility/debugger/reference/ieevisualizerdataprovider.md) interface, which the EE implements. This interface allows changes to be made to the property being visualized. All property data is encapsulated in an [IDebugObject](../../extensibility/debugger/reference/idebugobject.md) interface, which is also implemented by the EE.

### Accessing property data
 Accessing property data is done through the [IPropertyProxyEESide](../../extensibility/debugger/reference/ipropertyproxyeeside.md) interface. To obtain this interface, Visual Studio calls [QueryInterface](/cpp/atl/queryinterface) on the property object to get the [IPropertyProxyProvider](../../extensibility/debugger/reference/ipropertyproxyprovider.md) interface (implemented on the same object that implements the [IDebugProperty3](../../extensibility/debugger/reference/idebugproperty3.md) interface) and then calls the [GetPropertyProxy](../../extensibility/debugger/reference/ipropertyproxyprovider-getpropertyproxy.md) method to obtain the `IPropertyProxyEESide` interface.

 All data passed into and out of the `IPropertyProxyEESide` interface is encapsulated in the [IEEDataStorage](../../extensibility/debugger/reference/ieedatastorage.md) interface. This interface represents an array of bytes and is implemented by both Visual Studio and the EE. When a property's data is to be changed, Visual Studio creates an `IEEDataStorage` object holding the new data and calls [CreateReplacementObject](../../extensibility/debugger/reference/ipropertyproxyeeside-createreplacementobject.md) with that data object in order to obtain a new `IEEDataStorage` object that, in turn, is passed to [InPlaceUpdateObject](../../extensibility/debugger/reference/ipropertyproxyeeside-inplaceupdateobject.md) to update the property's data. `IPropertyProxyEESide::CreateReplacementObject` allows the EE to instantiate its own class that implements the `IEEDataStorage` interface.

## Supporting custom viewers
 The flag `DBG_ATTRIB_VALUE_CUSTOM_VIEWER` is set in the `dwAttrib` field of the [DEBUG_PROPERTY_INFO](../../extensibility/debugger/reference/debug-property-info.md) structure (returned by a call to [GetPropertyInfo](../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md)) to indicate that the object has a custom viewer associated with it. When this flag is set, Visual Studio obtains the [IDebugProperty3](../../extensibility/debugger/reference/idebugproperty3.md) interface from the [IDebugProperty2](../../extensibility/debugger/reference/idebugproperty2.md) interface using [QueryInterface](/cpp/atl/queryinterface).

 If the user selects a custom viewer, Visual Studio instantiates the custom viewer using the viewer's `CLSID` supplied by the `IDebugProperty3::GetCustomViewerList` method. Visual Studio then calls [DisplayValue](../../extensibility/debugger/reference/idebugcustomviewer-displayvalue.md) to show the value to the user.

 Normally, `IDebugCustomViewer::DisplayValue` presents a read-only view of the data. To allow changes to the data, the EE must implement a custom interface that supports changing data on a property object. The `IDebugCustomViewer::DisplayValue` method uses this custom interface to support changing the data. The method looks for the custom interface on the `IDebugProperty2` interface passed in as the `pDebugProperty` argument.

## Supporting both type visualizers and custom viewers
 An EE can support both type visualizers and custom viewers in the [GetCustomViewerCount](../../extensibility/debugger/reference/idebugproperty3-getcustomviewercount.md) and [GetCustomViewerList](../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md) methods. First, the EE adds the number of custom viewers that it is supplying to the value returned by the [GetCustomViewerCount](../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewercount.md) method. Second, the EE appends the `CLSID`s of its own custom viewers to the list returned by the [GetCustomViewerList](../../extensibility/debugger/reference/ieevisualizerservice-getcustomviewerlist.md) method.

## Related content
- [Debugging tasks](../../extensibility/debugger/debugging-tasks.md)
- [Type visualizer and custom viewer](../../extensibility/debugger/type-visualizer-and-custom-viewer.md)
