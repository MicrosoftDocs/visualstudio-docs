---
title: Visual Studio for Mac 17.0 and .NET on Apple Silicon machines
description: Steps for getting supported versions of .NET working in 2022 on M1 machines.
author: heiligerdankgesang
ms.author: dominicn
ms.date: 11/08/2021
ms.assetid: 18f722bc-3d9d-4c75-9e77-d66b64784c8d
---

# Visual Studio for Mac 17.0 Previews and .NET on Apple Silicon machines

On Apple Silicon machines (also known as M1 or ARM) with older x64 SDKs installed, you'll need to remove all existing .NET installations in order to use the .NET 6 GA Arm64 SDK.  

> [!NOTE]
> This information is specific for Visual Studio for Mac 2022 Preview (17.0) versions. For information on this process for Visual Studio for Mac 2019 versions, see [Visual Studio for Mac 8.10 and .NET on Apple Silicon machines](/visualstudio/mac/uninstall-net-2019) for details.

## Uninstall .NET from your machine: 

1. Download the [uninstall script](https://github.com/dotnet/sdk/blob/main/scripts/obtain/uninstall/dotnet-uninstall-pkgs.sh) from the .NET GitHub repository by right-clicking on the script and selecting **Save As** to save the file to your Mac.
2. Open Terminal and change the working directory to where the script was downloaded:
 
    ```bash
    cd /location/of/file
    ```
3. Make the script executable and then run it with **sudo**:

    ```bash
    chmod +x dotnet-uninstall-pkgs.sh 
    sudo ./dotnet-uninstall-pkgs.sh
    sudo rm -r /etc/dotnet
    ```  

## Install supported .NET SDKs

1. [Install the .NET 6 Arm64 SDK](https://download.visualstudio.microsoft.com/download/pr/ed60d37e-7842-4fc2-8250-2bd66073d79e/725d486e04d27e45d2b41c687dc35f49/dotnet-sdk-6.0.100-osx-arm64.pkg)
2. Restart Visual Studio for Mac for it to detect the new SDK installed. 
