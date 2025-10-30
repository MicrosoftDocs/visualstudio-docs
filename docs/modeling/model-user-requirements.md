---
title: Model user requirements
description: Learn how Visual Studio helps you understand, discuss, and communicate your users' needs by drawing diagrams about their activities.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- requirements
- stories
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Model user requirements

Visual Studio helps you understand, discuss, and communicate your users' needs by drawing diagrams about their activities and the part your system plays in helping them achieve their goals. A requirements model is a set of these diagrams, each of which focuses on a different aspect of the users' needs.

To see which versions of Visual Studio support each type of model, see [Version support for architecture and modeling tools](../modeling/analyze-and-model-your-architecture.md#VersionSupport).

A requirements model helps you:

- Focus on the system's external behavior, separately from its internal design.

- Describe the users' and stakeholders' needs with much less ambiguity than you can in natural language.

- Define a consistent glossary of terms that can be used by users, developers, and testers.

- Reduce gaps and inconsistencies in the requirements.

- Reduce the work needed to respond to requirements changes.

- Plan the order in which features will be developed.

- Use the models as a basis for system tests, making a clear relationship between the tests and the requirements. When the requirements change, this relationship helps you update the tests correctly. This makes sure that the system meets the new requirements.

A requirements model provides greatest benefit if you use it to focus discussions with the users or their representatives, and revisit it at the beginning of each iteration. You do not have to complete it in detail before writing code. A partially working application, even if very much simplified, generally forms the most stimulating basis for discussion of the requirements with users. The model is an effective way to summarize the results of those discussions. For more information, see [Use models in your development process](../modeling/use-models-in-your-development-process.md).

> [!NOTE]
> Throughout these topics, "system" means the system or the application that you are developing. It might be a large collection of many software and hardware components; or a single application; or a software component inside a larger system. In every case, the requirements model describes the behavior that is visible from outside your system, whether through a user interface or API.

## Common tasks

You can create several different views of the users' requirements.  Each view provides a particular type of information.  When you create these views, it is best to move frequently from one to another. You can start from any view.

|Diagram or document|What it describes in a requirements model|Section|
|-|-|-|
|Conceptual class diagram|Glossary of types that are used to describe the requirements; the types visible at the system's interface.||
|Additional documents or work items|Performance, security, usability and reliability criteria.|[Describing quality of service requirements](#QoSRequirements)|
|Additional documents or work items|Constraints and rules not specific to a particular use case|[Showing business rules](#BusinessRules)|

Notice that most of the diagram types can be used for other purposes. For an overview of diagram types, see [Create models for your app](../modeling/create-models-for-your-app.md).

## <a name="BusinessRules"></a> Showing Business Rules

A business rule is a requirement that is not associated with a particular use case, and should be observed throughout the system.

Many business rules are constraints on the relationships among the conceptual classes. You can write these *static business rules* as comments associated with the relevant classes on a conceptual class diagram. For example:

![Rule in Comment attached to Order class.](../modeling/media/uml_reqmcd2.png)

*Dynamic business rules* constrain the allowable sequences of events. For example, you use a sequence or activity diagram to show that a user must log in before performing other operations on your system.

However, many dynamic rules can be more effectively and generically stated by replacing them with static rules. For example, you could add a Boolean attribute 'Logged In' to a class in the conceptual class model. You would add Logged In as the postcondition of the log in use case, and add it as a precondition of most of the other use cases. This approach lets you avoid defining all the possible combinations of sequences of events. It is also more flexible when you need to add new use cases to the model.

Notice that the choice here is about how you define the requirements, and that this is independent of how you implement the requirements in the program code.

The following topics provide more information:

|To learn about|Read|
|-|-|
|How to develop code that adheres to business rules|[Model your app's architecture](../modeling/model-your-app-s-architecture.md)|

## <a name="QoSRequirements"></a> Describing Quality of Service Requirements

There are several categories of quality of service requirement. They include the following:

- Performance

- Security

- Usability

- Reliability

- Robustness

You can include some of these requirements in the descriptions of particular use cases. Other requirements are not specific to use cases, and are most effectively written in a separate document. When you can, it is useful to adhere to the vocabulary defined by the requirements model. In the following example, notice that the main words used in the requirement are the titles of actors, use cases, and classes in the preceding illustrations:

If a Restaurant deletes a Menu Item while a Customer is Ordering a Meal, any Order Item that refers to that Menu Item will be displayed in red.

See [Model your app's architecture](../modeling/model-your-app-s-architecture.md) to learn how to develop code that adheres to quality of service requirements.

## Related content

- [Use models in your development process](../modeling/use-models-in-your-development-process.md)
- [Model your app's architecture](../modeling/model-your-app-s-architecture.md)
