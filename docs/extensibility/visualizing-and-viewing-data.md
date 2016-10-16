---
title: "Visualizing and Viewing Data"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "debugging [Debugging SDK], viewing data"
  - "debugging [Debugging SDK], visualizing data"
ms.assetid: 699dd0f5-7569-40b3-ade6-d0fe53e832bc
caps.latest.revision: 20
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
# Visualizing and Viewing Data
Type visualizers and custom viewers present data in a way that is quickly meaningful to a developer. The expression evaluator (EE) can support third-party type visualizers as well as supply its own custom viewers.  
  
 [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] determines how many type visualizers and custom viewers are associated with the object's type by calling the [GetCustomViewerCount](../extensibility/idebugproperty3--getcustomviewercount.md) method. If there is at least one type visualizer or custom viewer available, Visual Studio calls the [GetCustomViewerList](../extensibility/idebugproperty3--getcustomviewerlist.md) method to retrieve a list of those visualizers and viewers (actually, a list of `CLSID`s that implement the visualizers and viewers) and presents them to the user.  
  
## Supporting Type Visualizers  
 There are a number of interfaces that the EE must implement to support type visualizers. These interfaces can be broken down into two broad categories: those that list the type visualizers and those that access the property data.  
  
### Listing Type Visualizers  
 The EE supports listing the type visualizers in its implementation of `IDebugProperty3::GetCustomViewerCount` and `IDebugProperty3::GetCustomViewerList`. These methods pass the call to the corresponding methods [GetCustomViewerCount](../extensibility/ieevisualizerservice--getcustomviewercount.md) and [GetCustomViewerList](../extensibility/ieevisualizerservice--getcustomviewerlist.md).  
  
 The [IEEVisualizerService](../extensibility/ieevisualizerservice.md) is obtained by calling [CreateVisualizerService](../extensibility/ieevisualizerserviceprovider--createvisualizerservice.md). This method requires the [IDebugBinder3](../extensibility/idebugbinder3.md) interface, which is obtained from the [IDebugBinder](../extensibility/idebugbinder.md) interface passed to [EvaluateSync](../extensibility/idebugparsedexpression--evaluatesync.md). `IEEVisualizerServiceProvider::CreateVisualizerService` also requires the [IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md) and [IDebugAddress](../extensibility/idebugaddress.md) interfaces which were passed to `IDebugParsedExpression::EvaluateSync`. The final interface required to create the `IEEVisualizerService` interface is the [IEEVisualizerDataProvider](../extensibility/ieevisualizerdataprovider.md) interface, which the EE implements. This interface allows changes to be made to the property being visualized. All property data is encapsulated in an [IDebugObject](../extensibility/idebugobject.md) interface, which is also implemented by the EE.  
  
### Accessing Property Data  
 Accessing property data is done through the [IPropertyProxyEESide](../extensibility/ipropertyproxyeeside.md) interface. To obtain this interface, Visual Studio calls [QueryInterface](../Topic/QueryInterface.md) on the property object to get the [IPropertyProxyProvider](../extensibility/ipropertyproxyprovider.md) interface (implemented on the same object that implements the [IDebugProperty3](../extensibility/idebugproperty3.md) interface) and then calls the [GetPropertyProxy](../extensibility/ipropertyproxyprovider--getpropertyproxy.md) method to obtain the `IPropertyProxyEESide` interface.  
  
 All data passed into and out of the `IPropertyProxyEESide` interface is encapsulated in the [IEEDataStorage](../extensibility/ieedatastorage.md) interface. This interface represents an array of bytes and is implemented by both Visual Studio and the EE. When a property's data is to be changed, Visual Studio creates an `IEEDataStorage` object holding the new data and calls [CreateReplacementObject](../extensibility/ipropertyproxyeeside--createreplacementobject.md) with that data object in order to obtain a new `IEEDataStorage` object that, in turn, is passed to [InPlaceUpdateObject](../extensibility/ipropertyproxyeeside--inplaceupdateobject.md) to update the property's data. `IPropertyProxyEESide::CreateReplacementObject` allows the EE to instantiate its own class that implements the `IEEDataStorage` interface.  
  
## Supporting Custom Viewers  
 The flag `DBG_ATTRIB_VALUE_CUSTOM_VIEWER` is set in the `dwAttrib` field of the [DEBUG_PROPERTY_INFO](../extensibility/debug_property_info.md) structure (returned by a call to [GetPropertyInfo](../extensibility/idebugproperty2--getpropertyinfo.md)) to indicate that the object has a custom viewer associated with it. When this flag is set, Visual Studio obtains the [IDebugProperty3](../extensibility/idebugproperty3.md) interface from the [IDebugProperty2](../extensibility/idebugproperty2.md) interface using [QueryInterface](../Topic/QueryInterface.md).  
  
 If the user selects a custom viewer, Visual Studio instantiates the custom viewer using the viewer's `CLSID` supplied by the `IDebugProperty3::GetCustomViewerList` method. Visual Studio then calls [DisplayValue](../extensibility/idebugcustomviewer--displayvalue.md) to show the value to the user.  
  
 Normally, `IDebugCustomViewer::DisplayValue` presents a read-only view of the data. To allow changes to the data, the EE must implement a custom interface that supports changing data on a property object. The `IDebugCustomViewer::DisplayValue` method uses this custom interface to support changing the data. The method looks for the custom interface on the `IDebugProperty2` interface passed in as the `pDebugProperty` argument.  
  
## Supporting Both Type Visualizers and Custom Viewers  
 An EE can support both type visualizers and custom viewers in the [GetCustomViewerCount](../extensibility/idebugproperty3--getcustomviewercount.md) and [GetCustomViewerList](../extensibility/idebugproperty3--getcustomviewerlist.md) methods. First, the EE adds the number of custom viewers that it is supplying to the value returned by the [GetCustomViewerCount](../extensibility/ieevisualizerservice--getcustomviewercount.md) method. Second, the EE appends the `CLSID`s of its own custom viewers to the list returned by the [GetCustomViewerList](../extensibility/ieevisualizerservice--getcustomviewerlist.md) method.  
  
## See Also  
 [Debugging Tasks](../extensibility/debugging-tasks.md)   
 [Type Visualizer and Custom Viewer](../extensibility/type-visualizer-and-custom-viewer.md)