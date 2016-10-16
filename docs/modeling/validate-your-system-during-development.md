---
title: "Validate your system during development"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-devops-techdebt"
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "layer diagrams"
ms.assetid: c9dafb47-7b1d-4c72-9432-d43be3db1799
caps.latest.revision: 37
ms.author: "ahomer"
manager: "kamrani"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Validate your system during development
Visual Studio can help keep your software consistent with the users' requirements and with the architecture of your system.  
  
 To see which versions of Visual Studio support each of these features, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).  
  
## Key Tasks  
 Use the following tasks to validate your software.  
  
|**Tasks**|**Associated Topics**|  
|---------------|---------------------------|  
|**Make sure your model is consistent:**<br /><br /> Depending on the way your project uses and interprets models, it might be useful to disallow some combinations of elements. For example, you could restrict UML classes so that they always have [!INCLUDE[TLA2#tla_net](../modeling/includes/tla2sharptla_net_md.md)]-compliant names. You can define constraints like these in [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] extensions.|-   [Validate your UML model](../modeling/validate-your-uml-model.md)<br />-   [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md)|  
|**Make sure your software meets the users' requirements**:<br /><br /> You can use requirements and architectural models to help you organize the tests of your system and its components. This practice helps ensure that you test the requirements that are important to the users and other stakeholders, and it helps you update the tests quickly when the requirements change.|-   [Develop tests from a model](../modeling/develop-tests-from-a-model.md)|  
|**Make sure that your software remains consistent with the intended design of your system:**<br /><br /> Layer diagrams describe the intended dependencies between the components of your application. During development, you can verify that the actual dependencies in the code conform to the intended design.|-   [Create layer diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />-   [Validate code with layer diagrams](../modeling/validate-code-with-layer-diagrams.md)|  
  
## External Resources  
  
|**Category**|**Links**|  
|------------------|---------------|  
|**Videos**|![link to video](../codequality/media/playvideo.gif "PlayVideo") [Channel 9: Doug Seven: Code Understanding and System Design with Visual Studio 2010](http://go.microsoft.com/fwlink/?LinkId=216100)<br /><br /> ![link to video](../codequality/media/playvideo.gif "PlayVideo") [Channel 9: Architecting an Application using a Layer Diagram](http://go.microsoft.com/fwlink/?LinkID=201117)<br /><br /> ![link to video](../codequality/media/playvideo.gif "PlayVideo") [MSDN How Do I Series: How to Validate Code using Layer Diagrams](http://go.microsoft.com/fwlink/?LinkID=214405)|  
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](http://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](http://go.microsoft.com/fwlink/?LinkId=184721)|  
|**Blogs**|-   [Visual Studio ALM + Team Foundation Server Blog](http://go.microsoft.com/fwlink/?LinkID=201340)|  
|**Technical Articles and Journals**|[MSDN Architecture Center](http://go.microsoft.com/fwlink/?LinkId=201343)|  
  
## See Also  
 [Testing the application](../test/test-apps-early-and-often.md)   
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)   
 [Model user requirements](../modeling/model-user-requirements.md)   
 [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)