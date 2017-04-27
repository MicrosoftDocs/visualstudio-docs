---
title: "Automatically apply product keys when deploying Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "3/10/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: d79260be-6234-4fd3-89b5-a9756b4a93c1
caps.latest.revision: 10
author: "TerryGLee"
ms.author: "tglee"
manager: "ghogen"
translation.priority.ht:
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt:
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Automatically apply product keys when deploying Visual Studio
You can apply your product key programmatically as part of a script used to automate the deployment of Visual Studio. Product keys can be set on a device programmatically during installation of Visual Studio or after an installation completed.  

## Apply the license after installation  
 You can activate an installed version of Visual Studio with a product key by using the storePID.exe utility on the target machines in silent mode. StorePID.exe is a utility program that installs with Visual Studio at **\<drive>:\\\Program Files (x86)\Microsoft Visual Studio 15.0\Common7\IDE\StorePID.exe**.  

 Run storePID.exe with elevated privileges, either by using a System Center agent or an elevated command prompt, followed by the product key (including the dashes) and the Microsoft Product Code (MPC). Please be sure to include the dashes in the product key!  

 `StorePID.exe [product key including the dashes] [MPC]`  

 This is an example command line for installing Visual Studio 2017 Enterprise, which has a MPC of 08860, with a product key "AAAAA-BBBBB-CCCCC-DDDDDD-EEEEEE":  

 `C:\Program Files (x86)\Microsoft Visual Studio 15.0\Common7\IDE\StorePID.exe AAAAA-BBBBB-CCCCC-DDDDDD-EEEEEE 08860`  

 The following table lists the MPC codes for each edition of Visual Studio:  

|Visual Studio Edition | MPC |  
|---------------------------|---------|
|Visual Studio Enterprise 2017|08860|  
|Visual Studio Professional 2017|08862|  
|Visual Studio Test Professional 2017|08866|

If StorePID.exe successfully applied the product key, it will return 0. If it encounters errors, it will return a number ranging from 1 to 6.  

## See Also  
 * [Install Visual Studio](../install/install-visual-studio.md)
 * [Create an offline installation of Visual Studio](../install/create-an-offline-installation-of-visual-studio.md)
