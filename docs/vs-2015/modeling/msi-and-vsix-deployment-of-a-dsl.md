---
title: "VSIX Deployment of a DSL | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 6ce16f06-1978-4e19-8cdc-441ee65a3fb2
caps.latest.revision: 4
author: jillre
ms.author: jillfra
manager: jillfra
---
# VSIX Deployment of a DSL
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can install a domain-specific language on your own computer or on other computers. [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] must already be installed on the target computer.

## <a name="Installing"></a> Installing and Uninstalling a DSL by using the VSX
 When your DSL is installed by this method, the user can open a DSL file from within [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], but the file cannot be opened from Windows Explorer.

#### To install a DSL by using the VSIX

1. In your computer, find the **.vsix** file that was built by your DSL Package project.

    1. In **Solution Explorer**, right-click the **DslPackage** project, and then click **Open Folder in Windows Explorer**.

    2. Locate the file **bin\\\*\\**_YourProject_**.DslPackage.vsix**

2. Copy the **.vsix** file to the target computer on which you want to install the DSL. This can be your own computer or another one.

    - The target computer must have one of the editions of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] that supports DSLs at run time. For more information, see [Supported Visual Studio Editions for Visualization & Modeling SDK](../modeling/supported-visual-studio-editions-for-visualization-amp-modeling-sdk.md).

    - The target computer must have one of the editions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] specified in **DslPackage\source.extensions.manifest**.

3. On the target computer, double-click the **.vsix** file.

     **Visual Studio Extension Installer** opens and installs the extension.

4. Start or restart [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)].

5. To test the DSL, use [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to create a new file that has the extension that you defined for your DSL.

#### To uninstall a DSL that was installed by using VSX

1. On the **Tools** menu, click **Extension Manager**.

2. Expand **Installed Extensions**.

3. Select the extension in which the DSL is defined, and then click **Uninstall**.

   Rarely, a faulty extension fails to load and creates a report in the error window, but does not appear in Extension Manager. In that case, you can remove the extension by deleting the file from:

   *LocalAppData* **\Microsoft\VisualStudio\10.0\Extensions**
