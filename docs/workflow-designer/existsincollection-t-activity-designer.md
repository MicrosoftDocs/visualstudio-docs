---
title: ExistsInCollection&lt;T&gt; Activity Designer
description: Learn how you can use the ExistsInCollection <T> activity designer in Workflow Designer to create and configure an ExistsInCollection <T> activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.ExistsInCollection`1.UI"
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# ExistsInCollection\<T> Activity Designer

The **ExistsInCollection\<T>** activity designer is used to create and configure an <xref:System.Activities.Statements.ExistsInCollection%601> activity.

## The ExistsInCollection\<T> Activity

The <xref:System.Activities.Statements.ExistsInCollection%601> activity determines whether a specified item exists in a particular collection.

### Using the ExistsInCollection\<T> Activity Designer

The **ExistsInCollection\<T>** activity designer can be found in the **Collection** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of Workflow Designer. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

The **ExistsInCollection\<T>** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are usually placed, such as inside a <xref:System.Activities.Statements.Sequence>. This creates a <xref:System.Activities.Statements.ExistsInCollection%601> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of ExistsInCollection<Int32\>. (By default, the *TypeArgument* is **Int32**. It can be changed in the property grid.)  The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **ExistsInCollection<T\>** activity designer or in the **DisplayName** box of the property grid. The other properties must be edited on the property grid.

### The ExistsInCollection\<T> Properties

The following table shows the <xref:System.Activities.Statements.ExistsInCollection%601> properties and describes how they are used in the designer:

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|The friendly name of the <xref:System.Activities.Statements.ExistsInCollection%601> activity. The default is ExistsInCollection<Int32\>. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.ExistsInCollection%601.Item%2A>|True|The item to look for in the Collection\<T>. This item is of type *T*, which is of type *TypeArgument*. To specify the item, type a Visual Basic expression in the property grid.|
|<xref:System.Activities.Statements.ExistsInCollection%601.Collection%2A>|True|The collection in which to check if the item exists. This collection is of type **ICollection<TypeArgument\>.** To specify the collection, type a Visual Basic expression in the property grid.|
|*TypeArgument*|True|The type T of the items contained in the <xref:System.Collections.Generic.ICollection%601>. By default, this *TypeArgument* type is set to **Int32**. To change the type, change the value of the *TypeArgument* in the combo box in the property grid.|
|<xref:System.Activities.Activity%601.Result%2A>|False|A value that indicates whether the specified item exists in the collection. To specify a variable to bind to the result, type a Visual Basic variable in the property grid.|

## See also

- [Collection](../workflow-designer/collection-activity-designers.md)
- [AddToCollection\<T>](../workflow-designer/addtocollection-t-activity-designer.md)
- [ClearCollection\<T>](../workflow-designer/clearcollection-t-activity-designer.md)
- [RemoveFromCollection\<T>](../workflow-designer/removefromcollection-t-activity-designer.md)