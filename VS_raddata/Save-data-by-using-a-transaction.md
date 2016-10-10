---
title: "Save data by using a transaction"
ms.custom: na
ms.date: 10/07/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - aspx
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8b835e8f-34a3-413d-9bb5-ebaeb87f1198
caps.latest.revision: 13
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Save data by using a transaction
You save data in a transaction by using the <xref:System.Transactions?qualifyHint=False> namespace. Use the <xref:System.Transactions.TransactionScope?qualifyHint=False> object to participate in a transaction that is automatically managed for you.  
  
 Projects are not created with a reference to the System.Transactions assembly, so you need to manually add a reference to projects that use transactions.  
  
> [!NOTE]
>  The <xref:System.Transactions?qualifyHint=False> namespace is supported in Windows 2000 or later.  
  
 The easiest way to implement a transaction is to instantiate a <xref:System.Transactions.TransactionScope?qualifyHint=False> object in a `using` statement. (For more information, see [Using Statement](../Topic/Using%20Statement%20\(Visual%20Basic\).md), and [using Statement](../Topic/using%20Statement%20\(C%23%20Reference\).md).) The code that runs within the `using` statement participates in the transaction.  
  
 To commit the transaction, call the <xref:System.Transactions.TransactionScope.Complete?qualifyHint=False> method as the last statement in the using block.  
  
 To roll back the transaction, throw an exception prior to calling the <xref:System.Transactions.TransactionScope.Complete?qualifyHint=False> method.  
  
 For more information, see [Save data in a transaction](../VS_raddata/Save-data-in-a-transaction.md).  
  
### To add a reference to the System.Transactions dll  
  
1.  On the **Project** menu, select **Add Reference**.  
  
2.  On the **.NET** tab (**SQL Server** tab for SQL Server projects), select **System.Transactions**, and thenselect**OK**.  
  
     A reference to System.Transactions.dll is added to the project.  
  
### To save data in a transaction  
  
-   Add code to save data within the using statement that contains the transaction. The following code shows how to create and instantiate a <xref:System.Transactions.TransactionScope?qualifyHint=False> object in a using statement:  
  
     [!CODE [VbRaddataSaving#11](../CodeSnippet/VS_Snippets_VBCSharp/VbRaddataSaving#11)]  
  
## See Also  
 [Save data back to the database](../VS_raddata/Save-data-back-to-the-database.md)