---
title: Create a HTTP body editor for a web performance test
description: Learn how to create a custom content editor that enables you to edit the string body content or the binary body content of a web service request.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - Web performance tests, custom HTTP body editor
ms.assetid: a0b2d8ff-3e2a-487e-9172-90047174f336
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# How to: Create a custom HTTP body editor for the Web Performance Test Editor

You can create a custom content editor that enables you to edit the string body content or the binary body content of a web service request, for example, SOAP, REST, asmx, wcf, RIA, and other web service request types.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

You can implement these kinds of editors:

- **String content editor** This is implemented using the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin> interface.

- **Binary content editor** This is implemented using the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin> interface.

These interfaces are contained in the <xref:Microsoft.VisualStudio.TestTools.WebTesting> namespace.

## Create a Windows Control Library project

1. In Visual Studio, create a new **Windows Forms Control Library** project. Name the project **MessageEditors**.

   The project is added to the new solution and a <xref:System.Windows.Forms.UserControl> named *UserControl1.cs* is presented in the Designer.

1. From the **Toolbox**, under the **Common Controls** category, drag a <xref:System.Windows.Forms.RichTextBox> onto the surface of UserControl1.

1. Choose the action tag glyph (![Smart Tag Glyph](../test/media/vs_winformsmttagglyph.gif)) on the upper-right corner of the <xref:System.Windows.Forms.RichTextBox> control, and then select and **Dock in Parent Container**.

1. In **Solution Explorer**, right-click the Windows Forms Library project and select **Properties**.

1. In the **Properties**, select the **Application** tab.

1. In the **Target framework** drop-down list, select .NET Framework 4 (or later).

1. The **Target Framework Change** dialog box is displayed.

1. Choose **Yes**.

1. In **Solution Explorer**, right-click the **References** node and select **Add Reference**.

1. The **Add Reference** dialog box is displayed.

1. Choose the .**NET** tab, scroll down, and select **Microsoft.VisualStudio.QualityTools.WebTestFramework** and then choose **OK**.

1. If **View Designer** is not still open, in **Solution Explorer**, right-click **UserControl1.cs** and then select **View Designer**.

1. On the design surface, right-click and select **View Code**.

1. (Optional) Change the name of the class and the constructor from UserControl1 to a meaningful name, for example, MessageEditorControl:

    > [!NOTE]
    > The sample uses MessageEditorControl.

    ```csharp
    namespace MessageEditors
    {
        public partial class MessageEditorControl : UserControl
        {
            public MessageEditorControl()
            {
                InitializeComponent();
            }
        }
    }
    ```

1. Add the following properties to enable getting and setting the text in RichTextBox1. The <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin> interface will use EditString and the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin> will use EditByteArray:

    ```csharp
    public String EditString
    {
       get
       {
           return this.richTextBox1.Text;
       }
       set
       {
           this.richTextBox1.Text = value;
       }
    }

    public byte[] EditByteArray
    {
       get
       {
           return System.Convert.FromBase64String(richTextBox1.Text);
       }
       set
       {
           richTextBox1.Text = System.Convert.ToBase64String(value, 0, value.Length);
       }
    }
    ```

## Add a class to the Windows Control Library project

Add a class to the project. It will be used to implement the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin> and <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin> interfaces.

**Overview of the code in this procedure**

The MessageEditorControl <xref:System.Windows.Forms.UserControl> that was created in the previous procedure is instantiated as messageEditorControl:

```csharp
private MessageEditorControl messageEditorControl
```

The messageEditorControl instance is hosted within the plug-in dialog that is created by the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.CreateEditor*> method. Additionally, the messageEditorControl's <xref:System.Windows.Forms.RichTextBox> is populated with the contents in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody>. However, the creation of the plug-in cannot occur unless <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.SupportsContentType*> returns `true`. In the case of this editor, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.SupportsContentType*> returns `true` if the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody.ContentType*> in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody> contains "xml".

When editing of the string body is completed and the user clicks **OK** in the plug-in dialog box, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.GetNewValue*> is called to get the edited text as a string and update the **String Body** in the request in the Web Test Performance Editor.

### Create a class and implement the IStringHttpBodyEditorPlugin interface

1. In **Solution Explorer**, right-click the Windows Forms Control Library project and select **Add New Item**.

   The **Add New Item** dialog box is displayed.

2. Select **Class**.

3. In the **Name** text box, type a meaningful name for the class, for example, `MessageEditorPlugins`.

4. Choose **Add**.

   Class1 is added to the project and presented in the Code Editor.

5. In the code editor, add the following `using` statement:

    ```csharp
    using Microsoft.VisualStudio.TestTools.WebTesting;
    ```

6. Paste in the following code to implement the interface:

    ```csharp
    /// <summary>
    /// Editor for generic text based hierarchical messages such as XML and JSON.
    /// </summary>
    public class XmlMessageEditor : IStringHttpBodyEditorPlugin
    {
        public XmlMessageEditor()
        {
        }

        /// <summary>
        /// Determine if this plugin supports the content type.
        /// </summary>
        /// <param name="contentType">The content type to test.</param>
        /// <returns>Returns true if the plugin supports the specified content type.</returns>
        public bool SupportsContentType(string contentType)
        {
            return contentType.ToLower().Contains("xml");
        }

        /// <summary>
        /// Create a UserControl to edit the specified bytes.
        /// This control will be hosted in the
        /// plugin dialog which provides OK and Cancel buttons.
        /// </summary>
        /// <param name="contentType">The content type of the BinaryHttpBody.</param>
        /// <param name="initialValue">The bytes to edit. The bytes are the payload of a BinaryHttpBody.</param>
        /// <returns>A UserControl capable of displaying and editing the byte array value of the specified content type.</returns>
        public object CreateEditor(string contentType, string initialValue)
        {
            messageEditorControl = new MessageEditorControl();
            messageEditorControl.EditString = initialValue;
            return this.messageEditorControl;
        }

        /// <summary>
        /// Gets the edited bytes after the OK button is clicked on the plugin dialog.
        /// </summary>
        public string GetNewValue()
        {
            return messageEditorControl.EditString;
        }

        private MessageEditorControl messageEditorControl;
    }
    ```

## Add a IBinaryHttpBodyEditorPlugin to the class

Implement the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin> interface.

**Overview of the code in this procedure**

The code implementation for the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin> interface is similar to the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin> covered in the previous procedure. However, the binary version uses an array of bytes to handle the binary data instead of a string.

The MessageEditorControl <xref:System.Windows.Forms.UserControl> created in the first procedure is instantiated as messageEditorControl:

```csharp
private MessageEditorControl messageEditorControl
```

The messageEditorControl instance is hosted within the plug-in dialog that is created by the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.CreateEditor*> method. Additionally, the messageEditorControl's <xref:System.Windows.Forms.RichTextBox> is populated with the contents in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody>. However, the creation of the plug-in cannot occur unless <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.SupportsContentType*> returns `true`. In the case of this editor, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.SupportsContentType*> returns `true` if the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody.ContentType*> in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody> contains "msbin1".

When editing of the string body is completed and the user clicks **OK** in the plug-in dialog box, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.GetNewValue*> is called to get the edited text as a string and update the **BinaryHttpBody.Data** in the request in the Web Test Performance Editor.

### To add the IBinaryHttpBodyEditorPlugin to the class

- Write or copy the following code under the XmlMessageEditor class added in the previous procedure to instantiate the Msbin1MessageEditor class from <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin> interface and implement the required methods:

    ```csharp
    /// <summary>
        /// Editor for MSBin1 content type (WCF messages)
        /// </summary>
        public class Msbin1MessageEditor : IBinaryHttpBodyEditorPlugin
        {
            /// <summary>
            ///
            /// </summary>
            public Msbin1MessageEditor()
            {
            }

            /// <summary>
            /// Determine if this plugin supports a content type.
            /// </summary>
            /// <param name="contentType">The content type to test.</param>
            /// <returns>Returns true if the plugin supports the specified content type.</returns>
            public bool SupportsContentType(string contentType)
            {
                return contentType.ToLower().Contains("msbin1");
            }

            /// <summary>
            /// Create a UserControl to edit the specified bytes. This control will be hosted in the
            /// plugin dialog which provides OK and Cancel buttons.
            /// </summary>
            /// <param name="contentType">The content type of the BinaryHttpBody.</param>
            /// <param name="initialValue">The bytes to edit. The bytes are the payload of a BinaryHttpBody.</param>
            /// <returns>A UserControl capable of displaying and editing the byte array value of the specified content type.</returns>
            public object CreateEditor(string contentType, byte[] initialValue)
            {
                messageEditorControl = new MessageEditorControl();
                messageEditorControl.EditByteArray = initialValue;
                return messageEditorControl;
            }

            /// <summary>
            /// Gets the edited bytes after the OK button is clicked on the plugin dialog.
            /// </summary>
            public byte[] GetNewValue()
            {
                return messageEditorControl.EditByteArray;
            }

            private MessageEditorControl messageEditorControl;
            private object originalMessage;
        }
    ```

## Build and deploy the plug-ins

1. On the **Build** menu, choose **Build \<Windows Form Control Library project name>**.

2. Close all instances of Visual Studio.

   > [!NOTE]
   > Closing Visual Studio makes sure that the *.dll* file isn't locked before you try to copy it.

3. Copy the resulting *.dll* file from your project's *bin\debug* folder (for example, *MessageEditors.dll*) to *%ProgramFiles%\Microsoft Visual Studio\2017\\\<edition>\Common7\IDE\PrivateAssemblies\WebTestPlugins*.

4. Open Visual Studio.

   The *.dll* is now registered with Visual Studio.

## Verify the plug-ins using a Web Performance Test

1. Create a test project.

2. Create a web performance test and enter a URL in the browser to a web service.

3. When you finish the recording, in the Web Performance Test Editor, expand the request for the web service and select either a **String Body** or a **Binary Body**.

4. In the **Properties** window, select either String Body or Binary Body and choose the ellipsis **(…)**.

   The **Edit HTTP Body Data** dialog box is displayed.

5. You can now edit the data and choose **OK**. This invokes the applicable GetNewValue method to update the contents in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody>.

## Compile the code

Verify that the Targeted framework for the Windows Control Library project is .NET Framework 4.5. By default, Windows Control Library projects target the .NET Framework 4.5 Client framework, which will not allow the inclusion of the Microsoft.VisualStudio.QualityTools.WebTestFramework reference.

For more information, see [Application page, project designer (C#)](../ide/reference/application-page-project-designer-csharp.md).

## See also

- <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin>
- <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody>
- <xref:System.Windows.Forms.UserControl>
- <xref:System.Windows.Forms.RichTextBox>
- [Create custom code and plug-ins for load tests](../test/create-custom-code-and-plug-ins-for-load-tests.md)
- [How to: Create a request-level plug-in](../test/how-to-create-a-request-level-plug-in.md)
- [Code a custom extraction rule for a web performance test](../test/code-a-custom-extraction-rule-for-a-web-performance-test.md)
- [Code a custom validation rule for a web performance test](../test/code-a-custom-validation-rule-for-a-web-performance-test.md)
- [How to: Create a load test plug-in](../test/how-to-create-a-load-test-plug-in.md)
- [Generate and run a coded web performance test](../test/generate-and-run-a-coded-web-performance-test.md)
- [How to: Create a Visual Studio add-in for the Web Performance Test Results Viewer](../test/how-to-create-an-add-in-for-the-web-performance-test-results-viewer.md)
