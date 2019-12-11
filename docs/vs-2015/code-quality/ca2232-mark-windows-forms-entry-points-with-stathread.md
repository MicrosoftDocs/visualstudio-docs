---
title: "CA2232: Mark Windows Forms entry points with STAThread | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "MarkWindowsFormsEntryPointsWithStaThread"
  - "CA2232"
helpviewer_keywords:
  - "CA2232"
  - "MarkWindowsFormsEntryPointsWithStaThread"
ms.assetid: a3c95130-8e7f-4419-9fcd-b67d077e8efb
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2232: Mark Windows Forms entry points with STAThread
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|MarkWindowsFormsEntryPointsWithStaThread|
|CheckId|CA2232|
|Category|Microsoft.Usage|
|Breaking Change|Non Breaking|

## Cause
 An assembly references the <xref:System.Windows.Forms> namespace, and its entry point is not marked with the <xref:System.STAThreadAttribute?displayProperty=fullName> attribute.

## Rule Description
 <xref:System.STAThreadAttribute> indicates that the COM threading model for the application is single-threaded apartment. This attribute must be present on the entry point of any application that uses Windows Forms; if it is omitted, the Windows components might not work correctly. If the attribute is not present, the application uses the multithreaded apartment model, which is not supported for Windows Forms.

> [!NOTE]
> [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] projects that use the Application Framework do not have to mark the **Main** method with STAThread. The [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] compiler does it automatically.

## How to Fix Violations
 To fix a violation of this rule, add the <xref:System.STAThreadAttribute> attribute to the entry point. If the <xref:System.MTAThreadAttribute?displayProperty=fullName> attribute is present, remove it.

## When to Suppress Warnings
 It is safe to suppress a warning from this rule if you are developing for the .NET Compact Framework, for which the <xref:System.STAThreadAttribute> attribute is unnecessary and not supported.

## Example
 The following examples demonstrate the correct usage of <xref:System.STAThreadAttribute>.

 [!code-csharp[FxCop.Usage.StaThread#1](../snippets/csharp/VS_Snippets_CodeAnalysis/FxCop.Usage.StaThread/cs/FxCop.Usage.StaThread.cs#1)]
 [!code-vb[FxCop.Usage.StaThread#1](../snippets/visualbasic/VS_Snippets_CodeAnalysis/FxCop.Usage.StaThread/vb/FxCop.Usage.StaThread.vb#1)]
