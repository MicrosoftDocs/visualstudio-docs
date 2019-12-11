---
title: "Type Collection Editor Dialog Box | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
f1_keywords:
  - "TypeCollectionEditor.UI"
ms.assetid: 63cdea6b-bca2-4c06-b8b4-c8faabd40726
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# Type Collection Editor Dialog Box
The **Type Collection Editor** dialog box is used to add known types to the **Send** and **Receive** activities. This dialog is also used to add generic type arguments to the **InvokeMethod** activity. When used for the **Send** and **Receive** activities to add known types, the **Type Collection Editor** dialog box requires the type additions to be unique. If a duplicate type is added and the change is committed by clicking **OK**, an error message is returned. When used for the **InvokeMethod** activity to add generic type arguments, the **Type Collection Editor** dialog box allows the addition of duplicate types.

> [!NOTE]
> [!INCLUDE[crabout](../includes/crabout-md.md)] known types, see [Data Contract Known Types](https://msdn.microsoft.com/library/1a0baea1-27b7-470d-9136-5bbad86c4337).

 The following table describes the user interface (UI) elements of the **Type Collection** dialog box.

|UI Element|Description|
|----------------|-----------------|
|**Type List**|A list of the types that have been added or removed.|

## To bring up the Type Collection Editor

#### To bring up the Type Collection Editor for the Send and Receive activities

1. Select the **Send** or **Receive** activity in the design view.

2. Press **F4** to bring up the **Properties** window.

3. In the **Properties** window, click the ellipsis button next to the **KnownTypes** property.

#### To bring up the Type Collection Editor for the InvokeMethod activity

1. Select the **InvokeMethod** activity in the design view.

2. Press **F4** to bring up the **Properties** window.

3. In the **Properties** window, click the ellipsis button next to the **GenericTypeArguments** property.