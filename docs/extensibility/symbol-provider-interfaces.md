---
title: "Symbol Provider Interfaces"
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
  - "interfaces, symbol handler"
  - "symbol handler, interfaces"
  - "symbol handler, evaluating variables"
ms.assetid: 4201f10e-c9f7-4b38-bb45-40fe0082d5bf
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
# Symbol Provider Interfaces
The following are the Symbol Handling Interfaces for the [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)].  
  
## Discussion  
 These interfaces are used to evaluate variables in a call stack during break mode. They are implemented only for common language runtime symbol providers (SP).  
  
|Interface|Implemented by|Description|  
|---------------|--------------------|-----------------|  
|[IDebugAddress](../extensibility/idebugaddress.md)|SP|Represents the address of an item.|  
|[IDebugAddress2](../extensibility/idebugaddress2.md)|SP|Represents the address of an item, providing access to the process ID.|  
|[IDebugArrayField](../extensibility/idebugarrayfield.md)|SP|Represents an array symbol or array type.|  
|[IDebugClassField](../extensibility/idebugclassfield.md)|SP|Represents a class symbol or class type.|  
|[IDebugComPlusSymbolProvider](../extensibility/idebugcomplussymbolprovider.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code.|  
|[IDebugComPlusSymbolProvider2](../extensibility/idebugcomplussymbolprovider2.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code and extends the **IDebugComPlusSymbolProvider**.|  
|[IDebugContainerField](../extensibility/idebugcontainerfield.md)|SP|Represents a symbol or type that is a container for other symbols or types.|  
|[IDebugCustomAttribute](../extensibility/idebugcustomattribute.md)|SP|Represents a custom attribute that can be attached to a symbol.|  
|[IDebugCustomAttributeQuery](../extensibility/idebugcustomattributequery.md)|SP|Represents a query for custom attributes on a method or type.|  
|[IDebugCustomAttributeQuery2](../extensibility/idebugcustomattributequery2.md)|SP|Provides access to custom attributes on a symbol.|  
|[IDebugDynamicField](../extensibility/idebugdynamicfield.md)|SP|The base interface for any type that can be determined at runtime.|  
|[IDebugDynamicFieldCOMPlus](../extensibility/idebugdynamicfieldcomplus.md)|SP|Represents a dynamic field for an [IDebugBinder](../extensibility/idebugbinder.md) object.|  
|[IDebugEnumField](../extensibility/idebugenumfield.md)|SP|Represents an enumeration type.|  
|[IDebugExtendedField](../extensibility/idebugextendedfield.md)|Sp|Extends the types of available fields to support managed code generics.|  
|[IDebugField](../extensibility/idebugfield.md)|SP|The base class for all fields; represents a description of a symbol or type.|  
|[IDebugGenericFieldDefinition](../extensibility/idebuggenericfielddefinition.md)|SP|Represents the definition of a field for a managed code generic type.|  
|[IDebugGenericFieldInstance](../extensibility/idebuggenericfieldinstance.md)|SP|Represents an instance of a field for a managed code generic type.|  
|[IDebugGenericParamField](../extensibility/idebuggenericparamfield.md)|SP|Represents a parameter for a managed code generic type.|  
|[IDebugMethodField](../extensibility/idebugmethodfield.md)|SP|Represents a method.|  
|[IDebugModOpt](../extensibility/idebugmodopt.md)|SP|Represents a debug optional modifier.|  
|[IDebugPointerField](../extensibility/idebugpointerfield.md)|SP|Represents a pointer.|  
|[IDebugPrimitiveTypeField](../extensibility/idebugprimitivetypefield.md)|SP|Represents a primitive type enumeration value from an [IDebugField](../extensibility/idebugfield.md) interface.|  
|[IDebugPropertyField](../extensibility/idebugpropertyfield.md)|SP|Represents a property of a managed code class that can be get or set.|  
|[IDebugSymbolProvider](../extensibility/idebugsymbolprovider.md)|SP|Represents a symbol provider that provides symbols and types.|  
|[IDebugSymbolProviderDirect](../extensibility/idebugsymbolproviderdirect.md)|SP|Represents a symbol provider with direct access to metadata and core symbol interfaces.|  
|[IDebugTypeFieldBuilder](../extensibility/idebugtypefieldbuilder.md)|SP|Represents the ability to create a field that represents a type.|  
|[IDebugTypeFieldBuilder2](../extensibility/idebugtypefieldbuilder2.md)|SP|Extends the **IDebugTypeFieldBuilder** to be able to create array types.|  
|[IEnumDebugAddresses](../extensibility/ienumdebugaddresses.md)|SP|Represents a collection of [IDebugAddress](../extensibility/idebugaddress.md) objects.|  
|[IEnumDebugCustomAttributes](../extensibility/ienumdebugcustomattributes.md)|SP|Represents a collection of [IDebugCustomAttribute](../extensibility/idebugcustomattribute.md) objects.|  
|[IEnumDebugFields](../extensibility/ienumdebugfields.md)|SP|Represents a collection of [IDebugField](../extensibility/idebugfield.md) objects.|  
  
## See Also  
 [API Reference](../extensibility/api-reference--visual-studio-debugging-.md)