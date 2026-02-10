---
title: Overview of GitHub Copilot testing for .NET
description: Learn about GitHub Copilot testing for .NET in Visual Studio.
ms.date: 02/06/2026
ms.update-cycle: 90-days
ms.topic: how-to
ms.custom: awp-ai
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

# Overview of GitHub Copilot testing for .NET

GitHub Copilot testing for .NET is a new capability in GitHub Copilot Chat that is integrated into Visual Studio. This feature automates the creation, running, and testing of C# code for entire projects, solutions, files, classes, or members. It is designed for C# developers who want to quickly bootstrap comprehensive test coverage without manually writing every test case. GitHub Copilot testing can generate tests for xUnit, NUnit, and MSTest test frameworks.

Unlike one-off prompts in Copilot agent mode, GitHub Copilot testing for .NET offers a guided, long-running experience designed specifically for test generation. It produces deterministic results grounded in the C# compiler and language semantics, with deep awareness of your codebase, file structure, and testing conventions to ensure predictable, context-appropriate tests.

## Prerequisites

+ Visual Studio 2026 version 18.3 or later
+ C# project
+ [Sign in to Visual Studio using a GitHub account](../ide/work-with-github-accounts.md) with a paid [Copilot subscription](https://docs.github.com/en/copilot/about-github-copilot/what-is-github-copilot#getting-access-to-copilot)

> [!NOTE]
> GitHub Copilot testing for .NET requires a paid GitHub Copilot subscription (individual, business, or enterprise). Free Copilot subscriptions are not supported.

## Why use GitHub Copilot testing for .NET?

GitHub Copilot testing for .NET offers a comprehensive experience compared to the more general Copilot capabilities related to the generation of tests. The unit testing capability in GitHub Copilot for .NET provides the following:

- **Efficiency:** Automatically generate, build, and run C# unit tests for large or small projects or solutions.
- **Consistency:** Ensure tests follow best practices and project standards. Tests are created in a separate test project in the solution and are generated using the xUnit, NUnit, and MSTest frameworks. If the solution already has unit tests in NUnit or xUnit, GitHub Copilot testing for .NET generates new tests in the same unit testing framework. If there are no unit tests in the solution, new tests are generated using MSTest.
- **Integration:** Works seamlessly within Visual Studio, leveraging Copilot’s AI capabilities.
- **Predictability:** Copilot is generating tests deterministically, grounded in the C# compiler and language semantics, so assertions and edge cases are predictable and type-safe.

## Key features

- **Automated test generation at scale:** Create tests for single files, multiple files in a single project, or entire solutions.
- **Command-based interaction:** Use supported commands and parameters (listed in the `/help` message within GitHub Copilot testing).
- **Flexible prompts:** Use structured `@Test #<target>` syntax or freeform natural language prompts to describe what you want to test.

## What GitHub Copilot testing can do

When you enable this capability, GitHub Copilot testing interacts with your solution in several ways to generate and validate tests:

- **Read:** Copilot analyzes your source code and project structure to understand context and dependencies.
- **Write:** It creates or updates test files within your solution based on its suggestions.
- **Build:** The tool triggers builds to compile your code and verify that generated tests integrate correctly.
- **Execute:** It runs tests to confirm they pass and to provide feedback on coverage and quality.

>[!IMPORTANT]
> Copilot testing does not modify production code outside of the test generation process. All changes occur within your local development environment, and you retain full control to review, accept, or discard suggestions.

## Actions taken by the @Test agent

The `@Test` agent performs various actions during test generation. Understanding these actions helps you know what to expect when using the tool.

### Build and test operations

The agent uses Visual Studio APIs (not command-line tools like `dotnet restore` or `dotnet test`) to perform the following operations:

- **Restore and build**: Restores packages and builds projects based on scope (from a single project up to the entire solution).
- **Run tests**: Primarily runs only the generated tests. However, to compute initial and resulting code coverage (and for coverage optimization mode), the agent runs all tests within the given scope.
- **Process git diff**: When using diff mode (`#git_changes`), the agent analyzes your uncommitted changes to generate targeted tests.

### Package installation

The agent installs NuGet packages as needed:

- Test framework packages (MSTest, NUnit, or xUnit)
- Mock framework packages if not already present
- Coverage and TRX extensions for Microsoft Test Platform (MTP) if not present

### LLM operations

The agent makes LLM calls for:

- Freeform prompt analysis
- Summary processing
- Test generation

### Project and file modifications

The agent creates a test project if one doesn't exist for the target code.

The agent uses a custom file system with the following guarantees:

- **Scope**: The agent never reads or writes files outside the repository root (except for logs).
- **Read-only preference**: Whenever possible, the agent uses a read-only file system that prevents write actions.

The agent can write to the following files:

- Test project files
- Source project files (for example, adding `InternalsVisibleTo` attributes)
- Solution files (indirectly through Visual Studio APIs, such as when adding a project)
- Test source files

## Security warning

When you first run GitHub Copilot testing for .NET, Copilot requests your consent to execute LLM-generated code on your machine. This may include actions such as installing or restoring NuGet packages and running tests. If you don't grant general consent, GitHub Copilot testing will prompt you for explicit approval before performing any such operation.

> [!CAUTION]
> Your consent grants Copilot the ability to silently invoke arbitrary commands within your Visual Studio session. Microsoft can't guarantee the safety of these commands. You should only enable this switch inside a sandboxed environment, and you should take steps to limit the privileges available to that environment. For example, the sandboxed environment shouldn't use a cloud-connected account to log into Windows, and the sandboxed environment shouldn't be logged into Visual Studio using a privileged GitHub account that has read access to non-public repositories or write access to production repositories.

## Next steps

See [Generate and run tests using GitHub Copilot testing for .NET in Visual Studio](../test/unit-testing-with-github-copilot-test-dotnet.md).