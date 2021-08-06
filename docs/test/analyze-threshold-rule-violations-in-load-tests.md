---
title: Analyzing Threshold Rule Violations in Load Tests
description: Learn how to view violations of threshold rules that you set up, so that you can analyze the violations. 
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: conceptual
f1_keywords:
- vs.test.load.monitor.threshholdresult
helpviewer_keywords:
- load tests, thresholds
- threshold violations
- threshold counts
- load tests, threshold violations
- load test results, analyzing threshold violations
- thresholds in load tests
ms.assetid: 969ed346-cf2e-4d48-82b3-edb3e075e1c0
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Analyzing threshold rule violations in load tests Using the Load Test Analyzer

Threshold rules are associated with specific performance counters, and violations indicate that a performance counter exceeded or fell below a set value. When you run a load test, you can analyze violations that occur for the threshold rules you set up previously.

If any violations occurred, a **threshold violations** hyperlink appears on the **Load Test Analyzer** status bar and specifies the number of violations that occurred. You choose the hyperlink to display the threshold violations table. You can also view threshold violations in the **Counters** window, and on the graph.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## View threshold violations in the table

The threshold violations table displays the first 1,000 violations. The following table contains these columns:

|Column|Description|Visible By Default|
|-|-|-|
|Time|The time during the load test at which the violation occurred.|Yes|
|Computer|The name of the computer under test on which the violation occurred. **Note:**  This is important when you run load tests on rigs.|Yes|
|Category|The category of the performance counter on which the violation occurred.|Yes|
|Counter|The name of the performance counter on which the violation occurred.|Yes|
|Instance|The performance counter instance on which the violation occurred.|Yes|
|Message|A message that describes the threshold violation. For example, **The value 5 exceeds the critical threshold value of 0**.|Yes|

> [!NOTE]
> You can sort the table by choosing the column headers.

For more information, see [Analyze load test results and errors in the Tables view](../test/analyze-load-test-results-and-errors-in-the-tables-view.md).

## View threshold violations in the Counters panel

You can view threshold violations in the **Counters** panel, in the tree that lists the performance counters for your load test. Icons in the **Counters** panel communicate threshold violations. The icon will be one of the following:

The icon will be one of the following:

![No threshold violation](../test/media/icon_ltest_1.gif) No threshold violation.

![A critical threshold violation on last interval](../test/media/icon_ltest_2.gif) A critical threshold violation occurred on the last interval.

![A critical threshold violation on a prior interval](../test/media/icon_ltest_3.gif) A critical threshold violation occurred on a prior interval.

![A warning threshold violation on the last interval](../test/media/icon_ltest_4.gif) A warning threshold violation occurred on the last interval.

![A warning threshold violation on a prior interval](../test/media/icon_ltest_5.gif) A warning threshold violation occurred on a prior interval.

Optionally, threshold violations can be shown on the graph also. The threshold icon appears on the graph next to the data point where the threshold violation occurred.

In the counter tree, the icon for a threshold violation is propagated from the specific counter node, up to the root node. This alerts you to a violation on a counter that may not be visible in the tree because the tree has not been expanded.

## View threshold violations on the graph

You can view threshold violations on the graph. Similar to the **Counters** panel, icons communicate threshold violations on the graph. The icons appear on the graph next to the data point where the threshold violation occurred. If a threshold violation occurs on a counter that does not appear on the graph, you can add it to the graph by dragging it from the **Counters** panel to the graph.

For more information, see [Analyze load test results in the Graphs view](../test/analyze-load-test-results-in-the-graphs-view.md).

## See also

- [Specifying the counter sets and threshold rules for computers in a load test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)
- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [Analyze load test results and errors in the Tables view](../test/analyze-load-test-results-and-errors-in-the-tables-view.md)
