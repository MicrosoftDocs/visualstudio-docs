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
You must have administrative permissions on the remote computer.  
  
1.  Locate the Remote Debugger application. (Open the Start menu and search for **Remote Debugger**.)
  
     If you are running the remote debugger on a  remote server, you can right-click the Remote Debugger app and choose **Run as administrator** (Or, you can [run the remote debugger as a service](../../debugger/remote-debugging.md#bkmk_configureService)). If you are not running it on a remote server, just start it normally.
  
3.  When you start the remote tools for the first time (or before you have configured it), the **Remote Debugging Configuration** dalog box appears.  
  
     ![RemoteDebuggerConfWizardPage](../debugger/includes/media/remotedebuggerconfwizardpage.png "RemoteDebuggerConfWizardPage")  
  
4.  If the Windows Service API is not installed (which happens only on Windows Server 2008 R2), choose the **Install** button.  
  
5.  Select the network types you want use the remote tools on. At least one network type must be selected. If the computers are connected through a domain, you must choose the first item. If the computers are connected through a workgroup or homegroup, you need to choose the second or third item as appropriate.  
  
6.  Choose **Configure remote debugging** to configure the firewall and start the tool.  
  
7.  When configuration is complete, the Remote Debugger window appears.
  
     ![RemoteDebuggerWindow](../debugger/includes/media/remotedebuggerwindow.png "RemoteDebuggerWindow")
  
     The remote debugger is now waiting for a connection. Make a note of the server name and port number that is displayed, because you will need this later for configuration in Visual Studio.  
  
 When you are finished debugging and need to stop the remote debugger, click **File / Exit** on the window. You can restart it from the **Start** menu or from the command line:  
  
 **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger\\<x86, x64, or Appx\msvsmon.exe**.  
  
### Configure the remote debugger  
 You can change some aspects of the configuration of the remote debugger after you have started it for the first time.
  
-   To enable other users to connect to the remote debugger, choose **Tools / Permissions**. You must have administrator privileges to grant or deny permissions.

     > [!IMPORTANT] 
     > You can run the remote debugger under a user account that differs from the user account you are using on the Visual Studio computer, but you must add the different user account to the remote debugger's permissions. 

     Alternatively, you can start the remote debugger from the command line with the **/allow \<username>** parameter: **msvsmon /allow \<username@computer>**.
  
-   To change the Authentication mode or the port number, or to specify a timeout value for the remote tools: choose **Tools / Options**.  
  
     For a listing of the port numbers used by default, see [Remote Debugger Port Assignments](../../debugger/remote-debugger-port-assignments.md).  
  
     > [!WARNING]
     >  You can choose to run the remote tools in No Authentication mode, but this mode is strongly discouraged. There is no network security when you run in this mode. Choose the No Authentication mode only if you are sure that the network is not at risk from malicious or hostile traffic.