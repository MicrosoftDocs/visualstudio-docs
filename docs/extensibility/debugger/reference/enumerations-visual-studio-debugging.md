---
description: "Following are enumerations for the Visual Studio Debugging SDK."
title: Enumerations (Visual Studio Debugging)
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- enumerations [Visual Studio SDK]
- debugging [Debugging SDK], enumerations
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Enumerations (Visual Studio Debugging)

Following are enumerations for the Visual Studio Debugging SDK.

- [AD_PROCESS_ID_TYPE](../../../extensibility/debugger/reference/ad-process-id-type.md) specifies how to interpret a process ID in the [AD_PROCESS_ID](../../../extensibility/debugger/reference/ad-process-id.md) structure.

- [ADDRESS_KIND](../../../extensibility/debugger/reference/address-kind.md) specifies the types of an address.

- [ASSEMBLYLOCRESOLUTION](../../../extensibility/debugger/reference/assemblylocresolution.md) specifies where an assembly is located.

- [ATTACH_REASON](../../../extensibility/debugger/reference/attach-reason.md) specifies the reason for the debug engine (DE) to attach to a program node.

- [BP_COND_STYLE](../../../extensibility/debugger/reference/bp-cond-style.md) specifies the breakpoint condition style for pending and bound breakpoints.

- [BP_ERROR_TYPE](../../../extensibility/debugger/reference/bp-error-type.md) specifies the error type of a breakpoint.

- [BP_FLAGS](../../../extensibility/debugger/reference/bp-flags.md) provides optional flags that may be used to specify additional information when setting a breakpoint.

- [BP_FLAGS90](../../../extensibility/debugger/reference/bp-flags90.md) enumerates valid values for optional flags that may be used to specify additional information when setting a breakpoint. This enumeration extends the [BP_FLAGS](../../../extensibility/debugger/reference/bp-flags.md) enumeration.

- [BP_LOCATION_TYPE](../../../extensibility/debugger/reference/bp-location-type.md) specifies the location type of the breakpoint for a breakpoint request.

- [BP_PASSCOUNT_STYLE](../../../extensibility/debugger/reference/bp-passcount-style.md) specifies the condition associated with the breakpoint pass count that will cause the breakpoint to fire.

- [BP_RES_DATA_FLAGS](../../../extensibility/debugger/reference/bp-res-data-flags.md) specifies whether the data breakpoint is being emulated or implemented in hardware.

- [BP_STATE](../../../extensibility/debugger/reference/bp-state.md) specifies the existence of a bound breakpoint and whether it is enabled.

- [BP_TYPE](../../../extensibility/debugger/reference/bp-type.md) specifies whether the breakpoint is at a code location, is a data location, or is another type of breakpoint.

- [BP_UNBOUND_REASON](../../../extensibility/debugger/reference/bp-unbound-reason.md) gives the reason a breakpoint was unbound.

- [BPERESI_FIELDS](../../../extensibility/debugger/reference/bperesi-fields.md) specifies what information to retrieve about a failed resolution of a breakpoint.

- [BPREQI_FIELDS](../../../extensibility/debugger/reference/bpreqi-fields.md) specifies what information to retrieve about a breakpoint request.

- [BPREQI_FIELDS90](../../../extensibility/debugger/reference/bpreqi-fields90.md) enumerates the valid values that specify the information to be retrieved about a breakpoint request. This enumeration extends the [BPREQI_FIELDS](../../../extensibility/debugger/reference/bpreqi-fields.md) enumeration.

- [BPRESI_FIELDS](../../../extensibility/debugger/reference/bpresi-fields.md) specifies what information is to be retrieved about the successful resolution of a breakpoint.

- [CANSTOP_REASON](../../../extensibility/debugger/reference/canstop-reason.md) is used to determine if a program can stop execution after reaching a particular point in the execution.

- [CONNECTION_PROTOCOL](../../../extensibility/debugger/reference/connection-protocol.md) indicates the protocol being used to communicate between a debug server and the debug package.

- [CONSTRUCTOR_ENUM](../../../extensibility/debugger/reference/constructor-enum.md) selects different types of constructors.

- [CONTEXT_COMPARE](../../../extensibility/debugger/reference/context-compare.md) specifies the criteria for comparing two memory contexts.

- [CONTEXT_INFO_FIELDS](../../../extensibility/debugger/reference/context-info-fields.md) specifies what information to retrieve about a memory context.

- [DBG_ATTRIB_FLAGS](../../../extensibility/debugger/reference/dbg-attrib-flags.md) describes various attributes for an [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md) or an [IDebugReference2](../../../extensibility/debugger/reference/idebugreference2.md) interface.

- [DEBUG_REASON](../../../extensibility/debugger/reference/debug-reason.md) specifies why the process was launched for debugging.

- [DEBUGPROP_INFO_FLAGS](../../../extensibility/debugger/reference/debugprop-info-flags.md) specifies what information to retrieve about a debug property object.

- [DEBUGREF_INFO_FLAGS](../../../extensibility/debugger/reference/debugref-info-flags.md) specifies what information to retrieve about a debug reference object.

- [DISASSEMBLY_FLAGS](../../../extensibility/debugger/reference/disassembly-flags.md) specifies the flags for disassembly.

- [DISASSEMBLY_STREAM_FIELDS](../../../extensibility/debugger/reference/disassembly-stream-fields.md) specifies what information to retrieve about a disassembly field.

- [DISASSEMBLY_STREAM_SCOPE](../../../extensibility/debugger/reference/disassembly-stream-scope.md) specifies the scope of the disassembly stream.

- [DisplayKind](../../../extensibility/debugger/reference/displaykind.md) enumerates the valid values that represent the kinds of information to take from an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object and display to the user.

- [DOCCONTEXT_COMPARE](../../../extensibility/debugger/reference/doccontext-compare.md) specifies the criteria for comparing two document contexts.

- [DUMPTYPE](../../../extensibility/debugger/reference/dumptype.md) specifies how much of a program's state to dump.

- [dwTYPE_KIND](../../../extensibility/debugger/reference/dwtype-kind.md) specifies how to interpret the type of an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

- [EncUnavailableReason](../../../extensibility/debugger/reference/encunavailablereason.md) eepresents the reasons that Edit and Continue is not available.

- [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) specifies flags that control expression evaluation.

- [EVALFLAGS90](../../../extensibility/debugger/reference/evalflags90.md) enumerates the valid values for flags that control expression evaluation. This enumeration extends the [EVALFLAGS](../../../extensibility/debugger/reference/evalflags.md) enumeration.

- [EVENTATTRIBUTES](../../../extensibility/debugger/reference/eventattributes.md) specifies the event attributes.

- [EXCEPTION_STATE](../../../extensibility/debugger/reference/exception-state.md) specifies the exception state.

- [FIELD_INFO_FIELDS](../../../extensibility/debugger/reference/field-info-fields.md) specifies what information to retrieve about an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

- [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md) specifies the kind of field contained in an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object.

- [FIELD_KIND_EX](../../../extensibility/debugger/reference/field-kind-ex.md) enumerates additional kinds of fields an [IDebugField](../../../extensibility/debugger/reference/idebugfield.md) object can contain. This enumeration extends the [FIELD_KIND](../../../extensibility/debugger/reference/field-kind.md) enumeration.

- [FIELD_MODIFIERS](../../../extensibility/debugger/reference/field-modifiers.md) specifies modifiers for a field type.

- [FRAMEINFO_FLAGS](../../../extensibility/debugger/reference/frameinfo-flags.md) specifies the information to retrieve about a stack frame object.

- [GETHOSTNAME_TYPE](../../../extensibility/debugger/reference/gethostname-type.md) specifies the type of host name.

- [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md) specifies the name type of files to retrieve.

- [INTERCEPT_EXCEPTION_ACTION](../../../extensibility/debugger/reference/intercept-exception-action.md) specifies what actions to take when intercepting exceptions.

- [LAUNCH_FLAGS](../../../extensibility/debugger/reference/launch-flags.md) specifies how a program is to be launched.

- [MACHINE_INFO_FIELDS](../../../extensibility/debugger/reference/machine-info-fields.md) specifies what kind of information to retrieve for a particular machine.

- [MACHINE_INFO_FLAGS](../../../extensibility/debugger/reference/machine-info-flags.md) is used to describe a machine.

- [MESSAGETYPE](../../../extensibility/debugger/reference/messagetype.md) specifies the message type and reason.

- [MODULE_FLAGS](../../../extensibility/debugger/reference/module-flags.md) is used to describe a module.

- [MODULE_INFO_FIELDS](../../../extensibility/debugger/reference/module-info-fields.md) specifies the flags for the debug module information.

- [MODULE_INFO_FLAGS](../../../extensibility/debugger/reference/module-info-flags.md) specifies the state of symbols for a module.

- [NAME_MATCH](../../../extensibility/debugger/reference/name-match.md) selects the case option for matching names.

- [OBJECT_TYPE](../../../extensibility/debugger/reference/object-type.md) specifies the type of an object from the expression evaluator.

- [PARSEFLAGS](../../../extensibility/debugger/reference/parseflags.md) specifies how to parse an expression.

- [PENDING_BP_STATE](../../../extensibility/debugger/reference/pending-bp-state.md) specifies the state of a pending breakpoint (a breakpoint that has not yet been bound).

- [PENDING_BP_STATE_FLAGS](../../../extensibility/debugger/reference/pending-bp-state-flags.md) specifies the pending breakpoint state flags.

- [PORT_SUPPLIER_DESCRIPTION_FLAGS](../../../extensibility/debugger/reference/port-supplier-description-flags.md) defines the metadata that can be retrieved about a port supplier.

- [PROCESS_INFO_FIELDS](../../../extensibility/debugger/reference/process-info-fields.md) specifies what kind of information to retrieve for a process.

- [PROCESS_INFO_FLAGS](../../../extensibility/debugger/reference/process-info-flags.md) describes or specifies properties of a process.

- [PROGRAM_DESTROY_FLAGS](../../../extensibility/debugger/reference/program-destroy-flags.md) enumerates the valid values of the program destroy flags.

- [PROVIDER_FIELDS](../../../extensibility/debugger/reference/provider-fields.md) specifies properties associated with a program provider.

- [PROVIDER_FLAGS](../../../extensibility/debugger/reference/provider-flags.md) specifies desired properties to be obtained from a program provider.

- [REFERENCE_COMPARE](../../../extensibility/debugger/reference/reference-compare.md) specifies the type of comparison for references.

- [REFERENCE_TYPE](../../../extensibility/debugger/reference/reference-type.md) specifies the reference type.

- [SEEK_START](../../../extensibility/debugger/reference/seek-start.md) specifies the position from which to start seeking in a disassembly.

- [STEPKIND](../../../extensibility/debugger/reference/stepkind.md) specifies the step kind for stepping.

- [STEPUNIT](../../../extensibility/debugger/reference/stepunit.md) specifies the step unit for stepping.

- [SYMBOL_SEARCH_INFO_FIELDS](../../../extensibility/debugger/reference/symbol-search-info-fields.md) specifies what kind of symbol information to retrieve.

- [TEXT_DOC_ATTR_2](../../../extensibility/debugger/reference/text-doc-attr-2.md) describes the attributes of a document.

- [THREADPROPERTY_FIELDS](../../../extensibility/debugger/reference/threadproperty-fields.md) specifies what information about a thread that is to be retrieved.

- [THREADSTATE](../../../extensibility/debugger/reference/threadstate.md) specifies the state of the thread.

## Requirements
 Header: msdbg.h, sh.h, or ee.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll

## See also
- [API Reference](../../../extensibility/debugger/reference/api-reference-visual-studio-debugging.md)
