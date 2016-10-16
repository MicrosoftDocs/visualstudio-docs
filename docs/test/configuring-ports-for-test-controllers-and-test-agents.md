---
title: "Configuring Ports for Test Controllers and Test Agents"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "firewalls, configuring for test agents"
  - "firewalls, configuring for test controllers"
  - "test agents, firewalls"
  - "test controllers, firewalls"
  - "agents, firewalls"
  - "controllers, firewalls"
ms.assetid: 211edbd7-9fe4-4251-ba85-8bec4363261b
caps.latest.revision: 13
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
# Configuring Ports for Test Controllers and Test Agents
You can change the default incoming ports used by the test controller, the test agent, and the client. This might be necessary if you are trying to use the test controller, the test agent, or the client together with some other software that conflicts with the port settings. Another reason to change the ports is due to the firewall restriction between the test controller and the client. In this case you might want to manually configure the port to accommodate enabling it for a firewall so that the test controller can send results to the client.  
  
 The following illustration shows the connection points between the test controller, test agent and the client. It outlines which ports are used for incoming and outgoing connections as well as security restrictions used on these ports.  
  
 ![Test contoller and test agent ports and security](../test/media/testcontrolleragentfirewall.png "TestControllerAgentFirewall")  
  
 The technology used to connect remote test execution components is .NET Remoting over TCP ports. For more information, see [.NET Remoting](http://go.microsoft.com/fwlink/?LinkId=190617).  
  
-   **Incoming connections** The default port used by the test controller is 6901 and the test agent's default port is 6910. The client uses a random port by default which is used to receive the test results from the test controller. For all incoming connections, the test controller authenticates the calling party and verifies that it belongs to specific security group.  
  
    -   **Test Controller** Incoming connections are on TCP port 6901. If you need to, you can configure the incoming port. For more information, see [Configuring the Incoming Ports](#ConfigurePorts).  
  
         The test controller needs to be able to make outgoing connection to test agents and to the client.  
  
        > [!NOTE]
        >  The test controller needs incoming **File and Printer sharing** connection open.  
  
    -   **Test Agent** Incoming connections are on TCP port 6910. If you need to, you can configure the incoming port. For more information, see [Configuring the Incoming Ports](#ConfigurePorts).  
  
         The test agent needs to be able to make outgoing connection to the test controller.  
  
    -   **Client** By default, a random TCP port is used for incoming connections. If you need to, you can configure the incoming port. For more information, see [Configuring the Incoming Ports](#ConfigurePorts).  
  
         You might get firewall notifications when the test controller tries to connect to the client the first time.  
  
         On [!INCLUDE[winsvr08](../test/includes/winsvr08_md.md)] the firewall notifications are disabled by default and you must manually add Firewall exceptions for Client programs (devenv.exe, mstest.exe, mlm.exe) so that it can accept incoming connections.  
  
-   **Outgoing connections** Random TCP ports are used for all outgoing connections.  
  
    -   **Test Controller** The test controller needs to be able to make outgoing connection to Agents and to the Client.  
  
    -   **Test Agent** The test agent needs to be able to make outgoing connection to Controller.  
  
    -   **Client** The client needs to be able to make outgoing connection to Controller.  
  
 For more information, including security issues for test controllers and test agents, see [Troubleshooting Guide for Visual Studio Test Controller and Agent](http://go.microsoft.com/fwlink/?LinkId=190594).  
  
##  <a name="ConfigurePorts"></a> Configuring the Incoming Ports  
 Follow these directions to configure the ports for a test controller and test agents.  
  
-   **Controller Service** Modify the port's value by editing the \<drive letter:>\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\QTCcontroller.exe.config file:  
  
    ```  
    <appSettings>  
      <add key="ControllerServicePort" value="6901"/>  
    </appSettings>  
    ```  
  
-   **Agent Service** Modify the port by editing the \<drive letter:>\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\QTAgentService.exe.config file:  
  
    ```  
    <appSettings>  
      <add key="AgentServicePort" value="6910"/>  
    </appSettings>  
    ```  
  
-   **Client** Use the registry editor to add the following registry (DWORD) values. The client will use one of the ports from the specified range for receiving data from the test controller:  
  
     HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\VisualStudio\12.0\EnterpriseTools\QualityTools\ListenPortRange\PortRangeStart  
  
     HKEY_LOCAL_MACHINE\SOFTWARE\MICROSOFT\VisualStudio\12.0\EnterpriseTools\QualityTools\ListenPortRange\PortRangeEnd  
  
## See Also  
 [Install and configure test agents](../test/install-and-configure-test-agents.md)