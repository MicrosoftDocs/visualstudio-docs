---
title: "Renaming Project Hierarchy Nodes (C++)"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cea5968e-e9f8-41a5-b068-622df542247c
caps.latest.revision: 12
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Renaming Project Hierarchy Nodes (C++)
You can rename a project folder hierarchy node by using the HierUtil7 project framework for unmanaged C++. For more information, see [HierUtil7 Sample](assetId:///29c15184-a70c-4813-86c2-fb1d47442d11).  
  
## Expanding the Hierarchy node  
  
#### To expand the hierarchy node and rename the folder  
  
1.  Select the hierarchy node by using the following method:  
  
    ```  
    IfFailGo(pNode->ExtExpand(EXPF_SelectItem, GUID_MacroExplorer));  
    ```  
  
     `pNode` is the hierarchy container corresponding to the folder and `EXPF_SelectItem` is from the <xref:Microsoft.VisualStudio.Shell.Interop.EXPANDFLAGS?qualifyHint=False> enumeration. The `GUID_MacroExplorer` is a GUID constant defined in Vsshell.idl and is an example for `rguidPersistenceSlot` in the function signature of `ExtExpand`, defined in Hu_node.h.  
  
    ```  
    HRESULT ExtExpand(EXPANDFLAGS expandflags, REFGUID rguidPersistenceSlot = GUID_SolutionExplorer) const;  
    ```  
  
     You can find the Hu_node.h file in the folder, <installation root\>\Program Files\VSIP 8.0\EnvSDK\common\hierutil7:  
  
2.  Rename the folder by posting the rename command by using <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.PostExecCommand?qualifyHint=False>  
  
    ```  
    IfFailGo(srpVsUIShell->PostExecCommand(&guidVSStd97, cmdidRename, 0, NULL));  
    ```  
  
     `srpVsUIShell` is a <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell?qualifyHint=False> pointer: `<IVsUIShell>``srpVsUIShell`. `guiVSStd97` is a unique identifier of the command group to which the command `cmdidRename` belongs, defined in Vsshlids.h.  
  
## See Also  
 [Creating Project Types](../Topic/Creating%20Project%20Types.md)   
 [VSSDK Samples](../VS_not_in_toc/VSSDK-Samples.md)