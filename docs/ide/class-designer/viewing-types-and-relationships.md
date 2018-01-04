---
title: "Viewing Types and Relationships (Class Designer) | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.classdesigner.CannotShowBaseType"
helpviewer_keywords: 
  - "class diagrams"
  - "types [Visual Studio], visualizing"
  - "relationships, class diagrams"
  - "types [Visual Studio], class diagrams"
  - "relationships, visualizing"
ms.assetid: c4f46d94-9972-42ac-ae63-6ff306369965
caps.latest.revision: 33
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
ms.workload: 
  - "multiple"
---
# Viewing Types and Relationships (Class Designer)
Class Designer uses class diagrams to show you the details of types, for example, their constituent members, and the relationships that they share. The visualization of these entities is actually a dynamic view into the code. This means that you can edit types on the designer and then see your edits reflected in the source code of the entity. Similarly, the class diagram is kept synchronized with changes you make to entities in code.  
  
> [!NOTE]
>  If your project contains a class diagram and if your project references a type that is located in another project, the class diagram does not show the referenced type until you build the project for that type. Likewise, the diagram does not display changes to the code of the external entity until you rebuild the project for that entity. For information about type in referenced assemblies and read-only files, see [Display of Read-Only Information](http://msdn.microsoft.com/en-us/33e2d3a9-1668-4d10-ae56-fa09b3156e0a).
  
## See also
[Designing Classes and Types](designing-classes-and-types.md)  
[Refactoring Classes and Types](refactoring-classes-and-types.md)  
[How to: Customize Class Diagrams](how-to-customize-class-diagrams.md)  
[Working with Class Diagrams](working-with-class-diagrams.md)