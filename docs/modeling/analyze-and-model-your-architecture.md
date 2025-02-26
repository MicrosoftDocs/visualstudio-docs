---
title: Architecture analysis & modeling tools
description: Design and analyze your application to ensure it meets architectural requirements by using code maps, dependency diagrams, and language models.
ms.date: 06/04/2021
ms.topic: overview
helpviewer_keywords:
- diagrams - modeling
- architecture
- code visualization
- application design
- code exploration
- modeling
- application architecture
- architecture [Visual Studio ALM], modeling
- application modeling
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Analyze and model your architecture

Make sure your app meets architectural requirements by using Visual Studio architecture and modeling tools to design and model your app.

1. Understand existing program code better by [visualizing the code](visualize-code.md) structure, behavior, and relationships with code maps and dependency diagrams.
    - See the code's organization and relationships by creating **code maps**. 
    - Visualize dependencies between assemblies, namespaces, classes, methods, and so on.
    - Find conflicts between your code and its design by creating **dependency diagrams** to validate code.
    - See the class structure and members for a specific project by [creating class diagrams from code](../ide/class-designer/designing-and-viewing-classes-and-types.md).
    - [Generate text using T4 templates](../modeling/code-generation-and-t4-text-templates.md) with text blocks and control logic inside templates to generate text-based files. 
    
1. Educate your team in the need for respecting architectural dependencies.

1. Create models at different levels of detail throughout the application lifecycle as part of your development process.

See [Scenario: Change your design using visualization and modeling](../modeling/scenario-change-your-design-using-visualization-and-modeling.md).

## Code maps

Code maps are one type of model that helps you see the organization and relationships in your code.

Use maps to examine program code so you can better understand its structure and its dependencies, how to update it, and estimate the cost of proposed changes.

Learn more:
- [Install architecture code tools](install-architecture-tools.md)
- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)
- [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)
- [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)

## Dependency diagrams

Dependency diagrams let you define the structure of an application as a set of layers or blocks with explicit dependencies. Live validation shows conflicts between dependencies in the code and dependencies described on a dependency diagram.

Use dependency diagrams to: 
- Stabilize the structure of the application through numerous changes over its life.
- Discover unintentional dependency conflicts before checking in changes to the code.

Learn more:
- [Install architecture code tools](install-architecture-tools.md)
- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)
- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)
- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)

## Domain-specific language (DSL) models

A DSL is a notation that you design for a specific purpose. In Visual Studio, it's usually graphical.

Use domain-specific language to: 
- Generate or configure parts of the application. Work is required to develop the notation and tools. The result can be a better fit to your domain than a UML customization.
- For large projects or in product lines where the investment in developing the DSL and its tools is returned by its use in more than one project.

Learn more:
- [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)

## <a name="VersionSupport"></a> Edition support for architecture and modeling tools

> [!NOTE]
> Architecture tools are not supported on ARM64 Visual Studio.

Visual Studio is available in several editions. Not all of these provide support for the architecture and modeling tools. The following table shows the availability of each tool.

|**Feature**|**Enterprise edition**|**Professional edition**|**Community edition**|
|-|-|-|-|
|**Code maps**|Yes|Only supports reading code maps, filtering code maps, adding new generic nodes, and creating a new Directed Graph from a selection.|-|
|**Dependency diagrams**|Yes|Only supports reading dependency diagrams.|Only supports reading dependency diagrams.|
|**Directed graphs** (DGML diagrams)|Yes|Yes|Yes|
|**Code clone**|Yes|-|-|
