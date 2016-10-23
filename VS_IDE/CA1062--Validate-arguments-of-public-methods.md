---
title: "CA1062: Validate arguments of public methods"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: db1f69ca-68f7-477e-94f3-d135cc5dfcbc
caps.latest.revision: 27
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# CA1062: Validate arguments of public methods
|||  
|-|-|  
|TypeName|ValidateArgumentsOfPublicMethods|  
|CheckId|CA1062|  
|Category|Microsoft.Design|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An externally visible method dereferences one of its reference arguments without verifying whether that argument is `null` (`Nothing` in Visual Basic).  
  
## Rule Description  
 All reference arguments that are passed to externally visible methods should be checked against `null`. If appropriate, throw a <xref:System.ArgumentNullException?qualifyHint=False> when the argument is `null`.  
  
 If a method can be called from an unknown assembly because it is declared public or protected, you should validate all parameters of the method. If the method is designed to be called only by known assemblies, you should make the method internal and apply the <xref:System.Runtime.CompilerServices.InternalsVisibleToAttribute?qualifyHint=False> attribute to the assembly that contains the method.  
  
## How to Fix Violations  
 To fix a violation of this rule, validate each reference argument against `null`.  
  
## When to Suppress Warnings  
 You can suppress a warning from this rule if you are sure that the dereferenced parameter has been validated by another method call in the function.  
  
## Example  
 The following example shows a method that violates the rule and a method that satisfies the rule.  
  
 [!CODE [FxCop.Design.ValidateArguments#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.ValidateArguments#1)]  
  
## Example  
 In Visual Studio 2005, this rule does not detect that parameters are being passed to another method that does the validation.  
  
 [!CODE [FxCop.Design.ValidateArguments#2](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Design.ValidateArguments#2)]  
  
## Example  
 Copy constructors that populate field or properties that are reference objects can also violate the CA1062 rule. The violation occurs because the copied object that is passed to the copy constructor might be `null` (`Nothing` in Visual Basic). To resolve the violation, use a static (Shared in Visual Basic) method to check that the copied object is not null.  
  
 In the following `Person` class example, the `other` object that is passed to the `Person` copy constructor might be `null`.  
  
```  
  
public class Person  
{  
    public string Name { get; private set; }  
    public int Age { get; private set; }  
  
    public Person(string name, int age)  
    {  
        Name = name;  
        Age = age;  
    }  
  
    // Copy constructor CA1062 fires because other is dereferenced  
    // without being checked for null  
    public Person(Person other)  
        : this(other.Name, other.Age)  
    {  
    }  
}  
  
```  
  
## Example  
 In the following revised `Person` example, the `other` object that is passed to the copy constructor is first checked for null in the `PassThroughNonNull` method.  
  
```  
public class Person  
{  
    public string Name { get; private set; }  
    public int Age { get; private set; }  
  
    public Person(string name, int age)  
    {  
        Name = name;  
        Age = age;  
    }  
  
    // Copy constructor  
    public Person(Person other)  
        : this(PassThroughNonNull(other).Name,   
          PassThroughNonNull(other).Age)  
    {   
    }  
  
    // Null check method  
    private static Person PassThroughNonNull(Person person)  
    {  
        if (person == null)  
            throw new ArgumentNullException("person");  
        return person;  
    }  
}  
  
```