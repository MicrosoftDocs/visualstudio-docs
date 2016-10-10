---
title: "CA2208: Instantiate argument exceptions correctly"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: e2a48939-d9fa-478c-b2f9-3bdbce07dff7
caps.latest.revision: 19
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
# CA2208: Instantiate argument exceptions correctly
|||  
|-|-|  
|TypeName|InstantiateArgumentExceptionsCorrectly|  
|CheckId|CA2208|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 Possible causes include the following situations:  
  
-   A call is made to the default (parameterless) constructor of an exception type that is, or derives from [System.ArgumentException](assetId:///System.ArgumentException?qualifyHint=True&autoUpgrade=True).  
  
-   An incorrect string argument is passed to a parameterized constructor of an exception type that is, or derives from [System.ArgumentException.](assetId:///System.ArgumentException.?qualifyHint=True&autoUpgrade=True)  
  
## Rule Description  
 Instead of calling the default constructor, call one of the constructor overloads that allows a more meaningful exception message to be provided. The exception message should target the developer and clearly explain the error condition and how to correct or avoid the exception.  
  
 The signatures of the one and two string constructors of <xref:System.ArgumentException?qualifyHint=False> and its derived types are not consistent with respect to the `message` and `paramName` parameters. Make sure these constructors are called with the correct string arguments. The signatures are as follows:  
  
 <xref:System.ArgumentException?qualifyHint=False>(string `message`)  
  
 <xref:System.ArgumentException?qualifyHint=False>(string `message`, string `paramName`)  
  
 <xref:System.ArgumentNullException?qualifyHint=False>(string `paramName`)  
  
 <xref:System.ArgumentNullException?qualifyHint=False>(string `paramName`, string `message`)  
  
 <xref:System.ArgumentOutOfRangeException?qualifyHint=False>(string `paramName`)  
  
 <xref:System.ArgumentOutOfRangeException?qualifyHint=False>(string `paramName`, string `message`)  
  
 <xref:System.DuplicateWaitObjectException?qualifyHint=False>(string `parameterName`)  
  
 <xref:System.DuplicateWaitObjectException?qualifyHint=False>(string `parameterName`, string `message`)  
  
## How to Fix Violations  
 To fix a violation of this rule, call a constructor that takes a message, a parameter name, or both, and make sure the arguments are proper for the type of <xref:System.ArgumentException?qualifyHint=False> being called.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule only if a parameterized constructor is called with the correct string arguments.  
  
## Example  
 The following example shows a constructor that incorrectly instantiates an instance of the ArgumentNullException type.  
  
 [!CODE [FxCop.Usage.InstantiateArgumentExceptionsCorrectly#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly#1)]  
  
## Example  
 The following example fixes the above violation by switching the constructor arguments.  
  
 [!CODE [FxCop.Usage.InstantiateArgumentExceptionsCorrectly#2](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly#2)]