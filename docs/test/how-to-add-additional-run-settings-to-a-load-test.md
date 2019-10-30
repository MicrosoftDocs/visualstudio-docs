---
title: "Add Run Settings to a Load Test"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, run settings, adding"
  - "load tests, run settings"
ms.assetid: 257d2a24-d582-4cfe-8b2b-51f51ba9cc84
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Add additional run settings to a load test

The run settings of a load test determine a variety of other settings. These include the duration of the test, results collection detail level, and the counter sets that are collected when the test runs. You can create and store multiple run settings for each load test, and then select one particular setting to use when you run the test. An initial run setting is added to your load test when you create your load test by using the **New Load Test Wizard**.

You can add more run settings to your load test with different property settings so that you can run the load test under different conditions. For example, you can add a new test setting and use a different sample rate, or specify a longer run duration. You can use only one run setting at a time and must specify which run setting to use by marking it as active.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To add another run setting

1. Open a load test.

2. (Optional) Expand the **Run Settings** folder.

3. Right-click the **Run Settings** folder and select **Add Run Settings**.

     A new run setting is added to the **Run Settings** folder.

4. On the **View** menu, choose **Properties Window**.

     The **Properties** window is displayed with the properties for the selected run setting.

5. In the **Properties** window, use the text box for the **Name** property to give the new run setting a name that describes the intent of the run setting (for example, **Run Setting: Five minute run**).

6. Use the **Properties** window to change the run settings. For example, change the run duration to **00:05:00** to run your test for five minutes.

    > [!NOTE]
    > For a full list of the run settings properties and their descriptions, see [Load test run settings properties](../test/load-test-run-settings-properties.md).

     You can now specify that you want to use the added run setting by setting it to active. For more information, see [How to: Select the active run setting for a load test](../test/how-to-select-the-active-run-setting-for-a-load-test.md).

## See also

- [Configure load test run settings](../test/configure-load-test-run-settings.md)
- [Specify the counter sets and threshold rules for computers in a load test](../test/specify-counter-sets-and-threshold-rules-for-load-testing.md)