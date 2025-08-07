---
title: "Workflow Designer - ClearCollection&lt;T&gt; Activity Designer"
description: Learn how you can use the ClearCollection <T> activity designer to create and configure a ClearCollection <T> activity.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
  - "System.Activities.Statements.ClearCollection`1.UI"
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# ClearCollection\<T> Activity Designer

The **ClearCollection\<T>** activity designer is used to create and configure a <xref:System.Activities.Statements.ClearCollection%601> activity.

## The ClearCollection\<T> Activity

The <xref:System.Activities.Statements.ClearCollection%601> activity clears a specified collection of all items.

### Using the ClearCollection\<T> Activity Designer

The **ClearCollection\<T>** activity designer can be found in the **Collection** category of the **Toolbox**, which is accessed by clicking the **Toolbox** tab of the Workflow Designer. Alternatively, select **Toolbox** from the **View** menu, or press **Ctrl**+**Alt**+**X**.

The **ClearCollection\<T>** activity designer can be dragged from the **Toolbox** and dropped on to the Workflow Designer surface wherever activities are placed, such as inside a <xref:System.Activities.Statements.Sequence>. Dropping the activity designer creates a <xref:System.Activities.Statements.ClearCollection%601> activity with a default <xref:System.Activities.Activity.DisplayName%2A> of ClearCollection<Int32\>. (By default, the *TypeArgument* is **Int32**. TypeArgument can be changed in the property grid.) The <xref:System.Activities.Activity.DisplayName%2A> value can be edited in the header of the **ClearCollection<T\>** activity designer or in the **DisplayName** box of the property grid. The other properties must be edited on the property grid.

### The ClearCollection\<T> Properties

The following table shows the <xref:System.Activities.Statements.ClearCollection%601> properties and describes how they are used in the designer.

|Property Name|Required|Usage|
|-|--------------|-|
|<xref:System.Activities.Activity.DisplayName%2A>|False|Specifies the optional friendly name of the <xref:System.Activities.Statements.ClearCollection%601> activity. The default is ClearCollection<Int32\>. Although the <xref:System.Activities.Activity.DisplayName%2A> value is not strictly required, it is a best practice to use one.|
|<xref:System.Activities.Statements.ClearCollection%601.Collection%2A>|True|Specifies the collection to be cleared of items. This collection is of type **ICollection\<TypeArgument>.** To specify the collection, type a Visual Basic expression in the property grid.|
|*TypeArgument*|True|Specifies the type T of the items contained in the <xref:System.Collections.Generic.ICollection%601>. By default, this *TypeArgument* type is set to **Int32**. To change the type, change the value of the *TypeArgument* in the combo box in the property grid.|

## See also

- [Collection](../workflow-designer/collection-activity-designers.md)
- [AddToCollection\<T>](../workflow-designer/addtocollection-t-activity-designer.md)
- [ExistsInCollection\<T>](../workflow-designer/existsincollection-t-activity-designer.md)
- [RemoveFromCollection\<T>](../workflow-designer/removefromcollection-t-activity-designer.md)