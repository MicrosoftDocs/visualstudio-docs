---
title: Paste JSON or XML as classes
description: Learn how to copy any JSON or XML text from the clipboard and then paste it as .NET classes into C# or Visual Basic code.
ms.date: 04/04/2023
ms.topic: reference
ms.custom: "ide-ref"
author:anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Paste JSON or XML as classes

In Visual Studio, you can copy text from JSON or XML files and then paste the text as classes in your [C#](/dotnet/csharp/) or [Visual Basic](/dotnet/visual-basic/) code. To do so, select **Edit** > **Paste Special** and choose either **Paste JSON As Classes** or **Paste XML As Classes**.

:::image type="content" source="media/paste-json-xml-class-sml.png" alt-text="Screenshot of the Paste Special option from the Edit menu in Visual Studio." lightbox="media/paste-json-xml-class-lrg.png":::

> [!TIP]
> If you don't see the **Paste Special** option on the **Edit** menu, make sure that you have at least one of the following [**workloads**](../../install/modify-visual-studio.md#change-workloads-or-individual-components) installed: **ASP.NET and web development**, **Azure development**, or **.NET desktop development**. Then, make sure that you select the program file for your app. For example, for a C# app, select the **Program.cs** file in [Solution Explorer](../use-solution-explorer.md).

**JSON** (**J**ava**S**cript **O**bject **N**otation) and **XML** (e**X**tensible **M**arkup **L**anguage) are similar in that they're both used to store and transport data. JSON, however, is less verbose and can use arrays.

## Examples

Before you use either the **Paste JSON As Classes** command or the **Paste XML As Classes** command in Visual Studio, create a placeholder for your text. For a [C#](/dotnet/csharp/) app, you can use an empty [namespace](/dotnet/csharp/language-reference/keywords/namespace) declaration to do so, as shown in the following screenshot:

:::image type="content" source="media/paste-class-placeholder.png" alt-text="Screenshot of an empty namespace declaration in Visual Studio that's used as a placeholder to paste in JSON or XML text.":::

Then, paste your JSON or XML text within the braces.

### JSON

Here's an example of JSON text:

```json
{
  "Colors": [
 {
   "numberKey": 1,
   "isPrimary": true,
   "listColors": ["Red", "Blue", "Yellow"]
 },

 {
   "numberKey": 2,
   "isPrimary": false,
   "listColors": ["Purple", "Green", "Orange"]
 } ]
}
```

Here's a screenshot that shows how Visual Studio converts the JSON text to classes:

:::image type="content" source="media/paste-json-example-code.png" alt-text="Screenshot of the JSON example text converted to classes by using the Paste Special feature in Visual Studio.":::

### XML

Here's an example of XML text:

```xml
<root>
 <color>
  <id>01</id>
  <name>red</name>
  <type>primary</type>
 </color>
 <color>
  <id>02</id>
  <name>green</name>
  <type>secondary</type>
 </color>
</root>
```

Here's a code example that shows how Visual Studio converts the XML text to classes:

```csharp
using System;

namespace PasteDemo
{
    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class root
    {

        private rootColor[] colorField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("color")]
        public rootColor[] color
        {
            get
            {
                return this.colorField;
            }
            set
            {
                this.colorField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class rootColor
    {

        private byte idField;

        private string nameField;

        private string typeField;

        /// <remarks/>
        public byte id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
            }
        }
    }
}

```

## See also

- [Features of the code editor](../../ide/writing-code-in-the-code-and-text-editor.md)
- [Productivity guide for Visual Studio](../productivity-features.md)
