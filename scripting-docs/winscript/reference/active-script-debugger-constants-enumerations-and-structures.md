---
title: "Active Script Debugger Constants, Enumerations, and Structures | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "Active Script Debugger structures"
  - "Active Script Debugger enumerations"
  - "Active Script Debugger constants"
ms.assetid: b80b9207-fb19-4ee2-85fb-41f8c26e7706
caps.latest.revision: 13
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Active Script Debugger Constants, Enumerations, and Structures
The following constants, enumerations, and structures are used by the Active Debugging interfaces.  
  
## Constants, Enumerations, and Structures  
  
|Constants|Description|  
|---------------|-----------------|  
|[APPBREAKFLAGS Constants](../../winscript/reference/appbreakflags-enumeration.md)|Indicate the current debug state for applications and threads.|  
|[DEBUG_TEXT Constants](../../winscript/reference/debug-text-constants.md)|Option flags used during [IDebugExpressionContext::ParseLanguageText](../../winscript/reference/idebugexpressioncontext-parselanguagetext.md).|  
|[TEXT_DOC_ATTR Constants](../../winscript/reference/text-doc-attr-constants.md)|Describe the attributes of the document.|  
  
|Enumerations|Description|  
|------------------|-----------------|  
|[APPBREAKFLAGS Constants](../../winscript/reference/appbreakflags-enumeration.md)|Indicate the current debug state for applications and threads.|  
|[APPLICATION_NODE_EVENT_FILTER Enumeration](../../winscript/reference/application-node-event-filter-enumeration.md)|Indicate the nodes to be excluded with a filter.|  
|[BREAKPOINT_STATE Enumeration](../../winscript/reference/breakpoint-state-enumeration.md)|Indicates the state of a breakpoint.|  
|[BREAKREASON Enumeration](../../winscript/reference/breakreason-enumeration.md)|Indicates what caused the break.|  
|[BREAKRESUMEACTION Enumeration](../../winscript/reference/breakresumeaction-enumeration.md)|Describes how to continue from a breakpoint.|  
|[DOCUMENTNAMETYPE Enumeration](../../winscript/reference/documentnametype-enumeration.md)|Describes which type to get for a document.|  
|[ERRORRESUMEACTION Enumeration](../../winscript/reference/errorresumeaction-enumeration.md)|Describes how to continue from a runtime error.|  
|[JS_PROPERTY_ATTRIBUTES Enumeration](../../winscript/reference/js-property-attributes-enumeration.md)|Indicates the attributes of a property.|  
|[JS_PROPERTY_MEMBERS Enumeration](../../winscript/reference/js-property-members-enumeration.md)|Flags to specify the type of information to return in a request for members of an object.|  
|[JsDebugReadMemoryFlags Enumeration](../../winscript/reference/jsdebugreadmemoryflags-enumeration.md)|Flags to specify behavior when reading memory.|  
|[SCRIPT_DEBUGGER_OPTIONS Enumeration](../../winscript/reference/script-debugger-options-enumeration.md)|Indicates a set of options or capabilities that apply to the attached debugger.|  
|[SCRIPT_ERROR_DEBUG_EXCEPTION_THROWN_KIND Enumeration](../../winscript/reference/script-error-debug-exception-thrown-kind-enumeration.md)|Indicates the thrown exception kind.|  
|[SOURCE_TEXT_ATTR Constants](../../winscript/reference/source-text-attr-enumeration.md)|Describe the attributes of a single character of source text.|  
  
|Structures|Description|  
|----------------|-----------------|  
|[DebugStackFrameDescriptor Structure](../../winscript/reference/debugstackframedescriptor-structure.md)|Enumerates stack frames and merges output from several enumerators on the same thread.|  
|[JS_NATIVE_FRAME Structure](../../winscript/reference/js-native-frame-structure.md)|Represents a stack frame.|  
|[JsDebugPropertyInfo Structure](../../winscript/reference/jsdebugpropertyinfo-structure.md)|Indicates information about a property.|  
|[TEXT_DOCUMENT_ARRAY Structure](../../winscript/reference/text-document-array-structure.md)|Provides a set of documents.|