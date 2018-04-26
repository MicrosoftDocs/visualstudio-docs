---
title: "How to: Import Load Test Results into a Repository in Visual Studio"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "results, load test"
  - "load test results, importing"
  - "Load Test Results Repository"
  - "load tests, importing results"
ms.assetid: a955b3d2-c8ad-40dd-8ea3-9f1a271e1eed
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# How to: Import Load Test Results into a Repository

When you run a load test, information gathered during the run is stored in the Load Test Results Repository. The Load Test Results Repository contains performance counter data and information about any errors. For more information, see [Managing Load Test Results in the Load Test Results Repository](../test/manage-load-test-results-in-the-load-test-results-repository.md).

 You can manage load test results from the Load Test Editor by using the **Open and Manage Load Test Results** dialog box. You can open, import, export, and remove load test results.

## To import results into a repository

1.  From a Web performance and load test project, open a load test.

2.  On the embedded toolbar, choose **Open and Manage Results**.

     The **Open and Manage Load Test Results** dialog box is displayed.

3.  In **Enter a controller name to find load test results**, select a controller. Select **\<local>** to access results stored locally.

     If there are load test results available, they appear in the **Load test results** list. The columns are **Time**, **Duration**, **User**, **Outcome**, **Test**, and **Description**. **Test** contains the name of the test, and **Description** contains the optional description that is added before the test is run.

4.  Choose **Import**.

     The **Import Load Test Results** dialog box appears.

5.  In the **File name** box, type the name of an archived test results file, and then choose **Open**.

     \- or -

     Browse to the file, and then choose **Open**.

    > [!NOTE]
    > An archived test results file that you specify in this step must have been created by performing the Export operation.

     The results are imported and appear in the **Load test results** list.

## See also

- [Managing Load Test Results in the Load Test Results Repository](../test/manage-load-test-results-in-the-load-test-results-repository.md)
- [Analyze Load Test Results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [How to: Export Load Test Results from a Repository](../test/how-to-export-load-test-results-from-a-repository.md)