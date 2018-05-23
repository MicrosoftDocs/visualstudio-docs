
1. Close and re-open the IIS Management Console to show updated configuration options in the UI.

1. In IIS, right-click the **Default Web Site**, choose **Deploy** > **Configure Web Deploy Publishing**.

    ![Configure Web Deploy configuration](../../deployment/media/tutorial-configure-web-deploy-publishing.png)

1. In the **Configure Web Deploy Publishing** dialog box, examine the settings.

1. Click **Setup**.

    In the **Results** panel, the output shows that access rights have been granted to the specified user, and that a file with a *.publishsettings* file extension has been generated in the location shown in the dialog box.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <publishData>
      <publishProfile
        publishUrl="https://myhostname:8172/msdeploy.axd"
        msdeploySite="Default Web Site"
        destinationAppUrl="http://myhostname:80/"
        mySQLDBConnectionString=""
        SQLServerDBConnectionString=""
        profileName="Default Settings"
        publishMethod="MSDeploy"
        userName="myhostname\myusername" />
    </publishData>
    ```

    Depending on your Windows Server and IIS configuration, you will see different values. Here are a few details about the values that you see:

    * The *msdeploy.axd* file referenced in the `publishUrl` attribute is a dynamically-generated HTTP handler file for Web Deploy. (For testing purposes, `http://myhostname:8172` will generally work as well.)
    * The `publishUrl` port is usually set to port 8172, which is the default for Web Deploy.
    * The `destinationAppUrl` port is usually set to port 80, which is the default for IIS.
    * If you are unable to connect to the remote host in Visual Studio using the host name (in later steps), test the IP address in place of the host name.

    > [!NOTE]
    > If you are publishing to IIS running on an Azure VM, the Web Deploy and IIS ports must be opened in the Network Security group. For detailed information, see [Install and run IIS](/azure/virtual-machines/windows/quick-create-portal#open-port-80-for-web-traffic).

1. Copy this file to the computer where you are running Visual Studio.
