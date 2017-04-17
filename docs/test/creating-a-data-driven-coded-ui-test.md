---
title: "Creating a Data-Driven Coded UI Test | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "coded UI tests, data-driven"
ms.assetid: 5838f02d-001f-49ce-adce-c9ea1afaec2f
caps.latest.revision: 56
ms.author: "douge"
manager: "douge"
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
# Creating a Data-Driven Coded UI Test
To test different conditions, you can run your tests multiple times with different parameter values. Data-driven coded UI tests are a convenient way to do this. You define parameter values in a data source, and each row in the data source is an iteration of the coded UI test. The overall result of the test will be based on the outcome for all the iterations. For example, if one test iteration fails, the overall test result is failure.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
## Create a data-driven coded UI test  
 This sample creates a coded UI test that runs on the Windows Calculator application. It adds two numbers together and uses an assertion to validate that the sum is correct. Next, the assertion and the parameter values for the two numbers are coded to become data-driven and stored in a comma-separated value (.csv) file.  
  
#### Step 1 - Create a coded UI test  
  
1.  Create a project.  
  
     ![Create a coded UI test project](../test/media/cuit_datadriven_.png "CUIT_dataDriven_")  
  
2.  Choose to record the actions.  
  
     ![Choose to record the actions](../test/media/cuit_datadriven_generatecodedialog.png "CUIT_dataDriven_GenerateCodeDialog")  
  
3.  Open the calculator app and start recording the test.  
  
     ![Record actions](../test/media/cuit_datadriven_cuitbuilder.png "CUIT_dataDriven_CUITBuilder")  
  
4.  Add 1 plus 2, pause the recorder, and generate the test method. Later we’ll replace the values of this user input with values from a data file.  
  
     ![Genetate test method](../test/media/cuit_datadriven_cuitbuildergencode.png "CUIT_dataDriven_CUITBuilderGenCode")  
  
     Close the test builder. The method is added to the test:  
  
    ```c#  
    [TestMethod]  
    public void CodedUITestMethod1()  
    {  
        // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.  
        this.UIMap.AddNumbers();  
  
    }  
    ```  
  
5.  Use the `AddNumbers()` method to verify that the test runs. Place the cursor in the test method shown above, open the context menu, and choose **Run Tests**. (Keyboard shortcut: Ctrl + R, T).  
  
     The test result that shows if the test passed or failed is displayed in the Test Explorer window. To open the Test Explorer window, from the **TEST** menu, choose **Windows** and then choose **Test Explorer**.  
  
6.  Because a data source can also be used for assertion parameter values—which are used by the test to verify expected values—let’s add an assertion to validate that the sum of the two numbers is correct. Place the cursor in the test method shown above, open the context menu and choose **Generate Code for Coded UI Test**, and then **Use Coded UI Test Builder**.  
  
     Map the text control in the calculator that displays the sum.  
  
     ![Map the UI text control](../test/media/cuit_datadriven_addassertion.png "CUIT_dataDriven_AddAssertion")  
  
7.  Add an assertion that validates that the value of the sum is correct. Choose the **DisplayText** property that has the value of **3** and then choose **Add Assertion**. Use the **AreEqual** comparator and verify that the comparison value is **3**.  
  
     ![Configure the assertion](../test/media/cuit_datadriven_builderaddassertion2.png "CUIT_dataDriven_BuilderAddAssertion2")  
  
8.  After configuring the assertion, generate code from the builder again. This creates a new method for the validation.  
  
     ![Generate the assertion method](../test/media/cuit_datadriven_assertiongencode.png "CUIT_dataDriven_AssertionGenCode")  
  
     Because the `ValidateSum` method validates the results of the `AddNumbers` method, move it to the bottom of the code block.  
  
    ```c#  
    public void CodedUITestMethod1()  
    {  
  
        // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.  
        this.UIMap.AddNumbers();  
        this.UIMap.ValidateSum();  
  
    }  
    ```  
  
9. Verify that the test runs by using the `ValidateSum()` method. Place the cursor in the test method shown above, open the context menu, and choose **Run Tests**. (Keyboard shortcut:Ctrl + R, T).  
  
     At this point, all the parameter values are defined in their methods as constants. Next, let’s create a data set to make our test data-driven.  
  
#### Step 2 - Create a data set  
  
1.  Add a text file to the dataDrivenSample project named `data.csv`.  
  
     ![Add a comma seperated value file to the project](../test/media/cuit_datadriven_addcsvfile.png "CUIT_dataDriven_AddCSVFile")  
  
2.  Populate the .csv file with the following data:  
  
    |Num1|Num2|Sum|  
    |----------|----------|---------|  
    |3|4|7|  
    |5|6|11|  
    |6|8|14|  
  
     After adding the data, the file should appear as the following:  
  
     ![Populate the .CSV file with data](../test/media/cuit_datadriven_adddatatocsvfile.png "CUIT_dataDriven_AddDataToCSVFile")  
  
3.  It is important to save the .csv file using the correct encoding. On the **FILE** menu, choose **Advanced Save Options** and choose **Unicode (UTF-8 without signature) – Codepage 65001** as the encoding.  
  
4.  The .csv file, must be copied to the output directory, or the test can’t run. Use the Properties window to copy it.  
  
     ![Deploy the .CSV file](../test/media/cuit_datadriven_deploycsvfile.png "CUIT_dataDriven_DeployCSVFile")  
  
     Now that we have the data set created, let’s bind the data to the test.  
  
#### Step 3 – Add data source binding  
  
1.  To bind the data source, add a `DataSource` attribute within the existing `[TestMethod]` attribute that is immediately above the test method.  
  
    ```  
    [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]  
    public void CodedUITestMethod1()  
    {  
  
        // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.  
        this.UIMap.AddNumbers();  
        this.UIMap.ValidateSum();  
  
    }  
  
    ```  
  
     The data source is now available for you to use in this test method.  
  
    > [!TIP]
    >  See [data source attribute samples](#CreateDataDrivenCUIT_QA_DataSourceAttributes) in the Q & A section for samples of using other data source types such as XML, SQL Express and Excel.  
  
2.  Run the test.  
  
     Notice that the test runs through three iterations. This is because the data source that was bound contains three rows of data. However, you will also notice that the test is still using the constant parameter values and is adding 1 + 2 with a sum of 3 each time.  
  
     Next, we’ll configure the test to use the values in the data source file.  
  
#### Step 4 – Use the data in the coded UI test  
  
1.  Add `using Microsoft.VisualStudio.TestTools.UITesting.WinControls` to the top of the CodedUITest.cs file:  
  
    ```  
    using System;  
    using System.Collections.Generic;  
    using System.Text.RegularExpressions;  
    using System.Windows.Input;  
    using System.Windows.Forms;  
    using System.Drawing;  
    using Microsoft.VisualStudio.TestTools.UITesting;  
    using Microsoft.VisualStudio.TestTools.UnitTesting;  
    using Microsoft.VisualStudio.TestTools.UITest.Extension;  
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;  
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;  
    ```  
  
2.  Add `TestContext.DataRow[]` in the `CodedUITestMethod1()` method which will apply values from the data source. The data source values override the constants assigned to UIMap controls by using the controls `SearchProperties`:  
  
    ```  
    public void CodedUITestMethod1()  
    {  
  
        // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.  
        this.UIMap.UICalculatorWindow.UIItemWindow.UIItem1Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num1"].ToString();this.UIMap.UICalculatorWindow.UIItemWindow21.UIItem2Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num2"].ToString();  
        this.UIMap.AddNumbers();  
        this.UIMap.ValidateSumExpectedValues.UIItem2TextDisplayText = TestContext.DataRow["Sum"].ToString();  
        this.UIMap.ValidateSum();  
  
    }  
    ```  
  
     To figure out which search properties to code the data to, use the Coded UI Test Editor.  
  
    -   Open the UIMap.uitest file.  
  
         ![Open the Coded UI Test Editor](../test/media/cuit_datadriven_opentesteditor.png "CUIT_dataDriven_OpenTestEditor")  
  
    -   Choose the UI action and observe the corresponding UI control mapping. Notice how the mapping corresponds to the code, for example, `this.UIMap.UICalculatorWindow.UIItemWindow.UIItem1Button`.  
  
         ![Use the Coded UI Test Editor to assist with code](../test/media/cuit_datadriven_testeditor.png "CUIT_dataDriven_TestEditor")  
  
    -   In the Properties Window, open **Search Properties**. The search properties **Name** value is what is being manipulated in the code using the data source. For example, the `SearchProperties` is being assigned the values in the first column of each data row: `UIItem1Button.SearchProperties[WinButton.PropertyNames.Name] = TestContext.DataRow["Num1"].ToString();`. For the three iterations, this test will change the **Name** value for the search property to 3, then 5, and finally 6.  
  
         ![Use the search properties to assist in coding](../test/media/cuit_datadriven_searchproperties.png "CUIT_dataDriven_SearchProperties")  
  
3.  Save the solution.  
  
#### Step 5 – Run the data-driven test  
  
1.  Verify that the test is now data-driven by running the test again.  
  
     You should see the test run through the three iterations using the values in the .csv file. The validation should work as well and the test should display as passed in the Test Explorer.  
  
 **Guidance**  
  
 For additional information, see [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 2: Unit Testing: Testing the Inside](http://go.microsoft.com/fwlink/?LinkID=255188) and [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 5: Automating System Tests](http://go.microsoft.com/fwlink/?LinkID=255196)  
  
## Q & A  
  
###  <a name="CreateDataDrivenCUIT_QA_DataSourceAttributes"></a> What are the data source attributes for other data source types, such as SQL Express or XML?  
 You can use the sample data source strings in the table below by copying them to your code and making the necessary customizations.  
  
 **Data Source Types and Attributes**  
  
-   CSV  
  
     `[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV", "|DataDirectory|\\data.csv", "data#csv", DataAccessMethod.Sequential), DeploymentItem("data.csv"), TestMethod]`  
  
-   Excel  
  
     `DataSource("System.Data.Odbc", "Dsn=ExcelFiles;Driver={Microsoft Excel Driver (*.xls)};dbq=|DataDirectory|\\Data.xls;defaultdir=.;driverid=790;maxbuffersize=2048;pagetimeout=5;readonly=true", "Sheet1$", DataAccessMethod.Sequential), DeploymentItem("Sheet1.xls"), TestMethod]`  
  
-   Test case in Team Foundation Server  
  
     `[DataSource("Microsoft.VisualStudio.TestTools.DataSource.TestCase", "http://vlm13261329:8080/tfs/DefaultCollection;Agile", "30", DataAccessMethod.Sequential), TestMethod]`  
  
-   XML  
  
     `[DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\data.xml", "Iterations", DataAccessMethod.Sequential), DeploymentItem("data.xml"), TestMethod]`  
  
-   SQL Express  
  
     `[DataSource("System.Data.SqlClient", "Data Source=.\\sqlexpress;Initial Catalog=tempdb;Integrated Security=True", "Data", DataAccessMethod.Sequential), TestMethod]`  
  
### Q: Can I use data-driven tests on my Windows Phone app?  
 **A:** Yes. Data-driven Coded UI tests for Windows Phone are defined using the DataRow attribute on a test method. In the following example, x and y use the values of 1 and 2 for the first iteration and -1 and -2 for the second iteration of the test.  
  
```  
[DataRow(1, 2, DisplayName = "Add positive numbers")]  
[DataRow(-1, -2, DisplayName = "Add negative numbers")]  
[TestMethod]  
public void DataDrivingDemo_MyTestMethod(int x, int y)  
  
```  
  
 For more information, see [Use Data-driven coded UI tests on Windows Phone apps](../test/test-windows-phone-8-1-apps-with-coded-ui-tests.md#TestingPhoneAppsCodedUI_DataDriven).  
  
### Q: Why can’t I modify the code in the UIMap.Designer file?  
 **A:** Any code changes you make in the UIMapDesigner.cs file will be overwritten every time you generate code using the UIMap - Coded UI Test Builder. In this sample, and in most cases, the code changes needed to enable a test to use a data source can be made to the test's source code file (that is, CodedUITest1.cs).  
  
 If you have to modify a recorded method, you must copy it to UIMap.cs file and rename it. The UIMap.cs file can be used to override methods and properties in the UIMapDesigner.cs file. You must remove the reference to the original method in the Coded UITest.cs file and replace it with the renamed method name.  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap>   
 <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert>   
 [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)   
 [Creating Coded UI Tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate)   
 [Best Practices for Coded UI Tests](../test/best-practices-for-coded-ui-tests.md)   
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)
