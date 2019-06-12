---
title: "Structures and Unions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "structures [Visual Studio SDK]"
ms.assetid: 9ff0a8f8-1ee6-4fdd-8b80-206436ff589b
caps.latest.revision: 12
ms.author: gregvanl
manager: jillfra
---
# Structures and Unions
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

The following are structures and unions in the Visual Studio Debugging SDK.  
  
 [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md)  
 Specifies the process ID, which may be either a system ID or a GUID.  
  
 [BP_CONDITION](../../../extensibility/debugger/reference/bp-condition.md)  
 Describes the conditions under which a breakpoint will fire.  
  
 [BP_ERROR_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-error-resolution-info.md)  
 Describes the resolution of an error breakpoint, including location, program, and thread.  
  
 [BP_LOCATION](../../../extensibility/debugger/reference/bp-location.md)  
 Specifies the type of structure used to describe the location of the breakpoint.  
  
 [BP_LOCATION_CODE_ADDRESS](../../../extensibility/debugger/reference/bp-location-code-address.md)  
 Defines the components that describe the location of a breakpoint at an address in code.  
  
 [BP_LOCATION_CODE_CONTEXT](../../../extensibility/debugger/reference/bp-location-code-context.md)  
 Describes the location of a breakpoint that is bound directly to an address in the program being debugged.  
  
 [BP_LOCATION_CODE_FILE_LINE](../../../extensibility/debugger/reference/bp-location-code-file-line.md)  
 Describes the location of a breakpoint at line in a code source file.  
  
 [BP_LOCATION_CODE_FUNC_OFFSET](../../../extensibility/debugger/reference/bp-location-code-func-offset.md)  
 Describes the offset location of a breakpoint at a function in code.  
  
 [BP_LOCATION_CODE_STRING](../../../extensibility/debugger/reference/bp-location-code-string.md)  
 Used for setting code breakpoints based on a string that the user can enter from the IDE.  
  
 [BP_LOCATION_DATA_STRING](../../../extensibility/debugger/reference/bp-location-data-string.md)  
 Used for setting data breakpoints that are based on a string that the user can enter from the IDE.  
  
 [BP_LOCATION_RESOLUTION](../../../extensibility/debugger/reference/bp-location-resolution.md)  
 Describes the resolution of a breakpoint at a specific location.  
  
 [BP_PASSCOUNT](../../../extensibility/debugger/reference/bp-passcount.md)  
 Describes the count and conditions upon which a breakpoint will be fired after having been previously passed.  
  
 [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md)  
 Contains the information required to implement a breakpoint.  
  
 [BP_REQUEST_INFO2](../../../extensibility/debugger/reference/bp-request-info2.md)  
 Contains the information required to implement a breakpoint (same as the [BP_REQUEST_INFO](../../../extensibility/debugger/reference/bp-request-info.md) structure but includes vendor GUID, constraint and tracepoint information).  
  
 [BP_RESOLUTION_CODE](../../../extensibility/debugger/reference/bp-resolution-code.md)  
 Describes the location of a code breakpoint.  
  
 [BP_RESOLUTION_DATA](../../../extensibility/debugger/reference/bp-resolution-data.md)  
 Describes the result of binding a data breakpoint.  
  
 [BP_RESOLUTION_INFO](../../../extensibility/debugger/reference/bp-resolution-info.md)  
 Describes the bound breakpoint information for either a code breakpoint or a data breakpoint.  
  
 [BP_RESOLUTION_LOCATION](../../../extensibility/debugger/reference/bp-resolution-location.md)  
 Specifies the structure of the breakpoint resolution location.  
  
 [BSTR_ARRAY](../../../extensibility/debugger/reference/bstr-array.md)  
 Describes an array of strings.  
  
 [BUILT_TYPE](../../../extensibility/debugger/reference/built-type.md)  
 Specifies information about a field type taken from metadata.  
  
 [CODE_PATH](../../../extensibility/debugger/reference/code-path.md)  
 Describes a call to a function or method.  
  
 [COMPUTER_INFO](../../../extensibility/debugger/reference/computer-info.md)  
 Describes the computer on which the debugger is running.  
  
 [CONST_GUID_ARRAY](../../../extensibility/debugger/reference/const-guid-array.md)  
 Describes a list of GUIDs.  
  
 [CONTEXT_INFO](../../../extensibility/debugger/reference/context-info.md)  
 Describes a memory context or code context.  
  
 [DEBUG_ADDRESS](../../../extensibility/debugger/reference/debug-address.md)  
 Describes an address in a program being debugged.  
  
 [DEBUG_ADDRESS_UNION](../../../extensibility/debugger/reference/debug-address-union.md)  
 Represents one of a number of different kinds of addresses.  
  
 [DEBUG_CUSTOM_VIEWER](../../../extensibility/debugger/reference/debug-custom-viewer.md)  
 Identifies a custom viewer or type visualizer.  
  
 [DEBUG_PROPERTY_INFO](../../../extensibility/debugger/reference/debug-property-info.md)  
 Describes a debug property that in turn describes an object of a hierarchical nature that has name, type, and value.  
  
 [DEBUG_REFERENCE_INFO](../../../extensibility/debugger/reference/debug-reference-info.md)  
 Describes a reference.  
  
 [DisassemblyData](../../../extensibility/debugger/reference/disassemblydata.md)  
 Describes disassembly to the IDE for display.  
  
 [EXCEPTION_INFO](../../../extensibility/debugger/reference/exception-info.md)  
 Describes an exception or run-time error thrown by the program being debugged.  
  
 [FIELD_INFO](../../../extensibility/debugger/reference/field-info.md)  
 Describes a local variable, parameter, or other field.  
  
 [FRAMEINFO](../../../extensibility/debugger/reference/frameinfo.md)  
 Describes a stack frame.  
  
 [GUID_ARRAY](../../../extensibility/debugger/reference/guid-array.md)  
 Describes an array of unique identifiers for available debug engines.  
  
 [JMC_CODE_SPEC](../../../extensibility/debugger/reference/jmc-code-spec.md)  
 Used to set the JustMyCode information for a module.  
  
 [MACHINE_INFO](../../../extensibility/debugger/reference/machine-info.md)  
 Describes a particular machine.  
  
 [METADATA_ADDRESS_ARRAYELEM](../../../extensibility/debugger/reference/metadata-address-arrayelem.md)  
 Describes an array element within an array.  
  
 [METADATA_ADDRESS_FIELD](../../../extensibility/debugger/reference/metadata-address-field.md)  
 Describes the address of a field of a class or structure.  
  
 [METADATA_ADDRESS_LOCAL](../../../extensibility/debugger/reference/metadata-address-local.md)  
 Describes the address of a local variable within a scope (usually a function or method).  
  
 [METADATA_ADDRESS_METHOD](../../../extensibility/debugger/reference/metadata-address-method.md)  
 Describes the address of a method of a class.  
  
 [METADATA_ADDRESS_PARAM](../../../extensibility/debugger/reference/metadata-address-param.md)  
 Describes a parameter of a method or function.  
  
 [METADATA_ADDRESS_RETVAL](../../../extensibility/debugger/reference/metadata-address-retval.md)  
 Describes a return value from a method or function.  
  
 [METADATA_TYPE](../../../extensibility/debugger/reference/metadata-type.md)  
 Describes a field type taken from metadata.  
  
 [MODULE_INFO](../../../extensibility/debugger/reference/module-info.md)  
 Describes a particular module (DLL, EXE, or assembly).  
  
 [MODULE_SYMBOL_SEARCH_INFO](../../../extensibility/debugger/reference/module-symbol-search-info.md)  
 Describes status information about symbol search paths that have been searched.  
  
 [NATIVE_ADDRESS](../../../extensibility/debugger/reference/native-address.md)  
 Describes a native address.  
  
 [PDB_TYPE](../../../extensibility/debugger/reference/pdb-type.md)  
 Describes a field type taken from a PDB symbol.  
  
 [PENDING_BP_STATE_INFO](../../../extensibility/debugger/reference/pending-bp-state-info.md)  
 Describes the state of a breakpoint that is ready to bind to a code location.  
  
 [PROCESS_INFO](../../../extensibility/debugger/reference/process-info.md)  
 Describes a process.  
  
 [PROGRAM_NODE_ARRAY](../../../extensibility/debugger/reference/program-node-array.md)  
 Describes a list of [IDebugProgramNode2](../../../extensibility/debugger/reference/idebugprogramnode2.md) objects that represent program nodes.  
  
 [PROVIDER_PROCESS_DATA](../../../extensibility/debugger/reference/provider-process-data.md)  
 Describes processes running on a machine.  
  
 [TEXT_POSITION](../../../extensibility/debugger/reference/text-position.md)  
 Describes the line and column location in the given text.  
  
 [THREADPROPERTIES](../../../extensibility/debugger/reference/threadproperties.md)  
 Describes the properties of a thread.  
  
 [TYPE_INFO](../../../extensibility/debugger/reference/type-info.md)  
 Describes a field's type.  
  
 [UNMANAGED_ADDRESS_PHYSICAL](../../../extensibility/debugger/reference/unmanaged-address-physical.md)  
 Describes a physical address.  
  
 [UNMANAGED_ADDRESS_THIS_RELATIVE](../../../extensibility/debugger/reference/unmanaged-address-this-relative.md)  
 Describes an address that is relative to a `this` pointer (`Me` in Visual Basic).  
  
## Requirements  
 Header: msdbg.h, sh.h, or ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [API Reference](../../../extensibility/debugger/reference/api-reference-visual-studio-debugging.md)
