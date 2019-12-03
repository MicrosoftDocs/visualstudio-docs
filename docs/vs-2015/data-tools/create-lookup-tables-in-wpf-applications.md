---
title: "Create lookup tables in WPF applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "data [WPF], displaying"
  - "WPF, data binding in Visual Studio"
  - "WPF data binding [Visual Studio]"
  - "displaying data, WPF"
  - "WPF [WPF], data"
  - "WPF Designer, data binding"
  - "data binding, WPF"
ms.assetid: 56a1fbff-c7e8-4187-a1c1-ffd17024bc1b
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Create lookup tables in WPF applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The term *lookup table* (sometimes called a *lookup binding*) describes a control that displays information from one data table based on the value of a foreign-key field in another table. You can create a lookup table by dragging the main node of a parent table or object in the **Data Sources** window onto a control that is already bound to a column or property in a related child table.

 For example, consider a table of `Orders` in a sales database. Each record in the `Orders` table includes a `CustomerID` that indicates which customer placed the order. The `CustomerID` is a foreign key that points to a customer record in the `Customers` table. When you display a list of orders from the `Orders` table, you may want to display the actual customer name instead of the `CustomerID`. Because the customer name is in the `Customers` table, you need to create a lookup table to display the customer name. The lookup table uses the `CustomerID` value in the `Orders` record to navigate the relationship, and return the customer name.

## To create a lookup table

1. Add one of the following types of data sources with related data to your project:

    - Dataset or Entity Data Model.

    - WCF Data Service, WCF service or Web service. For more information, see [How to: Connect to Data in a Service](../data-tools/how-to-connect-to-data-in-a-service.md).

    - Objects. For more information, see [How to: Connect to Data in Objects](https://msdn.microsoft.com/library/862fd351-0f4d-4220-9743-6103b87dc24b).

    > [!NOTE]
    > Before you can create a lookup table, two related tables or objects must exist as a data source for the project.

2. Open the**WPF Designer**, and make sure that the designer contains a container that is a valid drop target for items in the **Data Sources** window.

     For more information about valid drop targets, see [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md).

3. On the **Data** menu, click **Show Data Sources** to open the **Data Sources** window.

4. Expand the nodes in the **Data Sources** window, until you can see the parent table or object and the related child table or object.

    > [!NOTE]
    > The related child table or object is the node that appears as an expandable child node under the parent table or object.

5. Click the drop-down menu for the child node, and select **Details**.

6. Expand the child node.

7. Under the child node, click the drop-down menu for the item that relates the child and parent data. (In the preceding example, this is the **CustomerID** node.) Select one of the following types of controls that support lookup binding:

    - **ComboBox**

    - **ListBox**

    - **ListView**

        > [!NOTE]
        > If the **ListBox** or **ListView** control does not appear in the list, you can add these controls to the list. For information, see [Set the control to be created when dragging from the Data Sources window](../data-tools/set-the-control-to-be-created-when-dragging-from-the-data-sources-window.md).

    - Any custom control that derives from <xref:System.Windows.Controls.Primitives.Selector>.

        > [!NOTE]
        > For information about how to add custom controls to the list of controls you can select for items in the **Data Sources** window, see [Add custom controls to the Data Sources window](../data-tools/add-custom-controls-to-the-data-sources-window.md).

8. Drag the child node from the **Data Sources** window onto a container in the WPF designer. (In the preceding example, the child node is the **Orders** node.)

     Visual Studio generates XAML that creates new data-bound controls for each of the items that you drag. The XAML also adds a new <xref:System.Windows.Data.CollectionViewSource> for the child table or object to the resources of the drop target. For some data sources, Visual Studio also generates code to load data into the table or object. For more information, see [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md).

9. Drag the parent node from the **Data Sources** window onto the lookup binding control that you created earlier. (In the preceding example, the parent node is the **Customers** node).

     Visual Studio sets some properties on the control to configure the lookup binding. The following table lists the properties that Visual Studio modifies. If necessary, you can change these properties in the XAML or in the **Properties** window.

    |Property|Explanation of setting|
    |--------------|----------------------------|
    |<xref:System.Windows.Controls.ItemsControl.ItemsSource%2A>|This property specifies the collection or binding that is used to get the data that is displayed in the control. Visual Studio sets this property to the <xref:System.Windows.Data.CollectionViewSource> for the parent data you dragged to the control.|
    |<xref:System.Windows.Controls.ItemsControl.DisplayMemberPath%2A>|This property specifies the path of the data item that is displayed in the control. Visual Studio sets this property to the first column or property in the parent data, after the primary key, that has a string data type.<br /><br /> If you want to display a different column or property in the parent data, change this property to the path of a different property.|
    |<xref:System.Windows.Controls.Primitives.Selector.SelectedValue%2A>|Visual Studio binds this property to the column or property of the child data that you dragged to the designer. This is the foreign key to the parent data.|
    |<xref:System.Windows.Controls.Primitives.Selector.SelectedValuePath%2A>|Visual Studio sets this property to the path of the column or property of the child data that is the foreign key to the parent data.|

## See Also
 [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio1.md)
 [Bind WPF controls to data in Visual Studio](../data-tools/bind-wpf-controls-to-data-in-visual-studio2.md)
 [Display related data in WPF applications](../data-tools/display-related-data-in-wpf-applications.md)
 [Walkthrough: Displaying Related Data in a WPF Application](../data-tools/walkthrough-displaying-related-data-in-a-wpf-application.md)
