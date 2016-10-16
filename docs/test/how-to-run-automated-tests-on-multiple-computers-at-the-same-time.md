---
title: "How to run automated tests on multiple computers at the same time"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: a7db9d71-3e86-429a-b5e7-981b48d794d7
caps.latest.revision: 11
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
# How to run automated tests on multiple computers at the same time
If you have many automated tests to run from your test plan using [!INCLUDE[TCMext](../codequality/includes/tcmext_md.md)], you might want the automated tests in your test plan to run at the same time on multiple computers. This way the test run can take less time to complete. When you run automated tests from a test plan, the test controller for the environment that you use manages a set of test agents to run tests, as shown in the following illustration. To do this, you must set up your environment to include multiple machines for the role to run your tests, for example, a Client role. Additionally, you must use this environment in your test settings and then select the Client role to run the tests. This is shown in the following illustration where the Client role runs the tests. For more information about environments and test settings, see [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md).  
  
 ![Test Controller and Test Agents](../test/media/testagent_concepts.png "TestAgent_Concepts")  
  
 The test controller communicates with test agents to start tests, stop tests, track test agent status, and collect test results. When the test controller receives the tests for a test run, if there are more than 100 tests the test controller divides the tests into groups ready to be sent to a test agent machine. Each of these groups is called a *bucket*. The default bucket size is set to 100. To what agent the buckets are sent is based on the number of available machines in the role to run tests that was selected in the test settings. For example, if you have a test run of 250 tests, the test controller divides these into three buckets of tests with sizes of 100, 100 and 50. If there are three available test agents, the first bucket of 100 tests will be sent to agent1, the next bucket of 100 tests will be sent to agent2, and the remaining bucket of 50 tests will be sent to agent3.  
  
> [!NOTE]
>  You cannot change the default bucket size when you are running tests from a test plan.  
  
 When the test agent notifies the test controller that it has completed the bucket of tests, the test controller sends the test agent the next bucket of tests based on the buckets that are remaining. For example, if you have a test run of 600 tests then the test controller divides this into 6 buckets of 100 tests each. If you have three available agents, one bucket of 100 tests will initially be sent to each agent. When an agent has completed these tests, the test controller will send the agent the next bucket of 100 tests from the remaining 3 buckets.  
  
 If you have less than 100 tests (the default bucket size) in a test run, this is considered a partial bucket. In this case the test controller divides the tests in the run based on the value of the minimum number of tests per agent. This value is 10. For example, if you have 27 tests in your test run and three available test agents, the first 10 tests will be sent to agent1, the next 10 tests will be sent to agent2, and the remaining 7 tests will be sent to agent3. The test controller also tries to divide the tests in a partial bucket evenly. If you have 33 tests in your test run and three available test agents, each test agent will get 11 tests.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
> [!WARNING]
>  If you have 10 tests or less for the test run from your test plan, these tests will only be sent to one agent to run the tests even if you have multiple agents available in your environment.  
  
> [!IMPORTANT]
>  You cannot control which tests run on a specific machine in your environment for a test run. If you need to run some of your automated tests on different test configurations, you cannot do this with one test run. You can create different environment to use for each of the test runs. You can start test runs for multiple environments at the same time and your automated tests will run on the machines for each different environment at the same time.  
  
### Run Automated Tests on Multiple Computers at the Same Time  
  
1.  Create an environment including multiple machines in the same role that will be used to run tests. For more information about how to create an environment, see [Standard lab environments](../test/standard-lab-environments.md) or [SCVMM (virtual) environments](../test/scvmm--virtual--environments.md).  
  
2.  Create a test settings that has the same roles as this environment and uses this role with multiple machines as the role to run tests. For more information about how to create test settings, see [Collect more diagnostic data](../test/collect-more-diagnostic-data-in-manual-tests.md).  
  
3.  Start the test run using the test settings and the environment that you created.  
  
     You will see that the test agents are now all busy running tests.  
  
## See Also  
 [Setting Up Test Machines to Run Tests or Collect Data](../test/setting-up-test-machines-to-run-tests-or-collect-data.md)   
 [Standard lab environments](../test/standard-lab-environments.md)   
 [Creating an SCVMM Environment Using Stored Virtual Machines and Templates](../test/creating-an-scvmm-environment-using-stored-virtual-machines-and-templates.md)   
 [Running Automated Tests in Microsoft Test Manager](assetId:///0632f265-63fe-4859-a413-9bb934c66835)