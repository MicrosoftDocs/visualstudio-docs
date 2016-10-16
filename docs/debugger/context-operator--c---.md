---
title: "Context Operator (C++)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.debug.operators"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "expressions [C++], native debugger"
  - "evaluation"
  - "format specifiers, expressions"
  - "context operator, in expressions"
  - "debugging [C++], expressions"
  - "native expression evaluator"
ms.assetid: 73cc9afe-f4a4-474e-bb89-5a33fb5e570c
caps.latest.revision: 23
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Context Operator (C++)
You can use the context operator in C++ to qualify a breakpoint location, variable name, or expression. The context operator is useful for specifying a name from an outer scope that is otherwise hidden by a local name.  
  
##  <a name="BKMK_Using_context_operators_to_specify_a_symbol"></a> Syntax  
 There are two ways of specifying context:  
  
1.  {,,[*module*] } *expression*  
  
     The braces must contain two commas and the module (executable or DLL) name or full path.  
  
     For example, to set a breakpoint at the `SomeFunction` function of EXAMPLE.dll:  
  
    ```cpp  
    {,,EXAMPLE.dll}SomeFunction  
    ```  
  
2.  *module*!*expression*  
  
    ```cpp  
    EXAMPLE.dll!SomeFunction  
    ```  
  
-   *module* is the name of a module. You can use a full path to disambiguate between modules with the same name.  
  
     If the *module* path includes a comma, an embedded space, or a brace, you must use quotation marks around the path so that the context parser can properly recognize the string. Single quotation marks are considered part of a Windows file name, so you must use double quotation marks. For example,  
  
    ```  
    {,"a long, long, library name.dll", } g_Var  
    ```  
  
-   *expression* is any valid C++ expression that resolves to a valid target, such as a function name, variable name, or pointer address in *module*.  
  
 When the expression evaluator encounters a symbol in an expression, it searches for the symbol in the following order:  
  
1.  Lexical scope outward, starting with the current block, series of statements enclosed in braces, and continuing outward with the enclosing block. The current block is the code containing the current location, instruction pointer address.  
  
2.  Function scope. The current function.  
  
3.  Class scope, if the current location is inside a C++ member function. Class scope includes all base classes. The expression evaluator uses the normal dominance rules.  
  
4.  Global symbols in the current module.  
  
5.  Public symbols in the current program.