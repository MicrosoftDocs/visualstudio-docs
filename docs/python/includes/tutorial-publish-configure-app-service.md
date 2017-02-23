## Publish to Azure App Service

PTVS provides an easy way to deploy your web application to a website in Azure App Service. You can use an existing App Service if you like, or create one in the process.

1. In **Solution Explorer**, right-click the project select **Publish**. 

1. In the **Publish** dialog, select **Microsoft Azure App Service**:

  ![Publish to Azure step 1](media/tutorials-common-publish-1.png)

1. In the **App Service** dialog, select an existing App Service or click **New** to create one, specifying a name for the web app along with your subscription, resource group, and App Service Plan. Once you've selected an App Service, its details will appear in the **Publish** dialog's **Connection** tab:

  ![Publish to Azure step 2](media/tutorials-common-publish-2.png)

1. Click **Next >** to review additional settings, then click **Publish**. Once your application is deployed to Azure, your default browser will open on that site. However, if you look at the **About** page you'll see that the site is using an in-memory repository instead of your Azure Table Storage. This is because we need to set the environment variables in the application's code, which we'll do in the next section.

## Configure the Azure App service

In this section you'll configure the Azure App Service with environment variables that point to your Azure Table Storage account. These values will be loaded by the code in the application's `settings.py` file. 

1. In the Azure portal, navigate to the App Service to which you deployed the application in the previous step.
1. Select the **Settings > Application settings** blade and scroll down to **App settings**.

  ![App settings area on the Azure App Service portal](media/tutorials-common-app-settings-1.png)

1. In the blank key/value fields, add the following pairs, identical to those you used in the project's environment settings earlier:

  | Key | Value |
  | --- | --- |
  | REPOSITORY_NAME | azuretablestorage |
  | STORAGE_NAME | (your storage account name) |
  | STORAGE_KEY | (the storage access key) |
  
  ![Completed app settings area on the Azure App Service portal](media/tutorials-common-app-settings-2.png)
  
1. Select **Save** to apply the settings, which will update the live web app.

1. Browse to the web site's **About** page again (refreshing if necessary), and you should see that it's now using **Azure Table Storage**.