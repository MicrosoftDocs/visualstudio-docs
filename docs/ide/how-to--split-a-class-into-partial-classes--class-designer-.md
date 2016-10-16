---
title: "How to: Split a Class into Partial Classes (Class Designer)"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Class Designer, partial classes"
  - "partial classes, Class Designer"
ms.assetid: 6f6b0b30-3996-4569-9200-20482b3adf90
caps.latest.revision: 10
ms.author: "kempb"
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
# How to: Split a Class into Partial Classes (Class Designer)
You can divide the declaration of a class or structure among several declarations by using the `Partial` keyword in Visual Basic or the `partial` keyword in Visual C#. You can use as many partial declarations as you want, in as many different source files as you want, or in one source file. However, all the declarations must be in the same assembly and the same namespace.  
  
 Partial classes are useful in several situations. For example, when you are working on large projects, separating a class into more than one file enables more than one programmer to work on it at the same time. When you are working with code that Visual Studio generates, you can change the class without having to re-create the source file. (Examples of code that Visual Studio generates include Windows Forms and Web Service wrapper code.) You can thus create code that uses auto-generated classes without having to modify the file that Visual Studio creates.  
  
 There are two kinds of partial methods. In Visual C#, they are called declaring and implementing; in Visual Basic, they are called declaration and implementation.  
  
 Class Designer supports partial classes and methods. The type shape in the class diagram refers to a single declaration location for the partial class. If the partial class is defined in multiple files, you can specify which declaration location Class Designer will use by setting the **New Member Location** property in the **Properties** window. That is, when you double-click a class shape, Class Designer goes to the source file that contains the class declaration identified by the **New Member Location** property. When you double-click a partial method in a class shape, Class Designer goes to the partial method declaration. Also, in the **Properties** window, the **File Name** property refers to the declaration location. For partial classes, **File Name** lists all of the files that contain declaration and implementation code for that class. However, for partial methods, **File Name** lists only the file that contains the partial method declaration.  
  
 The following examples split the definition of class `Employee` into two declarations, each of which defines a different procedure. The two partial definitions in the examples could be in one source file or in two different source files.  
  
> [!NOTE]
>  Visual Basic uses partial-class definitions to separate Visual Studio—generated code from user-authored code. The code is separated into discrete source files. For example, the **Windows Form Designer** defines partial classes for controls such as `Form`. You should not modify the generated code in these controls.  
  
 For more information about partial types in Visual Basic, see [Partial](../Topic/Partial%20\(Visual%20Basic\).md).  
  
## Example  
 To split a class definition in Visual Basic, use the `Partial` keyword, as shown in the following example.  
  
```vb#  
' First part of class definition.  
Partial Public Class Employee  
    Public Sub CalculateWorkHours()  
    End Sub  
End Class  
  
' Second part of class definition.  
Partial Public Class Employee  
    Public Sub CalculateTaxes()  
    End Sub  
End Class  
```  
  
## Example  
 To split a class definition in Visual C#, use the `partial` keyword, as shown in the following example.  
  
```c#  
// First part of class definition.  
public partial class Employee  
{  
    public void CalculateWorkHours()  
    {  
    }  
}  
  
// Second part of class definition.  
public partial class Employee  
{  
    public void CalculateTaxes()  
    {  
    }  
}  
```  
  
## See Also  
 [Partial Classes and Methods](../Topic/Partial%20Classes%20and%20Methods%20\(C%23%20Programming%20Guide\).md)   
 [partial (Type)](../Topic/partial%20\(Type\)%20\(C%23%20Reference\).md)   
 [partial (Method) (C# Reference)](../Topic/partial%20\(Method\)%20\(C%23%20Reference\).md)   
 [Partial](../Topic/Partial%20\(Visual%20Basic\).md)