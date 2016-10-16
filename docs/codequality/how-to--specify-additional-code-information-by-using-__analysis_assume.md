---
title: "How to: Specify Additional Code Information by Using __analysis_assume"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "__analysis_assume"
helpviewer_keywords: 
  - "__analysis_assume"
ms.assetid: 51205d97-4084-4cf4-a5ed-3eeaf67deb1b
caps.latest.revision: 10
ms.author: "douge"
manager: "douge"
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
# How to: Specify Additional Code Information by Using __analysis_assume
You can provide hints to the code analysis tool for C/C++ code that will help the analysis process and reduce warnings. To provide additional information, use the following function:  
  
 `__analysis_assume(`  `expr`  `)`  
  
 `expr` - any expression that is assumed to evaluate to true.  
  
 The code analysis tool assumes that the condition represented by the expression is true at the point where the function appears and remains true until expression is altered, for example, by assignment to a variable.  
  
> [!NOTE]
>  `__analysis_assume` does not impact code optimization. Outside the code analysis tool, `__analysis_assume` is defined as a no-op.  
  
## Example  
 The following code uses `__analysis_assume` to correct the code analysis warning [C6388](../codequality/c6388.md):  
  
```  
#include<windows.h>  
#include<codeanalysis\sourceannotations.h>  
  
using namespace vc_attributes;  
  
// calls free and sets ch to null  
void FreeAndNull(char* ch);  
  
//requires pc to be null  
void f([Pre(Null=Yes)] char* pc);  
  
void test( )  
{  
  char *pc = (char*)malloc(5);  
  FreeAndNull(pc);  
  __analysis_assume(pc == NULL);   
  f(pc);  
}  
```  
  
## See Also  
 [__assume](../Topic/__assume.md)