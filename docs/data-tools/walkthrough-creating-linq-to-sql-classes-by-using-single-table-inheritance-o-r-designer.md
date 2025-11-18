---
title: LINQ to SQL classes with single-table inheritance
description: In this walkthrough, create LINQ to SQL classes by using single-table inheritance in the Visual Studio Object Relational Designer (O/R Designer).
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: data-tools
---

# Walkthrough: Create LINQ to SQL classes by using single-table inheritance (O/R Designer)

The [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md) supports single-table inheritance as it is typically implemented in relational systems. This walkthrough expands upon the generic steps provided in the [How to: Configure inheritance by using the O/R Designer](../data-tools/how-to-configure-inheritance-by-using-the-o-r-designer.md) topic and provides some real data to demonstrate the use of inheritance in the O/R Designer.

During this walkthrough, you perform the following tasks:

- Create a database table and add data to it.

- Create a Windows Forms application.

- Add a LINQ to SQL file to a project.

- Create new entity classes.

- Configure the entity classes to use inheritance.

- Query the inherited class.

- Display the data on a Windows Form.

## Create a table to inherit from

To see how inheritance works, you create a small `Person` table, use it as a base class, and then create an `Employee` object that inherits from it.

### To create a base table to demonstrate inheritance

1. In **Server Explorer** or **Database Explorer**, right-click the **Tables** node and click **Add New Table**.

    > [!NOTE]
    > You can use the Northwind database or any other database that you can add a table to.

2. In the **Table Designer**, add the following columns to the table:

    |Column Name|Data Type|Allow Nulls|
    |-----------------|---------------|-----------------|
    |**ID**|**int**|**False**|
    |**Type**|**int**|**True**|
    |**FirstName**|**nvarchar(200)**|**False**|
    |**LastName**|**nvarchar(200)**|**False**|
    |**Manager**|**int**|**True**|

3. Set the ID column as the primary key.

4. Save the table and name it **Person**.

## Add data to the table

So that you can verify that inheritance is configured correctly, the table needs some data for each class in the single-table inheritance.

### To add data to the table

1. Open the table in data view. (Right-click the **Person** table in **Server Explorer** or **Database Explorer** and click **Show Table Data**.)

2. Copy the following data into the table. (You can copy it and then paste it into the table by selecting the whole row in the **Results** Pane.)

    |**ID**|**Type**|**FirstName**|**LastName**|**Manager**|
    |-|-|-|-|-|
    |**1**|**1**|**Anne**|**Wallace**|**NULL**|
    |**2**|**1**|**Carlos**|**Grilo**|**NULL**|
    |**3**|**1**|**Yael**|**Peled**|**NULL**|
    |**4**|**2**|**Gatis**|**Ozolins**|**1**|
    |**5**|**2**|**Andreas**|**Hauser**|**1**|
    |**6**|**2**|**Tiffany**|**Phuvasate**|**1**|
    |**7**|**2**|**Alexey**|**Orekhov**|**2**|
    |**8**|**2**|**Michał**|**Poliszkiewicz**|**2**|
    |**9**|**2**|**Tai**|**Yee**|**2**|
    |**10**|**2**|**Fabricio**|**Noriega**|**3**|
    |**11**|**2**|**Mindy**|**Martin**|**3**|
    |**12**|**2**|**Ken**|**Kwok**|**3**|

## Create a new project

Now that you have created the table, create a new project to demonstrate configuring inheritance.

### To create the new Windows Forms application

1. In Visual Studio, on the **File** menu, select **New** > **Project**.

2. Expand either **Visual C#** or **Visual Basic** in the left-hand pane, then select **Windows Desktop**.

3. In the middle pane, select the **Windows Forms App** project type.

4. Name the project **InheritanceWalkthrough**, and then choose **OK**.

     The **InheritanceWalkthrough** project is created, and added to **Solution Explorer**.

## Add a LINQ to SQL classes file to the project

### To add a LINQ to SQL file to the project

1. On the **Project** menu, click **Add New Item**.

2. Click the **LINQ to SQL Classes** template, and then select **Add**.

     The `.dbml` file is added to the project and the **O/R Designer** opens.

## Create the inheritance by using the O/R Designer

Configure the inheritance by dragging an **Inheritance** object from the **Toolbox** onto the design surface.

### To create the inheritance

1. In **Server Explorer** or **Database Explorer**, navigate to the **Person** table that you created earlier.

2. Drag the **Person** table onto the **O/R Designer** design surface.

3. Drag a second **Person** table onto the **O/R Designer** and change its name to **Employee**.

4. Delete the **Manager** property from the **Person** object.

5. Delete the **Type**, **ID**, **FirstName**, and **LastName** properties from the **Employee** object. (In other words, delete all properties except for **Manager**.)

6. From the **Object Relational Designer** tab of the **Toolbox**, create an **Inheritance** between the **Person** and **Employee** objects. To do this, click the **Inheritance** item in the **Toolbox** and release the mouse button. Next, click the **Employee** object and then the **Person** object in the **O/R Designer**. The arrow on the inheritance line then points to the **Person** object.

7. Click the **Inheritance** line on the design surface.

8. Set the **Discriminator Property** property to **Type**.

9. Set the **Derived Class Discriminator Value** property to **2**.

10. Set the **Base Class Discriminator Value** property to **1**.

11. Set the **Inheritance Default** property to **Person**.

12. Build the project.

## Query the inherited class and display the data on the form

You now add some code to the form that queries for a specific class in the object model.

### To create a LINQ query and display the results on the form

1. Drag a **ListBox** onto **Form1**.

2. Double-click the form to create a `Form1_Load` event handler.

3. Add the following code to the `Form1_Load` event handler:

    ### [C#](#tab/csharp)

    ```csharp
    NorthwindDataContext dc = new DataClasses1DataContext();
    var results = from emp in dc.Persons
                  where emp is Employee
                  select emp;

    foreach(Employee Emp in results)
    {
        listBox1.Items.Add(Emp.LastName)
    }
    ```

    ### [VB](#tab/vb)

    ```vb
    Dim dc As New DataClasses1DataContext
    Dim results = From emp In dc.Persons _
        Where TypeOf emp Is Employee _
        Select emp

    For Each Emp As Employee In results
        ListBox1.Items.Add(Emp.LastName)
    Next
    ```

    ---

## Test the application

Run the application and verify that the records displayed in the list box are all employees (records that have a value of 2 in their **Type** column).

### To test the application

1. Press **F5**.

2. Verify that only records that have a value of 2 in their **Type** column are displayed.

3. Close the form. (On the **Debug** menu, click **Stop Debugging**.)

## Related content

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)
- [Walkthrough: Creating LINQ to SQL classes (O-R Designer)](how-to-create-linq-to-sql-classes-mapped-to-tables-and-views-o-r-designer.md)
- [How to: Assign stored procedures to perform updates, inserts, and deletes (O/R Designer)](../data-tools/how-to-assign-stored-procedures-to-perform-updates-inserts-and-deletes-o-r-designer.md)
- [LINQ to SQL](/dotnet/framework/data/adonet/sql/linq/index)
- [How to: Generate the object model in Visual Basic or C#](/dotnet/framework/data/adonet/sql/linq/how-to-generate-the-object-model-in-visual-basic-or-csharp)
