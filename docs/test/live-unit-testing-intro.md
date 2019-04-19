---
title: "Introducing Live Unit Testing"
description: Learn about the advantages of Live Unit Testing and how to use it when unit testing your projects.
ms.date: 09/11/2017
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio ALM"
  - "Live Unit Testing"
author: rpetrusha
ms.author: "ronpet"
ms.workload:
  - "dotnet"
---
# Live Unit Testing introduction

Live Unit Testing is a technology that was introduced in Visual Studio 2017. It executes your unit tests automatically in real time as you make code changes.

Live Unit Testing:

- Lets you refactor and change code with greater confidence. Live Unit Testing automatically executes all impacted tests as you edit your code to ensure that your changes do not break tests.

- Indicates whether your unit tests adequately cover your code and shows code not covered by unit tests. Live Unit Testing graphically depicts code coverage in real time so that you can see at a glance both how many tests cover each line of code and which lines are not covered by any unit tests.

If you have a solution that includes one or more unit test projects, you can enable Live Unit Testing by selecting **Test** > **Live Unit Testing** > **Start** from the top-level Visual Studio menu.

> [!NOTE]
> Live Unit Testing is available only in Visual Studio Enterprise edition.

To learn more about Live Unit Testing:

- Try the introductory tutorial, [Get started with Live Unit Testing](live-unit-testing-start.md).

- Read the detailed documentation, [Use Live Unit Testing with Visual Studio Enterprise Edition](live-unit-testing.md).

- Read the [Live Unit Testing FAQ](live-unit-testing-faq.md) to learn what's new in Live Unit Testing, as well as to read about tips and techniques.

- Watch the Channel 9 video for a overview of Live Unit Testing and its features. </p>

   > [!VIDEO https://channel9.msdn.com/Events/Visual-Studio/Visual-Studio-2017-Launch/T105/player]

## Related resources

- [Code testing tools](https://visualstudio.microsoft.com/vs/testing-tools/)
- [Unit test your code](unit-test-your-code.md)
