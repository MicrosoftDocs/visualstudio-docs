---
title: "Export Load Test Results"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "results, load test"
  - "load tests, exporting results"
  - "Load Test Results Repository"
  - "load test results, exporting"
ms.assetid: 716c2af5-8737-4d31-956f-a0273f7c5c0c
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Export load test results from a repository

When you run a load test, information gathered during the run is stored in the Load Test Results Repository. The Load Test Results Repository contains performance counter data and information about any errors. For more information, see [Manage load test results in the Load Test Results Repository](../test/manage-load-test-results-in-the-load-test-results-repository.md).

You can manage load test results from the Load Test Editor by using the **Open and Manage Load Test Results** dialog box. You can open, import, export, and remove load test results.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To export results from a repository

1. From a web performance and load test project, open a load test.

2. On the embedded toolbar, choose **Open and Manage Results**.

     The **Open and Manage Load Test Results** dialog box is displayed.

3. In **Enter a controller name to find load test results**, select a controller. Select **\<Local - No controller>** to access results stored locally.

4. In **Show results for the following load test**, select the load test whose results you want to view. Select **\<Show results for all tests>** to see all results for all tests.

     If load test results are available, they appear in the **Load test results** list. The columns are **Time**, **Duration**, **User**, **Outcome**, **Test**, and **Description**. **Test** contains the name of the test, and **Description** contains the optional description that is added before the test is run. The **Description** column displays the short descriptions that were entered in the **Analysis Comments** for this test result.

5. In the **Load test results** list, choose a result. You can use the **Shift** key, the **Ctrl** key, or both to select more than one result, and export them to a single file.

6. Choose **Export**.

     The **Export Load Test Results** dialog box appears.

7. In the **File name** box, type a name, and then choose **Save**.

     The results are exported to an archive file.

    > [!NOTE]
    > The **Open and Manage Load Test Results** dialog box remains open after the results appear.

## See also

- [Manage load test results in the Load Test Results Repository](../test/manage-load-test-results-in-the-load-test-results-repository.md)
- [How to: Delete load test results from a repository](../test/how-to-delete-load-test-results-from-a-repository.md)
- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [How to: Import load test results into a repository](../test/how-to-import-load-test-results-into-a-repository.md)