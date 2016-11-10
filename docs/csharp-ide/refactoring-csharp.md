---
title: "Refactoring | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-csharp"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.csharp.refactoring.preview"
  - "vs.csharp.refactoring.issues"
  - "vs.csharp.refactoring.buildwarning"
  - "VS.PreviewChanges"
dev_langs: 
  - "CSharp"
helpviewer_keywords: 
  - "refactoring [C#]"
ms.assetid: a39e656a-f81f-4c87-b484-a23168ff1dfc
caps.latest.revision: 23
author: "BrianPeek"
ms.author: "brpeek"
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
# Refactoring
Refactoring is the process of improving your code after it has been written by changing the internal structure of the code without changing the external behavior of the code.  
  
Visual C# provides the following refactoring features:  
  
* [Change Method Signature](refactoring/change-method-signature.md)
* [Extract Interface](refactoring/extract-interface.md)
* [Extract Method](refactoring/extract-method.md)
* [Inline Temporary Variable](refactoring/inline-temporary-variable.md)
* [Move Type to Matching File](refactoring/move-type-to-matching-file.md)
* [Rename](refactoring/rename.md)

## Multi-Project Refactoring  
 Visual Studio supports multi-project refactoring for projects that are in the same solution. All of the refactoring operations that correct references across files correct those references across all projects of the same language. This works for any project-to-project references. For example, if you have a console application that references a class library, when you rename a class library type (using the `Rename` refactoring operation), the references to the class library type in the console application are also updated.  
  
## Changes Preview  
 Many refactoring operations provide an opportunity for you to review all the reference changes that a refactoring operation would perform on your code, before committing to those changes. For these refactoring operations, a **preview reference changes** option will appear in the refactoring dialog box. After selecting that option and accepting the refactoring operation, the **Preview Changes Dialog Box** will appear. Notice that the **Preview Changes** dialog box has two views. The bottom view will display your code with all the reference updates due to the refactoring operation. Pressing **Cancel** on the **Preview Changes** dialog box will stop the refactoring operation, and no changes will be made to your code.  
  
## Refactoring Warnings  
 If the compiler does not have a complete understanding of your program, and it is possible that the refactoring engine might not update all the appropriate references, the warning dialog box is displayed. This warning dialog box also provides an opportunity for you to preview your code in the **Preview Changes** dialog box before you commit changes.  
  
> [!NOTE]
>  If a method contains a syntax error (which the IDE indicates with a red wavy underline), then the refactoring engine will not update any references to an element within that method. The example below illustrates this behavior.  
  
 By default, if you execute a refactoring operation without previewing reference changes and a compilation error is detected in your program, then the development environment displays this warning dialog box.  
  
 If you execute a refactoring operation that has **Preview reference changes** enabled and a compilation error is detected in your program, then the development environment will display the following warning message at the bottom of the **Preview Changes** dialog box, in lieu of displaying the **Refactoring Warning** dialog box:  
  
 **Your project or one of its dependencies does not currently build. References may not be updated.**  
  
 This refactoring warning is only available for refactoring operations that provide the **Preview reference changes** option.  
  
## Error-Tolerant Refactoring and Verification Results  
 Refactoring is error tolerant. In other words, you can perform a refactoring in a project that cannot build. However, in these cases the refactoring process might not update ambiguous references correctly.  
  
 The **Verification Results** dialog box can notify you if the refactoring engine detects compile errors or discovers that a refactoring operation inadvertently causes a code reference to bind to something different from what it was originally bound to (rebinding issue).  
  
 To turn on the verification results feature, on the **Tools** menu, click **Options**. In the **Options** dialog box, expand **Text Editor**, and then expand **C#**. Click **Advanced** and select the **Verify results of refactoring** check box.  
  
 The **Verification Results** dialog box distinguishes the difference between two kinds of rebinding issues.  
  
### References whose definition will no longer be the renamed symbol  
 This kind of rebinding issue occurs when a reference no longer refers to a renamed symbol. For example, consider the following code:  
  
```cs  
class Example  
{  
    private int a;  
    public Example(int b)  
    {  
        a = b;  
    }  
}  
```  
  
 If you use refactoring to rename `a` to `b`, this dialog box appears. The reference to the renamed variable `a` now binds to the parameter that is passed to the constructor instead of binding to the field.  
  
### References whose definition will now become the renamed symbol  
 This kind of rebinding issue occurs when a reference that previously did not refer to the renamed symbol now does refer to the renamed symbol. For example, consider the following code:  
  
```cs
class Example  
{  
    private static void Method(object a) { }  
    private static void OtherMethod(int a) { }  
    static void Main(string[] args)  
    {  
        Method(5);  
    }  
}  
```  
  
 If you use refactoring to rename `OtherMethod` to `Method`, this dialog box appears. The reference in `Main` now refers to the overloaded method that accepts an `int` parameter instead of the overloaded method that accepts an `object` parameter.  
  
## See Also  
 [Using the Visual Studio Development Environment for C#](../csharp-ide/using-the-visual-studio-development-environment-for-csharp.md)   
 [How to: Restore C# Refactoring Snippets](../ide/how-to-restore-csharp-refactoring-snippets.md)