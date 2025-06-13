---
title: Getting Service Information from the Settings Store
description: Learn how to use the settings store to find all available services or to determine whether a particular service is installed.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Get service information from the settings store

You can use the settings store to find all available services or to determine whether a particular service is installed. You must know the type of the service class.

## To list the available services

1. Create a VSIX project named `FindServicesExtension` and then add a custom command named `FindServicesCommand`. For more information about how to create a custom command, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md)

2. In *FindServicesCommand.cs*, add the following using directives:

    ```csharp
    using System.Collections.Generic;
    using Microsoft.VisualStudio.Settings;
    using Microsoft.VisualStudio.Shell.Settings;
    using System.Windows.Forms;
    ```

3. Get the configuration settings store, then find the subcollection named Services. This collection includes all the available services. In the `MenuItemCommand` method, remove the existing code and replace it with the following:

    ```csharp
    private void MenuItemCallback(object sender, EventArgs e)
    {
        SettingsManager settingsManager = new ShellSettingsManager(ServiceProvider);
        SettingsStore configurationSettingsStore = settingsManager.GetReadOnlySettingsStore(SettingsScope.Configuration);
        string message = "Available services:\n";
        IEnumerable<string> collection = configurationSettingsStore.GetSubCollectionNames("Services");
        int n = 0;
        foreach (string service in collection)
        {
            message += configurationSettingsStore.GetString("Services\\" + service, "Name", "Unknown") + "\n";
        }

        MessageBox.Show(message);
    }
    ```

4. Build the project and start debugging. The experimental instance appears.

5. In the experimental instance, on the **Tools** menu, click **Invoke FindServicesCommand**.

     You should see a message box listing all the services.

     To verify these settings, you can use the registry editor.

## Find a specific service
 You can also use the <xref:Microsoft.VisualStudio.Settings.SettingsStore.CollectionExists%2A> method to determine whether a particular service is installed. You must know the type of the service class.

1. In the MenuItemCallback of the project you created in the previous procedure, search the configuration settings store for the `Services` collection that has the subcollection named by the GUID of the service. In this case we will look for the Help service.

    ```csharp
    private void MenuItemCallback(object sender, EventArgs e)
    {
        SettingsManager settingsManager = new ShellSettingsManager(ServiceProvider);
        SettingsStore configurationSettingsStore = settingsManager.GetReadOnlySettingsStore(SettingsScope.Configuration);
        string helpServiceGUID = typeof(SVsHelpService).GUID.ToString("B").ToUpper();
        bool hasHelpService = configurationSettingsStore.CollectionExists("Services\\" + helpServiceGUID);
        string message = "Help Service Available: " + hasHelpService;

        MessageBox.Show(message);
    }
    ```

2. Build the project and start debugging.

3. In the experimental instance, on the **Tools** menu, click **Invoke FindServicesCommand**.

     You should see a message with the text **Help Service Available:**  followed by **True** or **False**. To verify this setting, you can use a registry editor, as shown in the earlier steps.
