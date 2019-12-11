---
title: "How to: Display WPF Trace Information | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "WPF, debugging"
  - "debugging, WPF"
ms.assetid: be3c6859-06e1-459e-9fd0-46375b5f55ef
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Display WPF Trace Information
[!INCLUDE[vs_current_short](../code-quality/includes/vs_current_short_md.md)] can receive debug trace information from WPF applications and display that information in the **Output** window. To display debug trace information, WPF tracing must be enabled.

 You can enable WPF tracing in your App.Config file or programmatically by using the <xref:System.Diagnostics.PresentationTraceSources> class. An easier way to enable WPF tracing is by using the **Options** window. WPF tracing for web applications is not supported.

### To enable or customize WPF trace information

1. On the **Tools** menu, select **Options**.

2. In the **Options** dialog box, in the box on the left, open the **Debugging** node.

3. Under **Debugging**, click **Output Window**.

4. Under **General Output Settings**, select **All debug output**.

5. In the box on the right, look for **WPF Trace Settings**.

6. Open the **WPF Trace Settings** node.

7. Under **WPF Trace Settings**, click the category of settings that you want to enable (for example, **Data Binding**).

     A drop-down list control appears in the Settings column next to **Data Binding** or whatever category you clicked.

8. Click the drop-down list and select the type of trace information that you want to see: **All**, **Critical**, **Error**, **Warning**, **Information**, **Verbose**, or **ActivityTracing**.

     **Critical** enables tracing of Critical events only.

     **Error** enables tracing of Critical and Error events.

     **Warning** enables tracing of Critical, Error, and Warning events.

     **Information** enables tracing of Critical, Error, Warning, and Information events.

     **Verbose** enables tracing of Critical, Error, Warning, Information, and Verbose events.

     **ActivityTracing** enables tracing of Stop, Start, Suspend, Transfer, and Resume events.

     For more information about what these levels of trace information mean, see <xref:System.Diagnostics.SourceLevels>.

9. Click **OK**.

### To disable WPF trace information

1. On the **Tools** menu, select **Options**.

2. In the **Options** dialog box, in the box on the left, open the **Debugging** node.

3. Under **Debugging**, click **Output Window**.

4. In the box on the right, look for **WPF Trace Settings**.

5. Open the **WPF Trace Settings** node.

6. Under **WPF Trace Settings**, click the category of settings that you want to enable (for example, **Data Binding**).

     A drop-down list control appears in the Settings column next to **Data Binding** or whatever category you clicked.

7. Click the drop-down list and select **Off**.

8. Click **OK**.

## See also
- [Debugging WPF](../debugger/debugging-wpf.md)