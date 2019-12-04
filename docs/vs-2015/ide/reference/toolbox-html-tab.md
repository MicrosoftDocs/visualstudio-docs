---
title: "Toolbox, HTML Tab | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "vs.toolbox.html"
helpviewer_keywords:
  - "Toolbox, HTML tab"
  - "HTML Designer, setting options"
  - "HTML tab in Toolbox"
ms.assetid: 9bfdd3b8-f5ac-4a5f-bdbf-c2b4e97641d8
caps.latest.revision: 18
author: jillre
ms.author: jillfra
manager: jillfra
---
# Toolbox, HTML Tab
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

The **HTML** tab of the Toolbox provides components that are useful on Web pages and Web forms. To view this tab, first open a document for editing in the HTML designer. On the **View** menu, click **Toolbox**, and then click the **HTML** tab of the Toolbox.

 To create an instance of a tool on the **HTML** tab, either double-click the tool to add it to your document at the current insertion point, or select the tool and drag it to the desired position on the editing surface.

## Tasks

- [How to: Manage the Toolbox Window](https://msdn.microsoft.com/a022c3fe-298c-4a59-a48f-b050da90ebc2)

- [How to: Manipulate Toolbox Tabs](https://msdn.microsoft.com/21285050-cadd-455a-b1f5-a2289a89c4db)

## UI Elements
 The following tools are available by default on the HTML tab.

 **Pointer**
 ![ASP.NET Mobile Designer HTMLpage Pointer](../../ide/reference/media/vxpointer.gif "vxPointer")

 This tool is selected by default when any Toolbox tab opens. It cannot be deleted. The pointer enables you to drag objects onto the Design view surface, resize them, and reposition them on the page or form. For more information, see [How to: Manage the Toolbox Window](https://msdn.microsoft.com/a022c3fe-298c-4a59-a48f-b050da90ebc2) and [How to: Manipulate Toolbox Tabs](https://msdn.microsoft.com/21285050-cadd-455a-b1f5-a2289a89c4db).

 **Input (Button)**
 ![HTML web page button](../../ide/reference/media/vxbutton.gif "vxButton")

 Inserts an `input` element of `type="button"`. To change the text that is displayed, edit the `name` property. By default, `id="Button1"` is inserted for the first button, `id="Button2"` for the second, and so on.

 When you drag **Input (Button)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Button1" type="button" value="Button" name="Button1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputButton Server Control Declarative Syntax](https://msdn.microsoft.com/99ccf7fb-7e2a-4ba1-bcd9-981b619a16aa), [NIB: How to: Create Scripts and Edit Event Handlers](https://msdn.microsoft.com/69d71d13-c68b-4ecd-869b-a42edf6d1f6d), [Button Web Server Controls Content Map](https://msdn.microsoft.com/library/66b3ce28-3b93-4f0a-951f-42fb5bb5fddf), <xref:System.Web.UI.HtmlControls.HtmlInputButton>, <xref:System.Web.UI.HtmlControls.HtmlButton>, and <xref:System.Web.UI.WebControls.Button>.

 **Input (Reset)**
 ![HTMLpageResetButton screenshot](../../ide/reference/media/vxreset.gif "vxReset")

 Inserts an `input` element of `type="reset"`. To change the text that is displayed, edit the `name` property. By default, `id="Reset1"` is inserted for the first reset button, `id="Reset2"` for the second, and so on.

 When you drag **Input (Reset)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Reset1" type="reset" value="Reset" name="Reset1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputReset Server Control Declarative Syntax](https://msdn.microsoft.com/cfc1f1fb-d33a-464d-9bb5-204e66174979), <xref:System.Web.UI.HtmlControls.HtmlInputButton>, and <xref:System.Web.UI.WebControls.Button>.

 **Input (Submit)**
 ![HTMLpageToolbarSubmitButton screenshot](../../ide/reference/media/vxsubmit.gif "vxSubmit")

 Inserts an `input` element of `type="submit"`. To change the text that is displayed, edit the `name` property. By default, `id="Submit1"` is inserted for the first submit button, `id="Submit2"` for the second, and so on.

 When you drag **Input (Submit)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Submit1" type="submit" value="Submit" name="Submit1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputSubmit Server Control Declarative Syntax](https://msdn.microsoft.com/eef2a157-f184-4ce9-b256-d1eacc7930f2), <xref:System.Web.UI.HtmlControls.HtmlInputButton>, and <xref:System.Web.UI.WebControls.Button>.

 **Input (Text)**
 ![HTMLpageToolbarTextField screenshot](../../ide/reference/media/vxtextfield.gif "vxTextfield")

 Inserts an `input` element of `type="text"` in your document. To change the default text that is displayed, edit the `value` attribute. By default, `id="Text1"` is inserted for the first text field, `id="Text2"` for the second, and so on.

 When you drag **Input (Text)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Text1" TYPE="text" value="Text Field" name="Text1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputText Server Control Declarative Syntax](https://msdn.microsoft.com/87060d90-a11c-434d-9fc9-b03a8487041e), [TextBox Web Server Control Overview](https://msdn.microsoft.com/library/ab354bc1-f23a-48fc-93d8-d4d7c1b7396f), <xref:System.Web.UI.HtmlControls.HtmlInputText>, and <xref:System.Web.UI.WebControls.TextBox>.

> [!IMPORTANT]
> It is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages](https://msdn.microsoft.com/library/4ad3dacb-89e0-4cee-89ac-40a3f2a85461).

 **Input (File)**
 ![HTML page File Field](../../ide/reference/media/vxfilefield.gif "vxFilefield")

 Inserts an `input` element of `type="file"` in your document. By default, `id="File1"` is inserted for the first file field, `id="File2"` for the second, and so on.

 When you drag **Input (File)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="File1" type="file" name="File1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputFile Server Control Declarative Syntax](https://msdn.microsoft.com/a817b4a0-056f-4c17-a696-b9fdcde43db6), and <xref:System.Web.UI.HtmlControls.HtmlInputFile>.

> [!IMPORTANT]
> It is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages](https://msdn.microsoft.com/library/4ad3dacb-89e0-4cee-89ac-40a3f2a85461).

 **Input (Password)**
 ![Visual Studio Password Field](../../ide/reference/media/vxpassword.gif "vxPassword")

 Inserts an `input` element of `type="password"`. By default, `id="Password1"` is inserted for the first password field, `id="Password2"` for the second, and so on.

 When you drag **Input (Password)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Password1" type="password" name="Password1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputPassword Server Control Declarative Syntax](https://msdn.microsoft.com/df703dd0-1624-4e5a-a547-c97f2f331b9f), [How to: Set a TextBox Web Server Control for Password Entry](https://msdn.microsoft.com/library/5b5069f3-64a1-435a-aee6-da263f4e6310), and [Walkthrough: Validating User Input in a Web Forms Page](https://msdn.microsoft.com/library/7141d6ba-34f3-410b-b5cd-2102a24cb436).

> [!IMPORTANT]
> If your application transmits user names and passwords, you should configure your Web site to use Secure Sockets Layer (SSL) to encrypt the transmission. For more information, see "Securing Connections with SSL" in the [IIS Operations Guide](https://go.microsoft.com/fwlink/?linkid=47856). Additionally, it is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages](https://msdn.microsoft.com/library/4ad3dacb-89e0-4cee-89ac-40a3f2a85461).

 **Input (Check box)**
 ![HTML webpage Toolbox Checkbox Option](../../ide/reference/media/vxcheckbox.gif "vxCheckbox")

 Inserts an `input` element of `type="checkbox"`. To change the text that is displayed, edit the `name` property. By default, `id="Checkbox1"` is inserted for the first check box, `id="Checkbox2"` for the second, and so on.

 When you drag **Input (Check box)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Checkbox1" type="checkbox" name="Checkbox1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputCheckBox Server Control Declarative Syntax](https://msdn.microsoft.com/4a509586-89d8-4ccf-a0b8-b9160ce6e4a6), [CheckBox and CheckBoxList Web Server Controls Overview](https://msdn.microsoft.com/library/3028dfd3-e2c5-451d-9150-d02c8ffb92bf), <xref:System.Web.UI.HtmlControls.HtmlInputCheckBox>, and <xref:System.Web.UI.WebControls.CheckBox>.

 **Input (Radio)**
 ![VisualStudioHTMLpageRadioButton screenshot](../../ide/reference/media/vxradio.gif "vxRadio")

 Inserts an `input` element of `type="radio"`. To change the text that is displayed, edit the `name` property. By default, `id="Radio1"` is inserted for the first radio button, `id="Radio2"` for the second, and so on.

 When you drag **Input (Radio)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Radio1" type="radio" name="Radio1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputRadioButton Server Control Declarative Syntax](https://msdn.microsoft.com/6e60ff63-cc57-46ef-bf96-e829e204ba33), [RadioButton and RadioButtonList Web Server Controls Overview](https://msdn.microsoft.com/library/20eb383c-4b59-432b-bba3-e9d785107747), <xref:System.Web.UI.HtmlControls.HtmlInputRadioButton>, and <xref:System.Web.UI.WebControls.RadioButton>.

 **Input (Hidden)**
 ![HTML page Hidden Item](../../ide/reference/media/vxhidden.gif "vxhidden")

 Inserts an `input` element of `type="hidden"`. By default, `id="Hidden1"` is inserted for the first hidden field, `id="Hidden2"` for the second, and so on.

 When you drag **Input (Hidden)** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<input id="Hidden1" type="hidden" name="Hidden1">
```

 For more information, see [HTML Input Controls](https://msdn.microsoft.com/library/2ba82c6b-dff7-4b73-b1c2-9e76a48a69de), [HtmlInputHidden Server Control Declarative Syntax](https://msdn.microsoft.com/4194e44d-1d74-4bfc-9cc7-743a2e1ea5f9), and <xref:System.Web.UI.HtmlControls.HtmlInputHidden>.

 **Textarea**
 ![HTMLpage Toolbar Text Area](../../ide/reference/media/vxtextarea.gif "vxTextarea")

 Inserts a `textarea` element. You can resize the text area, or use its scroll bars to view text that extends beyond its display area. To change the default text that is displayed, edit the `value` attribute. By default, `id="textarea1"` is inserted the first text area, `id=" textarea 2"` for the second, and so on.

 When you drag **Textarea** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<textarea id=" textarea 1 name=" textarea 1" rows=2 cols=20></textarea>
```

 For more information, see [HtmlTextArea Server Control Declarative Syntax](https://msdn.microsoft.com/5a103ffa-235b-4452-ba2b-a4fb8ba8cb87), <xref:System.Web.UI.HtmlControls.HtmlTextArea>, and <xref:System.Web.UI.WebControls.TextBox>.

> [!IMPORTANT]
> It is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages](https://msdn.microsoft.com/library/4ad3dacb-89e0-4cee-89ac-40a3f2a85461).

 **Table**
 ![HTMLpageToolbarTable screenshot](../../ide/reference/media/vxtable.gif "vxTable")

 Inserts a `table` element.

 When you drag **Table** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<table cellspacing="1" width="75%" border=1> <tr><td></td></tr></table>
```

 For more information, see [HtmlTable Server Control Declarative Syntax](https://msdn.microsoft.com/625b06d8-0f69-4112-a1d4-8ef2a9fbcda9), [Table, TableRow, and TableCell Web Server Control Overview](https://msdn.microsoft.com/library/2fbd0582-cf69-4c8d-9e35-21f35e2cee1a), <xref:System.Web.UI.HtmlControls.HtmlTable>, and <xref:System.Web.UI.WebControls.Table>.

 **Image**
 ![HTML page Image Item](../../ide/reference/media/vximage.gif "vxImage")

 Inserts an `img` element. Edit this element to specify its `src` and its `alt` text.

 When you drag **Image** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<img alt="" src="">
```

 For more information, see [HtmlImage Server Control Declarative Syntax](https://msdn.microsoft.com/528430e8-ced1-47d1-8db2-942e734a61f6), [Image Web Server Control Overview](https://msdn.microsoft.com/library/096a8d8d-58ee-4ee8-ab82-6594a0f3a0a9), <xref:System.Web.UI.HtmlControls.HtmlImage>, <xref:System.Web.UI.HtmlControls.HtmlInputImage>, and <xref:System.Web.UI.WebControls.Image>.

 **Select**
 ![HTML page Toolbox Dropdown](../../ide/reference/media/vxdropdown.gif "vxDropdown")

 Inserts a dropdown `select` element (without a `size` attribute). By default, `id="select1"` is inserted for the first list box, `id="select2"` for the second, and so on.

 When you drag **Select** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<select id="select1" name="select1"><option selected></option></select>
```

 You can create a multi-line `select` element by increasing the value of the size property.

 For more information, see [HtmlSelect Server Control Declarative Syntax](https://msdn.microsoft.com/ee93bdec-b343-441a-a8ff-56ffcafe9ae5), [NIB: How to: Create Scripts and Edit Event Handlers](https://msdn.microsoft.com/69d71d13-c68b-4ecd-869b-a42edf6d1f6d), [DropDownList Web Server Control Overview](https://msdn.microsoft.com/library/517dd1a4-8df3-4c9f-8c89-1549a1aee608), [ListBox Web Server Control Overview](https://msdn.microsoft.com/library/c08ee025-787a-408d-858e-a4a5fdb61d97), <xref:System.Web.UI.HtmlControls.HtmlSelect>, and <xref:System.Web.UI.WebControls.DropDownList>.

 **Horizontal Rule**
 ![HTML page Horizontal Rule Item](../../ide/reference/media/vxhorizontal.gif "vxHorizontal")

 Inserts an `hr` element. To increase the thickness of the line, edit the `size` attribute.

 When you drag **Horizontal Rule** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<hr width="100%" size=1>
```

 For more information, see [HTML Horizontal Rule Control](https://msdn.microsoft.com/library/bf6df0a8-9844-404d-8a9a-3455b0180f2f).

 **Div**
 ![HTML page Label](../../ide/reference/media/vxlabel.gif "vxLabel")

 Inserts a `div` element that includes an `ms_positioning="FlowLayout"` attribute. Except for the width and height, this item is identical to a Flow Layout Panel. To format the text that is contained within the `div` element, add a `class="stylename"` attribute to the opening tag.

 When you drag **Div** onto the Design view surface, HTML markup like the following is inserted into your document:

```
<div ms_positioning="FlowLayout" style="width: 70px; position: relative; height: 15px">Label</div>
```

 For more information, see [HTML Div Control](https://msdn.microsoft.com/library/585fa702-4408-4af1-a92b-68d77ee5e995), [Label Web Server Control Overview](https://msdn.microsoft.com/library/990558d1-4b22-4f28-b100-78a434b3c5ac), and <xref:System.Web.UI.WebControls.Label>.

## See Also
 [Toolbox](../../ide/reference/toolbox.md)
 [Standard Tab, Toolbox](https://msdn.microsoft.com/library/35e9320d-fcbd-474b-8b8f-55705e9a1870)
 [HTML Controls](https://msdn.microsoft.com/library/83bc6f7e-a2b5-4fe9-9a34-eb34aef673be)
