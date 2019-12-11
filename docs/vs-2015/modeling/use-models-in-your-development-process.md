---
title: "Use models in your development process | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML, using models"
ms.assetid: a33ac8fc-4ba0-4850-b71b-014dc8674e54
caps.latest.revision: 31
author: jillre
ms.author: jillfra
manager: jillfra
---
# Use models in your development process
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can use a model to help you understand and change a system, application, or component. A model can help you visualize the world in which your system works, clarify users' needs, define the architecture of your system, analyze the code, and ensure that your code meets the requirements. See [Channel 9 Video: Improve architecture through modeling](https://go.microsoft.com/fwlink/?LinkID=252078).

 To see which versions of Visual Studio support each type of model, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## How to use models
 Models can help you in several ways:

- Drawing modeling diagrams helps you clarify the concepts involved in requirements, architecture, and high-level design. For more information, see [Model user requirements](../modeling/model-user-requirements.md).

- Working with models can help you expose inconsistencies in requirements.

- Communicating with models helps you communicate important concepts less ambiguously than with natural language. For more information, see [Model your app's architecture](../modeling/model-your-app-s-architecture.md).

- You can sometimes use models to generate code or other artifacts such as database schemas or documents. For example, the modeling components of [!INCLUDE[vsUltShort](../includes/vsultshort-md.md)] are generated from a model.  For more information, see [Generate and configure your app from models](../modeling/generate-and-configure-your-app-from-models.md).

  You can use models in a wide variety of processes, from extreme agile to high ceremony.

### Use Models to Reduce Ambiguity
 Modeling language is less ambiguous than natural language, and it is designed to express the ideas typically required during software development.

 If your project has a small team following agile practices, you can use models to help you clarify user stories. In discussions with the customer about their needs, creating a model can generate useful questions much faster, and across a broader area of the product, than writing spike or prototype code.

 If your project is large and includes teams in different parts of the globe, you can use models to help communicate the requirements and architecture much more effectively than you can in plain text.

 In both cases creating a model almost always results in a significant reduction in inconsistencies and ambiguities. Different stakeholders frequently have different understandings of the business world in which the system works, and different developers frequently have different understandings of how the system works. Using a model as the focus of a discussion usually exposes these differences. For more information about how to use a model to reduce inconsistencies, see [Model user requirements](../modeling/model-user-requirements.md).

### Use Models with Other Artifacts
 A model is not by itself a requirements specification or an architecture. It is a tool for expressing some aspects of these things more clearly, but not all the concepts required during software design can be expressed. The models should therefore be used together with other means of communication, such as OneNote pages or paragraphs, Microsoft Office documents, work items in [!INCLUDE[esprfound](../includes/esprfound-md.md)], or sticky notes on the project room wall. Apart from the last item, all of these object types can be linked to elements parts of the model.

 Other aspects of specification that are ordinarily used together with models include the following. Depending on the scale and style of your project, you might use several of these aspects or not use any at all:

- User stories. A user story is a short description, discussed with users and other stakeholders, of an aspect of the system's behavior that will be delivered in one of the project's iterations. A typical user story begins "The customer will be able to…." A user story might introduce a group of use cases, or can define extensions of use cases that have been previously developed. Defining or extending the use cases helps make the user story clearer.

- Change Requests. A change request in a more formal project is very similar to a user story in an agile project. The agile approach treats all requirements as changes to what was developed in previous iterations.

- Use case description. A use case represents one way in which a user interacts with the system to achieve a particular goal. A full description includes the goal, main and alternative sequences of events, and exceptional outcomes. A use case diagram helps summarize and provide an overview of the use cases.

- Scenarios. A scenario is a fairly detailed description of a sequence of events showing how the system, users and other systems work together to provide value to the stakeholders. It might take the form of a slide show of the user interface or a prototype of the user interface. It can describe one use case or a sequence of use cases.

- Glossary. The project's requirements glossary describes the words with which customers discuss their world. The user interface and requirements models should also use these terms. A class diagram can help clarify the relationships between most of these terms. Creating the diagrams and glossary not only reduces misunderstandings between users and developers, but also almost always exposes misunderstandings between different business stakeholders.

- Business rules. Many business rules can be expressed as invariant constraints on the associations and attributes in the requirements class model, and as constraints on sequence diagrams.

- High-level design. Describes the major parts and how they fit together. Component, sequence and interface diagrams are a major part of a high-level design.

- Design patterns. Describe the rules of design that are shared across the different parts of the system.

- Test specifications. Test scripts and the designs for test code can make good use of activity and sequence diagrams to describe sequences of test steps. System tests should be expressed in terms of the requirements model so that they can easily be changed when the requirements change.

- Project plan. The project plan or backlog defines when each feature will be delivered. You can define each feature by stating what use cases and business rules it implements or extends. You can either refer to the use cases and business rules directly in the plan, or you can define a set of features in a separate document, and use the feature titles in the plan.

### Use Models in Iteration Planning
 Although all projects are different in their scale and organization, a typical project is planned as a series of iterations of between two and six weeks. It is important to plan enough iterations to allow feedback from early iterations to be used to adjust the scope and plans for later iterations.

 You might find the following suggestions useful to help realize the benefits of modeling in an iterative project.

#### Sharpen Focus as each Iteration Approaches
 As each iteration approaches, use models to help define what is to be delivered at the end of the iteration.

- Do not model everything in detail in the early iterations. In the first iteration, create a class diagram for the main items in the user glossary, draw a diagram of the major use cases, and draw a diagram of the major components. Do not describe any of these in fine detail, because the detail will change later in the project. Use the terms defined in this model to create a list of features or major user stories. Assign the features to iterations so as to approximately balance the estimated workload throughout the project. These assignments will change later in the project.

- Try to implement simplified versions of all the most important use cases in an early iteration. Extend those use cases in later iterations. This approach helps reduce the risk of discovering a flaw in the requirements or the architecture too late in the project to do anything about it.

- Near the end of each iteration, hold a requirements workshop to define in detail the requirements or user stories that will be developed in the next iteration. Invite users and business stakeholders who can decide priorities, as well as developers and system testers. Allow three hours to define requirements for a 2-week iteration.

- The objective of the workshop is for everyone to agree what will be accomplished by the end of the next iteration. Use models as one of the tools to help clarify the requirements. The output of the workshop is an iteration backlog: that is, a list of development tasks in [!INCLUDE[esprfound](../includes/esprfound-md.md)] and test suites in [!INCLUDE[TCMext](../includes/tcmext-md.md)].

- In the requirements workshop, discuss the design only insofar as you need to determine estimates for the development tasks. Otherwise, keep discussion to system behavior that users can experience directly. Keep the requirements model separate from the architectural model.

- Nontechnical stakeholders usually have no problems understanding UML diagrams, with some guidance from you.

#### Link Model to Work Items
 After the requirements workshop, elaborate the details of the requirements model, and link the model to development tasks. You can do this by linking work items in [!INCLUDE[esprfound](../includes/esprfound-md.md)] to elements in the model. To learn how to do this, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).

 You can link any element to work items, but the most useful elements are as follows:

- Use cases. You can link a use case to the development tasks that will implement it.

- Use case extensions. If only one aspect of a use case will be implemented in an iteration, you can separate it into a base use case together with one or more extensions. The extensions are use cases linked to the base case with the «extend» relationship. For more information about use case extension, see [UML Use Case Diagrams: Reference](../modeling/uml-use-case-diagrams-reference.md).

- Comments describing business rules or quality of service requirements. For more information, see [Model user requirements](../modeling/model-user-requirements.md).

#### Link Model to Tests
 Use the requirements model to guide the design of the acceptance tests. Create these tests concurrently with the development work.

 To learn more about this technique, see [Develop tests from a model](../modeling/develop-tests-from-a-model.md).

#### Estimate Remaining Work
 A requirements model can help estimate the total size of the project in relation to the size of each iteration. Assessing the number and complexity of the use cases and classes can help you estimate the development work that will be required. When you have completed the first few iterations, a comparison of the requirements covered and the requirements still to cover can give an approximate measure of the cost and scope of the rest of the project.

 Near the end of each iteration, review the assignment of requirements to future iterations. It can be useful to represent the state of your software at the end of each iteration as a subsystem in a use case diagram. In your discussions, you can move use cases and use case extensions from one of these subsystems to another.

## Levels of abstraction
 Models have a range of abstraction in relation to the software. The most concrete models directly represent program code, and the most abstract models represent business concepts that might or might not be represented in the code.

 A model can be viewed through several kinds of diagrams. For information about models and diagrams, see [Create models for your app](../modeling/create-models-for-your-app.md).

 Different kinds of diagram are useful for describing the design at different levels of abstraction. Many of the diagram types are useful at more than one level. This table shows how each type of diagram can be used.

|Design level|Diagram types|
|------------------|-------------------|
|Business Process<br /><br /> Understanding the context within which your system will be used helps you understand what the users need from it.|-   Activity diagrams describe the flow of work between people and systems to achieve business goals.<br />-   Conceptual class diagrams describe the business concepts used within the business process.|
|User requirements<br /><br /> Definition of what the users need from your system.|-   Use case diagrams summarize the interactions that the users and other external systems have with the system that you are developing. You can attach other documents to each use case to describe it in detail.<br />-   UML class diagrams describe the types of information that the users and system communicate about.<br />-   Business rules and quality of service requirements can be described in separate documents.|
|High level design<br /><br /> The overall structure of the system: the major components and how they couple together.|-   Layer Diagrams describe how the system is structured into interdependent parts. You can validate program code against layer diagrams to ensure that it adheres to the architecture.<br />-   Component diagrams show the interfaces of the parts, specifying the messages and services that are provided and required by each component.<br />-   Sequence diagrams show how the components communicate to implement each use case.<br />-   UML class diagrams describe the interfaces of the components and the types of data passed between the components.|
|Design patterns<br /><br /> Conventions and methods of solving design problems that are used in all parts of the design|-   UML class diagrams describe the structures of a pattern<br />-   Sequence or activity diagrams show the interactions and algorithms|
|Code analysis<br /><br /> Several types of diagram can be generated from the code.|-   Sequence diagrams show the interaction between objects in the code.<br />-   Layer diagrams show the dependencies between classes. Updated code can be validated against a layer diagram.<br />-   Class diagrams show the classes in the code.|

## External Resources

|**Category**|**Links**|
|------------------|---------------|
|**Videos**|![link to video](../data-tools/media/playvideo.gif "PlayVideo") [MSDN How Do I Videos: How to Create and Use UML Models and Diagrams (Visual Studio 2010 Ultimate)](https://go.microsoft.com/fwlink/?LinkId=214460)<br /><br /> ![link to video](../data-tools/media/playvideo.gif "PlayVideo") [Channel 9: UML with Visual Studio 2010](https://go.microsoft.com/fwlink/?LinkID=201106)<br /><br /> ![link to video](../data-tools/media/playvideo.gif "PlayVideo") [MSDN How Do I Series: UML Tools and Extensibility (Visual Studio 2010 Ultimate)](https://go.microsoft.com/fwlink/?LinkID=214467)|
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](https://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](https://go.microsoft.com/fwlink/?LinkId=184721)|
|**Blogs**|[Visual Studio ALM + Team Foundation Server Blog](https://go.microsoft.com/fwlink/?LinkID=201340)|
|**Technical Articles and Journals**|[MSDN Architecture Center](https://go.microsoft.com/fwlink/?LinkId=201343)<br /><br /> [Visual Studio Architecture Tooling Guidance](../modeling/visual-studio-architecture-tooling-guidance.md)|

## See Also
 [Use models in Agile development](https://msdn.microsoft.com/592ac27c-3d3e-454a-9c38-b76658ed137f)
 [Create models for your app](../modeling/create-models-for-your-app.md)
 [Model user requirements](../modeling/model-user-requirements.md)
 [Model your app's architecture](../modeling/model-your-app-s-architecture.md)
 [Develop tests from a model](../modeling/develop-tests-from-a-model.md)
 [Structure your modeling solution](../modeling/structure-your-modeling-solution.md)
