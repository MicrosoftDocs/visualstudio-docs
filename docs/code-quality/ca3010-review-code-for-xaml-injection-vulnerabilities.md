---
title: "CA3010: Review code for XAML injection vulnerabilities"
ms.date: 04/03/2019
ms.topic: reference
author: dotpaul
ms.author: paulming
manager: jillfra
dev_langs:
 - "CSharp"
 - VB
ms.workload:
 - "multiple"
---
# CA3010: Review code for XAML injection vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForXamlInjectionVulnerabilities|
|CheckId|CA3010|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

Potentially untrusted HTTP request input reaches a <xref:System.Windows.Markup.XamlReader?displayProperty=nameWithType> Load method.

## Rule description

When working with untrusted input, be mindful of XAML injection attacks. XAML is a markup language that directly represents object instantiation and execution. That means elements created in XAML can interact with system resources (for example, network access and file system IO). If an attacker can control the input to a <xref:System.Windows.Markup.XamlReader?displayProperty=nameWithType> Load method call, then the attacker can execute code.

This rule attempts to find input from HTTP requests that reaches a <xref:System.Windows.Markup.XamlReader?displayProperty=nameWithType> Load method.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that loads XAML, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in `.editorconfig` files.

## How to fix violations

Don't load untrusted XAML.

## When to suppress warnings

Don't suppress warnings from this rule.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.IO;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string input = Request.Form["in"];
        byte[] bytes = Convert.FromBase64String(input);
        MemoryStream ms = new MemoryStream(bytes);
        System.Windows.Markup.XamlReader.Load(ms);
    }
}
```

```vb
Imports System
Imports System.IO

Public Partial Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim input As String = Request.Form("in")
        Dim bytes As Byte() = Convert.FromBase64String(input)
        Dim ms As MemoryStream = New MemoryStream(bytes)
        System.Windows.Markup.XamlReader.Load(ms)
    End Sub
End Class
```
