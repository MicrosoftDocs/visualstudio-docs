---
description: "Describes various attributes for an IDebugProperty2 or an IDebugReference2 interface."
title: DBG_ATTRIB_FLAGS
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- DBG_ATTRIB_FLAGS
helpviewer_keywords:
- DBGPROP_ATTRIB_FLAGS enumerations
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# DBG_ATTRIB_FLAGS

Describes various attributes for an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) or an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) interface. Member of the [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) structure.

## Syntax

### [C#](#tab/csharp)
```csharp
public const int DBG_ATTRIB_NONE                 = 0x0000000000000000,
public const int DBG_ATTRIB_ALL                  = 0x00000000ffffffff,

// Attributes about the object itself

public const int DBG_ATTRIB_OBJ_IS_EXPANDABLE    = 0x0000000000000001,
public const int DBG_ATTRIB_OBJ_HAS_ID           = 0x0000000000000002,
public const int DBG_ATTRIB_OBJ_CAN_HAVE_ID      = 0x0000000000000004,

// Attributes about the value of the object

public const int DBG_ATTRIB_VALUE_READONLY       = 0x0000000000000010,
public const int DBG_ATTRIB_VALUE_ERROR          = 0x0000000000000020,
public const int DBG_ATTRIB_VALUE_SIDE_EFFECT    = 0x0000000000000040,
public const int DBG_ATTRIB_OVERLOADED_CONTAINER = 0x0000000000000080,
public const int DBG_ATTRIB_VALUE_BOOLEAN        = 0x0000000000000100,
public const int DBG_ATTRIB_VALUE_BOOLEAN_TRUE   = 0x0000000000000200,
public const int DBG_ATTRIB_VALUE_INVALID        = 0x0000000000000400,
public const int DBG_ATTRIB_VALUE_NAT            = 0x0000000000000800,
public const int DBG_ATTRIB_VALUE_AUTOEXPANDED   = 0x0000000000001000,
public const int DBG_ATTRIB_VALUE_TIMEOUT        = 0x0000000000002000,
public const int DBG_ATTRIB_VALUE_RAW_STRING     = 0x0000000000004000,
public const int DBG_ATTRIB_VALUE_CUSTOM_VIEWER  = 0x0000000000008000,

// Attributes about field access types for the object

public const int DBG_ATTRIB_ACCESS_NONE          = 0x0000000000010000,
public const int DBG_ATTRIB_ACCESS_PUBLIC        = 0x0000000000020000,
public const int DBG_ATTRIB_ACCESS_PRIVATE       = 0x0000000000040000,
public const int DBG_ATTRIB_ACCESS_PROTECTED     = 0x0000000000080000,
public const int DBG_ATTRIB_ACCESS_FINAL         = 0x0000000000100000,
public const int DBG_ATTRIB_ACCESS_ALL           = 0x00000000001f0000,

// Attributes for the storage types of the object

public const int DBG_ATTRIB_STORAGE_NONE         = 0x0000000001000000,
public const int DBG_ATTRIB_STORAGE_GLOBAL       = 0x0000000002000000,
public const int DBG_ATTRIB_STORAGE_STATIC       = 0x0000000004000000,
public const int DBG_ATTRIB_STORAGE_REGISTER     = 0x0000000008000000,
public const int DBG_ATTRIB_STORAGE_ALL          = 0x000000000f000000,

// Attributes for the type modifiers on the object

public const int DBG_ATTRIB_TYPE_NONE            = 0x0000000100000000,
public const int DBG_ATTRIB_TYPE_VIRTUAL         = 0x0000000200000000,
public const int DBG_ATTRIB_TYPE_CONSTANT        = 0x0000000400000000,
public const int DBG_ATTRIB_TYPE_SYNCHRONIZED    = 0x0000000800000000,
public const int DBG_ATTRIB_TYPE_VOLATILE        = 0x0000001000000000,
public const int DBG_ATTRIB_TYPE_ALL             = 0x0000001f00000000,

// Attributes that describe the type of object

public const int DBG_ATTRIB_DATA                 = 0x0000010000000000,
public const int DBG_ATTRIB_METHOD               = 0x0000020000000000,
public const int DBG_ATTRIB_PROPERTY             = 0x0000040000000000,
public const int DBG_ATTRIB_CLASS                = 0x0000080000000000,
public const int DBG_ATTRIB_BASECLASS            = 0x0000100000000000,
public const int DBG_ATTRIB_INTERFACE            = 0x0000200000000000,
public const int DBG_ATTRIB_INNERCLASS           = 0x0000400000000000,
public const int DBG_ATTRIB_MOSTDERIVED          = 0x0000800000000000,
public const int DBG_ATTRIB_CHILD_ALL            = 0x0000ff0000000000,

// Miscellaneous attributes

public const int DBG_ATTRIB_MULTI_CUSTOM_VIEWERS = 0x0001000000000000
```
### [C++](#tab/cpp)
```cpp
#define DBG_ATTRIB_NONE                 0x0000000000000000,
#define DBG_ATTRIB_ALL                  0x00000000ffffffff,

// Attributes about the object itself

#define DBG_ATTRIB_OBJ_IS_EXPANDABLE    0x0000000000000001,
#define DBG_ATTRIB_OBJ_HAS_ID           0x0000000000000002,
#define DBG_ATTRIB_OBJ_CAN_HAVE_ID      0x0000000000000004,

// Attributes about the value of the object

#define DBG_ATTRIB_VALUE_READONLY       0x0000000000000010,
#define DBG_ATTRIB_VALUE_ERROR          0x0000000000000020,
#define DBG_ATTRIB_VALUE_SIDE_EFFECT    0x0000000000000040,
#define DBG_ATTRIB_OVERLOADED_CONTAINER 0x0000000000000080,
#define DBG_ATTRIB_VALUE_BOOLEAN        0x0000000000000100,
#define DBG_ATTRIB_VALUE_BOOLEAN_TRUE   0x0000000000000200,
#define DBG_ATTRIB_VALUE_INVALID        0x0000000000000400,
#define DBG_ATTRIB_VALUE_NAT            0x0000000000000800,
#define DBG_ATTRIB_VALUE_AUTOEXPANDED   0x0000000000001000,
#define DBG_ATTRIB_VALUE_TIMEOUT        0x0000000000002000,
#define DBG_ATTRIB_VALUE_RAW_STRING     0x0000000000004000,
#define DBG_ATTRIB_VALUE_CUSTOM_VIEWER  0x0000000000008000,

// Attributes about field access types for the object

#define DBG_ATTRIB_ACCESS_NONE          0x0000000000010000,
#define DBG_ATTRIB_ACCESS_PUBLIC        0x0000000000020000,
#define DBG_ATTRIB_ACCESS_PRIVATE       0x0000000000040000,
#define DBG_ATTRIB_ACCESS_PROTECTED     0x0000000000080000,
#define DBG_ATTRIB_ACCESS_FINAL         0x0000000000100000,
#define DBG_ATTRIB_ACCESS_ALL           0x00000000001f0000,

// Attributes for the storage types of the object

#define DBG_ATTRIB_STORAGE_NONE         0x0000000001000000,
#define DBG_ATTRIB_STORAGE_GLOBAL       0x0000000002000000,
#define DBG_ATTRIB_STORAGE_STATIC       0x0000000004000000,
#define DBG_ATTRIB_STORAGE_REGISTER     0x0000000008000000,
#define DBG_ATTRIB_STORAGE_ALL          0x000000000f000000,

// Attributes for the type modifiers on the object

#define DBG_ATTRIB_TYPE_NONE            0x0000000100000000,
#define DBG_ATTRIB_TYPE_VIRTUAL         0x0000000200000000,
#define DBG_ATTRIB_TYPE_CONSTANT        0x0000000400000000,
#define DBG_ATTRIB_TYPE_SYNCHRONIZED    0x0000000800000000,
#define DBG_ATTRIB_TYPE_VOLATILE        0x0000001000000000,
#define DBG_ATTRIB_TYPE_ALL             0x0000001f00000000,

// Attributes that describe the type of object

#define DBG_ATTRIB_DATA                 0x0000010000000000,
#define DBG_ATTRIB_METHOD               0x0000020000000000,
#define DBG_ATTRIB_PROPERTY             0x0000040000000000,
#define DBG_ATTRIB_CLASS                0x0000080000000000,
#define DBG_ATTRIB_BASECLASS            0x0000100000000000,
#define DBG_ATTRIB_INTERFACE            0x0000200000000000,
#define DBG_ATTRIB_INNERCLASS           0x0000400000000000,
#define DBG_ATTRIB_MOSTDERIVED          0x0000800000000000,
#define DBG_ATTRIB_CHILD_ALL            0x0000ff0000000000,

// Miscellaneous attributes

#define DBG_ATTRIB_MULTI_CUSTOM_VIEWERS 0x0001000000000000

typedef UINT64 DBG_ATTRIB_FLAGS;
```
---

## Members
 `DBG_ATTRIB_NONE`\
 Indicates no attributes.

 `DBG_ATTRIB_ALL`\
 Indicates all attributes.

 `DBG_ATTRIB_OBJ_IS_EXPANDABLE`\
 Indicates that the reference or property has children.

 `DBG_ATTRIB_OBJ_HAS_ID`\
 Indicates that an ID for this object has been created.

 `DBG_ATTRIB_OBJ_CAN_HAVE_ID`\
 Indicates that an ID for this object can be created.

 `DBG_ATTRIB_VALUE_READONLY`\
 Indicates that the value is read-only.

 `DBG_ATTRIB_VALUE_ERROR`\
 Indicates that the value is an error.

 `DBG_ATTRIB_VALUE_SIDE_EFFECT`\
 Indicates that the evaluation had a side effect.

 `DBG_ATTRIB_OVERLOADED_CONTAINER`\
 Indicates that this property is really a container of overloads.

 `DBG_ATTRIB_VALUE_BOOLEAN`\
 Indicates that the value in `DEBUG_PROPERTY_INFO::bstrValue` is Boolean.

 `DBG_ATTRIB_VALUE_BOOLEAN_TRUE`\
 Indicates that the value in `DEBUG_PROPERTY_INFO::bstrValue` is Boolean and `TRUE`.

 `DBG_ATTRIB_VALUE_INVALID`\
 Indicates that the value in `DEBUG_PROPERTY_INFO::bstrValue` is not valid.

 `DBG_ATTRIB_VALUE_NAT`\
 Indicates that the value in `DEBUG_PROPERTY_INFO::bstrValue` is "*not a thing*" (NAT). NAT describes a register flag in Intel 64-bit processors that indicates deferred speculative exceptions.

 `DBG_ATTRIB_VALUE_AUTOEXPANDED`\
 Indicates that the value in `DEBUG_PROPERTY_INFO::bstrValue` has possibly been auto-expanded.

 `DBG_ATTRIB_VALUE_TIMEOUT`\
 Indicates that an evaluation has timed-out.

 `DBG_ATTRIB_VALUE_RAW_STRING`\
 Indicates that the value in `DEBUG_PROPERTY_INFO::bstrValue` can be represented by a raw string.

 `DBG_ATTRIB_VALUE_CUSTOM_VIEWER`\
 Indicates that this property has at least one custom viewer associated with it.

 `DBG_ATTRIB_ACCESS_NONE`\
 Indicates an object that has neither `public`, `private`, nor `protected` type access.

 `DBG_ATTRIB_ACCESS_PUBLIC`\
 Indicates an object that has public access.

 `DBG_ATTRIB_ACCESS_PRIVATE`\
 Indicates an object that has private access.

 `DBG_ATTRIB_ACCESS_PROTECTED`\
 Indicates an object that has protected access.

 `DBG_ATTRIB_ACCESS_FINAL`\
 Indicates an object that has final access.

 `DBG_ATTRIB_ACCESS_ALL`\
 Mask to extract the access attributes from `DBG_ATTRIB_FLAGS`.

 `DBG_ATTRIB_STORAGE_NONE`\
 Indicates that there is no storage type specified.

 `DBG_ATTRIB_STORAGE_GLOBAL`\
 Indicates global storage.

 `DBG_ATTRIB_STORAGE_STATIC`\
 Indicates static storage.

 `DBG_ATTRIB_STORAGE_REGISTER`\
 Indicates storage in the register.

 `DBG_ATTRIB_STORAGE_ALL`\
 Mask to extract the storage attributes from `DBG_ATTRIB_FLAGS`.

 `DBG_ATTRIB_TYPE_NONE`\
 Indicates that there is no type modifier.

 `DBG_ATTRIB_TYPE_VIRTUAL`\
 Indicates that the type of object is virtual.

 `DBG_ATTRIB_TYPE_CONSTANT`\
 Indicates that the type of object is constant.

 `DBG_ATTRIB_TYPE_SYNCHRONIZED`\
 Indicates that the type of object is synchronized.

 `DBG_ATTRIB_TYPE_VOLATILE`\
 Indicates that the type of object is volatile.

 `DBG_ATTRIB_TYPE_ALL`\
 Mask to extract the type attributes from `DBG_ATTRIB_FLAGS`.

 `DBG_ATTRIB_DATA`\
 Indicates that this object is a data field.

 `DBG_ATTRIB_METHOD`\
 Indicates that this object is a method.

 `DBG_ATTRIB_PROPERTY`\
 Indicates that this object is a property.

 `DBG_ATTRIB_CLASS`\
 Indicates that this object is a class.

 `DBG_ATTRIB_BASECLASS`\
 Indicates that this object is a base class.

 `DBG_ATTRIB_INTERFACE`\
 Indicates that this object is an interface.

 `DBG_ATTRIB_INNERCLASS`\
 Indicates that this object is an inner class.

 `DBG_ATTRIB_MOSTDERIVED`\
 Indicates that this object is '*most-derived*'. The term "*most-derived*" means the actual type of the object, and not the type of its reference.

 `DBG_ATTRIB_CHILD_ALL`\
 Indicates a mask of `DBG_ATTRIB_DATA` through `DBG_ATTRIB_MOSTDERIVED`.

 `DBG_ATTRIB_MULTI_CUSTOM_VIEWERS`\
 Indicates that the object has multiple custom viewers associated with it.

## Remarks

> [!NOTE]
> The values in this enumeration are not actually defined in the assembly for C#. Instead, you must copy the definitions to your source file.

 These flags are also used to filter children of an object, for example, when passed as an argument to [EnumChildren](../../../extensibility/debugger/reference/idebugproperty2-enumchildren.md). The values may be combined with a bitwise `OR`.

 The `DBG_ATTRIB_VALUE_CUSTOM_VIEWER` flag is an indication to Visual Studio to obtain the [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md) interface from the [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) interface and call [GetCustomViewerList](../../../extensibility/debugger/reference/idebugproperty3-getcustomviewerlist.md) for a list of custom viewers.

## Requirements
 Header: msdbg.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [Enumerations](../../../extensibility/debugger/reference/enumerations-visual-studio-debugging.md)
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugProperty3](../../../extensibility/debugger/reference/idebugproperty3.md)
- [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md)
- [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md)
