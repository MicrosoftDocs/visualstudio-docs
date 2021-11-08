---
title: Create relationships between datasets
description: Create relationships between datasets in Visual Studio. Understand DataRelation objects and constraints. Manually create a data relation in Dataset Manager.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- vbData.Microsoft.VSDesigner.DataSource.DesignRelation
- vbdata.Microsoft.VSDesigner.DataSource.DesignRelation
helpviewer_keywords:
- relationships, about relationships
- datasets [Visual Basic], relationships
- relationships, datasets
ms.assetid: cfe274f0-71fe-40f6-994e-7c7f6273c9ba
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# Create relationships between datasets
Datasets that contain related data tables use <xref:System.Data.DataRelation> objects to represent a parent/child relationship between the tables and to return related records from one another. Adding related tables to datasets by using the **Data Source Configuration Wizard**, or the **Dataset Designer**, creates and configures the <xref:System.Data.DataRelation> object for you.

The <xref:System.Data.DataRelation> object performs two functions:

- It can make available the records related to a record you are working with. It provides child records if you are in a parent record (<xref:System.Data.DataRow.GetChildRows%2A>) and a parent record if you are working with a child record (<xref:System.Data.DataRow.GetParentRow%2A>).

- It can enforce constraints for referential integrity, such as deleting related child records when you delete a parent record.

It is important to understand the difference between a true join and the function of a <xref:System.Data.DataRelation> object. In a true join, records are taken from parent and child tables and put into a single, flat recordset. When you use a <xref:System.Data.DataRelation> object, no new recordset is created. Instead, the DataRelation tracks the relationship between tables and keeps parent and child records in sync.

## DataRelation objects and constraints
A <xref:System.Data.DataRelation> object is also used to create and enforce the following constraints:

- A unique constraint, which guarantees that a column in the table contains no duplicates.

- A foreign-key constraint, which can be used to maintain referential integrity between a parent and child table in a dataset.

Constraints that you specify in a <xref:System.Data.DataRelation> object are implemented by automatically creating appropriate objects or setting properties. If you create a foreign-key constraint by using the <xref:System.Data.DataRelation> object, instances of the <xref:System.Data.ForeignKeyConstraint> class are added to the <xref:System.Data.DataRelation> object's <xref:System.Data.DataRelation.ChildKeyConstraint%2A> property.

A unique constraint is implemented either by simply setting the <xref:System.Data.DataColumn.Unique%2A> property of a data column to `true` or by adding an instance of the <xref:System.Data.UniqueConstraint> class to the <xref:System.Data.DataRelation> object's <xref:System.Data.DataRelation.ParentKeyConstraint%2A> property. For information on suspending constraints in a dataset, see [Turn off constraints while filling a dataset](../data-tools/turn-off-constraints-while-filling-a-dataset.md).

### Referential integrity rules
As part of the foreign-key constraint, you can specify referential integrity rules that are applied at three points:

- When a parent record is updated

- When a parent record is deleted

- When a change is accepted or rejected

The rules that you can make are specified in the <xref:System.Data.Rule> enumeration and are listed in the following table.

|Foreign-key constraint rule|Action|
| - |------------|
|<xref:System.Data.Rule.Cascade>|The change (update or delete) made to the parent record is also made in related records in the child table.|
|<xref:System.Data.Rule.SetNull>|Child records are not deleted, but the foreign key in the child records is set to <xref:System.DBNull>. With this setting, child records can be left as "orphans"—that is, they have no relationship to parent records. **Note:** Using this rule can result in invalid data in the child table.|
|<xref:System.Data.Rule.SetDefault>|The foreign key in the related child records is set to its default value (as established by the column's <xref:System.Data.DataColumn.DefaultValue%2A> property).|
|<xref:System.Data.Rule.None>|No change is made to related child records. With this setting, child records can contain references to invalid parent records.|

For more information about updates in dataset tables, see [Save data back to the database](../data-tools/save-data-back-to-the-database.md).

### Constraint-only relations
When you create a <xref:System.Data.DataRelation> object, you have the option of specifying that the relation be used only to enforce constraints—that is, it will not also be used to access related records. You can use this option to generate a dataset that is slightly more efficient and that contains fewer methods than one with the related-records capability. However, you will not be able to access related records. For example, a constraint-only relation prevents you from deleting a parent record that still has child records, and you cannot access the child records through the parent.

## Manually creating a data relation in the Dataset Designer
When you create data tables by using the data design tools in Visual Studio, relationships are created automatically if the information can be gathered from the source of your data. If you manually add data tables from the **DataSet** tab of the **Toolbox**, you may have to create the relationship manually. For information on creating <xref:System.Data.DataRelation> objects programmatically, see [Adding DataRelations](/dotnet/framework/data/adonet/dataset-datatable-dataview/adding-datarelations).

Relationships between data tables appear as lines in the **Dataset Designer**, with a key and infinity glyph depicting the one-to-many aspect of the relationship. By default, the name of the relationship does not appear on the design surface.

[!INCLUDE[note_settings_general](../data-tools/includes/note_settings_general_md.md)]

#### To create a relationship between two data tables

1. Open your dataset in the **Dataset Designer**. For more information, see [Walkthrough: Creating a Dataset in the Dataset Designer](walkthrough-creating-a-dataset-with-the-dataset-designer.md).

2. Drag a **Relation** object from the **DataSet** toolbox onto the child data table in the relationship.

     The **Relation** dialog box opens, populating the **Child Table** box with the table that you dragged the **Relation** object onto.

3. Select the parent table from the **Parent Table** box. The parent table contains records on the "one" side of a one-to-many relationship.

4. Verify that the correct child table is displayed in the **Child Table** box. The child table contains records on the "many" side of a one-to-many relationship.

5. Type a name for the relationship in the **Name** box, or leave the default name based on the selected tables. This is the name of the actual <xref:System.Data.DataRelation> object in code.

6. Select the columns that join the tables in the **Key Columns** and **Foreign Key Columns** lists.

7. Select whether to create a relation, constraint, or both.

8. Select or clear the **Nested Relation** box. Selecting this option sets the <xref:System.Data.DataRelation.Nested%2A> property to `true`, and it causes the child rows of the relation to be nested within the parent column when those rows are written as XML data or synchronized with <xref:System.Xml.XmlDataDocument>. For more information, see [Nesting DataRelations](/dotnet/framework/data/adonet/dataset-datatable-dataview/nesting-datarelations).

9. Set the rules to be enforced when you're making changes to records in these tables. For more information, see <xref:System.Data.Rule>.

10. Click **OK** to create the relationship. A relation line appears on the designer between the two tables.

#### To display a relation name in the Dataset Designer

1. Open your dataset in the **Dataset Designer**. For more information, see [Walkthrough: Creating a Dataset in the Dataset Designer](walkthrough-creating-a-dataset-with-the-dataset-designer.md).

2. From the **Data** menu, select the **Show Relation Labels** command to display the relation name. Clear that command to hide the relation name.

## See also

- [Create and configure datasets in Visual Studio](../data-tools/create-and-configure-datasets-in-visual-studio.md)
