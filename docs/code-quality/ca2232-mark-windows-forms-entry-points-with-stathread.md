---
title: "CA2232: Mark Windows Forms entry points with STAThread | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "MarkWindowsFormsEntryPointsWithStaThread"
  - "CA2232"
helpviewer_keywords: 
  - "CA2232"
  - "MarkWindowsFormsEntryPointsWithStaThread"
ms.assetid: a3c95130-8e7f-4419-9fcd-b67d077e8efb
caps.latest.revision: 16
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# CA2232: Mark Windows Forms entry points with STAThread
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
>  [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] projects that use the Application Framework do not have to mark the **Main** method with STAThread. The [!INCLUDE[vbprvb](../code-quality/includes/vbprvb_md.md)] compiler does it automatically.  
  
## How to Fix Violations  
 To fix a violation of this rule, add the <xref:System.STAThreadAttribute> attribute to the entry point. If the <xref:System.MTAThreadAttribute?displayProperty=fullName> attribute is present, remove it.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if you are developing for the .NET Compact Framework, for which the <xref:System.STAThreadAttribute> attribute is unnecessary and not supported.  
  
## Example  
 The following examples demonstrate the correct usage of <xref:System.STAThreadAttribute>.  
  
 [!code-cs[FxCop.Usage.StaThread#1](../code-quality/codesnippet/CSharp/ca2232-mark-windows-forms-entry-points-with-stathread_1.cs)]
 [!code-vb[FxCop.Usage.StaThread#1](../code-quality/codesnippet/VisualBasic/ca2232-mark-windows-forms-entry-points-with-stathread_1.vb)]