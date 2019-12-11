---
title: "IActiveScriptParse32::AddScriptlet | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: fcf11eb2-8e71-4cca-afda-a91791c243ff
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
---
# IActiveScriptParse32::AddScriptlet
Adds a code scriptlet to the script. This method is used in environments where the persistent state of the script is intertwined with the host document and the host is responsible for restoring the script, rather than through an `IPersist*` interface. The primary examples are HTML scripting languages that allow scriptlets of code embedded in the HTML document to be attached to intrinsic events (for instance, ONCLICK="button1.text='Exit'").  
  
## Syntax  
  
```cpp
HRESULT AddScriptlet(  
    LPCOLESTR pstrDefaultName,       // address of default name of scriptlet  
    LPCOLESTR pstrCode,              // address of scriptlet text  
    LPCOLESTR pstrItemName,          // address of item name  
    LPCOLESTR pstrSubItemName,       // address of subitem name  
    LPCOLESTR pstrEventName,         // address of event name  
    LPCOLESTR pstrDelimiter,         // address of end-of-scriptlet delimiter  
    DWORD_PTR dwSourceContextCookie, // application-defined value for debugging  
    ULONG ulStartingLineNumber,      // starting line of the script  
    DWORD dwFlags,                   // scriptlet flags  
    BSTR *pbstrName,                 // address of actual name of scriptlet  
    EXCEPINFO *pexcepinfo            // address of exception information  
);  
```  
  
#### Parameters  
 `pstrDefaultName`  
 [in] Address of a default name to associate with the scriptlet. If the scriptlet does not contain naming information (as in the ONCLICK example above), this name will be used to identify the scriptlet. If this parameter is `NULL`, the scripting engine manufactures a unique name, if necessary.  
  
 `pstrCode`  
 [in] Address of the scriptlet text to add. The interpretation of this string depends on the scripting language.  
  
 `pstrItemName`  
 [in] Address of a buffer that contains the item name associated with this scriptlet. This parameter, in addition to `pstrSubItemName`, identifies the object for which the scriptlet is an event handler.  
  
 `pstrSubItemName`  
 [in] Address of a buffer that contains the name of a `subobject` of the named item with which this scriptlet is associated; this name must be found in the named item's type information. This parameter is NULL if the scriptlet is to be associated with the named item instead of a `subitem`. This parameter, in addition to `pstrItemName`, identifies the specific object for which the scriptlet is an event handler.  
  
 `pstrEventName`  
 [in] Address of a buffer that contains the name of the event for which the scriptlet is an event handler.  
  
 `pstrDelimiter`  
 [in] Address of the end-of-scriptlet delimiter. When the `pstrCode` parameter is parsed from a stream of text, the host typically uses a delimiter, such as two single quotation marks (''), to detect the end of the scriptlet. This parameter specifies the delimiter that the host used, allowing the scripting engine to provide some conditional primitive preprocessing (for example, replacing a single quotation mark ['] with two single quotation marks for use as a delimiter). Exactly how (and if) the scripting engine makes use of this information depends on the scripting engine. Set this parameter to NULL if the host did not use a delimiter to mark the end of the scriptlet.  
  
 `dwSourceContextCookie`  
 [in] Application-defined value that is used for debugging purposes.  
  
 `ulStartingLineNumber`  
 [in] Zero-based value that specifies which line the parsing will begin at.  
  
 `dwFlags`  
 [in] Flags associated with the scriptlet. Can be a combination of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|SCRIPTTEXT_ISVISIBLE|Indicates that the script text should be visible (and, therefore, callable by name) as a global method in the name space of the script.|  
|SCRIPTTEXT_ISPERSISTENT|Indicates that the code added during this call should be saved if the scripting engine is saved (for example, through a call to `IPersist*::Save`), or if the scripting engine is reset by way of a transition back to the initialized state. For more information about this state, see Script Engine States.|  
  
 `pbstrName` ,  
 [out] Actual name used to identify the scriptlet. This is to be in order of preference: a name explicitly specified in the scriptlet text, the default name provided in `pstrDefaultName`, or a unique name synthesized by the scripting engine.  
  
 `pexcepinfo` ,  
 [out] Address of a structure containing exception information. This structure should be filled in if DISP_E_EXCEPTION is returned.  
  
## Return Value  
 Returns one of the following values:  
  
|Return Value|Meaning|  
|------------------|-------------|  
|`S_OK`|Success.|  
|`DISP_E_EXCEPTION`|An exception occurred in the parsing of the scriptlet. The `pexcepinfo` parameter contains information about the exception.|  
|`E_INVALIDARG`|An argument was invalid.|  
|`E_NOTIMPL`|This method is not supported; the scripting engine does not support adding event-sinking scriptlets.|  
|`E_POINTER`|An invalid pointer was specified.|  
|`E_UNEXPECTED`|The call was not expected (for example, the scripting engine has not yet been loaded or initialized) and therefore failed.|  
|`OLESCRIPT_E_INVALIDNAME`|The default name supplied is invalid in this scripting language.|  
|`OLESCRIPT_E_SYNTAX`|An unspecified syntax error occurred in the scriptlet.|  
  
## See also  
 [IActiveScriptParse32](../../winscript/reference/iactivescriptparse32.md)