---
title: Overview of GitHub Copilot testing for .NET
description: Learn about GitHub Copilot testing for .NET in Visual Studio.
ms.date: 10/23/2025
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

# Overview of GitHub Copilot testing for .NET

GitHub Copilot testing for .NET is a new capability in GitHub Copilot Chat that is integrated into Visual Studio. This feature automates the creation, running, and testing of C# code for entire projects, solutions, files, classes, or members. It is designed for C# developers who want to quickly bootstrap comprehensive test coverage without manually writing every test case.

Unlike short-lived Copilot suggestions, GitHub Copilot testing for .NET provides a guided, long-running experience for generating and managing tests across your codebase.

## Why use GitHub Copilot testing for .NET?

GitHub Copilot testing for .NET offers a comprehensive experience compared to the more basic Copilot capabilities related to the generation of tests (such as the `/tests` command). The unit testing capability in GitHub Copilot for .NET provides the following:

- **Efficiency:** Automatically generate, build, and run C# unit tests for large or small projects or solutions.
- **Consistency:** Ensure tests follow best practices and project standards. Tests are created in a separate test project in the solution and are generated using the MSTest framework.
- **Integration:** Works seamlessly within Visual Studio, leveraging Copilot’s AI capabilities.

## Key features

- **Automated test generation:** Create tests for single files, multiple files in a single project, or entire solutions.
- **Command-based interaction:** Use supported commands and parameters (listed in the `/help` message within GitHub Copilot testing).
- **Structured prompts:** Free-form prompts aren't supported at this time, ensuring predictable and reliable output.

## Security warning

When you first run GitHub Copilot testing for .NET, Copilot requests your consent to execute LLM-generated code on your machine. This may include actions such as installing or restoring NuGet packages and running tests. If you don't grant general consent, GitHub Copilot testing will prompt you for explicit approval before performing any such operation.

> [!CAUTION]
> Your consent grants Copilot the ability to silently invoke arbitrary commands within your Visual Studio session. Microsoft can't guarantee the safety of these commands. You should only enable this switch inside a sandboxed environment, and you should take steps to limit the privileges available to that environment. For example, the sandboxed environment shouldn't use a cloud-connected account to log into Windows, and the sandboxed environment shouldn't be logged into Visual Studio using a privileged GitHub account that has read access to non-public repositories or write access to production repositories.

## Next steps

See [Generate and run tests using GitHub Copilot testing for .NET in Visual Studio](../test/unit-testing-with-github-copilot-test-dotnet.md).