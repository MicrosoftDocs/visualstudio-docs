---
title: "Set Visual Studio load test run settings from the command line"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, command line"
  - "load tests, run settings, selecting"
ms.assetid: 175d1d58-f09a-4449-b132-a29a394a7c8e
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Select a Load Test Run Setting to Use from the Command-Line

A load test can contain one or more *run settings*, which are a set of properties that influence the way a load test runs. Run settings are organized by categories in the Properties window. When a load test is run, it uses the run setting that is currently set as active.

 If your load test contains only one run setting, it is always the active node. If your load test contains multiple run settings nodes, you can select the one to use when you run a load test from the command-line. See [How to: Add Additional Run Settings to a Load Test](../test/how-to-add-additional-run-settings-to-a-load-test.md).

## To change the run setting from the command-line

1.  If you want to use different run settings from the command line to take advantage of the context parameter strategy, use the following command:

    `Set Test.UseRunSetting= CorporateStagingWebServer`

2.  Run the load test using mstest:

    `mstest /testcontainer:loadtest1.loadtest`

## See also

- [Configuring Load Test Run Settings](../test/configure-load-test-run-settings.md)
- [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)
- [How to: Add Additional Run Settings to a Load Test](../test/how-to-add-additional-run-settings-to-a-load-test.md)
- [How to: Select the Active Run Setting for a Load Test](../test/how-to-select-the-active-run-setting-for-a-load-test.md)