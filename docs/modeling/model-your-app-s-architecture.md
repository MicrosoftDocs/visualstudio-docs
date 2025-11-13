---
title: Model your app&apos;s architecture
description: Learn how you can create models in Visual Studio as part of your description of the overall structure and behavior of your software system or application.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- UML, modeling architecture
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Model your app&#39;s architecture

To help ensure that your software system or application meets your users' needs, you can create models in Visual Studio as part of your description of the overall structure and behavior of your software system or application. Using models, you can also describe patterns that are used throughout the design. These models help you understand the existing architecture, discuss changes, and communicate your intentions clearly.

 To see which editions of Visual Studio support this feature, see [Edition support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

 The purpose of a model is to reduce the ambiguities that occur in natural-language descriptions, and to help you and your colleagues to visualize the design and to discuss alternative designs. A model should be used together with other documents or discussions. By itself, a model does not represent a complete specification of the architecture.

> [!NOTE]
> Throughout this topic, "system" means the software that you are developing. It might be a large collection of many software and hardware components, or a single application, or a part of an application.

 The architecture of a system can be divided into two areas:

- [High-level Design](#Structure). This describes the major components and how they interact with one another to fulfill each requirement. If the system is large, each component might have its own high-level design that shows how it is composed of smaller components.

- [Design Patterns](#Patterns) and conventions used throughout the designs of the components. A pattern describes a particular approach to achieving a programming goal. By using the same patterns throughout a design, your team can reduce the cost of making changes and developing new software.

## <a name="Structure"></a> High-level Design
 A high-level design describes the major components of your system and how they interact with one another to achieve the goals of the design. The activities in the following list are involved in developing the high level design, although not necessarily in a particular sequence.

 If you are updating existing code, you might begin by describing the major components. Make sure you understand any changes to the user requirements and then add or modify interactions between the components. If you are developing a new system, begin by understanding the main features of the users' needs. You can then explore sequences of interactions for the main use cases, and then consolidate the sequences into a component design.

 In every case, it is helpful to develop the different activities in parallel, and to develop code and tests at an early stage. Avoid trying to complete one of these aspects before you start another. Typically, both the requirements and your understanding of the best way to design the system will change while you are writing and testing the code. Therefore, you should begin by understanding and coding the main features of the requirements and your design. Fill in the details in later iterations of the project.

- [Understanding the Requirements](#Requirements). The starting point of any design is a clear understanding of the users' needs.

- [Architectural Patterns](#BigDecisions). The choices you made about core technologies and architectural elements of the system.

- Data Model of the Components and Interfaces. You can draw class diagrams to describe the information that is passed between components and stored inside the components.

## <a name="Requirements"></a> Understanding the Requirements
 The high-level design of a complete application is most effectively developed together with a requirements model or other description of the users' needs. For more information about requirements models, see [Model user requirements](../modeling/model-user-requirements.md).

 If the system that you are developing is a component in a larger system, part or all of your requirements might be embodied in programmatic interfaces.

 The requirements model provides these essential pieces of information:

- Provided interfaces. A provided interface lists the services or operations that the system or component must provide to its users, whether they are human users or other software components.

- Required interfaces. A required interface lists the services or operations that the system or component can use. In some cases, you will be able to design all these services as part of your own system. In other cases, especially if you are designing a component that can be combined with other components in many configurations, the required interface will be set by external considerations.

- Quality of service requirements. The performance, security, robustness, and other goals and constraints that the system must meet.

  The requirements model is written from the point of view of your system's users, whether they are people or other software components. They know nothing of the internal workings of your system. By contrast, your goal in an architectural model is to describe the internal workings and show how they meet the users' needs.

  Keeping the requirements and architectural models separate is useful because it makes it easier to discuss the requirements with the users. It also helps you refactor the design and consider alternative architectures while keeping the requirements unchanged.

  The amount of detail that you should put into either a requirements or an architectural model depends on the scale of the project and the size and distribution of the team. A small team on a short project might go no further than sketching a class diagram of the business concepts and some design patterns; a large project distributed over more than one region would need significantly more detail.

## <a name="BigDecisions"></a> Architectural Patterns
 Early in a development, you have to choose the major technologies and elements on which the design depends. The areas in which these choices must be made include the following:

- Base technology choices, such as the choice between a database and a file system, and the choice between a networked application and a web client, and so on.

- Frameworks choices, such as a choice between Windows Workflow Foundation or ADO.NET Entity Framework.

- Integration method choices, for example between an enterprise service bus or a point-to-point channel.

  These choices are frequently determined by quality of service requirements such as scale and flexibility, and can be made before the detailed requirements are known. In a large system, the configuration of hardware and software are strongly interrelated.

  The selections that you make affect how you use and interpret the architectural model. For example, in a system that uses a database, associations in a class diagram might represent relations or foreign keys in the database, whereas in a system that is based on XML files, associations might indicate cross-references that use XPath. In a distributed system, messages in a sequence diagram can represent messages on a wire; in a self-contained application, they can represent function calls.

## <a name="Patterns"></a> Design Patterns
 A design pattern is an outline of how to design a particular aspect of the software, especially one that recurs in different parts of the system. By adopting a uniform approach across the project, you can reduce the cost of design, ensure consistency in the user interface, and reduce the cost of understanding and changing the code.

 Some general design patterns such as Observer are well-known and widely applicable. In addition, there are patterns that are applicable just to your project. For example, in a web sales system, there will be several operations in the code where changes are made to a customer's order. To ensure that the state of the order is accurately displayed at every stage, all these operations must follow a particular protocol to update the database.

 Part of the work of software architecture is to determine what patterns should be adopted across the design. This is usually an ongoing task, because new patterns and improvements to existing patterns will be discovered as the project progresses. It is helpful to organize the development plan so that you exercise each of your major design patterns at an early stage.

 Most design patterns can be partly embodied in framework code. Part of the pattern can be reduced to requiring the developer to use particular classes or components, such as a database access layer that ensures the database is handled correctly.

 A design pattern is described in a document, and typically includes these parts:

- Name.

- Description of the context in which it is applicable. What criteria should make a developer consider applying this pattern?

- Brief explanation of the problem it solves.

- Model of the major parts and their relationships. These might be classes or components and interfaces, with associations and dependencies between them. The elements usually fall into two categories:

- Naming conventions.

- Description of how the pattern solves the problem.

- Description of variations that developers might be able to adopt.

## Related content

- [Visualize code](../modeling/visualize-code.md)
- [Model user requirements](../modeling/model-user-requirements.md)
- [Develop tests from a model](../modeling/develop-tests-from-a-model.md)
- [Use models in your development process](../modeling/use-models-in-your-development-process.md)
