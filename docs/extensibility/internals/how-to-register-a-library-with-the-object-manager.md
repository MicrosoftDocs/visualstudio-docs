---
title: 'Register a Library with the Object Manager'
description: Learn how to register a library with the Visual Studio object manager so that you can view symbols in browsing tools, such as Class View and Object Browser.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- libraries, registering with object manager
- IVsLibrary2 interface, registering library with object manager
- IVsSimpleLibrary2 interface, registering library with object manager
- IVsObjectManager2 interface, registering library with object manager
- libraries, symbol-browsing tools
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Register a library with the object manager

Symbols-browsing tools, such as **Class View**, **Object Browser**, **Call Browser** and **Find Symbol Results**, enable you to view symbols in your project or in external components. The symbols include namespaces, classes, interfaces, methods, and other language elements. The libraries track these symbols and expose them to the Visual Studio object manager that populates the tools with the data.

 The object manager keeps track of all available libraries. Each library must register with the object manager before providing symbols for the symbol-browsing tools.

 Typically, you register a library when a VSPackage loads. However, it can be done at another time as needed. You unregister the library when the VSPackage shuts down.

 To register a library, use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterLibrary%2A> method. For a managed code library, use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterSimpleLibrary%2A> method.

 To unregister a library, use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.UnregisterLibrary%2A> method.

 To obtain a reference to the object manager, <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2>, pass the <xref:Microsoft.VisualStudio.Shell.Interop.SVsObjectManager> service ID to `GetService` method.

## Register and unregister a library with the object manager

### To register a library with the object manager

1. Create a library.

    ### [C#](#tab/csharp)
    ```csharp
    private CallBrowser.Library m_CallBrowserLibrary = null;
    private uint m_nLibraryCookie = 0;
    // Create Library.
    m_CallBrowserLibrary = new CallBrowser.Library();

    ```

    ### [VB](#tab/vb)
    ```vb
    Private m_CallBrowserLibrary As CallBrowser.Library = Nothing
    Private m_nLibraryCookie As UInteger = 0
    ' Create Library.
    m_CallBrowserLibrary = New CallBrowser.Library()
    ```
    ---

2. Obtain a reference to an object of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2> type and call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.RegisterSimpleLibrary%2A> method.

    ### [C#](#tab/csharp)
    ```csharp
    private void RegisterLibrary()
    {
        if (m_nLibraryCookie != 0)
            throw new Exception("Library already registered with Object Manager");

        // Obtain a reference to IVsObjectManager2 type object.
        IVsObjectManager2 objManager =
                          GetService(typeof(SVsObjectManager)) as IVsObjectManager2;
        if (objManager == null)
            throw new NullReferenceException("GetService failed for SVsObjectManager");

        try
        {
            int hr =
                objManager.RegisterSimpleLibrary(m_CallBrowserLibrary,
                                                 out m_nLibraryCookie);
                Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(hr);
        }
        catch (Exception e)
        {
            // Code to handle any CLS-compliant exception.
            Trace.WriteLine(e.Message);
            throw;
        }
    }

    ```

    ### [VB](#tab/vb)
    ```vb
    Private Sub RegisterLibrary()
        If m_nLibraryCookie <> 0 Then
            Throw New Exception("Library already registered with Object Manager")
        End If

        ' Obtain a reference to IVsObjectManager2 type object.
        Dim objManager As IVsObjectManager2 = TryCast(GetService(GetType(SVsObjectManager)), IVsObjectManager2)
        If objManager Is Nothing Then
            Throw New NullReferenceException("GetService failed for SVsObjectManager")
        End If

        Try
            Dim hr As Integer = objManager.RegisterSimpleLibrary(m_CallBrowserLibrary, m_nLibraryCookie)
            Microsoft.VisualStudio.ErrorHandler.ThrowOnFailure(hr)
        Catch e As Exception
            ' Code to handle any CLS-compliant exception.
            Trace.WriteLine(e.Message)
            Throw
        End Try
    End Sub
    ```
    ---

### To unregister a library with the object manager

1. Obtain a reference to an object of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2> type and call the <xref:Microsoft.VisualStudio.Shell.Interop.IVsObjectManager2.UnregisterLibrary%2A> method.

    ### [C#](#tab/csharp)
    ```csharp
    private void UnregisterLibrary()
    {
        if (m_nLibraryCookie != 0)
        {
            // Obtain a reference to IVsObjectManager2 type object.
            IVsObjectManager2 objManager = GetService(typeof(SVsObjectManager)) as IVsObjectManager2;
            if (objManager == null)
                throw new NullReferenceException("GetService failed for SVsObjectManager");

            try
            {
                objManager.UnregisterLibrary(m_nLibraryCookie);
            }
            catch (Exception e)
            {
                // Code to handle any CLS-compliant exception.
                Trace.WriteLine(e.Message);
                throw;
            }
            finally
            {
                m_nLibraryCookie = 0;
            }
        }
    }

    ```

    ### [VB](#tab/vb)
    ```vb
    Private Sub UnregisterLibrary()
        If m_nLibraryCookie <> 0 Then
            ' Obtain a reference to IVsObjectManager2 type object.
            Dim objManager As IVsObjectManager2 = TryCast(GetService(GetType(SVsObjectManager)), IVsObjectManager2)
            If objManager Is Nothing Then
                Throw New NullReferenceException("GetService failed for SVsObjectManager")
            End If

            Try
                objManager.UnregisterLibrary(m_nLibraryCookie)
            Catch e As Exception
                ' Code to handle any CLS-compliant exception.
                Trace.WriteLine(e.Message)
                Throw
            Finally
                m_nLibraryCookie = 0
            End Try
        End If
    End Sub
    ```
    ---

## Related content
- [Legacy language service extensibility](/previous-versions/visualstudio/visual-studio-2017/extensibility/internals/legacy-language-service-extensibility)
- [Support symbol-browsing tools](../../extensibility/internals/supporting-symbol-browsing-tools.md)
- [How to: Expose lists of symbols provided by the library to the object manager](../../extensibility/internals/how-to-expose-lists-of-symbols-provided-by-the-library-to-the-object-manager.md)
