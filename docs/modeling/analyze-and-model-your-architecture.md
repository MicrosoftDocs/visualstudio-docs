---
title: "Analyze and model your architecture | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: ""
ms.topic: "get-started-article"
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
author: gewarren
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
---
# Analyze and model your architecture
Make sure your app meets architectural requirements by using
Visual Studio architecture and modeling tools to design and model
your app. 

* Understand existing program code more easily by using
Visual Studio to visualize the code's structure, behavior, and
relationships. 

* Educate your team in the need for respecting
architectural dependencies.  
  
* Create models at different levels of detail throughout the
application lifecycle as part of your development process.

See [Scenario: Change your design using visualization and modeling](../modeling/scenario-change-your-design-using-visualization-and-modeling.md).  
  
## To  
  
|||  
|-|-|  
|**Visualize code**:<br /><br /> -   See the code's organization and relationships by creating code maps. Visualize dependencies between assemblies, namespaces, classes, methods, and so on.<br />-   See the class structure and members for a specific project by creating class diagrams from code.<br />-   Find conflicts between your code and its design by creating dependency diagrams to validate code.|-   [Visualize code](../modeling/visualize-code.md)<br />-   [Working with Classes and Other Types (Class Designer)](../ide/working-with-classes-and-other-types-class-designer.md)<br />-   [Video: Understand design from code with Visual Studio 2015 code maps](https://channel9.msdn.com/Events/Visual-Studio/Connect-event-2015/502)<br />-   [Video: Validate your architecture dependencies in real time](https://sec.ch9.ms/sessions/69613110-c334-4f25-bb36-08e5a93456b5/170ValidateArchitectureDependenciesWithVisualStudio.mp4)|  
|**Define the architecture**:<br /><br /> -   Define and enforce constraints on dependencies between the components of your code by creating dependency diagrams.|-   [Video: Validate architecture dependencies with Visual Studio (Channel 9)](https://channel9.msdn.com/Events/Connect/2016/170)|  
|**Validate your system with the requirements and intended design:**<br /><br /> -   Validate code dependencies with dependency diagrams that describe the intended architecture and prevent changes that might conflict with the design.|-   [Video: Validate architecture dependencies with Visual Studio (Channel 9)](https://channel9.msdn.com/Events/Connect/2016/170)|  
|**Share models, diagrams, and code maps using Team Foundation version control**:<br /><br /> -   Put code maps, projects, and deoendency diagrams under Team Foundation version control so you can share them.| |  
|**Customize models and diagrams**:<br /><br /> -   Create your own domain-specific languages.|-   [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)|  
|**Generate text using T4 templates**:<br /><br /> -   Use text blocks and control logic inside templates to generate text-based files.<br /> - T4 template build with MSBuild included in Visual Studio|-   [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md)|

To see which versions of Visual Studio support each feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport)  
  
## Types of Models and Their Uses  
  
|**Model type and typical uses**|  
|-------------------------------------|  
|**Code maps**<br /><br /> Code maps help you see the organization and relationships in your code.<br /><br /> Typical uses:<br /><br /> -   Examine program code so you can better understand its structure and its dependencies, how to update it, and estimate the cost of proposed changes.<br /><br /> See:<br /><br /> -   [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)<br />-   [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)<br />-   [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)|  
|**Dependency diagram**<br /><br /> Dependency diagrams let you define the structure of an application as a set of layers or blocks with explicit dependencies. You can run validation to discover conflicts between dependencies in the code and dependencies described on a dependency diagram.<br /><br /> Typical uses:<br /><br /> -   Stabilize the structure of the application through numerous changes over its life.<br />-   Discover unintentional dependency conflicts before checking in changes to the code.<br /><br /> See:<br /><br /> -   [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />-   [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)<br />-   [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)|  
|**Domain-specific language (DSL)**<br /><br /> A DSL is a notation that you design for a specific purpose. In Visual Studio, it is usually graphical.<br /><br /> Typical uses:<br /><br /> -   Generate or configure parts of the application. Work is required to develop the notation and tools. The result can be a better fit to your domain than a UML customization.<br />-   For large projects or in product lines where the investment in developing the DSL and its tools is returned by its use in more than one project.<br /><br /> See:<br /><br /> -   [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)|  
  
## Where can I get more information?  
  
[Visual Studio Visualization & Modeling Tools Forum](http://go.microsoft.com/fwlink/?LinkId=184720)  
  
## See Also  
 [What's new](../modeling/what-s-new-for-design-in-visual-studio.md)   
 [DevOps and Application Lifecycle Management](http://msdn.microsoft.com/Library/74a1f71d-7f23-4c71-8fd7-89ede614fab6)
