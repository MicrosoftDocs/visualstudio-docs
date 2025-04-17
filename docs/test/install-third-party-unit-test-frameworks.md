---
title: Install Third-party Unit Test Frameworks
description: Visual Studio Test Explorer can run tests from any unit test framework that has an adapter interface available.
ms.date: 04/17/2025
ms.topic: how-to
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
#customer intent: As a developer, I want to install unit test frameworks from other parties so I can run unit tests from any unit test framework in Visual Studio.
---
# Install unit test frameworks

Visual Studio Test Explorer can run tests from any unit test framework that has an adapter interface available. Installing the framework copies the binaries and adds Visual Studio project templates for the languages it supports. When you create a project with the template, the framework is registered with Test Explorer.

A Visual Studio solution can contain unit test projects that use different frameworks and that are targeted at different languages.

For .NET, [MSTest, NUnit, and xUnit](getting-started-with-unit-testing.md) are the test frameworks provided by Visual Studio, which are installed by default. For C++, a different set of test frameworks are provided, such as CTest.

## Acquire frameworks

Install third-party unit test frameworks by using **NuGet Package Manager**:

1. In **Solution Explorer**, right-click the project for your test code, and select **Manage NuGet Packages**.

1. In **NuGet Package Manager**, search for the test framework you want to install:

   ::: moniker range=">=vs-2022"
   :::image type="content" source="media/vs-2022/nuget-package-manager.png" alt-text="Screenshot of NuGet Package Manager in Visual Studio 2022.":::
   ::: moniker-end
   ::: moniker range="vs-2019"
   :::image type="content" source="media/vs-2019/nuget-package-manager.png" alt-text="Screenshot of NuGet Package Manager in Visual Studio 2019.":::
   ::: moniker-end

1. Select the framework and then select **Install**.

## Update to the latest test adapters

Update to the latest stable test adapter to experience better test discovery and execution. For more information about updates to MSTest, NUnit, and xUnit test adapters, see the [Visual Studio blog](https://devblogs.microsoft.com/visualstudio/test-experience-improvements/).

### To update to the latest stable test adapter version

1. Open **NuGet Package Manager** for your solution by selecting **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**.

1. Select the **Updates** tab and search for MSTest, NUnit, or xUnit test adapters that are installed.

1. Select the checkbox next to each test adapter you want to refresh, and then select **Update** to install the latest version of each adapter.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="media/vs-2022/install-adapter-upgrade.png" alt-text="Screenshot of Upgrade Test Adapter in Visual Studio 2022.":::

   If the **Preview changes** dialog opens, confirm your selection, and select **Apply**. Accept any licensing changes, as needed.

   ::: moniker-end
   ::: moniker range="vs-2019"

   :::image type="content" source="media/install-adapter-upgrade.png" alt-text="Screenshot of Upgrade Test Adapter in Visual Studio 2019.":::

   Select **Install**.

   ::: moniker-end

## Related content

- [Unit test your code](../test/unit-test-your-code.md)
