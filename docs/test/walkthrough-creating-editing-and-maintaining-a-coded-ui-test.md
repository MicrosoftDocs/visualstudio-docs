---
title: Create a Coded UI Test
description: Learn how to use a coded UI test for a Windows Presentation Framework app and see solutions for tests with timing issues and refactoring of controls.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload:
- multiple
author: mikejo5000
---
# Walkthrough: Create, edit, and maintain a coded UI test

In this walkthrough, you'll learn how to create, edit, and maintain a coded UI test to test a Windows Presentation Framework (WPF) app. The walkthrough provides solutions for correcting tests that have been broken by various timing issues and refactoring of controls.

[!INCLUDE [coded-ui-test-deprecation](includes/coded-ui-test-deprecation.md)]

## Create a WPF app

1. Create a new **WPF App (.NET Framework)** project and name it **SimpleWPFApp**.

     The **WPF Designer** opens and displays MainWindow of the project.

2. If the toolbox is not currently open, open it. Choose the **View** menu, and then choose **Toolbox**.

3. Under the **All WPF Controls** section, drag a **Button**, **CheckBox** and **ProgressBar** control onto the MainWindow in the design surface.

4. Select the **Button** control. In the **Properties** window, change the value for the **Name** property from \<No Name> to button1. Then change the value for the **Content** property from Button to Start.

5. Select the **ProgressBar** control. In the **Properties** window, change the value for the **Name** property from \<No Name> to progressBar1. Then change the value for the **Maximum** property from **100** to **10000**.

6. Select the **Checkbox** control. In the **Properties** window, change the value for the **Name** property from \<No Name> to checkBox1 and clear the **IsEnabled** property.

     ![Simple WPF Application](../test/media/codedui_wpfapp.png)

7. Double-click the button control to add a click event handler.

     The *MainWindow.xmal.cs* is displayed in the Code Editor with the cursor in the new button1_Click method.

8. At the top of the MainWindow class, add a delegate. The delegate will be used for the progress bar. To add the delegate, add the following code:

    ```csharp
    public partial class MainWindow : Window
    {
            private delegate void ProgressBarDelegate(System.Windows.DependencyProperty dp, Object value);

        public MainWindow()
        {

            InitializeComponent();
        }
    ```

9. In the button1_Click method, add the following code:

    ```csharp
    private void button1_Click(object sender, RoutedEventArgs e)
    {
        double progress = 0;

        ProgressBarDelegate updatePbDelegate =
            new ProgressBarDelegate(progressBar1.SetValue);

        do
        {
            progress ++;

            Dispatcher.Invoke(updatePbDelegate,
                System.Windows.Threading.DispatcherPriority.Background,
                new object[] { ProgressBar.ValueProperty, progress });
            progressBar1.Value = progress;
        }
        while (progressBar1.Value != progressBar1.Maximum);

        checkBox1.IsEnabled = true;
    }
    ```

10. Save the file.

### Run the WPF app

1. On the **Debug** menu, select **Start Debugging** or press **F5**.

2. Notice that the check box control is disabled. Choose **Start**.

     In a few seconds, the progress bar should be 100% complete.

3. You can now select the check box control.

4. Close SimpleWPFApp.

## Create a shortcut to the WPF app

1. Locate the SimpleWPFApp application that you created earlier.

2. Create a desktop shortcut to the SimpleWPFApp application. Right-click *SimpleWPFApp.exe* and choose **Copy**. On your desktop, right-click and choose **Paste shortcut**.

    > [!TIP]
    > A shortcut to the application makes it easier to add or modify coded UI tests for your application because it lets you start the application quickly.

## Create a coded UI test for SimpleWPFApp

1. In **Solution Explorer**, right-click the solution and choose **Add** > **New Project**.

2. Search for and select the **Coded UI Test Project** project template, and continue through the steps until the project is created.

   > [!NOTE]
   > If you don't see the **Coded UI Test Project** template, you need to [install the coded UI test component](../test/use-ui-automation-to-test-your-code.md#install-the-coded-ui-test-component).

     The new coded UI test project named **CodedUITestProject1** is added to your solution and the **Generate Code for Coded UI Test** dialog box appears.

1. Select the **Record actions, edit UI map or add assertions** option and choose **OK**.

     The **UIMap - Coded UI Test Builder** dialog appears, and the Visual Studio window is minimized.

     For more information about the options in the dialog box, see [Create coded UI tests](../test/use-ui-automation-to-test-your-code.md).

1. Choose **Start Recording** on the **UIMap - Coded UI Test Builder** dialog.

     ![Start recording](../test/media/cuit_builder_record.png)

     You can pause the recording if needed, for example if you have to deal with incoming mail.

     ![Pause the recording](../test/media/cuit_.png)

    > [!WARNING]
    > All actions performed on the desktop will be recorded. Pause the recording if you are performing actions that may lead to sensitive data being included in the recording.

1. Launch the SimpleWPFApp using the desktop shortcut.

     As before, notice that the check box control is disabled.

1. On the SimpleWPFApp, choose **Start**.

     In a few seconds, the progress bar should be 100% complete.

1. Check the check box control which is now enabled.

1. Close the SimpleWPFApp application.

1. On the **UIMap - Coded UI Test Builder** dialog, choose **Generate Code**.

1. In the **Method Name** box, type **SimpleAppTest** and choose **Add and Generate**. In a few seconds, the coded UI test appears and is added to the solution.

1. Close **UIMap - Coded UI Test Builder**.

     The *CodedUITest1.cs* file appears in the code editor.

1. Save your project.

### Run the test

1. From the **Test** menu, choose **Windows** and then choose **Test Explorer**.

2. From the **Build** menu, choose **Build Solution**.

3. In the *CodedUITest1.cs* file, locate the **CodedUITestMethod** method, right-click and select **Run Tests**, or run the test from **Test Explorer**.

   While the coded UI test runs, the SimpleWPFApp is visible. It conducts the steps that you did in the previous procedure. However, when the test tries to select the check box for the check box control, the **Test Results** window shows that the test failed. This is because the test tries to select the check box but is not aware that the check box control is disabled until the progress bar is 100% complete. You can correct this and similar issues by using the various `UITestControl.WaitForControlXXX()` methods that are available for coded UI testing. The next procedure will demonstrate using the `WaitForControlEnabled()` method to correct the issue that caused this test to fail. For more information, see [Make coded UI tests wait for specific events during playback](../test/making-coded-ui-tests-wait-for-specific-events-during-playback.md).

## Edit and rerun the coded UI test

1. In the **Test Explorer** window, select the failed test and in the **StackTrace** section, choose the first link to **UIMap.SimpleAppTest()**.

2. The *UIMap.Designer.cs* file opens with the point of error highlighted in the code:

    ```csharp
    // Select 'CheckBox' check box
    uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;
    ```

3. To correct this problem, you can make the coded UI test wait for the CheckBox control to be enabled before continuing on to this line using the `WaitForControlEnabled()` method.

    > [!WARNING]
    > Do not modify the *UIMap.Designer.cs* file. Any code changes you make will be overwritten every time you generate code using **UIMap - Coded UI Test Builder**. If you have to modify a recorded method, copy it to the *UIMap.cs* file and rename it. The *UIMap.cs* file can be used to override methods and properties in the *UIMapDesigner.cs* file. You must remove the reference to the original method in the *CodedUITest.cs* file and replace it with the renamed method name.

4. In **Solution Explorer**, locate *UIMap.uitest* in your coded UI test project.

5. Open the shortcut menu for *UIMap.uitest* and choose **Open**.

     The coded UI test is displayed in the Coded UI Test Editor. You can now view and edit the coded UI test.

6. In the **UI Action** pane, select the test method (SimpleAppTest) that you want to move to the *UIMap.cs* or *UIMap.vb* file. Moving the method to a different file allows custom code to be added that won't be overwritten when the test code is recompiled.

7. Choose the **Move Code** button on the **Coded UI Test Editor** toolbar.

8. A Microsoft Visual Studio dialog box is displayed. It warns you that the method will be moved from the *UIMap.uitest* file to the *UIMap.cs* file, and that you'll no longer be able to edit the method using the Coded UI Test Editor. Choose **Yes**.

     The test method is removed from the *UIMap.uitest* file and no longer is displayed in the UI Actions pane. To edit the moved test file, open the *UIMap.cs* file from **Solution Explorer**.

9. On the Visual Studio toolbar, choose **Save**.

     The updates to the test method are saved in the *UIMap.Designer* file.

    > [!WARNING]
    > Once you have moved the method, you can no longer edit it using the Coded UI Test Editor. You must add your custom code and maintain it using the Code Editor.

10. Rename the method from `SimpleAppTest()` to `ModifiedSimpleAppTest()`

11. Add the following using statement to the file:

    ```csharp
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    ```

12. Add the following `WaitForControlEnabled()` method before the offending line of code identified previously:

    ```csharp
    uICheckBoxCheckBox.WaitForControlEnabled();

    // Select 'CheckBox' check box
    uICheckBoxCheckBox.Checked = this.SimpleAppTestParams.UICheckBoxCheckBoxChecked;
    ```

13. In the *CodedUITest1.cs* file, locate the **CodedUITestMethod** method and either comment out or rename the reference to the original SimpleAppTest() method and then replace it with the new ModifiedSimpleAppTest():

    ```csharp
    [TestMethod]
            public void CodedUITestMethod1()
            {
                // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
                // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
                //this.UIMap.SimpleAppTest();
                this.UIMap.ModifiedSimpleAppTest();
            }
    ```

14. On the **Build** menu, choose **Build Solution**.

15. Right-click the **CodedUITestMethod** method and select **Run Tests**.

16. This time the coded UI test successfully completes all the steps in the test, and **Passed** is displayed in the **Test Explorer** window.

## Refactor a control in SimpleWPFApp

1. In the *MainWindow.xaml* file, in the designer, select the button control.

2. At the top of the **Properties** window, change the **Name** property value from **button1** to **buttonA**.

3. On the **Build** menu, choose **Build Solution**.

4. In **Test Explorer**, run **CodedUITestMethod1**.

     The test fails because the coded UI test cannot locate the button control that was originally mapped in the UIMap as button1. Refactoring can impact coded UI tests in this manner.

5. In **Test Explorer**, in the **StackTrace** section, choose the first link next to **UIMpa.ModifiedSimpleAppTest()**.

     The *UIMap.cs* file opens. The point of error is highlighted in the code:

    ```csharp
    // Click 'Start' button
    Mouse.Click(uIStartButton, new Point(27, 10));
    ```

     Notice that the line of code earlier in this procedure is using `UiStartButton`, which is the UIMap name before it was refactored.

     To correct the issue, you can add the refactored control to the UIMap by using the **Coded UI Test Builder**. You can update the test's code to use the code, as demonstrated in the next procedure.

## Map refactored control rerun the test

1. In the *CodedUITest1.cs* file, in the **CodedUITestMethod1()** method, right-click, select **Generate Code for Coded UI Test** and then choose **Use Coded UI Test Builder**.

     The **UIMap - Coded UI Test Builder** appears.

2. Using the desktop shortcut you created earlier, run the SimpleWPFApp application that you created earlier.

3. On the **UIMap - Coded UI Test Builder** dialog, drag the crosshair tool to the **Start** button on SimpleWPFApp.

     The **Start** button is enclosed in a blue box. **Coded UI Test Builder** takes a few seconds to process the data for the selected control and display the control's properties. Notice that the value of **AutomationUId** is **buttonA**.

4. In the properties for the control, choose the arrow at the upper-left corner to expand the UI Control Map. Notice that **UIStartButton1** is selected.

5. In the toolbar, choose the **Add control to UI Control Map**.

     The status at the bottom of the window verifies the action by displaying **Selected control has been added to the UI control map**.

6. On the **UIMap - Coded UI Test Builder** dialog, choose **Generate Code**.

     The **Coded UI Test Builder - Generate Code** dialog appears with a note indicating that no new method is required, and that code will only be generated for the changes to the UI control map.

7. Choose **Generate**.

8. Close SimpleWPFApp.

9. Close **UIMap - Coded UI Test Builder**.

10. In **Solution Explorer**, open the *UIMap.Designer.cs* file.

11. In the *UIMap.Designer.cs* file, locate the **UIStartButton1** property. Notice the `SearchProperties` is set to `"buttonA"`:

    ```csharp
    public WpfButton UIStartButton1
            {
                get
                {
                    if ((this.mUIStartButton1 == null))
                    {
                        this.mUIStartButton1 = new WpfButton(this);
                        #region Search Criteria
                        this.mUIStartButton1.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
                        this.mUIStartButton1.WindowTitles.Add("MainWindow");
                        #endregion
                    }
                    return this.mUIStartButton1;
                }
            }
    ```

     Now you can modify the coded UI test to use the newly mapped control. As pointed out in the previous procedure if you want to override any methods or properties in the coded UI test, you must do so in the *UIMap.cs* file.

12. In the *UIMap.cs* file, add a constructor and specify the `SearchProperties` property of the `UIStartButton` property to use the `AutomationID` property with a value of `"buttonA":`

    ```csharp
    public UIMap()
            {
                this.UIMainWindowWindow.UIStartButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "buttonA";
            }
    ```

13. On the **Build** menu, choose **Build Solution**.

14. In **Test Explorer**, run **CodedUITestMethod1**.

     This time, the coded UI test successfully completes all the steps in the test. In the **Test Results** window, you see a status of **Passed**.

## Videos

![link to video](../data-tools/media/playvideo.gif) [Get started with coded UI tests](https://onedrive.live.com/?id=2DB0E1EFE1C1D3B8%21110&cid=2DB0E1EFE1C1D3B8)

## FAQ

[Coded UI tests FAQ](https://social.msdn.microsoft.com/Forums/vsautotest/3a74dd2c-cef8-4923-abbf-7a91f489e6c4/faqs)

## See also

- [Use UI automation to test your code](../test/use-ui-automation-to-test-your-code.md)
- [Supported configurations and platforms for coded UI tests and action recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)
- [Edit coded UI tests using the coded UI test editor](../test/editing-coded-ui-tests-using-the-coded-ui-test-editor.md)
