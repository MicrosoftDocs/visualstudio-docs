---
title: Update Visual Studio using a minimal offline layout
description: Learn how to Update Visual Studio using a minimal offline layout.
ms.date: 03/19/2020
ms.custom: seodec18
ms.topic: conceptual
ms.assetid: 
author: takulal
ms.author: takulal
manager: allend
ms.workload:
- multiple
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Update Visual Studio using a minimal offline layout

For computers that are not connected to the internet, creating a minimal layout is the easiest and fastest way to update your offline Visual Studio instances.
<br><br>You can use the minimal layout tool to generate a layout tailored specifically to your team's needs. Enterprise Administrators can use this tool to create update layout(s) for most versions for Visual Studio 2017 and 2019. Unlike a full Visual Studio layout, a minimal layout only contains the updated packages; and therefore, it is always smaller and faster to generate and deploy. Enterprise administrators can further minimize the size of the update layout by specifying only the language, workloads and components that their team needs.

> [!IMPORTANT]
> - If you are not familiar with Layout creation and usage please refer this [doc](update-a-network-installation-of-visual-studio.md).
> - For better understanding of Visual Studio life cycle, refer this [doc](https://docs.microsoft.com/en-us/visualstudio/releases/2019/servicing)

## How to generate a minimal layout to update an offline installation of Visual Studio

This tool is used by enterprise IT administrators for easy deployments to network/offline deployment of VS 2017(15.9) and onwards. During [normal layout creation](update-a-network-installation-of-visual-studio.md), all the packages for that particular release is downloaded. Normal layout creation is required for repair, uninstall and other standard operations. This minimal layout however downloads only updated packages and is ideal for quick updates. Since this contains only updated packages, it is small and easy to copy to offline machines. Minimal layout is designed for quick and easy updates for network/offline scenarios.

### Installing Minimal layout tool
 -	MinimalLayout tool can be downloaded by clicking [here](https://aka.ms/vs/install/minimallayout). Make sure to choose **Save** the Microsoft.VisualStudio.Setup.MinimalLayout.msi. 

 ![Save MinimalLayout](media/save-minimal-layout.png "Save MinimalLayout tool")

 - Click on Run. Accept User account control prompt by clicking yes

 ![Accept user account control](media/accept-user-account-control.png "Accept user account control")

 - The minimal layout tool gets installed under “C:\Program Files (x86)\Microsoft Visual Studio\MinimalLayout” location. 

### How to use Minimal layout tool

MinimalLayout.exe uses following commands and options to generate layout. A command is mandatory for the tool. Please refer to the following commands and option table for detail.

> Syntax: `minimallayout.exe [command] <options>...`

#### Commands: 
1. **Preview**: Use this command to look at how many packages will download, and total space used while creating this layout.
2. **Generate**: This command is used to generate the layout with updated packages
3. **Regenerate**: This command can be used to Generate layout using already existing layout with same parameters. Every generation of a minimal layout produces a MinimalLayout.json file, which captures the original run inputs.  This allows you to easily re-run/replay.  Alternatively, it is an alternative mechanism for managing/setting the tool's parameters.
   - For this command minimallayout.json file path from already generated layout is required. Here is an example:

    ```cmd
    minimalLayout.exe regenerate --filePath C:\MinimalLayout\minimalLayout.json
    ```
4. **Verify**: This command determines if the layout folder is corrupted.
5. **Fix**: This command fixes a corrupted layout folder, including replacing any /missing packages from the layout folder.
<br>
<br>

#### Options: 
|Options    |Description    |Required/Optional|Example|
|:----------|:-----------|:------------|:--------------|
|--targetLocation &lt;dir&gt;    |Specifies a directory in which to create a minimal offline layout       |Required        |--targetLocation c:\VSLayout\
|--baseVersion &lt;version&gt;|The minimal offline layout will be generated starting with this version until the target version   |Required|--baseVersion 16.0.4
|--targetVersion &lt;version&gt;|The minimal offline layout will be generated up to this version|Required|--targetVersion 16.4.4
|--channelId &lt;Id&gt;|	The ID of the channel from which the minimal offline layout will be generated. Only VisualStudio.15.Release and VisualStudio.16.Release are supported|	Required|	--channelId VisualStudio.15.Release
|--languages	|Used to prepare the minimal offline layout with resource packages for the specified language(s). Multiple values can be specified with space as the separator	|Required	|--languages en-US fr-FR
|--productId &lt;id&gt;	|The ID of the product from which the minimal offline layout will be generated. <br> <br>Here is the list of productIds: <ul><li>Microsoft.VisualStudio.Product.Enterprise</li><li>Microsoft.VisualStudio.Product.Professional</li><li>Microsoft.VisualStudio.Product.Community</li><li>Microsoft.VisualStudio.Product.BuildTools</li><li>Microsoft.VisualStudio.Product.TestAgent</li><li>Microsoft.VisualStudio.Product.TestController</li><li>Microsoft.VisualStudio.Product.TeamExplorer</li></ul>|Required|--productId Microsoft.VisualStudio.Product.Enterprise
|--filePath	|This is path of MinimalLayout.json from already created layout. This is used only with Regenerate command. 	|Required for Regenerate command	|--filePath C:\VSLayout\minimalLayout.json
|--add &lt;one or more workload or component IDs&gt;	|One or more workload or component IDs to add. Additional components globally can be added using --includeRecommended and/or –includeOptional instead of listing each workload or component ID. You can mention multiple workloads or component IDs separated by a space	|optional	|--add Microsoft.VisualStudio.Workload.ManagedDesktop Microsoft.VisualStudio.Workload.NetWeb Component.GitHub.VisualStudio
|--includeRecommended	|Includes the recommended components for any workloads that are installed, but not the optional components	|optional	|for specific workload --add Microsoft.VisualStudio.Workload. ManagedDesktop;includeRecommended <br>Or apply to all workload *--includeRecommended* 
|--includeOptional	|Includes the optional components for any workloads that are installed, but not the recommended components.	|optional	|for specific workload--add Microsoft.VisualStudio.Workload. ManagedDesktop;includeOptional <br>Or apply to all workload *--includeOptional*

### How to create minimal layout

> [!IMPORTANT]
>  These instructions assume that you've previously created a network installation layout. For more information about how to do so, see the [Create a network installation of Visual Studio](create-a-network-installation-of-visual-studio.md) page.

Minimal layout can be created by using ***generate*** command for the range of versions. You also need productid, channeled, languages and any specific workloads required. This minimal layout updates any Visual Studio in the range of base version to target version. 

Before creating layout, you can get information on total size of download, total number of packages downloaded by ***preview*** command. This command takes same options as ***generate*** and details are console.

- This example previews generating a minimal layout for an Enterprise product with versions ranging from 15.9.10 to 15.9.20 for the English language.

    ```cmd
    MinimalLayout.exe preview --targetLocation c:\VSLayout\ --productId Microsoft.VisualStudio.Product.Enterprise --channelId VisualStudio.15.Release --baseVersion 15.9.10 --targetVersion 15.9.20 --languages en-US
    ```
- This example generates minimal layout for Enterprise product with versions 15.9.10 to 15.9.20 with one workload for English language

    ```cmd
    MinimalLayout.exe generate --targetLocation c:\VSLayout\ --productId Microsoft.VisualStudio.Product.Enterprise --channelId VisualStudio.16.Release --baseVersion 16.4.0 --targetVersion 16.4.4 --add Microsoft.VisualStudio.Workload.ManagedDesktop;includeOptional --languages en-US
    ```
- An example of regenerating a minimal offline layout using existing minimal layout response file.
    ```cmd
    MinimalLayout.exe regenerate -filepath c:\VSLayout\MinimalLayout.json
    ```
Few other examples of ***generate*** command

- This example generates minimal layout for 2 workloads including recommended only packages.
    ```cmd
    MinimalLayout.exe generate --targetLocation c:\VSLayout\ --productId Microsoft.VisualStudio.Product.Professional --channelId VisualStudio.15.Release --baseVersion 15.9.0 --targetVersion 15.9.14 --add Microsoft.VisualStudio.Workload.ManagedDesktop Microsoft.VisualStudio.Workload.NetWeb;includeRecommended --languages en-US
    ```
- An example for Visual Studio 2019 with multiple languages
    ```cmd
    MinimalLayout.exe generate --targetLocation c:\VSLayout\ --productId Microsoft.VisualStudio.Product.Enterprise --channelId VisualStudio.16.Release --baseVersion 16.0.0 --targetVersion 16.0.10 --add Microsoft.VisualStudio.Workload.ManagedDesktop;includeOptional --languages en-US fr-FR
    ```
- An example of generating a minimal offline layout for updating between minor versions.
    ```cmd
    MinimalLayout.exe generate --targetLocation c:\VSLayout\ --productId Microsoft.VisualStudio.Product.Enterprise --channelId VisualStudio.16.Release --baseVersion 16.0.0 --targetVersion 16.4.0 --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeOptional --languages en-US
    ```
### How to maintain a minimal layout
The ***verify*** and ***fix*** commands can be used to maintain minimal layout after creation. The ***verify*** command can be used to determine if there are any corrupt or missing packages in the minimal layout. If you find any problem after running the ***verify*** command, use the ***fix*** command to correct those missing or corrupt packages.

- An example of verifying a layout to determine if there are corrupt or missing packages in it
    ```cmd
    MinimalLayout.exe Verify --targetLocation c:\VSLayout\ --productId Microsoft.VisualStudio.Product.Enterprise --channelId VisualStudio.16.Release --baseVersion 16.4.0 --targetVersion 16.4.4 --add Microsoft.VisualStudio.Workload.ManagedDesktop --includeRecommended --languages en-US
    ```
- An example of fixing a layout with missing or corrupt packages 
    ```cmd
    MinimalLayout.exe fix --targetLocation C:\VSLayout\ --productId Microsoft.VisualStudio.Product.Enterprise --channelId VisualStudio.16.Release --baseVersion 16.4.0 --targetVersion 16.4.4 --add Microsoft.VisualStudio.Workload.ManagedDesktop;includeOptional --languages en-US
    ```

>[!NOTE] 
> This layout cannot be used for repairing an installation of Visual studio. To repair an existing instance of Visual Studio, follow instructions from this document.

### How to use a minimal offline layout to update an existing installation of Visual Studio

- After generating a minimal layout, you can copy the entire minimal layout folder to a client machine. This is required if the computer doesn’t have access to the minimal layout folder in its original location.

- Navigate to the folder and identify the bootstrapper application name. The name of the bootstrapper application depends on the ProductId value specified while generating the minimal layout. Refer the table below for common examples, you can view the application (.exe files) in the root of the minimal layout folder to determine what bootstrapper applications are available.

    |ProductId value	|Application name|
    |:-----------|:------------|
    |Microsoft.VisualStudio.Product.Enterprise	|vs_enterprise.exe|
    |Microsoft.VisualStudio.Product.Professional	|vs_professional.exe|
    |Microsoft.VisualStudio.Product.Community	|vs_community.exe|
    |Microsoft.VisualStudio.Product.BuildTools	|vs_buildtools.exe|

- The update is applied to a Visual Studio instance in 2 steps. Start by updating the Visual Studio Installer, then update Visual Studio.

    1. Update the Visual Studio installer: substitute the .exe with the bootstrapper that is available in the minimal layout folder)

        ```cmd
        vs_enterprise.exe --quiet --update --offline C:\VSLayout\vs_installer.opc
        ```

    2. Update the Visual Studio application itself: For updating Visual Studio, you need to specify the installPath of the Visual Studio instance you wish to update. (If multiple instances of Visual Studio are installed, each one would be updated separately.). We strongly recommend you specify the ***–noWeb*** option with the update command to prevent the installation of components that aren’t in the minimal layout. This avoids leaving Visual Studio in an unusable state.

        Following example uses installPath as “C:\Program Files(x86)\Microsoft Visual Studio\2019\Enterprise.” Be sure to replace the installPath commad line parameter value with the install path on the computer being updated. (substitute the .exe with the bootstrapper that is available in the minimal layout folder)

        ```cmd
        vs_enterprise.exe update --noWeb --quiet --installpath "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise"
        ```

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
* [Tools for detecting and managing Visual Studio instances](tools-for-managing-visual-studio-instances.md)
* [How to define settings in a response file](automated-installation-with-response-file.md)
* [Control updates to network-based Visual Studio deployments](controlling-updates-to-visual-studio-deployments.md)
* [Visual Studio product lifecycle and servicing](/visualstudio/releases/2019/servicing/)
