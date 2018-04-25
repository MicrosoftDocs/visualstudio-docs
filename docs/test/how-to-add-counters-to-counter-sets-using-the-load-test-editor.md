---
title: "Add Counters to Counter Sets for load testing in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "counters, counter sets"
  - "counter sets"
  - "load tests, counter sets"
ms.assetid: e17d0e71-f982-4fc1-a2df-a1065d37473d
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Add Counters to Counter Sets Using the Load Test Editor

When you create a load test with the **Load Test Wizard**, you add an initial set of counters. These offer you a set of predefined counter sets for your load test. For more information, see [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md).

> [!NOTE]
> If your load tests are distributed across remote machines, controller and agent counters are mapped to the controller and agent counter sets. For more information about how to use remote machines in your load test, see [Test controllers and test agents](configure-test-agents-and-controllers-for-load-tests.md).


 You manage your counters in the **Load Test Editor**. The counter sets that are already added to the test are visible in the **Counter Sets** node of the load test. After you create a load test, you can add new counters to existing counter sets.

## To add counters to a counter set

1.  Open a load test.

2.  Expand the **Counter Sets** node. All the counter sets that have been added to the load test are visible.

    > [!NOTE]
    > The load test hierarchy tree also contains the **Run Settings** node. This node contains the **Counter Set Mappings** node, which shows all the computers and the counter sets that are mapped to those computers.

3.  Right-click an existing counter set and then choose **Add Counters**.

     The **Pick Performance Counters** dialog box is displayed.

4.  In the **Computer** drop-down combo box, type the name of the computer you want to map to. Alternatively, select one of the computers in the drop-down list.

    > [!NOTE]
    > Because counter sets must be mapped to a computer before performance data is collected, you must specify a computer on which to collect performance data.

5.  Select a **Performance category** to filter the categories of performance data counters. You will see two columns of data from which to select performance counters.

    > [!NOTE]
    > Some counter categories will require that you select an instance also. For example, if you select a SQL counter, you must select a SQL instance because there may be more than one instance of SQL installed on the target computer.

6.  Select a counter and an instance to add to your custom counter set.

     \- or -

     Select the **All counters** radio button to select all available counters.

7.  Choose **OK**.

    > [!NOTE]
    > It is also possible to add counters to a counter set by right choosing an existing counter or counter category, choosing copy, and then pasting it to a different counter set node. Extra counters that are copied, but not needed, can be deleted.

## See also

- [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)
- [Configuring Load Test Run Settings](../test/configure-load-test-run-settings.md)