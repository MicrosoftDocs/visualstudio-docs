---
title: "Common Language Runtime and Expression Evaluation | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "debugging [Debugging SDK], expression evaluation"
  - "expression evaluation, and common language runtime"
ms.assetid: b36c1eb5-1aaf-48a6-b287-ee7a273d2b1c
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# Common Language Runtime and Expression Evaluation
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

> [!IMPORTANT]
> In Visual Studio 2015, this way of implementing expression evaluators is deprecated. For information about implementing CLR expression evaluators, please see [CLR Expression Evaluators](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/CLR-Expression-Evaluators) and [Managed Expression Evaluator Sample](https://github.com/Microsoft/ConcordExtensibilitySamples/wiki/Managed-Expression-Evaluator-Sample).  
  
 Compilers, such as Visual Basic and C# (pronounced C-sharp), that target the Common Language Runtime (CLR), produce Microsoft Intermediate Language (MSIL), which is later compiled to native code. The CLR provides a debug engine (DE) to debug the resulting code. If you plan to integrate your proprietary programming language into the Visual Studio IDE, you can choose to compile to MSIL and therefore will not have to write your own DE. However, you will have to write an expression evaluator (EE) that is capable of evaluating expressions within the context of your programming language.  
  
## Discussion  
 Computer language expressions are generally parsed to produce a set of data objects and a set of operators used to manipulate them. For example, the expression "A+B" might be parsed to apply the addition operator (+) to the data objects "A" and "B," possibly resulting in another data object. The total set of data objects, operators, and their associations are most often represented in a program as a tree, with the operators at the nodes of the tree and the data objects at the branches. An expression that has been broken down into tree form is often called a parsed tree.  
  
 Once an expression has been parsed, a symbol provider (SP) is called to evaluate each data object. For example, if "A" is defined both in more than one method, then the question "Which A?" must be answered before the value of A can be ascertained. The answer returned by the SP is something like "The third item on the fifth stack frame" or "The A that is 50 bytes beyond the start of the static memory allocated to this method."  
  
 Besides producing MSIL for the program itself, CLR compilers can also produce very descriptive debugging information that is written into a Program DataBase (.pdb) file. As long as a proprietary-language compiler produces debug information in the same format as the CLR compilers, the CLR's SP is able to identify that language's named data objects. Once a named data object has been identified, the EE uses a binder object to associate (or bind) the data object to the memory area that holds the value of that object. The DE can then get or set a new value for the data object.  
  
 A proprietary compiler can provide CLR debugging information by calling the `ISymbolWriter` interface (which is defined in the .NET Framework in the namespace `System.Diagnostics.SymbolStore`). By compiling to MSIL and writing debug information through these interfaces, a proprietary compiler can use the CLR DE and SP. This greatly simplifies integrating a proprietary language into the Visual Studio IDE.  
  
 When the CLR DE calls the proprietary EE to evaluate an expression, the DE supplies the EE with interfaces to an SP and a binder object. Thus, writing a CLR-based debug engine means it is necessary only to implement the appropriate expression evaluator interfaces; the CLR takes care of the binding and the symbol handling for you.  
  
## See Also  
 [Writing a CLR Expression Evaluator](../../extensibility/debugger/writing-a-common-language-runtime-expression-evaluator.md)
