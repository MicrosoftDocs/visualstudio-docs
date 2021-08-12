---
title: Create a Diagnostic Data Adapter for testing
description: Learn how to write code to perform tasks at specific points in your test run by using APIs provided within Visual Studio Enterprise.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords:
  - Diagnostic Data Adapter [Visual Studio ALM]
  - Diagnostic Data Adapter
ms.assetid: b0b53fae-7007-4ad9-a604-21685937622f
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Create a diagnostic data adapter to collect custom data or affect a test machine

You might want to create your own diagnostic data adapter to collect data when you run a test, or you might want to affect the test machine as part of your test. For example, you might want to collect log files that are created by your application under test and attach them to your test results, or you might want to run your tests when there is limited disk space left on your computer. Using APIs provided within Visual Studio Enterprise, you can write code to perform tasks at specific points in your test run. For example, you can perform tasks when a test run starts, before and after each individual test is run, and when the test run finishes.

::: moniker range="vs-2017"
You can provide default input to your custom diagnostic data adapter using a configuration settings file. For example, you can provide information about the location of the file you want to collect and attach to your test results, or how much disk space you want to be left on the system. This data can be configured for each test settings that you create. It can be displayed and edited using the default editor provided with Microsoft Test Manager or you can create your own user control to use as an editor. Any changes that are made to the adapter configuration in your editor are stored with your test settings.
::: moniker-end

::: moniker range=">=vs-2019"
You can provide default input to your custom diagnostic data adapter using a configuration settings file. For example, you can provide information about the location of the file you want to collect and attach to your test results, or how much disk space you want to be left on the system. This data can be configured for each test settings that you create. You can create your own user control to use as an editor. Any changes that are made to the adapter configuration in your editor are stored with your test settings.
::: moniker-end

If you are running your tests from Visual Studio, you must set these test settings to be active. For more information about test settings, see [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Tasks

Use the following topics to help you create Diagnostic Data Adapters:

|Tasks|Associated Topics|
|-|-----------------------|
|**Creating a Diagnostic Data Adapter:** You create a diagnostic data adapter by creating a class library, and then use the diagnostic data adapter APIs to collect information that you want or impact a test system that you are using to run your tests.|-   [How to: Create a diagnostic data adapter](../test/how-to-create-a-diagnostic-data-adapter.md)|
|**Selecting a Custom Diagnostic Data Adapter to Use When Tests are Run:** You can select which diagnostic data adapter to use for your test settings, so that the adapter is used when you run your tests.|-   [Collect diagnostic data while testing (Azure Test Plans)](/azure/devops/test/collect-diagnostic-data?view=vsts&preserve-view=true)<br />-   [Collect diagnostic data in manual tests (Azure Test Plans)](/azure/devops/test/mtm/collect-more-diagnostic-data-in-manual-tests?view=vsts&preserve-view=true)|

## See also

- [Collect diagnostic information using test settings](../test/collect-diagnostic-information-using-test-settings.md)