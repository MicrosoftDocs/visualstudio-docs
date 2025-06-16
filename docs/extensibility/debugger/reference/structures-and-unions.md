---
title: Structures and Unions
description: This article links to reference descriptions of structures and unions in the Visual Studio Debugging SDK.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- structures [Visual Studio SDK]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Structures and Unions

The following are structures and unions in the Visual Studio Debugging SDK.

- [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) specifies the process ID, which may be either a system ID or a GUID.

- [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md) describes the conditions under which a breakpoint will fire.

- [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md) describes the resolution of an error breakpoint, including location, program, and thread.

- [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md) specifies the type of structure used to describe the location of the breakpoint.

- [BP_LOCATION_CODE_ADDRESS](../../../extensibility/debugger/reference/bp-location-code-address.md) defines the components that describe the location of a breakpoint at an address in code.

- [BP_LOCATION_CODE_CONTEXT](../../../extensibility/debugger/reference/bp-location-code-context.md) describes the location of a breakpoint that is bound directly to an address in the program being debugged.

- [BP_LOCATION_CODE_FILE_LINE](../../../extensibility/debugger/reference/bp-location-code-file-line.md) describes the location of a breakpoint at line in a code source file.

- [BP_LOCATION_CODE_FUNC_OFFSET](../../../extensibility/debugger/reference/bp-location-code-func-offset.md) describes the offset location of a breakpoint at a function in code.

- [BP_LOCATION_CODE_STRING](../../../extensibility/debugger/reference/bp-location-code-string.md) is used for setting code breakpoints based on a string that the user can enter from the IDE.

- [BP_LOCATION_DATA_STRING](../../../extensibility/debugger/reference/bp-location-data-string.md) is used for setting data breakpoints that are based on a string that the user can enter from the IDE.

- [BP_LOCATION_RESOLUTION](../../../extensibility/debugger/reference/bp-location-resolution.md) describes the resolution of a breakpoint at a specific location.

- [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md) describes the count and conditions upon which a breakpoint will be fired after having been previously passed.

- [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) contains the information required to implement a breakpoint.

- [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md) contains the information required to implement a breakpoint (same as the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) structure but includes vendor GUID, constraint and tracepoint information).

- [BP_RESOLUTION_CODE](../../../extensibility/debugger/reference/bp-resolution-code.md) describes the location of a code breakpoint.

- [BP_RESOLUTION_DATA](../../../extensibility/debugger/reference/bp-resolution-data.md) describes the result of binding a data breakpoint.

- [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md) describes the bound breakpoint information for either a code breakpoint or a data breakpoint.

- [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md) specifies the structure of the breakpoint resolution location.

- [BSTR_ARRAY](../../../extensibility/debugger/reference/bstr-array.md) describes an array of strings.

- [BUILT_TYPE](../../../extensibility/debugger/reference/built-type.md) specifies information about a field type taken from metadata.

- [CODE_PATH](../../../extensibility/debugger/reference/code-path.md) describes a call to a function or method.

- [COMPUTER_INFO](../../../extensibility/debugger/reference/computer-info.md) describes the computer on which the debugger is running.

- [CONST_GUID_ARRAY](../../../extensibility/debugger/reference/const-guid-array.md) describes a list of GUIDs.

- [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md) describes a memory context or code context.

- [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md) describes an address in a program being debugged.

- [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md) represents one of a number of different kinds of addresses.

- [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md) identifies a custom viewer or type visualizer.

- [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md) describes a debug property that in turn describes an object of a hierarchical nature that has name, type, and value.

- [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md) describes a reference.

- [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md) describes disassembly to the IDE for display.

- [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md) describes an exception or run-time error thrown by the program being debugged.

- [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md) describes a local variable, parameter, or other field.

- [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md) describes a stack frame.

- [GUID_ARRAY](../../../extensibility/debugger/reference/guid-array.md) describes an array of unique identifiers for available debug engines.

- [JMC_CODE_SPEC](../../../extensibility/debugger/reference/jmc-code-spec.md) is used to set the JustMyCode information for a module.

- [MACHINE_INFO](../../../extensibility/debugger/reference/machine-info.md) describes a particular machine.

- [METADATA_ADDRESS_ARRAYELEM](../../../extensibility/debugger/reference/metadata-address-arrayelem.md) describes an array element within an array.

- [METADATA_ADDRESS_FIELD](../../../extensibility/debugger/reference/metadata-address-field.md) describes the address of a field of a class or structure.

- [METADATA_ADDRESS_LOCAL](../../../extensibility/debugger/reference/metadata-address-local.md) describes the address of a local variable within a scope (usually a function or method).

- [METADATA_ADDRESS_METHOD](../../../extensibility/debugger/reference/metadata-address-method.md) describes the address of a method of a class.

- [METADATA_ADDRESS_PARAM](../../../extensibility/debugger/reference/metadata-address-param.md) describes a parameter of a method or function.

- [METADATA_ADDRESS_RETVAL](../../../extensibility/debugger/reference/metadata-address-retval.md) describes a return value from a method or function.

- [METADATA_TYPE](../../../extensibility/debugger/reference/metadata-type.md) describes a field type taken from metadata.

- [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md) describes a particular module (DLL, EXE, or assembly).

- [MODULE_SYMBOL_SEARCH_INFO](../../../extensibility/debugger/reference/module-symbol-search-info.md) describes status information about symbol search paths that have been searched.

- [NATIVE_ADDRESS](../../../extensibility/debugger/reference/native-address.md) describes a native address.

- [PDB_TYPE](../../../extensibility/debugger/reference/pdb-type.md) describes a field type taken from a PDB symbol.

- [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md) describes the state of a breakpoint that is ready to bind to a code location.

- [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md) describes a process.

- [PROGRAM_NODE_ARRAY](../../../extensibility/debugger/reference/program-node-array.md) describes a list of [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) objects that represent program nodes.

- [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md) describes processes running on a machine.

- [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md) describes the line and column location in the given text.

- [THREADPROPERTIES](../../../extensibility/debugger/reference/threadproperties.md) describes the properties of a thread.

- [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md) describes a field's type.

- [UNMANAGED_ADDRESS_PHYSICAL](../../../extensibility/debugger/reference/unmanaged-address-physical.md) describes a physical address.

- [UNMANAGED_ADDRESS_THIS_RELATIVE](../../../extensibility/debugger/reference/unmanaged-address-this-relative.md) describes an address that is relative to a `this` pointer (`Me` in Visual Basic).

## Requirements
 Header: msdbg.h, sh.h, or ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [API Reference](../../../extensibility/debugger/reference/api-reference-visual-studio-debugging.md)
