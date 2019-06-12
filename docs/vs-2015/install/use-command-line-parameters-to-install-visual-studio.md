---
title: "Use Command-Line Parameters to Install Visual Studio 2015 | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
f1_keywords:
  - "command-line parameters"
  - "switches"
  - "command prompt"
ms.assetid: 480f3cb4-d873-434e-a8bf-82cff7401cf2
caps.latest.revision: 10
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# Use Command-Line Parameters to Install Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [Use command-line parameters to install Visual Studio](/visualstudio/install/use-command-line-parameters-to-install-visual-studio).

When you install Visual Studio 2015 from a command prompt, you can use the following command-line parameters (also known as switches).

> [!NOTE]
> Make sure that you use the actual installer and not the bootstrapper file. For example, make sure you use **`vs_enterprise.exe`** instead of vs_enterprise_*GUID*.exe. You can download an installer from [My.VisualStudio.com](https://my.visualstudio.com/downloads?q=visual%20studio%20enterprise%202015).

## List of command-line parameters

Visual Studio command-line parameters are not case-sensitive.

|Parameter|Description|
|---------------|-----------------|
|**/?**<br /><br /> **/help**<br /><br /> **/h**|Displays command-line parameters.|
|**/AddRemoveFeatures**|Specifies which features to add or remove from the installed product.|
|**/AdminFile** *AdminDeployment.xml*|Installs Visual Studio using the data file that you specified for administrative installation.|
|**/ChainingPackage** *BundleName*|Specifies which bundle is chaining this bundle. Also can be used to specify a Customer Improvement Experience cohort.|
|**/CreateAdminFile \<filename>**|Specifies the location to create a control file that can be used with /AdminFile|
|**/CustomInstallPath** *InstallationDirectory*|Installs all re-targetable packages in the directory that you specify.|
|**/ForceRestart**|Always restarts the computer after installation.|
|**/full**|Installs all product features.|
|**/InstallSelectableItems \<item name 1>[;\<item name 2>]**|List of selection tree items to check on the selection screen of the installer wizard.|
|**/l**<br /><br /> **/Log** *Filename*|Specifies a location for the log file.|
|**/layout** *Directory*|Copies the files on the installation media to the directory that you specify.|
|**/NoCacheOnlyMode**|Prevents pre-population of the package cache.|
|**/NoRefresh**|Prevents the check for newer versions of this product for either required or recommended updated versions.|
|**/norestart**|Prevents the installation application from restarting the computer during or after installation. See the Return Codes section of the [Visual Studio Administrator Guide](../install/visual-studio-administrator-guide.md) for the return codes to look for.|
|**/noweb**|Prevents installation from the Internet.|
|**/OverrideFeedUri \<path to feed file>**|Path to a local, external feed that describes software items|
|**/ProductKey**<br /><br /> *ProductKey*|Sets a custom product key that contains no dashes and no more than 25 characters.|
|**/PromptRestart**|Prompts the user before restarting the computer.|
|**/q**<br /><br /> **/quiet**<br /><br /> **/s**<br /><br /> **/silent**|Suppresses the user interface (UI) for the installation application. If Visual Studio is already installed and you specify no parameters except this one, the installation application runs in Maintenance mode.|
|**/qb**<br /><br /> **/passive**|Shows progress but doesn't wait for user input.|
|**/repair**|Repairs Visual Studio.|
|**/SuppressRefreshPrompt**|Prevents displaying the update available dialog in the installation wizard, thus, the installation wizard will auto-accept any required or recommended updated versions.|
|**/u**<br /><br /> **/Uninstall**|Uninstalls [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].|
|**/Uninstall /Force**<br /><br /> **/u /force**|Uninstalls Visual Studio and all features that are shared with other products. **Warning:**  If you use this parameter, other products that are installed on the same computer might stop functioning correctly.|

## See Also

- [Visual Studio Administrator Guide](../install/visual-studio-administrator-guide.md)