---
title: "Select a Run Setting for a Load Test in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, run settings, active"
ms.assetid: ed6ff546-acfa-4dd8-b3a2-6e7455930ca4
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Select the Active Run Setting for a Load Test

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals.

A load test can contain one or more *run settings* which are a set of properties that influence the way a load test runs. Run settings are organized by categories in the Properties window. When a load test is run, it uses the run setting that is currently set as active.

> [!NOTE]
> For a complete list of the run settings properties and their descriptions, see [Load Test Run Settings Properties](../test/load-test-run-settings-properties.md).

If your load test contains only one run setting node under the **Run Settings** folder, that node is always the active node. If your load test contains multiple run settings nodes, you can select the one to use when you run a load test. See [How to: Add Additional Run Settings to a Load Test](../test/how-to-add-additional-run-settings-to-a-load-test.md).

In the Load Test Editor, the active run setting is identified by the "[Active]" suffix.

## Selecting the Active Run Setting

### To select the active run setting in a load test

1.  Open a load test.

2.  Expand the **Run Settings** folder.

3.  Right-click the run settings node that you want to be the active node, and then choose **Set As Active**.

     In the **Load Test Edito**r, the affected run setting node is updated with the "[Active]" suffix.

     The run setting selected becomes active, and remains active until you select a different run setting to be active.

> [!NOTE]
> You can override the active run setting by setting an environment variable named `Test.UseRunSetting=<run setting name>`. This is useful when you run a load test from the command line or from a batch file. This lets you choose different run settings without opening your load test.


## Specifying the Run Setting to Use from the Command Line
 You can override the default run settings in your load test by setting an environment variable from the command line:

 **Set Test.UseRunSetting=PreProdEnvironment**

 And the run the test:

 **mstest /testcontainer:loadtest1.loadtest**

## See also

- [Configuring Load Test Run Settings](../test/configure-load-test-run-settings.md)
- [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)
- [How to: Add Additional Run Settings to a Load Test](../test/how-to-add-additional-run-settings-to-a-load-test.md)