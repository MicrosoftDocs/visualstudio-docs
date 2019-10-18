---
title: "Save data by using a transaction | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-data-tools
ms.topic: conceptual
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords:
  - "saving data, using transactions"
  - "System.Transactions namespace"
  - "transactions, saving data"
  - "data [Visual Studio], saving"
ms.assetid: 8b835e8f-34a3-413d-9bb5-ebaeb87f1198
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# Save data by using a transaction
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You save data in a transaction by using the <xref:System.Transactions> namespace. Use the <xref:System.Transactions.TransactionScope> object to participate in a transaction that is automatically managed for you.

 Projects are not created with a reference to the System.Transactions assembly, so you need to manually add a reference to projects that use transactions.

> [!NOTE]
> The <xref:System.Transactions> namespace is supported in Windows 2000 or later.

 The easiest way to implement a transaction is to instantiate a <xref:System.Transactions.TransactionScope> object in a `using` statement. (For more information, see [Using Statement](https://msdn.microsoft.com/library/665d1580-dd54-4e96-a9a9-6be2a68948f1), and [using Statement](https://msdn.microsoft.com/library/afc355e6-f0b9-4240-94dd-0d93f17d9fc3).) The code that runs within the `using` statement participates in the transaction.

 To commit the transaction, call the <xref:System.Transactions.TransactionScope.Complete%2A> method as the last statement in the using block.

 To roll back the transaction, throw an exception prior to calling the <xref:System.Transactions.TransactionScope.Complete%2A> method.

 For more information, see [Save data in a transaction](../data-tools/save-data-in-a-transaction.md).

### To add a reference to the System.Transactions dll

1. On the **Project** menu, select **Add Reference**.

2. On the **.NET** tab (**SQL Server** tab for SQL Server projects), select **System.Transactions**, and then select **OK**.

     A reference to System.Transactions.dll is added to the project.

### To save data in a transaction

- Add code to save data within the using statement that contains the transaction. The following code shows how to create and instantiate a <xref:System.Transactions.TransactionScope> object in a using statement:

     [!code-csharp[VbRaddataSaving#11](../snippets/csharp/VS_Snippets_VBCSharp/VbRaddataSaving/CS/Form2.cs#11)]
     [!code-vb[VbRaddataSaving#11](../snippets/visualbasic/VS_Snippets_VBCSharp/VbRaddataSaving/VB/Form2.vb#11)]

## See Also
 [Save data back to the database](../data-tools/save-data-back-to-the-database.md)
