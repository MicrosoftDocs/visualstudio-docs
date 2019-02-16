---
title: Validate your system during development
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "dependency diagrams"
author: gewarren
ms.author: gewarren
manager: jillfra
ms.workload:
  - "multiple"
---
# Validate your system during development
Visual Studio can help keep your software consistent with the users' requirements and with the architecture of your system.

 To see which versions of Visual Studio support each of these features, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Key Tasks
 Use the following tasks to validate your software.

|**Tasks**|**Associated Topics**|
|-|-|
|**Make sure your software meets the users' requirements**:<br /><br /> You can use requirements and architectural models to help you organize the tests of your system and its components. This practice helps ensure that you test the requirements that are important to the users and other stakeholders, and it helps you update the tests quickly when the requirements change.|-   [Develop tests from a model](../modeling/develop-tests-from-a-model.md)|
|**Make sure that your software remains consistent with the intended design of your system:**<br /><br /> Dependency diagrams describe the intended dependencies between the components of your application. During development, you can verify that the actual dependencies in the code conform to the intended design.|-   [Create dependency diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)<br />-   [Validate code with dependency diagrams](../modeling/validate-code-with-layer-diagrams.md)|

## External Resources

|**Category**|**Links**|
|-|-|
|**Videos**|![link to video](../data-tools/media/playvideo.gif) [Channel 9: Doug Seven: Code Understanding and System Design with Visual Studio 2010](http://go.microsoft.com/fwlink/?LinkId=216100)<br /><br /> ![link to video](../data-tools/media/playvideo.gif) [Channel 9: Architecting an Application using a Dependency Diagram](http://go.microsoft.com/fwlink/?LinkID=201117)<br /><br /> ![link to video](../data-tools/media/playvideo.gif) [MSDN How Do I Series: How to Validate Code using Dependency Diagrams](http://go.microsoft.com/fwlink/?LinkID=214405)|
|**Forums**|-   [Visual Studio Visualization & Modeling Tools](http://go.microsoft.com/fwlink/?LinkId=184720)<br />-   [Visual Studio Visualization & Modeling SDK (DSL Tools)](http://go.microsoft.com/fwlink/?LinkId=184721)|
|**Blogs**|-   [Microsoft DevOps](https://devblogs.microsoft.com/devops/)|
|**Technical Articles and Journals**|[MSDN Architecture Center](http://go.microsoft.com/fwlink/?LinkId=201343)|

## See also

- [Testing the application](/azure/devops/test/overview?view=vsts)
- [Model user requirements](../modeling/model-user-requirements.md)
- [Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]
