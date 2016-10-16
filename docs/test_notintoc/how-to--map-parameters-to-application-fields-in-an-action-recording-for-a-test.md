---
title: "How to: Map Parameters to Application Fields in an Action Recording for a Test"
ms.custom: na
ms.date: "09/28/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Test Runner, mapping parameters to fields"
  - "action recording, mapping parameters"
  - "Test Runner, action recordings, mapping parameters"
  - "Test Runner, action recordings"
ms.assetid: b4ae9a7d-e827-4f09-941a-b9d3c0fa3fce
caps.latest.revision: 35
ms.author: "ahomer"
manager: "kamrani"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Map Parameters to Application Fields in an Action Recording for a Test
If you have a test with parameters, you can run multiple iterations of that test using each parameter set. If you want to replay the test for an iteration using an action recording, you must map each parameter to an input field. Mapping each parameter lets you play the action recording and instead of a fixed value, the value of the parameter for the iteration will be substituted into the input field. If parameters are not mapped, a fixed value is used.  
  
 You can use parameters on the actions or expected results for any test step in your test case. Then you can add multiple sets of values for the parameters that you want to use in your test. Each set of values for the parameters is run as an individual iteration of the test using [!INCLUDE[mtrshort](../test_notintoc/includes/mtrshort_md.md)]. When you create an action recording, you can copy the value of each parameter when you run the test and then paste the value into your input field in your application under test. For example, you can have an action parameter for an item's cost and the quantity of that item together with an expected result parameter that verifies that the total is accurate. This is shown in the following illustration for the procedure [Map Data Parameters to Application Fields in an Action Recording](#MapDataParameters).  
  
 For more information about how to create a test case with parameters, see [Repeat a test with different data](../test/repeat-a-test-with-different-data.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
## Load a Test into Test Runner  
 ![Selecting test to run in Microsoft Test Manager](../test_notintoc/media/runtest.png "RunTest")  
  
#### To load a test into Test Runner  
  
1.  Open [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)]. (Go to Start, All Programs, Microsoft Visual Studio, Microsoft Test Manager.)  
  
2.  On the center group switcher, choose the down-arrow and then choose **Testing Center**.  
  
3.  On the center group menu bar, click **Test**.  
  
4.  In the menu under the center group menu bar, choose **Run Tests** if it is not already selected.  
  
5.  In the left pane, under **Run Tests**, select either the test plan or the test suite listed under the test plan that contains the test that you want to run.  
  
     The right side pane displays the test cases within the selected test suite.  
  
6.  In the right side pane, choose the test case and then choose **Run**.  
  
     The **Test Runner** opens.  
  
    > [!NOTE]
    >  Select **Run with options** to specify a build to run the test on, or to override the test settings and environment settings for the test plan.  
  
##  <a name="MapDataParameters"></a> Map Data Parameters to Application Fields in an Action Recording  
 ![Mapping parameters to application input fields](../test_notintoc/media/howtomanual_parameters_map_actionrecording.png "HowToManual_Parameters_Map_ActionRecording")  
  
#### To map parameters to application fields  
  
1.  In [!INCLUDE[mtrlong](../codequality/includes/mtrlong_md.md)], you are prompted to **Start Test** with the option to **Create action recording**. Select **Create action recording** and choose **Start Test**.  
  
    > [!NOTE]
    >  If you have configured test settings to create an action log for the test being run, selecting the **Create action recording** option when you start a test will use the settings that you configured. If you did not configure the actions diagnostic data adapter in your test settings, then the default values are used to create your action recording. For more information, see [How to: Choose the applications that are recorded](../test_notintoc/how-to--choose-the-applications-that-are-recorded-in-a-manual-test.md).  
  
     Notice that [!INCLUDE[mtrshort](../test_notintoc/includes/mtrshort_md.md)] includes iteration information at the top. The number of iterations will be equal to the number of parameter sets that you created when you created the test case. For more information, see[Repeat a test with different data](../test/repeat-a-test-with-different-data.md).  
  
2.  Perform the steps of the test case for the first iteration of the test and mark each step with a result. Use the drop-down arrow to the right of the step and select either **Pass** or **Fail**.  
  
    1.  When you come to a step that uses a parameter associated with the action, for example the **Enter Quantity** and **Override price** steps in the previous screen shot, you will see the parameter displayed as a link within the test step. You can copy the data that was assigned for the parameter by choosing its link. This copies the data into the systems clipboard. You can then copy it into the appropriate input field in the application under test using CTRL+V.  
  
        > [!CAUTION]
        >  Right-clicking a UI control or input field on the application under test to view the shortcut menu, and then using the **Paste** option will not correctly map the parameter. This is because action recording recognizes and records it as a mouse choose action. You must either use CTRL+V or type the value.  
  
         When the parameter data has been copied to the application under test, use the drop-down arrow to the right of the step and select either **Pass** or **Fail**.  
  
        > [!NOTE]
        >  During an action recording, the copying action also maps the parameter to the specific input field that you pasted the data into. If the mapping is successful, then a green check mark icon is displayed before the parameter and the icon after the parameter has a tooltip that states the field that the parameter is now mapped to. If the mapping was not successful, a warning icon is displayed next to the Pass or Fail icon.  
  
    2.  When you come to a step that uses a parameter associated with an expected result, for example, the **Choose update** step in the previous screen shot, verify that the output field in the application under test is the same as the expected result displayed in the test step. Next, use the drop-down arrow to the right of the step and select either **Pass** or **Fail**.  
  
3.  Choose **End iteration and move to next**.  
  
    > [!IMPORTANT]
    >  If you did not successfully map a parameter to an input field in the application, a dialog box will appear. The dialog box informs you that some parameters are not mapped to any UI controls. If any parameters are not successfully mapped, if you play back the action recording for an iteration of the test, only the recorded values will be used and not the parameter values because the parameters are not mapped to a UI control. You can either try to reset and create a new action recording, or modify the test so that you can correctly map the parameters to the various UI controls.  
  
4.  Choose **Start Test** to run the next iteration.  
  
     You can now use the action recording to run the next iteration of the test.  
  
## See Also  
 [Run your tests](../test/running-manual-tests-using-the-web-portal.md)   
 [Repeat a test with different data](../test/repeat-a-test-with-different-data.md)   
 [How to: Map Parameters for an Action Recording for a Test](../test_notintoc/how-to--map-parameters-to-application-fields-in-an-action-recording-for-a-test.md)