---
title: "CA2103: Review imperative security | Microsoft Docs"
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
  - "CA2103"
  - "ReviewImperativeSecurity"
helpviewer_keywords: 
  - "CA2103"
  - "ReviewImperativeSecurity"
ms.assetid: d24fde71-bdf6-46c0-8965-9a73dc33c1aa
caps.latest.revision: 18
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
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
# CA2103: Review imperative security
|||  
|-|-|  
|TypeName|ReviewImperativeSecurity|  
|CheckId|CA2103|  
|Category|Microsoft.Security|  
|Breaking Change|Breaking|  
  
## Cause  
 A method uses imperative security and might be constructing the permission by using state information or return values that can change as long as the demand is active.  
  
## Rule Description  
 Imperative security uses managed objects to specify permissions and security actions during code execution, compared to declarative security, which uses attributes to store permissions and actions in metadata. Imperative security is very flexible because you can set the state of a permission object and select security actions by using information that is not available until run time. Together with that flexibility comes the risk that the runtime information that you use to determine the state of a permission does not remain unchanged as long as the action is in effect.  
  
 Use declarative security whenever possible. Declarative demands are easier to understand.  
  
## How to Fix Violations  
 Review the imperative security demands to make sure that the state of the permission does not rely on information that can change as long as the permission is being used.  
  
## When to Suppress Warnings  
 It is safe to suppress a warning from this rule if the permission does not rely on changing data. However, it is better to change the imperative demand to its declarative equivalent.  
  
## See Also  
 [Secure Coding Guidelines](../Topic/Secure%20Coding%20Guidelines.md)   
 [Data and Modeling](../Topic/Data%20and%20Modeling%20in%20the%20.NET%20Framework.md)