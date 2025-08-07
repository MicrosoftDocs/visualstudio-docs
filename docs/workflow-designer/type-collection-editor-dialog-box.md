---
title: Workflow Designer - Type Collection Editor Dialog Box
description: Learn how you can use the Type Collection Editor dialog box to add known types to the Send and Receive activities.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- TypeCollectionEditor.UI
author: sayedihashimi
author: sayedha
manager: timheuer
ms.subservice: workflow-designer
---
# Type Collection Editor Dialog Box

The **Type Collection Editor** dialog box is used to add known types to the **Send** and **Receive** activities. This dialog is also used to add generic type arguments to the **InvokeMethod** activity. When used for the **Send** and **Receive** activities to add known types, the **Type Collection Editor** dialog box requires the type additions to be unique. If a duplicate type is added and the change is committed by clicking **OK**, an error message is returned. When used for the **InvokeMethod** activity to add generic type arguments, the **Type Collection Editor** dialog box allows the addition of duplicate types.

For more information, see [Data contract known types](/dotnet/framework/wcf/feature-details/data-contract-known-types).

The following table describes the user interface (UI) elements of the **Type Collection** dialog box.

|UI Element|Description|
|-|-----------------|
|**Type List**|A list of the types that have been added or removed.|

## To bring up the Type Collection Editor for the Send and Receive activities

1. Select the **Send** or **Receive** activity in the design view.

2. Press **F4** to bring up the **Properties** window.

3. In the **Properties** window, click the ellipsis button next to the **KnownTypes** property.

## To bring up the Type Collection Editor for the InvokeMethod activity

1. Select the **InvokeMethod** activity in the design view.

2. Press **F4** to bring up the **Properties** window.

3. In the **Properties** window, click the ellipsis button next to the **GenericTypeArguments** property.
