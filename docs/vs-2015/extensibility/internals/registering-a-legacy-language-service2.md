---
title: "Registering a Legacy Language Service2 | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "registration, language services"
  - "language services, registry information"
  - "registry, language services"
ms.assetid: ca312aa3-f9f1-4572-8553-89bf3a724deb
caps.latest.revision: 25
ms.author: gregvanl
manager: jillfra
---
# Registering a Legacy Language Service
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The following sections provide lists of registry entries for the various language service options available in [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)].  
  
 In the following list of registry entries, *VS Reg Root* is equal to HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\*X.Y*, where *X.Y* is the [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] version number.  
  
## Registry Entries for Language Service Options  
 The *VS Reg Root*\Languages\Language Services\\*Language Name* key can contain the following values.  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|(Default)|REG_SZ|*\<GUID>*|GUID of the language service.|  
|LangResID|REG_DWORD|0x0-0xffff|String resource identifier (ResID) for the localized text name of the language.|  
|Package|REG_SZ|*\<GUID>*|GUID of the VSPackage.|  
|ShowCompletion|REG_DWORD|0-1|Specifies whether the **Statement completion** options in the **Options** dialog box are enabled.|  
|ShowSmartIndent|REG_DWORD|0-1|Specifies whether the option to select **Smart** indenting in the **Options** dialog box is enabled.|  
|RequestStockColors|REG_DWORD|0-1|Specifies whether custom or default colors are used to color keywords.|  
|ShowHotURLs|REG_DWORD|0-1|Specifies whether the user can click URLs.|  
|Default to Non Hot URLs|REG_DWORD|0-1|Specifies the initial setting for the **Enable single-click URL navigation** option in the **Options** dialog box.|  
|DefaultToInsertSpaces|REG_DWORD|0-1|Specifies whether the language service has "insert spaces" as its default tab option.|  
|ShowDropdownBarOption|REG_DWORD|0-1|Enables or disables the **Navigation bar** option in the **Options** dialog box that shows or hides the **Navigation bar**.|  
|Single Code Window Only|REG_DWORD|0-1|Enables or disables the **New Window** choice in the **Window** menu for a language service.|  
|EnableAdvancedMembersOption|REG_DWORD|0-1|Enables or disables an **Options** dialog box setting for **Hide Advanced Members**.|  
|Support CF_HTML|REG_DWORD|0-1|Specifies whether the editor enables copying and pasting of HTML data.|  
|EnableLineNumbersOption|REG_DWORD|0-1|Specifies whether the **Line numbers** options in the **Options** dialog box is enabled for a language service.|  
|HideAdvancedMembersByDefault|REG_DWORD|0-1|Specifies whether advanced members such as private fields are hidden in completion lists.|  
|ShowBraceCompletion|REG_DWORD|0-1|Specifies whether the **Brace completion** option in the **Options** dialog box is enabled.|  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\  
  Languages\  
    Language Services\  
      C/C++\  
        (Default)             = reg_sz:{B2F072B0-ABC1-11D0-9D62-00C04FD9DFD9}  
        LangResID             = reg_dword:0x00000000  
        Package               = reg_sz:{8C2EA640-ABC1-11D0-9D62-00C04FD9DFD9}  
        ShowCompletion        = reg_dword:0x00000001  
        ShowSmartIndent       = reg_dword:0x00000001  
        ShowDropdownBarOption = reg_dword:0x00000001  
```  
  
## Registry Entries for Debugger Languages Options  
 The *VS Reg Root*\Languages\Language Services\\*Language Name*\Debugger Languages\\*GUID*\ key can include the following values.  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|(Default)|REG_SZ|text|The default value can be used to document the name of the language. The name of this key is a GUID of an expression evaluator that has a corresponding entry in *\<VS Reg Root>*\AD7Metrics\Expression Evaluator.|  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\  
  Languages\  
    Language Services\  
      C/C++\  
        Debugger Languages\  
          {3A12D0B7-C26C-11D0-B442-00A0244A1DD2}\  
            (Default) = reg_sz:C++  
```  
  
## Registry Entries for Editor Tools Options  
 You can add registry keys under the EditorToolsOptions key for property pages and property nodes. These keys and their values identify property pages in the **Options** dialog box (on the **Tools** menu) that are used to configure the language service. In the following example, *Page Name* is the name of a property page, and *Node Name* is the name of a node in the tree on the **Options** dialog box. The page entry and the node entry must be specified separately.  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|(Default)|REG_SZ|ResID|The localized display name of this option page. The name can be literal text, or #`nnn`, where `nnn` is a string resource ID in the satellite DLL of the specified VSPackage.|  
|Package|REG_SZ|*GUID*|The GUID of the VSPackage that implements this options page.|  
|Page|REG_SZ|*GUID*|The GUID of the property page to request from the VSPackage by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage.GetPropertyPage%2A> method. If this registry entry is not present, the registry key describes a node, not a page.|  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\  
  Languages\  
    Language Services\  
      CSharp\  
        EditorToolsOptions\  
          Formatting\  
            (Default) = reg_sz:#242  
            Package   = reg_sz:{A066E284-DCAB-11D2-B551-00C04F68D4DB}  
            General\  
              (Default) = reg_sz:#255  
              Package   = reg_sz:{A066E284-DCAB-11D2-B551-00C04F68D4DB}  
              Page      = reg_sz:{3EB2CC0B-033E-4D75-B26A-B2362C25227E}  
            Indentation\  
              (Default) = reg_sz:#250  
              Package   = reg_sz:{A066E284-DCAB-11D2-B551-00C04F68D4DB}  
              Page      = reg_sz:{5E21D017-6D2A-4114-A1F1-C923F001CBBB}  
            Newlines\  
              (Default) = reg_sz:#253  
              Package   = reg_sz:{A066E284-DCAB-11D2-B551-00C04F68D4DB}  
              Page      = reg_sz:{607D8062-68D1-41E4-9A35-B5E7F14D0481}  
```  
  
## Registry Entries for File Name Extension Options  
 The entry for the file extension should include the leading period, for example ".myext".  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|(Default)|REG_SZ|*GUID*|Service GUID for the default language service for this file name extension type.|  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\  
  Languages\  
    File Extensions\  
      .cpp\  
        (Default) = {B2F072B0-ABC1-11D0-9D62-00C04FD9DFD9}  
```  
  
## Registry Entries for Editor Options  
 The *VS Reg Root*\Editors key can contain the following values:  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|(Default)|REG_SZ|""|Unused; you can put your name here for documentation.|  
|DefaultToolboxTab|REG_SZ|""|Name of the toolbox tab to make default when the editor is active.|  
|DisplayName|REG_SZ|ResID|Name to display in the **Open With** dialog box. The name is the string resource ID or a name in standard format.|  
|ExcludeDefTextEditor|REG_DWORD|0-1|Used for the **Open With** menu command. If you do not want to list the default text editor in the list of available editors for a specific file type, set this value to 1.|  
|LinkedEditorGUID|REG_SZ|*\<GUID>*|Used for any language service that can open a file with codepage support. For example, when you open a .txt file by using the **Open With** command, options are provided for using the source code editor with and without encoding.<br /><br /> The GUID specified in the name of the subkey is for the codepage editor factory; the linked GUID specified in this specific registry entry is for the regular editor factory. The purpose of this entry is that if the IDE does not open a file by using the default editor, the IDE will try to use the next editor in the list. This next editor should not be the codepage editor factory because this editor factory is basically the same as the editor factory that failed.|  
|Package|REG_SZ|*\<GUID>*|VSPackage GUID for the display name's ResID.|  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\  
  \Editors\  
    {8281C572-2171-45AA-A642-7D8BC1662F1C}\  
      (Default)            = reg_sz:Html Editor with Encoding  
      DefaultToolboxTab    = reg_sz:HTML  
      DisplayName          = reg_sz:#20101  
      LinkedEditorGUID     = reg_sz:{C76D83F8-A489-11D0-8195-00A0C91BBEE3}  
      Package              = reg_sz:{1B437D20-F8FE-11D2-A6AE-00104BCC7269}  
```  
  
## Registry Entries for Logical View Options  
 The *VS Reg Root*\Editors\\*Editor GUI>*\LogicalViews key can contain the following values.  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|(Default)|REG_SZ||Unused.|  
|*\<GUID>*|REG_SZ|""|Key to the logical views supported. You can have as many of these as you need. The name of the registry entry is what is important, not the value, which is always an empty string.|  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\  
  \Editors\  
    {8281C572-2171-45AA-A642-7D8BC1662F1C}\  
      LogicalViews\  
       (Default) = reg_sz:  
       {7651a700-06e5-11d1-8ebd-00a0c90f26ea} = reg_sz:  
       {7651a701-06e5-11d1-8ebd-00a0c90f26ea} = reg_sz:  
       {7651a702-06e5-11d1-8ebd-00a0c90f26ea} = reg_sz:  
       {7651a703-06e5-11d1-8ebd-00a0c90f26ea} = reg_sz:  
```  
  
## Registry Entries for Editor Extension Options  
 The *VS Reg Root*\Editors\\*Editor GUID*\Extensions key can contain the following values. The file name extension does not include the leading period.  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|(Default)|REG_SZ||Unused.|  
|*\<ext>*|REG_DWORD|0-0xffffffff|Relative priority of extensions. If two or more languages share the same extension, the higher-priority language is chosen.|  
  
 Additionally, the current user's default selection for an editor is stored in HKEY_Current_User\Software\Microsoft\VisualStudio\\*X.Y*\Default Editors\\*ext*. The GUID of the selected language service is in the Custom entry. This takes precedence for the current user.  
  
### Example  
  
```  
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0\  
  \Editors\  
    {8281C572-2171-45AA-A642-7D8BC1662F1C}\  
      Extensions\  
       (Default) = reg_sz:  
       *         = reg_dword:0x00000018  
       html      = reg_dword:0x00000027  
       shtm      = reg_dword:0x00000027  
       shtml     = reg_dword:0x00000027  
```  
  
## Registry Entries for Managed Package Framework Language Service Options  
 The following registry entries are specific to the managed package framework (MPF) language service classes. These registry entries indicate support in the language service for various IntelliSense features and for other advanced editing features.  
  
 These registry entries are accessed through the <xref:Microsoft.VisualStudio.Package.LanguagePreferences> class.  
  
|Name|Type|Range|Description|  
|----------|----------|-----------|-----------------|  
|CodeSense|REG_DWORD|0-1|Support for IntelliSense operations.|  
|MatchBraces|REG_DWORD|0-1|Support for matching language pairs such as braces, parentheses, and brackets.|  
|QuickInfo|REG_DWORD|0-1|Support for the IntelliSense Quick Info operation.|  
|ShowMatchingBrace|REG_DWORD|0-1|Support for displaying the matching language pair in the status bar.|  
|MatchBracesAtCaret|REG_DWORD|0-1|Support for displaying matching language pairs, typically through highlighting the two elements.|  
|MaxErrorMessages|REG_DWORD|0-n|The maximum number of errors that can be displayed in the **Error List** window.|  
|CodeSenseDelay|REG_DWORD|0-n|The number of milliseconds to delay before initiating any background parsing for an IntelliSense operation.|  
|EnableAsyncCompletion|REG_DWORD|0-1|Support for background parsing.|  
|EnableCommenting|REG_DWORD|0-1|Support for commenting out selected blocks of text, and also implies support for uncommenting selected text.|  
|EnableFormatSelection|REG_DWORD|0-1|Support for formatting text such as auto-indentation or adjusting the position of braces.|  
|AutoOutlining|REG_DWORD|0-1|Support for outlining (regions that can be collapsed).|  
|MaxRegions|REG_DWORD|0-n|The maximum number of hidden regions per file.|  
  
```  
ExampleHKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\8.0Exp\  
  Languages\  
    Language Services\  
      XML\  
        (Default)             = reg_sz:{f6819a78-a205-47b5-be1c-675b3c7f0b8e}  
        MatchBraces           = reg_dword:0x00000001  
        QuickInfo             = reg_dword:0x00000001  
        ShowMatchingBrace     = reg_dword:0x00000001  
        MatchBracesAtCaret    = reg_dword:0x00000000  
        MaxErrorMessages      = reg_dword:0x00000064  
        CodeSenseDelay        = reg_dword:0x000001f4  
        MaxRegions            = reg_dword:0x0000000a  
```  
  
## See Also  
 [Developing a Legacy Language Service](../../extensibility/internals/developing-a-legacy-language-service.md)
