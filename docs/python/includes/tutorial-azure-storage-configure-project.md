## Create an Azure Storage Account

Follow the instructions on [Create a storage account](https://docs.microsoft.com/en-us/azure/storage/storage-create-storage-account#create-a-storage-account) in the Azure documentation, using the default settings (a **General Purpose** storage account includes tables) and choosing a geographic region close to your own. Record the name that you enter for the storage account here, as it's the host name that you use to access the storage.

## Configure the Project

Next we'll configure the application to use the storage account created above, then run the application locally:

1. Follow the instructions on[] Manage your storage account](https://docs.microsoft.com/en-us/azure/storage/storage-create-storage-account#manage-your-storage-account) in the Azure documentation, specifically the section "View and copy storage access keys." Keep the browser open to this page as we'll need one of the keys in a moment.

1. In Visual Studio, right-click on your project node in Solution Explorer, select **Properties**, click on the **Debug** tab, and scroll down to the **Debug Server Command** group.

1. In the **Environment** box, enter the following:

  ```
    REPOSITORY_NAME=azuretablestorage
    STORAGE_NAME=<storage_account_name>
    STORAGE_KEY=<primary_access_key>
  ```

  where you replace &lt;storage_account_name&gt; with the name you entered in the Azure portal, and replace &lt;primary_access_key&gt; with the first access key from the Azure portal in step 1 above.

  ![Setting Debug Server Command Environment values](media/tutorial-bottle-project-debug-settings.png)

  These values set the environment variables when you use **Debug > Start Debugging** or F5.  To set the same variables when running without debugging, copy the values to the **Run Server Command > Environment** field as well.

  Alternatively, you can define environment variables using the Windows Control Panel.  This is a better option if you want to avoid storing credentials in the project file.  Note that you will need to restart Visual Studio for the new environment values to be available to the application.

1. Run the application with **Debug > Start Debugging** or F5. Provided that your configuration is correct, data is now being saved in Azure Table Storage. You can verify this by answering the various polls with different answers, and noting that the votes accumulate. You can also browse to the **About** page and note the **Current repository**:

  ![About page for Bottle web application using Azure Table Storage](media/tutorial-bottle-azure-table-storage-about.png)

1. Stop the debugger when you're finished.

> [!Tip]
> The code that manages the repository is found in `models/azuretablestorage.py` (`models` might be in another subfolder with the project name). For details on what this code is doing, see [How to Use Table Storage (Python)](http://azure.microsoft.com/en-us/documentation/articles/storage-python-how-to-use-table-storage/) in the Azure documentation.