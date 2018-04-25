---
title: Viewing Types and Relationships (Class Designer)
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.CannotShowBaseType"
helpviewer_keywords:
  - "class diagrams"
  - "types [Visual Studio], visualizing"
  - "relationships, class diagrams"
  - "types [Visual Studio], class diagrams"
  - "relationships, visualizing"
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# View types and relationships (Class Designer)

**Class Designer** uses class diagrams to show you the details of types, for example, their constituent members, and the relationships that they share. The visualization of these entities is actually a dynamic view into the code. This means that you can edit types on the designer and then see your edits reflected in the source code of the entity. Similarly, the class diagram is kept synchronized with changes you make to entities in code.

> [!NOTE]
> If your project contains a class diagram and if your project references a type that is located in another project, the class diagram does not show the referenced type until you build the project for that type. Likewise, the diagram does not display changes to the code of the external entity until you rebuild the project for that entity.

## See also

- [Designing and Viewing Classes and Types](designing-and-viewing-classes-and-types.md)
- [Refactoring Classes and Types](refactoring-classes-and-types.md)
- [How to: Customize Class Diagrams](how-to-customize-class-diagrams.md)
- [Working with Class Diagrams](working-with-class-diagrams.md)