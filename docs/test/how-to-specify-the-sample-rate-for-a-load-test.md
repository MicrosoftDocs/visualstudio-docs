---
title: "How to: Specify the Sample Rate for a Load Test Run Setting"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, run settings"
ms.assetid: 51cbe7d6-5dfd-4842-bca3-f7f8a665dc84
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Specify the sample rate for a load test run setting

After you create your load test with the **New Load Test Wizard**, you can use the **Load Test Editor** to change the properties to meet your testing needs and goals.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

Using the **Load Test Editor**, you can edit a run setting's **Sample Rate** property's value in the **Properties** window. For a complete list of the run settings properties and their descriptions, see [Load test run settings properties](../test/load-test-run-settings-properties.md).

Choose an appropriate value for the **Sample Rate** property for the load test run setting based on the length of your load test. A smaller sample rate, such as the default value of five seconds, requires more space in the load test results database. For longer load tests, increasing the sample rate reduces the amount of data that you collect. For more information, see [How to: Specify the sample rate for a load test run setting](../test/how-to-specify-the-sample-rate-for-a-load-test.md).

Here are some guidelines for sample rates:

|Load Test Duration|Recommended Sample Rate|
|-|-----------------------------|
|\< 1 Hour|5 seconds|
|1 - 8 Hours|15 seconds|
|8 - 24 Hours|30 seconds|
|> 24 Hours|60 seconds|

## To specify performance counter sampling rate in a run setting

1. Open a load test.

     The **Load Test Editor** appears. The load test tree is displayed.

2. In the load test tree, in the **Run Settings** folder, choose the run setting that you want to specify the sample rate for.

3. On the **View** menu, select **Properties Window**.

     The load run setting's categories and properties are displayed in the **Properties** window.

4. In the **Sample Rate** property, enter a time value that indicates the frequency at which the load test will collect performance counter data.

5. After you have finished changing the property, choose **Save** on the **File** menu. You can then run your load test using the new **Sample Rate** value.

## See also

- [Configure load test run settings](../test/configure-load-test-run-settings.md)
- [Load test scenario properties](../test/load-test-scenario-properties.md)