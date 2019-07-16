---
title: "VSCT XML Schema Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
helpviewer_keywords: 
  - "Visual Studio command table configuration files (VSCT), XML schema"
  - "VSCT XML schema elements"
ms.assetid: 49e7efae-e713-4762-a824-96fdaf92cdc9
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# VSCT XML Schema Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Provides a table of Command Table Compiler schema elements, with allowed child elements and attributes for each.  
  
 An XML-based command table configuration (.vsct) file defines the command elements that a VSPackage provides to the integrated development environment (IDE). These elements include menu items, menus, toolbars, and combo boxes.  
  
> [!NOTE]
> The VSCT compiler can run a preprocessor on the .vsct file. Because this is typically the C++ preprocessor, you can define includes and macros that have the same syntax that is used in C++ files. Examples of this are provided in the .vsct file that the **New Project** wizard creates for a VSPackage project.  
  
## Optional Elements  
 Some VSCT elements are optional. If a `Parent` argument is not specified, Group_Undefined:0 will be implied. If an `Icon` argument is not specified, guidOfficeIcon:msotcidNoIcon will be implied. When a shortcut key is defined, the emulation, which is typically unused, is optional.  
  
 Bitmap items may be embedded at compile time by specifying the location of the bitmap strip in the `href` argument. The bitmap strip is copied during the merge rather than extracted from the resources of the DLL. When an `href` argument is provided, the `usedList` argument becomes optional, and all slots in the bitmap strip are considered used.  
  
 All GUID and ID values must be defined by using symbolic names. These names may be defined in header files or in VSCT \<Symbols> sections. The symbolic names must be local, included through \<Include> elements, or referenced by \<Extern> elements. A symbolic name is imported from a header file specified in an \<Extern> element if it follows the simple pattern of #define SYMBOL   VALUE. The value may be another symbol as long as that symbol was previously defined. GUID definitions must follow either the OLE or C++ format. ID values may be either decimal digits or hexadecimal digits that are preceded by 0x, as shown in the following lines:  
  
- {6D484634-E53D-4a2c-ADCB-55145C9362C8}  
  
- { 0x6d484634, 0xe53d, 0x4a2c, { 0xad, 0xcb, 0x55, 0x14, 0x5c, 0x93, 0x62, 0xc8 } }  
  
  XML comments may be used, but round-trip graphical user interface (GUI) tools might discard them. The contents of \<Annotation> elements are guaranteed to be maintained regardless of format.  
  
## Schema Hierarchy  
 A .vsct file has the following major elements.  
  
 [CommandTable Element](../extensibility/commandtable-element.md)  
  
 [Extern Element](../extensibility/extern-element.md)  
  
 [Include Element](../extensibility/include-element.md)  
  
 [Define Element](../extensibility/define-element.md)  
  
 [Commands Element](../extensibility/commands-element.md)  
  
 [CommandPlacements Element](../extensibility/commandplacements-element.md)  
  
 [VisibilityConstraints Element](../extensibility/visibilityconstraints-element.md)  
  
 [KeyBindings Element](../extensibility/keybindings-element.md)  
  
 [UsedCommands Element](../extensibility/usedcommands-element.md)  
  
 [Parent Element](../extensibility/parent-element.md)  
  
 [Icon Element](../extensibility/icon-element.md)  
  
 [Strings Element](../extensibility/strings-element.md)  
  
 [Command Flag Element](../extensibility/command-flag-element.md)  
  
 [Symbols Element](../extensibility/symbols-element.md)  
  
 [Conditional Attributes](../extensibility/vsct-xml-schema-conditional-attributes.md)  
  
## See Also  
 [How VSPackages Add User Interface Elements](../extensibility/internals/how-vspackages-add-user-interface-elements.md)   
 [Command Routing in VSPackages](../extensibility/internals/command-routing-in-vspackages.md)
