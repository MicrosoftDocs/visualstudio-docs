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
  
1.  Locate the Remote Debugger application. (Find msvsmon.exe in the location where it has been installed, or open the Start menu and search for **Remote Debugger**.)
  
     If you are running the remote debugger on a  remote server, you can right-click the Remote Debugger app and choose **Run as administrator**. If you are not running it on a remote server, just start it normally.
  
3.  When you start the remote tools for the first time (or before you have configured it), the **Remote Debugging Configuration** dialog box appears.  
  
     ![RemoteDebuggerConfWizardPage](../media/remotedebuggerconfwizardpage.png "RemoteDebuggerConfWizardPage")  
  
4.  If the Windows Service API is not installed (which happens only on Windows Server 2008 R2), choose the **Install** button.  
  
5.  Select the network types you want use the remote tools on. At least one network type must be selected. If the computers are connected through a domain, you must choose the first item. If the computers are connected through a workgroup or homegroup, you need to choose the second or third item as appropriate.  
  
6.  Choose **Configure remote debugging** to configure the firewall and start the tool.  
  
7.  When configuration is complete, the Remote Debugger window appears.
  
     ![RemoteDebuggerWindow](../media/remotedebuggerwindow.png "RemoteDebuggerWindow")
  
     The remote debugger is now waiting for a connection. Make a note of the server name and port number that is displayed, because this must match the configuration you later use in Visual Studio.  
  
 When you are finished debugging and need to stop the remote debugger, click **File > Exit** on the window. You can restart it from the **Start** menu or from the command line:  
  
 **\<Visual Studio installation directory>\Common7\IDE\Remote Debugger\\<x86, x64, or Appx>\msvsmon.exe**.  
