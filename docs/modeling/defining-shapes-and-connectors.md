---
title: Defining Shapes and Connectors
description: Learn about the several basic types of shapes that you can use to display information on a diagram in a domain-specific language (DSL).
ms.date: 11/04/2016
ms.topic: concept-article
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Define shapes and connectors

There are several basic types of shapes that you can used to display information on a diagram in a domain-specific language (DSL).

## <a name="shapeTypes"></a> Basic Types of Shapes and Connectors

A DSL diagram shows a collection of *shapes* interlinked by lines or *connectors*. Typically, but not always:

- Shapes are the visible representation of model elements.

- Connectors represent reference relationships.

- The diagram represents the model root instance.

- Embedding relationships between model elements are shown by containment. For example, elements representing component ports are embedded in the component.

These patterns are not enforced, but are more strongly supported. When you design a DSL, bear in mind that the design of the embedding relationships should be influenced by how you want to present the model on the screen. By contrast, the reference relationships should reflect the concepts of your business domain.

The following types of shapes are available:

|Shape type|Description|
|-|-|
|Geometry shape|General purpose rectangular or elliptical shape. You can display text and icon decorators in specific positions relative to the bounds of the shape. You can also nest shapes inside geometry shapes.|
|Compartment shape|Rectangle containing a header and compartments, like a UML class. Each compartment can contain a list of text rows.<br /><br /> The rows typically represent elements embedded under the element represented by the shape. For an example, create a DSL from the Class Diagrams solution template.|
|Image shape|Shape that displays an image.|
|Port shape|A small rectangle designed to attach to the outline of another shape. Typically used in component models.<br /><br /> The model element represented by a port is typically embedded under the element represented by the parent shape. For an example, create a DSL by using the Components solution template.<br /><br /> By default, a port shape can slide along the sides of its parent. You can define a Bounds Rule to constrain it to a particular position.<br /><br /> By making a port shape very small and transparent, you can use it to provide a fixed connection point on the surface of its parent shape.|
|Swimlanes|Swimlanes partition a diagram into horizontal or vertical segments. The swimlane always stays underneath the other shapes on the diagram.<br /><br /> Typically the model elements of the swimlane are parented on the model root, and the other elements are parented on them. For an example, create a DSL from the Task Flow solution template.|
|Connectors|The lines drawn between shapes typically represent reference relationships. You can set options to make a connector straight or rectilinear, and to have different types of arrowhead.|

## Shape inheritance

A shape can inherit from another shape. However, the shapes must be the same kind. For example, only a geometry shape can inherit from a geometry shape. Inherited shapes have the compartments and decorators of their base shape. Connectors can inherit from connectors.
