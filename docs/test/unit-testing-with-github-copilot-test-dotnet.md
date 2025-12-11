---
title: Generate and run unit tests using GitHub Copilot testing
description: Use GitHub Copilot testing for .NET in Visual Studio to create, test, and run your tests.
ms.date: 12/10/2025
ms.update-cycle: 90-days
ms.topic: how-to
dev_langs:
  - CSharp
helpviewer_keywords:
  - testing, Copilot
  - Copilot, testing
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= visualstudio'
---

# Generate and run unit tests using GitHub Copilot testing for .NET

Make sure that your code is working as expected by creating and running unit tests using GitHub Copilot testing for .NET.

Although Copilot can generate unit tests, you get extra testing capability by using GitHub Copilot testing for .NET in Visual Studio, including the following:

- Unit tests are generated in a separate project within the solution.
- Copilot generates tests deterministically, grounded in the C# compiler and language semantics, so assertions and edge cases are predictable and type-safe.
- GitHub Copilot testing builds the unit tests following test generation. If there are errors, the unit testing capability in GitHub Copilot for .NET tries to identify and fix errors, and then re-runs the tests.
- GitHub Copilot testing runs the tests using Test Explorer.

GitHub Copilot testing for .NET generates tests for C# projects only using the MSTest, NUnit, and xUnit frameworks.

## Prerequisites

To get started, you need:

+ Visual Studio 2026 Insiders build
+ [Sign in to Visual Studio using a GitHub account](../ide/work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)

>[!TIP]
> For the best experience, we suggest using a paid Copilot subscription to avoid potential throttling and ensure consistent access.

For an introduction to unit testing, see [Unit test basics](../test/unit-test-basics.md).

## Generate and run tests

1. Open an existing C# project that needs new tests.

   If you don't have an existing project, you can create a new project and then use the Bank sample application code to experiment with unit testing. Copy the starting sample code from [Create and run unit tests for .NET](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md#create-a-project-to-test) into `Program.cs`.

1. Build the project.

   Make sure the project builds without errors to simplify the process.

1. In Visual Studio, select **View > GitHub Copilot Chat**.

1. Use the following syntax in the Chat window to start GitHub Copilot testing and generate tests:

   ```cmd
   @test #target
   ```

   where `#target` can be the name of a solution, project, file, class, or member.

   For the Bank sample code, you can specify the class name: `@test #BankAccount`. The Test command appears in the chat as follows, indicating that the command is recognized.

   ![Screenshot of command to generate tests.](media/visualstudio/test-agent-start-agent.png)

1. In the Chat window, select **Send**.

   GitHub Copilot testing for .NET initiates an iterative process of analyzing your code, creating a new project for the unit tests, generating tests, building, and running the tests.

   Test generation is a long-running process. Depending on the scope of your target (file, project, solution, etc.) it may take a while.

   ![Screenshot of Copilot starting test generation.](media/visualstudio/test-agent-generate-tests.png)

   When unit tests are generated, the tests appear in a separate test project in the solution.

   ![Screenshot of generated sample test.](media/visualstudio/test-agent-sample-output.png)

   Test Explorer shows the results. If Test Explorer is not automatically opened by GitHub Copilot testing, select **Test** > **Test Explorer**.

   ![Screenshot of Test Explorer output.](media/visualstudio/test-agent-test-explorer-results.png)

   At this point, you can manually use Test Explorer to continue running tests, or chat with Copilot about the test results. You can also use Copilot to debug failed tests. For more information, see [Debug unit tests](../test/debug-unit-tests-with-test-explorer.md).
