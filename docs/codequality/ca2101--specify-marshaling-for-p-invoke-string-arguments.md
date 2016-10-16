---
title: "CA2101: Specify marshaling for P-Invoke string arguments"
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
  - "SpecifyMarshalingForPInvokeStringArguments"
  - "CA2101"
helpviewer_keywords: 
  - "CA2101"
  - "SpecifyMarshalingForPInvokeStringArguments"
ms.assetid: 9d1abfc3-d320-41e0-9f6e-60cefe6ffe1b
caps.latest.revision: 19
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA2101: Specify marshaling for P/Invoke string arguments
|||  
|-|-|  
|TypeName|SpecifyMarshalingForPInvokeStringArguments|  
|CheckId|CA2101|  
|Category|Microsoft.Globalization|  
|Breaking Change|Non-breaking|  
  
## Cause  
 A platform invoke member allows for partially trusted callers, has a string parameter, and does not explicitly marshal the string.  
  
## Rule Description  
 When you convert from Unicode to ANSI, it is possible that not all Unicode characters can be represented in a specific ANSI code page. *Best-fit mapping* tries to solve this problem by substituting a character for the character that cannot be represented. The use of this feature can cause a potential security vulnerability because you cannot control the character that is chosen. For example, malicious code could intentionally create a Unicode string that contains characters that are not found in a particular code page, which are converted to file system special characters such as '..' or '/'. Note also that security checks for special characters frequently occur before the string is converted to ANSI.  
  
 Best-fit mapping is the default for the unmanaged conversion, WChar to MByte. Unless you explicitly disable best-fit mapping, your code might contain an exploitable security vulnerability because of this issue.  
  
## How to Fix Violations  
 To fix a violation of this rule, explicitly marshal string data types.  
  
## When to Suppress Warnings  
 Do not suppress a warning from this rule.  
  
## Example  
 The following example shows a method that violates this rule, and then shows how to fix the violation.  
  
 [!code[FxCop.Security.PinvokeAnsiUnicode#1](../codequality/codesnippet/CSharp/ca2101--specify-marshaling-for-p-invoke-string-arguments_1.cs)]