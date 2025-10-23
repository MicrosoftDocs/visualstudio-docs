---
title: Overview of the GitHub Test Agent
description: Learn about the GitHub Test Agent in Visual Studio.
ms.date: 10/23/2025
ms.update-cycle: 90-days
ms.topic: how-to
dev_langs:
  - CSharp
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

# Overview of GitHub Test Agent in Visual Studio

The GitHub Test Agent is a new GitHub Copilot Chat Agent Mode feature integrated into Visual Studio. It automates the creation, running, and testing of C# unit tests for entire projects, solutions, files, classes, or members. This tool is designed for C# developers who want to quickly bootstrap comprehensive test coverage without manually writing every test case.

Unlike short-lived Copilot suggestions, GitHub Test Agent provides a long-running experience that guides you through generating and managing tests across your codebase.

## Why Use GitHub Test Agent?

The Test Agent offer a comprehensive experience compared to the more basic Copilot capabilities related to the generation of unit tests (such as the `/tests` command). The Test Agent provides the following:

- Efficiency: Leverage the Test Agent to automatically generate, run, and test C# unit tests for large or small projects or solutions. 
- Consistency: Ensures tests follow best practices and project standards. Tests are generated using MSTest framework. Unit tests are created in a separate unit test project in the solution, following best practices.
- Integration: Works seamlessly within Visual Studio, leveraging Copilot’s AI capabilities.

## Key features

- Automated unit test generation: Create tests for single files, multiple files, or entire solutions.
- Command-based interaction: Use supported commands and parameters (listed in the `/help` message within the agent).
- Structured prompts: Free-form prompts are not supported at this time, ensuring predictable and reliable output.

## Security warning

When you first run the GitHub Test Agent, it requests your consent to execute LLM-generated code on your machine. This may include actions such as installing or restoring NuGet packages and running unit tests. If you do not grant general consent, the agent will prompt you for explicit approval before performing any such operation.

> [!CAUTION]
> Your consent grants Copilot the ability to silently invoke arbitrary commands within your Visual Studio session. Microsoft cannot guarantee the safety of these commands. You should only enable this switch inside a sandboxed environment, and you should take steps to limit the privileges available to that environment. For example, the sandboxed environment should not use a cloud-connected account to log into Windows, and the sandboxed environment should not be logged into Visual Studio using a privileged GitHub account that has read access to non-public repositories or write access to production repositories.

## Next steps

See [Generate and run unit tests using the GitHub Copilot Test Agent](../test/unit-testing-with-github-test-agent.md).