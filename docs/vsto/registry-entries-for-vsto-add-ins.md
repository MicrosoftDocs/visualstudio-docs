---
title: "Registry entries for VSTO Add-ins"
description: Develop a set of registry entries when you deploy VSTO add-ins created with Visual Studio, such as the LoadBehavior entry that specifies add-in run-time behavior.
ms.date: "01/27/2022"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "LoadBehavior entry"
  - "add-ins [Office development in Visual Studio], registry entries"
  - "registry keys [Office development in Visual Studio]"
  - "application-level add-ins [Office development in Visual Studio], registry entries"
  - "registry entries [Office development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# Registry entries for VSTO Add-ins

  You must create a specific set of registry entries when you deploy VSTO Add-ins that are created by using Visual Studio. These registry entries provide information that enables the Microsoft Office application to discover and load the VSTO Add-in.

 [!INCLUDE[appliesto_allapp](../vsto/includes/appliesto-allapp-md.md)]

[!include[Add-ins note](includes/addinsnote.md)]

 When you build your project, Visual Studio creates these registry entries on the development computer. This helps you easily run and debug the VSTO Add-in. Using ClickOnce to deploy your VSTO Add-in, the registry entries are automatically created on the end-user computer. 

For more information about how to deploy a VSTO Solution Using Windows Installer, see [Deploying a VSTO Solution Using Windows Installer](../vsto/deploying-a-vsto-solution-by-using-windows-installer.md).

 For more information about how the registry entries are used during the load process for VSTO Add-ins, see [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md).

> [!NOTE]
> In this topic, the text *add-in ID* represents a unique ID for your VSTO Add-in. By default, the ID is the name of your VSTO Add-in assembly.

## Register VSTO Add-ins for the current user vs. all users
 When a VSTO Add-in is installed, it can be registered in two ways:

- For the current user only (The VSTO Add-in is available only to the user that was logged onto the computer when the Add-in was installed). In this case, the registry entries are created under the **HKEY_CURRENT_USER**.

- For all users (that is, any user that signs in to the computer can use the VSTO Add-in). In this case, the registry entries are created under **HKEY_LOCAL_MACHINE**.

  All VSTO Add-ins that you create by using Visual Studio can be registered for the current user. However, VSTO Add-ins can be registered for all users only in certain scenarios. These scenarios depend on the version of Microsoft Office on the computer and how the VSTO Add-in was deployed.

### Deployment type
 If you use ClickOnce to deploy a VSTO Add-in, the VSTO Add-in can be registered only for the current user. This is because ClickOnce only supports creating keys under **HKEY_CURRENT_USER**. If you want to register a VSTO Add-in to all users on a computer, you must use Windows Installer to deploy the VSTO Add-in. For more information about these deployment types, see [Deploy an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md) and [Deploy an Office solution by using Windows Installer](../vsto/deploying-a-vsto-solution-by-using-windows-installer.md).

## Registry entries
 The required VSTO Add-in registry entries are located under the following registry keys where *Root* is **HKEY_CURRENT_USER** or **HKEY_LOCAL_MACHINE** depending if the installation is for the current user or all users.

|Office Application|Configuration Path|
|------------------|------------------|
|Visio|*Root*\Software\Microsoft\\*Visio*\Addins\\*add-in ID*|
|All Other|*Root*\Software\Microsoft\Office\\*Office application name*\Addins\\*add-in ID*|

> [!NOTE]
> If the installer is targeting all users on 64-bit Windows, it is recommended that it includes two registry entries, one under the HKEY_LOCAL_MACHINE\Software\Microsoft and one under the HKEY_LOCAL_MACHINE\Software\\**WOW6432Node**\Microsoft hive. This is because it's possible for users to use either 32-bit or 64-bit versions of Office on the computer.
>
>If the Installer is targeting the current user, it doesn't need to install to the WOW6432Node because the HKEY_CURRENT_USER\Software path is shared.
>
>For more information, see [32-bit and 64-bit Application Data in the Registry](/windows/win32/sysinfo/32-bit-and-64-bit-application-data-in-the-registry).

 The following table lists the entries under this registry key.

|Entry|Type|Value|
|-----------|----------|-----------|
|**Description**|REG_SZ|Required. A brief description of the VSTO Add-in.<br /><br /> This description is displayed when the user selects the VSTO Add-in in the **Add-Ins** pane of the **Options** dialog box in the Microsoft Office application.|
|**FriendlyName**|REG_SZ|Required. A descriptive name of the VSTO Add-in that is displayed in the **COM Add-Ins** dialog box in the Microsoft Office application. The default value is the VSTO Add-in ID.|
|**LoadBehavior**|REG_DWORD|Required. A value that specifies when the application attempts to load the VSTO Add-in and the current state of the VSTO Add-in (loaded or unloaded).<br /><br /> By default, this entry is set to 3, which specifies that the VSTO Add-in is loaded at startup. For more information, see [LoadBehavior values](#LoadBehavior).<br /><br />**Note:**  If a user disables the VSTO Add-in, that action modifies **LoadBehavior** value in the **HKEY_CURRENT_USER** registry hive. For each user, the value of the **LoadBehavior** value in the HKEY_CURRENT_USER hive overrides the default **LoadBehavior** defined in the **HKEY_LOCAL_MACHINE** hive.|
|**Manifest**|REG_SZ|Required. The full path of the deployment manifest for the VSTO Add-in. The path can be a location on the local computer, a network share (UNC), or a Web server (HTTP).<br /><br /> If you use Windows Installer to deploy the solution, you must add the prefix **file:///** to the **manifest** path. You must also append the string **&#124;vstolocal** (that is, the pipe character **&#124;** followed by **vstolocal**) to the end of this path. This ensures that your solution is loaded from the installation folder, rather than the ClickOnce cache. For more information, see [Deploy an Office solution by using Windows Installer](../vsto/deploying-a-vsto-solution-by-using-windows-installer.md).<br /><br />**Note:**  When you build a VSTO Add-in on the development computer, Visual Studio automatically appends the **&#124;vstolocal** string to this registry entry.|

### <a name="OutlookEntries"></a> Registry entries for Outlook form regions
 If you create a custom form region in a VSTO Add-in for Outlook, additional registry entries are used to register the form region with Outlook. These entries are created under a different registry key for each message class that the form region supports. These registry keys are in the following location, where *Root* is **HKEY_CURRENT_USER** or **HKEY_LOCAL_MACHINE**.

 *Root*\Software\Microsoft\Office\Outlook\FormRegions\\*message class*

 Like the other registry entries shared by all VSTO Add-ins, Visual Studio creates the form region registry entries on the development computer when you build your project. Using ClickOnce to deploy your VSTO Add-in, the registry entries are automatically created on the end-user computer. When you use Windows Installer to deploy your VSTO Add-in, you must configure the InstallShield Limited Edition project to create the registry entries on the end-user computer.

 For more information about the form region registry entries, see [Specify the location of a form region in a custom form](/office/vba/outlook/Concepts/Creating-Form-Regions/specify-the-location-of-a-form-region-in-a-custom-form). For more information about Outlook form regions, see [Create Outlook form regions](../vsto/creating-outlook-form-regions.md).

## <a name="LoadBehavior"></a> LoadBehavior values
 The **LoadBehavior** entry under the *Root*\Software\Microsoft\Office\\*application name*\Addins\\*add-in ID* key contains a bitwise combination of values that specify the run time behavior of the VSTO Add-in. The lowest order bit (values 0 and 1) indicates whether the VSTO Add-in is currently unloaded or loaded. Other bits indicate when the application attempts to load the VSTO Add-in.

 Typically, the **LoadBehavior** entry is intended to be set to 0, 3, or 16 (in decimal) when the VSTO Add-in is installed on end-user computers. By default, Visual Studio sets the **LoadBehavior** entry of your VSTO Add-in to 3 when you build or publish it.

 The following table lists all the possible values of the **LoadBehavior** entry. Some descriptions in this table refer to loading a VSTO Add-in manually or programmatically. To load a VSTO Add-in manually, select the check box next to the VSTO Add-in in the **COM Add-Ins** dialog box in the application. To load a VSTO Add-in programmatically, set the <xref:Microsoft.Office.Core.COMAddIn.Connect%2A> property of the <xref:Microsoft.Office.Core.COMAddIn> object that represents the VSTO Add-in to **true**.

|Value (in decimal)|VSTO Add-in status|VSTO Add-in load behavior|Description|
|--------------------------|-------------------------|--------------------------------|-----------------|
|0|Unloaded|Don't load automatically|The application never tries to load the VSTO Add-in automatically. The user can try to manually load the VSTO Add-in, or the VSTO Add-in can be loaded programmatically.<br /><br /> If the VSTO Add-in is successfully loaded, the **LoadBehavior** value remains 0, but the status of the VSTO Add-in in the **COM Add-ins** dialog box is updated to indicate that the VSTO Add-in is loaded.|
|1|Loaded|Don't load automatically|The application never tries to load the VSTO Add-in automatically. The user can try to manually load the VSTO Add-in, or the VSTO Add-in can be loaded programmatically.<br /><br /> Although the **COM Add-ins** dialog box indicates that the VSTO Add-in is loaded after the application starts, the VSTO Add-in isn't loaded until it's loaded manually or programmatically.<br /><br /> If the application successfully loads the VSTO Add-in, the **LoadBehavior** value changes to 0, and remains at 0 after the application closes.|
|2|Unloaded|Load at startup|The application doesn't try to load the VSTO Add-in automatically. The user can try to manually load the VSTO Add-in, or the VSTO Add-in can be loaded programmatically.<br /><br /> If the application successfully loads the VSTO Add-in, the **LoadBehavior** value changes to 3, and remains at 3 after the application closes.|
|3|Loaded|Load at startup|The application tries to load the VSTO Add-in when the application starts. This is the default value when you build or publish a VSTO Add-in in Visual Studio.<br /><br /> If the application successfully loads the VSTO Add-in, the **LoadBehavior** value remains 3. If an error occurs when loading the VSTO Add-in, the **LoadBehavior** value changes to 2, and remains at 2 after the application closes.|
|8|Unloaded|Load on demand|The application doesn't try to load the VSTO Add-in automatically. The user can try to manually load the VSTO Add-in, or the VSTO Add-in can be loaded programmatically.<br /><br /> If the application successfully loads the VSTO Add-in, the **LoadBehavior** value changes to 9.|
|9|Loaded|Load on demand|The VSTO Add-in will be loaded only when the application requires it. Such as when a user selects a UI element that uses functionality in the VSTO Add-in (for example, a custom button in the Ribbon).<br /><br /> If the application successfully loads the VSTO Add-in, the **LoadBehavior** value remains 9, but the status of the VSTO Add-in in the **COM Add-ins** dialog box is updated to indicate that the VSTO Add-in is currently loaded. If an error occurs when loading the VSTO Add-in, the **LoadBehavior** value changes to 8.|
|16|Loaded|Load first time, then load on demand|Set this value if you want your VSTO Add-in to be loaded on demand. The application loads the VSTO Add-in when the user runs the application for the first time. The next time the user runs the application, the application loads any UI elements that are defined by the VSTO Add-in. However, the VSTO Add-in isn't loaded until the user selects a UI element that is associated with the VSTO Add-in.<br /><br /> When the application successfully loads the VSTO Add-in for the first time, the **LoadBehavior** value remains 16 while the VSTO Add-in is loaded. After the application closes, the **LoadBehavior** value changes to 9.|

## Related content
- [Architecture of Office solutions in Visual Studio](../vsto/architecture-of-office-solutions-in-visual-studio.md)
- [Architecture of VSTO Add-ins](../vsto/architecture-of-vsto-add-ins.md)
- [Build Office solutions](../vsto/building-office-solutions.md)
- [Deploy an Office solution](../vsto/deploying-an-office-solution.md)
 
