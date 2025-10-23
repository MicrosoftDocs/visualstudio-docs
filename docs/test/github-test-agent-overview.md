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

The GitHub Test Agent is a new GitHub Copilot Chat Agent Mode feature integrated into Visual Studio. It automates the creation, running, and testing of C# unit tests for entire projects, solutions, files, or classes, offering a comprehensive experience compared to the more basic Copilot capabilities for generating unit tests. This tool is designed for C# developers who want to quickly bootstrap comprehensive test coverage without manually writing every test case.

Unlike short-lived Copilot suggestions, GitHub Test Agent provides a long-running experience that guides you through generating and managing tests across your codebase.

## Why Use GitHub Test Agent?

- Efficiency: Leverage the Test Agent to automatically generate, run, and test C# unit tests for large or small projects or solutions. 
- Consistency: Ensures tests follow best practices and project standards. Tests are generated using MSTest framework. Unit tests are created in a separate unit test project in the solution, following best practices.
- Integration: Works seamlessly within Visual Studio, leveraging Copilot’s AI capabilities.

## Key features

- Automated unit test generation: Create tests for multiple files or entire solutions.
- Command-based interaction: Use supported commands and parameters (listed in the /help message within the agent).
- Structured prompts: Free-form prompts are not supported at this time, ensuring predictable and reliable output.

## Getting started

1. Install Visual Studio 2026.
1. Enable GitHub Copilot Chat in Visual Studio.
1. Run the command to start the agent and generate tests: Start with a project or solution and let the agent create unit tests automatically. For detailed instructions, see [Generate and run unit tests using the GitHub Copilot Test Agent](../test/unit-testing-with-github-test-agent.md).