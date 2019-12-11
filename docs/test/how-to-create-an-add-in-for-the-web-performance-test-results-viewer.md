---
title: "Create Add-In for Web Performance Test Results Viewer"
ms.date: 10/20/2016
ms.topic: conceptual
helpviewer_keywords:
  - "Web performance tests, Visual Studio Add-in"
  - "Visual Studio Add-in, Web performance tests"
ms.assetid: 1118c604-4b1b-4b21-a04e-45995b676fa8
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create an add-in for the Web Performance Test Results Viewer

You can extend the UI for the **Web Performance Test Results Viewer** by using the following namespaces:

- <xref:Microsoft.VisualStudio.TestTools.LoadTesting>

- <xref:Microsoft.VisualStudio.TestTools.WebTesting>

Additionally, you need to add a reference to LoadTestPackage DLL, which is located in the *%ProgramFiles(x86)%\Microsoft Visual Studio\\\<version>\Enterprise\Common7\IDE\PrivateAssemblies* folder.

To extend the **Web Performance Test Results Viewer**'s UI, you must create a Visual Studio add-in and a user control. The following procedures explain how to create the add-in, the user control, and how to implement the classes necessary to extend the **Web Performance Test Results Viewer**'s UI.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Create or open a solution that contains an ASP.NET web application and a web performance and load test project

### To prepare for extending the Web Performance Test Results Viewer

Either create or open a non-production solution that you can experiment with which contains an ASP.NET web application and a web performance and load test project with one or more web performance tests for the ASP.NET web application.

> [!NOTE]
> You can create an ASP.NET web application and web performance and load test project that contains web performance tests by following the procedures in [How to: Create a web service test](../test/how-to-create-a-web-service-test.md) and [Generate and run a coded web performance test](../test/generate-and-run-a-coded-web-performance-test.md).

## Create a Visual Studio add-in

An add-in is a compiled DLL that runs in the Visual Studio integrated development environment (IDE). Compilation helps protect your intellectual property and improves performance. Although you can create add-ins manually, you may find it easier to use the **Add-In Wizard**. This wizard creates a functional but basic add-in that you can run immediately after you create it. After the **Add-In Wizard** generates the basic program, you can add code to it and customize it.

The **Add-In Wizard** lets you supply a display name and description for your add-in. Both will appear in **Add-In Manager**. Optionally, you can have the wizard generate code that adds to the **Tools** menu a command to open the add-in. You can also choose to display a custom **About** dialog box for your add-in. When the wizard is finished, you have a new project that has just one class  that implements the add-in. That class is named Connect.

You will use the **Add-In Manager** at the end of this article.

### To create an add-in by using the Add-In Wizard

1. In **Solution Explorer**, right-click the solution, choose **Add**, and then select **New Project**.

2. Create a new **Visual Studio Add-in** project.

    The Visual Studio **Add-In Wizard** starts.

3. Choose **Next**.

4. On the **Select a Programming Language** page, select the programming language that you want to use to write the add-in.

   > [!NOTE]
   > This topic uses Visual C# for the sample code.

5. On the **Select An Application Host** page, select **Visual Studio** and clear **Visual Studio Macros**.

6. Choose **Next**.

7. Type a name and description for your add-in on the **Enter a Name and Description** page.

     After the add-in is created, its name and description are displayed in the **Available Add-Ins** list in **Add-In Manager**. Add enough detail to the description of your add-in so that users can learn what your add-in does, how it works, and so on.

8. Choose **Next**.

9. On the **Choose Add-In Options** page, select **I would like my Add-in to load when the host application starts**.

10. Clear the remaining check boxes.

11. On the **Choosing 'Help About' Information** page, you can specify whether you want information about your add-in to be displayed in an **About** dialog box. If you do want the information to be displayed, select the **Yes, I would like my Add-in to offer 'About' box information** check box.

     Information that can be added to the Visual Studio **About** dialog box includes version number, support details, licensing data, and so forth.

12. Choose **Next**.

13. The options that you selected are displayed on the **Summary** page for you to review. If you are satisfied, choose **Finish** to create the add-in. If you want to change something, choose the **Back** button.

     The new solution and project are created and the *Connect.cs* file for the new add-in is displayed in the **Code Editor**.

     You will add code to the *Connect.cs* file after the following procedure, which creates a user control that will be referenced by this WebPerfTestResultsViewerAddin project.

    After an add-in is created, you must register it with Visual Studio before it can be activated in **Add-In Manager**. You do this by using an XML file that has an *.addin* file name extension.

    The *.addin* file describes the information that Visual Studio requires to display the add-in in **Add-In Manager**. When Visual Studio starts, it looks in the *.addin* file location for any available *.addin* files. If it finds any, it reads the XML file and gives **Add-In Manager** the information that it requires to start the add-in when it is clicked.

    The *.addin* file is created automatically when you create an add-in by using the **Add-In Wizard**.

### Add-in file locations

Two copies of the *.addin* files are automatically created by the **Add-In Wizard**, as follows:

|**.Addin File Location**|**Description**|
|-|----------------------------|-|
|Root project folder|Used for deployment of the add-in project. Included in the project for ease of editing and has the local path for XCopy-style deployment.|
|Add-in folder|Used for running the add-in in the debugging environment. Should always point to the output path of the current build configuration.|

## Create a Windows Form Control Library project

The Visual Studio add-in created in the previous procedure references a Windows Forms Control Library project to create an instance of a <xref:System.Windows.Forms.UserControl> class.

### To create a control to be used in the Web Test Results Viewer

1. In **Solution Explorer**, right-click the solution, choose **Add**, and then select **New Project**.

2. Create a new **Windows Forms Control Library** project.

3. From the **Toolbox**, drag a <xref:System.Windows.Forms.DataGridView> onto the surface of userControl1.

4. Click the action tag glyph (![Smart Tag Glyph](../test/media/vs_winformsmttagglyph.gif)) on the upper-right corner of the <xref:System.Windows.Forms.DataGridView> and follow these steps:

    1. Choose **Dock in Parent Container**.

    2. Clear the check boxes for **Enable Adding**, **Enable Editing**, **Enable Deleting** and **Enable Column Reordering**.

    3. Choose **Add Column**.

         The **Add Column** dialog box is displayed.

    4. In the **Type** drop-down list, select **DataGridViewTextBoxColumn**.

    5. Clear the text "Column1" in **Header text**.

    6. Choose **Add**.

    7. Choose **Close**.

5. In the **Properties** window, change the **(Name)** property of the <xref:System.Windows.Forms.DataGridView> to **resultControlDataGridView**.

6. Right-click the design surface and select **View Code**.

     The *UserControl1.cs* file is displayed in the **Code Editor**.

7. Change the name of the instantiated <xref:System.Windows.Forms.UserControl> class from UserContro1 to resultControl:

    ```csharp
    namespace WebPerfTestResultsViewerControl
    {
        public partial class resultControl : UserControl
        {
            public resultControl()
            {
                InitializeComponent();
            }
    ```

     In the next procedure, you will add code to the WebPerfTestResultsViewerAddin project's *Connect.cs* file, which will reference the resultControl class.

     You will be adding some additional code to the *Connect.cs* file later.

## Add code to the WebPerfTestResultsViewerAddin

1. In **Solution Explorer**, right-click the **References** node in the WebPerfTestResultsViewerAddin project and select **Add Reference**.

2. In the **Add Reference** dialog box, choose the **.NET** tab.

3. Scroll down and select **Microsoft.VisualStudio.QualityTools.WebTestFramework** and **System.Windows.Forms**.

4. Choose **OK**.

5. Right-click the **References** node again, and select **Add Reference**.

6. In the **Add Reference** dialog box, choose the **Browse** tab.

7. Choose the drop-down for **Look in** and navigate to *%ProgramFiles(x86)%\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\PrivateAssemblies* and select the *Microsoft.VisualStudio.QualityTools.LoadTestPackage.dll* file.

8. Choose **OK**.

9. Right-click the WebPerfTestResultsViewerAddin project node, and select **Add Reference**.

10. In the **Add Reference** dialog box, choose the **Projects** tab.

11. Under **Project Name**, select the **WebPerfTestResultsViewerControl** project and choose **OK**.

12. If the *Connect.cs* file is not still open, in **Solution Explorer**, right-click the **Connect.cs** file in the WebPerfTestResultsViewerAddin project and select **View Code**.

13. In the *Connect.cs* file, add the following Using statements:

    ```csharp
    using System.IO;
    using System.Windows.Forms;
    using System.Collections.Generic;
    using Microsoft.VisualStudio.TestTools.LoadTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using WebPerfTestResultsViewerControl;
    ```

14. Scroll down to the bottom of the *Connect.cs* file. You need to add a list of GUIDs for the <xref:System.Windows.Forms.UserControl> in case more than one instance of the **Web Performance Test Results Viewer** is open. You will add code later that uses this list.

     A second List of string is used in the OnDiscconection method, which you will code later.

    ```csharp
    private DTE2 _applicationObject;
    private AddIn _addInInstance;

    private Dictionary<Guid, List<UserControl>> m_controls = new Dictionary<Guid, List<UserControl>>();        private List<string> temporaryFilePaths = new List<string>();
    ```

15. The *Connect.cs* file instantiates a class named Connect from the <xref:Extensibility.IDTExtensibility2> class and also includes some methods for implementing the Visual Studio add-in. One of the methods is the OnConnection method, which receives notification that the add-in is being loaded. In the OnConnection method, you will use the LoadTestPackageExt class to create your extensibility package for the **Web Performance Test Results Viewer**. Add the following code to the OnConnection method:

    ```csharp
    public void OnConnection(object application, ext_ConnectMode connectMode, object addInInst, ref Array custom)
                {
                _applicationObject = (DTE2)application;
                _addInInstance = (AddIn)addInInst;

                // Create a load test packge extensibility class.            LoadTestPackageExt loadTestPackageExt = _applicationObject.GetObject("Microsoft.VisualStudio.TestTools.LoadTesting.LoadTestPackageExt") as LoadTestPackageExt;            // Process open windows.            foreach (WebTestResultViewer webTestResultViewer in loadTestPackageExt.WebTestResultViewerExt.ResultWindows)            {                WindowCreated(webTestResultViewer);            }            // Create event handlers.            loadTestPackageExt.WebTestResultViewerExt.WindowCreated += new EventHandler<WebTestResultViewerExt.WindowCreatedEventArgs>(WebTestResultViewerExt_WindowCreated);            loadTestPackageExt.WebTestResultViewerExt.WindowClosed += new EventHandler<WebTestResultViewerExt.WindowClosedEventArgs>(WebTesResultViewer_WindowClosed);            loadTestPackageExt.WebTestResultViewerExt.SelectionChanged += new EventHandler<WebTestResultViewerExt.SelectionChangedEventArgs>(WebTestResultViewer_SelectedChanged);
            }
    ```

16. Add the following code to the connect class to create the WebTestResultViewerExt_WindowCreated method for the loadTestPackageExt.WebTestResultViewerExt.WindowCreated event handler you added in the OnConnection method and for the WindowCreated method that the WebTestResultViewerExt_WindowCreated method calls.

    ```csharp
            void WebTestResultViewerExt_WindowCreated(object sender, WebTestResultViewerExt.WindowCreatedEventArgs e)
            {
                // New control added to new result viewer window.
                WindowCreated(e.WebTestResultViewer);
            }

    private void WindowCreated(WebTestResultViewer viewer)        {            // Instantiate an instance of the resultControl referenced in the WebPerfTestResultsViewerControl project.
                resultControl resultControl = new resultControl();            // Add to the dictionary of open playback windows.            System.Diagnostics.Debug.Assert(!m_controls.ContainsKey(viewer.TestResultId));            List<UserControl> userControls = new List<UserControl>();            userControls.Add(resultControl);            // Add Guid to the m_control List to manage Result viewers and controls.            m_controls.Add(viewer.TestResultId, userControls);            // Add tabs to the playback control.            resultControl.Dock = DockStyle.Fill;            viewer.AddResultPage(new Guid(), "Sample", resultControl);        }
    ```

17. Add the following code to the connect class to create the WebTestResultViewer_SelectedChanged method for the loadTestPackageExt.WebTestResultViewerExt.SelectionChanged event handler you added in the OnConnection method:

    ```csharp
    void WebTestResultViewer_SelectedChanged(object sender, WebTestResultViewerExt.SelectionChangedEventArgs e)
    {
        foreach (UserControl userControl in m_controls[e.TestResultId])            {                // Update the userControl in each result viewer.                resultControl resultControl = userControl as resultControl;                if (resultControl != null)                    // Call the resultControl's Update method (This will be added in the next procedure).                    resultControl.Update(e.WebTestRequestResult);            }
    }
    ```

18. Add the following code to the connect class to create the WebTesResultViewer_WindowClosed method for the event handler for the loadTestPackageExt.WebTestResultViewerExt.WindowClosed you added in the OnConnection method:

    ```csharp
    void WebTesResultViewer_WindowClosed(object sender, WebTestResultViewerExt.WindowClosedEventArgs e)
    {
        if (m_controls.ContainsKey(e.WebTestResultViewer.TestResultId))
        {
            m_controls.Remove(e.WebTestResultViewer.TestResultId);
        }
    }
    ```

     Now that the code has been completed for the Visual Studio add-in, you need to add the Update method to the resultControl in the WebPerfTestResultsViewerControl project.

## Add Code to the WebPerfTestResultsViewerControl

1. In **Solution Explorer**, right-click the WebPerfTestResultsViewerControl project node and select **Properties**.

2. Select the **Application** tab and then choose the **Target framework** drop-down list and select **.NET Framework 4** (or later). Close the **Properties** window.

   This is required in order to support the DLL references that are needed for extending the **Web Performance Test Results Viewer**.

3. In **Solution Explorer**, in the WebPerfTestResultsViewerControl project, right-click the **References** node and select **Add Reference**.

4. In the **Add Reference** dialog box, click the **.NET** tab.

5. Scroll down and select **Microsoft.VisualStudio.QualityTools.WebTestFramework**.

6. Choose **OK**.

7. In the *UserControl1.cs* file, add the following Using statements:

    ```csharp
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    ```

8. Add the Update method that is called and passed a WebTestRequestResult from the WebPerfTestResultsViewerAddin WebTestResultViewer_SelectedChanged method in the *Connect.cs* file. The Update method populates the DataGridView with various properties passed to it in the WebTestRequestResult.

    ```csharp
    public void Update(WebTestRequestResult WebTestResults)
            {
                // Clear the DataGridView when a request is selected.
                resultControlDataGridView.Rows.Clear();
                // Populate the DataGridControl with properties from the WebTestResults.
                this.resultControlDataGridView.Rows.Add("Request: " + WebTestResults.Request.Url.ToString());
                this.resultControlDataGridView.Rows.Add("Response: " + WebTestResults.Response.ResponseUri.ToString());
                foreach (RuleResult ruleResult in WebTestResults.ExtractionRuleResults)
                {
                    this.resultControlDataGridView.Rows.Add("Extraction rule results: " + ruleResult.Message.ToString());
                }
                foreach (RuleResult ruleResult in WebTestResults.ValidationRuleResults)
                {
                    this.resultControlDataGridView.Rows.Add("Validation rule results: " + ruleResult.Message.ToString());
                }
                foreach (WebTestError webTestError in WebTestResults.Errors)
                {
                    this.resultControlDataGridView.Rows.Add("Error: " + webTestError.ErrorType.ToString() + " " + webTestError.ErrorSubtype.ToString() + " " + webTestError.ExceptionText.ToString());
                }
            }
    ```

## Build the solution

- On the **Build** menu, select **Build Solution**.

## Register the WebPerfTestResultsViewerAddin add-in

1. On the **Tools** menu, select **Add-in Manager**.

2. The **Add-in Manager** dialog box is displayed.

3. Select the check box for the WebPerfTestResultsViewerAddin add-in in the **Available Add-ins** column and clear the check boxes underneath the **Startup** and **Command Line** columns.

4. Choose **OK**.

## Run the web performance test using the Web Test Results Viewer

1. Run your web performance test and you will see the WebPerfTestResultsViewerAddin add-in's new tab titled Sample displayed in the **Web Performance Test Results Viewer**.

2. Choose the tab to see the properties presented in the DataGridView.

## .NET security

To improve security by preventing malicious add-ins from automatically activating, Visual Studio provides settings in a **Tools Options** page named **Add-in/Macros Security**.

In addition, this options page allows you to specify the folders in which Visual Studio searches for *.AddIn* registration files. This improves security by allowing you to limit the locations where *.AddIn* registration files can be read. This  helps prevent malicious *.AddIn* files from unintentionally being used.

**Add-In Security Settings**

The settings in the options page for add-in security are as follows:

- **Allow Add-in components to load.** Selected by default. When selected, add-ins are allowed to load in Visual Studio. When not selected, add-ins are prohibited from loading in Visual Studio.

- **Allow Add-in components to load from a URL.** Not selected by default. When selected, add-ins can be loaded from external websites. When not selected, remote add-ins are prohibited from loading in Visual Studio. If an add-in cannot load for some reason, then it cannot be loaded from the Web. This setting controls only the loading the add-in DLL. The *.Addin* registration files must always be located on the local system.

## See also

- <xref:System.Windows.Forms.UserControl>
- <xref:Microsoft.VisualStudio.TestTools.LoadTesting>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules>
- <xref:System.Windows.Forms.UserControl>
- <xref:System.Windows.Forms.DataGrid>
- [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)