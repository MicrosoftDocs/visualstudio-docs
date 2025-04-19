---
title: Create a Unit Test Project
description: Learn how to create a unit test project. The test project can be in the same solution as the production code, or it can be in a separate solution.
ms.date: 04/17/2025
ms.topic: how-to
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
author: mikejo5000
#customer intent: As a developer, I want to create unit test projects in Visual Studio so I can run unit tests on project code in my solution.
---
# Create a unit test project

Unit tests often mirror the structure of the code under test. For example, a unit test project might be created for each code project in the product. The test project can be in the same solution as the production code, or it can be in a separate solution. You can have multiple unit test projects in a solution.

> [!NOTE]
> The location of unit tests for native code and the test project structure can be different from the structure described in this article. For more information, see [Writing unit tests for C/C++](writing-unit-tests-for-c-cpp.md).

## To create a unit test project

1. On the **File** menu, select **New** > **Project**, or press **Ctrl**+**Shift**+**N**.

1. On the **Create a new project** page, enter *unit test* in the search box. Select the project template for the test framework that you want to use, such as **MSTest Test Project** or **NUnit Test Project**, and then select **Next**.

   ::: moniker range=">=vs-2022"
   :::image type="content" source="media/vs-2022/test-project-templates.png" alt-text="Screenshot of test project templates in Visual Studio 2022.":::
   ::: moniker-end
   ::: moniker range="vs-2019"
   :::image type="content" source="media/vs-2019/test-project-templates.png" alt-text="Screenshot of test project templates in Visual Studio 2019.":::
   ::: moniker-end

1. On the **Configure your new project** page, enter a name for your project, and then select **Create**.

1. In your unit test project, add a reference to the code under test. To add a reference to a code project in the same solution:

   1. In **Solution Explorer**, right-click the test project, and select **Add** > **Reference**.

   1. In **Reference Manager**, select the **Solution** node under **Projects**.
   
   1. Select the code project you want to test, and then select **OK**.

   If the code you want to test is in another location, see [Managing references in a project](../ide/managing-references-in-a-project.md) for information about adding a reference.

## Related content

- [Unit test your code](../test/unit-test-your-code.md)
- [Writing unit tests for C/C++](writing-unit-tests-for-c-cpp.md)
- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)