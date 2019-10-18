---
title: "Viewing Types and Relationships (Class Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.CannotShowBaseType"
helpviewer_keywords:
  - "class diagrams"
  - "types [Visual Studio], visualizing"
  - "relationships, class diagrams"
  - "types [Visual Studio], class diagrams"
  - "relationships, visualizing"
ms.assetid: c4f46d94-9972-42ac-ae63-6ff306369965
caps.latest.revision: 37
author: jillre
ms.author: jillfra
manager: jillfra
---
# Viewing Types and Relationships (Class Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Class Designer uses class diagrams to show you the details of types, for example, their constituent members, and the relationships that they share. The visualization of these entities is actually a dynamic view into the code. This means that you can edit types on the designer and then see your edits reflected in the source code of the entity. Similarly, the class diagram is kept synchronized with changes you make to entities in code.

> [!NOTE]
> If your project contains a class diagram and if your project references a type that is located in another project, the class diagram does not show the referenced type until you build the project for that type. Likewise, the diagram does not display changes to the code of the external entity until you rebuild the project for that entity. For information about type in referenced assemblies and read-only files, see [Display of Read-Only Information (Class Designer)](https://msdn.microsoft.com/33e2d3a9-1668-4d10-ae56-fa09b3156e0a).

## In This Section
 [How to: View Existing Types (Class Designer)](../ide/how-to-view-existing-types-class-designer.md)

 Describes how Class Designer can be used to visualize pre-existing code.

 [How to: View Inheritance Between Types (Class Designer)](../ide/how-to-view-inheritance-between-types-class-designer.md)

 Describes how to view the inheritance relationships between types.

 [How to: Change Between Member Notation and Association Notation (Class Designer)](../ide/how-to-change-between-member-notation-and-association-notation-class-designer.md)

 Describes how to switch between member notation and association notation.

## Related Sections
 [Designing Classes and Types (Class Designer)](../ide/designing-classes-and-types-class-designer.md)

 [Refactoring Classes and Types (Class Designer)](../ide/refactoring-classes-and-types-class-designer.md)

 [How to: Customize Class Diagrams (Class Designer)](../ide/how-to-customize-class-diagrams-class-designer.md)

 [Working with Class Diagrams (Class Designer)](../ide/working-with-class-diagrams-class-designer.md)
