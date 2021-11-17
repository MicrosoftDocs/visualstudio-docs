---
title: Visual Studio for Mac 8.10 and .NET on Apple Silicon machines
description: Steps for getting supported versions of .NET working in 2019 on M1 machines.
author: heiligerdankgesang
ms.author: dominicn
ms.date: 11/08/2021
ms.assetid: db2dc420-63d2-44ef-bdda-a351561dc900
---

# Visual Studio for Mac 8.10 and .NET on Apple Silicon machines

On Apple Silicon machines (also known as M1 or ARM), Visual Studio for Mac 8.10 does not currently support the .NET 6, .NET 5 and .NET Core 3.1 x64 SDKs released in November. It also does not support the .NET 6 Arm64 SDK. If any of these are installed, then they will break Visual Studio for Mac 8.10, and should be uninstalled, and the older .NET SDKs installed. 

> [!NOTE]
> This information is specific for Visual Studio for Mac 2019 (8.10.x) versions. For information on this process for Visual Studio for Mac 2022 Preview versions, see [Visual Studio for Mac 17.0 and .NET on Apple Silicon machines](/visualstudio/mac/uninstall-net-2022) for details.

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

1. Install the October releases of the .NET 5 and .NET Core 3.1 x64 SDKs 
    - [.NET 5.0.402 x64 SDK](https://download.visualstudio.microsoft.com/download/pr/88bc1553-e90f-4a4f-9574-65d9a5065cd2/1d5646e1abb8b4d4a61ba0b0be976047/dotnet-sdk-5.0.402-osx-x64.pkg)
    - [.NET Core 3.1.414 x64 SDK](https://download.visualstudio.microsoft.com/download/pr/0517421d-3300-42c7-a420-e42d55068126/76b722e65c0745962156e622ed76501c/dotnet-sdk-3.1.414-osx-x64.pkg)
2. Restart Visual Studio for Mac for it to detect the new SDKs installed. 
