---
title: Use visualization and modeling to check your code
description: Use visualization and modeling tools in Visual Studio to understand relationships and dependencies in your code and ensure consistency with the architecture design.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- code, understanding
- code, visualizing
- code, exploring
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Visualize code

You can use the visualization and modeling tools in Visual Studio to help you understand existing code and describe your application. This lets you visually learn how your changes might affect the code and help you assess the work and risks that result from those changes. For example:

- To understand the relationships in your code, map those relationships visually.

- To describe your system's architecture and keep the code consistent with its design, create dependency diagrams and validate code against these diagrams.

- To describe class structures, create class diagrams.

These tools also help you communicate more easily with the people involved with your project.

To see which editions of Visual Studio support each feature, see [Edition support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport)

## What do you want to do?

|Scenario|Articles|
|-|-|
|**Understand code and its relationships:**<br /><br /> Map relationships between specific pieces of code.<br /><br /> See an overview of the relationships in your code for the entire solution.|- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)<br />- [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)<br />- [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)<br />- [Map methods on the call stack while debugging](../debugger/map-methods-on-the-call-stack-while-debugging-in-visual-studio.md)|
|**Understand class structures:**<br /><br /> Visualize the structure of classes in a project by creating class diagrams from code.|[How to: Add Class Diagrams to Projects (Class Designer)](../ide/class-designer/how-to-add-class-diagrams-to-projects.md)|
|**Describe the high-level system design and validate code against this design:**<br /><br /> Describe the high-level system design and its intended dependencies by creating dependency diagrams. Validate code against this design to make sure dependencies in code remain consistent with the design.|- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)<br />- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)<br />- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)|

## Related content

- [Install architecture code tools](install-architecture-tools.md)
- [Scenario: Change your design using visualization and modeling](../modeling/scenario-change-your-design-using-visualization-and-modeling.md)
- [Analyze and Model Architecture](../modeling/analyze-and-model-your-architecture.md)
- [Model your app's architecture](../modeling/model-your-app-s-architecture.md)
- [Use models in your development process](../modeling/use-models-in-your-development-process.md)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]
