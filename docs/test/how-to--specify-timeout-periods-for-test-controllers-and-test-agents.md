---
title: "How to: Specify Timeout Periods for Test Controllers and Test Agents"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "agents, configuring"
  - "agetns, timeouts"
  - "controllers, configuring"
  - "controllers, timeouts"
ms.assetid: 777d0db5-0073-458a-a2a3-58b1c1f24c60
caps.latest.revision: 9
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
# How to: Specify Timeout Periods for Test Controllers and Test Agents
Both the test controller and the test agent have several timeout settings that specify how long they should wait for responses from one another, or from a data source before failing with an error. Under certain circumstances, it might be necessary to edit the timeout values to meet the needs of your topology or other environment issues. To edit the timeout values, edit the XML configuration file that is associated with either the test controller or test agent, as covered in the following procedures.  
  
 To edit a test controller or a test agent’s various timeout settings, modify the following configuration files using the key names and values in the tables:  
  
-   Test controller: QTController.exe.config  
  
    |Key name|Description|Value|  
    |--------------|-----------------|-----------|  
    |AgentConnectionTimeoutInSeconds|Number of seconds to wait for agent ping request before connection is considered lost.|"n" seconds.|  
    |AgentSyncTimeoutInSeconds|When you start a synchronizing test run, number of seconds to wait for all agents to sync before aborting the run.|"n" seconds.|  
    |AgentInitializeTimeout|Number of seconds to wait for all agents and their data collectors to initialize at the beginning of a test run, before aborting the test run. This value should be reasonably large if using data collectors.|"n" seconds. Default: "120" (two minutes).|  
    |AgentCleanupTimeout|Number of seconds to wait for all agents and their data collectors to clean up, before completing the test run. This value should be reasonably large if using data collectors.|"n" seconds. Default: "120" (two minutes).|  
  
-   Test Agent: QTAgentService.exe.config  
  
    |Key name|Description|Value|  
    |--------------|-----------------|-----------|  
    |ControllerConnectionPeriodInSeconds|Number of seconds between attempts to connect to the controller.|"n" seconds. Default: "30" (thirty seconds).|  
    |RemotingTimeoutSeconds|Maximum time a remoting call can last in seconds.|"n" seconds. Default: "600" (ten minutes).|  
    |StopTestRunCallTimeoutInSeconds|Number of seconds to wait for call to stop the test run.|"n" seconds. Default: "120" (two minutes).|  
    |GetCollectorDataTimeout|Number of seconds to wait for the data collector.|"n" seconds. Default: "300" (five minutes).|  
  
#### To Specify Agent Timeout Options for a Test Controller  
  
1.  Open the QTCcontroller.exe.config XML configuration file located in \<drive letter:>\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\\.  
  
2.  locate `<appSettings>` tag.  
  
    ```  
  
    <appSettings>  
      <add key="LogSizeLimitInMegs" value="20"/>  
      <add key="AgentConnectionTimeoutInSeconds" value="120"/>  
      <add key="AgentSyncTimeoutInSeconds" value="300"/>  
      <add key="ControllerServicePort" value="6901"/>  
      <add key="ControllerUsersGroup" value="TeamTestControllerUsers"/>  
      <add key="ControllerAdminsGroup" value="TeamTestControllerAdmins"/>  
      <add key="CreateTraceListener" value="no"/>  
    </appSettings>  
    ```  
  
3.  Edit an existing value for one of the test controller’s timeout keys. For example, you can change the default value for the key `AgentConnectionTimeoutInSeconds` from two minutes to three minutes:  
  
    ```  
  
    <add key="AgentConnectionTimeoutInSeconds" value="180"/>  
  
    ```  
  
     -or-  
  
     Add an additional key and specify a timeout value. For example, you can add the `AgentInitializeTimeout` key in the `<appSettings>` section and specify a value of five minutes:  
  
    ```  
  
            <add key="AgentInitializeTimeout" value="300"/>  
    </appSettings>  
  
    ```  
  
#### To Specify Agent Timeout Options for a Test Agent  
  
1.  Open the QTAgentService.exe.config XML configuration file located in \<drive letter:>\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\\.  
  
2.  locate `<appSettings>` tag.  
  
    ```  
  
    <appSettings>  
      <appSettings>  
      <add key="LogSizeLimitInMegs" value="20"/>  
      <add key="AgentServicePort" value="6910"/>  
      <add key="ControllerConnectionPeriodInSeconds" value="30"/>  
      <add key="StopTestRunCallTimeoutInSeconds" value="120"/>  
      <add key="CreateTraceListener" value="no"/>  
      <add key="GetCollectorDataTimeout" value="300"/>  
    </appSettings>  </appSettings>  
    ```  
  
3.  Edit an existing value for one of the test agent’s timeout keys. For example, you can change the default value for the key `ControllerConnectionPeriodInSeconds` from thirty seconds to one minute:  
  
    ```  
  
    <add key="ControllerConnectionPeriodInSeconds" value="60"/>  
  
    ```  
  
     -or-  
  
     Add an additional key and specify a timeout value. For example, you can add the `RemotingTimeoutSeconds` key in the `<appSettings>` section and specify a value of fifteen minutes:  
  
    ```  
  
            <add key=" RemotingTimeoutSeconds " value="900"/>  
    </appSettings>  
  
    ```  
  
## See Also  
 [Install and configure test agents](../test/install-and-configure-test-agents.md)   
 [Modifying Load Test Logging Settings](../test/modifying-load-test-logging-settings.md)   
 [Configuring Ports for Test Controllers and Test Agents](../test/configuring-ports-for-test-controllers-and-test-agents.md)   
 [How to: Specify the Maximum Size for the Log File](../test/how-to--specify-the-maximum-size-for-the-log-file.md)   
 [How to: Bind a Test Controller or Test Agent to a Network Adapter](../test/how-to--bind-a-test-controller-or-test-agent-to-a-network-adapter.md)