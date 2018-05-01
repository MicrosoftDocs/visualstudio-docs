---
title: "Editing Load Tests in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Load Test Editor"
  - "load tests, Load Test Editor"
ms.assetid: ba16ed02-137e-40bf-a4cb-45d87d922d37
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# Edit load tests

Load tests run Web performance tests or unit tests to simulate many users accessing a server at the same time. A load test gives you access to application stress and performance data. A load test can be configured to emulate various load conditions such as user loads and network types.

> [!NOTE]
> Load testing is available only in the Enterprise edition of Visual Studio 2017.

A load test is defined by *scenarios*, *counter sets*, and *run settings*. The following illustration explains the differences between [scenarios](../test/edit-load-test-scenarios.md), [counter sets](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md), and [run settings](../test/load-test-run-settings-properties.md):

![Load Test Architecture](../test/media/load_test_editor.png)

## Edit load test scenario settings

A scenario is used to model how a group of users interacts with a server application. A scenario consists of a load pattern, a test mix model, a test mix, a browser mix, and network mix. A load test can have more than one scenario and a single scenario can contain Web performance tests and unit tests. By grouping similar settings together, a scenario lets you to group and run tests of a similar nature together.

For more information, see [Editing Load Test Scenarios](../test/edit-load-test-scenarios.md) and [Load Test Scenario Properties](../test/load-test-scenario-properties.md).

## Configure and manage performance counter sets

Load tests provide named counter sets, organized by technology, that are useful when you analyze performance counter data. The counter sets include Load Test, IIS, ASP.NET, and SQL. When you create a load test with the New Load Test Wizard, an initial set of predefined and important counters is configured for the computers that you specify to include in the load test. You manage your counters in the Load Test Editor.

For more information, see [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md).

## Configure and manage load test run settings

Run settings are properties that influence the way a load test runs. Run settings are organized by categories in the Properties window.

For more information, see [Configuring Load Test Run Settings](../test/configure-load-test-run-settings.md) and [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).

## See also

- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [Analyzing Threshold Rule Violations](../test/analyze-threshold-rule-violations-in-load-tests.md)