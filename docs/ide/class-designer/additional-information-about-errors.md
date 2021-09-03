---
title: Class Designer errors
description: Learn how to resolve Class Design errors by dragging the modified or relocated source code to the class diagram again to display it.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: troubleshooting
f1_keywords:
- vs.classdesigner.CPlusPlusViewInDiagramNoTypeFound
- vs.classdesigner.CPlusPlusNoTypeFound
- vs.classdesigner.CannotShowBaseType
- vs.classdesigner.MatchOrphanTypesAtLoad
- vs.classdesigner.CannotShowType
- vs.classdesigner.AssociationTypeNotFoundError
- vs.classdesigner.ViewInDiagramNoTypesFound
- vs.classdesigner.CannotImplementInterface
- vs.classdesigner.CannotShowImplementedInterface
- vs.classdesigner.ViewInDiagramUnparsableTypeFound
- vs.classdesigner.AssociationTypeNotFound
- vs.classdesigner.CPlusPlusTypeCannotBeAdded
helpviewer_keywords:
- errors, class diagrams
- errors, Class Designer
- error messages, Class Designer
- error messages, class diagrams
- Class Designer [Visual Studio], errors
- class diagrams, errors
ms.assetid: 79d70e70-704c-4255-ab68-c10d6949470e
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# Class Designer errors

**Class Designer** does not track the location of your source files, so modifying your project structure or moving source files in the project can cause **Class Designer** to lose track of the type, For example, it's common to modify the source type of a typedef, base classes, and association types. You might receive an error such as **Class Designer is unable to display this type**. To resolve the error, drag the modified or relocated source code to the class diagram again to display it.

## Resources

You can find assistance with other errors and warnings in the following resources:

- [Work with Visual C++ code](working-with-visual-cpp-code.md) includes troubleshooting information about displaying C++ in a class diagram.
- [Visual Studio Class Designer forum](https://social.msdn.microsoft.com/Forums/en-US/home?forum=vsclassdesigner) provides a forum for questions about **Class Designer**.

## See also

- [Design and view classes and types](designing-and-viewing-classes-and-types.md)
