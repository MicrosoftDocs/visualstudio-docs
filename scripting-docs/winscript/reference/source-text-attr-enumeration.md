---
title: "SOURCE_TEXT_ATTR Enumeration | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "SOURCE_TEXT_ATTR constants"
ms.assetid: 459384b0-1463-4841-a2b3-a993207163bf
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# SOURCE_TEXT_ATTR Enumeration
Describe the attributes of a single character of source text.  
  
## Syntax  
  
```cpp  
enum enum_SOURCE_TEXT_ATTR{    SOURCETEXT_ATTR_KEYWORD    = 0x0001,    SOURCETEXT_ATTR_COMMENT    = 0x0002,    SOURCETEXT_ATTR_NONSOURCE    = 0x0004,    SOURCETEXT_ATTR_OPERATOR   = 0x0008,    SOURCETEXT_ATTR_NUMBER    = 0x0010,    SOURCETEXT_ATTR_STRING    = 0x0020,    SOURCETEXT_ATTR_FUNCTION_START  = 0x0040};  
```  
  
## Members  
  
|Member|Value|Description|  
|------------|-----------|-----------------|  
|SOURCETEXT_ATTR_KEYWORD|0x0001|The character is part of a language keyword, for example, the VBScript keyword `While`.|  
|SOURCETEXT_ATTR_COMMENT|0x0002|The character is part of a comment block.|  
|SOURCETEXT_ATTR_NONSOURCE|0x0004|The character is not part of compiled language source text. For example, the HTML surrounding a script block.|  
|SOURCETEXT_ATTR_OPERATOR|0x0008|The character is part of a language operator. For example:, the arithmetic operator **+**.|  
|SOURCETEXT_ATTR_NUMBER|0x0010|The character is part of a language numeric constant.  For example, the constant 3.14159.|  
|SOURCETEXT_ATTR_STRING|0x0020|The character is part of a language string constant. For example, the string "Hello World".|  
|SOURCETEXT_ATTR_FUNCTION_START|0x0040|The character indicates the start of a function block|  
  
## Remarks  
 Typically, the `IDebugDocumentHost::GetScriptTextAttributes`, `IActiveScriptDebug::GetScriptletTextAttributes`, and `IActiveScriptDebug::GetScriptTextAttributes` methods return one text attribute per character, unless:  
  
- The GETATTRTYPE_DEPSCAN flag is set, in which case the method may return the SOURCETEXT_ATTR_IDENTIFIER and SOURCETEXT_ATTR_MEMBERLOOKUP flags,  
  
- The GETATTRFLAG_THIS flag is set, in which case the method may return the SOURCETEXT_ATTR_THIS flag,  
  
- The GETATTRFLAG_HUMANTEXT flag is set, in which case the method may return the SOURCETEXT_ATTR_HUMANTEXT flag.  
  
## See also  
 [Active Script Debugger Constants, Enumerations, and Structures](../../winscript/reference/active-script-debugger-constants-enumerations-and-structures.md)