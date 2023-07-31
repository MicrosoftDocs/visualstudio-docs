---
title: Unit test Python code
description: Setting up unit testing for Python code in Visual Studio takes full advantage of Test Explorer features to discover, run, and debug tests.
ms.date: 04/01/2022
ms.topic: how-to
author: cwebster-99
ms.author: cowebster
manager: jmartens
ms.technology: vs-python

ms.workload:
  - python
  - data-science
---
# Set up unit testing for Python code

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Unit tests are pieces of code that test other code units in an application, typically isolated functions, classes, and so on. When an application passes all its unit tests, you can at least trust that its low-level functionality is correct.

Python uses unit tests extensively to validate scenarios while designing a program. Python support in Visual Studio includes discovering, executing, and debugging unit tests within the context of your development process, without needing to run tests separately.

This article provides a brief outline of unit testing capabilities in Visual Studio with Python. For more on unit testing in general, see [Unit test your code](../test/unit-test-your-code.md).

::: moniker range=">= vs-2019"

[!include[Testing Python code](includes/vs-2019/unit-testing-python.md)]

::: moniker-end