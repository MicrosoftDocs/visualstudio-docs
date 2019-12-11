---
title: "CA2212: Do not mark serviced components with WebMethod | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "CA2212"
  - "DoNotMarkServicedComponentsWithWebMethod"
helpviewer_keywords:
  - "CA2212"
  - "DoNotMarkServicedComponentsWithWebMethod"
ms.assetid: 774bc55d-e588-48ee-8f38-c228580feca2
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA2212: Do not mark serviced components with WebMethod
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|DoNotMarkServicedComponentsWithWebMethod|
|CheckId|CA2212|
|Category|Microsoft.Usage|
|Breaking Change|Breaking|

## Cause
 A method in a type that inherits from <xref:System.EnterpriseServices.ServicedComponent?displayProperty=fullName> is marked with <xref:System.Web.Services.WebMethodAttribute?displayProperty=fullName>.

## Rule Description
 <xref:System.Web.Services.WebMethodAttribute> applies to methods within an XML Web service that were created by using ASP.NET; it makes the method callable from remote Web clients. The method and class must be public and executing in an ASP.NET Web application. <xref:System.EnterpriseServices.ServicedComponent> types are hosted by COM+ applications and can use COM+ services. <xref:System.Web.Services.WebMethodAttribute> is not applied to <xref:System.EnterpriseServices.ServicedComponent> types because they are not intended for the same scenarios. Specifically, adding the attribute to the <xref:System.EnterpriseServices.ServicedComponent> method does not make the method callable from remote Web clients. Because <xref:System.Web.Services.WebMethodAttribute> and a <xref:System.EnterpriseServices.ServicedComponent> method have conflicting behaviors and requirements for context and transaction flow, the behavior of the method will be incorrect in some scenarios.

## How to Fix Violations
 To fix a violation of this rule, remove the attribute from the <xref:System.EnterpriseServices.ServicedComponent> method.

## When to Suppress Warnings
 Do not suppress a warning from this rule. There are no scenarios where combining these elements is correct.

## See Also
 <xref:System.EnterpriseServices.ServicedComponent?displayProperty=fullName>
 <xref:System.Web.Services.WebMethodAttribute?displayProperty=fullName>
