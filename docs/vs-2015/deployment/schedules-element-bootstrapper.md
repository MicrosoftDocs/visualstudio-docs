---
title: "&lt;Schedules&gt; Element (Bootstrapper) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-deployment"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "<Schedules> element [bootstrapper]"
ms.assetid: 28d094cf-64f5-42b1-bd8a-3697082aab4f
caps.latest.revision: 7
author: mikejo5000
ms.author: mikejo
manager: jillfra
---
# &lt;Schedules&gt; Element (Bootstrapper)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The `Schedules` element contains `Schedule` elements, which define specific times at which commands defined by the `Command` element should be run.  
  
## Syntax  
  
```  
<Schedules>  
    <Schedule  
        Name  
    >  
        <BuildList />  
        <BeforePackage />  
        <AfterPackage />  
    </Schedule>  
</Schedules>  
```  
  
## Elements and Attributes  
 The `Schedules` element is a child of the `Product` element. Each `Product` element might have at most one `Schedules` element. The `Schedules` element has no attributes.  
  
## Schedule  
 The `Schedule` element is a child of the `Schedules` element. A `Schedules` element must have at least one `Schedule` element.  
  
 `Schedule` has the following attribute.  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Name`|Required. The name of the schedule item. This corresponds to the `ScheduleName` property of the `Command` element. When a `Command` references the named schedule, it will only be executed at the time indicated by that `Schedule` element. Schedules may also be associated with the `FailIf` and `BypassIf` elements, which restrict these conditional tests to executing on the specified schedule. For more information, see [\<Commands> Element](../deployment/commands-element-bootstrapper.md).|  
  
 A given `Schedule` element may have exactly one of the following children.  
  
## BuildList  
 The `BuildList` element instructs the installer to execute a command immediately after the bootstrapping application is started.  
  
## BeforePackage  
 The `BeforePackage` element instructs the installer to execute a command before the specified package is installed.  
  
## AfterPackage  
 The `AfterPackage` element instructs the installer to execute a command after the specified package is installed.  
  
## See also  
 [\<Product> Element](../deployment/product-element-bootstrapper.md)   
 [Product and Package Schema Reference](../deployment/product-and-package-schema-reference.md)
