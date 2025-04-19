
1. Close and reopen the IIS Management Console to show updated configuration options in the UI.

2. In IIS, right-click the **Default Web Site**, choose **Deploy** > **Configure Web Deploy Publishing**.

    ![Configure Web Deploy configuration](../../deployment/media/tutorial-configure-web-deploy-publishing.png)

   If you don't see the **Deploy** menu, see the preceding section to verify that Web Deploy is running.

3. In the **Configure Web Deploy Publishing** dialog box, examine the settings.

4. Click **Setup**.

    In the **Results** panel, the output shows that access rights are granted to the specified user, and that a file with a *.publishsettings* file extension has been generated in the location shown in the dialog box.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <publishData>
      <publishProfile
        publishUrl="https://myhostname:8172/msdeploy.axd"
        msdeploySite="Default Web Site"
        destinationAppUrl="http://myhostname:80/"
        profileName="Default Settings"
        publishMethod="MSDeploy"
        userName="myhostname\myusername" />
    </publishData>
    ```

    Depending on your Windows Server and IIS configuration, you see different values in the XML file. Here are a few details about the values that you see:

   * The *msdeploy.axd* file referenced in the `publishUrl` attribute is a dynamically generated HTTP handler file for Web Deploy. (For testing purposes, `http://myhostname:8172` generally works as well.)
   * The `publishUrl` port is set to port 8172, which is the default for Web Deploy.
   * The `destinationAppUrl` port is set to port 80, which is the default for IIS.
   * If, in later steps, you are unable to connect to the remote host from Visual Studio using the host name, test the server's IP address in place of the host name.

     > [!NOTE]
     > If you are publishing to IIS running on an Azure VM, you must open an inbound port for Web Deploy and IIS in the Network Security group. For detailed information, see [Open ports to a virtual machine](/azure/virtual-machines/windows/nsg-quickstart-portal).

5. Copy this file to the computer where you are running Visual Studio.
