---
<<<<<<< HEAD
title: "Improve Code Quality"
ms.custom:
ms.date: "10/14/2016"
ms.reviewer:
ms.suite:
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm:
ms.topic: "article"
helpviewer_keywords: 
  - "Visual Studio ALM"
  - "team-based development"
ms.author: "mlearned"
manager: "douge"
---
# Improve Code Quality

What is code quality? Correctness, maintainability, and even elegance are all involved in creating great code. However you define it, Visual Studio test tools can help you and your team to develop and sustain high standards of code excellence.

In the following table, you can find descriptions of common tasks and links to more information about how you can successfully complete those tasks.
=======
title: "Visual Studio testing tools | Microsoft Docs"
ms.date: 01/31/2018
ms.technology: vs-devops-test
ms.topic: "article"
helpviewer_keywords: 
  - "testing tools [Visual Studio]"
  - "unit tests [Visual Studio]"
ms.author: gewarren
manager: ghogen
ms.workload: 
  - "multiple"
author: gewarren
---
# Testing tools in Visual Studio

Visual Studio testing tools can help you and your team to develop and sustain high standards of code excellence.

> [!NOTE]
> Unit testing is availble in all editions of Visual Studio. Other testing tools, such as live unit testing, IntelliTest, and Coded UI tests are only available in Visual Studio Enterprise edition. For more information about editions see [Compare Visual Studio 2017 IDEs](https://www.visualstudio.com/vs/compare/).

## In this section
>>>>>>> master

|||
|-|-|
|[Unit Test Your Code](../test/unit-test-your-code.md)|Test Explorer makes it easy to integrate unit tests in your development practice. You can use the Microsoft unit test framework or one of several third-party and open source frameworks.|
<<<<<<< HEAD
|[Analyzing Application Quality](../code-quality/analyzing-application-quality-by-using-code-analysis-tools.md)|Static code analysis tools find design, usage, maintainablity, and style issues in C++ and managed code. Many of these issues can lead to bugs that are hard to reproduce in standard testing environment.|
|[Measuring Complexity and Maintainability of Managed Code](../code-quality/measuring-complexity-and-maintainability-of-managed-code.md)|Code metrics is a set of software measures that provide developers better insight into the code they are developing. The metrics include a maintainability index for functions and classes, cyclomatic complexity of functions, the inheritance depth of classes, and the amount of coupling among classes.|
|[PreEmptive Analytics for Team Foundation Server](http://msdn.microsoft.com/library/hh973124.aspx)|PreEmptive Analytics for TFS CE helps you to integrate feedback-driven development processes into your development workflow. Your applications automatically send back exception report data to the PreEmptive Analytics service as errors occur during their execution. The service then creates or updates work items in Microsoft Team Foundation Server based on rules and thresholds you define.|
|[PreEmptive Dotfuscator and Analytics CE](assetId:///25d195d4-9f76-4dcc-9fbb-eeb9bdca9a3f)|PreEmptive Dotfuscator is a.NET obfuscator and compactor that helps protect programs against reverse engineering while making them smaller and more efficient.|

## Related Scenarios

[Adopting Visual Studio and Team Foundation Server for Application Lifecycle Management](assetId:///7ae9182f-4762-4bd3-b238-39ce987932e5)  
If you are unfamiliar with Visual Studio Team Foundation, you can learn more about how you can use it in a team development environment to improve productivity and reduce risks that are associated with application development.

[Analyzing and Modeling Architecture](../modeling/analyze-and-model-your-architecture.md)  
You can use Visual Studio to manage the challenges and complexity of designing software. Visual Studio lets you visually model your application, both as it exists now and as you want it to exist in the future. You can create and maintain diagrams to help you visualize the logical models of your application at the same time that they map to the physical models; this enables you to change, validate, and analyze the software that is "under design."

[Testing the application](https://www.visualstudio.com/docs/test/overview)  
You can use Visual Studio to be more productive throughout the testing life cycle and plan your testing effort. You can create, manage, edit, and run both manual and automated tests. You can also review your testing progress based on your plan.

[Build the application](https://www.visualstudio.com/docs/build/overview)  
You can use [!INCLUDE[esprbuild](../test/includes/esprbuild_md.md)] to create and manage automated builds for your code. [!INCLUDE[esprbuild](../test/includes/esprbuild_md.md)] lets you create drop servers to deploy builds. In addition, you can analyze build trends.

[Track work using Visual Studio Online or Team Foundation Server](https://www.visualstudio.com/docs/work/overview)  
You can use [!INCLUDE[vstsTfsLong](../test/includes/vststfslong_md.md)] to plan and track your projects whether you use the agile process, the formal process, or a variation on those processes. By planning your projects, tracking your progress against the plan, and making necessary adjustments, you can reduce risks, avoid unpleasant surprises, and manage the cost of your projects.
=======
|[IntelliTest](../test/generate-unit-tests-for-your-code-with-intellitest.md)|IntelliTest automatically generates unit tests and test data for your managed code.|
|[Code Coverage](../test/using-code-coverage-to-determine-how-much-code-is-being-tested.md)|Code coverage determines what proportion of your project's code is actually being tested by coded tests such as unit tests.|
|[Microsoft Fakes](../test/isolating-code-under-test-with-microsoft-fakes.md)|Microsoft Fakes help you isolate the code you are testing by replacing other parts of the application with stubs or shims.|
|[Live Unit Testing](../test/live-unit-testing.md)|Live Unit Testing automatically runs unit tests in the background and graphically displays code coverage and test results in the Visual Studio code editor.|
|[UI Automation](../test/use-ui-automation-to-test-your-code.md)|Use Coded UI tests to drive your application through its user interface.|
|[Lab Management](../test/lab-management/using-a-lab-environment-for-your-application-lifecycle.md)|A lab environment is a collection of virtual and physical machines that you can use to develop and test applications.|

## Related scenarios

* [Exploratory & Manual Testing (VSTS)](/vsts/manual-test/)
* [Load Testing (VSTS)](/vsts/load-test/index)
* [Continuous Testing (VSTS)](/vsts/build-release/test/index)
* [DevOps overview for Team Services and TFS (VSTS)](/vsts/user-guide/devops-alm-overview)
* [Code analysis tools](../code-quality/analyzing-application-quality-by-using-code-analysis-tools.md)
>>>>>>> master
