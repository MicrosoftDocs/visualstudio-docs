---
title: Include a data file in a ClickOnce app
description: Learn how to add a data file of any type into your ClickOnce application to be stored in a data directory on the destination computer local disk.
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - VB
  - CSharp
  - C++
helpviewer_keywords: 
  - ClickOnce deployment, data
  - deploying applications [ClickOnce], data files
  - data access, ClickOnce applications
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Include a data file in a ClickOnce application

Each ClickOnce application you install is assigned a data directory on the destination computer's local disk where the application can manage its own data. Data files can include files of any type: text files, XML files, or even Microsoft Access database (*.mdb*) files. The following procedures show you how to add a data file of any type into your ClickOnce application.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-dotnetmage-exe.md)]

### To include a data file by using Mage.exe

1. Add the data file to your application directory with the rest of your application's files.

    Typically, your application directory will be a directory labeled with the deployment's current version—for example, v1.0.0.0.

2. Update your application manifest to list the data file.

    `mage -u v1.0.0.0\Application.manifest -FromDirectory v1.0.0.0`

    Performing this task re-creates the list of files in your application manifest and also automatically generates the hash signatures.

3. Open the application manifest in your preferred text or XML editor and find the `file` element for your recently added file.

    If you added an XML file named `Data.xml`, the file will look similar to the following code example.

   `<file name="Data.xml" hash="AA11BB22CC33DD44EE55FF66AA77BB88CC99DD00" hashalg="SHA1" asmv2:size="39500" />`

4. Add the attribute `type` to this element, and supply it with a value of `data`.

   `<file name="Data.xml" writeableType="applicationData" hash="AA11BB22CC33DD44EE55FF66AA77BB88CC99DD00" hashalg="SHA1" asmv2:size="39500" />`

5. Re-sign your application manifest by using your key pair or certificate, and then re-sign your deployment manifest.

    You must re-sign your deployment manifest because its hash of the application manifest has changed.

    `mage -s app manifest -cf cert_file -pwd password`

    `mage -u deployment manifest -appm app manifest`

    `mage -s deployment manifest -cf certfile -pwd password`

### To include a data file by using MageUI.exe

1. Add the data file to your application directory with the rest of your application's files.

2. Typically, your application directory will be a directory labeled with the deployment's current version—for example, v1.0.0.0.

3. On the **File** menu, click **Open** to open your application manifest.

4. Select the **Files** tab.

5. In the text box at the top of the tab, enter the directory that contains your application's files, and then click **Populate**.

     Your data file will appear in the grid.

6. Set the **File Type** value of the data file to **Data**.

7. Save the application manifest, and then re-sign the file.

     *MageUI.exe* will prompt you to re-sign the file.

8. Re-sign your deployment manifest

     You must re-sign your deployment manifest because its hash of the application manifest has changed.

## Related content
- [Access local and remote data in ClickOnce applications](../deployment/accessing-local-and-remote-data-in-clickonce-applications.md)
