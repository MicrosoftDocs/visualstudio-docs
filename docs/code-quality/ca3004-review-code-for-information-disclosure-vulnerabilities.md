---
title: "CA3004: Review code for information disclosure vulnerabilities"
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
# CA3004: Review code for information disclosure vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForInformationDisclosureVulnerabilities|
|CheckId|CA3004|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

An exception's message, stack trace, or string representation reaches web output.

## Rule description

Disclosing exception information gives attackers insight into the internals of your application, which can help attackers find other vulnerabilities to exploit.

This rule attempts to find an exception message, stack trace, or string representation being output to an HTTP response.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly catches an exception and then passes it to another assembly that outputs the exception, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in an EditorConfig file.

## How to fix violations

Don't output exception information to HTTP responses. Instead, provide a generic error message. See [OWASP's Error Handling page](https://www.owasp.org/index.php/Error_Handling) for more guidance.

## When to suppress warnings

If you know your web output is within your application's trust boundary and never exposed outside, it's okay to suppress this warning. This is rare. Take into consideration that your application's trust boundary and data flows may change over time.

## Pseudo-code examples

### Violation

```csharp
using System;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs eventArgs)
    {
        try
        {
            object o = null;
            o.ToString();
        }
        catch (Exception e)
        {
            this.Response.Write(e.ToString());
        }
    }
}
```

```vb
Imports System

Partial Public Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, eventArgs As EventArgs)
        Try
            Dim o As Object = Nothing
            o.ToString()
        Catch e As Exception
            Me.Response.Write(e.ToString())
        End Try
    End Sub
End Class
```

### Solution

```csharp
using System;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs eventArgs)
    {
        try
        {
            object o = null;
            o.ToString();
        }
        catch (Exception e)
        {
            this.Response.Write("An error occurred. Please try again later.");
        }
    }
}
```

```vb
Imports System

Partial Public Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, eventArgs As EventArgs)
        Try
            Dim o As Object = Nothing
            o.ToString()
        Catch e As Exception
            Me.Response.Write("An error occurred. Please try again later.")
        End Try
    End Sub
End Class
```