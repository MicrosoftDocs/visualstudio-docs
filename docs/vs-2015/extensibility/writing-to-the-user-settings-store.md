---
title: "Writing to the User Settings Store | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
ms.assetid: efd27f00-7fe5-45f8-9b97-371af732be97
caps.latest.revision: 4
ms.author: gregvanl
manager: jillfra
---
# Writing to the User Settings Store
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

User settings are writeable settings like the ones in the **Tools / Options** dialog, properties windows, and certain other dialog boxes. Visual Studio extensions may use these to store small amounts of data. This walkthrough shows how to add Notepad to Visual Studio as an external tool by reading from and writing to the user settings store.  
  
### Backing up Your User Settings  
  
1. You must be able to reset the External Tools settings so that you can debug and repeat the procedure. To do this, you must save the original settings so that you can restore them as required.  
  
2. Open Regedit.exe.  
  
3. Navigate to HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\14.0Exp\External Tools\\.  
  
    > [!NOTE]
    > Make sure that you are looking at the key that contains \14.0Exp\ and not \14.0\\. When you run the experimental instance of Visual Studio, your user settings are in the registry hive "14.0Exp".  
  
4. Right-click the \External Tools\ subkey, and then click **Export**. Make sure that **Selected branch** is selected.  
  
5. Save the resulting External Tools.reg file.  
  
6. Later, when you want to reset the External Tools settings, select the HKEY_CURRENT_USER\Software\Microsoft\VisualStudio\14.0Exp\External Tools\ registry key and click **Delete** on the context menu.  
  
7. When the **Confirm Key Delete** dialog box appears, click **Yes**.  
  
8. Right-click the External Tools.reg file that you saved earlier, click **Open with**, and then click **Registry Editor**.  
  
## Writing to the User Settings Store  
  
1. Create a VSIX project named UserSettingsStoreExtension and then add a custom command named UserSettingsStoreCommand. For more information about how to create a custom command, see [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md)  
  
2. In UserSettingsStoreCommand.cs, add the following using statements:  
  
    ```csharp  
    using System.Collections.Generic;  
    using Microsoft.VisualStudio.Settings;  
    using Microsoft.VisualStudio.Shell.Settings;  
    ```  
  
3. In MenuItemCallback, delete the body of the method and get the user settings store, as follows:  
  
    ```csharp  
    private void MenuItemCallback(object sender, EventArgs e)  
    {  
        SettingsManager settingsManager = new ShellSettingsManager(ServiceProvider);  
        WritableSettingsStore userSettingsStore = settingsManager.GetWritableSettingsStore(SettingsScope.UserSettings);  
    }  
    ```  
  
4. Now find out whether Notepad is already set as an external tool. You need to iterate through all the external tools to determine whether the ToolCmd setting is “Notepad”, as follows:  
  
    ```csharp  
    private void MenuItemCallback(object sender, EventArgs e)  
    {  
        SettingsManager settingsManager = new ShellSettingsManager(ServiceProvider);  
        WritableSettingsStore userSettingsStore = settingsManager.GetWritableSettingsStore(SettingsScope.UserSettings);  
  
        // Find out whether Notepad is already an External Tool.  
        int toolCount = userSettingsStore.GetInt32("External Tools", "ToolNumKeys");  
        bool hasNotepad = false;  
        CompareInfo Compare = CultureInfo.InvariantCulture.CompareInfo;  
        for (int i = 0; i < toolCount; i++)  
        {  
            if (Compare.IndexOf(userSettingsStore.GetString("External Tools", "ToolCmd" + i), "Notepad", CompareOptions.IgnoreCase) >= 0)  
            {  
                hasNotepad = true;  
                break;  
            }  
        }  
    }  
  
    ```  
  
5. If Notepad hasn’t been set as an external tool, set it as follows:  
  
    ```vb  
    private void MenuItemCallback(object sender, EventArgs e)  
    {  
        SettingsManager settingsManager = new ShellSettingsManager(ServiceProvider);  
        WritableSettingsStore userSettingsStore = settingsManager.GetWritableSettingsStore(SettingsScope.UserSettings);  
  
        // Find out whether Notepad is already installed.  
        int toolCount = userSettingsStore.GetInt32("External Tools", "ToolNumKeys");  
        bool hasNotepad = false;  
        CompareInfo Compare = CultureInfo.InvariantCulture.CompareInfo;  
        for (int i = 0; i < toolCount; i++)  
        {  
            if (Compare.IndexOf(userSettingsStore.GetString("External Tools", "ToolCmd" + i), "Notepad", CompareOptions.IgnoreCase) >= 0)  
            {  
                hasNotepad = true;  
                break;  
            }  
        }  
  
        string message = (hasNotepad) ? "Notepad already installed" : "Installing Notepad";  
         if (!hasNotepad)  
        {  
            userSettingsStore.SetString("External Tools", "ToolTitle" + toolCount, "&Notepad");  
            userSettingsStore.SetString("External Tools", "ToolCmd" + toolCount, "C:\\Windows\\notepad.exe");  
            userSettingsStore.SetString("External Tools", "ToolArg" + toolCount, "");  
            userSettingsStore.SetString("External Tools", "ToolDir" + toolCount, "$(ProjectDir)");  
            userSettingsStore.SetString("External Tools", "ToolSourceKey" + toolCount, "");  
            userSettingsStore.SetUInt32("External Tools", "ToolOpt" + toolCount, 0x00000011);  
  
            userSettingsStore.SetInt32("External Tools", "ToolNumKeys", toolCount + 1);  
        }  
    }  
    ```  
  
6. Test the code. Remember that it adds Notepad as an External Tool, so you must roll back the registry before running it a second time.  
  
7. Build the code and start debugging.  
  
8. On the **Tools** menu, click **Invoke UserSettingsStoreCommand**. This will add Notepad to the **Tools** menu.  
  
9. Now you should see Notepad on the Tools / Options menu, and clicking **Notepad** should bring up an instance of Notepad.
