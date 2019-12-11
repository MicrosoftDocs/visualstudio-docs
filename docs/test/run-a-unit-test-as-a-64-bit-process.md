---
title: "Run a unit test as a 64-bit process"
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "unit tests, creating"
  - "unit tests, running"
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
author: jillre
---
# Run a unit test as a 64-bit process

If you have a 64-bit machine, you can run unit tests and capture code coverage information as a 64-bit process.

## To run a unit test as a 64-bit process

1. If your code or tests were compiled as 32-bit/x86, but you now want to run them as a 64-bit process, recompile them as **Any CPU**, or optionally as **64-bit**.

    > [!TIP]
    > For maximum flexibility, compile your test projects with the **Any CPU** configuration. Then you can run on both 32-bit and 64-bit agents. There's no advantage to compiling test projects with the **64-bit** configuration.

2. From the Visual Studio menu, choose **Test**, then choose **Settings**, and then choose **Processor Architecture**. Choose **x64** to run the tests as a 64-bit process.

   - or -

   Specify `<TargetPlatform>x64</TargetPlatform>` in a *.runsettings* file. An advantage of this method is that you can specify groups of settings in different files and quickly switch between different settings. You can also copy settings between solutions. For more information, see [Configure unit tests by using a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md).

## See also

- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)
- [Unit test your code](../test/unit-test-your-code.md)
