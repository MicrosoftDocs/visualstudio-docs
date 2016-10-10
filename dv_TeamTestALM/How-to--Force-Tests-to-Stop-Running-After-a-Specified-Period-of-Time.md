---
title: "How to: Force Tests to Stop Running After a Specified Period of Time"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b1a94439-28c3-499f-998e-219e1c46ac70
caps.latest.revision: 39
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Force Tests to Stop Running After a Specified Period of Time
You can set time limits with which the execution of a test or a test run will comply. You might need to do this, for example, if you work in a test lab and need a test run to complete by a certain time of day.  
  
 Another scenario for the use of time limits is that of non-responsive code. If a test encounters a section of code that does not respond, your use of a test time-out and a test-run time-out lets the individual test finish so that the test run can continue with subsequent tests.  
  
 There are two ways to set time limits:  
  
-   [Setting Time-Out period for All Tests](../dv_TeamTestALM/How-to--Force-Tests-to-Stop-Running-After-a-Specified-Period-of-Time.md#TimeOutAllTests) **:** You set time-out values for tests and test runs in test settings. For more information about test settings, see [Specifying Test Settings for Visual Studio Tests](../dv_TeamTestALM/Specifying-Test-Settings-for-Visual-Studio-Tests.md).  
  
-   [Override the Per-Test Time-Out Value on Individual test](../dv_TeamTestALM/How-to--Force-Tests-to-Stop-Running-After-a-Specified-Period-of-Time.md#TimeOutIndividualTestt) **:** You can override the per-test time-out value by setting a property on an individual test. You cannot override the test-run time-out value.  
  
 You cannot set test time-outs for specific test types. Test time-outs do not apply to manual tests, but the test-run time-outs are always in effect, even for test runs that contain manual tests.  
  
 Setting time limits for tests and test runs has these effects:  
  
-   When the duration of a test run reaches its time-out value, the test run is aborted, even if some tests have not been run.  
  
-   When the duration of an individual test reaches its time-out value, the execution of that test stops, and the test is marked as **Timeout**. The test run continues with the subsequent test.  
  
 **How Initialization Methods Affect Test Time-Outs**  
  
 A test run can include an <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssemblyInitializeAttribute?qualifyHint=False> method and a <xref:Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute?qualifyHint=False> method. If these methods are defined, they will take a finite amount of time to complete, and then the first test in the test run starts.  
  
 The amount of time that the initialization methods use is added to the amount of time that the first test uses. We can express this as a formula that uses these terms:  
  
-   Dt = total duration  
  
-   Dr = amount of time that a test runs  
  
-   I = initialization methods for the assembly and the class  
  
-   Tn = test that runs in a random position within a test run  
  
-   T1 = test that runs in the first position within a test run  
  
 The following applies for all tests after the first test:  
  
 **D**t**[T**n**] = D**r**[T**n**]**  
  
 But note the following case:  
  
 **D**t**[T**1**] = D**r**[T**1**] + D[I]**  
  
 The first test that runs might have a per-test time-out value assigned. In this case, the initialization time counts toward the time limit that is imposed on the first test, and it therefore could cause that test to fail.  
  
> [!NOTE]
>  This limitation could cause only the first test to fail. Subsequent tests in the test run are unaffected.  
  
 If your test run includes initialization methods, you could circumvent this limitation in the following way: Apply to each test a time-out that is greater than the sum of the expected execution times for the test method and any initialization methods. You would have to do this for each test. Because unit testing does not guarantee the order in which tests run, you cannot predict which test will run first.  
  
 **How Cleanup Methods Affect Test Run Time-Outs**  
  
 A test run can include an <xref:Microsoft.VisualStudio.TestTools.UnitTesting.AssemblyCleanupAttribute?qualifyHint=False> method and a <xref:Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute?qualifyHint=False> method. After these methods complete, the test run ends.  
  
 The test run might have a time-out value assigned. The amount of time that is used by the cleanup methods is added to the total amount of time that is used by the test run. In other words, the cleanup time counts toward the time limit that you have imposed on the test run as a whole, and therefore could cause the test run to time out.  
  
##  <a name="TimeOutAllTests"></a> Setting Time-Out period for All Tests  
 This procedure involves creating a test settings file. We recommend avoiding this if you can, because it forces your tests to run under an older framework that is less efficient.  
  
1.  In the Solution Items folder of your solution, double-click the test settings file. If you don’t have a \*.testsettings file, right-click the solution and choose **Add Item**, **Test Settings**.  
  
     The **Configuration Settings** dialog box appears.  
  
2.  Choose **Test Timeouts**.  
  
3.  Check **Abort a test run if its total execution time exceeds:**  
  
4.  Set the test run time-out value, in hours, minutes, and seconds.  
  
5.  Choose **Save** and then choose **Close**.  
  
     Make this the active test settings file. Choose **Test** > **Test Settings** > **Set the Test Settings File**.  
  
## Set the Timeout value on individual tests  
  
-   Add the Timeout attribute to each test. The parameter is in milliseconds. For example:  
  
    ```  
    [TestMethod(), Timeout(80)]  
    public void MyTestMethod()  
    {  
    // test code  
    }  
    ```  
  
    ```  
    <TestMethod(), Timeout(80)> _  
    Public Sub MyTestMethod()  
    ' test code  
    End Sub  
    ```  
  
     For this test only, the value that you set overrides the per-test time-out value set in the test settings. The test-run time-out value is unaffected.  
  
## See Also  
 [How to: Select the Active Test Settings from Microsoft Visual Studio](../Topic/How%20to:%20Select%20the%20Active%20Test%20Settings%20from%20Microsoft%20Visual%20Studio.md)