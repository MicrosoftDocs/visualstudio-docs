---
title: "Save data by using a transaction"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
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
caps.latest.revision: 13
ms.author: "mblome"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Save data by using a transaction
You save data in a transaction by using the \<xref:System.Transactions> namespace. Use the \<xref:System.Transactions.TransactionScope> object to participate in a transaction that is automatically managed for you.  
  
 Projects are not created with a reference to the System.Transactions assembly, so you need to manually add a reference to projects that use transactions.  
  
> [!NOTE]
>  The \<xref:System.Transactions> namespace is supported in Windows 2000 or later.  
  
 The easiest way to implement a transaction is to instantiate a \<xref:System.Transactions.TransactionScope> object in a `using` statement. (For more information, see [Using Statement](../Topic/Using%20Statement%20\(Visual%20Basic\).md), and [using Statement](../Topic/using%20Statement%20\(C%23%20Reference\).md).) The code that runs within the `using` statement participates in the transaction.  
  
 To commit the transaction, call the \<xref:System.Transactions.TransactionScope.Complete*> method as the last statement in the using block.  
  
 To roll back the transaction, throw an exception prior to calling the \<xref:System.Transactions.TransactionScope.Complete*> method.  
  
 For more information, see [Save data in a transaction](../datatools/save-data-in-a-transaction.md).  
  
### To add a reference to the System.Transactions dll  
  
1.  On the **Project** menu, select **Add Reference**.  
  
2.  On the **.NET** tab (**SQL Server** tab for SQL Server projects), select **System.Transactions**, and thenselect**OK**.  
  
     A reference to System.Transactions.dll is added to the project.  
  
### To save data in a transaction  
  
-   Add code to save data within the using statement that contains the transaction. The following code shows how to create and instantiate a \<xref:System.Transactions.TransactionScope> object in a using statement:  
  
     [!code[VbRaddataSaving#11](../datatools/codesnippet/VisualBasic/save-data-by-using-a-transaction_1.vb)]
[!code[VbRaddataSaving#11](../datatools/codesnippet/CSharp/save-data-by-using-a-transaction_1.cs)]  
  
## See Also  
 [Save data back to the database](../datatools/save-data-back-to-the-database.md)