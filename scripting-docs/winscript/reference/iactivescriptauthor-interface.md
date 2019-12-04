---
title: "IActiveScriptAuthor Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IActiveScriptAuthor interface"
ms.assetid: df1f454d-01ee-4beb-928b-48513d07365a
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IActiveScriptAuthor Interface
Represents authoring services, including IntelliSense and collation of information.  
  
 In addition to the methods inherited from `IUnknown`, the `IActiveScriptAuthor` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[IActiveScriptAuthor::AddNamedItem](../../winscript/reference/iactivescriptauthor-addnameditem.md)|Adds the name of a root-level item to the script authoring engine's namespace. A *root-level item* is an object that can contain properties and methods, and that can also contain an event source.|  
|[IActiveScriptAuthor::AddScriptlet](../../winscript/reference/iactivescriptauthor-addscriptlet.md)|Adds a code scriptlet as a child of the root level `IScriptNode` object. In the host, the fully qualified name of the scriptlet can have only two levels.|  
|[IActiveScriptAuthor::AddTypeLib](../../winscript/reference/iactivescriptauthor-addtypelib.md)|Adds a type library to the namespace for the script.|  
|[IActiveScriptAuthor::GetChars](../../winscript/reference/iactivescriptauthor-getchars.md)|Returns the set of completion characters for a requested completion context.|  
|[IActiveScriptAuthor::GetEventHandler](../../winscript/reference/iactivescriptauthor-geteventhandler.md)|Returns the scriptlet that has the specified attributes.|  
|[IActiveScriptAuthor::GetInfoFromContext](../../winscript/reference/iactivescriptauthor-getinfofromcontext.md)|Returns type information and anchor positions for a given character in a block of code. This provides information for member IntelliSense, global lists, and parameter tips.|  
|[IActiveScriptAuthor::GetLanguageFlags](../../winscript/reference/iactivescriptauthor-getlanguageflags.md)|Returns language information.|  
|[IActiveScriptAuthor::GetRoot](../../winscript/reference/iactivescriptauthor-getroot.md)|Returns the `IScriptNode` root of the author's script tree.|  
|[IActiveScriptAuthor::GetScriptletTextAttributes](../../winscript/reference/iactivescriptauthor-getscriptlettextattributes.md)|Returns the text attributes of a scriptlet.|  
|[IActiveScriptAuthor::GetScriptTextAttributes](../../winscript/reference/iactivescriptauthor-getscripttextattributes.md)|Returns the text attributes of a script block.|  
|[IActiveScriptAuthor::IsCommitChar](../../winscript/reference/iactivescriptauthor-iscommitchar.md)|Returns a value that indicates whether a given character should commit a statement completion by the application.|  
|[IActiveScriptAuthor::ParseScriptText](../../winscript/reference/iactivescriptauthor-parsescripttext.md)|Parses script text, adds the text to the authoring script authoring engine, and creates an `IScriptEntry` object that corresponds to the script block.|  
|[IActiveScriptAuthor::RemoveNamedItem](../../winscript/reference/iactivescriptauthor-removenameditem.md)|Removes a `NamedItem` object from the namespace of the script authoring engine.|  
|[IActiveScriptAuthor::RemoveTypeLib](../../winscript/reference/iactivescriptauthor-removetypelib.md)|Removes a type library from the script authoring engine namespace.|  
  
## See also  
 [Active Script Authoring Interfaces](../../winscript/reference/active-script-authoring-interfaces.md)