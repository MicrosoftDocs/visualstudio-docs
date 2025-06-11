---
title: Symbol Provider Interfaces
description: This article links to descriptions for the Symbol Handling Interfaces for the Visual Studio SDK, which evaluate variables in a call stack during break mode.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- interfaces, symbol handler
- symbol handler, interfaces
- symbol handler, evaluating variables
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Symbol Provider Interfaces

The following are the Symbol Handling Interfaces for the Visual Studio SDK.

## Discussion
 These interfaces are used to evaluate variables in a call stack during break mode. They are implemented only for common language runtime symbol providers (SP).

|Interface|Implemented by|Description|
|---------------|--------------------|-----------------|
|[IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md)|SP|Represents the address of an item.|
|[IDebugAddress2](../../../extensibility/debugger/reference/idebugaddress2.md)|SP|Represents the address of an item, providing access to the process ID.|
|[IDebugArrayField](../../../extensibility/debugger/reference/idebugarrayfield.md)|SP|Represents an array symbol or array type.|
|[IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)|SP|Represents a class symbol or class type.|
|[IDebugComPlusSymbolProvider](../../../extensibility/debugger/reference/idebugcomplussymbolprovider.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code.|
|[IDebugComPlusSymbolProvider2](../../../extensibility/debugger/reference/idebugcomplussymbolprovider2.md)|SP|Represents a COM+ symbol provider with methods that are specific to managed code and extends the **IDebugComPlusSymbolProvider**.|
|[IDebugContainerField](../../../extensibility/debugger/reference/idebugcontainerfield.md)|SP|Represents a symbol or type that is a container for other symbols or types.|
|[IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)|SP|Represents a custom attribute that can be attached to a symbol.|
|[IDebugCustomAttributeQuery](../../../extensibility/debugger/reference/idebugcustomattributequery.md)|SP|Represents a query for custom attributes on a method or type.|
|[IDebugCustomAttributeQuery2](../../../extensibility/debugger/reference/idebugcustomattributequery2.md)|SP|Provides access to custom attributes on a symbol.|
|[IDebugDynamicField](../../../extensibility/debugger/reference/idebugdynamicfield.md)|SP|The base interface for any type that can be determined at runtime.|
|[IDebugDynamicFieldCOMPlus](../../../extensibility/debugger/reference/idebugdynamicfieldcomplus.md)|SP|Represents a dynamic field for an [IDebugBinder](../../../extensibility/debugger/reference/idebugbinder.md) object.|
|[IDebugEnumField](../../../extensibility/debugger/reference/idebugenumfield.md)|SP|Represents an enumeration type.|
|[IDebugExtendedField](../../../extensibility/debugger/reference/idebugextendedfield.md)|Sp|Extends the types of available fields to support managed code generics.|
|[IDebugField](../../../extensibility/debugger/reference/idebugfield.md)|SP|The base class for all fields; represents a description of a symbol or type.|
|[IDebugGenericFieldDefinition](../../../extensibility/debugger/reference/idebuggenericfielddefinition.md)|SP|Represents the definition of a field for a managed code generic type.|
|[IDebugGenericFieldInstance](../../../extensibility/debugger/reference/idebuggenericfieldinstance.md)|SP|Represents an instance of a field for a managed code generic type.|
|[IDebugGenericParamField](../../../extensibility/debugger/reference/idebuggenericparamfield.md)|SP|Represents a parameter for a managed code generic type.|
|[IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)|SP|Represents a method.|
|[IDebugModOpt](../../../extensibility/debugger/reference/idebugmodopt.md)|SP|Represents a debug optional modifier.|
|[IDebugPointerField](../../../extensibility/debugger/reference/idebugpointerfield.md)|SP|Represents a pointer.|
|[IDebugPrimitiveTypeField](../../../extensibility/debugger/reference/idebugprimitivetypefield.md)|SP|Represents a primitive type enumeration value from an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) interface.|
|[IDebugPropertyField](../../../extensibility/debugger/reference/idebugpropertyfield.md)|SP|Represents a property of a managed code class that can be get or set.|
|[IDebugSymbolProvider](../../../extensibility/debugger/reference/idebugsymbolprovider.md)|SP|Represents a symbol provider that provides symbols and types.|
|[IDebugSymbolProviderDirect](../../../extensibility/debugger/reference/idebugsymbolproviderdirect.md)|SP|Represents a symbol provider with direct access to metadata and core symbol interfaces.|
|[IDebugTypeFieldBuilder](../../../extensibility/debugger/reference/idebugtypefieldbuilder.md)|SP|Represents the ability to create a field that represents a type.|
|[IDebugTypeFieldBuilder2](../../../extensibility/debugger/reference/idebugtypefieldbuilder2.md)|SP|Extends the **IDebugTypeFieldBuilder** to be able to create array types.|
|[IEnumDebugAddresses](../../../extensibility/debugger/reference/ienumdebugaddresses.md)|SP|Represents a collection of [IDebugAddress](../../../extensibility/debugger/reference/idebugaddress.md) objects.|
|[IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)|SP|Represents a collection of [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md) objects.|
|[IEnumDebugFields](../../../extensibility/debugger/reference/ienumdebugfields.md)|SP|Represents a collection of [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) objects.|

## See also
- [API Reference](../../../extensibility/debugger/reference/api-reference-visual-studio-debugging.md)
