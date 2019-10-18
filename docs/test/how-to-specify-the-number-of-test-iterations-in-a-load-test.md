---
title: "Specify number of test iterations in load test run setting"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, properties"
  - "load tests, run settings"
ms.assetid: 45a625db-b3e7-4d64-beda-b9a76248096d
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Specify the number of test iterations in a load test run setting

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the scenarios properties to meet your testing needs and goals. For more information, see [Walkthrough: Create and run a load test](../test/walkthrough-create-and-run-a-load-test.md).

Using the **Load Test Editor**, you can edit the **Test Iterations** property of a run settings value in the **Properties** window. The **Test Iterations** property specifies the number of iterations to run on all the web performance and unit tests in all the scenarios in a load test using the **Load Test Editor**.

> [!NOTE]
> For a complete list of the run settings properties and their descriptions, see [Load test run settings properties](../test/load-test-run-settings-properties.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To specify the number of test iterations in a run setting

1. Open a load test.

     The **Load Test Editor** appears and displays the load test tree.

2. In the load test tree, in the **Run Settings** folder, choose a run setting.

3. On the **View** menu, select **Properties Window** to view the load run setting's categories and properties.

4. Set the **Use Test Iterations** property to **True**.

5. In the **Test Iterations** property, enter a number that indicates the number of test iterations to run during the load test.

6. After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Test Iterations** value.

## See also

- [Configure load test run settings](../test/configure-load-test-run-settings.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)