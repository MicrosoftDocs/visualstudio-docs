---
title: "Extend UML models and diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML - extending"
  - "UML model, extending"
ms.assetid: b5bfa61e-ea59-4c3b-b5af-53475d7d13cd
caps.latest.revision: 39
author: jillre
ms.author: jillfra
manager: jillfra
---
# Extend UML models and diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic summarizes the different ways in which you can extend the UML modeling tools included with Visual Studio. To see which versions of Visual Studio support each model type and tool, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

 In the following example scenario, Fabrikam designs and installs airport baggage handling systems. From one airport project to the next, there are many similarities in the basic equipment and the software that controls it. However, there are also several factors that vary widely, such as the configuration of conveyor belts, checkin desks, storage bins, and other bag handling equipment.

 When starting a new project, the Fabrikam team creates a UML model to help them discuss these requirements between themselves and with their customer. They use activity diagrams to represent the flow of bags, with object nodes representing each piece of equipment. The UML model does not directly represent the system's code.

 Fabrikam's tools team makes a series of enhancements to help the development teams. The following sections describe the different kinds of extensions that you can define. You can combine several of these techniques into one Visual Studio extension.

 For more information, see this video: ![link to video](../data-tools/media/playvideo.gif "PlayVideo")[MSDN How Do I Series: UML Tools and Extensibility](https://go.microsoft.com/fwlink/?LinkId=214467).

## <a name="Requirements"></a> Requirements

- [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

- [Modeling SDK for Visual Studio 2015](https://www.microsoft.com/download/details.aspx?id=48148).

## Profiles
 Profiles let you define stereotypes and additional properties on UML elements.

 Fabrikam's tool developers define stereotypes on the object nodes of activity diagrams, such as «conveyor belt» and «checkin desk». When a team member creates a baggage handling scheme using an activity diagram, they can now set stereotypes to indicate what type of equipment each node represents. The tool developers define additional properties on some of the stereotypes, so that users can record values such as the capacity of a conveyor belt, and the handedness of a checkin desk.

 For more information, see [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md).

## Custom Toolbox Items
 A custom toolbox item creates an element or a group of elements from a prototype that you define in a diagram. For example, you could create a tool that creates use cases in a particular color or stereotype, or a group of classes and associations that represents a design pattern. You can add these toolbox items to Visual Studio extensions and distribute them to other users.

 For more information, see [Define a custom modeling toolbox item](../modeling/define-a-custom-modeling-toolbox-item.md).

## Validation
 You can define rules to ensure that a UML model conforms to specified constraints.

 Fabrikam's tool developers define rules to help team members avoid simple mistakes in baggage handling models. For example, a checkin desk cannot be connected directly to a storage bin. There must at least be a conveyor belt between them.

 For more information, see [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md).

## Menu Commands
 You can define commands that users can invoke by right-clicking elements on a UML diagram. The commands can update the model and diagrams or perform other operations in [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)].

 Fabrikam defines menu commands to automate frequently-performed operations, such as create a check-in desk and connect it to a selected conveyor belt or rearrange a diagram according to the company's layout rules.

 See [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

## Gestures
 You can define commands that users initiate by double-clicking a diagram element, or by dragging onto a diagram or an element on the diagram. You can define commands that can deal with items dragged from other UML diagrams, from other parts of Visual Studio, or from other applications or Windows Explorer (or File Explorer.

 Fabrikam team members can associate a file such as a specification with any model element by dragging it from the Windows desktop. The tool developers defined a stereotype that provides any element with a file path property, and a gesture that sets the stereotype and the file path when a file is dropped onto an element.

 For more information, see [Define a gesture handler on a modeling diagram](../modeling/define-a-gesture-handler-on-a-modeling-diagram.md).

## Responding to Changes
 You can write code that responds to changes in the model, whether caused by user actions or by other program code.

 Fabrikam’s developers create code that automatically sets the color of an element dependent on its stereotype. This makes it easy for users to distinguish the different roles played by elements in the models.

 For more information, see [How to: Respond to Changes in a UML Model](../misc/how-to-respond-to-changes-in-a-uml-model.md).

## Model Bus
 Model Bus allows you to access a diagram or model from another diagram or from another [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] Extension. Among other things, this allows you to spread information across more than one model, so that several people can work on the combined model at the same time.

 Fabrikam uses elements on activity diagrams to represent baggage handling equipment. Each item of equipment can have a more detailed specification in another diagram, which can be in another model. The validation constraints on the baggage flow diagram can retrieve relevant properties of the equipment from the other diagrams. The references to the other diagrams are stored in additional properties defined in stereotypes.

 For more information, see [Integrate UML models with other models and tools](../modeling/integrate-uml-models-with-other-models-and-tools.md).

## Generation
 From a model, you can generate program code, scripts, configurations, documents, new models, or other artifacts.

 In the baggage systems that Fabrikam designs, much of the program code is the same from one project to the next. The major variable aspect is the plan of the baggage flow around the airport. After the design team has had the experience of their first few projects, the tool developers create a template that generates, from the baggage flow model, much of the variable program code and other files such as user documents. This considerably reduces the development time and error rate for each new project.

 For more information, see [Generate files from a UML model](../modeling/generate-files-from-a-uml-model.md).

## Team Foundation Server Integration
 You can link work items to model elements, and access the linked items programmatically.

 Fabrikam's tool developers write a tool that generates a work schedule for each airport project. The work items in the schedule are linked to the model elements.

 For more information, see [Define a work item link handler](../modeling/define-a-work-item-link-handler.md).

## Tools that Update Models
 You can create stand-alone applications and Visual Studio extensions that can load UML models.

 Fabrikam's developers create a tool that reads a model and generates reports of the progress of work on each element of the model.

 For more information, see [Read a UML model in program code](../modeling/read-a-uml-model-in-program-code.md).

## Domain-Specific Languages
 Where you frequently use a particular type of model, it can be useful to create a domain-specific language. This can be made to fit your business needs more closely than a UML model, but requires more effort to build it and maintain it. For more information, see [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md).

## External Resources

|**Category**|**Links**|
|------------------|---------------|
|**Videos**|![link to video](../data-tools/media/playvideo.gif "PlayVideo") [MSDN How Do I Series: UML Tools and Extensibility](https://go.microsoft.com/fwlink/?LinkId=214467)<br /><br /> ![link to video](../data-tools/media/playvideo.gif "PlayVideo") [Channel 9: UML with Visual Studio](https://go.microsoft.com/fwlink/?LinkId=199957)|
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](https://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](https://go.microsoft.com/fwlink/?LinkId=184721)|
|**Blogs**|[Visual Studio ALM + Team Foundation Server Blog](https://go.microsoft.com/fwlink/?LinkID=201340)|
|**Technical Articles and Journals**|[MSDN Architecture Center](https://go.microsoft.com/fwlink/?LinkId=201343)|

## See Also
 [Create models for your app](../modeling/create-models-for-your-app.md)
 [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md)
