---
 title: Deploy to local folder
 description: Deploy an app to a local folder
 services: ""
 author: mikejo5000
 ms.service: ""
 ms.topic: include
 ms.date: 05/23/2018
 ms.author: mikejo
 ms.custom:
   - include file
   - sfi-image-nochange
---

1. In the **Solution Explorer**,  right-click the project node and select **Publish** (for Web Forms, **Publish Web App**).

    If you have previously configured any publishing profiles, the **Publish** pane appears. Click **New profile**.

1. In the **Publish** dialog box, select **Folder**, click **Browse**, and create a new folder, **C:\Publish**.

   ::: moniker range=">=vs-2022"

   :::image type="content" source="../media/vs-2022/remote-debug-publish-local.png" alt-text="Screenshot of the Pick a publish target dialog in Visual Studio with the Folder `C:\Publish' selected as the publish target.":::

   Click **Finish** to save the publish profile.
   ::: moniker-end

   ::: moniker range="vs-2019"

   :::image type="content" source="../media/vs-2019/remotedbg-publish-local.png" alt-text="Screenshot of the Pick a publish target dialog in Visual Studio with the Folder `C:\Publish' selected as the publish target.":::

   Click **Finish** to save the publish profile.
   ::: moniker-end

1. Switch to a debug configuration.

   Choose **Edit** to edit the profile, and then choose **Settings**. Choose a **Debug** configuration, and then choose **Remove additional files at destination** under the **File Publish** options.

    ![Screenshot of the Settings tab in the Publish dialog box. Configuration is set to Debug and the Publish button is selected.](../media/remote-debug-publish-debug-config.png)

   > [!NOTE]
   > If you use a Release build, you disable debugging in the *web.config* file when you publish.

1. Click **Publish**.

    The application publishes a **Debug** configuration of the project to the local folder. Progress shows in the Output window.

1. Copy the ASP.NET project directory from the Visual Studio computer to the local directory configured for the ASP.NET app (in this example, **C:\Publish**) on the Windows Server computer. In this tutorial, we assume you are copying manually, but you can use other tools like PowerShell, Xcopy, or Robocopy.

    > [!CAUTION]
    > If you need to make changes to the code or rebuild, you must republish and repeat this step. The executable you copied to the remote machine must exactly match your local source and symbols. If you do not do this you will receive a `cannot find or open the PDB file` warning in Visual Studio when you attempt to debug the process.

1. On the Windows Server, verify that you can run the app correctly by opening the app in your browser.

    If the app doesn't run correctly, there may be a mismatch between the version of ASP.NET installed on your server and your Visual Studio machine, or you may have an issue with your IIS or Web site configuration. Recheck earlier steps.
