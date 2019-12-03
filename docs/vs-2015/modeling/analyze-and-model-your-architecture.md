---
title: "Analyze and model your architecture | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio Ultimate, exploring code"
  - "Visual Studio Ultimate, visualizing code"
  - "diagrams - modeling"
  - "Visual Studio ALM, modeling"
  - "application, design"
  - "architecture"
  - "code visualization"
  - "application design"
  - "applications, architecture"
  - "code exploration"
  - "Visual Studio ALM, exploring code"
  - "modeling"
  - "application architecture"
  - "application, modeling"
  - "applications, modeling"
  - "architecture [Visual Studio ALM], modeling"
  - "application modeling"
  - "Visual Studio Ultimate, modeling"
  - "architecture [Visual Studio Ultimate], modeling"
  - "application, architecture"
  - "Visual Studio ALM, visualizing code"
  - "applications, designing"
ms.assetid: c9f04cfa-72bd-419d-a952-616eed01472e
caps.latest.revision: 129
author: jillre
ms.author: jillfra
manager: jillfra
---
# Analyze and model your architecture
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Make sure your app meets user requirements by using Visual Studio architecture and modeling tools to design and model your app. Understand existing program code more easily by using Visual Studio to visualize the code's structure, behavior, and relationships.

 Create models at different levels of detail throughout the application lifecycle as part of your development process. Track requirements, tasks, test cases, bugs, and other work associated with your models by linking model elements to Team Foundation Server work items and your development plan. See [Scenario: Change your design using visualization and modeling](../modeling/scenario-change-your-design-using-visualization-and-modeling.md).

 To see which versions of Visual Studio support each feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport)

## To

|||
|-|-|
|**Visualize code**:<br /><br /> -   See the code's organization and relationships by creating code maps. Visualize dependencies between assemblies, namespaces, classes, methods, and so on.<br />-   See the class structure and members for a specific project by creating class diagrams from code.<br />-   Find conflicts between your code and its design by creating layer diagrams to validate code.<br /><br /> **Note**: In this release of Visual Studio, the term *code map* is used in place of *dependency graph*. The term *graph* when used alone generally refers to a Directed Graph or DGML diagram (or document). Code maps are a specialized type of DGML diagram.|-   [Visualize code](../modeling/visualize-code.md)<br />-   [Working with Classes and Other Types (Class Designer)](../ide/working-with-classes-and-other-types-class-designer.md)<br />-   [Video: Understand your code dependencies through visualization (Channel 9)](https://go.microsoft.com/fwlink/?LinkID=252065)<br />-   [Video: Visualize the impact of a change (Channel 9)](https://go.microsoft.com/fwlink/?LinkID=252068)|
|**Describe and communicate user requirements**:<br /><br /> -   Clarify user stories, business rules, and other requirements and help ensure their consistency by drawing UML diagrams such as use case, activity, and class diagrams.|-   [Create models for your app](../modeling/create-models-for-your-app.md)<br />-   [Model user requirements](../modeling/model-user-requirements.md)<br />-   [Video: Improve architecture through modeling (Channel 9)](https://go.microsoft.com/fwlink/?LinkID=252078)|
|**Define the architecture**:<br /><br /> -   Model the large-scale structure of your software system and the design patterns by drawing UML component, class, and sequence diagrams.<br />-   Define and enforce constraints on dependencies between the components of your code by creating layer diagrams.|-   [Create models for your app](../modeling/create-models-for-your-app.md)<br />-   [Model your app's architecture](../modeling/model-your-app-s-architecture.md)<br />-   [Video: Improve architecture through modeling (Channel 9)](https://go.microsoft.com/fwlink/?LinkID=252078)<br />-   [Video: Use layer diagrams to design and validate your architecture (Channel 9)](https://go.microsoft.com/fwlink/?LinkID=252073)|
|**Validate your system with the requirements and intended design:**<br /><br /> -   Define acceptance tests or system tests based on the requirements models. This creates a strong relationship between the tests and your users' requirements and helps you update the system more easily when the requirements change.<br />-   Validate code dependencies with layer diagrams that describe the intended architecture and prevent changes that might conflict with the design.|-   [Validate your system during development](../modeling/validate-your-system-during-development.md)<br />-   [Video: Use layer diagrams to design and validate your architecture (Channel 9)](https://go.microsoft.com/fwlink/?LinkID=252073)|
|**Share models, diagrams, and code maps using Team Foundation version control**:<br /><br /> -   Put code maps, modeling projects, UML diagrams, and layer diagrams under Team Foundation version control so you can share them.|When you have multiple users who work with these items under Team Foundation version control, use these guidelines to help you avoid version control issues:<br /><br /> -   [Manage models and diagrams under version control](../modeling/manage-models-and-diagrams-under-version-control.md)|
|**Generate or configure parts of your application from UML or domain-specific languages**:<br /><br /> -   Make your design more responsive to requirements changes and easily variable across a product line.|-   [Generate and configure your app from models](../modeling/generate-and-configure-your-app-from-models.md)|
|**Customize models and diagrams**:<br /><br /> -   Adapt models to how your project uses them by defining additional properties for UML elements, validation constraints to make sure that your models conform to your business rules, and additional menu commands and toolbox items.<br />-   Create your own domain-specific languages.|-   [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)<br />-   [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)|
|**Generate text using T4 templates**:<br /><br /> -   Use text blocks and control logic inside templates to generate text-based files.|-   [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md)|

## Types of Models and Their Uses

|**Model type and typical uses**|
|-------------------------------------|
|**Code maps**<br /><br /> Code maps help you see the organization and relationships in your code.<br /><br /> Typical uses:<br /><br /> -   Examine program code so you can better understand its structure and its dependencies, how to update it, and estimate the cost of proposed changes.<br /><br /> See:<br /><br /> -   [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)<br />-   [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)<br />-   [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)|
|**Layer diagram**<br /><br /> Layer diagrams let you define the structure of an application as a set of layers or blocks with explicit dependencies. You can run validation to discover conflicts between dependencies in the code and dependencies described on a layer diagram.<br /><br /> Typical uses:<br /><br /> -   Stabilize the structure of the application through numerous changes over its life.<br />-   Discover unintentional dependency conflicts before checking in changes to the code.<br /><br /> See:<br /><br /> -   [Create layer diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />-   [Layer Diagrams: Reference](../modeling/layer-diagrams-reference.md)<br />-   [Validate code with layer diagrams](../modeling/validate-code-with-layer-diagrams.md)|
|**UML model**<br /><br /> A UML model includes several views, including class, component, use case, activity, and sequence diagrams. You can customize UML to suit your application domain. For example, you can attach tags, additional information, and constraints to the model elements. You can also define tools that operate on the models. See [Create models for your app](../modeling/create-models-for-your-app.md).<br /><br /> Typical uses:<br /><br /> -   Describe requirements and design. You can quickly apply UML to the development of any application. See [Use models in your development process](../modeling/use-models-in-your-development-process.md).<br />-   Generate or configure tests or parts of an application. Some work is required to customize the notation and develop the generation templates or configurable application. See [Generate and configure your app from models](../modeling/generate-and-configure-your-app-from-models.md).<br />-   For general description and for code generation or configuration in smaller projects.|
|**Domain-specific language (DSL)**<br /><br /> A DSL is a notation that you design for a specific purpose. In Visual Studio, it is usually graphical.<br /><br /> Typical uses:<br /><br /> -   Generate or configure parts of the application. Work is required to develop the notation and tools. The result can be a better fit to your domain than a UML customization.<br />-   For large projects or in product lines where the investment in developing the DSL and its tools is returned by its use in more than one project.<br /><br /> See:<br /><br /> -   [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)|

## Where can I get more information?

|||
|-|-|
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](https://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](https://go.microsoft.com/fwlink/?LinkId=184721)|

## See Also

- [What's new for modeling in Visual Studio 2015](../modeling/what-s-new-for-design-in-visual-studio.md)
- [DevOps and Application Lifecycle Management](https://msdn.microsoft.com/library/74a1f71d-7f23-4c71-8fd7-89ede614fab6)
