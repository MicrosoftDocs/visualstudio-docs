---
title: "Walkthrough: Creating a Custom Directive Processor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "text templates, custom directive processors"
  - "walkthroughs [text templates], directive processor"
ms.assetid: b8f35a36-14e1-4467-8f5f-e01402af14d5
caps.latest.revision: 76
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: Creating a Custom Directive Processor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Directive processors* work by adding code to the *generated transformation class*. If you call a *directive* from a *text template*, the rest of the code that you write in your text template can rely on the functionality that the directive provides.

 You can write your own custom directive processors. This enables you to customize your text templates. To create a custom directive processor, you create a class that inherits from either <xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor> or <xref:Microsoft.VisualStudio.TextTemplating.RequiresProvidesDirectiveProcessor>.

 Tasks that are illustrated in this walkthrough include the following:

- Creating a custom directive processor

- Registering the directive processor

- Testing the directive processor

## Prerequisites
 To complete this walkthrough, you will need:

- Visual Studio 2010

- Visual Studio 2010 SDK

## Creating a Custom Directive Processor
 In this walkthrough, you create a custom directive processor. You add a custom directive that reads an XML file, stores it in an <xref:System.Xml.XmlDocument> variable, and exposes it through a property. In the section "Testing the Directive Processor," you use this property in a text template to access the XML file.

 The call to your custom directive looks like the following:

 `<#@ CoolDirective Processor="CustomDirectiveProcessor" FileName="<Your Path>DocFile.xml" #>`

 The custom directive processor adds the variable and the property to the generated transformation class. The directive that you write uses the <xref:System.CodeDom> classes to create the code that the engine adds to the generated transformation class. The <xref:System.CodeDom> classes create code in either Visual C# or [!INCLUDE[vbprvb](../includes/vbprvb-md.md)], depending on the language specified in the `language` parameter of the `template` directive. The language of the directive processor and the language of the text template that is accessing the directive processor do not have to match.

 The code that the directive creates looks like the following:

```csharp
private System.Xml.XmlDocument document0Value;

public virtual System.Xml.XmlDocument Document0
{
  get
  {
    if ((this.document0Value == null))
    {
      this.document0Value = XmlReaderHelper.ReadXml(<FileNameParameterValue>);
    }
    return this.document0Value;
  }
}
```

```vb
Private document0Value As System.Xml.XmlDocument

Public Overridable ReadOnly Property Document0() As System.Xml.XmlDocument
    Get
        If (Me.document0Value Is Nothing) Then
            Me.document0Value = XmlReaderHelper.ReadXml(<FileNameParameterValue>)
        End If
        Return Me.document0Value
    End Get
End Property
```

#### To create a custom directive processor

1. In Visual Studio, create a C# or a Visual Basic class library project named CustomDP.

    > [!NOTE]
    > If you want to install the directive processor on more than one computer, it is better to use a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension (VSIX) project and include a .pkgdef file in the extension. For more information, see [Deploying a Custom Directive Processor](../modeling/deploying-a-custom-directive-processor.md).

2. Add  references to these assemblies:

    - **Microsoft.VisualStudio.TextTemplating.\*.0**

    - **Microsoft.VisualStudio.TextTemplating.Interfaces.\*.0**

3. Replace the code in **Class1** with the following code. This code defines a CustomDirectiveProcessor class that inherits from the <xref:Microsoft.VisualStudio.TextTemplating.DirectiveProcessor> class and implements the necessary methods.

    ```csharp
    using System;
    using System.CodeDom;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using Microsoft.VisualStudio.TextTemplating;

    namespace CustomDP
    {
        public class CustomDirectiveProcessor : DirectiveProcessor
        {
            //this buffer stores the code that is added to the
            //generated transformation class after all the processing is done
            //---------------------------------------------------------------------
            private StringBuilder codeBuffer;

            //Using a Code Dom Provider creates code for the
            //generated transformation class in either Visual Basic or C#.
            //If you want your directive processor to support only one language, you
            //can hard code the code you add to the generated transformation class.
            //In that case, you do not need this field.
            //--------------------------------------------------------------------------
            private CodeDomProvider codeDomProvider;

            //this stores the full contents of the text template that is being processed
            //--------------------------------------------------------------------------
            private String templateContents;

            //These are the errors that occur during processing. The engine passes
            //the errors to the host, and the host can decide how to display them,
            //for example the host can display the errors in the UI
            //or write them to a file.
            //---------------------------------------------------------------------
            private CompilerErrorCollection errorsValue;
            public new CompilerErrorCollection Errors
            {
                get { return errorsValue; }
            }

            //Each time this directive processor is called, it creates a new property.
            //We count how many times we are called, and append "n" to each new
            //property name. The property names are therefore unique.
            //-----------------------------------------------------------------------------
            private int directiveCount = 0;

            public override void Initialize(ITextTemplatingEngineHost host)
            {
                //we do not need to do any initialization work
            }

            public override void StartProcessingRun(CodeDomProvider languageProvider, String templateContents, CompilerErrorCollection errors)
            {
                //the engine has passed us the language of the text template
                //we will use that language to generate code later
                //----------------------------------------------------------
                this.codeDomProvider = languageProvider;
                this.templateContents = templateContents;
                this.errorsValue = errors;

                this.codeBuffer = new StringBuilder();
            }

            //Before calling the ProcessDirective method for a directive, the
            //engine calls this function to see whether the directive is supported.
            //Notice that one directive processor might support many directives.
            //---------------------------------------------------------------------
            public override bool IsDirectiveSupported(string directiveName)
            {
                if (string.Compare(directiveName, "CoolDirective", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return true;
                }
                if (string.Compare(directiveName, "SuperCoolDirective", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return true;
                }
                return false;
            }

            public override void ProcessDirective(string directiveName, IDictionary<string, string> arguments)
            {
                if (string.Compare(directiveName, "CoolDirective", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    string fileName;

                    if (!arguments.TryGetValue("FileName", out fileName))
                    {
                        throw new DirectiveProcessorException("Required argument 'FileName' not specified.");
                    }

                    if (string.IsNullOrEmpty(fileName))
                    {
                        throw new DirectiveProcessorException("Argument 'FileName' is null or empty.");
                    }

                    //Now we add code to the generated transformation class.
                    //This directive supports either Visual Basic or C#, so we must use the
                    //System.CodeDom to create the code.
                    //If a directive supports only one language, you can hard code the code.
                    //--------------------------------------------------------------------------

                    CodeMemberField documentField = new CodeMemberField();

                    documentField.Name = "document" + directiveCount + "Value";
                    documentField.Type = new CodeTypeReference(typeof(XmlDocument));
                    documentField.Attributes = MemberAttributes.Private;

                    CodeMemberProperty documentProperty = new CodeMemberProperty();

                    documentProperty.Name = "Document" + directiveCount;
                    documentProperty.Type = new CodeTypeReference(typeof(XmlDocument));
                    documentProperty.Attributes = MemberAttributes.Public;
                    documentProperty.HasSet = false;
                    documentProperty.HasGet = true;

                    CodeExpression fieldName = new CodeFieldReferenceExpression(new CodeThisReferenceExpression(), documentField.Name);
                    CodeExpression booleanTest = new CodeBinaryOperatorExpression(fieldName, CodeBinaryOperatorType.IdentityEquality, new CodePrimitiveExpression(null));
                    CodeExpression rightSide = new CodeMethodInvokeExpression(new CodeTypeReferenceExpression("XmlReaderHelper"), "ReadXml", new CodePrimitiveExpression(fileName));
                    CodeStatement[] thenSteps = new CodeStatement[] { new CodeAssignStatement(fieldName, rightSide) };

                    CodeConditionStatement ifThen = new CodeConditionStatement(booleanTest, thenSteps);
                    documentProperty.GetStatements.Add(ifThen);

                    CodeStatement s = new CodeMethodReturnStatement(fieldName);
                    documentProperty.GetStatements.Add(s);

                    CodeGeneratorOptions options = new CodeGeneratorOptions();
                    options.BlankLinesBetweenMembers = true;
                    options.IndentString = "    ";
                    options.VerbatimOrder = true;
                    options.BracingStyle = "C";

                    using (StringWriter writer = new StringWriter(codeBuffer, CultureInfo.InvariantCulture))
                    {
                        codeDomProvider.GenerateCodeFromMember(documentField, writer, options);
                        codeDomProvider.GenerateCodeFromMember(documentProperty, writer, options);
                    }

                }//end CoolDirective

                //One directive processor can contain many directives.
                //If you want to support more directives, the code goes here...
                //-----------------------------------------------------------------
                if (string.Compare(directiveName, "supercooldirective", StringComparison.OrdinalIgnoreCase) == 0)
                {
                    //code for SuperCoolDirective goes here...
                }//end SuperCoolDirective

                //Track how many times the processor has been called.
                //-----------------------------------------------------------------
                directiveCount++;

            }//end ProcessDirective

            public override void FinishProcessingRun()
            {
                this.codeDomProvider = null;

                //important: do not do this:
                //the get methods below are called after this method
                //and the get methods can access this field
                //-----------------------------------------------------------------
                //this.codeBuffer = null;
            }

            public override string GetPreInitializationCodeForProcessingRun()
            {
                //Use this method to add code to the start of the
                //Initialize() method of the generated transformation class.
                //We do not need any pre-initialization, so we will just return "".
                //-----------------------------------------------------------------
                //GetPreInitializationCodeForProcessingRun runs before the
                //Initialize() method of the base class.
                //-----------------------------------------------------------------
                return String.Empty;
            }

            public override string GetPostInitializationCodeForProcessingRun()
            {
                //Use this method to add code to the end of the
                //Initialize() method of the generated transformation class.
                //We do not need any post-initialization, so we will just return "".
                //------------------------------------------------------------------
                //GetPostInitializationCodeForProcessingRun runs after the
                //Initialize() method of the base class.
                //-----------------------------------------------------------------
                return String.Empty;
            }

            public override string GetClassCodeForProcessingRun()
            {
                //Return the code to add to the generated transformation class.
                //-----------------------------------------------------------------
                return codeBuffer.ToString();
            }

            public override string[] GetReferencesForProcessingRun()
            {
                //This returns the references that we want to use when
                //compiling the generated transformation class.
                //-----------------------------------------------------------------
                //We need a reference to this assembly to be able to call
                //XmlReaderHelper.ReadXml from the generated transformation class.
                //-----------------------------------------------------------------
                return new string[]
                {
                    "System.Xml",
                    this.GetType().Assembly.Location
                };
            }

            public override string[] GetImportsForProcessingRun()
            {
                //This returns the imports or using statements that we want to
                //add to the generated transformation class.
                //-----------------------------------------------------------------
                //We need CustomDP to be able to call XmlReaderHelper.ReadXml
                //from the generated transformation class.
                //-----------------------------------------------------------------
                return new string[]
                {
                    "System.Xml",
                    "CustomDP"
                };
            }
        }//end class CustomDirectiveProcessor

        //-------------------------------------------------------------------------
        // the code that we are adding to the generated transformation class
        // will call this method
        //-------------------------------------------------------------------------
        public static class XmlReaderHelper
        {
            public static XmlDocument ReadXml(string fileName)
            {
                XmlDocument d = new XmlDocument();

                using (XmlTextReader reader = new XmlTextReader(fileName))
                {
                    try
                    {
                        d.Load(reader);
                    }
                    catch (System.Xml.XmlException e)
                    {
                        throw new DirectiveProcessorException("Unable to read the XML file.", e);
                    }
                }
                return d;
            }
        }//end class XmlReaderHelper
    }//end namespace CustomDP
    ```

    ```vb
    Imports System
    Imports System.CodeDom
    Imports System.CodeDom.Compiler
    Imports System.Collections.Generic
    Imports System.Globalization
    Imports System.IO
    Imports System.Text
    Imports System.Xml
    Imports System.Xml.Serialization
    Imports Microsoft.VisualStudio.TextTemplating

    Namespace CustomDP

        Public Class CustomDirectiveProcessor
        Inherits DirectiveProcessor

            'this buffer stores the code that is added to the
            'generated transformation class after all the processing is done
            '---------------------------------------------------------------
            Private codeBuffer As StringBuilder

            'Using a Code Dom Provider creates code for the
            'generated transformation class in either Visual Basic or C#.
            'If you want your directive processor to support only one language, you
            'can hard code the code you add to the generated transformation class.
            'In that case, you do not need this field.
            '--------------------------------------------------------------------------
            Private codeDomProvider As CodeDomProvider

            'this stores the full contents of the text template that is being processed
            '--------------------------------------------------------------------------
            Private templateContents As String

            'These are the errors that occur during processing. The engine passes
            'the errors to the host, and the host can decide how to display them,
            'for example the host can display the errors in the UI
            'or write them to a file.
            '---------------------------------------------------------------------
            Private errorsValue As CompilerErrorCollection
            Public Shadows ReadOnly Property Errors() As CompilerErrorCollection
                Get
                    Return errorsValue
                End Get
            End Property

            'Each time this directive processor is called, it creates a new property.
            'We count how many times we are called, and append "n" to each new
            'property name. The property names are therefore unique.
            '--------------------------------------------------------------------------
            Private directiveCount As Integer = 0

            Public Overrides Sub Initialize(ByVal host As ITextTemplatingEngineHost)

                'we do not need to do any initialization work
            End Sub

            Public Overrides Sub StartProcessingRun(ByVal languageProvider As CodeDomProvider, ByVal templateContents As String, ByVal errors As CompilerErrorCollection)

                'the engine has passed us the language of the text template
                'we will use that language to generate code later
                '----------------------------------------------------------
                Me.codeDomProvider = languageProvider
                Me.templateContents = templateContents
                Me.errorsValue = errors

                Me.codeBuffer = New StringBuilder()
            End Sub

            'Before calling the ProcessDirective method for a directive, the
            'engine calls this function to see whether the directive is supported.
            'Notice that one directive processor might support many directives.
            '---------------------------------------------------------------------
            Public Overrides Function IsDirectiveSupported(ByVal directiveName As String) As Boolean

                If String.Compare(directiveName, "CoolDirective", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Return True
                End If

                If String.Compare(directiveName, "SuperCoolDirective", StringComparison.OrdinalIgnoreCase) = 0 Then
                    Return True
                End If

                Return False
            End Function

            Public Overrides Sub ProcessDirective(ByVal directiveName As String, ByVal arguments As IDictionary(Of String, String))

                If String.Compare(directiveName, "CoolDirective", StringComparison.OrdinalIgnoreCase) = 0 Then

                    Dim fileName As String

                    If Not (arguments.TryGetValue("FileName", fileName)) Then
                        Throw New DirectiveProcessorException("Required argument 'FileName' not specified.")
                    End If

                    If String.IsNullOrEmpty(fileName) Then
                        Throw New DirectiveProcessorException("Argument 'FileName' is null or empty.")
                    End If

                    'Now we add code to the generated transformation class.
                    'This directive supports either Visual Basic or C#, so we must use the
                    'System.CodeDom to create the code.
                    'If a directive supports only one language, you can hard code the code.
                    '--------------------------------------------------------------------------

                    Dim documentField As CodeMemberField = New CodeMemberField()

                    documentField.Name = "document" & directiveCount & "Value"
                    documentField.Type = New CodeTypeReference(GetType(XmlDocument))
                    documentField.Attributes = MemberAttributes.Private

                    Dim documentProperty As CodeMemberProperty = New CodeMemberProperty()

                    documentProperty.Name = "Document" & directiveCount
                    documentProperty.Type = New CodeTypeReference(GetType(XmlDocument))
                    documentProperty.Attributes = MemberAttributes.Public
                    documentProperty.HasSet = False
                    documentProperty.HasGet = True

                    Dim fieldName As CodeExpression = New CodeFieldReferenceExpression(New CodeThisReferenceExpression(), documentField.Name)
                    Dim booleanTest As CodeExpression = New CodeBinaryOperatorExpression(fieldName, CodeBinaryOperatorType.IdentityEquality, New CodePrimitiveExpression(Nothing))
                    Dim rightSide As CodeExpression = New CodeMethodInvokeExpression(New CodeTypeReferenceExpression("XmlReaderHelper"), "ReadXml", New CodePrimitiveExpression(fileName))
                    Dim thenSteps As CodeStatement() = New CodeStatement() {New CodeAssignStatement(fieldName, rightSide)}

                    Dim ifThen As CodeConditionStatement = New CodeConditionStatement(booleanTest, thenSteps)
                    documentProperty.GetStatements.Add(ifThen)

                    Dim s As CodeStatement = New CodeMethodReturnStatement(fieldName)
                    documentProperty.GetStatements.Add(s)

                    Dim options As CodeGeneratorOptions = New CodeGeneratorOptions()
                    options.BlankLinesBetweenMembers = True
                    options.IndentString = "    "
                    options.VerbatimOrder = True
                    options.BracingStyle = "VB"

                    Using writer As StringWriter = New StringWriter(codeBuffer, CultureInfo.InvariantCulture)

                        codeDomProvider.GenerateCodeFromMember(documentField, writer, options)
                        codeDomProvider.GenerateCodeFromMember(documentProperty, writer, options)
                    End Using

                End If  'CoolDirective

                'One directive processor can contain many directives.
                'If you want to support more directives, the code goes here...
                '-----------------------------------------------------------------
                If String.Compare(directiveName, "supercooldirective", StringComparison.OrdinalIgnoreCase) = 0 Then

                    'code for SuperCoolDirective goes here
                End If 'SuperCoolDirective

                'Track how many times the processor has been called.
                '-----------------------------------------------------------------
                directiveCount += 1
            End Sub 'ProcessDirective

            Public Overrides Sub FinishProcessingRun()

                Me.codeDomProvider = Nothing

                'important: do not do this:
                'the get methods below are called after this method
                'and the get methods can access this field
                '-----------------------------------------------------------------
                'Me.codeBuffer = Nothing
            End Sub

            Public Overrides Function GetPreInitializationCodeForProcessingRun() As String

                'Use this method to add code to the start of the
                'Initialize() method of the generated transformation class.
                'We do not need any pre-initialization, so we will just return "".
                '-----------------------------------------------------------------
                'GetPreInitializationCodeForProcessingRun runs before the
                'Initialize() method of the base class.
                '-----------------------------------------------------------------
                Return String.Empty
            End Function

            Public Overrides Function GetPostInitializationCodeForProcessingRun() As String

                'Use this method to add code to the end of the
                'Initialize() method of the generated transformation class.
                'We do not need any post-initialization, so we will just return "".
                '------------------------------------------------------------------
                'GetPostInitializationCodeForProcessingRun runs after the
                'Initialize() method of the base class.
                '-----------------------------------------------------------------
                Return String.Empty
            End Function

            Public Overrides Function GetClassCodeForProcessingRun() As String

                'Return the code to add to the generated transformation class.
                '-----------------------------------------------------------------
                Return codeBuffer.ToString()
            End Function

            Public Overrides Function GetReferencesForProcessingRun() As String()

                'This returns the references that we want to use when
                'compiling the generated transformation class.
                '-----------------------------------------------------------------
                'We need a reference to this assembly to be able to call
                'XmlReaderHelper.ReadXml from the generated transformation class.
                '-----------------------------------------------------------------
                Return New String() {"System.Xml", Me.GetType().Assembly.Location}
            End Function

            Public Overrides Function GetImportsForProcessingRun() As String()

                'This returns the imports or using statements that we want to
                'add to the generated transformation class.
                '-----------------------------------------------------------------
                'We need CustomDP to be able to call XmlReaderHelper.ReadXml
                'from the generated transformation class.
                '-----------------------------------------------------------------
                Return New String() {"System.Xml", "CustomDP"}
            End Function
        End Class 'CustomDirectiveProcessor

        '--------------------------------------------------------------------------
        ' the code that we are adding to the generated transformation class
        ' will call this method
        '--------------------------------------------------------------------------
        Public Class XmlReaderHelper

            Public Shared Function ReadXml(ByVal fileName As String) As XmlDocument

                Dim d As XmlDocument = New XmlDocument()

                Using reader As XmlTextReader = New XmlTextReader(fileName)

                    Try
                        d.Load(reader)

                    Catch e As System.Xml.XmlException

                        Throw New DirectiveProcessorException("Unable to read the XML file.", e)
                    End Try
                End Using

                Return d
            End Function
        End Class 'XmlReaderHelper

    End Namespace
    ```

4. For [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] only, open the **Project** menu, and click **CustomDP Properties**. On the **Application** tab, in **Root namespace**, delete the default value, `CustomDP`.

5. On the **File** menu, click **Save All**.

6. On the **Build** menu, click **Build Solution**.

### Build the Project
 Build the project. On the **Build** menu, click **Build Solution**.

## Registering the Directive Processor
 Before you can call a directive from a text template in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you must add a registry key for the directive processor.

> [!NOTE]
> If you want to install the directive processor on more than one computer, it is better to define a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension (VSIX) that includes a .pkgdef file along with your assembly. For more information, see [Deploying a Custom Directive Processor](../modeling/deploying-a-custom-directive-processor.md).

 Keys for directive processors exist in the registry in the following location:

```
HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\*.0\TextTemplating\DirectiveProcessors
```

 For 64-bit systems, the registry location is:

```
HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\VisualStudio\*.0\TextTemplating\DirectiveProcessors
```

 In this section, you add a key for your custom directive processor to the registry in the same location.

> [!CAUTION]
> Incorrectly editing the registry can severely damage your system. Before you make changes to the registry, back up any valuable data that is on the computer.

#### To add a registry key for the directive processor

1. Run the `regedit` command by using the Start menu or the command line.

2. Browse to the location **HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\\\*.0\TextTemplating\DirectiveProcessors**, and click the node.

    On 64-bit systems, use **HKEY_LOCAL_MACHINE\SOFTWARE\Wow6432Node\Microsoft\VisualStudio\\\*.0\TextTemplating\DirectiveProcessors**

3. Add a new key named CustomDirectiveProcessor.

   > [!NOTE]
   > This is the name that you will use in the Processor field of your custom directives. This name does not need to match the name of the directive, the name of the directive processor class, or the directive processor namespace.

4. Add a new string value named Class that has a value CustomDP.CustomDirectiveProcessor for the name of the new string.

5. Add a new string value named CodeBase that has a value equal to the path of the CustomDP.dll that you created earlier in this walkthrough.

    For example, the path might look like `C:\UserFiles\CustomDP\bin\Debug\CustomDP.dll`.

    Your registry key should have the following values:

   |   Name    |  Type  |                                   Data                                   |
   |-----------|--------|--------------------------------------------------------------------------|
   | (Default) | REG_SZ |                             (value not set)                              |
   |   Class   | REG_SZ |                    CustomDP.CustomDirectiveProcessor                     |
   | CodeBase  | REG_SZ | <strong>\<Path to Your Solution></strong>CustomDP\bin\Debug\CustomDP.dll |

    If you have put the assembly in the GAC, the values should look like the following:

   |   Name    |  Type  |               Data                |
   |-----------|--------|-----------------------------------|
   | (Default) | REG_SZ |          (value not set)          |
   |   Class   | REG_SZ | CustomDP.CustomDirectiveProcessor |
   | Assembly  | REG_SZ |           CustomDP.dll            |

6. Restart Visual Studio.

## Testing the Directive Processor
 To test the directive processor, you need to write a text template that calls it.

 In this example, the text template calls the directive and passes in the name of an XML file that contains documentation for a class file. For more information, see [XML Documentation Comments](https://msdn.microsoft.com/library/803b7f7b-7428-4725-b5db-9a6cff273199).

 The text template then uses the <xref:System.Xml.XmlDocument> property that the directive creates to navigate the XML and print the documentation comments.

#### To create an XML file for use in testing the directive processor

1. Create a text file named `DocFile.xml` by using any text editor (for example, Notepad).

    > [!NOTE]
    > You can create this file in any location (for example, C:\Test\DocFile.xml).

2. Add the following to the text file:

    ```
    <?xml version="1.0"?>
    <doc>
        <assembly>
            <name>xmlsample</name>
        </assembly>
        <members>
            <member name="T:SomeClass">
                <summary>Class level summary documentation goes here.</summary>
                <remarks>Longer comments can be associated with a type or member through the remarks tag</remarks>
            </member>
            <member name="F:SomeClass.m_Name">
                <summary>Store for the name property</summary>
            </member>
            <member name="M:SomeClass.#ctor">
                <summary>The class constructor.</summary>
            </member>
            <member name="M:SomeClass.SomeMethod(System.String)">
                <summary>Description for SomeMethod.</summary>
                <param name="s">Parameter description for s goes here</param>
                <seealso cref="T:System.String">You can use the cref attribute on any tag to reference a type or member and the compiler will check that the reference exists.</seealso>
            </member>
            <member name="M:SomeClass.SomeOtherMethod">
                <summary>Some other method.</summary>
                <returns>Return results are described through the returns tag.</returns>
                <seealso cref="M:SomeClass.SomeMethod(System.String)">Notice the use of the cref attribute to reference a specific method</seealso>
            </member>
            <member name="M:SomeClass.Main(System.String[])">
                <summary>The entry point for the application.</summary>
                <param name="args">A list of command line arguments</param>
            </member>
            <member name="P:SomeClass.Name">
                <summary>Name property</summary>
                <value>A value tag is used to describe the property value</value>
            </member>
        </members>
    </doc>
    ```

3. Save and close the file.

#### To create a text template to test the directive processor

1. In Visual Studio, create a C# or Visual Basic class library project named TemplateTest.

2. Add a new text template file named TestDP.tt.

3. Make sure that the **Custom Tool** property of TestDP.tt is set to `TextTemplatingFileGenerator`.

4. Change the content of  TestDP.tt to the following text.

    > [!NOTE]
    > Make sure to replace the string <`YOUR PATH>` with the path to the DocFile.xml file.

     The language of the text template does not have to match the language of the directive processor.

    ```csharp
    <#@ assembly name="System.Xml" #>
    <#@ template debug="true" #>
    <#@ output extension=".txt" #>

    <#  //This will call the custom directive processor. #>
    <#@ CoolDirective Processor="CustomDirectiveProcessor" FileName="<YOUR PATH>\DocFile.xml" #>

    <#  //Uncomment this line if you want to see the generated transformation class. #>
    <#  //System.Diagnostics.Debugger.Break(); #>

    <#  //This will use the results of the directive processor. #>
    <#  //The directive processor has read the XML and stored it in Document0. #>
    <#
        XmlNode node = Document0.DocumentElement.SelectSingleNode("members");

        foreach (XmlNode member in node.ChildNodes)
        {
            XmlNode name = member.Attributes.GetNamedItem("name");
            WriteLine("{0,7}:  {1}", "Name", name.Value);

            foreach (XmlNode comment in member.ChildNodes)
            {
                WriteLine("{0,7}:  {1}", comment.Name, comment.InnerText);
            }
            WriteLine("");
        }
    #>

    <#  //You can call the directive processor again and pass it a different file. #>
    <# //@ CoolDirective Processor="CustomDirectiveProcessor" FileName="<YOUR PATH>\<Your Second File>" #>

    <#  //To use the results of the second directive call, use Document1. #>
    <#
        //XmlNode node2 = Document1.DocumentElement.SelectSingleNode("members");

        //...
    #>
    ```

    ```vb
    <#@ assembly name="System.Xml" #>
    <#@ template debug="true" language="vb" #>
    <#@ output extension=".txt" #>

    <#  'This will call the custom directive processor. #>
    <#@ CoolDirective Processor="CustomDirectiveProcessor" FileName="<YOUR PATH>\DocFile.xml" #>

    <#  'Uncomment this line if you want to see the generated transformation class. #>
    <#  'System.Diagnostics.Debugger.Break() #>

    <#  'This will use the results of the directive processor. #>
    <#  'The directive processor has read the XML and stored it in Document0. #>
    <#
        Dim node as XmlNode = Document0.DocumentElement.SelectSingleNode("members")

        Dim member As XmlNode
        For Each member In node.ChildNodes

            Dim name As XmlNode = member.Attributes.GetNamedItem("name")
            WriteLine("{0,7}:  {1}", "Name", name.Value)

            Dim comment As XmlNode
            For Each comment In member.ChildNodes
                WriteLine("{0,7}:  {1}", comment.Name, comment.InnerText)
            Next

            WriteLine("")
        Next
    #>

    <#  'You can call the directive processor again and pass it a different file. #>
    <# '@ CoolDirective Processor="CustomDirectiveProcessor" FileName="<YOUR PATH>\DocFileTwo.xml" #>

    <#  'To use the results of the second directive call, use Document1. #>
    <#
        'node = Document1.DocumentElement.SelectSingleNode("members")

        '...
    #>
    ```

    > [!NOTE]
    > In this example, the value of the `Processor` parameter is `CustomDirectiveProcessor`. The value of the `Processor` parameter must match the name of the processor's registry key.

5. On the **File** menu, click **Save All**.

#### To test the directive processor

1. In **Solution Explorer**, right-click TestDP.tt and then click **Run Custom Tool**.

     For [!INCLUDE[vbprvb](../includes/vbprvb-md.md)] users, TestDP.txt might not appear in **Solution Explorer** by default. To display all files assigned to the project, open the **Project** menu and click **Show All Files**.

2. In **Solution Explorer**, expand the TestDP.txt node, and then double-click TestDP.txt to open it in the editor.

     The generated text output appears. The output should look like the following:

    ```
       Name:  T:SomeClass
    summary:  Class level summary documentation goes here.
    remarks:  Longer comments can be associated with a type or member through the remarks tag

       Name:  F:SomeClass.m_Name
    summary:  Store for the name property

       Name:  M:SomeClass.#ctor
    summary:  The class constructor.

       Name:  M:SomeClass.SomeMethod(System.String)
    summary:  Description for SomeMethod.
      param:  Parameter description for s goes here
    seealso:  You can use the cref attribute on any tag to reference a type or member and the compiler will check that the reference exists.

       Name:  M:SomeClass.SomeOtherMethod
    summary:  Some other method.
    returns:  Return results are described through the returns tag.
    seealso:  Notice the use of the cref attribute to reference a specific method

       Name:  M:SomeClass.Main(System.String[])
    summary:  The entry point for the application.
      param:  A list of command line arguments

       Name:  P:SomeClass.Name
    summary:  Name property
      value:  A value tag is used to describe the property value
    ```

## Adding HTML to Generated Text
 After you test your custom directive processor, you might want to add some HTML to your generated text.

#### To add HTML to the generated text

1. Replace the code in TestDP.tt with the following. The HTML is highlighted. Make sure to replace the string `YOUR PATH` with the path to the DocFile.xml file.

    > [!NOTE]
    > Additional open \<# and close #> tags separate the statement code from the HTML tags.

    ```csharp
    <#@ assembly name="System.Xml" #>
    <#@ template debug="true" #>
    <#@ output extension=".htm" #>

    <#  //this will call the custom directive processor #>
    <#@ CoolDirective Processor="CustomDirectiveProcessor" FileName="<YOUR PATH>\DocFile.xml" #>

    <#  //uncomment this line if you want to see the generated transformation class #>
    <#  //System.Diagnostics.Debugger.Break(); #>

    <html><body>

    <#  //this will use the results of the directive processor #>
    <#  //the directive processor has read the XML and stored it in Document0#>
    <#
        XmlNode node = Document0.DocumentElement.SelectSingleNode("members");

        foreach (XmlNode member in node.ChildNodes)
        {
    #>
    <h3>
    <#
            XmlNode name = member.Attributes.GetNamedItem("name");
            WriteLine("{0,7}:  {1}", "Name", name.Value);
    #>
    </h3>
    <#
            foreach (XmlNode comment in member.ChildNodes)
            {
                WriteLine("{0,7}:  {1}", comment.Name, comment.InnerText);
    #>
    <br/>
    <#
            }
        }
    #>
    </body></html>
    ```

    ```vb
    <#@ assembly name="System.Xml" #>
    <#@ template debug="true" language="vb" #>
    <#@ output extension=".htm" #>

    <#  'this will call the custom directive processor #>
    <#@ CoolDirective Processor="CustomDirectiveProcessor" FileName="<YOUR PATH>\DocFile.xml" #>

    <#  'uncomment this line if you want to see the generated transformation class #>
    <#  'System.Diagnostics.Debugger.Break() #>

    <html><body>

    <#  'this will use the results of the directive processor #>
    <#  'the directive processor has read the XML and stored it in Document0#>
    <#
        Dim node as XmlNode = Document0.DocumentElement.SelectSingleNode("members")

        Dim member As XmlNode
        For Each member In node.ChildNodes
    #>
    <h3>
    <#
            Dim name As XmlNode = member.Attributes.GetNamedItem("name")
            WriteLine("{0,7}:  {1}", "Name", name.Value)
    #>
    </h3>
    <#
            Dim comment As XmlNode
            For Each comment In member.ChildNodes
                WriteLine("{0,7}:  {1}", comment.Name, comment.InnerText)
    #>
    <br/>
    <#
            Next
        Next
    #>
    </body></html>
    ```

2. On the **File** menu, click **Save TestDP.txt**.

3. To view the output in a browser, in **Solution Explorer**, right-click TestDP.htm, and click **View In Browser**.

     Your output should be the same as the original text except it should have the HTML format applied. Each item name should appear in bold.
