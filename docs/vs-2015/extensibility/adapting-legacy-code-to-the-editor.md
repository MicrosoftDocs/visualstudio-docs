---
title: "Adapting Legacy Code to the Editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "editors [Visual Studio SDK], legacy - adapters"
ms.assetid: a208d38e-9bea-41c9-9fe2-38bd86a359cb
caps.latest.revision: 26
ms.author: gregvanl
manager: jillfra
---
# Adapting Legacy Code to the Editor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Visual Studio editor has many features that you can access from existing code components. The following instructions show how to adapt a non-MEF component, for example, a VSPackage, to consume editor functionality. The instructions also show how to use adapters to get the services of the editor in both managed and unmanaged code.  
  
## Editor Adapters  
 Editor adapters, or shims, are wrappers for editor objects that also expose the classes and interfaces in the <xref:Microsoft.VisualStudio.TextManager.Interop> API. You can use the adapters to move between non-editor services for example, Visual Studio shell commands, and editor services. (This is how the editor is currently hosted in Visual Studio.) Adapters also enable legacy editor and language service extensions to work correctly in Visual Studio.  
  
## Using Editor Adapters  
 The <xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService> provides methods that switch between the new editor interfaces and the legacy interfaces, and also methods that create adapters.  
  
 If you are using this service in a MEF component part, you can import the service as follows.  
  
```  
[Import(typeof(IVsEditorAdaptersFactoryService))]  
internal IVsEditorAdaptersFactoryService editorFactory;  
```  
  
 If you want to use this service in a non-MEF component, follow the instructions in the "Using Visual Studio Editor Services in a Non-MEF Component" section later in this topic.  
  
## Switching Between the New Editor API and the Legacy API  
 Use the following methods to switch between an editor object and a legacy interface.  
  
|Method|Conversion|  
|------------|----------------|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetBufferAdapter%2A>|Converts an <xref:Microsoft.VisualStudio.Text.ITextBuffer> to an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetDataBuffer%2A>|Converts an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> to an <xref:Microsoft.VisualStudio.Text.ITextBuffer>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetDocumentBuffer%2A>|Converts an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> to an <xref:Microsoft.VisualStudio.Text.ITextBuffer>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetViewAdapter%2A>|Converts an <xref:Microsoft.VisualStudio.Text.Editor.ITextView> to an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.GetWpfTextView%2A>|Converts an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> to an <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextView>.|  
  
## Creating Adapters  
 Use the following methods to create adapters for legacy interfaces.  
  
|Method|Conversion|  
|------------|----------------|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsCodeWindowAdapter%2A>|Creates an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextBufferAdapter%2A>|Creates an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer> for a specified <xref:Microsoft.VisualStudio.Utilities.IContentType>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextBufferAdapter%2A>|Creates an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBuffer>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextBufferCoordinatorAdapter%2A>|Creates an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextBufferCoordinator>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextViewAdapter%2A>|Creates an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView> for an <xref:Microsoft.VisualStudio.Text.Editor.ITextViewRoleSet>.|  
|<xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService.CreateVsTextViewAdapter%2A>|Creates an <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>.|  
  
## Creating Adapters in Unmanaged Code  
 All adapter classes are registered to be local co-creatable, and can be instantiated by using the `VsLocalCreateInstance()` function.  
  
 All adapters are created by using the GUIDs that are defined in the vsshlids.h file in the ..\VisualStudioIntegration\Common\Inc\ folder of the Visual Studio SDK installation. To create an instance of VsTextBufferAdapter, use the following code.  
  
```  
IVsTextBuffer *pBuf = NULL;  
VsLocalCreateInstance(CLSID_VsTextBuffer, NULL, CLSCTX_INPROC_SERVER, IID_IVsTextBuffer, (void**)&pBuf);  
```  
  
## Creating Adapters in Managed Code  
 In managed code, you can co-create the adapters in the same way as that described for unmanaged code. You can also use a MEF service that lets you create and interact with adapters. This manner of getting an adapter enables more fine-grained control than you have when you co-create it.  
  
#### To create an adapter for IVsTextView  
  
1. Add a reference to Microsoft.VisualStudio.Editor.dll. Make sure that `CopyLocal` is set to `false`.  
  
2. Instantiate the <xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService>, as follows.  
  
    ```  
    using Microsoft.VisualStudio.Editor;  
    ...  
    IVsEditorAdaptersFactoryService adapterFactoryService = ComponentModel.GetService<IVsEditorAdaptersFactoryService>();  
    ```  
  
3. Call the `CreateX()` method.  
  
    ```  
    adapterFactoryService.CreateTextViewAdapter(textView);  
    ```  
  
## Using the Visual Studio Editor Directly from Unmanaged Code  
 The Microsoft.VisualStudio.Platform.VSEditor namespace and the Microsoft.VisualStudio.Platform.VSEditor.Interop namespace expose COM-callable interfaces as IVx* interfaces. For example, the Microsoft.VisualStudio.Platform.VSEditor.Interop.IVxTextBuffer interface is the COM version of the <xref:Microsoft.VisualStudio.Text.ITextBuffer> interface. From the `IVxTextBuffer`, you can get access to the buffer snapshots, modify the buffer, listen for text-change events on the buffer, and create tracking points and spans. The following steps show how to access an `IVxTextBuffer` from a `IVsTextBuffer`.  
  
#### To get an IVxTextBuffer  
  
1. The definitions for the IVx* interfaces are in the VSEditor.h file in the ..\VisualStudioIntegration\Common\Inc\ folder of the Visual Studio SDK installation.  
  
2. The following code instantiates a text buffer by using the `IVsUserData->GetData()` method. In the following code, `pData` is a pointer to an `IVsUserData` object.  
  
    ```  
    #include <textmgr.h>  
    #include <VSEditor.h>  
    #include <vsshlids.h>  
  
    CComPtr<IVsTextBuffer> pVsTextBuffer;  
    CComPtr<IVsUserData> pData;  
    CComPtr<IVxTextBuffer> pVxBuffer;  
    ...  
    if (SUCCEEDED(pVsTextBuffer->QueryInterface(IID_IVsUserData, &pData))  
    {  
        CComVariant vt;  
        if (SUCCEEDED(pData->GetData(GUID_VxTextBuffer, &vt)) &&  
        (vt.Type == VT_UNKNOWN) && (vt.punkVal != NULL))  
        {  
            vt.punkVal->QueryInterface(IID_IVxTextBuffer, (void**)&pVxBuffer);  
        }  
    }  
    ```  
  
## Using Visual Studio Editor Services in a Non-MEF Component  
 If you have an existing managed code component that does not use MEF and you want to use the services of the Visual Studio editor, you must add a reference to the assembly that contains the ComponentModelHost VSPackage and get its SComponentModel service.  
  
#### To consume Visual Studio editor components from a non-MEF component  
  
1. Add a reference to the Microsoft.VisualStudio.ComponentModelHost.dll assembly in the ..\Common7\IDE\ folder of the Visual Studio installation. Make sure that `CopyLocal` is set to `false`.  
  
2. Add a private `IComponentModel` member to the class in which you want to use Visual Studio editor services, as follows.  
  
    ```  
    using Microsoft.VisualStudio.ComponentModelHost;  
    ....  
    private IComponentModel componentModel;  
    ```  
  
3. Instantiate the component model in the initialization method for your component.  
  
    ```  
    componentModel =  
     (IComponentModel)Package.GetGlobalService(typeof(SComponentModel));  
    ```  
  
4. After this, you can get any one of the Visual Studio editor services by calling the `IComponentModel.GetService<T>()` method for the service you want.  
  
    ```  
    textBufferFactoryService =  
         componentModel.GetService<ITextBufferFactoryService>();     
    ```
