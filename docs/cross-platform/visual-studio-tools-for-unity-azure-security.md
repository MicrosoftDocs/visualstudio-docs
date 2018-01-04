---
title: "Visual Studio Tools for Unity Azure Walkthrough Security| Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2017"
ms.reviewer: "crdun"
ms.suite: ""
ms.technology: 
  - "tgt-pltfrm-cross-plat"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: F4FD6E1C-EA64-4613-BDDE-6E4E5CCF983E
author: "dantogno"
ms.author: "v-davian"
manager: "crdun"
ms.workload: 
  - "azure"
  - "unity"
---

# Update Unity Mono security certificate store

Unity's Mono ships with an empty certificate store and therefore does not trust any site. You can read more about this on the [Mono security FAQ](http://www.mono-project.com/docs/faq/security/).

In order to connect to Azure without ignoring TLS / SSL, the Unity Mono certificate store must be updated.

## Using mozroots to install certificates

The mozroots tool is included in Mono. It downloads and installs Mozilla's list of root certificates.

1. Open the command prompt terminal.

2. Navigate in the terminal to the **C:\Program Files\Unity\Editor\Data\MonoBleedingEdge\bin>** directory. The exact location may differ depending on where you installed Unity on your local machine.

3. Type the following command and hit **Enter** to run it:

  `mono ..\lib\mono\4.5\mozroots.exe --sync --import`

4. You should get the following output (though the number or certificates added may differ):

  ```
  Downloading from 'https://hg.mozilla.org/releases/mozilla-release/raw-file/default/security/nss/lib/ckfw/builtins/certdata.txt'...
  Importing certificates into user store...
  1 new root certificates were added to your trust store.
  Import process completed.
  ```

5. Now you should be able to run the example project without receiving TLS related errors.

## Next step

* [Test the client connection](visual-studio-tools-for-unity-azure-connection.md)
