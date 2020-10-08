---
title: "Displaying Files By Using the Open File Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "project types, supporting Open File command"
  - "Open File command"
  - "persistence, supporting Open File command"
ms.assetid: 4fff0576-b2f3-4f17-9769-930f926f273c
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# Displaying Files By Using the Open File Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following steps describe how the IDE handles the **Open File** command, which is available on the **File** menu in [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)]. The steps also describe how projects should respond to calls that originate from this command.  
  
 When a user clicks the **Open File** command on the **File** menu, and selects a file from the **Open File** dialog box, the following process occurs.  
  
1. Using the running document table, the IDE determines whether the file is already open in a project.  
  
    - If the file is open, the IDE resurfaces the window.  
  
    - If the file is not open, the IDE calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.IsDocumentInProject%2A> to query each project to determine which project can open the file.  
  
        > [!NOTE]
        > In your project implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.IsDocumentInProject%2A>, provide a priority value that indicates the level at which your project opens the file. Priority values are provided in the <xref:Microsoft.VisualStudio.Shell.Interop.VSDOCUMENTPRIORITY> enumeration.  
  
2. Each project responds with a priority level that indicates the importance it places on being the project to open the file.  
  
3. The IDE uses the following criteria to determine which project opens the file:  
  
    - The project that responds with the highest priority (DP_Intrinsic) opens the file. If more than one project responds with this priority, the first project to respond opens the file.  
  
    - If no project responds with the highest priority (DP_Intrinsic), but all projects respond with the same, lower priority, the active project opens the file. If no project is active, the first project to respond opens the file.  
  
    - If no project claims ownership of the file (DP_Unsupported), the Miscellaneous Files project opens the file.  
  
         If an instance of the Miscellaneous Files project is created, the project always responds with the value DP_CanAddAsExternal. This value indicates that the project can open the file. This project is used to house open files that are not in any other project. The list of items in this project is not persisted; this project is visible in **Solution Explorer** only when it is used to open a file.  
  
         If the Miscellaneous Files project does not indicate that it can open the file, an instance of the project has not been created. In this case, the IDE creates an instance of the Miscellaneous Files project and tells the project to open the file.  
  
4. As soon as the IDE determines which project opens the file, it calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject3.OpenItem%2A> method on that project.  
  
5. The project then has the option of opening the file by using a project-specific editor or a standard editor. For more information, see [How to: Open Project-Specific Editors](../../extensibility/how-to-open-project-specific-editors.md) and [How to: Open Standard Editors](../../extensibility/how-to-open-standard-editors.md), respectively.  
  
## See Also  
 [Displaying Files By Using the Open With Command](../../extensibility/internals/displaying-files-by-using-the-open-with-command.md)   
 [Opening and Saving Project Items](../../extensibility/internals/opening-and-saving-project-items.md)   
 [How to: Open Project-Specific Editors](../../extensibility/how-to-open-project-specific-editors.md)   
 [How to: Open Standard Editors](../../extensibility/how-to-open-standard-editors.md)
