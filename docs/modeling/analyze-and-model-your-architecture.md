---
title: Analyze and model your architecture
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "diagrams - modeling"
  - "architecture"
  - "code visualization"
  - "application design"
  - "code exploration"
  - "modeling"
  - "application architecture"
  - "architecture [Visual Studio ALM], modeling"
  - "application modeling"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Analyze and model your architecture

Make sure your app meets architectural requirements by using Visual Studio architecture and modeling tools to design and model your app.

* Understand existing program code more easily by using Visual Studio to visualize the code's structure, behavior, and relationships.

* Educate your team in the need for respecting architectural dependencies.

* Create models at different levels of detail throughout the application lifecycle as part of your development process.

See [Scenario: Change your design using visualization and modeling](../modeling/scenario-change-your-design-using-visualization-and-modeling.md).

## Article reference

|||
|-|-|
|**Visualize code**:<br /><br />- See the code's organization and relationships by creating code maps. Visualize dependencies between assemblies, namespaces, classes, methods, and so on.<br />- See the class structure and members for a specific project by creating class diagrams from code.<br />- Find conflicts between your code and its design by creating dependency diagrams to validate code.|- [Visualize code](../modeling/visualize-code.md)<br />- [Working with Classes and Other Types (Class Designer)](../ide/class-designer/designing-and-viewing-classes-and-types.md)<br />- [Video: Understand design from code with Visual Studio 2015 code maps](https://channel9.msdn.com/Events/Visual-Studio/Connect-event-2015/502)<br />- [Video: Validate your architecture dependencies in real time](https://sec.ch9.ms/sessions/69613110-c334-4f25-bb36-08e5a93456b5/170ValidateArchitectureDependenciesWithVisualStudio.mp4)|
|**Define the architecture**:<br /><br />- Define and enforce constraints on dependencies between the components of your code by creating dependency diagrams.|- [Video: Validate architecture dependencies with Visual Studio (Channel 9)](https://channel9.msdn.com/Events/Connect/2016/170)|
|**Validate your system with the requirements and intended design:**<br /><br />- Validate code dependencies with dependency diagrams that describe the intended architecture and prevent changes that might conflict with the design.|- [Video: Validate architecture dependencies with Visual Studio (Channel 9)](https://channel9.msdn.com/Events/Connect/2016/170)|
|**Customize models and diagrams**:<br /><br />- Create your own domain-specific languages.|- [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)|
|**Generate text using T4 templates**:<br /><br />- Use text blocks and control logic inside templates to generate text-based files.<br /> - T4 template build with MSBuild included in Visual Studio|- [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md)|
|**Share models, diagrams, and code maps using Team Foundation version control**:<br /><br />- Put code maps, projects, and dependency diagrams under Team Foundation version control so you can share them.| |

To see which editions of Visual Studio support each feature, see [Edition support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport)

## Types of models and typical uses

### Code maps

Code maps help you see the organization and relationships in your code.

**Typical uses:**

- Examine program code so you can better understand its structure and its dependencies, how to update it, and estimate the cost of proposed changes.

**See:**

- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)
- [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)
- [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)

### Dependency diagrams

Dependency diagrams let you define the structure of an application as a set of layers or blocks with explicit dependencies. Live validation shows conflicts between dependencies in the code and dependencies described on a dependency diagram.

**Typical uses:**

- Stabilize the structure of the application through numerous changes over its life.
- Discover unintentional dependency conflicts before checking in changes to the code.

**See:**

- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)
- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)
- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)

### Domain-specific language (DSL)

A DSL is a notation that you design for a specific purpose. In Visual Studio, it's usually graphical.

**Typical uses:**

- Generate or configure parts of the application. Work is required to develop the notation and tools. The result can be a better fit to your domain than a UML customization.
- For large projects or in product lines where the investment in developing the DSL and its tools is returned by its use in more than one project.

**See:**

- [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)

## See also

- [What's new for modeling in Visual Studio 2017](../modeling/what-s-new-for-design-in-visual-studio.md)
- [DevOps and Application Lifecycle Management](/azure/devops/user-guide/devops-alm-overview)
