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
# Control updates to Visual Studio deployments

## How an administrator can control VS update notifications for their enterprise users
Admins often create a layout and host it on a file share.  Then, they or their users install VS from this share.  The version of VS in the layout is what will be installed.  However, by default, VS will look online for updates.  If an update is available, the user can install it.  Any updated content being installed that is not found in the offline layout will be downloaded from the web. 

If an admin wants to control when their users get VS product update notifications and to which version they get updated, they can do so by following these steps.

 1. Create an offline layout: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US```
 2. Copy it to the file share where you want to host it: <br>```xcopy /e C:\vs2017offline \\server\share\VS2017```
 3. Modify the response.json file in the layout and change the ```channelUri``` value to point to a copy of the channelManifest.json that the admin controls. <b>Note:</b> Be sure to escape backslashes in the value like this: <br>```"channelUri":"\\\\server\\share\\VS2017\\ChannelManifest.json"```
 4. Admins or users can run VS setup from this share to install VS. <br>```\\server\share\VS2017\vs_enterprise.exe```
 5. When the admin determines it is time for their users to update to a newer version VS, they can update their layout.  First, create a new layout or update an existing layout.  You will likely want to do this in a local folder and not the live file share: <br>```vs_enterprise.exe --layout C:\vs2017offline --lang en-US```
 6. Ensure that the response.json file in the updated layout still contains your customizations, specifically the channelUri modification: <br>```"channelUri":"\\\\server\\share\\VS2017\\ChannelManifest.json"```
 7. If you didn't update the file share directly, copy the new and updated layout content to the share: <br>```xcopy /e C:\vs2017offline \\server\share\VS2017```
 8. Existing VS installs from this layout are looking for updates to \\\\server\share\VS2017\ChannelManifest.json.  If VS sees that this channelManifest.json is newer than what the user has installed, it will notify the user that an update is availble.
 10. New VS installs will install the newer content directly from the layout.


## See also
* [Install Visual Studio](install-visual-studio.md)
* [Visual Studio administrator guide](visual-studio-administrator-guide.md)
* [Use command-line parameters to install Visual Studio](use-command-line-parameters-to-install-visual-studio.md)
