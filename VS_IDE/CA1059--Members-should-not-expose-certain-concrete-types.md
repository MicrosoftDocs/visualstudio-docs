---
title: "CA1059: Members should not expose certain concrete types"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 59f61f52-8d6c-49cb-aefb-191910523a3c
caps.latest.revision: 18
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
# CA1059: Members should not expose certain concrete types
|||  
|-|-|  
|TypeName|MembersShouldNotExposeCertainConcreteTypes|  
|CheckId|CA1059|  
|Category|Microsoft.Design|  
|Breaking Change|Breaking|  
  
## Cause  
 An externally visible member is a certain concrete type or exposes certain concrete types through one of its parameters or return value. Currently, this rule reports exposure of the following concrete types:  
  
-   A type derived from <xref:System.Xml.XmlNode?qualifyHint=True>.  
  
## Rule Description  
 A concrete type is a type that has a complete implementation and therefore can be instantiated. To allow widespread use of the member, replace the concrete type with the suggested interface. This allows the member to accept any type that implements the interface or be used where a type that implements the interface is expected.  
  
 The following table lists the targeted concrete types and their suggested replacements.  
  
|Concrete type|Replacement|  
|-------------------|-----------------|  
|<xref:System.Xml.XPath.XPathDocument?qualifyHint=False>|<xref:System.Xml.XPath.IXPathNavigable?qualifyHint=True>.<br /><br /> Using the interface decouples the member from a specific implementation of an XML data source.|  
  
## How to Fix Violations  
 To fix a violation of this rule, change the concrete type to the suggested interface.  
  
## When to Suppress Warnings  
 It is safe to suppress a message from this rule if the specific functionality provided by the concrete type is required.  
  
## Related Rules  
 [CA1011: Consider passing base types as parameters](../VS_IDE/CA1011--Consider-passing-base-types-as-parameters.md)