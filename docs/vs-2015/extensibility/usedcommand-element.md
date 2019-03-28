---
title: "UsedCommand Element | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "UsedCommands element (VSCT XML schema)"
  - "VSCT XML schema elements, UsedCommands"
ms.assetid: 99cd05d3-644a-42ff-b289-8458cd1b20c0
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# UsedCommand Element
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Enables a VSPackage to access a command that is defined in another .vsct file. For example, if your VSPackage uses the standard **Copy** command, which is defined by the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] shell, you can add the command to a menu or toolbar without re-implementing it.  
  
## Syntax  
  
```  
<UsedCommand guid="guidMyCommandGroup" id="MyCommand" />  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|guid|Required. The GUID of the GUID ID pair that identifies the command.|  
|id|Required. The ID of the GUID ID pair that identifies the command.|  
|Condition|Optional. See [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md).|  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|None||  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[UsedCommands Element](../extensibility/usedcommands-element.md)|Groups UsedCommand elements and other UsedCommands groupings.|  
  
## Remarks  
 By adding a command to the `<UsedCommands>` element, a VSPackage informs the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] environment that the VSPackage requires the command. You should add a `<UsedCommand>` element for any command your package requires that might not be included in all versions and configurations of Visual Studio. For example, if your package calls a command that is specific to Visual C++, the command will not be available to users of Visual Web Developer unless you include a `<UsedCommand>` element for the command.  
  
## Example  
  
```  
<UsedCommands>  
  <UsedCommand guid="guidVSStd97" id="cmdidCut"/>  
  <UsedCommand guid="guidVSStd97" id="cmdidCopy"/>  
  <UsedCommand guid="guidVSStd97" id="cmdidPaste"/>  
</UsedCommands>  
```  
  
## See Also  
 [UsedCommands Element](../extensibility/usedcommands-element.md)   
 [Visual Studio Command Table (.Vsct) Files](../extensibility/internals/visual-studio-command-table-dot-vsct-files.md)
