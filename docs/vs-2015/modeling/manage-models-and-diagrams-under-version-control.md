---
title: "Manage models and diagrams under version control | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "models, version control"
ms.assetid: ca6443e3-6d11-4da8-aae7-ca7dcc410076
caps.latest.revision: 32
author: jillre
ms.author: jillfra
manager: jillfra
---
# Manage models and diagrams under version control
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Manage different versions of your modeling projects and diagrams, including code maps (.dgml files), by using [use Team Foundation version control or Git](https://msdn.microsoft.com/library/33267cee-fe5f-4aa3-b2cd-6d22ceace314); either with on-premises Team Foundation Server or in the cloud with Visual Studio Team Services.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

> [!IMPORTANT]
> Use caution when several users work on the same modeling project. Find out how you can [organize models in medium or large projects](../modeling/structure-your-modeling-solution.md).

## <a name="ModelingProjects"></a> Files in a Modeling Project
 More than one user can work on a modeling project at the same time, provided they work on different files.

 To avoid or resolve conflicts between changes made by different users, it is important to understand how the model is stored in files.

- Each package is stored in a separate **.uml** file, which is kept in the **ModelDefinition** project folder. The model also has a **.uml** file. If one of these files is deleted or corrupted, the corresponding package or model will be lost.

- Each diagram is stored in two files. For example, a class diagram has:

  - **DiagramName.classdiagram** - If this file is deleted or corrupted, the diagram will be lost, but the classes and associations that it showed will still be in the model, and can be seen in UML Model Explorer.

  - **DiagramName.classdiagram.layout** - If this file is deleted, the shapes will still appear the diagram, but they will lose their sizes and positions. Each layout file is subsidiary to a diagram file. To see it, click the [+] next to the diagram file in Solution Explorer.

> [!NOTE]
> It is important to maintain consistency between the files. For example, if you use source control to roll back changes in a .uml file, you should roll back the corresponding changes in the .*diagram and .layout files at the same time. Elements represented in a .\*diagram file will be lost if they are not also represented in a .uml file.

## <a name="Shared"></a> Working on Shared Modeling Projects
 To minimize conflicts between concurrent work on different parts of a project:

- Divide your modeling project into packages representing different areas of work. Move the entire model into the packages, instead of leaving it in the root model. For more information, see [Define packages and namespaces](../modeling/define-packages-and-namespaces.md).

- Different users should not work on the same package or diagram at the same time.

- If you are using profiles, make sure everyone has installed the same profiles. See [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md).

- To help ensure that you change only the package that you are working on:

  - Set the **LinkedPackage** property of a UML class, component, or use case diagram.

  - In UML Model Explorer, drag an activity or interaction into your package as soon as you have created it. This element will appear in UML Model Explorer when you create the first node in the activity or sequence diagram.

- To help you keep track of packages, rename the package files to reflect the actual package names.

- In [!INCLUDE[esprscc](../includes/esprscc-md.md)], always perform **Check In** and **Get Latest Version** operations on the complete modeling project, never on individual files.

- Always perform a **Get** operation immediately before you check in the modeling project.

- Always close all diagrams before you perform a **Get** operation.

    > [!NOTE]
    > If a file is open when you perform a **Get**, and the operation results in local changes, then you will be prompted to reload the file. In this case, click **No**, and then reload the complete project. In **Solution Explorer**, right-click the modeling project node, click **Unload Project**, and then click **Reload Project**.

### <a name="Exclusive"></a> Changes Requiring Exclusive Access to the Model
 Before you make the following kinds of changes, make sure that you have a Check Out lock on the whole project.

- Renaming or deleting elements that are referenced from other packages.

- Changing properties of relationships that cross package boundaries.

- To learn about Check Out locks, see [Check out and edit files](https://msdn.microsoft.com/library/eb404d63-c448-4994-9416-3e6d50ec554a).

##### To move a diagram file in or out of a project folder

1. Start **Developer Command prompt for Visual Studio**.

2. Use **tf rename** to move the diagram file and its **.layout** file:

     `tf rename sourcePath targetPath`

3. In Solution Explorer, right-click the file and then click **Exclude From Project**.

4. Add the file to the destination folder.

     In Solution Explorer, right-click the destination folder or the project, point to **Add**, and then click **Existing Item**. In the dialog box, select the diagram file and then click **Add**. The layout file will be added automatically.

    > [!NOTE]
    > You cannot move the file to a different project.

## <a name="Merging"></a> Merging Changes in Model Files and Diagrams
 After more than one user has worked on a model concurrently, [!INCLUDE[esprscc](../includes/esprscc-md.md)] will prompt you to merge the changes in the model files. Working on separate projects as described in the previous preceding sections will avoid most of the merges. Ordinarily, the remaining conflicts can be safely merged automatically. The following kinds of changes should cause no difficulty:

- Types of lifelines. When you add a lifeline to an interaction (sequence diagram), its type is stored in the root model, unless you have created the lifeline from an existing type.

- New activities and interactions are initially stored in the root model.

- Adding elements and relationships.

- Renaming or deleting elements that are referenced only within their own package.

## See Also
 [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)
 [Share models and exporting diagrams](../modeling/share-models-and-exporting-diagrams.md)
