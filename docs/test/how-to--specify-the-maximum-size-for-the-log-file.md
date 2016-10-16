---
title: "How to: Specify the Maximum Size for the Log File"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "load tests, logging"
ms.assetid: 417059bf-37ae-4e7a-b9b0-29bd71f1414f
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
# How to: Specify the Maximum Size for the Log File
By default, the maximum size of the log file that is used for load tests is set to 20 megabytes. You can optionally change this value by editing the configuration file associated with the controller service.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
#### Specifying the Maximum Log File Size for Load Test  
  
1.  Open the QTCcontroller.exe.config XML configuration file located in \<drive letter:>\Program Files (x86)\Microsoft Visual Studio 12.0\Common7\IDE\QTCcontroller.exe.config.  
  
2.  Locate `<add key="LogSizeLimitInMegs" value="20"/>` entry under the `<appSettings>` tag.  
  
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
  
3.  Modify `value ="20"` to the maximum allowable size you want to specify for the log file.  
  
    > [!NOTE]
    >  Entering a value of "0" specifies that the log file is only limited in size by available disk space.  
  
## See Also  
 [Modifying Load Test Logging Settings](../test/modifying-load-test-logging-settings.md)   
 [Configuring Ports for Test Controllers and Test Agents](../test/configuring-ports-for-test-controllers-and-test-agents.md)