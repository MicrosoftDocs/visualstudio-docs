---
title: Set load test run settings from the command line
description: A load test can include run settings, which are properties that influence the way a load test runs. Learn how to load run settings from the command line.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - load tests, command line
  - load tests, run settings, selecting
ms.assetid: 175d1d58-f09a-4449-b132-a29a394a7c8e
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Select a load test run setting to use from the command line

A load test can include *run settings*, which are properties that influence the way a load test runs. Run settings are organized by categories in the **Properties** window. When a load test is run, it uses the run setting that is currently set as active.

If your load test contains only one run setting, it is always the active node. If your load test contains multiple run settings nodes, you can select the one to use when you run a load test from the command line. See [How to: Add additional run settings to a load test](../test/how-to-add-additional-run-settings-to-a-load-test.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To change the run setting from the command line

1. If you want to use different run settings from the command line to take advantage of the context parameter strategy, use the following command:

    `Set Test.UseRunSetting= CorporateStagingWebServer`

2. Run the load test using mstest:

    `mstest /testcontainer:loadtest1.loadtest`

## See also

- [Configure load test run settings](../test/configure-load-test-run-settings.md)
- [Specify the counter sets and threshold rules for computers in a load test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)
- [How to: Add additional run settings to a load test](../test/how-to-add-additional-run-settings-to-a-load-test.md)
- [How to: Select the active run setting for a load test](../test/how-to-select-the-active-run-setting-for-a-load-test.md)
