---
title: "Validate your system during development | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "layer diagrams"
ms.assetid: c9dafb47-7b1d-4c72-9432-d43be3db1799
caps.latest.revision: 39
author: jillre
ms.author: jillfra
manager: jillfra
---
# Validate your system during development
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Visual Studio can help keep your software consistent with the users' requirements and with the architecture of your system.

 To see which versions of Visual Studio support each of these features, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Key Tasks
 Use the following tasks to validate your software.

|**Tasks**|**Associated Topics**|
|---------------|---------------------------|
|**Make sure your model is consistent:**<br /><br /> Depending on the way your project uses and interprets models, it might be useful to disallow some combinations of elements. For example, you could restrict UML classes so that they always have [!INCLUDE[TLA2#tla_net](../includes/tla2sharptla-net-md.md)]-compliant names. You can define constraints like these in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] extensions.|-   [Validate your UML model](../modeling/validate-your-uml-model.md)<br />-   [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)|
|**Make sure your software meets the users' requirements**:<br /><br /> You can use requirements and architectural models to help you organize the tests of your system and its components. This practice helps ensure that you test the requirements that are important to the users and other stakeholders, and it helps you update the tests quickly when the requirements change.|-   [Develop tests from a model](../modeling/develop-tests-from-a-model.md)|
|**Make sure that your software remains consistent with the intended design of your system:**<br /><br /> Layer diagrams describe the intended dependencies between the components of your application. During development, you can verify that the actual dependencies in the code conform to the intended design.|-   [Create layer diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />-   [Validate code with layer diagrams](../modeling/validate-code-with-layer-diagrams.md)|

## External Resources

|**Category**|**Links**|
|------------------|---------------|
|**Videos**|![link to video](../data-tools/media/playvideo.gif "PlayVideo") [Channel 9: Doug Seven: Code Understanding and System Design with Visual Studio 2010](https://go.microsoft.com/fwlink/?LinkId=216100)<br /><br /> ![link to video](../data-tools/media/playvideo.gif "PlayVideo") [Channel 9: Architecting an Application using a Layer Diagram](https://go.microsoft.com/fwlink/?LinkID=201117)<br /><br /> ![link to video](../data-tools/media/playvideo.gif "PlayVideo") [MSDN How Do I Series: How to Validate Code using Layer Diagrams](https://go.microsoft.com/fwlink/?LinkID=214405)|
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](https://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](https://go.microsoft.com/fwlink/?LinkId=184721)|
|**Blogs**|-   [Visual Studio ALM + Team Foundation Server Blog](https://go.microsoft.com/fwlink/?LinkID=201340)|
|**Technical Articles and Journals**|[MSDN Architecture Center](https://go.microsoft.com/fwlink/?LinkId=201343)|

## See Also
 [Testing the application](https://msdn.microsoft.com/library/796b7d6d-ad45-4772-9719-55eaf5490dac)
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)
 [Model user requirements](../modeling/model-user-requirements.md)
 [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)
