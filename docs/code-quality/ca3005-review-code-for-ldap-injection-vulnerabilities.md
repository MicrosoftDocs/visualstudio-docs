---
title: "CA3005: Review code for LDAP injection vulnerabilities"
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
# CA3005: Review code for LDAP injection vulnerabilities

|||
|-|-|
|TypeName|ReviewCodeForLdapInjectionVulnerabilities|
|CheckId|CA3005|
|Category|Microsoft.Security|
|Breaking Change|Non Breaking|

## Cause

Potentially untrusted HTTP request input reaches an LDAP statement.

## Rule description

When working with untrusted input, be mindful of Lightweight Directory Access Protocol (LDAP) injection attacks. An attacker can potentially run malicious LDAP statements against information directories. Applications that use user input to construct dynamic LDAP statements to access directory services are particularly vulnerable.

This rule attempts to find input from HTTP requests reaching an LDAP statement.

> [!NOTE]
> This rule can't track data across assemblies. For example, if one assembly reads the HTTP request input and then passes it to another assembly that executes an LDAP statement, this rule won't produce a warning.

> [!NOTE]
> There is a configurable limit to how deep this rule will analyze data flow across method calls. See [Analyzer Configuration](https://github.com/dotnet/roslyn-analyzers/blob/master/docs/Analyzer%20Configuration.md#dataflow-analysis) for how to configure the limit in `.editorconfig` files.

## How to fix violations

For the user-controlled portion of LDAP statements, consider one of:
1. Allow only a safe list of non-special characters.
1. Disallow special character
1. Escape special characters.

See [OWASP's LDAP Injection Prevention Cheat Sheet](https://github.com/OWASP/CheatSheetSeries/blob/master/cheatsheets/LDAP_Injection_Prevention_Cheat_Sheet.md) for more guidance.

## When to suppress warnings

If you know the input has been validated or escaped to be safe.

## Pseudo-code examples

### Violation

```csharp
using System;
using System.DirectoryServices;

public partial class WebForm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string userName = Request.Params["user"];
        string filter = "(uid=" + userName + ")";  // searching for the user entry 

        // In this example, if we send the * character in the user parameter which will
        // result in the filter variable in the code to be initialized with (uid=*). 
        // The resulting LDAP statement will make the server return any object that 
        // contains a uid attribute.
        DirectorySearcher searcher = new DirectorySearcher(filter);
        SearchResultCollection results = searcher.FindAll();

        // Iterate through each SearchResult in the SearchResultCollection.
        foreach (SearchResult searchResult in results)
        {
            // ...
        }
    }
}
```

```vb
Imports System
Imports System.DirectoryServices

Partial Public Class WebForm
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(send As Object, e As EventArgs)
        Dim userName As String = Me.Request.Params(""user"")
        Dim filter As String = ""(uid="" + userName + "")""    ' searching for the user entry

        ' In this example, if we send the * character in the user parameter which will
        ' result in the filter variable in the code to be initialized with (uid=*). 
        ' The resulting LDAP statement will make the server return any object that 
        ' contains a uid attribute.
        Dim searcher As DirectorySearcher = new DirectorySearcher(filter)
        Dim results As SearchResultCollection = searcher.FindAll()

        ' Iterate through each SearchResult in the SearchResultCollection.
        For Each searchResult As SearchResult in results
            ' ...
        Next searchResult
    End Sub
End Class
```