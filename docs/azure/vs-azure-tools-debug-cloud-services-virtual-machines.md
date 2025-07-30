---
title: Debug an Azure Cloud Services (extended support) service or virtual machine
description: Debug an Azure Cloud Services (extended support) service or virtual machine in Visual Studio by running the operation on your local computer or debugging remotely in Azure.
author: mikejo5000
manager: mijacobs
ms.topic: how-to
ms.date: 03/06/2024
ms.author: mikejo
ms.subservice: debug-diagnostics
ms.custom: sfi-image-nochange
---

# Debug an Azure Cloud Services (extended support) service in Visual Studio

Visual Studio gives you different options for debugging Azure Cloud Services (extended support) and virtual machines.

## Prerequisites

- Visual Studio (see [Visual Studio downloads] (https://visualstudio.microsoft.com/downloads/?cid=learn-onpage-download-cta)) with the **Azure development** workload installed, and the Individual Component **.NET Framework project and item templates** installed. See [Modify Visual Studio](../install/modify-visual-studio.md).
- [!INCLUDE [prerequisites-azure-subscription](includes/prerequisites-azure-subscription.md)]

## Debug your cloud service on your local computer

You can save time and money by using the Azure Compute Emulator to debug your cloud service on a local machine. By debugging a service locally before you deploy it, you can improve reliability and performance without paying for compute time. However, some errors might occur only when you run a cloud service in Azure itself. You can debug these errors if you enable remote debugging when you publish your service and then attach the debugger to a role instance.

The emulator simulates the Azure Compute service and runs in your local environment so that you can test and debug your cloud service before you deploy it. The emulator handles the lifecycle of your role instances and provides access to simulated resources, such as local storage. When you debug or run your service from Visual Studio, it automatically starts the emulator as a background application and then deploys your service to the emulator. You can use the emulator to view your service when it runs in the local environment. You can run the full version or the express version of the emulator. See [Using Emulator Express to Run and Debug a Cloud Service Locally](vs-azure-tools-emulator-express-debug-run.md).

### To debug your cloud service on your local computer

1. On the menu bar, select **Debug** > **Start Debugging** to run your Azure Cloud Services (extended support) project. As an alternative, you can press F5. You'll see a message that the Compute Emulator is starting. When the emulator starts, the system tray icon confirms it.

    ![Azure emulator in the system tray](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC783828.png)

2. Display the user interface for the compute emulator by opening the shortcut menu for the Azure icon in the notification area, and then select **Show Compute Emulator UI**.

    The left pane of the UI shows the services that are currently deployed to the compute emulator and the role instances that each service is running. You can choose the service or roles to display lifecycle, logging, and diagnostic information in the right pane. If you put the focus in the top margin of an included window, it expands to fill the right pane.

3. Step through the application by choosing commands on the **Debug** menu and setting breakpoints in your code. As you step through the application in the debugger, the panes are updated with the current status of the application. When you stop debugging, the application deployment is deleted. If your application includes a web role and you've set the Startup action property to start the web browser, Visual Studio starts your web application in the browser. If you change the number of instances of a role in the service configuration, you must stop your cloud service and then restart debugging so that you can debug these new instances of the role.

    > [!NOTE]
    > When you stop running or debugging your service, the local compute emulator and storage emulator aren't stopped. You must stop them explicitly from the notification area.

## Debug a cloud service in Azure

If you enable remote debugging for a cloud service using the procedure in this section, it doesn't exhibit degraded performance or incur additional charges. Don't use remote debugging on a production service, because clients who use the service might be adversely affected.

:::moniker range="<=vs-2019"

### To enable remote debugging for a cloud service (extended support)

1. Add an Endpoint to the *ServiceDefinition.csdef* for the default msvsmon port. For Visual Studio 2019, it's 4024.

    ```xml
    <Endpoints>
       <InputEndpoint name="RemoteDebug" protocol="tcp" port="4024" localPort="4024" />
    </Endpoints>
    ```

   > [!NOTE]
   > Other versions of Visual Studio have different ports [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md).

1. Open the shortcut menu for the Azure project, and then select **Publish**.

1. Select the **Staging** environment and the **Debug** configuration.

    This is only a guideline. You can opt to run your test environments in a Production environment. However, you may adversely affect users if you enable remote debugging on the Production environment. You can choose the Release configuration, but the Debug configuration makes debugging easier.

    ![Choose the Debug configuration.](./media/vs-2022/cloud-services-extended-support-publish.png)

1. Follow the usual steps described at [Cloud Services (extended support)](cloud-services-extended-support.md#publish-to-cloud-services-extended-support), but select the **Enable Remote Desktop for all roles** checkbox.

    You'll be asked to create a username and password for the remote desktop user, which you'll need later to sign in to that virtual machine.

1. Advance to the next screen, review your settings, and when ready, click **Publish** and wait for the deployment to finish.

1. Sign in to [Azure portal](https://portal.azure.com) and navigate to the Cloud Service (extended support) that you want to debug.

1. Choose **Roles and Instances** in the left hand pane, then choose the role that you are interested in debugging remotely.

1. Click **Connect** in the **Role Instance** popout on the right and choose the **Connect** button to download a remote desktop file that will let you sign in to the virtual machine. Sign in using the credentials you created when you enabled remote desktop in a previous step.

   ![Screenshot showing the role instance popout with the Connect option.](./media/vs-2022/connect-to-virtual-machine.png)

1. On the Remote Azure virtual machine, install the Visual Studio 2019 Remote tools as described at [Remote debugging](../debugger/remote-debugging.md).

1. From the desktop on the virtual machine, execute the command *D:\Program Files (x86)\Microsoft Visual Studio\2019\Enterprise\Common7\IDE\Remote Debugger\x64\msvsmon.exe*. Be sure to run as Administrator.

1. Accept prompts to allow access through the firewall. You should see a message indicating that *msvsmon.exe* has started listening for connections.

1. In the Azure portal, open the resource group and get the public IP Address for the Cloud Service (extended support).

   ![Screenshot showing where to find the public IP address for the cloud service.](./media/vs-2022/azure-resource-group-ip-address.png)

### To attach the debugger to a cloud service (extended support) in Azure

> [!NOTE]
> Whenever possible, you should debug with the **Debug** configuration chosen in the **Publish** process, but if you are debugging a **Release** configuration, then in Visual Studio, use **Ctrl**+**Q** to search for "Just My Code" and uncheck **Enable Just My Code** in **Tools** > **Options** > **Debugger** > **General**. Release builds are optimized and thus are not considered "My code."

1. Choose **Debug** > **Attach to Process** (or press **Ctrl**+**Alt**+**P**).

1. Keep connection type at **Default**.

1. Enter the connection target, using your IP address and port: `{ipaddress}:4024`.

1. Set **Attach To** to **Automatic**.

1. Sign in using the same credentials as remote desktop user.

1. Select **Show process for all users**. If you're debugging a worker role, attach to *WaWorkerHost.exe*; if you're debugging a web role, attach to the *w3wp.exe* process; for a Web API role, it's *WaIISHost.exe*.

1. Set breakpoints (navigate to the line, and press **F9**), access the site's public URL, and reproduce the scenario to debug.

:::moniker-end
:::moniker range=">=vs-2022"

### To enable remote debugging for a cloud service (extended support)

1. Add an Endpoint to the *ServiceDefinition.csdef* for the default msvsmon port. For Visual Studio 2022, that's 4026; for Visual Studio 2019, it's 4024.

    ```xml
    <Endpoints>
       <InputEndpoint name="RemoteDebug" protocol="tcp" port="4026" localPort="4026" />
    </Endpoints>
    ```

   > [!NOTE]
   > Other versions of Visual Studio have different ports [Remote Debugger Port Assignments](../debugger/remote-debugger-port-assignments.md).

1. If you are targeting .NET 4.8, be sure to open the *ServiceConfiguration.Cloud.cscfg* file and check the value of the `osFamily` attribute on the `ServiceConfiguration` element when publishing Cloud Services (extended support). For a .NET 4.8 project, use `osFamily="7"`.

1. Open the shortcut menu for the Azure project, and then select **Publish**.

1. Select the **Staging** environment and the **Debug** configuration.

    This is only a guideline. You can opt to run your test environments in a Production environment. However, you may adversely affect users if you enable remote debugging on the Production environment. You can choose the Release configuration, but the Debug configuration makes debugging easier.

    ![Choose the Debug configuration](./media/vs-2022/cloud-services-extended-support-publish.png)

1. Follow the usual steps described at [Cloud Services (extended support)](cloud-services-extended-support.md#publish-to-cloud-services-extended-support), but select the **Enable Remote Desktop for all roles** checkbox.

    You'll be asked to create a username and password for the remote desktop user, which you'll need later to sign in to that virtual machine.

1. Advance to the next screen, review your settings, and when ready, click **Publish** and wait for the deployment to finish.

1. Sign in to [Azure portal](https://portal.azure.com) and navigate to the Cloud Service (extended support) that you want to debug.

1. Choose **Roles and Instances** in the left hand pane, then choose the role that you are interested in debugging remotely.

1. Click **Connect** in the **Role Instance** popout on the right and choose the **Connect** button to download a remote desktop file that will let you sign in to the virtual machine. Sign in using the credentials you created when you enabled remote desktop in a previous step.

   ![Screenshot showing the role instance popout with the Connect option.](./media/vs-2022/connect-to-virtual-machine.png)

1. On the Remote Azure virtual machine, install the Visual Studio 2022 Remote tools as described at [Remote debugging](../debugger/remote-debugging.md).

1. From the desktop on the virtual machine, execute the command *msvsmon.exe* in the Visual Studio installation folder under `Common7\IDE\Remote Debugger\x64`. Be sure to run as Administrator.

1. Accept prompts to allow access through the firewall. You should see a message indicating that *msvsmon.exe* has started listening for connections.

   ![Screenshot showing that msvsmon.exe is listening for connections.](./media/vs-2022/msvsmon-started-a-new-server.png)

1. In the Azure portal, open the resource group and get the public IP Address for the Cloud Service (extended support).

   :::image type="content" alt-text="Screenshot showing where to find the public IP address for the cloud service." source="./media/vs-2022/azure-resource-group-ip-address.png" lightbox="./media/vs-2022/azure-resource-group-ip-address.png":::

### To attach the debugger to a cloud service (extended support) in Azure

> [!NOTE]
> Whenever possible, you should debug with the **Debug** configuration chosen in the **Publish** process, but if you are debugging a **Release** configuration, then in Visual Studio, use **Ctrl**+**Q** to search for "Just My Code" and uncheck **Enable Just My Code** in **Tools** > **Options** > **Debugger** > **General**. Release builds are optimized and thus are not considered "My code."

1. Choose **Debug** > **Attach to Process** (or press **Ctrl**+**Alt**+**P**).

1. Keep connection type at **Default**.

1. Enter the connection target, using your IP address and port: `{ipaddress}:4026`.

1. Set **Attach To** to **Automatic**.

1. Sign in using the same credentials as remote desktop user.

1. Select **Show process for all users**. If you're debugging a worker role, attach to *WaWorkerHost.exe*; if you're debugging a web role, attach to the *w3wp.exe* process; for a Web API role, it's *WaIISHost.exe*.

1. Set breakpoints (navigate to the line, and press **F9**), access the site's public URL, and reproduce the scenario to debug.

:::moniker-end

:::moniker range="<=vs-2019"

## Limitations of remote debugging in Azure

Remote debugging has the following limitations:

- With remote debugging enabled, you can't publish a cloud service in which any role has more than 25 instances.
- The debugger uses ports 30400 to 30424, 31400 to 31424 and 32400 to 32424. If you try to use any of these ports, you won't be able to publish your service, and one of the following error messages will appear in the activity log for Azure:

  - Error validating the .cscfg file against the .csdef file.
    The reserved port range 'range' for endpoint `Microsoft.WindowsAzure.PlugIns.RemoteDebugger.Connector` of role 'role' overlaps with an already defined port or range.
  - Allocation failed. Retry later, try reducing the VM size or number of role instances, or try deploying to a different region.

:::moniker-end

::: moniker range=">=vs-2022"

<a name='debugging-azure-app-services'></a>

## Debugging Azure App Service

You can debug programs that run in Azure App Service by using the Attach to Process dialog in Visual Studio.

> [!NOTE]
> This is only available for Azure App Service starting in Visual Studio 2022 17.1.

### To debug a Windows Azure App Service

1. Under **Debug**, select **Attach to Process**.

2. Change **Connection type** to **Microsoft Azure App Services**, then select **Find..**.

3. In the dialog box that opens, select the **Subscription name**.

    ![Screenshot of Select Azure App Service Dialog, showing a list of app services to select.](./media/vs-azure-tools-debug-cloud-services-virtual-machines/select-app-service.png)

    > [!NOTE]
    > You need to be signed in to a Microsoft Account with access to the subscription that contains your Azure App Service.

4. Filter the view by either Resource Group or Resource Type, or search by name.

5. Next, select the App Service you want to debug then select **Ok**.

    This enables remote debugging on your App Service and shows you a list of available processes to attach to.

    ![Screenshot of the Attach to Process Window, showing the processes running on the selected App Service.](./media/vs-azure-tools-debug-cloud-services-virtual-machines/attach-to-process.png)

6. Select the process you want to attach to and then choose **Attach** to start debugging.

::: moniker-end

::: moniker range="vs-2019"

## Debugging Azure Virtual Machines

You can debug programs that run on Azure Virtual Machines by using Server Explorer in Visual Studio. When you enable remote debugging on an Azure virtual machine, Azure installs the remote debugging extension on the virtual machine. Then, you can attach to processes on the virtual machine and debug as you normally would.

> [!NOTE]
> Virtual Machines created through the Azure Resource Manager stack can be remotely debugged by using Cloud Explorer in Visual Studio 2019. For more information, see [Managing Azure Resources with Cloud Explorer](/previous-versions/visualstudio/visual-studio-2017/azure/vs-azure-tools-resources-managing-with-cloud-explorer).

### To debug an Azure virtual machine

1. In Server Explorer, expand the Virtual Machines node and select the node of the virtual machine that you want to debug.

2. Open the context menu and select **Enable Debugging**. When asked if you're sure if you want to enable debugging on the virtual machine, select **Yes**.

    Azure installs the remote debugging extension on the virtual machine to enable debugging.

    ![Virtual machine enable debugging command](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746720.png)

    ![Azure activity log](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746721.png)

3. After the remote debugging extension finishes installing, open the virtual machine's context menu and select **Attach Debugger...**

    Azure gets a list of the processes on the virtual machine and shows them in the **Attach to Process** dialog box.

    ![Attach debugger command](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746722.png)

4. In the **Attach to Process** dialog box, select **Select** to limit the results list to show only the types of code you want to debug. You can debug 32-bit or 64-bit managed code, native code, or both.

    ![Select code type dialog box](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC718346.png)

5. Choose the processes you want to debug on the virtual machine and then select **Attach**. For example, you might choose the w3wp.exe process if you wanted to debug a web app on the virtual machine. See [Debug One or More Processes in Visual Studio](../debugger/debug-multiple-processes.md) and [Azure Role Architecture](/archive/blogs/kwill/windows-azure-role-architecture) for more information.

## Create a web project and a virtual machine for debugging

Before publishing your Azure project, you might find it useful to test it in a contained environment that supports debugging and testing scenarios, and where you can install testing and monitoring programs. One way to run such tests is to remotely debug your app on a virtual machine.

Visual Studio ASP.NET projects offer an option to create a handy virtual machine that you can use for app testing. The virtual machine includes commonly needed endpoints such as PowerShell, Remote Desktop, and WebDeploy.

### To create a web project and a virtual machine for debugging

1. In Visual Studio, create a new ASP.NET Web Application.

2. In the New ASP.NET Project dialog, in the Azure section, select **Virtual Machine** in the dropdown list box. Leave the **Create remote resources** checkbox selected. Select **OK** to proceed.

    The **Create virtual machine on Azure** dialog box appears.

    ![Create ASP.NET web project dialog box](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746723.png)

    > [!NOTE]
    > You'll be asked to sign in to your Azure account if you're not already signed in.

3. Choose the various settings for the virtual machine and then select **OK**. See [Virtual Machines](/azure/virtual-machines/) for more information.

    The name you enter for DNS name will be the name of the virtual machine.

    ![Create virtual machine on Azure dialog box](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746724.png)

    Azure creates the virtual machine and then provisions and configures the endpoints, such as Remote Desktop and Web Deploy.

4. After the virtual machine is fully configured, select the virtual machine's node in Server Explorer.

5. Open the context menu and select **Enable Debugging**. When asked if you're sure if you want to enable debugging on the virtual machine, select **Yes**.

    Azure installs the remote debugging extension to the virtual machine to enable debugging.

    ![Virtual machine enable debugging command](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746720.png)

    ![Azure activity log](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746721.png)

6. Publish your project as outlined in [How to: Deploy a Web Project Using One-Click Publish in Visual Studio](/previous-versions/aspnet/dd465337(v=vs.110)). Because you want to debug on the virtual machine, on the **Settings** page of the **Publish Web** wizard, select **Debug** as the configuration. This makes sure that code symbols are available while debugging.

    ![Publish settings](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC718349.png)

7. In the **File Publish Options**, select **Remove additional files at destination** if the project was already deployed at an earlier time.

8. After the project publishes, on the virtual machine's context menu in Server Explorer, select **Attach Debugger...**

    Azure gets a list of the processes on the virtual machine and shows them in the **Attach to Process** dialog box.

    ![Attach debugger command](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC746722.png)

9. In the **Attach to Process** dialog box, select **Select** to limit the results list to show only the types of code you want to debug. You can debug 32-bit or 64-bit managed code, native code, or both.

    ![Select code type dialog box](./media/vs-azure-tools-debug-cloud-services-virtual-machines/IC718346.png)

10. Choose the processes you want to debug on the virtual machine and then select **Attach**. For example, you might choose the w3wp.exe process if you wanted to debug a web app on the virtual machine. See [Debug One or More Processes in Visual Studio](../debugger/debug-multiple-processes.md) for more information.

:::moniker-end

## Related content

- Use **Azure Diagnostics** to log detailed information from code running within roles, in Azure. See [Collecting logging data by using Azure Diagnostics](/azure/cloud-services/cloud-services-dotnet-diagnostics).

- For other remote debugging scenarios, see [Remote debugging](../debugger/remote-debugging.md).
