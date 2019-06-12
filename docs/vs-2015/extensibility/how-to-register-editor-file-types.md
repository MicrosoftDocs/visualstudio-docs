---
title: "How to: Register Editor File Types | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - register file types"
ms.assetid: 54846779-8290-48de-90ab-81011559d9a5
caps.latest.revision: 15
ms.author: gregvanl
manager: jillfra
---
# How to: Register Editor File Types
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The easiest way to register editor file types is by using the registration attributes provided as a part of the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] managed package framework (MPF) classes. If you are implementing your package in native [!INCLUDE[vcprvc](../includes/vcprvc-md.md)], you can also write a registry script that registers your editor and the associated extensions.  
  
## Registration Using MPF Classes  
  
#### To register editor file types using MPF classes  
  
1. Provide the <xref:Microsoft.VisualStudio.Shell.ProvideEditorExtensionAttribute> class with the appropriate parameters for your editor in the class of your VSPackage.  
  
    ```  
    [Microsoft.VisualStudio.Shell.ProvideEditorExtensionAttribute(typeof(EditorFactory), ".Sample", 32,   
         ProjectGuid = "{A2FE74E1-B743-11d0-AE1A-00A0C90FFFC3}",   
         TemplateDir = "..\\..\\Templates",   
         NameResourceID = 106)]  
    ```  
  
     Where ".Sample" is the extension that is registered for this editor, and "32" is its priority level.  
  
     The `projectGuid` is the GUID for miscellaneous file types, defined in <xref:Microsoft.VisualStudio.VSConstants.CLSID.MiscellaneousFilesProject_guid>. The miscellaneous file type is provided, so that the resulting file is not going to be a part of the build process.  
  
     `TemplateDir` represents the folder that contains the template files that are included with the managed basic editor sample.  
  
     `NameResourceID` is defined in the Resources.h file of the BasicEditorUI project, and identifies the editor as "My Editor".  
  
2. Override the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method.  
  
     In your implementation of the <xref:Microsoft.VisualStudio.Shell.Package.Initialize%2A> method, call the <xref:Microsoft.VisualStudio.Shell.Package.RegisterEditorFactory%2A> method and pass the instance of your editor factory as demonstrated below.  
  
    ```  
    protected override void Initialize()  
    {  
        Trace.WriteLine (string.Format(CultureInfo.CurrentCulture,   
        "Entering Initialize() of: {0}", this.ToString()));  
        base.Initialize();  
           //Create Editor Factory  
        editorFactory = new EditorFactory(this);  
        base.RegisterEditorFactory(editorFactory);  
    }  
    ```  
  
     This step registers both the editor factory and the editor file extensions.  
  
3. Unregister the editor factories.  
  
     Editor factories are automatically unregistered when the VSPackage is disposed. If the editor factory object implements the <xref:System.IDisposable> interface, its `Dispose` method is called after the factory has been unregistered with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].  
  
## Registration Using a Registry Script  
 Registering editor factories and file types in native [!INCLUDE[vcprvc](../includes/vcprvc-md.md)] is done using a registry script to write to the windows registry, as illustrated by the following.  
  
#### To register editor file types using a registry script  
  
1. In your registry script, define the editor factory and the editor factory GUID string as shown in the `GUID_BscEditorFactory` section of the following registry script. Also, define the extension and the priority of the editor extension:  
  
    ```  
  
          NoRemove Editors     {         %GUID_BscEditorFactory% = s 'RTF Editor'         {             val Package = s '%CLSID_Package%'             val DisplayName = s 'An RTF Editor'             val ExcludeDefTextEditor = d 1             val AcceptBinaryFiles = d 0  
  
            LogicalViews  
            {  
                val %LOGVIEWID_TextView% = s ''  
            }  
  
            OpenWithEntries  
            {  
            }  
  
            Extensions            {                val rtf = d 50            }  
        }  
    }  
    ```  
  
     The editor file extension in this example is identified as ".rtf" and its priority is "50". The GUID strings are defined in Resource.h file of the BscEdit sample project.  
  
2. Register the VSPackage.  
  
3. Register the editor factory.  
  
     The editor factory is registered in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRegisterEditors.RegisterEditor%2A> implementation.  
  
    ```  
    // create editor factory.  
    if (m_srpEdFact == NULL)   
    {  
        CComObject<CBscEditorFactory> *pEdFact = new CComObject<CBscEditorFactory>;  
        if (NULL == pEdFact)  
          return E_OUTOFMEMORY;  
  
        if (!pEdFact->FInit(this))  
          return E_UNEXPECTED;  
  
        m_srpEdFact = (IVsEditorFactory *) pEdFact;    // Note: assignment to a smart pointer does an AddRef()  
    }  
    // Query service for IVsRegisterEditors, register the editor factory  
    CComPtr<IVsRegisterEditors> srpRegEd;  
    if ((SUCCEEDED(m_srpPkgSiteSP->QueryService(SID_SVsRegisterEditors, IID_IVsRegisterEditors,(void **)&srpRegEd ))) && (srpRegEd != NULL))  
      {  
        ATLTRACE(TEXT(">> CVsPackage, registering editor factory.\n"));  
          if (FAILED(srpRegEd->RegisterEditor(GUID_BscEditorFactory,  
                      m_srpEdFact, &m_dwEditorCookie)))   
          {  
             ATLTRACE(TEXT(">> CVsPackage, RegisterEditor() failed.\n"));  
            return E_FAIL;  
          }  
      }  
        return S_OK;  
    }  
    ```  
  
     The GUID strings are defined in Resource.h file of the BscEdit project.
