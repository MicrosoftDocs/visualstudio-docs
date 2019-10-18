---
title: Use Class Designer
ms.date: 05/08/2018
ms.topic: conceptual
f1_keywords:
  - "vs.classdesigner.diagram"
helpviewer_keywords:
  - "Class Designer [Visual Studio]"
  - "Class Designer, about Class Designer"
  - "types [Visual Studio], viewing"
  - "classes [Visual Studio], viewing"
  - "class designer"
ms.assetid: 40ed2c9d-0ce0-4b95-ad78-5dec2065ccea
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Design and view classes and types with Class Designer

Design, visualize, and refactor classes and other types in your code with **Class Designer** in Visual Studio. Use class diagrams to create and edit classes in your C#, Visual Basic, or C++ project. You can also use class diagrams to understand your project structure better or reorganize your code.

## What you can do with class diagrams

- **Design**: Edit your project's code by editing the class diagram. Add new elements and delete unwanted ones. Your changes are reflected in code.

- **Visualize**: Understand your project's structure by viewing the classes in your project on a diagram. Customize your diagram so that you can focus on the project details that you care about the most. Save your diagram to use later for demonstration or documentation.

- **Refactor**: Override methods, rename identifiers, refactor parameters, and implement interfaces and abstract classes.

## View types and relationships

Class diagrams show the details of types, for example, their constituent members, and the relationships between them. The visualization of these entities is a dynamic view into the code. This means that you can edit types in the designer and then see your edits reflected in the source code of the entity. Similarly, the class diagram is kept in sync with changes you make to code files.

> [!NOTE]
> If your project contains a class diagram and your project references a type that's located in another project, the class diagram does not show the referenced type until you build the project for that type. Likewise, the diagram does not display changes to the code of the external entity until you rebuild the project for that entity.

## Class diagram workflow

Class diagrams can help you understand the class structure of projects. These projects might have been created by other developers, or you just need a refresher on a project you created yourself. You can use class diagrams to customize, share, and present project information with others.

The first step in presenting project information is to create a class diagram that displays what you want to show. For more information, see [Add a class diagram](how-to-add-class-diagrams-to-projects.md). You can create multiple class diagrams for a project that can be used to display a distinct view of the project, a chosen subset of the project's types, or a chosen subset of the members of types.

In addition to defining what each class diagram shows, you can also change the way that information is presented; for more information, see [How to: Customize class diagrams](how-to-customize-class-diagrams.md).

After you have fine-tuned one or more class diagrams, you can copy them into Microsoft Office documents and print them, or export them as image files. For more information, see [How to: Copy class diagram elements to a Microsoft Office document](how-to-copy-class-diagram-elements-to-a-microsoft-office-document.md), [How to: Print class diagrams](how-to-print-class-diagrams.md) and [How to: Export class diagrams as images](how-to-export-class-diagrams-as-images.md).

> [!NOTE]
> Class Designer does not track the location of your source files, so changing your project structure or moving source files in the project can cause Class Designer to lose track of the type, especially the source type of a typedef, base classes, or association types. You might get an error, like **Class Designer is unable to display this type**. If you do, drag the modified or relocated source code to the class diagram again to redisplay it.

## See also

- [Features of the code editor](../writing-code-in-the-code-and-text-editor.md)
- [Map dependencies across your solutions](../../modeling/map-dependencies-across-your-solutions.md)