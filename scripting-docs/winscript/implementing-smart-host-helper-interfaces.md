---
title: "Implementing Smart Host Helper Interfaces | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "Smart Host Helper Interfaces, implementing"
ms.assetid: b9c44246-4d4d-469e-91be-00c8f5796fa5
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Implementing Smart Host Helper Interfaces
The [IDebugDocumentHelper Interface](../winscript/reference/idebugdocumenthelper-interface.md) interface greatly simplifies the task of creating a smart host for Active Debugging, because it provides implementations for many interfaces necessary for smart hosting.  
  
 To be a smart host using `IDebugDocumentHelper`, a host application must do only three things:  
  
1. `CoCreate` the Process Debug Manager, and use the [IProcessDebugManager Interface](../winscript/reference/iprocessdebugmanager-interface.md) interface to add your application to the list of debuggable applications.  
  
2. Create a debug document helper for each script object, using the [IProcessDebugManager::CreateDebugDocumentHelper](../winscript/reference/iprocessdebugmanager-createdebugdocumenthelper.md) method. Make sure that the document name, parent document, text, and script blocks are defined.  
  
3. Implement the [IActiveScriptSiteDebug Interface](../winscript/reference/iactivescriptsitedebug-interface.md) interface on your object that implements the [IActiveScriptSite](../winscript/reference/iactivescriptsite.md) interface (which is needed for Active Scripting). The only non-trivial method on the `IActiveScriptSiteDebug` interface simply delegates to the helper.  
  
   Optionally, the host can implement the [IDebugDocumentHost Interface](../winscript/reference/idebugdocumenthost-interface.md) interface if it needs additional control over syntax color, document context creation, and other extended functionality.  
  
   The main limitation on the smart host helper is that it can only handle documents whose contents change or shrink after they have been added (although documents can expand). For many smart hosts, however, the functionality it provides is exactly what is needed.  
  
   The following sections explain each step in more detail.  
  
## Create an Application Object  
 Before the smart host helper can be used, it is necessary to create an [IDebugApplication Interface](../winscript/reference/idebugapplication-interface.md) object to represent your application in the debugger.  
  
#### To create an application object  
  
1. Create an instance of the process debug manager using `CoCreateInstance`.  
  
2. Call [IProcessDebugManager::CreateApplication](../winscript/reference/iprocessdebugmanager-createapplication.md).  
  
3. Set the name on the application by using [IDebugApplication::SetName](../winscript/reference/idebugapplication-setname.md).  
  
4. Add the application object to the list of debuggable applications by using [IProcessDebugManager::AddApplication](../winscript/reference/iprocessdebugmanager-addapplication.md).  
  
     The code below outlines the process, but it does not include error checking or other robust programming techniques.  
  
    ```cpp
    CoCreateInstance(CLSID_ProcessDebugManager, NULL,  
          CLSCTX_INPROC_SERVER | CLSCTX_INPROC_HANDLER  
          | CLSCTX_LOCAL_SERVER,  
    IID_IProcessDebugManager, (void **)&g_ppdm);  
    g_ppdm->CreateApplication(&g_pda);  
    g_pda->SetName(L"My cool application");  
    g_ppdm->AddApplication(g_pda, &g_dwAppCookie);  
    ```  
  
## Using IDebugDocumentHelper  
  
#### To use the helper (minimal sequence of steps)  
  
1. For each host document, create a helper using [IProcessDebugManager::CreateDebugDocumentHelper](../winscript/reference/iprocessdebugmanager-createdebugdocumenthelper.md).  
  
2. Call [IDebugDocumentHelper::Init](../winscript/reference/idebugdocumenthelper-init.md) on the helper, giving the name, document attributes, and so on.  
  
3. Call [IDebugDocumentHelper::Attach](../winscript/reference/idebugdocumenthelper-attach.md) with parent helper for the document (or NULL if the document is the root) to define the position of the document in the tree and make it visible to the debugger.  
  
4. Call [IDebugDocumentHelper::AddDBCSText](../winscript/reference/idebugdocumenthelper-adddbcstext.md) or [IDebugDocumentHelper::AddUnicodeText](../winscript/reference/idebugdocumenthelper-addunicodetext.md) to define the text of the document. (These can be called multiple times if document is downloaded incrementally, as in the case of a browser.)  
  
5. Call [IDebugDocumentHelper::DefineScriptBlock](../winscript/reference/idebugdocumenthelper-definescriptblock.md) to define the ranges for each script block and the associated script engines.  
  
## Implementing IActiveScriptSiteDebug  
 To implement [IActiveScriptSiteDebug::GetDocumentContextFromPosition](../winscript/reference/iactivescriptsitedebug-getdocumentcontextfromposition.md), get the helper corresponding to the given site, and then get the starting document offset for the given source context, as follows:  
  
```cpp
pddh->GetScriptBlockInfo(dwSourceContext, NULL, &ulStartPos, NULL);  
```  
  
 Next, use the helper to create a new document context for the given character offset:  
  
```cpp
pddh->CreateDebugDocumentContext(ulStartPos + uCharacterOffset, cChars, &pddcNew);  
```  
  
 To implement [IActiveScriptSiteDebug::GetRootApplicationNode](../winscript/reference/iactivescriptsitedebug-getrootapplicationnode.md), simply call `IDebugApplication::GetRootNode` (inherited from [IRemoteDebugApplication::GetRootNode](../winscript/reference/iremotedebugapplication-getrootnode.md)).  
  
 To implement [IDebugDocumentHelper::GetDebugApplicationNode](../winscript/reference/idebugdocumenthelper-getdebugapplicationnode.md), simply return the `IDebugApplication` you initially created using the process debug manager.  
  
## The optional IDebugDocumentHost interface  
 The host can provide an implementation of the [IDebugDocumentHost Interface](../winscript/reference/idebugdocumenthost-interface.md) by using [IDebugDocumentHelper::SetDebugDocumentHost](../winscript/reference/idebugdocumenthelper-setdebugdocumenthost.md) to give it additional control over the helper. Here are some of the key things the host interface allows you to do:  
  
- Add text using [IDebugDocumentHelper::AddDeferredText](../winscript/reference/idebugdocumenthelper-adddeferredtext.md) so that the host does not need to provide the actual characters immediately. When the characters are really needed, the helper will call [IDebugDocumentHost::GetDeferredText](../winscript/reference/idebugdocumenthost-getdeferredtext.md) on the host.  
  
- Override the default syntax coloring provided by the helper. The helper calls [IDebugDocumentHost::GetScriptTextAttributes](../winscript/reference/idebugdocumenthost-getscripttextattributes.md) to determine the coloring for a range of characters, falling back on its default implementation if the host return `E_NOTIMPL`.  
  
- Provide a controlling unknown for document contexts created by the helper by implementing [IDebugDocumentHost::OnCreateDocumentContext](../winscript/reference/idebugdocumenthost-oncreatedocumentcontext.md). This allows the host to override the functionality of the default document context implementation.  
  
- Provide a path name in the file system for the document. Some debugging UIs use this to permit the user to edit and save changes to the document. [IDebugDocumentHost::NotifyChanged](../winscript/reference/idebugdocumenthost-notifychanged.md) is called to notify the host after the document has been saved.  
  
## See also  
 [Active Script Debugging Overview](../winscript/active-script-debugging-overview.md)