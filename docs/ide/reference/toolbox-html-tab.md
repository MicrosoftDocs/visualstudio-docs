---
title: Toolbox, HTML Tab
description: Learn about the HTML components you'll find in the HTML tab of the Toolbox window.
ms.date: 06/21/2017
ms.topic: reference
f1_keywords:
- vs.toolbox.html
helpviewer_keywords:
- Toolbox, HTML tab
- HTML Designer, setting options
- HTML tab in Toolbox
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
ms.custom:
  - "ide-ref"
  - sfi-image-nochange
---
# Toolbox, HTML tab

The **HTML** tab of the Toolbox provides components that are useful on web pages and web forms. To view this tab, first open a document for editing in the HTML designer. On the **View** menu, click **Toolbox**, and then click the **HTML** tab of the Toolbox.

To create an instance of a tool on the **HTML** tab, either double-click the tool to add it to your document at the current insertion point, or select the tool and drag it to the desired position on the editing surface.

## UI elements

The following tools are available by default on the HTML tab.

**Pointer**

![ASP.NET Mobile Designer HTMLpage Pointer](../../ide/reference/media/vxpointer.gif)

This tool is selected by default when any Toolbox tab opens. It cannot be deleted. The pointer enables you to drag objects onto the Design view surface, resize them, and reposition them on the page or form. For more information, see [Toolbox](../../ide/reference/toolbox.md).

**Input (Button)**

![HTML web page button](../../ide/reference/media/vxbutton.gif)

Inserts an `input` element of `type="button"`. To change the text that is displayed, edit the `name` property. By default, `id="Button1"` is inserted for the first button, `id="Button2"` for the second, and so on.

When you drag **Input (Button)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Button1" type="button" value="Button" name="Button1">
```

**Input (Reset)**

![HTMLpageResetButton screenshot](../../ide/reference/media/vxreset.gif)

Inserts an `input` element of `type="reset"`. To change the text that is displayed, edit the `name` property. By default, `id="Reset1"` is inserted for the first reset button, `id="Reset2"` for the second, and so on.

When you drag **Input (Reset)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Reset1" type="reset" value="Reset" name="Reset1">
```

**Input (Submit)**

![HTMLpageToolbarSubmitButton screenshot](../../ide/reference/media/vxsubmit.gif)

Inserts an `input` element of `type="submit"`. To change the text that is displayed, edit the `name` property. By default, `id="Submit1"` is inserted for the first submit button, `id="Submit2"` for the second, and so on.

When you drag **Input (Submit)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Submit1" type="submit" value="Submit" name="Submit1">
```

**Input (Text)**

![HTMLpageToolbarTextField screenshot](../../ide/reference/media/vxtextfield.gif)

Inserts an `input` element of `type="text"` in your document. To change the default text that is displayed, edit the `value` attribute. By default, `id="Text1"` is inserted for the first text field, `id="Text2"` for the second, and so on.

When you drag **Input (Text)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Text1" TYPE="text" value="Text Field" name="Text1">
```

> [!IMPORTANT]
>It is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages (Razor) Sites](/aspnet/web-pages/overview/ui-layouts-and-themes/validating-user-input-in-aspnet-web-pages-sites).

**Input (File)**

![HTML page File Field](../../ide/reference/media/vxfilefield.gif)

Inserts an `input` element of `type="file"` in your document. By default, `id="File1"` is inserted for the first file field, `id="File2"` for the second, and so on.

When you drag **Input (File)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="File1" type="file" name="File1">
```

> [!IMPORTANT]
> It is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages (Razor) Sites](/aspnet/web-pages/overview/ui-layouts-and-themes/validating-user-input-in-aspnet-web-pages-sites).

**Input (Password)**

![Visual Studio Password Field](../../ide/reference/media/vxpassword.gif)

Inserts an `input` element of `type="password"`. By default, `id="Password1"` is inserted for the first password field, `id="Password2"` for the second, and so on.

When you drag **Input (Password)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Password1" type="password" name="Password1">
```

> [!IMPORTANT]
> If your application transmits user names and passwords, you should configure your website to use Secure Sockets Layer (SSL) to encrypt the transmission. For more information, see [Securing Connections](/previous-versions/tn-archive/bb418917(v=technet.10)). Additionally, it is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages (Razor) Sites](/aspnet/web-pages/overview/ui-layouts-and-themes/validating-user-input-in-aspnet-web-pages-sites).

**Input (Check box)**

![HTML webpage Toolbox Checkbox Option](../../ide/reference/media/vxcheckbox.gif)

Inserts an `input` element of `type="checkbox"`. To change the text that is displayed, edit the `name` property. By default, `id="Checkbox1"` is inserted for the first check box, `id="Checkbox2"` for the second, and so on.

When you drag **Input (Check box)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Checkbox1" type="checkbox" name="Checkbox1">
```

**Input (Radio)**

![VisualStudioHTMLpageRadioButton screenshot](../../ide/reference/media/vxradio.gif)

Inserts an `input` element of `type="radio"`. To change the text that is displayed, edit the `name` property. By default, `id="Radio1"` is inserted for the first radio button, `id="Radio2"` for the second, and so on.

When you drag **Input (Radio)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Radio1" type="radio" name="Radio1">
```

**Input (Hidden)**

![HTML page Hidden Item](../../ide/reference/media/vxhidden.gif)

Inserts an `input` element of `type="hidden"`. By default, `id="Hidden1"` is inserted for the first hidden field, `id="Hidden2"` for the second, and so on.

When you drag **Input (Hidden)** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<input id="Hidden1" type="hidden" name="Hidden1">
```

**Textarea**

![HTMLpage Toolbar Text Area](../../ide/reference/media/vxtextarea.gif)

Inserts a `textarea` element. You can resize the text area, or use its scroll bars to view text that extends beyond its display area. To change the default text that is displayed, edit the `value` attribute. By default, `id="textarea1"` is inserted the first text area, `id=" textarea 2"` for the second, and so on.

When you drag **Textarea** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<textarea id=" textarea 1 name=" textarea 1" rows=2 cols=20></textarea>
```

> [!IMPORTANT]
> It is recommended that you validate all user input. For more information, see [Validating User Input in ASP.NET Web Pages (Razor) Sites](/aspnet/web-pages/overview/ui-layouts-and-themes/validating-user-input-in-aspnet-web-pages-sites).

**Table**

![HTMLpageToolbarTable screenshot](../../ide/reference/media/vxtable.gif)

Inserts a `table` element.

When you drag **Table** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<table cellspacing="1" width="75%" border=1> <tr><td></td></tr></table>
```

**Image**

![HTML page Image Item](../../ide/reference/media/vximage.gif)

Inserts an `img` element. Edit this element to specify its `src` and its `alt` text.

When you drag **Image** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<img alt="" src="">
```

**Select**

![HTML page Toolbox Dropdown](../../ide/reference/media/vxdropdown.gif)

Inserts a dropdown `select` element (without a `size` attribute). By default, `id="select1"` is inserted for the first list box, `id="select2"` for the second, and so on.

When you drag **Select** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<select id="select1" name="select1"><option selected></option></select>
```

You can create a multi-line `select` element by increasing the value of the size property.

**Horizontal Rule**

![HTML page Horizontal Rule Item](../../ide/reference/media/vxhorizontal.gif)

Inserts an `hr` element. To increase the thickness of the line, edit the `size` attribute.

When you drag **Horizontal Rule** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<hr width="100%" size=1>
```

**Div**

![HTML page Label](../../ide/reference/media/vxlabel.gif)

Inserts a `div` element that includes an `ms_positioning="FlowLayout"` attribute. Except for the width and height, this item is identical to a Flow Layout Panel. To format the text that is contained within the `div` element, add a `class="stylename"` attribute to the opening tag.

When you drag **Div** onto the Design view surface, HTML markup like the following is inserted into your document:

```html
<div ms_positioning="FlowLayout" style="width: 70px; position: relative; height: 15px">Label</div>
```

## See also

- [Toolbox](../../ide/reference/toolbox.md)
