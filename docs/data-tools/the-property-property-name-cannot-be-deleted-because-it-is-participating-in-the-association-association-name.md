---
title: Property participates in association
description: 'The property cannot be deleted because it is participating in the association. View information about this Object Relational Designer (O/R Designer) message.'
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: error-reference
ms.assetid: 389873cc-92dd-48da-bfca-0f6c8e0ae3c2
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
  - "data-storage"
---
# The property &lt;property name&gt; cannot be deleted because it is participating in the association &lt;association name&gt;

The selected property is set as the **Association Property** for the association between the classes indicated in the error message. Properties cannot be deleted if they are participating in an association between data classes.

Set the **Association Property** to a different property of the data class to enable successful deletion of the desired property.

## To correct this error

1. Select the association line on the **O/R Designer** that connects the data classes indicated in the error message.

2. Double-click the line to open the **Association Editor** dialog box.

3. Remove the property from the **Association Properties**.

4. Try to delete the property again.

## See also

- [LINQ to SQL tools in Visual Studio](../data-tools/linq-to-sql-tools-in-visual-studio2.md)