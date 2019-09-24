---
title: Unit test Python code
description: Setting up unit testing for Python code in Visual Studio takes full advantage of Test Explorer features to discover, run, and debug tests.
ms.date: 09/18/2019
ms.topic: conceptual
author: JoshuaPartlow
ms.author: joshuapa
manager: jillfra
ms.custom: seodec18
ms.workload:
  - python
  - data-science
ms.topic: include
---

# Set up unit testing for Python code

Unit tests are pieces of code that test other code units in an application, typically isolated functions, classes, and so on. When an application passes all its unit tests, you can at least trust that its low-level functionality is correct.

Python uses unit tests extensively to validate scenarios while designing a program. Python support in Visual Studio includes discovering, executing, and debugging unit tests within the context of your development process, without needing to run tests separately.

This article provides a brief outline of unit testing capabilities in Visual Studio with Python. For more on unit testing in general, see [Unit test your code](../test/unit-test-your-code.md).

::: moniker range="vs-2017"

[!include[Testing Python code](includes/vs-2017/unit-testing-python.md)]

::: moniker-end

::: moniker range=">= vs-2019"

[!include[Testing Python code](includes/vs-2019/unit-testing-python.md)]

::: moniker-end