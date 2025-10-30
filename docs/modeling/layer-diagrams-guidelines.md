---
title: 'Dependency Diagrams: Guidelines'
description: Describe your application architecture at a high level by creating dependency diagrams with layers to represent functional areas or components in Visual Studio.
ms.date: 09/28/2018
ms.topic: article
helpviewer_keywords:
- architecture, dependency diagrams
- dependency diagrams
- diagrams - modeling, layer
- constraints, architectural
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Dependency diagrams: guidelines

Describe your app's architecture at a high level by creating *dependency diagrams* in Visual Studio. Make sure that your code stays consistent with this design by validating your code with a dependency diagram. You can also include layer validation in your build process.

To see which editions of Visual Studio support this feature, see [Edition support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

> [!NOTE]
> Dependency diagrams for .NET Core projects are supported starting in Visual Studio 2019 version 16.2.

## What is a dependency diagram?

Like a traditional architecture diagram, a dependency diagram identifies the major components or functional units of the design and their interdependencies. Each node on the diagram, called a *layer*, represents a logical group of namespaces, projects, or other artifacts. You can draw the dependencies that should exist in your design. Unlike a traditional architecture diagram, you can verify that the actual dependencies in the source code conform to the intended dependencies that you have specified. By making validation part of a regular build on Team Foundation Server, you can ensure that the program code continues to adhere to the system's architecture through future changes. See [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md).

## How to design or update your app with dependency diagrams

The following steps provide an overview of how to use dependency diagrams within the development process. Later sections in this topic describe more detail about each step. If you are developing a new design, omit the steps that refer to existing code.

> [!NOTE]
> These steps appear in approximate order. You will probably want to overlap the tasks, reorder them to suit your own situation, and revisit them at the start of each iteration in your project.

1. [Create a dependency diagram](#Create) for the whole application, or for a layer within it.

2. [Define layers to represent primary functional areas or components](#CreateLayers) of your application. Name these layers according to their function, for example, "Presentation" or "Services". If you have a Visual Studio solution, you can associate each layer with a collection of *artifacts*, such as projects, namespaces, files, and so on.

3. [Discover the existing dependencies](#Generate) between layers.

4. [Edit the layers and dependencies](#EditArchitecture) to show the updated design that you want the code to reflect.

5. [Design new areas of your application](#NewAreas) by creating layers to represent the principal architectural blocks or components and defining dependencies to show how each layer uses the others.

6. [Edit the layout and appearance of the diagram](#EditLayout) to help you discuss it with colleagues.

7. [Validate the code against the dependency diagram](#Validate) to highlight the conflicts between the code and the architecture you require.

8. [Update the code to conform to your new architecture](#UpdateCode). Iteratively develop and refactor code until the validation shows no conflicts.

9. [Include layer validation in the build process](#BuildValidation) to ensure that the code continues to adhere to your design.

## <a name="Create"></a> Create a dependency diagram

A dependency diagram must be created inside a modeling project. You can add a new dependency diagram to an existing modeling project, create a new modeling project for the dependency diagram, or copy an existing dependency diagram within the same modeling project.

> [!IMPORTANT]
> Do not add, drag, or copy an existing dependency diagram from a modeling project to another modeling project or to another location in the solution. A dependency diagram that is copied in this way will have the same references as the original diagram, even if you modify the diagram. This will prevent layer validation from working correctly and might cause other issues, such as missing elements or other errors when trying to open the diagram.

See [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md).

## <a name="CreateLayers"></a> Define layers to represent functional areas or components

Layers represent logical groups of *artifacts*, such as projects, code files, namespaces, classes, and methods. You can create layers from artifacts from Visual C# and Visual Basic projects, or you can attach specifications or plans to a layer by linking documents, such as Word files or PowerPoint presentations. Each layer appears as a rectangle on the diagram and shows the number of artifacts that are linked to it. A layer can contain nested layers that describe more specific tasks.

As a general guideline, name layers according to their function, for example, "Presentation" or "Services". If the artifacts are closely interdependent, place them in the same layer. If the artifacts can be updated separately or used in separate applications, place them in different layers.

> [!TIP]
> There are certain types of artifacts that you can link to layers but that do not support validation against the dependency diagram. To see whether the artifact supports validation, open **Layer Explorer** to examine the **Supports Validation** property of the artifact link. See [Discover existing dependencies between layers](#Generate).

When updating an unfamiliar application, you might also create code maps. These diagrams can help you discover patterns and dependencies while you explore the code. Use Solution Explorer to explore namespaces and classes, which often correspond well to existing layers. Assign these code artifacts to layers by dragging them from Solution Explorer to dependency diagrams. You can then use dependency diagrams to help you update the code and keep it consistent with your design.

See:

- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)

- [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)

- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)

## <a name="Generate"></a> Discover existing dependencies between layers

A dependency exists wherever an artifact that is associated with one layer has a reference to an artifact that is associated with another layer. For example, a class in one layer declares a variable that has a class in another layer. You can discover existing dependencies by reverse-engineering them.

> [!NOTE]
> Dependencies cannot be reverse-engineered for certain kinds of artifacts. For example, no dependencies will be reverse-engineered from or to a layer that is linked to a text file. To see which artifacts have dependencies that you can reverse-engineer, right-click one or multiple layers, and then click **View Links**. In **Layer Explorer**, examine the **Supports Validation** column. Dependencies will not be reverse-engineered for artifacts for which this column shows **False**.

### To reverse-engineer existing dependencies between layers

Select one layer or multiple layers, right-click a selected layer, and then click **Generate Dependencies**.

Typically, you will see some dependencies that should not exist. You can edit these dependencies to align them with the intended design.

## <a name="EditArchitecture"></a> Edit layers and dependencies to show the intended design

To describe the changes that you plan to make to your system or the intended architecture, use the following steps to edit the dependency diagram. You might also consider making some refactoring changes to improve the structure of the code before extending it. See [Improving the structure of the code](#Improving).

|**To**|**Perform these steps**|
|-|-|
|Delete a dependency that should not exist|Click the dependency, and then press **DELETE**.|
|Change or restrict the direction of a dependency|Set its **Direction** property.|
|Create new dependencies|Use the **Dependency** and **Bidirectional Dependency** tools.<br /><br /> To draw multiple dependencies, double-click the tool. When you are finished, click the **Pointer** tool or press the **ESC** key.|
|Specify that artifacts associated with a layer cannot depend on the specified namespaces|Type the namespaces in the layer's **Forbidden Namespace Dependencies** property. Use a semicolon (**;**) to separate the namespaces.|
|Specify that artifacts associated with a layer must not belong to the specified namespaces|Type the namespaces in the layer's **Forbidden Namespaces** property. Use a semicolon (**;**) to separate the namespaces.|
|Specify that artifacts associated with a layer must belong to one of the specified namespaces|Type the namespace in the layer's **Required Namespaces** property. Use a semicolon (**;**) to separate the namespaces.|

### <a name="Improving"></a> Improving the structure of the code

Refactoring changes are improvements that do not affect the behavior of the application, but help make the code easier to change and extend in the future. Well-structured code has a design that is easy to abstract to a dependency diagram.

For example, if you create a layer for each namespace in the code and then reverse-engineer the dependencies, there should be a minimal set of one-way dependencies between the layers. If you create a more detailed diagram using classes or methods as your layers, then the result should also have the same characteristics.

If this is not the case, the code will be more difficult to change throughout its life and will be less suitable for validation using dependency diagrams.

## <a name="NewAreas"></a> Design new areas of your application

When you start development of a new project, or a new area in a new project, you can draw layers and dependencies to help identify the major components before you start to develop the code.

- **Show identifiable architectural patterns** in your dependency diagrams, if possible. For example, a dependency diagram that describes a desktop application might include layers such as Presentation, Domain Logic, and Data Store. A dependency diagram that covers a single feature within an application might have layers such as Model, View, and Controller.

- **Create a code artifact for each layer** such as a namespace, class, or component. This makes it easier to follow the code and to link the code artifacts to layers. As soon as you create each artifact, link it to the appropriate layer.

- **You do not have to link most classes and other artifacts to layers** because they fall within larger artifacts such as namespaces that you have already linked to layers.

- **Create a new diagram for a new feature**. Typically, there will be one or more dependency diagrams describing the whole application. If you are designing a new feature within the application, do not add to or change the existing diagrams. Instead, create your own diagram that reflects the new parts of the code. The layers in the new diagram might include presentation, domain logic, and database layers for the new feature.

     When you build the application, your code will be validated both against the overall diagram and your more detailed feature diagram.

## <a name="EditLayout"></a> Edit the layout for presentation and discussion

To help you identify layers and dependencies or discuss them with team members, edit the appearance and layout of the diagram in the following ways:

- Change the sizes, shapes, and positions of layers.

- Change the colors of layers and dependencies.

  - Select one or more layers or dependencies, right-click, and then click **Properties**. In the **Properties** window, edit the **Color** property.

## <a name="Validate"></a> Validate the code against the diagram

When you have edited the diagram, you can validate it against the code manually at any time or automatically every time that you build.

See:

- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)

- [Include Layer Validation in the Build Process](#BuildValidation)

## <a name="UpdateCode"></a> Update the code to conform to the new architecture

Typically, errors will appear the first time that you validate code against an updated dependency diagram. These errors can have several causes:

- An artifact is assigned to the wrong layer. In this case, move the artifact.

- An artifact, such as a class, uses another class in a way that conflicts with your architecture. In this case, refactor the code to remove the dependency.

To resolve these errors, update the code until no more errors appear during validation. This is usually an iterative process. For more information about these errors, see [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md).

> [!NOTE]
> As you develop or refactor the code, you might have new artifacts to link to the dependency diagram. However, this might not be necessary, for example, when you have layers that represent existing namespaces, and the new code only adds more material to those namespaces.

During the development process, you might want to suppress some of the reported conflicts during validation. For example, you might want to suppress errors that you are already addressing or that are not relevant to your particular scenario. When you suppress an error, it is a good practice to log a work item in Team Foundation. To perform this task, see [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md).

## <a name="BuildValidation"></a> Include layer validation in the build process

To ensure that future changes in the code conform to the dependency diagrams, include layer validation to your solution's standard build process. Whenever other team members build the solution, any differences between the dependencies in the code and the dependency diagram will be reported as build errors. For more information about including layer validation in the build process, see [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md).

## Related content

- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)
- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)
