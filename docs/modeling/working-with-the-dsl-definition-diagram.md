---
title: Working with the DSL Definition Diagram
description: Learn that the diagram of a DSL Tools definition is an important tool for defining a domain-specific language.
ms.date: 11/04/2016
ms.topic: concept-article
f1_keywords:
- vs.dsltools.dsldesigner.diagram
- vs.dsltools.dsldesigner.dsldiagram
helpviewer_keywords:
- Domain-Specific Language Tools, diagram
- Domain-Specific Language Tools, Split Tree
- Domain-Specific Language Tools, Show Map Lines
- Domain-Specific Language Tools, Show As Class
- Domain-Specific Language Tools, Bring Tree Here
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Working with the DSL Definition Diagram

The diagram of a Domain-Specific Language Tools definition is an important tool for defining the domain-specific language. You can add elements to your domain model and define relationships on the diagram, and you can modify the layout of the diagram to make it more readable.

## The Layout of the Diagram
 The Domain-Specific Language Tools definition diagram has two partitions, the **Classes and Relationships** partition and the **Diagram Elements** partition. The **Classes and Relationships** partition displays domain classes, domain relationships, and inheritance. The **Diagram Elements** partition displays shape classes, connector classes, swimlane classes, and the generated designer diagram.

 Domain classes can appear in multiple locations in the **Classes and Relationships** partitions. A domain class definition displays an inheritance tree if it is the base class for other domain classes, and a relationships tree if it is the source of embedding or reference relationships. Domain class placeholders appear as the targets of embedding or reference relationships. By default, placeholder elements are displayed with the **Domain Properties** compartment collapsed. They do not show inheritance, or embedding or reference relationships.

 When you add a domain class, it appears in the lower part of the **Classes and Relationships** partition. When you add an embedding or reference relationship, it is drawn under and to the right of the source domain class.

 As you add domain classes and relationships, it may become difficult to locate a particular domain class. You can find a domain class by right-clicking it in the **DSL Explorer** and then clicking **Locate in Diagram**.

 The following sections describe how you can change the appearance of the diagram to make it easier to read.

## Copying elements
 You can use copy, cut and paste on elements in the DSL definition diagram.

## Zooming In or Out on the Diagram
 You can zoom in or out on the diagram by using the **DSL Designer** toolbar to set the zoom level.

## Hiding Map Lines
 Map lines are lines that are drawn between a domain class or domain relationship and the shape or connector to which it is mapped. You can hide map lines by clicking the **Show Map Lines** button on the **DSL Designer** toolbar. To show the lines, click the button again.

## Changing the Diagram Layout
 You can change the layout of the **Classes and Relationships** partition as follows.

### Expand/Collapse
 You can reduce the size of a compartment shape element that represents a domain class or a shape by right-clicking it and then clicking **Collapse**. This hides the **Domain Properties** compartment of the shape. To show the **Domain Properties** compartment again, right-click the shape and then click **Expand**.

### Move Up/Down
 You can move a domain class or diagram element up or down in the partition by right-clicking the element and then clicking **Move Up** or **Move Down**. If you move a placeholder element that is displayed as the target of an embedding or reference relationship, the relationship will move with it.

### Expand/Collapse Relationships Tree
 If a domain class plays the source role in embedding or reference relationships with other domain classes, you can hide the relationships by right-clicking the domain class definition and then clicking **Collapse Relationships Tree**. To show the relationships, right-click the definition element and then click **Expand Relationships Tree**.

### Expand/Collapse Inheritance Tree
 If a domain class is the base class of other domain classes, you can hide the inheritance tree by right-clicking the domain class definition and then clicking **Collapse Inheritance Tree**. To show the inheritance tree, right-click the definition element and then click **Expand Inheritance Tree**.

### Bring Tree Here
 You can consolidate the diagram by right-clicking a placeholder domain class and then clicking **Bring Tree Here**. The placeholder domain class becomes a definition element and displays the inheritance and relationships trees. The former definition element becomes a placeholder element if it is the target of a relationship or the child in an inheritance relationship; otherwise, it disappears.

### Split Tree
 You can break out inheritance or relationships trees by right-clicking the domain class definition that displays them and then clicking **Split Tree**. The definition element becomes a placeholder element, and the definition domain class, together with its inheritance and relationships trees, is now displayed at the bottom of the partition.

### Show As Class
 If a domain relationship has derived relationships, or if it has embedding or reference relationships with other domain relationships, you can display the relationship as a class by right-clicking the relationship and then clicking **Show As Class**. The relationship will be displayed with a **Domain Properties** compartment and will show the inheritance and relationships trees.

## Related content

- [Domain-Specific Language Tools Glossary](/previous-versions/bb126564(v=vs.100))
