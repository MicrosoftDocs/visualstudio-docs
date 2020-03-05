---
title: "Relationships in datasets | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
f1_keywords:
  - "vbData.Microsoft.VSDesigner.DataSource.DesignRelation"
  - "vbdata.Microsoft.VSDesigner.DataSource.DesignRelation"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "relationships, about relationships"
  - "datasets [Visual Basic], relationships"
  - "relationships, datasets"
ms.assetid: cfe274f0-71fe-40f6-994e-7c7f6273c9ba
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Relationships in datasets
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

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
|----------------------------------|------------|
|<xref:System.Data.Rule>|The change (update or delete) made to the parent record is also made in related records in the child table.|
|<xref:System.Data.Rule>|Child records are not deleted, but the foreign key in the child records is set to <xref:System.DBNull>. With this setting, child records can be left as "orphans"—that is, they have no relationship to parent records. **Note:**  Using this rule can result in invalid data in the child table.|
|<xref:System.Data.Rule>|The foreign key in the related child records is set to its default value (as established by the column's <xref:System.Data.DataColumn.DefaultValue%2A> property).|
|<xref:System.Data.Rule>|No change is made to related child records. With this setting, child records can contain references to invalid parent records.|

 For more information about updates in dataset tables, see [Save data back to the database](../data-tools/save-data-back-to-the-database.md).

### Constraint-only relations
 When you create a <xref:System.Data.DataRelation> object, you have the option of specifying that the relation be used only to enforce constraints—that is, it will not also be used to access related records. You can use this option to generate a dataset that is slightly more efficient and that contains fewer methods than one with the related-records capability. However, you will not be able to access related records. For example, a constraint-only relation prevents you from deleting a parent record that still has child records, and you cannot access the child records through the parent.

## Manually creating a data relation in the Dataset Designer
 When you create data tables by using the data design tools in Visual Studio, relationships are created automatically if the information can be gathered from the source of your data. If you manually add data tables from the **DataSet** tab of the **Toolbox**, you may have to create the relationship manually. For information on creating <xref:System.Data.DataRelation> objects programmatically, see [Adding DataRelations](https://msdn.microsoft.com/library/a4a564fb-c1c4-4135-b6c2-b030e51195e4).

 Relationships between data tables appear as lines in the **Dataset Designer**, with a key and infinity glyph depicting the one-to-many aspect of the relationship. By default, the name of the relationshipCommentEnd Id='1c8c78e19b7fa441' does not appear on the design surface.

 [!INCLUDE[note_settings_general](../includes/note-settings-general-md.md)]

#### To create a relationship between two data tables

1. Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](https://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).

2. Drag a **Relation** object from the **DataSet** toolbox onto the child data table in the relationship.

     The **Relation** dialog box opens, populating the **Child Table** box with the table that you dragged the **Relation** object onto.

3. Select the parent table from the **Parent Table** box. The parent table contains records on the "one" side of a one-to-many relationship.

4. Verify that the correct child table is displayed in the **Child Table** box. The child table contains records on the "many" side of a one-to-many relationship.

5. Type a name for the relationship in the **Name** box, or leave the default name based on the selected tables. This is the name of the actual <xref:System.Data.DataRelation> object in code.

6. Select the columns that join the tables in the **Key Columns** and **Foreign Key Columns** lists.

7. Select whether to create a relation, constraint, or both. For information, see [Introduction to DataRelation Objects](https://msdn.microsoft.com/library/89d8a881-8265-41f2-a88b-61311ab06192).

8. Select or clear the **Nested Relation** box. Selecting this option sets the <xref:System.Data.DataRelation.Nested%2A> property to `true`, and it causes the child rows of the relation to be nested within the parent column when those rows are written as XML data or synchronized with <xref:System.Xml.XmlDataDocument>. For more information, see [Nesting DataRelations](https://msdn.microsoft.com/library/9530f9c9-dd98-4b93-8cdb-40d7f1e8d0ab).

9. Set the rules to be enforced when you're making changes to records in these tables. For more information, see <xref:System.Data.Rule>.

10. Click **OK** to create the relationship. A relation line appears on the designer between the two tables.

#### To display a relation name in the Dataset Designer

1. Open your dataset in the **Dataset Designer**. For more information, see [How to: Open a Dataset in the Dataset Designer](https://msdn.microsoft.com/library/36fc266f-365b-42cb-aebb-c993dc2c47c3).

2. From the **Data** menu, select the **Show Relation Labels** command to display the relation name. Clear that command to hide the relation name.
