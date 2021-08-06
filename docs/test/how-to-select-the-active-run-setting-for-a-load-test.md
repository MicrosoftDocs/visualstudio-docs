---
title: Select a Run Setting for a Load Test
description: A load test can include run settings, which are properties that influence the way a load test runs. Learn how to select the active run setting.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - load tests, run settings, active
ms.assetid: ed6ff546-acfa-4dd8-b3a2-6e7455930ca4
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Select the active run setting for a load test

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

A load test can contain one or more *run settings* which are a set of properties that influence the way a load test runs. Run settings are organized by categories in the **Properties** window. When a load test is run, it uses the run setting that is currently set as active.

> [!NOTE]
> For a complete list of the run settings properties and their descriptions, see [Load test run settings properties](../test/load-test-run-settings-properties.md).

If your load test contains only one run setting node under the **Run Settings** folder, that node is always the active node. If your load test contains multiple run settings nodes, you can select the one to use when you run a load test. See [How to: Add Additional Run Settings to a Load Test](../test/how-to-add-additional-run-settings-to-a-load-test.md).

In the **Load Test Editor**, the active run setting is identified by the "[Active]" suffix.

## Select the active run setting

1. Open a load test.

2. Expand the **Run Settings** folder.

3. Right-click the run settings node that you want to be the active node, and then choose **Set As Active**.

     In the **Load Test Edito**r, the affected run setting node is updated with the "[Active]" suffix.

     The run setting selected becomes active, and remains active until you select a different run setting to be active.

> [!NOTE]
> You can override the active run setting by setting an environment variable named `Test.UseRunSetting=<run setting name>`. This is useful when you run a load test from the command line or from a batch file. This lets you choose different run settings without opening your load test.

## Specify the run setting to use from the command line

You can override the default run settings in your load test by setting an environment variable from the command line:

**Set Test.UseRunSetting=PreProdEnvironment**

And to run the test:

**mstest /testcontainer:loadtest1.loadtest**

## See also

- [Configure load test run settings](../test/configure-load-test-run-settings.md)
- [Specify the counter sets and threshold rules for computers in a load test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)
- [How to: Add additional run settings to a load test](../test/how-to-add-additional-run-settings-to-a-load-test.md)
