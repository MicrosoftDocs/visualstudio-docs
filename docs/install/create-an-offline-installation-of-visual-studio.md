---
title: "Create an Offline Installation of Visual Studio 2017 RC | Microsoft Docs"
description: "Learn how to create an offline installation of Visual Studio without using the Internet."
ms.custom: ""
ms.date: "2016-11-16"
ms.prod: "visual-studio-dev15"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-install"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "offline installation"
  - "offline install"
  - "ISO"
ms.assetid: 7bd7e724-7bfd-43f1-9935-981919be5a00
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
  translation.priority.ht: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# Create an offline install of Visual Studio 2017 RC 
## Create a layout 
You can create an offline installation layout that contains all the files you need to install the product without requiring Internet access.  

#### To create an offline install of Visual Studio
1. Download the Visual Studio setup executable file to a drive on your local machine. 
  For example, [download the vs_enterprise.exe file](https://aka.ms/vs/15/release/vs_enterprise.exe).
2. Run `vs_enterprise.exe` with the following arguments (switches) from a command prompt:

   a. `--layout <path>`, where `<path>` is the location where you want the layout to download to. By default, all languages are downloaded. (See <a href="exA">Example A</a>.) 
  
   b. Restrict the download to a single language by providing the `--lang <language>` argument, where `<language>` is one of the ISO country codes.  (See <a href="exB">Example B</a> and <a href="exC">Example C</a>.)

### Examples: 
<a name="exA"></a> A. Install all languages 
  > * `vs_enterprise.exe --layout C:\layout` 

<a name="exB"></a> B. Install one language (English only) 
  > * `vs_enterprise.exe --layout C:\layout --lang en-US` 

<a name="exC"></a> C. Install multiple languages 
  > * `vs_enterprise.exe --layout C:\layout --lang en-us de-DE ja-JP` 

### ISO country codes of the languages that you can use: 
| ISO Code | Language | 
| -----   | ----- | 
| cs-CZ	| Czech | 
| de-DE	| German | 
| en-US	| English | 
| es-ES	| Spanish | 
| fr-FR	| French | 
| it-IT	| Italian | 
| ja-JP	| Japanese | 
| ko-KR	| Korean | 
| pl-PL	| Polish | 
| pt-BR	| Portuguese - Brazil | 
| ru-RU	| Russian | 
| tr-TR	| Turkish | 
| zh-CN	| Chinese - Simplified | 
| zh-TW	| Chinese - Traditional | 


## Install from a layout 
#### To install Visual Studio from an offline installation layout 
1. On the target machine, navigate to the **Certificates** folder, which is in the Layout folder. 
2. Right-click and install each certificate in the **Certificates** folder. 
3. Run `vs_enterprise.exe` from the **Layout** folder. 
> [!NOTE]  
> The offline installation layout currently creates some files with restricted permissions (ACLs) that prevent access by all users.  Make sure that you adjust the permissions (ACLs) so that they grant Read access to other users  *before*  you share the offline install.

