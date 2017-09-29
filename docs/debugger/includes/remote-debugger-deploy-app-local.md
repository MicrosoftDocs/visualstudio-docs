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
1. In the **Solution Explorer**,  right-click the project node and select **Publish** (for Web Forms, **Publish Web App**).

2. In the **Publish** dialog box, select **Folder**, click **Browse**, and create a new folder, **C:\Publish**.

    ![RemoteDBG_Publish_Local](../media/remotedbg_publish_local.png "RemoteDBG_Publish_Local")

    For a Web Forms app, choose **Custom** in the Publish dialog box, enter a profile name, and choose **OK**.

3. Click **Publish**.

    Visual Studio publishes the project to the folder. Progress shows in the Output window.

4. In the **Publish** dialog box, click the **Settings** link, and then select the **Settings** tab.

5. Set the configuration to **Debug**, select **Delete all existing files prior to publish**, and then click **Save**.

    > [!NOTE]
    > If you use a Release build, you disable debugging in the web.config file when you publish.

6. Click **Publish**.

    ![RemoteDBG_Publish_Debug_Config](../media/remotedbg_publish_debug_config.png "RemoteDBG_Publish_Debug_Config")
    
    The application publishes a **Debug** configuration of the project to the local folder.

5. Copy the ASP.NET project directory from the Visual Studio computer to the local directory configured for the ASP.NET app (in this example, **C:\Publish**) on the Windows Server computer. In this tutorial, we assume you are copying manually, but you can use other tools like PowerShell, Xcopy, or Robocopy.

    > [!CAUTION]
    >  If you need to make changes to the code or rebuild, you must republish and repeat this step. The executable you copied to the remote machine must exactly match your local source and symbols.

6. On the Windows Server, verify that you can run the app correctly by opening the app in your browser.

    If the app doesn't run correctly, there may be a mismatch between the version of ASP.NET installed on your server and your Visual Studio machine, or you may have an issue with your IIS or Web site configuration. Recheck earlier steps.