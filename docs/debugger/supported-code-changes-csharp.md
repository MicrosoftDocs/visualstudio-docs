---
title: "Supported Code Changes (C#) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords: 
  - "Edit and Continue [C#], supported code changes"
ms.assetid: c7a48ea9-5a7f-4328-a9d7-f0e76fac399d
caps.latest.revision: 27
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
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
# Supported code changes (C#)
Edit and Continue handles most types of code changes within method bodies. Most changes outside method bodies, and a few changes within method bodies, cannot be applied during debugging, however. To apply those unsupported changes, you must stop debugging and restart with a fresh version of the code.

## Supported changes to C# code

The table below shows the changes that may be made to C# code during a debugging session without restarting the session.

|Language element/feature|Edit operation|Limitations|
|-|-|-|
|Types|Add methods, fields, constructors, et al|[Yes](https://github.com/dotnet/roslyn/wiki/EnC-Supported-Edits)|
|Iterators|Add or modify|No|
|async/await|Add or modify|[Yes](https://github.com/dotnet/roslyn/wiki/EnC-Supported-Edits)|
|Dynamic objects|Add or modify|No|
|C# 6.0 language features|Add or modify|No|
|lambda expressions|Add or modify|[Yes](https://github.com/dotnet/roslyn/wiki/EnC-Supported-Edits)|
|LINQ expressions|Add or modify|[Same as lambda](https://github.com/dotnet/roslyn/wiki/EnC-Supported-Edits)|

## Unsupported changes to C# code
 The following changes cannot be applied to C# code during a debugging session:  
  
-   Changes to the current statement or any other active statement.  
  
     Active statements include any statements, in functions on the call stack, that were called to get to the current statement.  
  
     The current statement is marked by a yellow background in the source window. Other active statements are marked by a shaded background and are read-only. These default colors can be changed in the **Options** dialog box.  
  
-   Changing the signature of a type.  
  
-   Adding an anonymous method that captures a variable that hasn't been captured before.  
  
-   Adding, removing, or changing attributes.  
  
-   Adding, removing, or changing `using` directives.  
  
-   Adding a `foreach`, `using`, or `lock` around the active statement.  




|Language element/feature|Edit operation|
|-|-|
|Methods|Modify signatures|
|Generics|Add or modify|
|Interfaces|Modify|
|Methods|Add method body|
|Types|Add abstract or virtual member, add override|
|Types|Add destructor|
|Events or properties|Modify a type parameter, base type, delegate type, or return type |
|Operators or indexers|Modify a type parameter, base type, delegate type, or return type |
|catch blocks|Modify when it contains an active statement|
|try-catch-finally blocks|Modify when it contains an active statement|
|All code elements|Renaming|
|Members, types, namespaces|Delete|
|Methods|Delete method bodies|
|using statements|Add|
|Namespaces|Add|
|Members (Visual Basic)|Edit member referencing an embedded interop type|
|Members (Visual Basic)|Edit member with On Error or Resume statement|
|async methods/lambdas|Edit an async method/lambda in a project that doesn't define or reference AsyncStateMachineAttribute type (e.g. projects targeting .NET Framework 4.0 and lower)|
|Iterators|Edit an iterator method/lambda in a project that doesn't define or reference IteratorStateMachineAttribute type (e.g. projects targeting .NET Framework 4.0 and lower)|
  
## Unsafe code  
 Changes to unsafe code have the same limitations as changes to safe code, with one additional restriction: Edit and Continue does not support changes to unsafe code that exits within a method that contains the `stackalloc` operator.  
  
## Unsupported scenarios  
 Edit and Continue is not available in the following debugging scenarios:  
  
-   Mixed-mode (native/managed) debugging.  
  
-   SQL debugging.  
  
-   Debugging a Dr. Watson dump.  
  
-   Editing code after an unhandled exception, when the "**Unwind the call stack on unhandled exceptions**" option is not selected.  
  
-   Debugging an embedded runtime application.  
  
-   Debugging an application that has **Attach to** instead of running the application by choosing **Start** from the **Debug** menu.  
  
-   Debugging optimized code.  
  
-   Debugging an old version of your code after a new version failed to build because of build errors.
  
## See Also  
 [Edit and Continue (Visual C#)](../debugger/edit-and-continue-visual-csharp.md)   
 [How to: Use Edit and Continue (C#)](../debugger/how-to-use-edit-and-continue-csharp.md)