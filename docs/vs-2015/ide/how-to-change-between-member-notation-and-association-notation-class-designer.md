---
title: "How to: Change Between Member Notation and Association Notation (Class Designer) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "notation, member"
  - "association notation"
  - "member notation"
  - "notation, association"
ms.assetid: 65881c5a-d251-4a36-ad0d-73d088436092
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Change Between Member Notation and Association Notation (Class Designer)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Class Designer, you can change the way the class diagram represents an association relationship between two types from member notation to association notation and vice versa. Members displayed as association lines often provide a useful visualization of how types are related.

> [!NOTE]
> Association relationships can be represented as a member property or field. To change member notation to association notation, one type must have a member of another type. To change association notation to member notation, the two types must be connected by an association line. For more information, see [How to: Create Associations Between Types (Class Designer)](../ide/how-to-create-associations-between-types-class-designer.md). If your project contains multiple class diagrams, changes that you make to the way a diagram displays association relationships affect only that diagram. To change the way another diagram displays association relationships, open or display that diagram and perform these steps.

### To change member notation to association notation

1. From the project node in Solution Explorer, open the class diagram (.cd) file.

2. In the type shape on the class diagram, right-click the member property or field representing the association, and choose **Show as Association**.

    > [!TIP]
    > If no properties or fields are visible in the type shape, the compartments in the shape might be collapsed. To expand the type shape, double-click the compartment name or right-click the type shape, and choose **Expand**.

     The member disappears from the compartment in the type shape and an association line appears to connect the two types. The association line is labeled with the name of the property or field.

### To change association notation to member notation

- On the class diagram, right-click the association line, and choose **Show as Property** or **Show as Field** as appropriate.

     The association line disappears, and the property displays in the appropriate compartment within its type shape on the diagram.

## See Also
 [How to: Create Inheritance Between Types (Class Designer)](../ide/how-to-create-inheritance-between-types-class-designer.md)
 [How to: View Inheritance Between Types (Class Designer)](../ide/how-to-view-inheritance-between-types-class-designer.md)
 [Viewing Types and Relationships (Class Designer)](../ide/viewing-types-and-relationships-class-designer.md)
 [How to: Visualize a Collection Association (Class Designer)](../ide/how-to-visualize-a-collection-association-class-designer.md)
