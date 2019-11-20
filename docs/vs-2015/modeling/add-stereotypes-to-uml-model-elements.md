---
title: "Add stereotypes to UML model elements | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML model, stereotypes"
ms.assetid: 82545252-83ce-4e11-a419-61373be75d16
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Add stereotypes to UML model elements
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can add a stereotype to a UML model element to annotate it and provide it with specialized properties. To add a stereotype to a model element, the stereotype must be defined in a profile, and you must link the profile to a package or to the model that contains the model element. Each stereotype can be added only to certain kinds of model element, such as UML classes, use cases, or components.

 For example, if you want to define a UML class with the «specification» stereotype, you must create it within a package or a model that is linked to Standard Profile L2.

 By default, every model is by linked to the UML Standard Profiles L2 and L3.

### To link a profile to a model or a package

1. Open **UML Model Explorer**. On the **Architecture** menu, point to **Windows**, and then click **UML Model Explorer**.

2. Locate a package or a model that contains all the elements to which you want to apply the stereotypes in the profile.

3. Right-click the package or the model and then click **Properties**.

4. In the **Properties** window, set the **Profiles** property to the profiles that contain the stereotypes you want to use.

     The stereotypes of the profile will now be available on all the elements inside the model or package. If the package contains other packages, the stereotypes will also be available on the elements inside them.

### To add stereotypes to model elements or relationships

1. Right-click the model element or relationship, either on a diagram or in **UML Model Explorer**, and then click **Properties**.

    > [!NOTE]
    > To add the same stereotypes to several elements, you can select several elements and then right-click one of them.

2. Click the **Stereotypes** property and select the stereotypes that you want to apply.

     The selected stereotypes appear within «chevrons» in the model element, for most kinds of element and relationship.

    > [!NOTE]
    > If you cannot see the **Stereotypes** property, or if the stereotype you want does not appear, verify that the model element is inside a package or a model to which the appropriate profile has been linked.

3. Some stereotypes allow you to set the values of additional properties for the model element. To see these properties, expand the **Stereotypes** property.

### To create model elements within a package

1. Create a package either in a UML Class Diagram, or in **UML Model Explorer**.

2. Add model elements to the package in one of the following ways:

    - In a UML Class Diagram, click the tool for an element, and then click inside the package on the diagram.

         \- or -

    - In UML Model Explorer, right-click the package, point to **Add**, and then click an element type.

         \- or -

    - In UML Model Explorer, drag an existing element into the package.

         \- or -

    - Link a diagram to the package, and then create elements within the diagram.

         To do this, right-click a blank part of the diagram and then click **Properties**. In the **Properties** window, set **Linked Package** to the package you want.

         All the new elements that you create in the diagram will be defined within that package.

         You can do this only with some types of diagram.

## See Also
 [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)
 [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md)
 [Define packages and namespaces](../modeling/define-packages-and-namespaces.md)

