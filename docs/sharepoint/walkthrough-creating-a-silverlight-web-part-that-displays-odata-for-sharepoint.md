---
title: "Create Silverlight web part displaying OData for SharePoint"
ms.date: "02/22/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.SPE.SilverlightWebPart"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Walkthrough: Create a Silverlight web part that displays OData for SharePoint
  SharePoint 2010 exposes its list data by means of OData. In SharePoint, the OData service is implemented by the RESTful service ListData.svc. This walkthrough shows how to create a SharePoint web part that hosts a Silverlight application. The Silverlight application displays SharePoint Announcement list information by using ListData.svc. For more information, see [SharePoint Foundation REST Interface](/previous-versions/office/developer/sharepoint-2010/ff521587(v=office.14)) and [Open Data Protocol](https://www.odata.org/).

 [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of Microsoft Windows and SharePoint.

- [!INCLUDE[vs_dev11_long](../sharepoint/includes/vs-dev11-long-md.md)].

## Create a Silverlight application and Silverlight web part
 First, create a Silverlight application in Visual Studio. The Silverlight application retrieves data from the SharePoint Announcements list by using the ListData.svc service.

> [!NOTE]
> No versions of Silverlight before 4.0 support the required interfaces for referencing SharePoint list data.

#### To create a Silverlight application and Silverlight web part

1. On the menu bar, choose **File** > **New** > **Project** to display the **New Project** dialog box.

2. Expand the **SharePoint** node under either **Visual C#** or **Visual Basic**, and then choose the **2010** node.

3. In the templates pane, choose the **SharePoint 2010 Silverlight Web Part** template.

4. In the **Name** box, enter **SLWebPartTest** and then choose the **OK** button.

    The **SharePoint Customization Wizard** dialog box appears.

5. On the **Specify the site and security level for debugging** page, enter the URL for the SharePoint server site where you want to debug the site definition, or use the default location (http://<em>system name</em>/).

6. In the **What is the trust level for this SharePoint solution?** section, choose the **Deploy as a farm solution** option button.

    Although this example uses a farm solution, Silverlight web part projects can be deployed as either farm or sandboxed solutions. For more information about sandboxed solutions and farm solutions, see [Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md).

7. In the **How do you want to associate the Silverlight Web Part** section of the **Specify Silverlight Configuration Information** page, choose the **Create a new Silverlight project and associate it with the web part** option button.

8. Change the **Name** to **SLApplication**, set **Language** to either **Visual Basic** or **Visual C#**, and then set **Silverlight Version** to **Silverlight 4.0**.

9. Choose the **Finish** button. The projects appear in **Solution Explorer**.

     The solution contains two projects: a Silverlight application and a Silverlight web part. The Silverlight application retrieves and displays the list data from SharePoint, and the Silverlight web part hosts the Silverlight application, enabling you to view it in SharePoint.

## Customize the Silverlight application
 Add code and design elements to the Silverlight application.

#### To customize the Silverlight application

1. Add an assembly reference to System.Windows.Data in the Silverlight application. For more information, see [How to: Add or Remove References By Using the Add Reference Dialog Box](https://msdn.microsoft.com/3bd75d61-f00c-47c0-86a2-dd1f20e231c9).

2. In **Solution Explorer**, open the shortcut menu for **References**, and then choose **Add Service Reference**.

    > [!NOTE]
    > If you're using Visual Basic, you must choose the **Show All Files** icon at the top of **Solution Explorer** to display the **References** node.

3. In the Address box of the **Add Service Reference** dialog box, enter the URL of your SharePoint site, such as **http://MySPSite**, and then choose the **Go** button.

     When Silverlight locates the SharePoint OData service ListData.svc, it replaces the address with the full service URL. For this example, http://myserver becomes http://myserver/_vti_bin/ListData.svc.

4. Choose the **OK** button to add the service reference to the project, and use the default service name, ServiceReference1.

5. On the menu bar, choose **Build** > **Build Solution**.

6. Add a new data source to the project based on the SharePoint service. To do this, on the menu bar, choose **View** > **Other Windows** > **Data Sources**.

     The **Data Sources** window shows all of the available SharePoint list data, such as Tasks, Announcements, and Calendar.

7. Add the Announcements list data to the Silverlight application. You can drag "Announcements" from the **Data Sources** window onto the Silverlight designer.

     This creates a grid control bound to the SharePoint site's Announcements list.

8. Resize the grid control to fit the Silverlight page.

9. In the MainPage.xaml code file (*MainPage.xaml.cs* for Visual C# or *MainPage.xaml.vb* for Visual Basic), add the following namespace references.

    ```vb
    ' Add the following three Imports statements.
    Imports SLApplication.ServiceReference1
    Imports System.Windows.Data
    Imports System.Data.Services.Client
    ```

    ```csharp
    // Add the following three using directives.
    using SLApplication.ServiceReference1;
    using System.Windows.Data;
    using System.Data.Services.Client;
    ```

10. Add the following variable declarations at the top of the class.

    ```vb
    Private context As TeamSiteDataContext
    Private myCollectionViewSource As CollectionViewSource
    Private announcements As New DataServiceCollection(Of AnnouncementsItem)()
    ```

    ```csharp
    private TeamSiteDataContext context;
    private CollectionViewSource myCollectionViewSource;
    DataServiceCollection<AnnouncementsItem> announcements = new DataServiceCollection<AnnouncementsItem>();
    ```

11. Replace the `UserControl_Loaded` procedure with the following.

    ```vb
    Private Sub UserControl_Loaded_1(sender As Object, e As RoutedEventArgs)
        ' The URL for the OData service.
        ' Replace <server name> in the next line with the name of your SharePoint server.
        context = New TeamSiteDataContext(New Uri("http://<server name>/_vti_bin/ListData.svc"))

        ' Do not load your data at design time.
        If Not System.ComponentModel.DesignerProperties.GetIsInDesignMode(Me) Then
            'Load your data here and assign the results to the CollectionViewSource.
            myCollectionViewSource =   DirectCast(Me.Resources("announcementsViewSource"), System.Windows.Data.CollectionViewSource)
            announcements.LoadCompleted += New EventHandler(Of LoadCompletedEventArgs)(AddressOf announcements_LoadCompleted)
            announcements.LoadAsync(context.Announcements)
        End If
    End Sub
    ```

    ```csharp
    private void UserControl_Loaded_1(object sender, RoutedEventArgs e)
    {
        // The URL for the OData service.
        // Replace <server name> in the next line with the name of your
        // SharePoint server.
        context = new TeamSiteDataContext(new Uri("http://ServerName>/_vti_bin/ListData.svc"));

        // Do not load your data at design time.
        if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
        {
            //Load your data here and assign the results to the CollectionViewSource.
            myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["announcementsViewSource"];
            announcements.LoadCompleted += new EventHandler<LoadCompletedEventArgs>(announcements_LoadCompleted);
            announcements.LoadAsync(context.Announcements);
        }
    }
    ```

     Be sure to replace the *ServerName* placeholder with the name of your server that's running SharePoint.

12. Add the following error-handling procedure.

    ```vb
    Private Sub announcements_LoadCompleted(sender As Object, e As LoadCompletedEventArgs)
        ' Handle any errors.
        If e.[Error] Is Nothing Then
            myCollectionViewSource.Source = announcements
        Else
            MessageBox.Show(String.Format("ERROR: {0}", e.[Error].Message))
        End If
    End Sub

    ```

    ```csharp
    void announcements_LoadCompleted(object sender, LoadCompletedEventArgs e)
    {
        // Handle any errors.
        if (e.Error == null)
        {
            myCollectionViewSource.Source = announcements;
        }
        else
        {
            MessageBox.Show(string.Format("ERROR: {0}", e.Error.Message));
        }
    }
    ```

## Modify the Silverlight web part
 Change a property in the Silverlight web part project to enable Silverlight debugging.

#### To modify the Silverlight web part

1. Open the shortcut menu for the Silverlight web part project (**SLWebPartTest**), and then choose **Properties**.

2. In the **Properties** window, choose the **SharePoint** tab.

3. If it's not already selected, select the **Enable Silverlight debugging (instead of Script debugging)** check box.

4. Save the project.

## Test the Silverlight web part
 Test the new Silverlight web part in SharePoint to ensure that it displays the SharePoint list data properly.

#### To test the Silverlight web part

1. Choose the **F5** key to build and run the SharePoint solution.

2. In SharePoint, on the **Site Actions** menu, choose **New Page**.

3. In the **New Page** dialog, enter a title, such as **SL Web Part Test**, and then choose the **Create** button.

4. In the page designer, on the **Editing Tools** tab, choose **Insert**.

5. On the tab strip, choose **Web Part**.

6. In the **Categories** box, choose the **Custom** folder.

7. In the **Web Parts** list, choose the Silverlight web part, and then choose the **Add** button to add the web part to the designer.

8. After you have made all of the additions to the web page that you want, choose the **Page** tab, and then choose the **Save & Close** button on the tool bar.

     The Silverlight web part should now be displaying Announcement data from the SharePoint site. By default, the page is stored in the Site Pages list in SharePoint.

    > [!NOTE]
    > When accessing data in Silverlight across domains, Silverlight guards against security vulnerabilities that can be used to exploit web applications. If you encounter problems when accessing remote data in Silverlight, see [Making a Service Available Across Domain Boundaries](/previous-versions/windows/silverlight/dotnet-windows-silverlight/cc197955(v=vs.95)).

## See also
- [Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)
- [Deploy, publish, and upgrade SharePoint solution packages](../sharepoint/deploying-publishing-and-upgrading-sharepoint-solution-packages.md)
