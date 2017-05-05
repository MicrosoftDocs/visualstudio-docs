---
title: "Control updates to Visual Studio deployments | Microsoft Docs"
description: "{{PLACEHOLDER}}"
ms.date: "04/14/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords:
  - "{{PLACEHOLDER}}"
  - "{{PLACEHOLDER}}"
ms.assetid: 35C7AB05-07D5-4B38-BCAC-AB88444E7368
author: "timsneath"
ms.author: "tims"
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
# Control updates to network-based Visual Studio deployments

Enterprise administrators often create a layout and host it on a network file share for deployment to their end-users.

By default, Visual Studio will continue to look online for updates even if the installation was deployed from a network share. If an update is available, the user will be able to install it; any updated content that is not found in the offline layout will be downloaded from the web.

If you want to control how end-users receive Visual Studio product update notifications, as well as which version your users are updated to, you can modify the location that Visual Studio looks for updates by following these steps:

 1. Create an offline layout:
    ```
    vs_enterprise.exe --layout C:\vs2017offline --lang en-US
    ```
 2. Copy it to the file share where you want to host it:
    ```
    xcopy /e C:\vs2017offline \\server\share\VS2017
    ```
 3. Modify the response.json file in the layout and change the `channelUri` value to point to a copy of the channelManifest.json that the admin controls. <b>Note:</b> Be sure to escape backslashes in the value, like this:
    ```json
    "channelUri":"\\\\server\\share\\VS2017\\ChannelManifest.json"
    ```
 4. Now end-users can run setup from this share to install Visual Studio.
    ```
    \\server\share\VS2017\vs_enterprise.exe
    ```
 5. When an enterprise administrator determines it is time for their users to update to a newer version of Visual Studio, they can [update the layout location](update-a-network-installation-of-visual-studio.md) to incorporate the updated files, with a command like this:
    ```
    vs_enterprise.exe --layout \\server\share\VS2017 --lang en-US
    ```
 6. Ensure that the response.json file in the updated layout still contains your customizations, specifically the channelUri modification:
    ```json
    "channelUri":"\\\\server\\share\\VS2017\\ChannelManifest.json"
    ```
 7. Existing Visual Studio installs from this layout will be looking for updates at `\\server\share\VS2017\ChannelManifest.json`. If this channelManifest.json is newer than what the user has installed, Visual Studio will notify the user that an update is available.
 8. New installs will automatically install the updated version of Visual Studio directly from the layout.



## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
