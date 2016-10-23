---
title: "CA2105: Array fields should not be read only"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 0bdc3421-3ceb-4182-b30c-a992fbfcc35d
caps.latest.revision: 16
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# CA2105: Array fields should not be read only
|||  
|-|-|  
|TypeName|ArrayFieldsShouldNotBeReadOnly|  
|CheckId|CA2105|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A public or protected field that holds an array is declared read-only.  
  
## Rule Description  
 When you apply the `readonly` (`ReadOnly` in Visual Basic) modifier to a field that contains an array, the field cannot be changed to refer to a different array. However, the elements of the array that are stored in a read-only field can be changed. Code that makes decisions or performs operations that are based on the elements of a read-only array that can be publicly accessed might contain an exploitable security vulnerability.  
  
 Note that having a public field also violates the design rule [CA1051: Do not declare visible instance fields](../VS_IDE/CA1051--Do-not-declare-visible-instance-fields.md).  
  
## How to Fix Violations  
 To fix the security vulnerability that is identified by this rule, do not rely on the contents of a read-only array that can be publicly accessed. It is strongly recommended that you use one of the following procedures:  
  
-   Replace the array with a strongly typed collection that cannot be changed. For more information, see <xref:System.Collections.ReadOnlyCollectionBase?qualifyHint=True>.  
  
-   Replace the public field with a method that returns a clone of a private array. Because your code does not rely on the clone, there is no danger if the elements are modified.  
  
 If you chose the second approach, do not replace the field with a property; properties that return arrays adversely affect performance. For more information, see [CA1819: Properties should not return arrays](../VS_IDE/CA1819--Properties-should-not-return-arrays.md).  
  
## When to Suppress Warnings  
 Exclusion of a warning from this rule is strongly discouraged. Almost no scenarios occur where the contents of a read-only field are unimportant. If this is the case with your scenario, remove the `readonly` modifier instead of excluding the message.  
  
## Example  
 This example demonstrates the dangers of violating this rule. The first part shows an example library that has a type, `MyClassWithReadOnlyArrayField`, that contains two fields (`grades` and `privateGrades`) that are not secure. The field `grades` is public, and therefore vulnerable to any caller. The field `privateGrades` is private but is still vulnerable because it is returned to callers by the `GetPrivateGrades` method. The `securePrivateGrades` field is exposed in a safe manner by the `GetSecurePrivateGrades` method. It is declared as private to follow good design practices. The second part shows code that changes values stored in the `grades` and `privateGrades` members.  
  
 The example class library appears in the following example.  
  
 [!CODE [FxCop.Security.ArrayFieldsNotReadOnly#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Security.ArrayFieldsNotReadOnly#1)]  
  
## Example  
 The following code uses the example class library to illustrate read-only array security issues.  
  
 [!CODE [FxCop.Security.TestArrayFieldsRead#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Security.TestArrayFieldsRead#1)]  
  
 The output from this example is:  
  
 **Before tampering: Grades: 90, 90, 90 Private Grades: 90, 90, 90  Secure Grades, 90, 90, 90**  
**After tampering: Grades: 90, 555, 90 Private Grades: 90, 555, 90  Secure Grades, 90, 90, 90**   
## See Also  
 <xref:System.Array?qualifyHint=True>   
 <xref:System.Collections.ReadOnlyCollectionBase?qualifyHint=True>