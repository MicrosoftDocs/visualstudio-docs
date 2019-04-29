---
title: "How to: Specify Which Files Are Published by ClickOnce | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "Microsoft.VisualStudio.Publish.BaseProvider.Dialog.File"
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "ClickOnce deployment, file exclusion"
  - "files, publishing via ClickOnce"
ms.assetid: 579c134a-d50f-4e0c-8e05-2a4ff654896a
author: mikejo5000
ms.author: mikejo
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Specify which files are published by ClickOnce
When publishing a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application, all non-code files in the project are deployed along with the application. In some cases, you may not want or need to publish certain files, or you may want to install certain files based on conditions. Visual Studio provides the capabilities to exclude files, mark files as data files or prerequisites, and create groups of files for conditional installation.

 Files for a [!INCLUDE[ndptecclick](../deployment/includes/ndptecclick_md.md)] application are managed in the **Application Files** dialog box, accessible from the **Publish** page of the **Project Designer**.

 Initially, there is a single file group named **(Required)**. You can create additional file groups and assign files to them. You cannot change the **Download Group** for files that are required for the application to run. For example, the application's .exe or files marked as data files must belong to the **(Required)** group.

 The default publish status value of a file is tagged with **(Auto)**. For example, the application's .exe has a publish status of **Include (Auto)** by default.

 Files with the **Build Action** property set to **Content** are designated as application files and will be marked as included by default. They can be included, excluded, or marked as data files. The exceptions are as follows:

- Data files such as SQL Database (*.mdf* and *.mdb*) files and XML files will be marked as data files by default.

- References to assemblies (*.dll* files) are designated as follows when you add the reference: If **Copy Local** is **False**, it is marked by default as a prerequisite assembly (**Prerequisite (Auto)**) that must be present in the GAC before the application is installed. If **Copy Local** is **True**, the assembly is marked by default as an application assembly (**Include (Auto)**) and will be copied into the application folder at installation. A COM reference will appear in the **Application Files** dialog box (as an *.ocx* file) only if its **Isolated** property is set to **True**. By default, it will be included.

### To add files to the Application Files dialog box

1. Select a data file in **Solution Explorer**.

2. In the Properties window, change the **Build Action** property to the **Content** value.

### To exclude files from ClickOnce publishing

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Application Files** button to open the **Application Files** dialog box.

4. In the **Application Files** dialog box, select the file that you wish to exclude.

5. In the **Publish Status** field, select **Exclude** from the drop-down list.

### To mark files as data files

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Application Files** button to open the **Application Files** dialog box.

4. In the **Application Files** dialog box, select the file that you wish to mark as data.

5. In the **Publish Status** field, select **Data File** from the drop-down list.

### To mark files as prerequisites

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Application Files** button to open the **Application Files** dialog box.

4. In the **Application Files** dialog box, select the application assembly (*.dll* file) that you wish to mark as a prerequisite. Note that your application must have a reference to the application assembly in order for it to appear in the list.

5. In the **Publish Status** field, select **Prerequisite** from the drop-down list.

### To add a new file group

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Application Files** button to open the **Application Files** dialog box.

4. In the **Application Files** dialog box, select the **Group** field for a file that you wish to include in the new group.

    > [!NOTE]
    > Files must have the **Build Action** property set to **Content** before the file names appear in the **Application Files** dialog box.

5. In the **Download Group** field, select **\<New...>** from the drop-down list.

6. In the **New Group** dialog box, enter a name for the group, and then click **OK**.

### To add a file to a group

1. With a project selected in **Solution Explorer**, on the **Project** menu, click **Properties**.

2. Click the **Publish** tab.

3. Click the **Application Files** button to open the **Application Files** dialog box.

4. In the **Application Files** dialog box, select the **Group** field for a file that you wish to include in the new group.

5. In the **Download Group** field, select a group from the drop-down list.

    > [!NOTE]
    > You cannot change the **Download Group** for files that are required for the application to run.

## See also
- [Publish ClickOnce applications](../deployment/publishing-clickonce-applications.md)
- [How to: Publish a ClickOnce application using the Publish Wizard](../deployment/how-to-publish-a-clickonce-application-using-the-publish-wizard.md)