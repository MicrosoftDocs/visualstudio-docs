---
title: "How to: Use the Activity Log | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "VSPackages, debugging"
  - "VSPackages, troubleshooting"
ms.assetid: bb3d3322-0e5e-4dd5-b93a-24d5fbcd2ffd
caps.latest.revision: 30
ms.author: gregvanl
manager: jillfra
---
# How to: Use the Activity Log
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

VSPackages can write messages to the activity log. This feature is especially useful for debugging VSPackages in retail environments.  
  
> [!TIP]
> The activity log is always turned on. Visual Studio keeps a rolling buffer of the last one hundred entries as well as the first ten entries, which have general configuration information.  
  
### To write an entry to the activity log  
  
1. Insert this code in the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method or in any other method except the VSPackage constructor:  
  
    ```csharp  
    IVsActivityLog log = GetService(typeof(SVsActivityLog)) as IVsActivityLog;  
    if (log == null) return;  
  
    int hr = log.LogEntry((UInt32)__ACTIVITYLOG_ENTRYTYPE.ALE_INFORMATION,  
        this.ToString(),  
        string.Format(CultureInfo.CurrentCulture,  
        "Called for: {0}", this.ToString()));  
    ```  
  
     This code gets the <xref:Microsoft.VisualStudio.Shell.Interop.SVsActivityLog> service and casts it to an <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog> interface. <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog.LogEntry%2A> writes an informational entry into the activity log using the current cultural context.  
  
2. When the VSPackage is loaded (usually when a command is invoked or a window is opened), the text is written to the activity log.  
  
### To examine the activity log  
  
1. Find the activity log in the subfolder for  Visual Studio data: *%AppData%*\Microsoft\VisualStudio\14.0\ActivityLog.XML..  
  
2. Open the activity log with any text editor. Here is a typical entry:  
  
    ```  
    Called for: Company.MyApp.MyAppPackage ...  
    ```  
  
## Robust Programming  
 Because the activity log is a service, the activity log is unavailable in the VSPackage constructor.  
  
 You should obtain the activity log just before writing to it. Do not cache or save the activity log for future use.  
  
## See also  
 <xref:Microsoft.VisualStudio.Shell.Interop.IVsActivityLog>   
 <xref:Microsoft.VisualStudio.Shell.Interop.__ACTIVITYLOG_ENTRYTYPE>   
 [Troubleshooting VSPackages](../extensibility/troubleshooting-vspackages.md)   
 [VSPackages](../extensibility/internals/vspackages.md)
