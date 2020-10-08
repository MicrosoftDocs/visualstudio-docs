---
title: "Attach reference strings to UML model elements | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
helpviewer_keywords:
  - "UML - extending, reference strings"
ms.assetid: 15dbed99-efce-42fe-a768-714a5804e7d1
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: jillfra
---
# Attach reference strings to UML model elements
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can write code to attach arbitrary strings to model elements. A string could be, for example, a URI, the cached result of a computation, or a ModelBus reference to an element in another model. Each string is contained in an IReference object. Any number of IReference objects can be attached to each model element.

 Every IReference object has a Name. You could use this Name to indicate how the reference value should be interpreted. For example, you could set Name to "URI" to indicate that the Value should be interpreted as a URI. There are some predefined reference name values used by the modeling tools.

## Attaching a Reference to an IElement
 To use the following methods, you must add a reference to:

 Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll

 You should insert this directive in your code:

 `using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;`

|Method call|Description|
|-----------------|-----------------|
|`element.AddReference (nameString, valueString, duplicatesAllowed)`|Creates an `IReference` with the given name and value strings, and links it to `element`. Returns the `IReference`.<br /><br /> Throws an exception if `duplicatesAllowed` is false and there is already an `IReference` with the same name attached to `element`.|
|`element.GetReferences(name)`|Returns all the `IReference` objects linked to `element` that have the given `name`.|
|`element.DeleteAllReferences(name)`|Deletes all the `IReference` objects linked to element that have the given name.|
|`reference.Delete()`|Deletes this `IReference`.|
|`ReferenceConstants.WorkItem`|The value used to name work item references.|

## See Also
 [Define a work item link handler](../modeling/define-a-work-item-link-handler.md)
 [Define and install a modeling extension](../modeling/define-and-install-a-modeling-extension.md)
 [Programming with the UML API](../modeling/programming-with-the-uml-api.md)
