---
title: "Walkthrough: Creating a Code Snippet | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "code snippets, creating"
  - "code snippets, shortcut"
  - "code snippets, template"
  - "code snippets, replacements"
  - "code snippets, references"
  - "code snippets, imports"
ms.assetid: 0dcaae11-39cf-4463-9c90-2494321251c2
caps.latest.revision: 25
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: Creating a Code Snippet
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can create a code snippet with only a few steps. All you need to do is create an XML file, fill in the appropriate elements, and add your code to it. You can also add references and replacement parameters to your code. You can add the snippet to your Visual Studio installation by using the Import button on the Code Snippets Manager (**Tools/Code Snippets Manager**).

> [!TIP]
> For information about how to write code snippets more easily, search the CodePlex website for community tools such as [Snippet Editor](https://go.microsoft.com/fwlink/?LinkId=251033).

## Snippet Template
 The following is the basic snippet template:

```
<?xml version="1.0" encoding="utf-8"?>
<CodeSnippets
    xmlns="http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet">
    <CodeSnippet Format="1.0.0">
        <Header>
            <Title></Title>
        </Header>
        <Snippet>
            <Code Language="">
                <![CDATA[]]>
            </Code>
        </Snippet>
    </CodeSnippet>
</CodeSnippets>

```

### To Create a Code Snippet

1. Create a new XML file in Visual Studio and add the template shown above.

2. Fill in the title of the snippet, e.g. "Hello World VB", in the Title element.

3. Fill in the language of the snippet in the Languages attribute of the Code element. For this example, use "VB".

4. Add some code in the CDATA section inside the Code element, for example:

    ```
    <Code Language="VB">
        <![CDATA[Console.WriteLine("Hello, World!")]]>
    </Code>

    ```

5. Save the snippet as VBCodeSnippet.snippet.

### To Add a Code Snippet to Visual Studio

1. You can add your own snippets to your Visual Studio installation by using the Code Snippets Manager. Open the Code Snippets Manager (**Tools/Code Snippets Manager**).

2. Click the **Import** button.

3. Go to the location where you saved the code snippet in the previous procedure, select it, and click **Open**.

4. The **Import Code Snippet** dialog opens, asking you to choose where to add the snippet from the choices in the right pane. One of the choices should be **My Code Snippets**. Select it and click **Finish**, then **OK**.

5. The snippet is copied to the following location:

     `%USERPROFILE%\Documents\Visual Studio 2013\Code Snippets\Visual Basic\My Code Snippets`

6. Test your snippet by opening a Visual Basic project and opening a code file. In the file click **Insert Snippet** on the context menu, then **My Code Snippets**. You should see a snippet named **My Visual Basic Code Snippet**. Double-click it.

7. You should see `Console.WriteLine("Hello, World!")` inserted in the code.

### Adding Description and Shortcut Fields

1. Description fields give more information about your code snippet when viewed in the Code Snippets Manager. The shortcut is a tag that users can type in order to insert your snippet. Edit the snippet you have added by opening the file `%USERPROFILE%\Documents\Visual Studio 2013\Code Snippets\Visual Basic\My Code Snippet\VBCodeSnippet.snippet`.

2. Add Author and Description elements to the Header element, and fill them in.

3. The Header element should look something like this:

    ```
    <Header>
        <Title>Hello World VB</Title>
        <Author>Myself</Author>
        <Description>Says Hello to the world.</Description>
    </Header>

    ```

4. Open the Code Snippets Manager and select your code snippet. In the right pane you should see that the Description and Author fields are now populated.

5. To add a shortcut, add a Shortcut element alongside the Author and Description element:

    ```
    <Header>
        <Title>Hello World VB</Title>
        <Author>Myself</Author>
        <Description>Says Hello to the world.</Description>
        <Shortcut>hello</Shortcut>
    </Header>

    ```

6. Save the snippet file again.

7. To test the shortcut, open a Visual Basic project and open a code file. Type `hello` in the file and press TAB. The snippet code should be inserted.

### To Add References and Imports

1. With Visual Basic snippets you can add a reference to a project by using the References element, and add an Imports declaration by using the Imports element. (Snippets in other languages do not have this feature.) For example, if you change `Console.WriteLine` in the code example to `MessageBox.Show`, you may need to add the System.Windows.Forms.dll assembly to the project.

2. Open your snippet.

3. Add the References element under the Snippet element:

    ```
    <References>
        <Reference>
            <Assembly>System.Windows.Forms.dll</Assembly>
        </Reference>
    </References>

    ```

4. Add the Imports element under the Snippet element:

    ```
    <Imports>
        <Import>
           <Namespace>System.Windows.Forms</Namespace>
        </Import>
    </Imports>

    ```

5. Change the CDATA section to the following:

    ```
    <![CDATA[MessageBox.Show("Hello, World!")]]>
    ```

6. Save the snippet.

7. Open a Visual Basic project and add the snippet.

8. You will see an Imports statement at the top of the code file:

    ```
    Imports System.Windows.Forms

    ```

9. Look at the project's properties. The References tab includes a reference to System.Windows.Forms.dll.

### Adding Replacements

1. You may want parts of your code snippets to be replaced by the user, for example if you add a variable and want the user to replace the variable with one in the current project. You can provide two types of replacements: literals and objects. Literals are strings of some type (string literals, variable names, or string representations of numeric values). Objects are instances of some type other than a string. In this procedure you will declare a literal replacement and an object replacement, and change the code to reference these replacements.

2. Open your snippet.

3. This example uses a SQL connection string, so you need to change the Imports and References elements to add the appropriate references:

    ```
    <References>
        <Reference>
            <Assembly>System.Data.dll</Assembly>
        </Reference>
        <Reference>
            <Assembly>System.Xml.dll</Assembly>
        </Reference>
    </References>
    <Imports>
        <Import>
            <Namespace>System.Data</Namespace>
        </Import>
        <Import>
            <Namespace>System.Data.SqlClient</Namespace>
        </Import>
    </Imports>

    ```

4. To declare a literal replacement for the SQL connection string, add a Declarations element under the Snippet element, and in it add a Literal element with subelements for the ID, the tooltip, and the default value for the replacement:

    ```
    <Declarations>
        <Literal>
            <ID>SqlConnString</ID>
            <ToolTip>Replace with a SQL connection string.</ToolTip>
            <Default>"SQL connection string"</Default>
        </Literal>
    </Declarations>

    ```

5. To declare an object replacement for the SQL connection, add an Object element inside the Declarations element, and add sub-elements for the ID, the type of the object, the tooltip, and the default value. The resulting Declarations element should look like this:

    ```
    <Declarations>
        <Literal>
            <ID>SqlConnString</ID>
            <ToolTip>Replace with a SQL connection string.</ToolTip>
            <Default>"SQL connection string"</Default>
        </Literal>
        <Object>
            <ID>SqlConnection</ID>
            <Type>System.Data.SqlClient.SqlConnection</Type>
            <ToolTip>Replace with a connection object in your application.</ToolTip>
            <Default>dcConnection</Default>
        </Object>
    </Declarations>
    ```

6. In the code section, you reference the replacements with surrounding $ signs, for example `$replacement$`:

    ```
    <Code Language="VB" Kind="method body">
        <![CDATA[Dim daCustomers As SqlDataAdapter
            Dim selectCommand As SqlCommand

            daCustomers = New SqlClient.SqlDataAdapter()
            selectCommand = new SqlClient.SqlCommand($SqlConnString$)
            daCustomers.SelectCommand = selectCommand
            daCustomers.SelectCommand.Connection = $SqlConnection$]]>
    </Code>
    ```

7. Save the snippet.

8. Open a Visual Basic project and add the snippet.

9. The code should look like the following, where the replacements `SQL connection string` and `dcConnection` are highlighted in light orange. Press TAB to navigate from one to the other.

    ```
    Dim daCustomers As SqlDataAdapter
    Dim selectCommand As SqlCommand

    daCustomers = New SqlClient.SqlDataAdapter()
    selectCommand = New SqlClient.SqlCommand("SQL connection string")
    daCustomers.SelectCommand = selectCommand
    daCustomers.SelectCommand.Connection = dcConnection

    ```

## See Also
 [Code Snippets Schema Reference](../ide/code-snippets-schema-reference.md)
