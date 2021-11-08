---
title: Run a unit test as a 64-bit process
description: Learn how to run unit tests and capture code coverage information as a 64-bit process. You must have a 64-bit computer.
ms.custom: SEO-VS-2020
ms.date: 03/10/2020
ms.topic: how-to
helpviewer_keywords: 
  - unit tests, creating
  - unit tests, running
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload: 
  - multiple
author: mikejo5000
---
# Run a unit test as a 64-bit process

If you have a 64-bit machine, you can run unit tests and capture code coverage information as a 64-bit process.

## To run a unit test as a 64-bit process

1. If your code or tests were compiled as 32-bit/x86, but you now want to run them as a 64-bit process, recompile them as **Any CPU**.

   ::: moniker range="vs-2017"
   Alternatively, In Visual Studio 2017, you could also compile your project as **64-bit**.
   ::: moniker-end

    > [!TIP]
    > For maximum flexibility, compile your test projects with the **Any CPU** configuration. Then you can run on both 32-bit and 64-bit agents. There's no advantage to compiling test projects with the **64-bit** configuration, unless you are calling code that is only supported on 64-bit.

2. Set the unit tests to run as a 64-bit process.

   ::: moniker range=">=vs-2019"
   From the Visual Studio menu, choose **Test**, then choose **Processor Architecture for AnyCPU projects**. Choose **x64** to run the tests as a 64-bit process.
   ::: moniker-end
   ::: moniker range="vs-2017"
   From the Visual Studio menu, choose **Test**, then choose **Test Settings**, and then choose **Processor Architecture**. Choose **x64** to run the tests as a 64-bit process.
   ::: moniker-end

   \- or -

   Specify `<TargetPlatform>x64</TargetPlatform>` in a *.runsettings* file. An advantage of this method is that you can specify groups of settings in different files and quickly switch between different settings. You can also copy settings between solutions. For more information, see [Configure unit tests by using a .runsettings file](../test/configure-unit-tests-by-using-a-dot-runsettings-file.md).

## See also

- [Run unit tests with Test Explorer](../test/run-unit-tests-with-test-explorer.md)
- [Unit test your code](../test/unit-test-your-code.md)
