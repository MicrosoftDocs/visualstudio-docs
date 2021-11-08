---
title: 'Change your design using visualization and modeling'
description: Learn about the visualization and modeling tools in Visual Studio, and how you use those tools to change your design.
ms.date: 11/04/2016
ms.topic: overview
helpviewer_keywords:
- code visualization [Visual Studio ALM]
- modeling software [Visual Studio ALM]
- software modeling [Visual Studio ALM]
- walkthroughs [Visual Studio ALM], visualizing code
- walkthrough [Visual Studio ALM], visualizing code
- walkthrough [Visual Studio ALM], modeling software
- walkthroughs [Visual Studio ALM], modeling software
author: mgoertz-msft
ms.author: mgoertz
ms.custom: SEO-VS-2020
manager: jmartens
ms.technology: vs-ide-modeling
ms.workload:
- multiple
---
# Scenario: Change your design using visualization and modeling

Make sure that your software system meets users' needs by using the visualization and modeling tools in Visual Studio.
Use tools such as code maps, dependency diagrams, and class diagrams to:

To see which versions of Visual Studio support each tool, see [Version support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

- Clarify users' requirements and business processes.

- Visualize and explore existing code.

- Describe changes to an existing system.

- Verify that the system meets its requirements.

- Keep code consistent with the design.

This walkthrough:

- Describes how these tools can benefit your software project.

- Shows how you might use these tools, regardless your development approach, with an example scenario.

To find out more about these tools and the scenarios that they support, see:

- [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)

- [Visualize code](../modeling/visualize-code.md)

## Scenario overview

This scenario describes episodes from the software development lifecycles of two fictitious companies: Dinner Now and Lucerne Publishing. Dinner Now provides a Web-based meal delivery service in Seattle. Customers can order meals and pay for them on the Dinner Now website. The orders are then sent to the appropriate local restaurant for delivery. Lucerne Publishing, a company in New York, runs several businesses both off and on the Web. For example, they run a website where customers can post restaurant reviews.

Lucerne recently acquired Dinner Now and wants to make the following changes:

- Integrate their websites by adding restaurant review capabilities to Dinner Now.

- Replace Dinner Now's payment system with Lucerne's system.

- Expand the Dinner Now service across the region.

Dinner Now uses SCRUM and eXtreme Programming. They have very high test coverage and very little unsupported code. They minimize risks by creating small but working versions of a system and then adding functionality incrementally. They develop their code over short and frequent iterations. This lets them embrace change confidently, refactor code frequently, and avoid "big design up front".

Lucerne maintains a vastly larger and complex collection of systems, some of which are more than 40 years old. They are very cautious about making changes because of the complexity and scope of legacy code. They follow a more rigorous development process, preferring to design detailed solutions and to document the design and changes that occur during development.

Both teams use modeling diagrams in Visual Studio to help them develop systems that meet the users' needs. They use Team Foundation Server alongside other tools to help them plan, organize, and manage their work.

For more information about Team Foundation Server, see:

- [Plan and track work](#plan-and-track-work)

- [Testing, validating, and checking in updated code](#TestValidateCheckInCode)

## <a name="ModelingDiagramsTools"></a> Roles of Architecture and Modeling Diagrams in Software Development

The following table describes roles that these tools can play during multiple and various stages of the software development lifecycle:

|Tool / Role|User Requirements Modeling|Business Process Modeling|System Architecture & Design|Code Visualization & Exploration|Verification|
|------|-|-|-|-|-|
|Domain-Specific Language (DSL) diagram|Yes|Yes|Yes|||
|Dependency diagram, layer validation|||Yes|Yes|Yes|
|Code map|||Yes|Yes|Yes|
|Class Designer (code-based)||||Yes||

To draw dependency diagrams, you must create a modeling project as part of an existing solution or a new one. These diagrams must be created in the modeling project.
Items on dependency diagrams are located in the modeling project, but they are not stored in the common model. Code maps and .NET class diagrams created from code exist outside the modeling project.

See:

- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)

- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)

- [How to: Add Class Diagrams to Projects (Class Designer)](../ide/class-designer/how-to-add-class-diagrams-to-projects.md)

- [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

Both teams also use dependency validation to make sure that code under development remains consistent with the design. See:

- [Keeping Code Consistent with the Design](#ValidatingCode)

- [Describe the Logical Architecture: Dependency Diagrams](#DescribeLayers)

- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)

> [!NOTE]
> Some versions of Visual Studio support dependency validation and read-only versions of code maps for visualization and modeling. To see which editions of Visual Studio support this feature, see [Edition support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

## Understand and communicate information about the system

There is no prescribed order for using the Visual Studio modeling diagrams, so you can use them as they fit with your needs or approach. Usually, teams revisit their models iteratively and frequently throughout a project. Each diagram offers particular strengths to help you understand, describe, and communicate different aspects of the system under development.

Dinner Now and Lucerne communicate with each other and with project stakeholders by using diagrams as their common language. For example, Dinner Now uses diagrams to perform these tasks:

- Visualize existing code.

- Communicate with Lucerne about new or updated user stories.

- Identify changes that are required to support new or updated user stories.

Lucerne uses diagrams to perform these tasks:

- Learn about the Dinner Now business process.

- Understand the design of the system.

- Communicate with Dinner Now about new or updated user requirements.

- Document updates to the system.

The diagrams are integrated with Team Foundation Server so the teams can plan, manage, and track their work more easily. For example, they use models to identify test cases and development tasks and to estimate their work. Lucerne links Team Foundation Server work items to model elements so that they can monitor progress and make sure that the system meets the users' requirements. For example, they link use cases to test case work items so they can see that use cases are fulfilled when all the tests pass.

Before teams check in their changes, they validate the code against the tests and the design by running builds that include dependency validation and automated tests. This helps make sure that the updated code does not conflict with the design and break previously working functionality.

### Identify Changes to the Existing System

Dinner Now must estimate the cost of meeting the new requirement. This depends partly on how much this change will affect other parts of the system. To help them understand this, one of the Dinner Now developers creates these maps and diagrams from existing code:

|**Map or diagram**|**Shows**|
|-|-|
|*Code map*<br /><br /> See:<br /><br /> - [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)<br />- [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md)<br />- [Customize code maps by editing the DGML files](../modeling/customize-code-maps-by-editing-the-dgml-files.md)|Dependencies and other relationships in code.<br /><br /> For example, Dinner Now might start by reviewing assembly code maps for an overview of the assemblies and their dependencies. They can drill into the maps to explore the namespaces and classes in those assemblies.<br /><br /> Dinner Now can also create maps to explore particular areas and other kinds of relationships in the code. They use Solution Explorer to find and select the areas and relationships that interest them.|
|*Code-based class diagram*<br /><br /> See [How to: Add Class Diagrams to Projects (Class Designer)](../ide/class-designer/how-to-add-class-diagrams-to-projects.md).|Existing classes in code|

 For example, the developer creates a code map. She adjusts its scope to focus on the areas that will be affected by the new scenario. These areas are selected and highlighted on the map:

 ![Namespace Dependency Graph](../modeling/media/namespace_reviewsystem.png)

 **Namespace code map**

 The developer expands the selected namespaces to see their classes, methods, and relationships:

 ![Expanded namespace dependency graph](../modeling/media/dep_reviewsystem.png)

 **Expanded namespace code map with visible cross-group links**

 The developer examines the code to find the affected classes and methods. To see the effects of each change as you make them, regenerate code maps after each change. See [Visualize code](../modeling/visualize-code.md).

 To describe changes to other parts of the system, such as components or interactions, the team might draw these elements on whiteboards. They might also draw the following diagrams in Visual Studio so that the details can be captured, managed, and understood by both teams:

|**Diagrams**|**Describes**|
|-|-|
|*Code-based class diagram*<br /><br /> See [How to: Add Class Diagrams to Projects (Class Designer)](../ide/class-designer/how-to-add-class-diagrams-to-projects.md).|Existing classes in code.|

### <a name="ValidatingCode"></a> Keep Code Consistent with the Design
 Dinner Now must make sure that the updated code stays consistent with the design. They create dependency diagrams that describe the layers of functionality in the system, specify the permitted dependencies between them, and associate solution artifacts to those layers.

|**Diagram**|**Describes**|
|-|-|
|*Dependency diagram*<br /><br /> See:<br /><br /> - [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)<br />- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)<br />- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)|The logical architecture of the code.<br /><br /> A dependency diagram organizes and maps the artifacts in a Visual Studio solution to abstract groups called *layers*. These layers identify the roles, tasks, or functions that these artifacts perform in the system.<br /><br /> Dependency diagrams are useful for describing the intended design of the system and validating evolving code against that design.<br /><br /> To create layers, drag items from Solution Explorer, code maps, Class View, and Object Browser. To draw new layers, use the toolbox or right-click the diagram surface.<br /><br /> To view existing dependencies, right-click the dependency diagram surface, and then click **Generate Dependencies**. To specify intended dependencies, draw new dependencies.|

For example, the following dependency diagram describes dependencies between layers and the number of artifacts that are associated with each layer:

![Dependency diagram of integrated payment system](../modeling/media/layer_integrated_dnlucerne.png)

 **Dependency Diagram**

To make sure that conflicts with the design do not occur during code development, the teams uses dependency validation on builds that are run on Azure DevOps. They also create a custom MSBuild task to require dependency validation in their check-in operations. They use build reports to collect validation errors.

See:

- [Use the visual designer](/azure/devops/pipelines/get-started-designer)

- [TFVC gated check-in](/azure/devops/pipelines/build/triggers)

- [Build and release tasks](/azure/devops/pipelines/tasks/index)

### General Tips for Creating and Using Models

- Most diagrams consist of nodes that are connected by lines. For each diagram type, the toolbox provides different kinds of nodes and lines.

   To open the toolbox, on the **View** menu, click **Toolbox**.

- To create a node, drag it from the toolbox to the diagram. Certain kinds of nodes must be dragged onto existing nodes. For example, on a component diagram, a new port must be added to an existing component.

- To create a line or a connection, click the appropriate tool in the toolbox, click the source node, and then click the target node. Some lines can be created only between certain kinds of nodes. When you move the pointer over a possible source or target, the pointer indicates whether you can create a connection.

### Plan and track work

Visual Studio modeling diagrams are integrated with Team Foundation Server so that you can plan, manage, and track work more easily. Both teams use models to identify test cases and development tasks and to estimate their work. Lucerne creates and links Team Foundation Server work items to model elements, such as use cases or components. This helps them monitor their progress and trace their work back to the users' requirements. This helps them make sure that their changes continue to meet those requirements.

As their work progresses, the teams update their work items to reflect the time that they spent on their tasks. They also monitor and report status on their work by using the following Team Foundation Server features:

- Daily *burn down reports* that show whether they will complete the planned work in the expected time. They generate other similar reports from Team Foundation Server to track the progress of bugs.

- An *iteration worksheet* that uses Microsoft Excel to help the team monitor and balance the workload between its members. This worksheet is linked to Team Foundation Server and provides focus for discussion during their regular progress meetings.

- A *development dashboard* that uses Office Project to keep the team informed about important project information.

See:

- [About Agile tools and Agile project management](/azure/devops/boards/backlogs/backlogs-overview?view=vsts&preserve-view=true)

- [Charts, dashboards, and widgets (Azure DevOps Services)](/azure/devops/report/dashboards/overview?view=vsts&preserve-view=true)

- [Create your backlog and tasks using Project](/previous-versions/azure/devops/boards/backlogs/office/create-your-backlog-tasks-using-project)

### <a name="TestValidateCheckInCode"></a> Test, Validate, and Check In Code

As the teams complete each task, they check their code into source control and receive reminders from Team Foundation Server, if they forget. Before Team Foundation Server accepts their check-ins, the teams run unit tests and dependency validation to verify the code against their test cases and the design. They use Team Foundation Server to run builds, automated unit tests, and dependency validation regularly. This helps make sure that the code meets the following criteria:

- It works.

- It does not break previously working code.

- It does not conflict with the design.

Dinner Now has a large collection of automated tests, which Lucerne can reuse because almost all still apply. Lucerne can also build on these tests and add new ones to cover new functionality. Both also use Visual Studio to run manual tests.

To make sure that the code conforms to the design, the teams configure their builds in Azure DevOps to include dependency validation. If any conflicts occur, a report is generated with the details.

See:

- [Testing the application](/azure/devops/test/overview?view=vsts&preserve-view=true)

- [Validate your system during development](../modeling/validate-your-system-during-development.md)

- [Use version control](/azure/devops/repos/tfvc/overview?view=azure-devops&preserve-view=true)

- [Azure Pipelines](/azure/devops/pipelines/index?view=vsts&preserve-view=true)

## Update the System Using Visualization and Modeling

Lucerne and Dinner Now must integrate their payment systems. The following sections show the modeling diagrams in Visual Studio help them perform this task:

- [Visualize Existing Code: Code Maps](#VisualizeCode)

- [Define a Glossary of Types: Class Diagrams](#DefineClasses)

- [Describe the Logical Architecture: Dependency Diagrams](#DescribeLayers)

See:

- [Visualize code](../modeling/visualize-code.md)

- [Use models in your development process](../modeling/use-models-in-your-development-process.md)

- [Model your app's architecture](../modeling/model-your-app-s-architecture.md)

### <a name="VisualizeCode"></a> Visualize Existing Code: Code Maps

Code maps show the current organization and relationships in the code. Items are represented by *nodes* on the map, and relationships are represented by *links*. Code maps can help you perform the following kinds of tasks:

- Explore unfamiliar code.

- Understand where and how a proposed change might affect existing code.

- Find areas of complexity, natural dependencies or patterns, or other areas that might benefit from improvement.

For example, Dinner Now must estimate the cost of updating the PaymentProcessing component. This depends partly on how much this change will affect other parts of the system. To help them understand this, one of the Dinner Now developers generates code maps from the code and adjusts the scope focus on the areas that might be affected by the change.

The following map shows the dependencies between the PaymentProcessing class and other parts of the Dinner Now system, which appear selected:

![Dependency graph for Dinner Now payment system](../modeling/media/dep_dnpayment.png)

**Code map for Dinner Now payment system**

The developer explores the map by expanding the PaymentProcessing class and selecting its members to see the areas that are potentially affected:

![Methods inside PaymentProcessing and dependencies](../modeling/media/depgraph_expandeddn.png)

**Methods inside PaymentProcessing class and their dependencies**

They generate the following map for the Lucerne Payment System to inspect its classes, methods, and dependencies. The team sees that the Lucerne system might also require work to interact with the other parts of Dinner Now:

![Dependency graph for Lucerne payment system](../modeling/media/depgraph_lucernepay.png)

**Code map for Lucerne Payment System**

Both teams work together to determine the changes that are required to integrate the two systems. They decide to refactor some of the code so that it will be easier to update. The PaymentApprover class will move to the DinnerNow.Business namespace and will require some new methods. The Dinner Now classes that handle transactions will have their own namespace. The teams create and use work items to plan, organize, and track their work. They link the work items to model elements where it is useful.

After reorganizing the code, the teams generate a new code map to see the updated structure and relationships:

![Dependency graph with reorganized code](../modeling/media/depgraph_integrated.png)

**Code map with reorganized code**

This map shows that the PaymentApprover class is now in the DinnerNow.Business namespace and has some new methods. The Dinner Now transaction classes now have their own PaymentSystem namespace, which makes it easier to deal with that code later.

#### Creating a Code Map

- For a quick overview of source code, follow these steps to generate a code map:

     On the **Architecture** menu, click **Generate Code Map For Solution**.

     For a quick overview of compiled code, create a blank code map, and then drag assembly files or binary files to the map surface.

- To explore specific code or solution items, use Solution Explorer to select items and relationships that you want to visualize. You can then either generate a new map or add selected items to an existing map. See [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md).

- To help you explore the map, rearrange the layout so that it suits the kinds of tasks that you want to perform.

     For example, to visualize layering in the code, select a tree layout. See [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md).

#### Summary: Strengths of Code Maps
 Code maps help you:

- Learn about the organization and relationships in existing code.

- Identify areas that might be affected by a proposed change.

- Find areas of complexity, patterns, layers, or other areas that you could improve to make the code easier to maintain, change, and reuse.

#### Relationship to Other Diagrams

|**Diagram**|**Describes**|
|-|-|
|Dependency diagram|The logical architecture of the system. Use dependency validation to make sure that the code stays consistent with the design.<br /><br /> To help you identify existing dependencies or intended dependencies, create a code map and group related items. To create a dependency diagram, see:<br /><br /> - [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)|
|Class diagram (code-based)|Existing classes in code for a specific project.<br /><br /> To visualize and modify an existing class in code, use Class Designer.<br /><br /> See [How to: Add Class Diagrams to Projects (Class Designer)](../ide/class-designer/how-to-add-class-diagrams-to-projects.md).|

### <a name="DefineClasses"></a> Define a Glossary of Types: Class Diagrams
 Class diagrams define the entities, terms, or concepts that participate in the system and their relationships with one another. For example, you can use these diagrams during development to describe the attributes and operations for each class, regardless of their implementation language or style.

 To help Lucerne describe and discuss the entities that participate in the Process Payment use case, they draw the following class diagram:

 ![Process Payment entities on the class diagram](../modeling/media/uml_payentities.png)

 **Process Payment entities on a class diagram**

 This diagram shows that a Customer can have many orders and different ways to pay for orders. BankAccount and CreditCard both inherit from Payment.

 During development, Lucerne uses the following class diagram to describe and discuss the details of each class:

 ![Process Payment entity details on a class diagram](../modeling/media/uml_payment.png)

 **Process Payment details on the class diagram**

#### Drawing a Class Diagram

A class diagram has the following major features:

- Types such as classes, interfaces, and enumerations:

  - A *class* is the definition of objects that share specific structural or behavioral characteristics.

  - An *interface* defines a part of the externally visible behavior of an object.

  - An *enumeration* is a classifier that contains a list of literal values.

- *Attributes* are values of a certain type that describe each instance of a *classifier*. A classifier is a general name for types, components, use cases, and even actors.

- *Operations* are methods or functions that instances of a classifier can perform.

- An *association* indicates some kind of relationship between two classifiers.

  - An *aggregation* is an association that indicates a shared ownership between classifiers.

  - A *composition* is an association that indicates a whole-part relationship between classifiers.

    To show aggregations or compositions, set the **Aggregation** property on an association. **Shared** shows aggregations and **Composite** shows compositions.

- A *dependency* indicates that changing the definition of one classifier might change the definition of another classifier.

- A *generalization* indicates that a specific classifier inherits part of its definition from a general classifier. A *realization* indicates that a class implements the operations and attributes offered by an interface.

     To create these relationships, use the **Inheritance** tool. Alternatively, a realization can be represented as a *lollipop*.

- *Packages* are groups of classifiers, associations, lifelines, components, and other packages. *Import* relationships indicate that one package includes all definitions of another package.

As a starting point to explore and discuss existing classes, you can use Class Designer to create class diagrams from code.

- [How to: Add Class Diagrams to Projects (Class Designer)](../ide/class-designer/how-to-add-class-diagrams-to-projects.md)

#### Summary: Strengths of Class Diagrams
 Class diagrams help you define:

- A common glossary of terms to use when discussing the users' needs and the entities that participate in the system. See [Model user requirements](../modeling/model-user-requirements.md).

- Types that are used by parts of the system, such as components, regardless of their implementation. See [Model your app's architecture](../modeling/model-your-app-s-architecture.md).

- Relationships, such as dependencies, between types. For example, you can show that one type can be associated with multiple instances of another type.

#### Relationship to Other Diagrams

|**Diagram**|**Description**|
|-|-|
|Dependency diagram|Define the logical architecture of the system as it relates to classes.<br /><br /> Use dependency validation to make sure that the code stays consistent with the design.<br /><br /> See:<br /><br /> - [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)<br />- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)<br />- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)|
|Code map|Visualize the organization and relationships in existing code.<br /><br /> To identify classes, their relationships, and their methods, create a code map that shows those elements.<br /><br /> See:<br /><br /> - [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)|

### <a name="DescribeLayers"></a> Describe the Logical Architecture: dependency Diagrams
 Dependency diagrams describe the logical architecture of a system by organizing the artifacts in your solution into abstract groups, or *layers*. Artifacts can be many things, such as namespaces, projects, classes, methods, and so on. Layers represent and describe the roles or tasks that the artifacts perform in the system. You can also include layer validation in your build and check-in operations to make sure that the code stays consistent with its design.

 To keep the code consistent with the design, Dinner Now and Lucerne use the following dependency diagram to validate their code as it evolves:

 ![Dependency diagram of integrated payment system](../modeling/media/layer_integrated_dnlucerne.png)

 **Dependency diagram for Dinner Now integrated with Lucerne**

 The layers on this diagram link to the corresponding Dinner Now and Lucerne solution artifacts. For example, the Business layer links to the DinnerNow.Business namespace and its members, which now include the PaymentApprover class. The Resource Access layer links to the DinnerNow.Data namespace. The arrows, or *dependencies*, specify that only the Business layer can use the functionality in the Resource Access layer. As the teams update their code, layer validation is performed regularly to catch conflicts as they occur and to help the teams resolve them promptly.

 The teams work together to incrementally integrate and test the two systems. They first make sure that PaymentApprover and the rest of Dinner Now work with one another successfully before they deal with PaymentProcessing.

 The following code map shows the new calls between the Dinner Now and PaymentApprover:

 ![Updated dependency graph with integrated system](../modeling/media/depgraph_intsystem.png)

 **Code map with updated method calls**

 After they confirm that the system works as expected, Dinner Now comments out the PaymentProcessing code. The layer validation reports are clean, and the resulting code map shows that no more PaymentProcessing dependencies exist:

 ![Dependency graph without PaymentProcessing](../modeling/media/depgraph_nomore.png)

 **Code map without PaymentProcessing**

#### Drawing a Dependency Diagram

A dependency diagram has the following major features:

- *Layers* describe logical groups of artifacts.

- A *link* is an association between a layer and an artifact.

     To create layers from artifacts, drag items from Solution Explorer, code maps, Class View, or Object Browser. To draw new layers and then link them to artifacts, use the toolbox or right-click the diagram surface to create the layers, and then drag items to those layers.

     The number on a layer shows the number of artifacts that are linked to the layer. These artifacts can be namespaces, projects, classes, methods, and so on. When you interpret the number of artifacts on a layer, remember the following:

  - If a layer links to an artifact that contains other artifacts, but the layer does not link directly to the other artifacts, then the number includes only the linked artifact. However, the other artifacts are included for analysis during layer validation.

       For example, if a layer is linked to a single namespace, then the number of linked artifacts is 1, even if the namespace contains classes. If the layer also has links to each class in the namespace, then the number will include the linked classes.

  - If a layer contains other layers that are linked to artifacts, then the container layer is also linked to those artifacts, even though the number on the container layer does not include those artifacts.

    To see the artifacts that are linked to a layer, right-click the dependency, and then click **View Links** to open **Layer Explorer**.

- A *dependency* indicates that one layer can use the functionality in another layer, but not vice versa. A *bidirectional dependency* indicates that one layer can use the functionality in another layer, and vice versa.

     To display existing dependencies on the dependency diagram, right-click the diagram surface, and then click **Generate Dependencies**. To describe intended dependencies, draw new ones.

See:

- [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)

- [Dependency Diagrams: Reference](../modeling/layer-diagrams-reference.md)

- [Dependency Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)

- [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)

#### Summary: Strengths of Dependency Diagrams

Dependency diagrams help you:

- Describe the logical architecture of a system according to the functionality of its artifacts.

- Make sure that code under development conforms to the specified design.

#### Relationship to Other Diagrams

|**Diagram**|**Description**|
|-|-|
|Code map|Visualize the organization and relationships in existing code.<br /><br /> To create layers, generate a code map, and then group items on the map as potential layers. Drag the groups from the map to the dependency diagram.<br /><br /> See:<br /><br /> - [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)<br />- [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md)|

## External Resources

|**Category**|**Links**|
|-|-|
|**Forums**|- [Visual Studio Visualization & Modeling Tools](https://social.msdn.microsoft.com/Forums/en-US/home?forum=vsarch)<br />- [Visual Studio Visualization & Modeling SDK (DSL Tools)](https://social.msdn.microsoft.com/Forums/home?forum=dslvsarchx)|

## See also

- [Visualize code](../modeling/visualize-code.md)
- [Use models in your development process](../modeling/use-models-in-your-development-process.md)
- [Use models in Agile development](/previous-versions/ff398061(v=vs.140))
- [Validate your system during development](../modeling/validate-your-system-during-development.md)
