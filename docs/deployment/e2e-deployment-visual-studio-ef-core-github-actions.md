---
title: Deploy an ASP.NET Core app and Database to Container Apps using GitHub Actions
description: Learn how to use the Publish tool to publish ASP.NET and ASP.NET Core to a website from Visual Studio. 
ms.date: 09/16/2022
ms.topic: tutorial
helpviewer_keywords:
  - "deployment, web app"
author: alexwolfmsft
ms.author: alexwolf
ms.technology: vs-ide-deployment
monikerRange: '>= vs-2022'
---

# Tutorial: Deploy an ASP.NET Core app and Database to Azure Container Apps using GitHub Actions

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

In this tutorial, you'll learn how to deploy an ASP.NET Core app and SQL Database to Azure Container Apps using Visual Studio and GitHub Actions. You'll also learn how to manage Entity Framework migrations and database updates in GitHub Actions, though the concepts can also be applied to other CI/CD tools and environments.

## Prerequisites

You need [Visual Studio 2022](https://www.visualstudio.com/downloads) installed with the ASP.NET and web development workload.

If you've already installed Visual Studio:

* Install the latest updates in Visual Studio by selecting **Help** > **Check for Updates**.
* Add the workload by selecting **Tools** > **Get Tools and Features**.

## Set up the sample app locally

Use the ToDo sample app to follow along with this tutorial. Clone the app from GitHub using the following command:

```dotnetcli
git clone https://github.com/Azure-Samples/msdocs-app-service-sqldb-dotnetcore.git
cd msdocs-app-service-sqldb-dotnetcore
```

Navigate into the project folder and open the `DotNetCoreSqlDb.sln` solution in Visual Studio.

The ToDo application is ready to go, but you'll need to establish a connection to the `localdb` SQL server that is available in Visual Studio. Connecting to `localdb` will allow you to run the app and persist todos while working locally.

1. Right click on the **Connected Services** node in the Visual Studio solution explorer and select **Add > SQL Server Database**.
1. On the **Connect to dependency** dialog, select **SQL Server Express LocalDB (Local)** and then select **Next**.
1. On the **Connect to SQL Server Express LocalDB (Local)** dialog, set the following values:
    1. **Connection string name**: Leave the default value.
    1. **Connection string value**: Leave the default value.
    1. **Save connection string value in**: Select **None**.
    1. Select **Next**
1. On the **Summary of changes** screen, leave the settings at their default values and select **Finish** to complete the workflow.

Visual Studio displays a summary of the service dependencies, including the connection to `LocalDB`.

Next you'll need to create an initial migration and use it to update the local database with the correct schema for the todo app.

1. Select the **...** icon on the right of the service dependencies list next to the `LocalDB` connection and choose **Add migration**.
1. On the **Entity Framework Migrations** dialog, wait a moment for Visual Studio to locate the `DbContext` class that is included in the project. Once the values have loaded, select **Finish**.
1. Visual Studio generates a `Migrations` folder in the project and create an initial migrations class. This class can be used to update the database with the correct schema.
1. Select the **...** icon next to the `LocalDB` service again and select **Update database**.
1. On the **Entity Framework Migrations** dialog, wait a moment for Visual Studio to locate the `DbContext` class again, and then choose **Finish**.
    Visual Studio run the migration and create the schema for the database in the `LocalDB` server.

Launch the project by selecting the **DotNetCoreSqlDb** run button at the top of Visual studio.

When the app loads, verify the database is working correctly by entering a new todo. The todo appears on the main list view on the app home page.

## Create the Azure services

The app will require the following Azure services to be created for a successful deployment: 

* **Container App**: Required to host and run the deployed application.
* **Container Registry**: Stores the built image artifact of the containerized app.
* **SQL Database**: An Azure SQL database to store the data of the app.

The publishing features of Visual Studio can handle creating these resources for you.

### Create the Azure Container App and Azure Container Registry

1. In Visual Studio solution explorer, right click on the top level project node and select **Publish**.
1. In the publishing dialog, select **Azure** as the deployment target, and then select **Next**.
1. For the specific target, select **Azure Container Apps (Linux)**, and then select **Next**.
1. Create a new container app to deploy to. Select the green **+** icon to open a new dialog and enter the following values:

    :::image type="content" source="./media/scaling-deploy-visual-studio-small.png" lightbox="./media/scaling-deploy-visual-studio.png" alt-text="A screenshot showing Visual Studio deployment.":::

    * **Container app name**: Leave the default value or enter a name.
    * **Subscription name**: Select the subscription to deploy to.
    * **Resource group**: Select **New** and create a new resource group called *msdocs-app-db-ef*.
    * **Container apps environment**: Select **New** to open the container apps environment dialog and enter the following values:
        * **Environment name**: Keep the default value.
        * **Location**: Select a location near you.
        * **Azure Log Analytics Workspace**: Select **New** to open the log analytics workspace dialog.
            * **Name**: Leave the default value.
            * **Location**: Select a location near you and then select **Ok** to close the dialog.
        * Select **Ok** to close the container apps environment dialog.
    * Select **Create** to close the original container apps dialog. Visual Studio creates the container app resource in Azure.
1. Once the resource is created, make sure it's selected in the list of container apps, and then select **Next**.
1. You'll need to create an Azure Container Registry to store the published image artifact for your app. Select the green **+** icon on the container registry screen. 

    :::image type="content" source="./media/scaling-create-new.png" alt-text="A screenshot showing how to create a new container registry.":::

1. Leave the default values, and then select **Create**.

    :::image type="content" source="./media/scaling-new-registry-small.png" lightbox="./media/scaling-new-registry.png" alt-text="A screenshot showing the values for a new container registry.":::

1. After the container registry is created, make sure it's selected, and then select next.
1. On the **Deployment type** screen, select **CI/CD using GitHub Actions workflows (generates yml file)** and then choose **Finish**.
    If Visual Studio prompts you to enable the Admin user to access the published docker container, select **Yes**.

Visual Studio creates and displays the publishing profile. Most of the publishing steps and details are described in the GitHub Actions `.yml` file, which can be viewed by clicking on the **Edit workflow** button on the publishing profile summary view. This file is covered in greater depth later in the article.

### Create the Azure SQL database

1. In the solution explorer, right click on the **Connected Services** node and select **Add > SQL Database**.
1. In the **Connect to dependency** dialog, select **Azure SQL Database** and then choose **Next**.
1. Select **+ Create New** to add a new database.
1. In the **Azure SQL Database** dialog, enter the following values:
    1. **Database Name**: Leave the default value.
    1. **Subscription Name**: Select the same subscription as previously.
    1. **Resource Group**: Select the same `msdocs-app-db-ef` group created previously.
    1. **Database Server**: Select **New...** and then enter the following values in the new pop-up:
        1. **Database Server Name**: Enter a unique server name, or append random numbers to the end of the autogenerated name.
        1. **Location**: Select a location that is close to you.
        1. **Administrator username**: Enter a value of your choosing.
        1. **Administrator password**: Enter a value of your choosing.
        1. **Administrator password (confirm)**: Enter the same password to confirm.
            Select **OK** to close the **SQL Server dialog**
    1. Select **Create** to create the SQL server and database.
    1. When the operation completes, select the server from the list and choose **Next**
1. On the **Connect to Azure SQL Database** dialog, leave the default values, but make sure **None** is selected at the bottom for the **Save connection string value in** option.
1. Select **Finish** and Visual Studio will create the SQL resources.

## Configure the GitHub Actions workflow

The GitHub Actions workflow file generated by Visual Studio can be used by GitHub to build and deploy the app to Azure when changes are pushed. Currently this process would work, but the deployed app would throw an exception. Although the Azure SQL database was created, a step must be added to the GitHub Actions workflow to generate the schema. The connection string for the Azure SQL database can be stored as a secret in GitHub and retrieved by the workflow when it runs.

### Retrieve the connection string and add it to GitHub secrets

1. In the Azure portal, search for the created database by name in the main search bar and select it from the results.
1. On the database overview page, select **Connection strings** from the left navigation.
1. On the **ADO.NET** tab, copy the connection string out of the form field.
1. Navigate to the forked GitHub repository of the app.
1. Under the **Settings** tab, select **Secrets > Actions** from the left navigation, and then choose **New repository secret**.
1. On the **New secret** page, enter the following values:
    1. **Name**: Enter a name of `DbConnection`.
    1. **Secret**: Paste the connection string copied from Azure.
    1. Select **Add secret**.

The connection string is now stored securely in the GitHub repository secrets and can be retrieved using a GitHub workflow.

### Modify the GitHub Actions workflow to enable migrations

1. Open the GitHub Actions workflow `.yml` file generated by Visual Studio. This can be done using the **Edit Workflow** button on the publishing summary page.
1. Update the markup at the bottom of the file to match the following:

    ```yml
        - name: Publish Artifacts
          uses: actions/upload-artifact@v1.0.0
          with:
            name: webapp
            path: ${{ env.AZURE_WEBAPP_PACKAGE_PATH }}
        - name: App Settings Variable Substitution
          uses: microsoft/variable-substitution@v1
          with:
              files: '**/appsettings.json'
          env:
              ConnectionStrings.Default: ${{ secrets.DBConnection }}
        - name: Run EF 
          run: | 
            dotnet tool install --global dotnet-ef
            dotnet tool restore
            dotnet ef database update -p DotNetCoreSqlDb
    ```

    This code adds two new steps in the GitHub actions workflow:
        * **App Settings Variable Substitution** Retrieves the connection string stored in GitHub secrets and adds it to the `appsettings.json` file while the worfklow is running.
        * **Run EF**: Installs the entity framework command line tooling and runs the app migrations.

### Run the GitHub Actions workflow and test the deployment

1. Commit the changes to the application and push to the forked repo using the following command:

    ```bash
    git add --all
    git commit -m "Added GitHub Actions workflow"
    git push
    ```
2. Navigate to the GitHub repository and select the **Actions** tab. A workflow run should have triggered automatically if the push was successful.
1. Select the active workflow to view the log details for each step as they complete. The migration runs last to update the databse in Azure.

After the workflow completes, the application is deployed to Azure Container Apps and connected to the database with an updated schema.