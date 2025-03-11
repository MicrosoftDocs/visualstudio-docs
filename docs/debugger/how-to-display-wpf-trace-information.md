---
title: Display WPF trace Information for data binding
description: Visual Studio can receive debug trace information for data binding from WPF applications and display it in the Output window. Learn how to manage and customize WPF tracing. 
ms.date: 02/25/2025
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - WPF, debugging
  - debugging, WPF
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Display WPF trace information for data binding

Visual Studio can receive debug trace information for data binding from WPF applications and display that information in the **Output** window. To display debug trace information, WPF tracing must be enabled.

 You can enable WPF tracing in your App.Config file or programmatically by using the <xref:System.Diagnostics.PresentationTraceSources> class. An easier way to enable WPF tracing is by using the **Options** window. WPF tracing for web applications is not supported.

## Enable or customize WPF trace information

1. On the **Tools** menu, select **Options**.

2. In the **Options** dialog box, in the box on the left, open the **Debugging** node.

3. Under **Debugging**, click **Output Window**.

4. Under **General Output Settings**, select **All debug output**.

5. In the box on the right, open the **WPF Trace Settings** node.

6. Under **WPF Trace Settings**, select **Data Binding**.

   A drop-down list control appears in the Settings column next to **Data Binding**.

7. Click the drop-down list and select the type of trace information that you want to see.

     **Critical** enables tracing of Critical events only.

     **Error** enables tracing of Critical and Error events.

     **Warning** enables tracing of Critical, Error, and Warning events.

     **Information** enables tracing of Critical, Error, Warning, and Information events.

     **Verbose** enables tracing of Critical, Error, Warning, Information, and Verbose events.

     **ActivityTracing** enables tracing of Stop, Start, Suspend, Transfer, and Resume events.

     For more information about what these levels of trace information mean, see <xref:System.Diagnostics.SourceLevels>.

9. Click **OK**.

## Related content
- [Debugging WPF](../debugger/debugging-wpf.md)