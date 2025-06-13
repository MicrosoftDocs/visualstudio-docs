---
title: Single and Multi-tab Views
description: Learn how to implement multi-tab views in editors, such as a code editor windows and a forms designer.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- editors [Visual Studio SDK], custom - single and multi-tab views
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Single and Multi-tab Views

An editor can create different types of views. One example is a code editor window, another is a forms designer.

 A multi-tabbed view is a view that has multiple tabs. For example, the HTML editor has two tabs at the bottom: **Design** and **Source**, each a logical view. The design view displays a rendered web page, while the other displays the HTML that comprises the web page.

## Accessing Physical Views
 Physical views host document view objects, each representing a view of data in the buffer, such as code or a form. Accordingly, each document view object has a physical view (identified by something known as a physical view string), and generally a single logical view.

 In some cases, though, a physical view can have two or more logical views. Some examples are an editor that has a split window with side-by-side views, or a forms designer that has a GUI/design view and a code-behind-the-form view.

 To enable your editor to access all of the available physical views, you must create a unique physical view string for each type of document view object that your editor factory can create. For example, the Visual Basic editor factory can create document view objects for a code window and a forms designer window.

## Creating Multi-Tabbed Views
 Though a document view object must be associated with a physical view through a unique physical view string, you can place multiple tabs within the physical view to enable the viewing of data in different ways. In this multi-tabbed configuration, all tabs are associated with the same physical view string, but each tab is given a different logical view GUID.

 To create a multi-tabbed view for an editor, implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsMultiViewDocumentView> interface and then associate a different logical view GUID (<xref:Microsoft.VisualStudio.Shell.Interop.LogicalViewID>) with each tab you create.

 The Visual Studio HTML editor is an example of an editor with a multi-tab view. It has **Design** and **Source** tabs. To enable this, a different logical view is associated with each tab, `LOGICALVIEWID_TextView` for the **Design** tab and `LOGICALVIEWID_Code` for the **Source** tab.

 By specifying the appropriate logical view, a VSPackage can access the view that corresponds to a particular purpose, such as designing a form, editing code, or debugging code. However, one of the windows must be identified by the NULL string and this must correspond to the primary logical view (`LOGVIEWID_Primary`).

 The following table lists the available logical view values and their use.

|LOGVIEWID GUID|Recommended Use|
|--------------------|---------------------|
|`LOGVIEWID_Primary`|Default/primary view of the editor factory.<br /><br /> All editor factories must support this value. This view must use the NULL string as its physical view string. At least one logical view must be set to this value.|
|`LOGVIEWID_Debugging`|Debugging view. Typically, `LOGVIEWID_Debugging` maps to the same view as `LOGVIEWID_Code`.|
|`LOGVIEWID_Code`|View launched by the **View Code** command.|
|`LOGVIEWID_Designer`|View launched by the **View Form** command.|
|`LOGVIEWID_TextView`|Text editor view. This is the view that returns <xref:Microsoft.VisualStudio.TextManager.Interop.IVsCodeWindow>, from which you can access <xref:Microsoft.VisualStudio.TextManager.Interop.IVsTextView>.|
|`LOGVIEWID_UserChooseView`|Prompts the user to choose which view to use.|
|`LOGVIEWID_ProjectSpecificEditor`|Passed by the **Open With** dialog box to<br /><br /> <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject.OpenItem%2A><br /><br /> when the user chooses the "(Project default editor)" entry.|

 Although logical view GUIDs are extensible, you can use only the logical view GUIDs defined in your VSPackage.

 On shutdown, Visual Studio retains the GUID of the editor factory and the physical view strings associated with the document window so that it can be used to re-open document windows when the solution is re-opened. Only windows that are open when a solution is closed are persisted in the solution (.suo) file. These values correspond to the `VSFPROPID_guidEditorType` and `VSFPROPID_pszPhysicalView` values passed in the `propid` parameter in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> method.

## Example
 This snippet illustrates how the <xref:Microsoft.VisualStudio.Shell.Interop.LogicalViewID.TextView> object is used to access a view that implements `IVsCodeWindow`. In this case, the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUIShellOpenDocument> service is used to call <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShellOpenDocument.OpenDocumentViaProject%2A> and request `LOGVIEWID_TextView`, which obtains a pointer to a window frame. A pointer to the document view object is obtained by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> and specifying a value of `VSFPROPID_DocView`. From the document view object, `QueryInterface` is called for `IVsCodeWindow`. The expectation in this case is that a text editor is returned, and so the document view object returned in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowFrame.GetProperty%2A> method is a code window.

```cpp
HRESULT CFindTool::GotoFileLocation(const WCHAR * szFile, long iLine, long iStart, long iLen)
{
  HRESULT hr;
  if (NULL == szFile || !*szFile)
    return E_INVALIDARG;

  if (iLine == -1L)
    return S_FALSE;

  VSITEMID                  itemid;
  VARIANT                   var;
  RECT                      rc;
  IVsUIShellOpenDocument *  pOpenDoc    = NULL;
  IVsCodeWindow *           pCodeWin    = NULL;
  IVsTextView *             pTextView   = NULL;
  IVsUIHierarchy *          pHierarchy  = NULL;
  IVsWindowFrame *          pFrame      = NULL;
  IUnknown *                pUnk        = NULL;
  IVsHighlight *            pHighlight  = NULL;

  IfFailGo(CGlobalServiceProvider::HrQueryService(SID_SVsUIShellOpenDocument, IID_IVsUIShellOpenDocument, (void **)&pOpenDoc));
  IfFailGo(pOpenDoc->OpenDocumentViaProject(szFile, LOGVIEWID_TextView, NULL, &pHierarchy, &itemid, &pFrame));
  pFrame->Show();
  VariantInit(&var);
  IfFailGo(pFrame->GetProperty(VSFPROPID_DocView, &var));
  if (VT_UNKNOWN != var.vt) { hr = E_FAIL; goto Error; }
  pUnk = V_UNKNOWN(&var);
  if (NULL != pUnk)
  {
    IfFailGo(pUnk->QueryInterface(IID_IVsCodeWindow, (void **)&pCodeWin));
    if (SUCCEEDED(hr = pCodeWin->GetLastActiveView(&pTextView)) ||
        SUCCEEDED(hr = pCodeWin->GetPrimaryView(&pTextView)) )
    {
      pTextView->SetSelection(iLine, iStart, iLine, iStart + iLen);
      // uncover selection
      IfFailGo(pTextView->QueryInterface(IID_IVsHighlight, (void**)&pHighlight));
      IfFailGo(SUCCEEDED(pHighlight->GetHighlightRect(&rc)));
      UncoverSelectionRect(&rc);
    }
  }

Error:
  CLEARINTERFACE(pHighlight);
  CLEARINTERFACE(pTextView);
  CLEARINTERFACE(pCodeWin);
  CLEARINTERFACE(pUnk);
  CLEARINTERFACE(pFrame);
  CLEARINTERFACE(pOpenDoc);
  CLEARINTERFACE(pHierarchy);
  RedrawWindow(m_hwndResults, NULL, NULL, RDW_ERASE|RDW_FRAME|RDW_INVALIDATE|RDW_ALLCHILDREN);
  return hr;
}
```

## Related content
- [Supporting Multiple Document Views](../extensibility/supporting-multiple-document-views.md)
- [How to: Attach Views to Document Data](../extensibility/how-to-attach-views-to-document-data.md)
- [Creating Custom Editors and Designers](../extensibility/creating-custom-editors-and-designers.md)
