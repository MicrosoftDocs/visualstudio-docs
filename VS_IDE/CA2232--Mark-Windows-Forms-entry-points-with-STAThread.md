---
title: "CA2232: Mark Windows Forms entry points with STAThread"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a3c95130-8e7f-4419-9fcd-b67d077e8efb
caps.latest.revision: 16
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
# CA2232: Mark Windows Forms entry points with STAThread
|||  
|-|-|  
|TypeName|MarkWindowsFormsEntryPointsWithStaThread|  
|CheckId|CA2232|  
|Category|Microsoft.Usage|  
|Breaking Change|Non Breaking|  
  
## Cause  
 An assembly references the <xref:System.Windows.Forms?qualifyHint=False> namespace, and its entry point is not marked with the <xref:System.STAThreadAttribute?qualifyHint=True> attribute.  
  
## Rule Description  
 <xref:System.STAThreadAttribute?qualifyHint=False> indicates that the COM threading model for the application is single-threaded apartment. This attribute must be present on the entry point of any application that uses Windows Forms; if it is omitted, the Windows components might not work correctly. If the attribute is not present, the application uses the multithreaded apartment model, which is not supported for Windows Forms.  
  
> [!NOTE]
>  Visual Basic projects that use the Application Framework do not have to mark the **Main** method with STAThread. The Visual Basic compiler does it automatically.  
  
## How to Fix Violations  
 To fix a violation of this rule, add the <xref:System.STAThreadAttribute?qualifyHint=False> attribute to the entry point. If the <xref:System.MTAThreadAttribute?qualifyHint=True> attribute is present, remove it.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if you are developing for the .NET Compact Framework, for which the <xref:System.STAThreadAttribute?qualifyHint=False> attribute is unnecessary and not supported.  
  
## Example  
 The following examples demonstrate the correct usage of <xref:System.STAThreadAttribute?qualifyHint=False>.  
  
 [!CODE [FxCop.Usage.StaThread#1](../CodeSnippet/VS_Snippets_CodeAnalysis/FxCop.Usage.StaThread#1)]