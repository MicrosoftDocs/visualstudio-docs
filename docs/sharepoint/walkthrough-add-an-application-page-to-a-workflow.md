---
title: "Walkthrough: Add an Application Page to a Workflow | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, adding applications page to workflow"
  - "application page [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Add an application page to a workflow
  This walkthrough demonstrates how to add an application page that displays data derived from a workflow to a workflow project. It builds on the project described in the topic [Walkthrough: Create a workflow with association and initiation forms](../sharepoint/walkthrough-creating-a-workflow-with-association-and-initiation-forms.md).

 This walkthrough demonstrates the following tasks:

- Adding an ASPX application page to a SharePoint workflow project.

- Obtaining data from the workflow project and manipulating it.

- Displaying data in a table on the application page.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)] and SharePoint.

- Visual Studio.

- You also have to complete the project in the topic [Walkthrough: Create a workflow with association and initiation forms](../sharepoint/walkthrough-creating-a-workflow-with-association-and-initiation-forms.md).

## Ammend the workflow code
 First, add a line of code to the workflow to set the value of the Outcome column to the amount of the expense report. This value is used later in the expense report summary calculation.

#### To set the value of the outcome column in the workflow

1. Load the completed project from the topic [Walkthrough: Creating a Workflow with Association and Initiation Forms](../sharepoint/walkthrough-creating-a-workflow-with-association-and-initiation-forms.md) into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

2. Open the code for *Workflow1.cs* or *Workflow1.vb* (depending on your programming language).

3. To the bottom of the `createTask1_MethodInvoking` method, add the following code:

    ```vb
    createTask1_TaskProperties1.ExtendedProperties("Outcome") =
      workflowProperties.InitiationData
    ```

    ```csharp
    createTask1_TaskProperties1.ExtendedProperties["Outcome"] =
      workflowProperties.InitiationData;
    ```

## Create an application page
 Next, add an ASPX form to the project. This form will display data obtained from the expense report workflow project. To do this, you will add an application page. An application page uses the same master page as other SharePoint pages, meaning that it will resemble other pages on the SharePoint site.

#### To add an application page to the project

1. Choose the ExpenseReport project, and then, on the menu bar, choose **Project** > **Add New Item**.

2. In the **Templates** pane, choose the **Application Page** template, use the default name for the project item (**ApplicationPage1.aspx**), and choose the **Add** button.

3. In the [!INCLUDE[TLA2#tla_xml](../sharepoint/includes/tla2sharptla-xml-md.md)] of ApplicationPage1.aspx, replace the `PlaceHolderMain` section with the following:

    ```aspx-csharp
    <asp:Content ID="Main" ContentPlaceHolderID="PlaceHolderMain" runat="server">
        <asp:Label ID="Label1" runat="server" Font-Bold="True"
            Text="Expenses that exceeded allotted amount" Font-Size="Medium"></asp:Label>
        <br />
        <asp:Table ID="Table1" runat="server">
        </asp:Table>
    </asp:Content>
    ```

     This code adds a table to the page together with a title.

4. Add a title to the application page by replacing the `PlaceHolderPageTitleInTitleArea` section with the following:

    ```aspx-csharp
    <asp:Content ID="PageTitleInTitleArea" ContentPlaceHolderID="PlaceHolderPageTitleInTitleArea" runat="server" >
        Expense Report Summary
    </asp:Content>
    ```

## Code the application page
 Next, add code to the expense report summary application page. When you open the page, the code scans the Task list in SharePoint for expenses that exceeded the allocated spending limit. The report lists each item together with the sum of the expenses.

#### To code the application page

1. Choose the **ApplicationPage1.aspx** node, and then, on the menu bar, choose **View** > **Code** to display the code behind the application page.

2. Replace the **using** or **Import** statements (depending on your programming language) at the top of the class with the following:

    ```vb
    Imports System
    Imports Microsoft.SharePoint
    Imports Microsoft.SharePoint.WebControls
    Imports System.Collections
    Imports System.Data
    Imports System.Web.UI
    Imports System.Web.UI.WebControls
    Imports System.Web.UI.WebControls.WebParts
    Imports System.Drawing
    Imports Microsoft.SharePoint.Navigation
    ```

    ```csharp
    using System;
    using Microsoft.SharePoint;
    using Microsoft.SharePoint.WebControls;
    using System.Collections;
    using System.Data;
    using System.Web.UI;
    using System.Web.UI.WebControls;
    using System.Web.UI.WebControls.WebParts;
    using System.Drawing;
    using Microsoft.SharePoint.Navigation;
    ```

3. Add the following code to the `Page_Load` method:

    ```vb
    Try
        ' Reference the Tasks list on the SharePoint site.
        ' Replace "TestServer" with a valid SharePoint server name.
        Dim site As SPSite = New SPSite("http://TestServer")
        Dim list As SPList = site.AllWebs(0).Lists("Tasks")
        ' string text = "";
        Dim sum As Integer = 0
        Table1.Rows.Clear()
        ' Add table headers.
        Dim hr As TableHeaderRow = New TableHeaderRow
        hr.BackColor = Color.LightBlue
        Dim hc1 As TableHeaderCell = New TableHeaderCell
        Dim hc2 As TableHeaderCell = New TableHeaderCell
        hc1.Text = "Expense Report Name"
        hc2.Text = "Amount Exceeded"
        hr.Cells.Add(hc1)
        hr.Cells.Add(hc2)
        ' Add the TableHeaderRow as the first item
        ' in the Rows collection of the table.
        Table1.Rows.AddAt(0, hr)
        ' Iterate through the tasks in the Task list and collect those
        ' that have values in the "Related Content" and "Outcome" fields
        ' - the fields written to when expense approval is required.
        For Each item As SPListItem In list.Items
            Dim s_relContent As String = ""
            Dim s_outcome As String = ""
            Try
                ' Task has the fields - treat as expense report.
                s_relContent = item.GetFormattedValue("Related Content")
                s_outcome = item.GetFormattedValue("Outcome")
            Catch erx As System.Exception
                ' Task does not have fields - skip it.
                Continue For
            End Try
            ' Convert amount to an int and keep a running total.
            If (Not String.IsNullOrEmpty(s_relContent) And Not
              String.IsNullOrEmpty(s_outcome)) Then
                sum = (sum + Convert.ToInt32(s_outcome))
                Dim relContent As TableCell = New TableCell
                relContent.Text = s_relContent
                Dim outcome As TableCell = New TableCell
                outcome.Text = ("$" + s_outcome)
                Dim dataRow2 As TableRow = New TableRow
                dataRow2.Cells.Add(relContent)
                dataRow2.Cells.Add(outcome)
                Table1.Rows.Add(dataRow2)
            End If
        Next
        ' Report the sum of the reports in the table footer.
        Dim tfr As TableFooterRow = New TableFooterRow
        tfr.BackColor = Color.LightGreen
        ' Create a TableCell object to contain the
        ' text for the footer.
        Dim ftc1 As TableCell = New TableCell
        Dim ftc2 As TableCell = New TableCell
        ftc1.Text = "TOTAL: "
        ftc2.Text = ("$" + Convert.ToString(sum))
        ' Add the TableCell object to the Cells
        ' collection of the TableFooterRow.
        tfr.Cells.Add(ftc1)
        tfr.Cells.Add(ftc2)
        ' Add the TableFooterRow to the Rows
        ' collection of the table.
        Table1.Rows.Add(tfr)
    Catch errx As Exception
        System.Diagnostics.Debug.WriteLine(("Error: " + errx.ToString))
    End Try
    ```

    ```csharp
    try
    {
        // Reference the Tasks list on the SharePoint site.
        // Replace "TestServer" with a valid SharePoint server name.
        SPSite site = new SPSite("http://TestServer");
        SPList list = site.AllWebs[0].Lists["Tasks"];

        // string text = "";
        int sum = 0;

        Table1.Rows.Clear();

        // Add table headers.
        TableHeaderRow hr = new TableHeaderRow();
        hr.BackColor = Color.LightBlue;
        TableHeaderCell hc1 = new TableHeaderCell();
        TableHeaderCell hc2 = new TableHeaderCell();
        hc1.Text = "Expense Report Name";
        hc2.Text = "Amount Exceeded";
        hr.Cells.Add(hc1);
        hr.Cells.Add(hc2);
        // Add the TableHeaderRow as the first item
        // in the Rows collection of the table.
        Table1.Rows.AddAt(0, hr);

        // Iterate through the tasks in the Task list and collect those
        // that have values in the "Related Content" and "Outcome"
        // fields - the fields written to when expense approval is
        // required.
        foreach (SPListItem item in list.Items)
        {
            string s_relContent = "";
            string s_outcome = "";

            try
            {
                // Task has the fields - treat as expense report.
                s_relContent = item.GetFormattedValue("Related
                  Content");
                s_outcome = item.GetFormattedValue("Outcome");
            }
            catch
            {
                // Task does not have fields - skip it.
                continue;
            }

            if (!String.IsNullOrEmpty(s_relContent) &&
              !String.IsNullOrEmpty(s_outcome))
            {
                // Convert amount to an int and keep a running total.
                sum += Convert.ToInt32(s_outcome);
                TableCell relContent = new TableCell();
                relContent.Text = s_relContent;
                TableCell outcome = new TableCell();
                outcome.Text = "$" + s_outcome;
                TableRow dataRow2 = new TableRow();
                dataRow2.Cells.Add(relContent);
                dataRow2.Cells.Add(outcome);
                Table1.Rows.Add(dataRow2);
            }
        }

        // Report the sum of the reports in the table footer.
           TableFooterRow tfr = new TableFooterRow();
        tfr.BackColor = Color.LightGreen;

        // Create a TableCell object to contain the
        // text for the footer.
        TableCell ftc1 = new TableCell();
        TableCell ftc2 = new TableCell();
        ftc1.Text = "TOTAL: ";
        ftc2.Text = "$" + Convert.ToString(sum);

        // Add the TableCell object to the Cells
        // collection of the TableFooterRow.
        tfr.Cells.Add(ftc1);
        tfr.Cells.Add(ftc2);

        // Add the TableFooterRow to the Rows
        // collection of the table.
        Table1.Rows.Add(tfr);
    }

    catch (Exception errx)
    {
        System.Diagnostics.Debug.WriteLine("Error: " + errx.ToString());
    }
    ```

    > [!WARNING]
    > Be sure to replace "TestServer" in the code with the name of a valid server that's running SharePoint.

## Test the application page
 Next, determine whether the application page displays the expense data correctly.

#### To test the application page

1. Choose the **F5** key to run and deploy the project to SharePoint.

2. Choose the **Home** button, and then choose the **Shared Documents** link on the QuickLaunch bar to display the Shared Documents list on the SharePoint site.

3. To represent expense reports for this example, upload some new documents into the Documents list by choosing the **Documents** link on the **LibraryTools** tab at the top of the page and then choosing the **Upload Document** button on the tool ribbon.

4. After you upload some documents, instantiate the workflow by choosing the **Library** link on the **LibraryTools** tab at the top of the page and then choosing the **Library Settings** button on the tool ribbon.

5. In the **Document Library Settings** page, choose the **Workflow Settings** link in the **Permissions and Management** section.

6. In the **Workflow Settings** page, choose the **Add a workflow** link.

7. In the **Add a Workflow** page, choose the **ExpenseReport - Workflow1** workflow, enter a name for the workflow, such as **ExpenseTest**, and then choose the **Next** button.

    The workflow Association form appears. Use it to report the expense limit amount.

8. In the Association form, enter **1000** into the **Auto Approval Limit** box, and then choose the **Associate Workflow** button.

9. Choose the **Home** button to return to the SharePoint home page.

10. Choose the **Shared Documents** link on the QuickLaunch bar.

11. Choose one of the uploaded documents to display a drop-down arrow, choose it, and then choose the **Workflows** item.

12. Choose the image next to the ExpenseTest to display the workflow Initiation form.

13. In the **Expense Total** text box, enter a value that's greater than 1000, and then choose the **Start Workflow** button.

     When a reported expense exceeds the allocated expense amount, a task is added to the Task List. A column named **ExpenseTest** with the value **Completed** is also added to the expense report item in the Shared Documents list.

14. Repeat steps 11 - 13 with other documents in the Shared Documents list. (The exact number of documents is not important.)

15. Display the expense report summary application page by opening the following URL in a Web browser: **http://**<em>SystemName</em>**/_layouts/ExpenseReport/ApplicationPage1.aspx**.

     The expense report summary page lists all of the expense reports that exceeded the allocated amount, the amount they exceeded it by, and the total amount for all reports.

## Next steps
 For more information about SharePoint application pages, see [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md).

 You can learn more about how to design SharePoint page content by using the Visual Web Designer in Visual Studio from these topics:

- [Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md).

- [Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md).

## See also

- [Walkthrough: Create a workflow with association and initiation forms](../sharepoint/walkthrough-creating-a-workflow-with-association-and-initiation-forms.md)
- [How to: Create an application page](../sharepoint/how-to-create-an-application-page.md)
- [Create application pages for SharePoint](../sharepoint/creating-application-pages-for-sharepoint.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)