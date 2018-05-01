---
title: "Add Computer Tags to Counter Set Mappings for load testing in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, counter set mappings, computer tags"
ms.assetid: f52a73e1-036a-4b28-a6c8-848284bf4488
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Add Computer Tags to Counter Set Mappings Using the Load Test Editor

Computer tags let you identify a computer with an easy-to-recognize name. The tags are displayed in the **Counter Set Mappings** node in the tree in the Load Test Editor. More important, the tags are displayed in Excel reports, which help stakeholders identify what role the computer has in the load test. For example, "Web Server1 in lab2" or "SQL Server2 in Phoenix office". For more information, see [Reporting Load Tests Results for Test Comparisons or Trend Analysis](../test/compare-load-test-results.md).

## To add a tag to a computer

1.  Open a load test.

2.  Choose the **Manage Counter Sets** button.

     – or –

     Right-click **Counter Sets** folder in the load test tree and choose **Manage Counter Sets**.

     The **Manage Counter Sets** dialog box is displayed.

3.  (Optional) In the **Selected computers and counter sets will be added under the following run settings** list box, select a different run setting.

    > [!NOTE]
    > This only applies if you have more than one run setting in your load test.

4.  Under **Computer and counter sets to monitor**, select the computer that you want to apply the tag to.

    > [!NOTE]
    > For information about how to add a computer, see [How to: Manage Counter Sets](../test/how-to-manage-counter-sets-using-the-load-test-editor.md).

5.  In the **Computer Tags** text box, type a tag to associate with the computer. For example, "TestMachine12 in lab3".

6.  Choose **OK**.

## See also

- [Analyzing Threshold Rule Violations](../test/analyze-threshold-rule-violations-in-load-tests.md)
- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [Specifying the Counter Sets and Threshold Rules for Computers in a Load Test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)
- [How to: Manage Counter Sets](../test/how-to-manage-counter-sets-using-the-load-test-editor.md)