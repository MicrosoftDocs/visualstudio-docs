---
title: Code a custom extraction rule (web perf test)
description: Learn how to create your own extraction rules, derived from an extraction rule class, ExtractionRule.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - extraction rules
  - Web performance tests, creating custom extraction rules
  - extraction rules, creating custom
ms.assetid: 6bcc5712-6cc6-4f59-8933-6e8078318c45
dev_langs: 
  - CSharp
  - VB
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Code a custom extraction rule for a web performance test

You can create your own extraction rules. To do this, you derive your own rules from an extraction rule class. Extraction rules derive from the <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule> base class.

> [!NOTE]
> You can also create custom validation rules. For more information, see [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md).

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## To create a custom extraction rule

1. Open a Test project that contains a web performance test.

2. (Optional) Create a separate Class library project in which to store your extraction rule.

    > [!IMPORTANT]
    > You can create the class in the same project that your tests are in. However, if you want to reuse the rule, it is better to create a separate Class library project in which to store your rule. If you create a separate project, you must complete the optional steps in this procedure.

3. (Optional) In the Class library project, add a reference to the Microsoft.VisualStudio.QualityTools.WebTestFramework dll.

4. Create a class that derives from the <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule> class. Implement the <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule.Extract*> and <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule.RuleName*> members.

5. (Optional) Build the new Class library project.

6. (Optional) In the Test project, add a reference to the Class library project that contains the custom extraction rule.

7. In the Test project, open a web performance test in the **Web Performance Test Editor**.

8. To add the custom extraction rule, right-click a web performance test request and select **Add Extraction Rule**.

     The **Add Extraction Rule** dialog box appears. You will see your custom validation rule in the **Select a rule** list, together with the predefined validation rules. Select your custom extraction rule and then choose **OK**.

9. Run your web performance test.

## Example

The following code shows an implementation of a custom extraction rule. This extraction rule extracts the value from a specified input field. Use this example as a starting point for your own custom extraction rules.

```csharp
using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.WebTesting;
using System.Globalization;

namespace ClassLibrary2
{
    //-------------------------------------------------------------------------
    // This class creates a custom extraction rule named "Custom Extract Input"
    // The user of the rule specifies the name of an input field, and the
    // rule attempts to extract the value of that input field.
    //-------------------------------------------------------------------------
    public class CustomExtractInput : ExtractionRule
    {
        /// Specify a name for use in the user interface.
        /// The user sees this name in the Add Extraction dialog box.
        //---------------------------------------------------------------------
        public override string RuleName
        {
            get { return "Custom Extract Input"; }
        }

        /// Specify a description for use in the user interface.
        /// The user sees this description in the Add Extraction dialog box.
        //---------------------------------------------------------------------
        public override string RuleDescription
        {
            get { return "Extracts the value from a specified input field"; }
        }

        // The name of the desired input field
        private string NameValue;
        public string Name
        {
            get { return NameValue; }
            set { NameValue = value; }
        }

        // The Extract method.  The parameter e contains the web performance test context.
        //---------------------------------------------------------------------
        public override void Extract(object sender, ExtractionEventArgs e)
        {
            if (e.Response.HtmlDocument != null)
            {
                foreach (HtmlTag tag in e.Response.HtmlDocument.GetFilteredHtmlTags(new string[] { "input" }))
                {
                    if (String.Equals(tag.GetAttributeValueAsString("name"), Name, StringComparison.InvariantCultureIgnoreCase))
                    {
                        string formFieldValue = tag.GetAttributeValueAsString("value");
                        if (formFieldValue == null)
                        {
                            formFieldValue = String.Empty;
                        }

                        // add the extracted value to the web performance test context
                        e.WebTest.Context.Add(this.ContextParameterName, formFieldValue);
                        e.Success = true;
                        return;
                    }
                }
            }
            // If the extraction fails, set the error text that the user sees
            e.Success = false;
            e.Message = String.Format(CultureInfo.CurrentCulture, "Not Found: {0}", Name);
        }
    }
}
```

```vb
Imports System
Imports System.Collections.Generic
Imports Microsoft.VisualStudio.TestTools.WebTesting
Imports System.Globalization

Namespace ClassLibrary2

    '-------------------------------------------------------------------------
    ' This class creates a custom extraction rule named "Custom Extract Input"
    ' The user of the rule specifies the name of an input field, and the
    ' rule attempts to extract the value of that input field.
    '-------------------------------------------------------------------------
    Public Class CustomExtractInput
        Inherits ExtractionRule

        ' Specify a name for use in the user interface.
        ' The user sees this name in the Add Extraction dialog box.
        '---------------------------------------------------------------------
        Public Overrides ReadOnly Property RuleName() As String
            Get
                Return "Custom Extract Input"
            End Get
        End Property

        ' Specify a description for use in the user interface.
        ' The user sees this description in the Add Extraction dialog box.
        '---------------------------------------------------------------------
        Public Overrides ReadOnly Property RuleDescription() As String
            Get
                Return "Extracts the value from a specified input field"
            End Get
        End Property

        ' The name of the desired input field
        Private NameValue As String
        Public Property Name() As String
            Get
                Return NameValue
            End Get
            Set(ByVal value As String)
                NameValue = value
            End Set
        End Property

        ' The Extract method.  The parameter e contains the web performance test context.
        '---------------------------------------------------------------------
        Public Overrides Sub Extract(ByVal sender As Object, ByVal e As ExtractionEventArgs)

            If Not e.Response.HtmlDocument Is Nothing Then

                For Each tag As HtmlTag In e.Response.HtmlDocument.GetFilteredHtmlTags(New String() {"input"})

                    If String.Equals(tag.GetAttributeValueAsString("name"), Name, StringComparison.InvariantCultureIgnoreCase) Then

                        Dim formFieldValue As String = tag.GetAttributeValueAsString("value")
                        If formFieldValue Is Nothing Then

                            formFieldValue = String.Empty
                        End If

                        ' add the extracted value to the web performance test context
                        e.WebTest.Context.Add(Me.ContextParameterName, formFieldValue)
                        e.Success = True
                        Return
                    End If
                Next
            End If
            ' If the extraction fails, set the error text that the user sees
            e.Success = False
            e.Message = String.Format(CultureInfo.CurrentCulture, "Not Found: {0}", Name)
        End Sub
    End Class
End Namespace
```

The <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule.Extract*> method contains the core functionality of an extraction rule. The <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule.Extract*> method in the previous example takes an <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionEventArgs> that provides the response generated by the request this extraction rule covers. The response contains an <xref:Microsoft.VisualStudio.TestTools.WebTesting.HtmlDocument> which contains all the tags in the response. Input tags are filtered out of the <xref:Microsoft.VisualStudio.TestTools.WebTesting.HtmlDocument>. Each input tag is examined for an attribute called `name` whose value equals the user supplied value of the `Name` property. If a tag with this matching attribute is found, an attempt is made to extract a value that is contained by the `value` attribute, if a value attribute exists. If it exists, the name and value of the tag are extracted and added to the web performance test context. The extraction rule passes.

## See also

- <xref:Microsoft.VisualStudio.TestTools.WebTesting.ExtractionRule>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules.ExtractAttributeValue>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules.ExtractFormField>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules.ExtractHttpHeader>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules.ExtractRegularExpression>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules.ExtractText>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.Rules.ExtractHiddenFields>
- [Coding a custom validation rule for a web performance test](../test/code-a-custom-validation-rule-for-a-web-performance-test.md)
