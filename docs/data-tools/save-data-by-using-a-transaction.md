---
title: 'How to: Save data by using a transaction'
description: Review how to save data by using a transaction with DataSet tools in Visual Studio. You save data in a transaction by using the System.Transactions namespace.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs:
- VB
- CSharp
helpviewer_keywords:
- saving data, using transactions
- System.Transactions namespace
- transactions, saving data
- data [Visual Studio], saving
ms.assetid: 8b835e8f-34a3-413d-9bb5-ebaeb87f1198
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
---
# How to: Save data by using a transaction

You save data in a transaction by using the <xref:System.Transactions> namespace. Use the <xref:System.Transactions.TransactionScope> object to participate in a transaction that is automatically managed for you.

Projects are not created with a reference to the *System.Transactions* assembly, so you need to manually add a reference to projects that use transactions.

The easiest way to implement a transaction is to instantiate a <xref:System.Transactions.TransactionScope> object in a `using` statement. (For more information, see [Using statement](/dotnet/visual-basic/language-reference/statements/using-statement), and [Using statement](/dotnet/csharp/language-reference/keywords/using-statement).) The code that runs within the `using` statement participates in the transaction.

To commit the transaction, call the <xref:System.Transactions.TransactionScope.Complete%2A> method as the last statement in the using block.

To roll back the transaction, throw an exception prior to calling the <xref:System.Transactions.TransactionScope.Complete%2A> method.

## To add a reference to the System.Transactions.dll

1. On the **Project** menu, select **Add Reference**.

2. On the **.NET** tab (**SQL Server** tab for SQL Server projects), select **System.Transactions**, and then select **OK**.

     A reference to *System.Transactions.dll* is added to the project.

## To save data in a transaction

- Add code to save data within the using statement that contains the transaction. The following code shows how to create and instantiate a <xref:System.Transactions.TransactionScope> object in a using statement:

     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb" id="Snippet11":::
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs" id="Snippet11":::

## See also

- [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
- [Walkthrough: Save data in a transaction](../data-tools/save-data-in-a-transaction.md)
