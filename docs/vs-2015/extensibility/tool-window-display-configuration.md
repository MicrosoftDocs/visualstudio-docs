---
title: "Tool Window Display Configuration | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "tool windows, configuring"
  - "tool windows, appearance"
ms.assetid: 502a4926-bb83-473e-94e2-8e833c5f8b53
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# Tool Window Display Configuration
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When a VSPackage registers a tool window, the default position, size, docking style, and other visibility information is specified in optional values. For more information on tool window registration, see [Tool Windows in the Registry](../extensibility/tool-windows-in-the-registry.md)  
  
## Window Display information  
 A tool window's basic display configuration is stored in up to six optional values:  
  
```  
HKEY_LOCAL_MACHINE\  
  Software\  
    Microsoft\  
      VisualStudio\  
        <Version>\  
          ToolWindows\  
            <Tool Window GUID>\  
              (Default)       = reg_sz: <Package GUID>Name            = reg_sz: <name of tool window>Float           = reg_sz: <position>Style           = reg_sz: <dock style>Window          = reg_sz: <window GUID>Orientation     = reg_sz: <orientation>DontForceCreate = reg_dword: 0x00000000  
```  
  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|Name|REG_SZ|"Short name goes here"|A short name that describes the tool window. Used only for reference in the registry.|  
|Float|REG_SZ|"X1,Y1,X2,Y2"|Four comma separated values. X1, Y1 is the coordinate of the upper-left corner of the tool window. X2, Y2 is the coordinate of the lower-right corner. All values are in screen coordinates.|  
|Style|REG_SZ|"MDI"<br /><br /> "Float"<br /><br /> "Linked"<br /><br /> "Tabbed"<br /><br /> "AlwaysFloat"|A keyword specifying the initial display state of the tool window.<br /><br /> "MDI" = docked with MDI window.<br /><br /> "Float" = floating.<br /><br /> "Linked" = linked with another window (specified in the Window entry).<br /><br /> "Tabbed" = combined with another tool window.<br /><br /> "AlwaysFloat" = cannot be docked.<br /><br /> For more information, see the Comments section below.|  
|Window|REG_SZ|*\<GUID>*|The GUID of a window to which the tool window can be linked or tabbed. The GUID may belong to one of your own windows or one of the windows in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] IDE.|  
|Orientation|REG_SZ|"Left"<br /><br /> "Right"<br /><br /> "Top"<br /><br /> "Bottom"|See the Comments section below.|  
|DontForceCreate|REG_DWORD|0 or 1|When this entry is present and its value is not zero, the window is loaded, but not immediately displayed.|  
  
### Comments  
 The Orientation entry defines the position where the tool window docks when its title bar is double-clicked. The position is relative to the window specified in the Window entry. If the Style entry is set to "Linked", the Orientation entry can be "Left", "Right", "Top", or "Bottom". If the Style entry is "Tabbed", the Orientation entry can be "Left" or "Right" and specifies where the tab is added. If the Style entry is "Float", the tool window floats first. When the title bar is double-clicked, the Orientation and Window entries apply, and the window uses the "Tabbed" style. If the Style entry is "AlwaysFloat", the tool window cannot be docked. If the Style entry is "MDI", the tool window is linked to the MDI area, and the Window entry is ignored.  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\  
  Software\  
    Microsoft\  
      VisualStudio\  
        8.0Exp\  
          ToolWindows\  
            {A0C5197D-0AC7-4B63-97CD-8872A789D233}\  
              (Default)       = reg_sz: {DA9FB551-C724-11D0-AE1F-00A0C90FFFC3}  
              DontForceCreate = reg_dword: 0x00000000  
              Float           = reg_sz: 100,100,450,300  
              Name            = reg_sz: Bookmarks  
              Orientation     = reg_sz: Left  
              Style           = reg_sz: Tabbed  
              Window          = reg_sz: {34E76E81-EE4A-11D0-00A0C90FFFC3}  
```  
  
## Tool Window Visibility  
 Values in the optional Visibility subkey determine a tool window's visibility settings. The names of the values are used to store the GUIDs of commands that require the window's visibility. If the command is executed, the IDE guarantees that the tool window is created and made visible.  
  
```  
HKEY_LOCAL_MACHINE\  
  Software\  
    Microsoft\  
      VisualStudio\  
        <Version>\  
          ToolWindows\  
            <Tool Window GUID>\  
              Visibility\  
                (Default) = reg_sz:  
                <GUID>    = reg_dword:  
                <GUID>    = reg_dword:  
                <GUID>    = reg_sz:  
```  
  
|Name|Type|Data|Description|  
|----------|----------|----------|-----------------|  
|(Default)|REG_SZ|None|Leave empty.|  
|*\<GUID>*|REG_DWORD or REG_SZ|0 or a descriptive string.|Optional. The entry's name must be the GUID of a command requiring visibility. The value just holds an informative string. Typically, the value is a `reg_dword` set to 0.|  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\  
  Software\  
    Microsoft\  
      VisualStudio\  
        8.0Exp\  
          ToolWindows\  
            {EEFA5220-E298-11D0-8F78-00A0C9110057}\  
              Visibility\  
                (Default) = reg_sz:  
                {93694fa0-0397-11d1-9f4e-00a0c911004f} = reg_dword: 0x00000000  
                {9DA22B82-6211-11d2-9561-00600818403B} = reg_dword: 0x00000000  
                {adfc4e66-0397-11d1-9f4e-00a0c911004f} = reg_dword: 0x00000000  
```  
  
## See Also  
 [VSPackage Essentials](../misc/vspackage-essentials.md)
