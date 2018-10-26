---
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
To configure the remote tools, you must have administrator permissions on the remote computer.  
  
1. On the remote computer, right-click the Remote Debugger (*msvsmon.exe*) and select **Run as administrator**. 
   There may be different versions of *msvsmon.exe* in *x64*, *x32*, or other folders. Make sure to start the version you need to debug your app. 
   
1. The first time you start the remote debugger (or before you have configured it), the **Remote Debugging Configuration** dialog box appears.  
  
    ![RemoteDebuggerConfWizardPage](../media/remotedebuggerconfwizardpage.png "RemoteDebuggerConfWizardPage")  
  
1. If the Windows Service API is not installed, which happens only on Windows Server 2008 R2, select the **Install** button.  
  
1. Select at least one network type you want to use the remote tools on. If the computers are connected through a domain, you must choose the first item. If the computers are connected through a workgroup or homegroup, choose the second or third item as appropriate.  
  
1. Choose **Configure remote debugging** to configure the firewall and start the remote debugging tool.  
  
1. When configuration is complete, the Remote Debugger window appears.
  
    ![RemoteDebuggerWindow](../media/remotedebuggerwindow.png "RemoteDebuggerWindow")
  
    The remote debugger is now waiting for a connection. Use the server name and port number shown to set the remote connection configuration in Visual Studio.  
  
   To stop the remote debugger, click **File > Exit**. You can restart it from the **Start** menu, or from the command line:  
  
   *\<Remote debugger installation directory>\\msvsmon.exe*  
