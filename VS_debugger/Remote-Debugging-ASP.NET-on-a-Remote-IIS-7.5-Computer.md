---
title: "Remote Debugging ASP.NET on a Remote IIS 7.5 Computer"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: hero-article
ms.assetid: 573a3fc5-6901-41f1-bc87-557aa45d8858
caps.latest.revision: 3
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Remote Debugging ASP.NET on a Remote IIS 7.5 Computer
You can deploy an ASP.NET Web application to a Windows Server 2008 R2 computer with IIS 7.5, and set it up for remote debugging. The following instructions explain how to set up and configure a Visual Studio 2015 MVC 4.5.2 application.  
  
## Create the application on the Visual Studio computer  
  
1.  Create a new MVC ASP.NET application. (**File / New / Project**, then select **Visual C# / Web / ASP.NET Web Application** . In the **ASP.NET 4.5.2** templates section, select **MVC**. Cancel the **Configure Microsoft Azure Web App** page. ) and name it **MyMVC**.  
  
2.  Open the  HomeController.cs file, and set a breakpoint in the `About()` method.  
  
3.  In the **Solution Explorer**,  right-click the project node and select **Publish**.  
  
4.  For **Select a publish target**, select **Custom** and name the profile **MyMVC**. Click **Next**.  
  
5.  On the **Connection** tab, set the **Publish method** field to **File System** and  the **Target location** field to a local directory. Click **Next**.  
  
6.  Set the configuration to **Debug**. Click **Publish**.  
  
     The application should be published to the local directory.  
  
## Deploy the application on the Windows Server remote computer  
 This section assumes that the Windows Server 2008 R2 computer already has IIS enabled.  
  
1.  Install ASP.NET:  
  
     **C:\Windows\Microsoft.NET\Framework(64)\v4.0.30319\aspnet_regiis.exe -ir**  
  
2.  Copy the ASP.NET project directory from the Visual Studio computer  to a local directory (which we'll call **C:\Publish**) on the Windows Server computer.  
  
3.  Make sure that the web.config file lists the correct version of the .NET Framework.  The .NET Framework version installed  by default on this computer is 4.0.30319, but we created an ASP.NET 4.5.2 version. If this version is not installed on the Windows Server computer, you need to change the version:  
  
    ```xml  
    <system.web>  
        <authentication mode="None" />  
        <compilation debug="true" targetFramework="4.0.30319" />  
        <httpRuntime targetFramework="4.0.30319" />  
      </system.web>  
  
    ```  
  
4.  Open the **Internet Information Services (IIS) Manager** and go to **Sites**.  
  
5.  Right-click the **Default Web Site** node and select **Add Application**.  
  
6.  Set the **Alias** field to **MyMVC** and the Application pool field to **ASP.NET v4.0**. Set the **Physical path** to **C:\Publish** (where you copied the ASP.NET project directory).  
  
7.  To test the deployment, right-click **Default Web Site** and select **Browse**. You should see the web page.  
  
## Install the remote debugger on the Windows Server computer  
 For instructions about how to download the remote debugger, see [Remote Debugging](../VS_debugger/Remote-Debugging.md).  
  
 To do remote debugging of ASP.NET applications, you can either start the remote debugger as a service, or run the remote debugger application as an administrator. Details about how to run the remote debugger as a service can be found in [Remote Debugging](../VS_debugger/Remote-Debugging.md).  
  
## Attach to the ASP.NET application from the Visual Studio computer  
  
-   On the Visual Studio computer, open the **MyMVC** solution.  
  
-   In Visual Studio, click **Debug / Attach to Process**.  
  
-   Set the Qualifier field to **<remote computer name\>:4020**.  
  
-   You should see some processes appear in the **Available Processes** window.  
  
-   Check  **Show processes from all users**.  
  
-   Look for **w3wp.exe** and click **Attach**.  
  
-   Open the remote computer's website. In a browser, go to **http://<remote computer name\>**.  
  
-   You should see the ASP.NET web page. Click **About**.  
  
     The breakpoint should be hit in Visual Studio.