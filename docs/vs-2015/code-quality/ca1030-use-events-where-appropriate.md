---
title: "CA1030: Use events where appropriate | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-code-analysis
ms.topic: reference
f1_keywords:
  - "UseEventsWhereAppropriate"
  - "CA1030"
helpviewer_keywords:
  - "CA1030"
  - "UseEventsWhereAppropriate"
ms.assetid: ea051367-deeb-40f9-9b65-eb818f1e133a
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: "wpickett"
---
# CA1030: Use events where appropriate
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

|||
|-|-|
|TypeName|UseEventsWhereAppropriate|
|CheckId|CA1030|
|Category|Microsoft.Design|
|Breaking Change|Non-breaking|

## Cause
 A public, protected, or private method name begins with one of the following:

- AddOn

- RemoveOn

- Fire

- Raise

## Rule Description
 This rule detects methods that have names that ordinarily would be used for events. Events follow the Observer or Publish-Subscribe design pattern; they are used when a state change in one object must be communicated to other objects. If a method gets called in response to a clearly defined state change, the method should be invoked by an event handler. Objects that call the method should raise events instead of calling the method directly.

 Some common examples of events are found in user interface applications where a user action such as clicking a button causes a segment of code to execute. The [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] event model is not limited to user interfaces; it should be used anywhere you must communicate state changes to one or more objects.

## How to Fix Violations
 If the method is called when the state of an object changes, you should consider changing the design to use the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] event model.

## When to Suppress Warnings
 Suppress a warning from this rule if the method does not work with the [!INCLUDE[dnprdnshort](../includes/dnprdnshort-md.md)] event model.
