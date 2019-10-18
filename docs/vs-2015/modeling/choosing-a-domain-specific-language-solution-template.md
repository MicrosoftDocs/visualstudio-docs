---
title: "Choosing a Domain-Specific Language Solution Template | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords: 
  - "Domain-Specific Language Tools, solution templates"
ms.assetid: 9c05955f-1548-4df6-b09b-4b348823c237
caps.latest.revision: 26
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Choosing a Domain-Specific Language Solution Template
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To create a domain-specific language solution, choose one of the solution templates that are available in the Domain-Specific Language Designer Wizard. By choosing the template that most closely resembles the language that you want to create, you can minimize the modifications that you have to make to the starting solution.  
  
 The following solution templates are available in the Domain-Specific Language Designer Wizard.  
  
> [!NOTE]
> The purpose of the templates is to provide a starting DSL. The templates named Class and Component diagrams are not full UML diagrams. If you want to create a UML model, consider the UML modeling tools, which provide a set of diagrams that are integrated around a single model. They are extensible and can be integrated with your DSL using ModelBus. For more information, see [Create models for your app](../modeling/create-models-for-your-app.md).  
  
|Template|Features|Description|  
|--------------|--------------|-----------------|  
|Class Diagrams|-   Compartment shapes<br />-   Class inheritance<br />-   Relationship inheritance<br />-   Shape inheritance<br />-   Relationship properties|Use this solution template if your domain-specific language includes entities and relationships that have properties. This template creates a domain-specific language that resembles UML class diagrams. The main entities are classes and interfaces, together with association, generalization, and implementation relationships. A class or interface appears as a box that contains a list of attributes.|  
|Component Diagrams|-   Ports|Use this solution template if your domain-specific language includes components, that is, parts of a software system. This template creates a domain-specific language that resembles UML component diagrams. The main entities are components and ports, which appear as small shapes on the outside of components.|  
|Task Flow Diagrams|-   Image and geometry shapes<br />-   *Swimlanes*|Use this solution template if your domain-specific language includes workflows, states, or sequences. This template creates a domain-specific language that resembles UML activity diagrams. The main entity is an activity, and the main relationship is a transition between activities. The template includes several other elements such as start state, final state, and a synchronization bar.|  
|Minimal Language|-   One class and shape<br />-   One relationship and connector|Use this solution template if your domain-specific language does not resemble the other templates. This template creates a domain-specific language that has two classes and one relationship, which are represented in the **Toolbox** as **Box** and **Line**. The class and the relationship each have an example string property.|  
|Minimal WinForm Designer|-   A small model.<br />-   A Windows Form that displays the model.|Use this template if you want to build an application in which a DSL is bound to a Windows Form, rather than a graphical designer.<br /><br /> The form that acts as the user interface for the language is in the folder Dsl\UI.<br /><br /> You should build the project before opening the form designer.<br /><br /> For more information, see [Creating a Windows Forms-Based Domain-Specific Language](../modeling/creating-a-windows-forms-based-domain-specific-language.md).|  
|Minimal WPF Designer|-   A small model<br />-   A Windows Presentation Foundation user interface that displays the model|Use this template if you want to build an application in which a DSL is bound to a WPF user interface, rather than a graphical designer.<br /><br /> The designer for the user interface is in the folder Dsl\UI.<br /><br /> You should build the project before opening the UI designer.<br /><br /> For more information, see [Creating a WPF-Based Domain-Specific Language](../modeling/creating-a-wpf-based-domain-specific-language.md).|  
|DSL Library|-   A minimal library|Use this template if you want to build a partial DSL definition that can be imported into other DSL definitions.|  
  
## See also  
 [Overview of Domain-Specific Language Tools](../modeling/overview-of-domain-specific-language-tools.md)
