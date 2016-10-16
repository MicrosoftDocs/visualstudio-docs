---
title: "How to: Create a Load Test Results Repository Using SQL"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.load.dialog.databasesetup"
helpviewer_keywords: 
  - "load tests, results repository"
  - "results, load test"
  - "load test results, repository"
  - "Load Test Results Repository"
  - "SQL, Load Test Results Store"
ms.assetid: b1efe736-c2d1-4f04-a9d0-ce9dc13ecc86
caps.latest.revision: 63
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# How to: Create a Load Test Results Repository Using SQL
Results of load tests are stored in a SQL database. The SQL database is called the Load Test Results Store. It can be local, typically using SQL Express, or remote, using any version of SQL. After the database schema is created, you can save the load test results to the database.  
  
 One option is to create the database tables on a local server that is running SQL Express. You only have to run the scripts one time for your local Load Test Results Store to be the global setting for all load tests.  
  
 For a controller, setup creates a default local instance of SQL Express and the Load Test Results Store and configures it for use by the controller. For any setup that does not use a remote machine, the database is created on the first run of a load test. You need to configure a separate and different Results Store if you want to use a database on a more powerful SQL Server. You can later mine the data mined by additional users. For more information, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### To set up a computer running SQL  
  
1.  Open a Visual Studio Command prompt. Type the following text:  
  
     On a 32-bit version of Windows type: `cd “c:\Program Files\Microsoft Visual Studio 12.0\Common7\IDE”`  
  
     -or-  
  
     On a 64-bit version of Windows type: `cd “c:\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE”`  
  
2.  In that folder, type the following text:  
  
    -   **SQL Express:** `SQLCMD /S localhost\sqlexpress /i loadtestresultsrepository.sql`  
  
    -   **SQL:** You can install the database to any existing SQL server. For example, if you had a SQL server named `ContosoServer1` you would use the following command:  
  
         `SQLCMD /S ContosoServer1 -i loadtestresultsrepository.sql`  
  
    > [!CAUTION]
    >  The parameters are case sensitive. You must type uppercase S and lowercase i.  
  
     You might also need to specify a user name and password so that you can connect to `ContosoServer1`. If so, you would use the following command:  
  
     `SQLCMD /S ContosoServer1 -U <user name> -P <password> -i loadtestresultsrepository.sql`  
  
    > [!CAUTION]
    >  The parameters are case sensitive. You must type uppercase S, U, and P, and lowercase i.  
  
3.  On the **Load Test** toolbar, choose **Manage Test Controllers**. The **Manage Test Controllers** dialog box is displayed.  
  
4.  In the **Load Test Results Connection String,** click the browse button (…) to display the **Connection Properties** dialog box.  
  
    > [!NOTE]
    >  If you change the connection string for a controller, then you must select the controller.  
  
5.  In **Server Name**, type `localhost\sqlexpress` or the name of the server that you used in step 2 such as `ContosoServer1`.  
  
6.  Under **Log on to the server**, choose **Use Windows Authentication**.  
  
7.  Under **Connect to a database**, choose **Select or enter a database name**. Select **LoadTest** from the drop-down list box.  
  
8.  Choose **OK**.  
  
9. Choose **Close** in the **Administer Test Controller** dialog box.  
  
## See Also  
 [Managing Load Test Results in the Load Test Results Repository](../test/managing-load-test-results-in-the-load-test-results-repository.md)   
 [How to: Select a Load Test Results Repository](../test/how-to--select-a-load-test-results-repository.md)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)