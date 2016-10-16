---
title: "How to: Manage Local Data Files in Your Project"
ms.custom: na
ms.date: "09/21/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.data.LocalConnectionConverter"
dev_langs: 
  - "VB"
  - "CSharp"
  - "C++"
  - "aspx"
helpviewer_keywords: 
  - "mdf files"
  - "local data"
  - ".mdb files"
  - ".mdf files"
  - "data [Visual Studio], local"
  - "mdb files"
ms.assetid: 3ffa1aa9-17e4-422c-a02f-09224828cdfc
caps.latest.revision: 29
ms.author: "mblome"
manager: "ghogen"
robots: noindex,nofollow
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
# How to: Manage Local Data Files in Your Project
A local database file can be included as a file in a project. The first time you connect to a local database file, you can choose to create a copy in your project or connect to the existing file in its current location. If you connect to the existing file, it is left in its original location. If you choose to copy the file into your project, Visual Studio creates a copy of it, adds it to your project, and modifies the connection to point to the copy. Other connections, such as those in Server Explorer are also modified.  
  
 The default setting of the property depends on the type of database file you are using. The behavior of the **Copy to Output Directory** property does not apply to Web or C++ projects.  
  
 During development, you might want to view the effects of your code on the database without making those changes permanent. You can do that by setting of the **Copy to Output Directory** property of the file to true. Each time the project builds or you press F5, the file is copied to the bin folder and changes are made to that file, not to the file in the root folder of your project. The database file in your root project folder is changed only when you edit the database schema or data by using **Server Explorer**, **Database Explorer** or other tool window.  
  
 The following table describes the settings of the **Copy to Output Directory** property.  
  
|Setting|Behavior|  
|-------------|--------------|  
|**Copy if newer** (default for .sdf files)|The database file is copied from the project directory to the **bin** directory the first time the project is built. Every subsequent time you build the project, the **Date Modified** property of the files is compared. If the file in the project folder is newer, it is copied to the **bin** folder, replacing the file that is currently there. If the file in the **bin** folder is newer, no files are copied. This setting persists any changes made to the data during run time, meaning that every time you run your application and save changes to the data, those changes are visible the next time you run your application. **Caution:**  We don’t recommend this option for .mdb or .mdf files. The database file can change even when no changes are made to the data. Simply opening a connection on a data file (for example, by expanding the **Tables** node in **Server Explorer**) can mark it as newer.|  
|**Copy always** (default for .mdf and .mdb files)|The database file is copied from the project directory to the /bin directory every time you build your application. Therefore, if you build your application and save changes to the file in the /bin directory, those changes are overwritten the next time that the original file is copied to the /bin directory.|  
|**Do not copy**|The file is never copied or overwritten by the project system. You must manually copy the file from the project directory to the output directory if you use this setting.|  
  
## Procedure  
  
#### To respond to the Local database file dialog box  
  
-   Click **Yes** if you want Visual Studio to copy the database file into your project and modify the connection to point to the copy in your project. For more information on working with database files in your project, see [Local Data Overview](../datatools/local-data-overview.md).  
  
-   Click **No** if you do not want Visual Studio to copy the database file into your project. Instead, the connection points to the file in the original location and the database file is not added as a file to the project.  
  
## See Also  
 [Walkthrough: Connecting to Data in a Local Database File (Windows Forms)](../datatools/walkthrough--connecting-to-data-in-a-local-database-file--windows-forms-.md)   
 [Connect to data in an Access database (Windows Forms)](../datatools/connect-to-data-in-an-access-database--windows-forms-.md)