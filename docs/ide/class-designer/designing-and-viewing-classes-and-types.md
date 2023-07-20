---
title: Use Class Designer
description: Learn how to design, visualize, and refactor classes and other types in your code with Class Designer in Visual Studio.
ms.date: 05/08/2018
ms.topic: conceptual
f1_keywords:
- vs.classdesigner.diagram
- vs.classdesigner.enum
helpviewer_keywords:
- Class Designer [Visual Studio]
- Class Designer, about Class Designer
- types [Visual Studio], viewing
- classes [Visual Studio], viewing
- class designer
ms.assetid: 40ed2c9d-0ce0-4b95-ad78-5dec2065ccea
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
ms.workload:
- multiple
---
# What is Class Designer?

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

With the **Class Designer** tool in Visual Studio, you can design, visualize, and refactor class diagrams in C#, Visual Basic, or C++ projects. Class diagrams show the code elements and their relationships in a visual design surface, which can help you better understand your project structure and reorganize your code.

> [!NOTE]
> Class Designer is not available in .NET Core projects.

## About class diagrams

Here's what you can do with class diagrams, in more detail:

- **Design**: Edit your project's code by editing the class diagram. Add new elements and delete unwanted ones. Your changes are reflected in code.

- **Visualize**: Understand your project's structure by viewing the classes in your project on a diagram. Customize your diagram so that you can focus on the project details that you care about the most. Save your diagram to use later for demonstration or documentation.

- **Refactor**: Override methods, rename identifiers, refactor parameters, and implement interfaces and abstract classes.

## View types and relationships

Class diagrams show the details of types, for example, their constituent members, and the relationships between them. The visualization of these entities is a dynamic view into the code. This means that you can edit types in the designer and then see your edits reflected in the source code of the entity. Similarly, the class diagram is kept in sync with changes you make to code files.

> [!NOTE]
> If your project contains a class diagram and your project references a type that's located in another project, the class diagram does not show the referenced type until you build the project for that type. Likewise, the diagram does not display changes to the code of the external entity until you rebuild the project for that entity.

### Class diagram workflow

Class diagrams can help you understand the class structure of projects. These projects might have been created by other developers, or you just need a refresher on a project you created yourself. You can use class diagrams to customize, share, and present project information with others.

The first step in presenting project information is to create a class diagram that displays what you want to show. For more information, see [Add a class diagram](how-to-add-class-diagrams-to-projects.md). You can create multiple class diagrams for a project that can be used to display a distinct view of the project, a chosen subset of the project's types, or a chosen subset of the members of types.

In addition to defining what each class diagram shows, you can also change the way that information is presented; for more information, see [How to: Customize class diagrams](how-to-customize-class-diagrams.md).

After you have fine-tuned one or more class diagrams, you can copy them into Microsoft Office documents and print them, or export them as image files. For more information, see [How to: Copy class diagram elements to a Microsoft Office document](how-to-copy-class-diagram-elements-to-a-microsoft-office-document.md), [How to: Print class diagrams](how-to-print-class-diagrams.md) and [How to: Export class diagrams as images](how-to-export-class-diagrams-as-images.md).

> [!NOTE]
> Class Designer does not track the location of your source files, so changing your project structure or moving source files in the project can cause Class Designer to lose track of the type, especially the source type of a typedef, base classes, or association types. You might get an error, like **Class Designer is unable to display this type**. If you do, drag the modified or relocated source code to the class diagram again to redisplay it.

## Add class diagrams to projects

To design, edit, and refactor classes and other types, add a class diagram to your C#, Visual Basic, or C++ project. To visualize different parts of the code in a project, add multiple class diagrams to the project.

::: moniker range="<=vs-2019"

You can't create class diagrams from projects that share code across multiple apps. To create UML class diagrams, see [Create UML modeling projects and diagrams](https://devblogs.microsoft.com/devops/uml-designers-have-been-removed-layer-designer-now-supports-live-architectural-analysis/).

::: moniker-end

### Install the Class Designer component

If you haven't installed the **Class Designer** component, follow these steps to install it.

1. Open **Visual Studio Installer** from the Windows Start menu, or by selecting **Tools** > **Get Tools and Features** from the menu bar in Visual Studio.

   **Visual Studio Installer** opens.

1. Select the **Individual components** tab, and then scroll down to the **Code tools** category.

1. Select **Class Designer** and then select **Modify**.

   ::: moniker range="vs-2019"
   :::image type="content" source="media/vs-2019/class-designer-component.png" alt-text="Screenshot of the Class Designer component in the Visual Studio Installer." lightbox="media/vs-2019/class-designer-component.png":::
   ::: moniker-end
   ::: moniker range="vs-2022"
   :::image type="content" source="media/vs-2022/class-designer-component.png" alt-text="Screenshot of the Class Designer component in the Visual Studio Installer." lightbox="media/vs-2022/class-designer-component.png":::
   ::: moniker-end

   The **Class Designer** component starts installing.

## Add a blank class diagram to a project

1. In **Solution Explorer**, right-click the project node and then choose **Add** > **New Item**. Or, press **Ctrl**+**Shift**+**A**.

   The **Add New Item** dialog opens.

1. Expand **General**, and then select **Class Diagram** from the template list. For Visual C++ projects, look in the **Utility** category to find the **Class Diagram** template.

   > [!NOTE]
   > If you don't see the **Class Diagram** template, [follow the steps](#install-the-class-designer-component) to install the **Class Designer** component for Visual Studio.

   The class diagram opens in Class Designer and appears as a file that has a *.cd* extension in **Solution Explorer**. You can drag shapes and lines to the diagram from **Toolbox**.

To add multiple class diagrams, repeat the steps in this procedure.

## Add a class diagram based on existing types

In **Solution Explorer**, open a class file's context menu (right-click) and then choose **View Class Diagram**.

-or-

In **Class View**, open the namespace or type context menu and then choose **View Class Diagram**.

> [!TIP]
> If **Class View** is not open, open **Class View** from the **View** menu. Or, press **Ctrl**+**Shift**+**C**.

## To display the contents of a complete project in a class diagram

In **Solution Explorer** or Class View, right-click the project and choose **View**, then choose **View Class Diagram**.

An auto-populated class diagram is created.

> [!IMPORTANT]
> Class Designer is not available in .NET Core projects.


