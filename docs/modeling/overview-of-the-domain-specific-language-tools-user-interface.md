---
title: Overview of the Domain-Specific Language Tools User Interface
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
  - "vs.dsltools.dsldesigner.editor"
helpviewer_keywords:
  - "Domain-Specific Language Tools, user interface"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Overview of the Domain-Specific Language Tools User Interface
When you first open a Domain-Specific Language Tools (DSL Tools) solution in Visual Studio, the user interface will resemble the following picture.

 ![dsl designer](../modeling/media/dsl_designer.png)

 The following table explains how the parts of the UI are used.

|**Element**|**Definition**|
|-|-|
|Diagram|The diagram displays the domain model.<br /><br /> The diagram has two sides. One side defines the types of the elements in your models. The other side defines how your models will appear on the screen.|
|Toolbox|Drag tools from the toolbox to add domain classes and shape types to the diagram. To add relationships, connectors and shape maps, click the tool, then click the source node on the diagram, and then the target node.|
|DSL Explorer|**DSL Explorer** appears when a DSL definition is the active window. It shows the DSL as a tree. DSL Explorer lets you edit features of the model that are not displayed on the diagram. For example, you can add toolbox items and switch on the validation process by using the **DSL Explorer**.|
|DSL Details window|The **DSL Details** window shows properties of the domain model's elements that allow you to control how elements are displayed, and how elements are copied and deleted.<br /><br /> -   By default, the **DSL Details** window appears next to the **Error List** and **Output** windows.|

## The Domain Model Diagram
 The domain model diagram is divided into two parts. One side of the diagram shows the elements and relationships in the model. The other side shows how the model is to be displayed, and includes the shapes that are used to display the elements and the properties of the model diagram. The following picture shows the elements of the diagram.

 ![dsl designer with swimlane](../modeling/media/dsl_desinger.png)

 The following table explains some of the elements of the domain model diagram.

|**Term**|**Definition**|
|-|-|
|Domain Class|Domain classes are the types of elements in your models.<br /><br /> A domain class can appear more than once in a diagram, if it is the target of more than one relationship.<br /><br /> To add a domain class, drag the domain class tool from the **Toolbox** to the **Classes and Relationships** side of the diagram.|
|Domain Relationship|Domain relationships are the types of links between elements in your models.<br /><br /> An *embedding relationship* indicates that the target element is owned or contained by the source element, and appears as a solid line. Every element in a model should be the target of one embedding relationship, so that the model forms a tree. A *reference relationship* indicates a general link between model elements, and appears as a dashed line. Any element can have any number of reference links.<br /><br /> Create a relationship by clicking the tool on the **Toolbox**, clicking the source domain class, and then clicking the target class.|
|Shapes and Connectors|Shapes specify how model elements should be displayed on a DSL diagram., Connectors specify lines on a DSL diagram that can be used to display relationships.<br /><br /> To create a shape or connector, drag the tool to the **Diagram Elements** side of the diagram.|
|Shape Maps|A shape map appears as a line on the domain model diagram, linking a shape to the domain class that it displays, or a connector to the domain relationship that it displays.|

## See also

- [Overview of Domain-Specific Language Tools](../modeling/overview-of-domain-specific-language-tools.md)
- [Domain-Specific Language Tools Glossary](https://msdn.microsoft.com/ca5e84cb-a315-465c-be24-76aa3df276aa)
- [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md)