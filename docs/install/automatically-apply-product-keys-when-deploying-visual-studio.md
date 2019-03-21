---
title: "Automatically apply product keys"
description: "Learn how to apply product keys programmatically when you deploy Visual Studio."
ms.date: 08/14/2017
ms.custom: "seodec18"
ms.topic: conceptual
ms.assetid: d79260be-6234-4fd3-89b5-a9756b4a93c1
author: TerryGLee
ms.author: tglee
manager: jillfra
ms.workload:
  - "multiple"
ms.prod: visual-studio-windows
ms.technology: vs-installation
---
# Automatically apply product keys when deploying Visual Studio

You can apply your product key programmatically as part of a script that is used to automate the deployment of Visual Studio. You can set a product key on a device programmatically either during an installation of Visual Studio or after an installation completes.

## Apply the license after installation

 You can activate an installed version of Visual Studio with a product key by using the `StorePID.exe` utility on the target machines, in silent mode. `StorePID.exe` is a utility program that installs with Visual Studio 2017 at the following default location: <br> `C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE`

 Run `StorePID.exe` with elevated privileges, either by using a System Center agent or an elevated command prompt. Follow it with the product key and the Microsoft Product Code (MPC).

>[!IMPORTANT]
> Make sure to include the dashes in the product key.

 ```cmd
 StorePID.exe [product key including the dashes] [MPC]
 ```

 The following example shows a command line for applying the license for Visual Studio 2017 Enterprise, which has an MPC of 08860, a product key of `AAAAA-BBBBB-CCCCC-DDDDDD-EEEEEE`, and assumes a default installation location:

 ```cmd
 "C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\Common7\IDE\StorePID.exe" AAAAA-BBBBB-CCCCC-DDDDDD-EEEEEE 08860
 ```

 The following table lists the MPC codes for each edition of Visual Studio:

| Visual Studio Edition                | MPC   |
|--------------------------------------|-------|
| Visual Studio Enterprise 2017        | 08860 |
| Visual Studio Professional 2017      | 08862 |
| Visual Studio Test Professional 2017 | 08866 |

If `StorePID.exe` successfully applies the product key, it returns an `%ERRORLEVEL%` of 0. If it encounters errors, it returns one of the following codes, depending on the error condition:

| Error                     | Code |
|---------------------------|------|
| `PID_ACTION_SUCCESS`      | 0    |
| `PID_ACTION_NOTINSTALLED` | 1    |
| `PID_ACTION_INVALID`      | 2    |
| `PID_ACTION_EXPIRED`      | 3    |
| `PID_ACTION_INUSE`        | 4    |
| `PID_ACTION_FAILURE`      | 5    |
| `PID_ACTION_NOUPGRADE`    | 6    |

[!INCLUDE[install_get_support_md](includes/install_get_support_md.md)]

## See also

* [Install Visual Studio](../install/install-visual-studio.md)
* [Create an offline installation of Visual Studio](../install/create-an-offline-installation-of-visual-studio.md)
