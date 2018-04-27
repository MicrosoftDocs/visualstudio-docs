---
title: Class Designer errors
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: troubleshooting
f1_keywords:
  - "vs.classdesigner.CPlusPlusViewInDiagramNoTypeFound"
  - "vs.classdesigner.CPlusPlusNoTypeFound"
  - "vs.classdesigner.CannotShowBaseType"
  - "vs.classdesigner.MatchOrphanTypesAtLoad"
  - "vs.classdesigner.CannotShowType"
  - "vs.classdesigner.AssociationTypeNotFoundError"
  - "vs.classdesigner.ViewInDiagramNoTypesFound"
  - "vs.classdesigner.CannotImplementInterface"
  - "vs.classdesigner.CannotShowImplementedInterface"
  - "vs.classdesigner.ViewInDiagramUnparsableTypeFound"
  - "vs.classdesigner.AssociationTypeNotFound"
  - "vs.classdesigner.CPlusPlusTypeCannotBeAdded"
helpviewer_keywords:
  - "errors, class diagrams"
  - "errors, Class Designer"
  - "error messages, Class Designer"
  - "Class Designer [Visual Studio], errors"
  - "error messages, class diagrams"
  - "class diagrams, errors"
ms.assetid: 79d70e70-704c-4255-ab68-c10d6949470e
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Additional information about Class Designer errors

**Class Designer** does not track the location of your source files, so modifying your project structure or moving source files in the project can cause **Class Designer** to lose track of the type (especially the source type of a typedef, base classes, or association types). You might receive an error such as **Class Designer is unable to display this type**. If you do, drag the modified or relocated source code to the class diagram again to redisplay it.

## Resources

You can find assistance with other errors and warnings in the following resources:

- [Working with Visual C++ Code](working-with-visual-cpp-code.md) includes troubleshooting information about displaying C++ in a class diagram.
- [Visual Studio Class Designer forum](http://go.microsoft.com/fwlink/?LinkId=160754) provides a forum for questions about the **Class Designer**.

## See also

- [Designing and viewing classes and types](designing-and-viewing-classes-and-types.md)
