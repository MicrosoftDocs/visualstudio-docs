---
title: "Enumerations (Visual Studio Debugging)"
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
  - "enumerations [Visual Studio SDK]"
  - "debugging [Debugging SDK], enumerations"
ms.assetid: 557065bf-081f-4d57-8744-bae02b8a5a6e
caps.latest.revision: 15
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
# Enumerations (Visual Studio Debugging)
Following are enumerations for the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Debugging SDK.  
  
 [AD_PROCESS_ID_TYPE](../extensibility/ad_process_id_type.md)  
 Specifies how to interpret a process ID in the [AD_PROCESS_ID](../extensibility/ad_process_id.md) structure.  
  
 [ADDRESS_KIND](../extensibility/address_kind.md)  
 Specifies the types of an address.  
  
 [ASSEMBLYLOCRESOLUTION](../extensibility/assemblylocresolution.md)  
 Specifies where an assembly is located.  
  
 [ATTACH_REASON](../extensibility/attach_reason.md)  
 Specifies the reason for the debug engine (DE) to attach to a program node.  
  
 [BP_COND_STYLE](../extensibility/bp_cond_style.md)  
 Specifies the breakpoint condition style for pending and bound breakpoints.  
  
 [BP_ERROR_TYPE](../extensibility/bp_error_type.md)  
 Specifies the error type of a breakpoint.  
  
 [BP_FLAGS](../extensibility/bp_flags.md)  
 Provides optional flags that may be used to specify additional information when setting a breakpoint.  
  
 [BP_FLAGS90](../extensibility/bp_flags90.md)  
 Enumerates valid values for optional flags that may be used to specify additional information when setting a breakpoint. This enumeration extends the [BP_FLAGS](../extensibility/bp_flags.md) enumeration.  
  
 [BP_LOCATION_TYPE](../extensibility/bp_location_type.md)  
 Specifies the location type of the breakpoint for a breakpoint request.  
  
 [BP_PASSCOUNT_STYLE](../extensibility/bp_passcount_style.md)  
 Specifies the condition associated with the breakpoint pass count that will cause the breakpoint to fire.  
  
 [BP_RES_DATA_FLAGS](../extensibility/bp_res_data_flags.md)  
 Specifies whether the data breakpoint is being emulated or implemented in hardware.  
  
 [BP_STATE](../extensibility/bp_state.md)  
 Specifies the existence of a bound breakpoint and whether it is enabled.  
  
 [BP_TYPE](../extensibility/bp_type.md)  
 Specifies whether the breakpoint is at a code location, is a data location, or is another type of breakpoint.  
  
 [BP_UNBOUND_REASON](../extensibility/bp_unbound_reason.md)  
 Gives the reason a breakpoint was unbound.  
  
 [BPERESI_FIELDS](../extensibility/bperesi_fields.md)  
 Specifies what information to retrieve about a failed resolution of a breakpoint.  
  
 [BPREQI_FIELDS](../extensibility/bpreqi_fields.md)  
 Specifies what information to retrieve about a breakpoint request.  
  
 [BPREQI_FIELDS90](../extensibility/bpreqi_fields90.md)  
 Enumerates the valid values that specify the information to be retrieved about a breakpoint request. This enumeration extends the [BPREQI_FIELDS](../extensibility/bpreqi_fields.md) enumeration.  
  
 [BPRESI_FIELDS](../extensibility/bpresi_fields.md)  
 Specifies what information is to be retrieved about the successful resolution of a breakpoint.  
  
 [CANSTOP_REASON](../extensibility/canstop_reason.md)  
 Used to determine if a program can stop execution after reaching a particular point in the execution.  
  
 [CONNECTION_PROTOCOL](../extensibility/connection_protocol.md)  
 A value that indicates the protocol being used to communicate between a debug server and the debug package.  
  
 [CONSTRUCTOR_ENUM](../extensibility/constructor_enum.md)  
 Selects different types of constructors.  
  
 [CONTEXT_COMPARE](../extensibility/context_compare.md)  
 Specifies the criteria for comparing two memory contexts.  
  
 [CONTEXT_INFO_FIELDS](../extensibility/context_info_fields.md)  
 Specifies what information to retrieve about a memory context.  
  
 [DBG_ATTRIB_FLAGS](../extensibility/dbg_attrib_flags.md)  
 Describes various attributes for an [IDebugProperty2](../extensibility/idebugproperty2.md) or an [IDebugReference2](../extensibility/idebugreference2.md) interface.  
  
 [DEBUG_REASON](../extensibility/debug_reason.md)  
 Specifies why the process was launched for debugging.  
  
 [DEBUGPROP_INFO_FLAGS](../extensibility/debugprop_info_flags.md)  
 Specifies what information to retrieve about a debug property object.  
  
 [DEBUGREF_INFO_FLAGS](../extensibility/debugref_info_flags.md)  
 Specifies what information to retrieve about a debug reference object.  
  
 [DISASSEMBLY_FLAGS](../extensibility/disassembly_flags.md)  
 Specifies the flags for disassembly.  
  
 [DISASSEMBLY_STREAM_FIELDS](../extensibility/disassembly_stream_fields.md)  
 Specifies what information to retrieve about a disassembly field.  
  
 [DISASSEMBLY_STREAM_SCOPE](../extensibility/disassembly_stream_scope.md)  
 Specifies the scope of the disassembly stream.  
  
 [DisplayKind](../extensibility/displaykind.md)  
 Enumerates the valid values that represent the kinds of information to take from an an [IDebugField](../extensibility/idebugfield.md) object and display to the user.  
  
 [DOCCONTEXT_COMPARE](../extensibility/doccontext_compare.md)  
 Specifies the criteria for comparing two document contexts.  
  
 [DUMPTYPE](../extensibility/dumptype.md)  
 Specifies how much of a program's state to dump.  
  
 [dwTYPE_KIND](../extensibility/dwtype_kind.md)  
 Specifies how to interpret the type of an [IDebugField](../extensibility/idebugfield.md) object.  
  
 [EncUnavailableReason](../extensibility/encunavailablereason.md)  
 Represents the reasons that Edit and Continue is not available.  
  
 [EVALFLAGS](../extensibility/evalflags.md)  
 Specifies flags that control expression evaluation.  
  
 [EVALFLAGS90](../extensibility/evalflags90.md)  
 Enumerates the valid values for flags that control expression evaluation. This enumeration extends the [EVALFLAGS](../extensibility/evalflags.md) enumeration.  
  
 [EVENTATTRIBUTES](../extensibility/eventattributes.md)  
 Specifies the event attributes.  
  
 [EXCEPTION_STATE](../extensibility/exception_state.md)  
 Specifies the exception state.  
  
 [FIELD_INFO_FIELDS](../extensibility/field_info_fields.md)  
 Specifies what information to retrieve about an [IDebugField](../extensibility/idebugfield.md) object.  
  
 [FIELD_KIND](../extensibility/field_kind.md)  
 Specifies the kind of field contained in an [IDebugField](../extensibility/idebugfield.md) object.  
  
 [FIELD_KIND_EX](../extensibility/field_kind_ex.md)  
 Enumerates additional kinds of fields an [IDebugField](../extensibility/idebugfield.md) object can contain. This enumeration extends the [FIELD_KIND](../extensibility/field_kind.md) enumeration.  
  
 [FIELD_MODIFIERS](../extensibility/field_modifiers.md)  
 Specifies modifiers for a field type.  
  
 [FRAMEINFO_FLAGS](../extensibility/frameinfo_flags.md)  
 Specifies the information to retrieve about a stack frame object.  
  
 [GETHOSTNAME_TYPE](../extensibility/gethostname_type.md)  
 Specifies the type of host name.  
  
 [GETNAME_TYPE](../extensibility/getname_type.md)  
 Specifies the name type of files to retrieve.  
  
 [INTERCEPT_EXCEPTION_ACTION](../extensibility/intercept_exception_action.md)  
 Specifies what actions to take when intercepting exceptions.  
  
 [LAUNCH_FLAGS](../extensibility/launch_flags.md)  
 Specifies how a program is to be launched.  
  
 [MACHINE_INFO_FIELDS](../extensibility/machine_info_fields.md)  
 Specifies what kind of information to retrieve for a particular machine.  
  
 [MACHINE_INFO_FLAGS](../extensibility/machine_info_flags.md)  
 Used to describe a machine.  
  
 [MESSAGETYPE](../extensibility/messagetype.md)  
 Specifies the message type and reason.  
  
 [MODULE_FLAGS](../extensibility/module_flags.md)  
 Used to describe a module.  
  
 [MODULE_INFO_FIELDS](../extensibility/module_info_fields.md)  
 Specifies the flags for the debug module information.  
  
 [MODULE_INFO_FLAGS](../extensibility/module_info_flags.md)  
 Specifies the state of symbols for a module.  
  
 [NAME_MATCH](../extensibility/name_match.md)  
 Selects the case option for matching names.  
  
 [OBJECT_TYPE](../extensibility/object_type.md)  
 Specifies the type of an object from the expression evaluator.  
  
 [PARSEFLAGS](../extensibility/parseflags.md)  
 Specifies how to parse an expression.  
  
 [PENDING_BP_STATE](../extensibility/pending_bp_state.md)  
 Specifies the state of a pending breakpoint (a breakpoint that has not yet been bound).  
  
 [PENDING_BP_STATE_FLAGS](../extensibility/pending_bp_state_flags.md)  
 Specifies the pending breakpoint state flags.  
  
 [PORT_SUPPLIER_DESCRIPTION_FLAGS](../extensibility/port_supplier_description_flags.md)  
 Defines the metadata that can be retrieved about a port supplier.  
  
 [PROCESS_INFO_FIELDS](../extensibility/process_info_fields.md)  
 Specified what kind of information to retrieve for a process.  
  
 [PROCESS_INFO_FLAGS](../extensibility/process_info_flags.md)  
 Describes or specifies properties of a process.  
  
 [PROGRAM_DESTROY_FLAGS](../extensibility/program_destroy_flags.md)  
 Enumerates the valid values of the program destroy flags.  
  
 [PROVIDER_FIELDS](../extensibility/provider_fields.md)  
 Specifies properties associated with a program provider.  
  
 [PROVIDER_FLAGS](../extensibility/provider_flags.md)  
 Specifies desired properties to be obtained from a program provider.  
  
 [REFERENCE_COMPARE](../extensibility/reference_compare.md)  
 Specifies the type of comparison for references.  
  
 [REFERENCE_TYPE](../extensibility/reference_type.md)  
 Specifies the reference type.  
  
 [SEEK_START](../extensibility/seek_start.md)  
 Specifies the position from which to start seeking in a disassembly.  
  
 [STEPKIND](../extensibility/stepkind.md)  
 Specifies the step kind for stepping.  
  
 [STEPUNIT](../extensibility/stepunit.md)  
 Specifies the step unit for stepping.  
  
 [SYMBOL_SEARCH_INFO_FIELDS](../extensibility/symbol_search_info_fields.md)  
 Specifies what kind of symbol information to retrieve.  
  
 [TEXT_DOC_ATTR_2](../extensibility/text_doc_attr_2.md)  
 Describes the attributes of a document.  
  
 [THREADPROPERTY_FIELDS](../extensibility/threadproperty_fields.md)  
 Specifies what information about a thread that is to be retrieved.  
  
 [THREADSTATE](../extensibility/threadstate.md)  
 Specifies the state of the thread.  
  
## Requirements  
 Header: msdbg.h, sh.h, or ee.h  
  
 Namespace: Microsoft.VisualStudio.Debugger.Interop  
  
 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll  
  
## See Also  
 [API Reference](../extensibility/api-reference--visual-studio-debugging-.md)