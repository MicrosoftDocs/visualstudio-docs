---
title: About Domain-Specific Languages
description: Learn how a domain-specific language (DSL) is designed to express statements in a particular problem space, or domain.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- Domain-Specific Language
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# About Domain-Specific Languages

Unlike a general-purpose language such as C# or UML, a domain-specific language (DSL) is designed to express statements in a particular problem space, or domain.

Well-known DSLs include regular expressions and SQL. Each DSL is much better than a general-purpose language for describing operations on text strings or a database, but much worse for describing ideas that are outside its own scope. Individual industries also have their own DSLs. For example, in the telecommunications industry, call description languages are widely used to specify the sequence of states in a telephone call, and in the air travel industry a standard DSL is used to describe flight bookings.

Your business and your project also deal with special sets of concepts that could be described with a DSL. For example, you could define a DSL for one of these applications:

- Plan of navigation paths in a website.

- Wiring diagrams for electronic components.

- Networks of conveyor belts and baggage handling equipment for an airport.

When you design a DSL, you define a *domain class* for each of the important concepts in the domain, such as a web page, lamp, or airport check-in desk. You define *domain relationships* such as hyperlink, wire, or a conveyor belt to link the concepts together.

Users of your DSL create *models.* Models are *instances* of the DSL. For example, they describe a particular website, or the wiring of a particular device, or the baggage handling system in a particular airport.

Your users can view a model as a diagram or as a Windows form. Models can also be viewed as XML, which is how they are stored. When you define a DSL, you define how the instances of each domain class and relationship appear on the user's screen. A typical DSL is displayed as a collection of icons or rectangles connected by arrows.

The following figure shows a small model in a diagrammatic DSL:

![Tudor Family Tree Model](../modeling/media/tudor_familytreemodel.png)

## What you can do with DSLs

A typical application of a DSL is to generate program code or other artifacts. When you define your DSL, you can define *text templates* that read a model of the DSL and generate text files.

For example, you could write templates that take an airport plan and generate part of the software for baggage handling, as well as some of the user documents that describe the plan.

When you have defined a DSL, you can distribute it to other users who can install it on their own computers. Users of your DSL can create and edit models in Visual Studio.

You can also define menu commands and other tools that help users edit the DSL, validation constraints to help ensure that the DSL is used correctly, and item templates that help users create new instances. You can wrap one or more DSLs with their tools and other Visual Studio extensions as an integrated package.

Typically, a domain-specific language is created when a development team has to write similar code for several products. For example, a company that specializes in baggage handling systems might define a baggage track DSL from which they can generate some of the code for each installation. The benefits of the DSL are that it can be understood by their customers, that the code generated from it is reliable, and that the system can be rapidly updated if the customers' requirements change.

Domain-Specific Language Tools lets you create a domain-specific language that has your own graphical designer and your own diagram notation, and then use the language to generate appropriate source code for each project.

## Domain-Specific Development

Domain-specific development is the process of identifying the parts of your applications that can be modeled by using a domain-specific language, and then constructing the language and deploying it to the application developers. The developers use the domain-specific language to construct models that are specific to their applications, use the models to generate source code, and then use the source code to develop the applications.

## Aspects of Graphical Domain-Specific Development

A graphical domain-specific language must include the following features:

- Notation

- Domain model

- Artifact generation

- Serialization

- Integration with Visual Studio

### Notation

A domain-specific language must have a reasonably small set of elements that can be easily defined and extended to represent domain-specific constructs. A notation consists of shapes, which represent the elements, and connectors, which represent the relationships between elements, on a graphical diagram surface. In Domain-Specific Language Tools, the shapes can be extended and refined to represent the elements of your domain-specific language.

### Domain Model

A domain-specific language must combine the set of elements and the relationships between them into a coherent grammar. It must also define whether combinations of elements and relationships are valid. For example, programming languages typically prevent circular inheritance, in which one class is derived from a second class and the second class is derived from the first class. Constraints can also be used to express business logic, for example, one person cannot be a dependent of himself. Domain-Specific Language Tools uses constraints to express the kinds of restrictions that most domain-specific languages require.

### Artifact Generation

One of the main purposes of a domain-specific language is to generate an artifact, for example, source code, an XML file, or some other usable data. Typically, a change in the model means a change in the artifact. You can use Domain-Specific Language Tools to generate artifacts and to regenerate them when you change the model.

### Serialization

A domain-specific language must be persisted in some form that can be edited, saved, closed, and reloaded. Domain-Specific Language Tools uses an XML format that lets you define and customize how your domain-specific language is serialized or persisted.

### Integration with Visual Studio

Because Domain-Specific Language Tools is hosted in Visual Studio, it extends many Visual Studio windows and controls. It also lets you customize the behavior of menu commands, toolbox items, and other elements of the user interface.

You can also create a Model Bus Adapter for your domain-specific language. This adapter lets you reference a model and elements within a model, and lets you write code that can access and update an instance of the DSL. By using the powerful Model Bus mechanism, you can write Visual Studio extensions that work with multiple models. You can also write stand-alone applications that work with models. For more information, see [Integrating Models by using Visual Studio Modelbus](../modeling/integrating-models-by-using-visual-studio-modelbus.md).

## Benefits of Domain-Specific Development

A domain-specific language can provide the following benefits:

- Contains constructs that exactly fit the problem space.

     Unlike general-purpose languages, a domain-specific language consists of elements and relationships that directly represent the logic of the problem space. For example, an insurance policy application must include elements for policies and claims. A domain-specific language makes it easier to design the application, and find and correct errors of logic.

- Lets non-developers and people who do not know the domain understand the overall design.

     By using a graphical domain-specific language, you can create a visual representation of the domain so that non-developers can easily understand the design of the application.

- Makes it easier to create a prototype of the final application.

     Developers can use the code that their model generates to create a prototype application that they can show to clients.

## The Process of Domain-Specific Development

Most software development teams that use domain-specific languages follow these steps to create and use their models:

- The team distinguishes the variable parts of the domain from the parts that never change.

- The developers write code for the fixed parts and leave extension points for the variable parts.

- The lead software developer or the architect creates a domain-specific language that incorporates the design patterns of the fixed parts of the domain and the extension points for the variable parts.

- The lead software developer or the architect deploys the domain-specific language to the developers of the various applications that the team produces.

- Every developer creates a model that applies to the specific application.
