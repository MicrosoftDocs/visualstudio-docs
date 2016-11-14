---
title: "Simplified Embedding | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "editors [Visual Studio SDK], custom - simple view embedding"
ms.assetid: f1292478-a57d-48ec-8c9e-88a23f04ffe5
caps.latest.revision: 16
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Simplified Embedding
Simplified embedding is enabled in an editor when its document view object is parented to (that is, made a child of) [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], and the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane> interface is implemented to handle its window commands. Simplified embedding editors cannot host active controls. The objects used to create an editor with simplified embedding are shown in the following illustration.  
  
 ![Simplified Embedding Editor graphic](../extensibility/media/vssimplifiedembeddingeditor.gif "vsSimplifiedEmbeddingEditor")  
Editor with simplified embedding  
  
> [!NOTE]
>  Of the objects in this illustration, only the `CYourEditorFactory` object is required to create a standard file-based editor. If you are creating a custom editor, you are not required to implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2>, because your editor will likely have its own private persistence mechanism. For non-custom editors, however, you must do so.  
  
 All interfaces implemented to create an editor with simplified embedding are contained in the `CYourEditorDocument` object. However, to support multiple views of document data, split the interfaces onto separate data and view objects as indicated in the following table.  
  
|Interface|Location of interface|Use|  
|---------------|---------------------------|---------|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowPane>|View|Provides connection to the parent window.|  
|<xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>|View|Handles commands.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser>|View|Enables status bar updates.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsToolboxUser>|View|Enables **Toolbox** items.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsFileChangeEvents>|Data|Sends notifications when the file changes.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat>|Data|Enables the Save As feature for a file type.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistDocData2>|Data|Enables persistence for the document.|  
|<xref:Microsoft.VisualStudio.Shell.Interop.IVsDocDataFileChangeControl>|Data|Allows suppression of file change events, such as reload triggering.|