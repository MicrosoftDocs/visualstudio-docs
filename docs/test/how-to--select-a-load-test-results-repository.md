---
title: "How to: Select a Load Test Results Repository"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.test.load.dialog.connectstringmissing"
  - "vs.test.load.dialog.databaseconnectstring"
helpviewer_keywords: 
  - "load tests, results repository"
  - "results, load test"
  - "load test results, repository"
  - "Load Test Results Repository"
  - "SQL, Load Test Results Store"
ms.assetid: fa0c4dd9-612f-4a57-b8eb-458f129d9cda
caps.latest.revision: 36
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
# How to: Select a Load Test Results Repository
You are not limited to a local results store. Frequently, load tests are run on a remote set of Agent computers. Agents, together with a controller, can generate more simulated load than any single computer. For more information, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md).  
  
 Test results from your agents or your local computer can be saved to any SQL server on which you have created a load test results store. In either case, you must identify where you want to store your load test results by using the Administer Test Controllers window.  
  
 For more information about how to set up the SQL tables, see [How to: Create a Load Test Results Repository Using SQL](../test/how-to--create-a-load-test-results-repository-using-sql.md)  
  
 For more information about agents, see [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
### Identify a results store for load test data  
  
1.  In **Solution Explorer**, open your load test file.  
  
2.  From the **Load Test** toolbar, choose **Manage Test Controllers**. The Manage Test Controller dialog box is displayed. If you are using an agent remotely, you must select a controller.  
  
     ![Load test results store connection properties](../test/media/loadtestconnectionproperties.png "LoadTestConnectionProperties")  
Load test results store connection properties  
  
3.  In the **Load test results store**, click (…) to display the **Connection Properties** dialog box.  
  
4.  In **Server Name**, type the name of the server where you have run the `LoadTest` scripts.  
  
    > [!TIP]
    >  If you are using SQL Express on your local machine for the load test store, enter \<computername>\sqlexpress (for example, **MyComputer\sqlexpress**). [!INCLUDE[crdefault](../codequality/includes/crdefault_md.md)][How to: Create a Load Test Results Repository Using SQL](../test/how-to--create-a-load-test-results-repository-using-sql.md).  
  
5.  Under **Log on to the server**, you can choose **Use Windows Authentication**. You can specify the username and password, but if you do, you have to select the option **Save my password**.  
  
6.  Under **Connect to a database**, choose **Select or enter a database name**. Select **LoadTest** from the drop-down list box.  
  
7.  Choose **OK**. You can test the connection by choosing **Test Connection**.  
  
8.  Choose **Close** in the **Manage Test Controller** dialog box.  
  
## See Also  
 [Managing Load Test Results in the Load Test Results Repository](../test/managing-load-test-results-in-the-load-test-results-repository.md)   
 [How to: Create a Load Test Results Repository Using SQL](../test/how-to--create-a-load-test-results-repository-using-sql.md)   
 [Distributing Load Test Runs Across Multiple Test Machines Using Test Controllers and Test Agents](../test/distributing-load-test-runs-across-multiple-test-machines-using-test-controllers-and-test-agents.md)   
 [How to: Run a Load Test Using Test Controllers and Test Agents Specified in a Test Setting](../test_notintoc/how-to--run-a-load-test-using-test-controllers-and-test-agents-specified-in-a-test-setting.md)