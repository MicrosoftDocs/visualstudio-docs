---
title: "How to: Automatically apply product keys when deploying Visual Studio 2015 | Microsoft Docs"
titleSuffix: ""
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
ms.assetid: d79260be-6234-4fd3-89b5-a9756b4a93c1
caps.latest.revision: 11
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# How to: Automatically apply product keys when deploying Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

For the latest documentation on Visual Studio, see [Automatically apply product keys when deploying Visual Studio](/visualstudio/install/automatically-apply-product-keys-when-deploying-visual-studio).

You can apply your product key programmatically as part of a script used to automate the deployment of Visual Studio 2015. Product keys can be set on a device programmatically during installation of Visual Studio or after an installation completed.

## Apply the license during installation
 Use the /ProductKey parameter to apply a product key during Visual Studio’s setup process. This setup parameter can be used with the /Silent parameter to install Visual Studio in an already licensed state for an end user. To use the /ProductKey parameter, open up a command prompt. Run the setup program (for example, vs_enterprise.exe or vs_professional.exe) and set the /ProductKey parameter with a product key (25 characters) that includes no dashes:

 This is an example command for installing Visual Studio 2015 Enterprise with product key AAAAABBBBBCCCCCDDDDDEEEEEEE:

 `vs_enterprise.exe [any other setup parameters] /ProductKey AAAAABBBBBCCCCCDDDDDDEEEEEE`

## Apply the license after installation
 You can activate an installed version of Visual Studio with a product key by using the storePID.exe utility on the target machines in silent mode. StorePID.exe is a utility program that installs with Visual Studio at **\<drive>:\\\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\StorePID.exe**.

 Run storePID.exe with elevated privileges, either by using a System Center agent or an elevated command prompt, followed by the product key (including the dashes) and the Microsoft Product Code (MPC). Be sure to include the dashes in the product key!

 `StorePID.exe [product key including the dashes] [MPC]`

 This is an example command line for installing Visual Studio 2015 Enterprise, which has an MPC of 07060, with a product key "AAAAA-BBBBB-CCCCC-DDDDDD-EEEEEE":

 `C:\Program Files (x86)\Microsoft Visual Studio 14.0\Common7\IDE\StorePID.exe AAAAA-BBBBB-CCCCC-DDDDDD-EEEEEE 07060`

 The following table lists the MPC codes for each edition of Visual Studio:

|Visual Studio Edition|MPC|
|---------------------------|---------|
|Visual Studio Enterprise 2015|07060|
|Visual Studio Professional 2015|07062|
|Visual Studio Test Professional 2015|07066|
|Visual Studio Ultimate 2013|06181|
|Visual Studio Premium 2013|06191|
|Visual Studio Professional 2013|06177|
|Visual Studio Test Professional 2013|06194|

For more information on getting a product key, see [How to: Locate the Visual Studio Product Key](../install/how-to-locate-the-visual-studio-product-key.md).

If StorePID.exe successfully applied the product key, it will return 0. If it encounters errors, it will return a number ranging from 1 to 6.

## See also

- [Install Visual Studio](../install/install-visual-studio-2015.md)