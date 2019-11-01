---
title: "CA2208: Instantiate argument exceptions correctly | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2208"
  - "InstantiateArgumentExceptionsCorrectly"
helpviewer_keywords:
  - "InstantiateArgumentExceptionsCorrectly"
  - "CA2208"
ms.assetid: e2a48939-d9fa-478c-b2f9-3bdbce07dff7
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2208: Instantiate argument exceptions correctly
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|InstantiateArgumentExceptionsCorrectly|
|CheckId|CA2208|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 Possible causes include the following situations:

- A call is made to the default (parameterless) constructor of an exception type that is, or derives from [System.ArgumentException](<!-- TODO: review code entity reference <xref:assetId:///System.ArgumentException?qualifyHint=True&amp;autoUpgrade=True>  -->).

- An incorrect string argument is passed to a parameterized constructor of an exception type that is, or derives from [System.ArgumentException.](<!-- TODO: review code entity reference <xref:assetId:///System.ArgumentException.?qualifyHint=True&amp;autoUpgrade=True>  -->)

## Rule Description
 Instead of calling the default constructor, call one of the constructor overloads that allows a more meaningful exception message to be provided. The exception message should target the developer and clearly explain the error condition and how to correct or avoid the exception.

 The signatures of the one and two string constructors of <xref:System.ArgumentException> and its derived types are not consistent with respect to the `message` and `paramName` parameters. Make sure these constructors are called with the correct string arguments. The signatures are as follows:

 <xref:System.ArgumentException>(string `message`)

 <xref:System.ArgumentException>(string `message`, string `paramName`)

 <xref:System.ArgumentNullException>(string `paramName`)

 <xref:System.ArgumentNullException>(string `paramName`, string `message`)

 <xref:System.ArgumentOutOfRangeException>(string `paramName`)

 <xref:System.ArgumentOutOfRangeException>(string `paramName`, string `message`)

 <xref:System.DuplicateWaitObjectException>(string `parameterName`)

 <xref:System.DuplicateWaitObjectException>(string `parameterName`, string `message`)

## How to Fix Violations
 To fix a violation of this rule, call a constructor that takes a message, a parameter name, or both, and make sure the arguments are proper for the type of <xref:System.ArgumentException> being called.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule only if a parameterized constructor is called with the correct string arguments.

## Example
 The following example shows a constructor that incorrectly instantiates an instance of the ArgumentNullException type.

 [!code-cpp[FxCop.Usage.InstantiateArgumentExceptionsCorrectly#1](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly/cpp/FxCop.Usage.InheritedPublic.cpp#1)]
 [!code-csharp[FxCop.Usage.InstantiateArgumentExceptionsCorrectly#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly/cs/FxCop.Usage.InheritedPublic.cs#1)]
 [!code-vb[FxCop.Usage.InstantiateArgumentExceptionsCorrectly#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly/vb/FxCop.Usage.InstantiateArgumentExceptionsCorrectly.vb#1)]

## Example
 The following example fixes the above violation by switching the constructor arguments.

 [!code-cpp[FxCop.Usage.InstantiateArgumentExceptionsCorrectly#2](../snippets/cpp/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly/cpp/FxCop.Usage.InheritedPublic.cpp#2)]
 [!code-csharp[FxCop.Usage.InstantiateArgumentExceptionsCorrectly#2](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly/cs/FxCop.Usage.InheritedPublic.cs#2)]
 [!code-vb[FxCop.Usage.InstantiateArgumentExceptionsCorrectly#2](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.InstantiateArgumentExceptionsCorrectly/vb/FxCop.Usage.InstantiateArgumentExceptionsCorrectly.vb#2)]
