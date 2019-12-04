---
title: "Structure your modeling solution | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 2ba70ba4-2cea-4e01-93c2-055903d59470
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---

# Structure your modeling solution

[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To use models effectively in a development project, the team members must be able to work on models of different parts of the project at the same time. This topic suggests a scheme for dividing the application into different parts that correspond to the layers in an overall layering diagram.

To start on a project or subproject quickly, it is useful to have a project template that follows the project structure that you have chosen. This topic describes how to create and use such a template.

This topic assumes that you are working on a project that is large enough to require several team members, and perhaps has several teams. The code and models of the project are stored on a source control system such as [!INCLUDE[esprtfs](../includes/esprtfs-md.md)]. At least some team members use Visual Studio to develop models, and other team members can view the models by using other Visual Studio versions.

To see which versions of Visual Studio support each tool and modeling feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Solution structure

In a medium or large project, the structure of the team is based on the structure of the application. Each team uses a Visual Studio solution.

#### To divide an application into layers

1. Base the structure of your solutions on the structure of your application, such as web application, service application, or desktop application. A variety of common architectures is discussed in [Application Archetypes in the Microsoft Application Architecture Guide](https://go.microsoft.com/fwlink/?LinkId=196681).

2. Create a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution, which we will call the Architecture solution. This solution will be used to create the overall design of the system. It will contain models but no code.

    Add a layer diagram to this solution. On the layer diagram, draw the architecture you have chosen for your application. For example, the diagram might show these layers and the dependencies between them: Presentation; Business logic; and Data.

    You can create the layer diagram and a new Visual Studio solution at the same time by using the **New UML or Layer Diagram** command on the **Architecture** menu.

3. Add to the Architecture model UML diagrams that represent the important business concepts, and use cases that are referred to in the design of all the layers.

4. Create a separate Visual Studio solution for each layer in the Architecture layer diagram.

    These solutions will be used to develop the code of the layers.

5. Create UML models that will represent the designs of the layers and the concepts that are common to all the layers. Arrange the models so that all the models can be seen from the Architecture solution, and the relevant models can be seen from each layer.

    You can achieve this by using either of the following procedures. The first alternative creates a separate modeling project for each layer, and the second creates a single modeling project that is shared between the layers.

###### To use a separate modeling project for each layer

1. Create a modeling project in each layer solution.

    This model will contain UML diagrams that describe the requirements and design of that layer. It can also contain layer diagrams that show nested layers.

    You now have a model for each layer, plus a model for the application architecture. Each model is contained in its own solution. This enables team members to work on the layers at the same time.

2. To the Architecture solution, add the modeling project of each layer solution. To do this, open the Architecture solution. In Solution Explorer, right-click the solution node, point to Add, and then click **Existing Project**. Navigate to the modeling project (.modelproj) in one layer solution.

    Each model is now visible in two solutions: its "home" solution and the Architecture solution.

3. To the modeling project of each layer, add a layer diagram. Start with a copy of the Architecture layer diagram. You can delete parts that are not dependencies of the layer diagram.

    You can also add layer diagrams that represent the detailed structure of this layer.

    These diagrams are used to validate the code that is developed in this layer.

4. In the Architecture solution, edit the requirements and design models of all the layers by using Visual Studio.

    In each layer solution, develop the code for that layer, referring to the model. If you are content to do the development without using the same computer to update the model, you can read the model and develop code by using versions of Visual Studio that cannot create models. You can also generate code from the model in these versions.

    This method guarantees that no interference will be caused by developers who edit the layer models at the same time.

    However, because the models are separate, it is difficult to refer to common concepts. Each model must have its own copy of the elements on which it is dependent from other layers and the architecture. The layer diagram in each layer must be kept in sync with the Architecture layer diagram. It is difficult to maintain synchronization when these elements change, although you could develop tools to accomplish this.

###### To use a separate package for each layer

1. In the solution for each layer, add the Architecture modeling project. In Solution Explorer, right-click the solution node, point to **Add**, and then click **Existing Project**. The single modeling project can now be accessed from every solution: the Architecture project, and the development project for each layer.

2. In the shared UML model, create a package for each layer: In Solution Explorer, select the modeling project. In UML Model Explorer, right-click the model root node, point to **Add**, and then click **Package**.

    Each package will contain UML diagrams that describe the requirements and design of the corresponding layer.

3. If required, add local layer diagrams for the internal structure of each layer.

    This method allows the design elements of each layer to refer directly to those of the layers and common architecture on which it depends.

    Although concurrent work on different packages can cause some conflicts, they are fairly easy to manage because the packages are stored in separate files. The major difficulty is caused by the deletion of an element that is referenced from a dependent package. For more information, see [Manage models and diagrams under version control](../modeling/manage-models-and-diagrams-under-version-control.md).

## Creating architecture templates

In practice, you will not create all your Visual Studio solutions at the same time, but add them as the project progresses. You will probably also use the same solution structure in future projects.  To help you create new solutions quickly, you can create a solution or project template. You can capture the template in a Visual Studio Integration Extension (VSIX) so that it is easy to distribute and to install on other computers.

For example, if you frequently use solutions that have Presentation, Business, and Data layers, you can configure a template that will create new solutions that have that structure.

#### To create a solution template

1. [Download and install the Export Template Wizard](https://go.microsoft.com/fwlink/?LinkId=196686), if you have not already done this.

2. Create the solution structure that you want to use as a starting point for future projects.

3. On the **File** menu, click **Export Template as VSIX**. The **Export Template as VSIX Wizard** opens.

4. Following the instructions in the wizard, select the projects that you want to include in the template, provide a name and description for the template, and specify an output location.

> [!NOTE]
> The material in this topic is abstracted and paraphrased from the Visual Studio Architecture Tooling Guidance, written by the Visual Studio ALM Rangers, which is a collaboration between Most Valued Professionals (MVPs), Microsoft Services, and the Visual Studio product team and writers. [Click here to download the complete Guidance package.](https://go.microsoft.com/fwlink/?LinkID=191984)

## Related materials

[Organizing and Managing Your Models](https://channel9.msdn.com/blogs/clinted/uml-with-vs-2010-part-9-organizing-and-managing-your-models) - video by Clint Edmondson.

[Visual Studio Architecture Tooling Guidance](../modeling/visual-studio-architecture-tooling-guidance.md) – Further guidance on managing models in a team

## See Also

[Manage models and diagrams under version control](../modeling/manage-models-and-diagrams-under-version-control.md)
[Use models in your development process](../modeling/use-models-in-your-development-process.md)
