---
title: Save data back to the database
description: Use DataSet tools to save data back to the database. The dataset is an in-memory copy of data that should be saved back to the database if it's modified.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- datasets [Visual Basic], validating data
- data validation, datasets
- data [Visual Studio], saving
- row version
- updating datasets, constraints
- datasets [Visual Basic], about datasets
- datasets [Visual Basic], merging
- updates, constraints in datasets
- saving data, about saving data
- datasets [Visual Basic], constraints
- TableAdapters
ms.assetid: afe6cb8a-dc6a-428b-b07b-903ac02c890b
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Save data back to the database

The dataset is an in-memory copy of data. If you modify that data, it's a good practice to save those changes back to the database. You do this in one of three ways:

- By calling one of the `Update` methods of a TableAdapter

- By calling one of `DBDirect` methods of the TableAdapter

- By calling the `UpdateAll` method on the TableAdapterManager that Visual Studio generates for you when the dataset contains tables that are related to other tables in the dataset

When you data bind dataset tables to controls on a Windows Form or XAML page, the data binding architecture does all the work for you.

If you're familiar with TableAdapters, you can jump directly to one of these topics:

|Topic|Description|
|-----------|-----------------|
|[Insert new records into a database](../data-tools/insert-new-records-into-a-database.md)|How to perform updates and inserts using TableAdapters or Command objects|
|[Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md)|How to perform updates with TableAdapters|
|[Hierarchical update](../data-tools/hierarchical-update.md)|How to perform updates from a dataset with two or more related tables|
|[Handle a concurrency exception](../data-tools/handle-a-concurrency-exception.md)|How to handle exceptions when two users attempt to change the same data in a database at the same time|
|[How to: Save data by using a transaction](../data-tools/save-data-by-using-a-transaction.md)|How to save data in a transaction using the System. Transactions namespace and a TransactionScope object|
|[Save data in a transaction](../data-tools/save-data-in-a-transaction.md)|Walkthrough that creates a Windows Forms application to demonstrate saving data to a database inside a transaction|
|[Save data to a database (multiple tables)](../data-tools/save-data-to-a-database-multiple-tables.md)|How to edit records and save changes in multiple tables back to the database|
|[Save data from an object to a database](../data-tools/save-data-from-an-object-to-a-database.md)|How to pass data from an object that is not in a dataset to a database by using a TableAdapter DbDirect method|
|[Save data with the TableAdapter DBDirect methods](../data-tools/save-data-with-the-tableadapter-dbdirect-methods.md)|How to use the TableAdapter to send SQL queries directly to the database|
|[Save a dataset as XML](../data-tools/save-a-dataset-as-xml.md)|How to save a dataset to an XML document|

## Two-stage updates

Updating a data source is a two-step process. The first step is to update the dataset with new records, changed records, or deleted records. If your application never sends those changes back to the data source, then you're finished with the update.

If you do send the changes back to the database, a second step is required. If you aren't using data-bound controls, you have to manually call the `Update` method of the same TableAdapter (or data adapter) that you used to populate the dataset. However, you can also use different adapters, for example, to move data from one data source to another or to update multiple data sources. If you aren't using data binding, and are saving changes for related tables, you have to manually instantiate a variable of the auto-generated `TableAdapterManager` class, and then call its `UpdateAll` method.

![Conceptual diagram of dataset updates](../data-tools/media/vbdatasetupdates.gif)

A dataset contains collections of tables, which contain a collections of rows. If you intend to update an underlying data source later, you must use the methods on the `DataTable.DataRowCollection` property when adding or removing rows. Those methods perform the change tracking that's needed for updating the data source. If you call the `RemoveAt` collection on the Rows property, the deletion won't be communicated back to the database.

## Merge datasets

You can update the contents of a dataset by *merging* it with another dataset. This involves copying the contents of a *source* dataset into the calling dataset (referred to as the *target* dataset). When you merge datasets, new records in the source dataset are added to the target dataset. Additionally, extra columns in the source dataset are added to the target dataset. Merging datasets is useful when you have a local dataset and you get a second dataset from another application. It's also useful when you get a second dataset from a component such as an XML web service, or when you need to integrate data from multiple datasets.

When merging datasets, you can pass a Boolean argument (`preserveChanges`) that tells the <xref:System.Data.DataSet.Merge%2A> method whether to retain existing modifications in the target dataset. Because datasets maintain multiple versions of records, it's important to keep in mind that more than one version of the records is being merged. The following table shows how a record in two datasets is merged:

|DataRowVersion|Target dataset|Source dataset|
| - | - | - |
|Original|James Wilson|James C. Wilson|
|Current|Jim Wilson|James C. Wilson|

Calling the <xref:System.Data.DataSet.Merge%2A> method on the previous table with `preserveChanges=false targetDataset.Merge(sourceDataset)` results in the following data:

|DataRowVersion|Target dataset|Source dataset|
| - | - | - |
|Original|James C. Wilson|James C. Wilson|
|Current|James C. Wilson|James C. Wilson|

Calling the <xref:System.Data.DataSet.Merge%2A> method with `preserveChanges = true targetDataset.Merge(sourceDataset, true)` results in the following data:

|DataRowVersion|Target dataset|Source dataset|
| - | - | - |
|Original|James C. Wilson|James C. Wilson|
|Current|Jim Wilson|James C. Wilson|

> [!CAUTION]
> In the `preserveChanges = true` scenario, if the <xref:System.Data.DataSet.RejectChanges%2A> method is called on a record in the target dataset, then it reverts to the original data from the *source* dataset. This means that if you try to update the original data source with the target dataset, it might not be able to find the original row to update. You can prevent a concurrency violation by filling another dataset with the updated records from the data source and then performing a merge to prevent a concurrency violation. (A concurrency violation occurs when another user modifies a record in the data source after the dataset has been filled.)

## Update constraints

To make changes to an existing data row, add or update data in the individual columns. If the dataset contains constraints (such as foreign keys or non-nullable constraints), it's possible that the record can temporarily be in an error state as you update it. That is, it can be in an error state after you finish updating one column but before you get to the next one.

To prevent premature constraint violations you can temporarily suspend update constraints. This serves two purposes:

- It prevents an error from being thrown after you've finished updating one column but haven't started updating another.

- It prevents certain update events from being raised (events that are often used for validation).

> [!NOTE]
> In Windows Forms, the data binding architecture that's built into the datagrid suspends constraint checking until focus moves out of a row, and you do not have to explicitly call the <xref:System.Data.DataRow.BeginEdit%2A>, <xref:System.Data.DataRow.EndEdit%2A>, or <xref:System.Data.DataRow.CancelEdit%2A> methods.

Constraints are automatically disabled when the <xref:System.Data.DataSet.Merge%2A> method is invoked on a dataset. When the merge is complete, if there are any constraints on the dataset that cannot be enabled, a <xref:System.Data.ConstraintException> is thrown. In this situation, the <xref:System.Data.DataSet.EnforceConstraints%2A> property is set to `false,` and all constraint violations must be resolved before resetting the <xref:System.Data.DataSet.EnforceConstraints%2A> property to `true`.

After you complete an update, you can re-enable constraint checking, which also re-enables update events and raises them.

For more information about suspending events, see [Turn off constraints while filling a dataset](../data-tools/turn-off-constraints-while-filling-a-dataset.md).

## Dataset update errors

When you update a record in a dataset, there is the possibility of an error. For example, you might inadvertently write data of the wrong type to a column, or data that's too long, or data that has some other integrity problem. Or, you might have application-specific validation checks that can raise custom errors during any stage of an update event. For more information, see [Validate data in datasets](../data-tools/validate-data-in-datasets.md).

## Maintain information about changes

Information about the changes in a dataset is maintained in two ways: by flagging rows that indicate that they have changed (<xref:System.Data.DataRow.RowState%2A>), and by keeping multiple copies of a record (<xref:System.Data.DataRowVersion>). By using this information, processes can determine what has changed in the dataset and can send appropriate updates to the data source.

### RowState property

The <xref:System.Data.DataRow.RowState%2A> property of a <xref:System.Data.DataRow> object is a value that provides information about the status of a particular row of data.

The following table details the possible values of the <xref:System.Data.DataRowState> enumeration:

|DataRowState Value|Description|
| - |-----------------|
|<xref:System.Data.DataRowState.Added>|The row has been added as an item to a <xref:System.Data.DataRowCollection>. (A row in this state does not have a corresponding original version since it did not exist when the last <xref:System.Data.DataRow.AcceptChanges%2A> method was called).|
|<xref:System.Data.DataRowState.Deleted>|The row was deleted using the <xref:System.Data.DataRow.Delete%2A> of a <xref:System.Data.DataRow> object.|
|<xref:System.Data.DataRowState.Detached>|The row has been created but is not part of any <xref:System.Data.DataRowCollection>. A <xref:System.Data.DataRow> object is in this state immediately after it has been created, before it has been added to a collection, and after it has been removed from a collection.|
|<xref:System.Data.DataRowState.Modified>|A column value in the row has changed in some way.|
|<xref:System.Data.DataRowState.Unchanged>|The row has not changed since <xref:System.Data.DataRow.AcceptChanges%2A> was last called.|

### DataRowVersion enumeration

Datasets maintain multiple versions of records. The <xref:System.Data.DataRowVersion> fields are used when retrieving the value found in a <xref:System.Data.DataRow> using the <xref:System.Data.DataRow.Item%2A> property or the <xref:System.Data.DataRow.GetChildRows%2A> method of the <xref:System.Data.DataRow> object.

The following table details the possible values of the <xref:System.Data.DataRowVersion> enumeration:

|DataRowVersion Value|Description|
| - |-----------------|
|<xref:System.Data.DataRowVersion.Current>|The current version of a record contains all modifications that have been performed on the record since the last time <xref:System.Data.DataRow.AcceptChanges%2A> was called. If the row has been deleted, there is no current version.|
|<xref:System.Data.DataRowVersion.Default>|The default value of a record, as defined by the dataset schema or data source.|
|<xref:System.Data.DataRowVersion.Original>|The original version of a record is a copy of the record as it was the last time changes were committed in the dataset. In practical terms, this is typically the version of a record as read from a data source.|
|<xref:System.Data.DataRowVersion.Proposed>|The proposed version of a record that is available temporarily while you are in the middle of an update — that is, between the time you called the <xref:System.Data.DataRow.BeginEdit%2A> method and the <xref:System.Data.DataRow.EndEdit%2A> method. You typically access the proposed version of a record in a handler for an event such as <xref:System.Data.DataTable.RowChanging>. Invoking the <xref:System.Data.DataRow.CancelEdit%2A> method reverses the changes and deletes the proposed version of the data row.|

The original and current versions are useful when update information is transmitted to a data source. Typically, when an update is sent to the data source, the new information for the database is in the current version of a record. Information from the original version is used to locate the record to update.

For example, in a case where the primary key of a record is changed, you need a way to locate the correct record in the data source in order to update the changes. If no original version existed, then the record would most likely be appended to the data source, resulting not only in an extra unwanted record, but in one record that is inaccurate and out of date. The two versions are also used in concurrency control. You can compare the original version against a record in the data source to determine if the record has changed since it was loaded into the dataset.

The proposed version is useful when you need to perform validation before actually committing the changes to the dataset.

Even if records have changed, there are not always original or current versions of that row. When you insert a new row into the table, there is no original version, only a current version. Similarly, if you delete a row by calling the table's `Delete` method, there is an original version, but no current version.

You can test to see if a specific version of a record exists by querying a data row's <xref:System.Data.DataRow.HasVersion%2A> method. You can access either version of a record by passing a <xref:System.Data.DataRowVersion> enumeration value as an optional argument when you request the value of a column.

## Get changed records

It's a common practice not to update every record in a dataset. For example, a user might be working with a Windows Forms <xref:System.Windows.Forms.DataGridView> control that displays many records. However, the user might update only a few records, delete one, and insert a new one. Datasets and data tables provide a method (`GetChanges`) for returning only the rows that have been modified.

You can create subsets of changed records using the `GetChanges` method of either the data table (<xref:System.Data.DataTable.GetChanges%2A>) or of the dataset (<xref:System.Data.DataSet.GetChanges%2A>) itself. If you call the method for the data table, it returns a copy of the table with only the changed records. Similarly, if you call the method on the dataset, you get a new dataset with only changed records in it.

`GetChanges` by itself returns all changed records. In contrast, by passing the desired <xref:System.Data.DataRowState> as a parameter to the `GetChanges` method, you can specify what subset of changed records you want: newly added records, records that are marked for deletion, detached records, or modified records.

Getting a subset of changed records is useful when you want to send records to another component for processing. Instead of sending the entire dataset, you can reduce the overhead of communicating with the other component by getting only the records that the component needs.

## Commit changes in the dataset

As changes are made in the dataset, the <xref:System.Data.DataRow.RowState%2A> property of changed rows is set. The original and current versions of records are established, maintained, and made available to you by the <xref:System.Data.DataRowView.RowVersion%2A> property. The metadata that's stored in the properties of these changed rows is necessary for sending the correct updates to the data source.

If the changes reflect the current state of the data source, you no longer need to maintain this information. Typically, there are two times when the dataset and its source are in sync:

- Immediately after you have loaded information into the dataset, such as when you read data from the source.

- After sending changes from the dataset to the data source (but not before, because you would lose the change information that's required to send changes to the database).

You can commit the pending changes to the dataset by calling the <xref:System.Data.DataSet.AcceptChanges%2A> method. Typically, <xref:System.Data.DataSet.AcceptChanges%2A> is called at the following times:

- After you load the dataset. If you load a dataset by calling a TableAdapter's `Fill` method, then the adapter automatically commits changes for you. However, if you load a dataset by merging another dataset into it, then you have to commit the changes manually.

    > [!NOTE]
    > You can prevent the adapter from automatically committing the changes when you call the `Fill` method by setting the `AcceptChangesDuringFill` property of the adapter to `false`. If it's set to `false`, then the <xref:System.Data.DataRow.RowState%2A> of each row that's inserted during the fill is set to <xref:System.Data.DataRowState.Added>.

- After you send dataset changes to another process, such as an XML web service.

    > [!CAUTION]
    > Committing the change this way erases any change information. Do not commit changes until after you finish performing operations that require your application to know what changes have been made in the dataset.

This method accomplishes the following:

- Writes the <xref:System.Data.DataRowVersion.Current> version of a record into its <xref:System.Data.DataRowVersion.Original> version and overwrites the original version.

- Removes any row where the <xref:System.Data.DataRow.RowState%2A> property is set to <xref:System.Data.DataRowState.Deleted>.

- Sets the <xref:System.Data.DataRow.RowState%2A> property of a record to <xref:System.Data.DataRowState.Unchanged>.

The <xref:System.Data.DataSet.AcceptChanges%2A> method is available at three levels. You can call it on a <xref:System.Data.DataRow> object to commits changes for just that row. You can also call it on a <xref:System.Data.DataTable> object to commit all rows in a table. Finally, you can call it on the <xref:System.Data.DataSet> object to commit all pending changes in all records of all tables of the dataset.

The following table describes which changes are committed based on what object the method is called on:

|Method|Result|
|------------|------------|
|<xref:System.Data.DataRow.AcceptChanges%2A?displayProperty=fullName>|Changes are committed only on the specific row.|
|<xref:System.Data.DataTable.AcceptChanges%2A?displayProperty=fullName>|Changes are committed on all rows in the specific table.|
|<xref:System.Data.DataSet.AcceptChanges%2A?displayProperty=fullName>|Changes are committed on all rows in all tables of the dataset.|

> [!NOTE]
> If you load a dataset by calling a TableAdapter's `Fill` method, you don't have to explicitly accept changes. By default, the `Fill` method calls the `AcceptChanges` method after it finishes populating the data table.

A related method, <xref:System.Data.DataSet.RejectChanges%2A>, undoes the effect of changes by copying the <xref:System.Data.DataRowVersion.Original> version back into the <xref:System.Data.DataRowVersion.Current> version of records. It also sets the <xref:System.Data.DataRow.RowState%2A> of each record back to <xref:System.Data.DataRowState.Unchanged>.

## Data validation

In order to verify that the data in your application meets the requirements of the processes that it is passed to, you often have to add validation. This might involve checking that a user's entry in a form is correct, validating data that's sent to your application by another application, or even checking that information that's calculated within your component falls within the constraints of your data source and application requirements.

You can validate data in several ways:

- In the business layer, by adding code to your application to validate data. The dataset is one place you can do this. The dataset provides some of the advantages of back-end validation — such as the ability to validate changes as column and row values are changing. For more information, see [Validate data in datasets](../data-tools/validate-data-in-datasets.md).

- In the presentation layer, by adding validation to forms. For more information, see [User input validation in Windows Forms](/dotnet/framework/winforms/user-input-validation-in-windows-forms).

- In the data back end, by sending data to the data source — for example, the database — and allowing it to accept or reject the data. If you are working with a database that has sophisticated facilities for validating data and providing error information, this can be a practical approach because you can validate the data no matter where it comes from. However, this approach might not accommodate application-specific validation requirements. Additionally, having the data source validate data can result in numerous round trips to the data source, depending on how your application facilitates the resolution of validation errors raised by the back end.

   > [!IMPORTANT]
   > When using data commands with a <xref:System.Data.SqlClient.SqlCommand.CommandType%2A> property that's set to <xref:System.Data.CommandType.Text>, carefully check information that is sent from a client before passing it to your database. Malicious users might try to send (inject) modified or additional SQL statements in an effort to gain unauthorized access or damage the database. Before you transfer user input to a database, always verify that the information is valid. It's a best practice to always use parameterized queries or stored procedures when possible.

## Transmit updates to the data source

After changes have been made in a dataset, you can transmit the changes to a data source. Most commonly, you do this by calling the `Update` method of a TableAdapter (or data adapter). The method loops through each record in a data table, determines what type of update is required (update, insert, or delete), if any, and then runs the appropriate command.

As an illustration of how updates are made, suppose your application uses a dataset that contains a single data table. The application fetches two rows from the database. After the retrieval, the in-memory data table looks like this:

```sql
(RowState)     CustomerID   Name             Status
(Unchanged)    c200         Robert Lyon      Good
(Unchanged)    c400         Nancy Buchanan    Pending
```

Your application changes Nancy Buchanan's status to "Preferred." As a result of this change, the value of the <xref:System.Data.DataRow.RowState%2A> property for that row changes from <xref:System.Data.DataRowState.Unchanged> to <xref:System.Data.DataRowState.Modified>. The value of the <xref:System.Data.DataRow.RowState%2A> property for the first row remains <xref:System.Data.DataRowState.Unchanged>. The data table now looks like this:

```sql
(RowState)     CustomerID   Name             Status
(Unchanged)    c200         Robert Lyon      Good
(Modified)     c400         Nancy Buchanan    Preferred
```

Your application now calls the `Update` method to transmit the dataset to the database. The method inspects each row in turn. For the first row, the method transmits no SQL statement to the database because that row has not changed since it was originally fetched from the database.

For the second row, however, the `Update` method automatically invokes the correct data command and transmits it to the database. The specific syntax of the SQL statement depends on the dialect of SQL that's supported by the underlying data store. But, the following general traits of the transmitted SQL statement are noteworthy:

- The transmitted SQL statement is an UPDATE statement. The adapter knows to use an UPDATE statement because the value of the <xref:System.Data.DataRow.RowState%2A> property is <xref:System.Data.DataRowState.Modified>.

- The transmitted SQL statement includes a WHERE clause indicating that the target of the UPDATE statement is the row where `CustomerID = 'c400'`. This part of the SELECT statement distinguishes the target row from all others because the `CustomerID` is the primary key of the target table. The information for the WHERE clause is derived from the original version of the record (`DataRowVersion.Original`), in case the values that are required to identify the row have changed.

- The transmitted SQL statement includes the SET clause, to set the new values of the modified columns.

   > [!NOTE]
   > If the TableAdapter's `UpdateCommand` property has been set to the name of a stored procedure, the adapter does not construct an SQL statement. Instead, it invokes the stored procedure with the appropriate parameters passed in.

## Pass parameters

You usually use parameters to pass the values for records that are going to be updated in the database. When the TableAdapter's `Update` method runs an UPDATE statement, it needs to fill in the parameter values. It gets these values from the `Parameters` collection for the appropriate data command — in this case, the `UpdateCommand` object in the TableAdapter.

If you've used the Visual Studio tools to generate a data adapter, the `UpdateCommand` object contains a collection of parameters that correspond to each parameter placeholder in the statement.

The <xref:System.Data.SqlClient.SqlParameter.SourceColumn%2A?displayProperty=fullName> property of each parameter points to a column in the data table. For example, the `SourceColumn` property for the `au_id` and `Original_au_id` parameters is set to whatever column in the data table contains the author id. When the adapter's `Update` method runs, it reads the author id column from the record that's being updated and fills the values into the statement.

In an UPDATE statement, you need to specify both the new values (those that will be written to the record) as well as the old values (so that the record can be located in the database). There are, therefore, two parameters for each value: one for the SET clause and a different one for the WHERE clause. Both parameters read data from the record that's being updated, but they get different versions of the column value based on the parameter's <xref:System.Data.SqlClient.SqlParameter.SourceVersion> property. The parameter for the SET clause gets the current version, and the parameter for the WHERE clause gets the original version.

> [!NOTE]
> You can also set values in the `Parameters` collection yourself in code, which you would typically do in an event handler for the data adapter's <xref:System.Data.DataTable.RowChanging> event.

## See also

- [Dataset tools in Visual Studio](../data-tools/dataset-tools-in-visual-studio.md)
- [Create and configure TableAdapters](create-and-configure-tableadapters.md)
- [Update data by using a TableAdapter](../data-tools/update-data-by-using-a-tableadapter.md)
- [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md)
- [Validate data](validate-data-in-datasets.md)
- [How to: Add, modify, and delete entities (WCF data services)](/dotnet/framework/data/wcf/how-to-add-modify-and-delete-entities-wcf-data-services)
