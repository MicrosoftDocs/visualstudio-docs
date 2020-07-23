---
title: Create a unit test project
ms.date: 01/29/2019
ms.topic: how-to
ms.author: mikejo
manager: jillfra
ms.workload: 
  - multiple
author: mikejo5000
---
# Create a unit test project

Unit tests often mirror the structure of the code under test. For example, a unit test project would be created for each code project in the product. The test project can be in the same solution as the production code, or it can be in a separate solution. You can have multiple unit test projects in a solution.

> [!NOTE]
> The location of unit tests for native code and the test project structure can be different than the structure that is described in this article. For more information, see [Writing unit tests for C/C++](writing-unit-tests-for-c-cpp.md).

## To create a unit test project

1. On the **File** menu, choose **New** > **Project**, or press **Ctrl**+**Shift**+**N**.

::: moniker range="vs-2017"

2. In the **New Project** dialog box, expand the **Installed** node, choose the language that you want to use for your test project, and then choose **Test**.

3. Select the project template for the test framework that you want to use, for example **MSTest Test Project** or **NUnit Test Project**. Name the project, and then choose **OK**.

   ![Test project templates in Visual Studio 2017](media/test-project-templates.png)

::: moniker-end

::: moniker range=">=vs-2019"

2. On the **Create a new project** page, type **unit test** into the search box. Select the project template for the test framework that you want to use, for example **MSTest Test Project** or **NUnit Test Project**, and then choose **Next**.

   ![Test project templates in Visual Studio 2019](media/vs-2019/test-project-templates.png)

3. On the **Configure your new project** page, enter a name for your project, and then choose **Create**.

::: moniker-end

4. In your unit test project, add a reference to the code under test. To add a reference to a code project in the same solution:

   1. Select the test project in **Solution Explorer**.

   2. On the **Project** menu, choose **Add Reference**.

   3. In **Reference Manager**, select the **Solution** node under **Projects**. Select the code project you want to test, and then select **OK**.

   If the code that you want to test is in another location, see [Managing references in a project](../ide/managing-references-in-a-project.md) for information about adding a reference.

## Next steps

See one of the following sections:

**Writing unit tests**

- [Unit test your code](../test/unit-test-your-code.md)

- [Writing unit tests for C/C++](writing-unit-tests-for-c-cpp.md)

- [Use the MSTest framework in unit tests](using-microsoft-visualstudio-testtools-unittesting-members-in-unit-tests.md)

**Running unit tests**

- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)
