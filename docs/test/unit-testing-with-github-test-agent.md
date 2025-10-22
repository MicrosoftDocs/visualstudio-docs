---
title: Generate and run unit tests by using Test Agent
description: Use the GitHub Test Agent in Visual Studio to create, test, and run your unit tests.
ms.date: 10/22/2025
ms.update-cycle: 90-days
ms.topic: how-to
dev_langs:
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords:
  - unit testing, Copilot
  - Copilot, unit testing
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: ai-tools
ms.collection: ce-skilling-ai-copilot
monikerRange: '>= visualstudio'
---

# Generate and run unit tests using the GitHub Copilot Test Agent

In this article, you'll learn how to create, run, and test unit tests using the GitHub Copilot Test Agent. 

Although Copilot can generate unit tests, you get extra unit testing feature support by using the GitHub Copilot Test Agent.

- Unit tests are generated in their own project.
- The Test Agent builds and runs the tests using Test Explorer.
- If there are errors, the Agent tries to identify and fix errros, and then re-runs the tests.

## Prerequisites

To get started, you need:

+ Visual Studio version 18.0.0 Preview 1 or later
+ [Sign in to Visual Studio using a GitHub account](../ide/work-with-github-accounts.md) with [Copilot access](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot) <br/>
  <sup>**</sup> You can use [GitHub Copilot for Free](../ide/copilot-free-plan.md). Sign up and leverage AI to code faster and more efficiently.

## Generate and run unit tests

1. Open an existing project that needs unit tests, or create a new project.

   If you create a new project, you can use the following sample code to test the feature.

   **TBD**

1. Build the project.

   Make sure the project builds without errors to simplify the process.

1. Open Copilot Chat.

1. Use the following syntax in the Chat window to start the agent and generate unit tests:

   ```cmd
   @test #target
   ```

   where `#target` can be a solution, project, file, or member.

1. For the `Bank` example, you can type the following.

   ```cmd
   @test #BankAccount
   ```

1. In the Chat window, select **Send**.

   The agent starts and initiates an interative process of analyzing your code, creating a new project for the unit tests, generating unit tests, and running the tests.

   Test Explorer shows the results.

   If Test Explorer is not opened by the agent, select **Test** > **Test Explorer**.

   ![Using the Create unit tests command](../media/visualstudio/test-agent-test-explorer-results.png)

   At this point, you can manually use Test Explorer to continue running tests. You can also use Copilot to debug unit tests. For more information, see [Debug unit tests](../test/debug-unit-tests-with-test-explorer.md).
