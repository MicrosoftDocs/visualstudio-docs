Web Deploy 3.6 for Hosting Servers provides additional configuration features that enable the creation of the publish settings file from the UI.

The Web Platform Installer for IIS allows installation of version 3.6, not 4.0, so that is the version we recommend in this article.

1. If you have Web Deploy already installed on Windows Server, uninstall it using **Control Panel** > **Programs** > **Uninstall a Program**.

2. Next, install Web Deploy 3.6 for Hosting Servers on Windows Server.

    To install Web Deploy for Hosting Servers, use the Web Platform Installer (WebPI). (To find the Web Platform Installer link from IIS, select **IIS** in the left pane of Server Manager. In the server pane, right-click the server and select **Internet Information Services (IIS) Manager**. Then use the **Get New Web Platform Components** link in the **Actions** window.) You can also obtain the Web Platform Installer (WebPI) from [downloads](https://www.microsoft.com/web/downloads/platform.aspx).

    In the Web Platform Installer, you find **Web Deploy 3.6 for Hosting Servers** in the Applications tab.

3. If you did not already install **IIS Management Scripts and Tools**, install it now.

    Go to **Select server roles** > **Web Server (IIS)** > **Management Tools**, and then select the **IIS Management Scripts and Tools** role, click **Next**, and then install the role.

    ![Install IIS Management Scripts and Tools](../../deployment/media/tutorial-iis-management-scripts-and-tools.png)

    The scripts and tools are required to enable the generation of the publish settings file.

4. (Optional) Verify that Web Deploy is running correctly by opening  **Control Panel > System and Security > Administrative Tools > Services**, and then make sure that:

    * **Web Deployment Agent Service** is running (the service name is different in older versions).

    * **Web Management Service** is running.

    If one of the agent services is not running, restart the **Web Deployment Agent Service**.

    If the Web Deployment Agent Service is not present at all, go to **Control Panel > Programs > Uninstall a program**, find **Microsoft Web Deploy \<version>**. Choose to **Change** the installation and make sure that you choose  **Will be installed to the local hard drive** for the Web Deploy components. Complete the change installation steps.