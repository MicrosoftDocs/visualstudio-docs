---
title: "Creating deployment scripts for build-deploy-test workflows"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1c86cd25-91c4-4dfa-a09f-aa4e16c9be18
caps.latest.revision: 15
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
# Creating deployment scripts for build-deploy-test workflows
To deploy your application with a build-deploy-test workflow, you must create deployment scripts and add them to your build. Deployment scripts are BAT or CMD files that copy your build to the machines in your lab environment. If your build includes an installation package, you can also use your deployment scripts to run the installation package. When you create your build-deploy-test workflow, you add commands to the workflow that run your deployment scripts. When you run your workflow, the build controller runs those commands in the working directory on the specified machines in your lab environment.  
  
 See [Create a build-deploy-test workflow for an SCVMM environment](../test/create-a-build-deploy-test-workflow-for-an-scvmm-environment.md) or [Create a build-deploy-test workflow for a standard environment](../test/create-a-build-deploy-test-workflow-for-a-standard-environment.md). These sections discuss how to create and use deployment scripts with your build-deploy-test workflow:  
  
-   [Preparing Build Files for Deployment](#scenarios)  
  
-   [Writing Your Deployment Scripts](#createcommands)  
  
-   [Building Your Deployment Scripts](#buildingscripts)  
  
-   [Setting up Working Directories](#setupdir)  
  
-   [Adding Deployment Scripts to Your Workflow](#addscripts)  
  
 For more examples, see [Automating System Tests](http://msdn.microsoft.com/library/jj159335.aspx)  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
##  <a name="scenarios"></a> Preparing build files for deployment  
 The way you choose to install your application will determine the primary tasks that your deployment scripts need to accomplish. Installing your application might only involve copying an EXE to a client machine, or it could involve running a deployment package that installs files on multiple machines. The following table describes these tasks for each type of deployment.  
  
> [!IMPORTANT]
>  If your application relies on prerequisite software that is not installed and configured by your deployment scripts before your application is deployed, you must manually install it when you prepare the machines in your lab environment. If you are using an SCVMM environment that deploys environment snapshots, you must ensure that the snapshots have the prerequisite software installed.  
  
|Installation Type|Description|  
|-----------------------|-----------------|  
|Web Service Deployment Package|**Warning:**  If you are deploying an application that uses IIS, the IIS server in your lab environment must have the Web Deployment Agent Service configured before you deploy your application <br /><br /> Your deployment scripts must copy your build files and your deployment package to the target machines in your lab environment, and then run the deployment package. To do this, you might need to pass a domain name, a service account name, and a TFS server name to your deployment script as parameters. This type of installation usually requires that you manually install and configure prerequisite software such as a web server or a database server before you deploy your application. Configuration of prerequisite software might require specific tasks that enable application deployment on the target machine. For example, if your application uses IIS, the IIS server in your lab environment must have the Web Deployment Agent Service configured before you deploy your application.|  
|Build Files with No Installation Package|Your deployment scripts must copy your application and build files to the target machines in your lab environment.|  
|Installation Package|**Warning:**  If you are deploying an installation package with your build-deploy-test workflow, your deployment scripts must handle any user input that is generated when they run your installation package or your application deployment will fail. <br /><br /> Your deployment scripts must copy your installation package to the target machines in your lab environment, and then run the installation package. When your deployment scripts run your installation package, they must ensure that it is a silent installation. User input requested by the installation must be handled by your deployment scripts. This includes credentials. If your deployment scripts do not handle all user input generated when they run your installation package, your application deployment will fail. If you are not deploying a web application, and you require an installation package for your deployment, we recommend that you use an InstallShield installation package. For information on InstallShield, see [Windows Installer Deployment](http://go.microsoft.com/fwlink/?LinkId=252848).|  
  
##  <a name="createcommands"></a> Writing your deployment scripts  
 These are the most common tasks carried out by deployment scripts:  
  
-   Get the build path on your build controller. You can send this to your deployment script as a command argument.  
  
-   Specify your deployment path.  
  
-   Create your deployment directory. You can also do this manually, instead of in your deployment script. If you are using pre-deployment environment snapshot with your workflow, you just need to create the directory on the virtual machines in your snapshot.  
  
-   Copy your deployment package from the build path to your deployment path.  
  
-   Run the deployment package in your deployment directory.  
  
 The following commands demonstrate some common tasks carried out by deployment scripts.  
  
```  
REM set build path  
set buildlocation=%1  
  
REM set deployment path  
set targetdir="C:\deploy"  
  
REM create deployment directory  
if not exist %targetdir% (cmd /c mkdir %targetdir%)  
  
REM copy build to the deployment directory  
xcopy /c /y /e %buildlocation%\*.* %targetdir%  
  
REM if you are using a deployment package you can run it here, after you copy it to your deployment directory  
  
```  
  
##  <a name="buildingscripts"></a> Building your Deployment Scripts  
 After you create your deployment scripts, you must check them into version control, and then configure them so that they are copied to your build output. To build your deployment scripts, you must first make sure that they are stored under your Visual Studio project, and not just in your solution. You can do this in Visual Studio by selecting your deployment script in **Solution Explorer**, and then under **Properties**, changing **Copy Output Directory** to **Copy always**.  
  
##  <a name="setupdir"></a> Setting up Working Directories  
 You can specify a working directory for each set of commands that you add to your build-deploy-test workflow. When you specify a working directory, your build controller will run the specified commands in the working directory of each machine that is assign to that role. If you do not specify a working directory when you add commands to your build-deploy-test workflow, your build controller will run the commands in the default working directory−**C:\Windows\System32**.  
  
> [!IMPORTANT]
>  Don’t create working directories using the commands that you add to your build-deploy-test workflow; if you do the directories will not be created before your deployment scripts try to copy files to those directories.  
  
 If you specify a working directory, you must ensure that the directory is created before your deployment scripts copy any files to that directory. Don’t create working directories with the commands that you use to add your deployment scripts to your build-deploy-test workflow. If you do, the directories will not be created before your deployment scripts try to copy files to the directories. To ensure that a working directory is created before your deployment scripts copy files to it, you must manually create the directory on the target machines in your lab environment, or the directory must be created by your deployment scripts before any command copies files to it.  
  
##  <a name="addscripts"></a> Adding Deployment Scripts to your Workflow  
 Add Windows shell commands to your build-deploy-test workflow to deploy your application to your lab environment. If you are using deployment scripts, the commands must copy your deployment scripts from your build controller to the working directory of the target machines, and then run the deployment scripts. However, for simple application installations that only involve copying a few files to the working directory, you can use shell commands in your workflow without specifying external deployment scripts.  
  
 If you want to add a command that is run from a windows prompt, such as `mkdir`, or run a batch file, you must begin the command by using `cmd /c`. For example, the command `cmd /c $(BuildLocation)\copyexe $(BuildLocation)` where `copyexe` is the batch file copyexe.bat, copies an executable to a local directory in a virtual machine.  
  
 **Built-in Variables:** When you add these commands to your build-deploy-test workflow, you can use built-in variables to identify certain paths and machines. You can also pass these variables to your deployment scripts.  
  
 $(BuildLocation)  
 The full path where your build files are located, or the build drop location—if one is configured in your build-deploy-test workflow. Use this variable to access your build files.  
  
 $(InternalComputerName_\<VM Name>)  
 The computer name for a virtual machine in an SCVMM environment. Use this variable to access a virtual machine host when you do not know the computer name of the host. If you have a deployment script to set up a Web server that requires the computer name, you can pass this as an argument to the script. For example, if the virtual machine name for the Web server was VM1 and the computer name was MyWebServer, you would type `$(InternalComputerName_VM1)` as the argument for your script and this would pass the value `MyWebServer` to your script.  
  
 $(ComputerName_\<VM Name>)  
 > [!NOTE]
>  **Network Isolation in SCVMM Environments:** If you are using network isolation for your SCVMM environment, the value of `$(InternalComputerName_<VM Name>)` is the same for an instance of a virtual machine in each copy of your environment, but the `$(ComputerName_<VM Name>)` value is different.  
  
 The fully qualified domain name of the virtual machine. Use this variable access a computer from outside an SCVMM environment. You might want to pass this variable as an argument to set up a Web server. For example, if the virtual machine name for the Web server is VM1, you can access the fully qualified domain name of the virtual machine by passing the `$(ComputerName_VM1)` argument to your deployment script.  
  
## See Also  
 [Automated build-deploy-test workflows](../test/automated-build-deploy-test-workflows.md)   
 [Automating System Tests](http://msdn.microsoft.com/library/jj159335.aspx)