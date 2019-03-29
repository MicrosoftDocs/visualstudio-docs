---
title: "CA3002: Review code for XSS vulnerabilities"
ms.date: 03/25/2019
ms.topic: reference
author: dotpaul
ms.author: paulming
manager: jillfra
dev_langs:
 - "CSharp"
 - "VisualBasic"
ms.workload:
  - "multiple"
---
# CA3002: Review code for XSS vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForXssVulnerabilities|
|CheckId|CA3002|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

Potentially untrusted HTTP request input reaches raw HTML output.

## Rule description

When working with untrusted input from web requests, be mindful of cross-site scripting (XSS) attacks. An XSS attack injects untrusted input into raw HTML output, allowing the attacker to execute malicious scripts or maliciously modify content in your web page. A typical technique is putting `<script>` elements with malicious code in input. For more information, see [OWASP's XSS](https://www.owasp.org/index.php/Cross-site_Scripting_(XSS)).

This rule attempts to find input from HTTP requests reaching raw HTML output.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that outputs raw HTML, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in `.editorconfig` files.

## How to fix violations

- Instead of outputting raw HTML, use a method or property that first HTML-encodes its input.
- HTML-encode untrusted data before outputting raw HTML.

## When to suppress warnings

It's safe to suppress a warning from this rule if:
- You know that the input is validated against a known safe set of characters not containing HTML.
- You know the data is HTML-encoded in a way not detected by this rule.

> [!NOTE]
> This rule may report false positives for some methods or properties that HTML-encode their input.

## Pseudo-code examples

### Violation

```csharp
using System;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string input = Request.Form["in"];
        Response.Write("<HTML>" + input + "</HTML>");
    }
}
```

```vb
Imports System

Partial Public Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim input As String = Me.Request.Form("in")
        Me.Response.Write("<HTML>" + input + "</HTML>")
    End Sub
End Class
```

### Solution

```csharp
using System;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string input = Request.Form["in"];

        // Example usage of System.Web.HttpServerUtility.HtmlEncode().
        Response.Write("<HTML>" + Server.HtmlEncode(input) + "</HTML>");
    }
}
```

```vb
Imports System

Partial Public Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs)
        Dim input As String = Me.Request.Form("in")

        ' Example usage of System.Web.HttpServerUtility.HtmlEncode().
        Me.Response.Write("<HTML>" + Me.Server.HtmlEncode(input) + "</HTML>")
    End Sub
End Class
```