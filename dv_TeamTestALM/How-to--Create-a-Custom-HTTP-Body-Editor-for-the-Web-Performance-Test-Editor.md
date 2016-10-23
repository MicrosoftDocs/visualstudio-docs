---
title: "How to: Create a Custom HTTP Body Editor for the Web Performance Test Editor"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a0b2d8ff-3e2a-487e-9172-90047174f336
caps.latest.revision: 25
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Create a Custom HTTP Body Editor for the Web Performance Test Editor
You can create a custom content editor that enables you to edit the string body content or the binary body content of a Web service request, for example, SOAP, REST, asmx, wcf, RIA and other Web service request types.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 You can implement these kinds of editors:  
  
-   **String content editor** This is implemented using the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin?qualifyHint=False> interface.  
  
-   **Binary content editor** This is implemented using the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin?qualifyHint=False> interface.  
  
 These interfaces are contained in the <xref:Microsoft.VisualStudio.TestTools.WebTesting?qualifyHint=False> namespace.  
  
## Create a Windows Control Library project  
  
#### Create a user control by using a Windows Control Library project  
  
1.  In Visual Studio, on the **File** menu, choose **New** and then select **Project**.  
  
     The **New Project** dialog box is displayed.  
  
2.  Under **Installed Templates**, select either **Visual Basic** or **Visual C#** depending on your programming preference, and then select **Windows**.  
  
    > [!NOTE]
    >  This sample uses Visual C#.  
  
3.  In the list of templates, select **Windows Forms Control Library**.  
  
4.  In the Name text box, type a name, for example, `MessageEditors`, and choose **OK**.  
  
    > [!NOTE]
    >  This sample uses MessageEditors.  
  
     The project is added to the new solution and a <xref:System.Windows.Forms.UserControl?qualifyHint=False> named UserControl1.cs is presented in the Designer.  
  
5.  From the **Toolbox**, under the **Common Controls** category, drag a <xref:System.Windows.Forms.RichTextBox?qualifyHint=False> onto the surface of UserControl1.  
  
6.  Choose the action tag glyph (![Smart Tag Glyph](../dv_TeamTestALM/media/VS_WinFormSmtTagGlyph.gif "VS_WinFormSmtTagGlyph")) on the upper-right corner of the <xref:System.Windows.Forms.RichTextBox?qualifyHint=False> control, and then select and **Dock in Parent Container**.  
  
7.  In Solution Explorer, right-click the Windows Forms Library project and select **Properties**.  
  
8.  In the Properties, select the **Application** tab.  
  
9. In the **Target framework** drop-down list, select **.NET Framework 4**.  
  
10. The Target Framework Change dialog box is displayed.  
  
11. Choose **Yes**.  
  
12. In Solution Explorer, right-click the **References** node and select **Add Reference**.  
  
13. The **Add Reference** dialog box is displayed.  
  
14. Choose the .**NET** tab, scroll down and select **Microsoft.VisualStudio.QualityTools.WebTestFramework** and then choose **OK**.  
  
15. If View Designer is not still open, in Solution Explorer, right-click **UserControl1.cs** and then select **View Designer**.  
  
16. On the design surface, right-click and select **View Code**.  
  
17. (Optional) Change the name of the class and the constructor from UserControl1 to a meaningful name, for example, MessageEditorControl:  
  
    > [!NOTE]
    >  The sample uses MessageEditorControl.  
  
    ```  
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
  
18. Add the following properties to enable getting and setting the text in RichTextBox1. The <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin?qualifyHint=False> interface will use EditString and the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin?qualifyHint=False> will use EditByteArray:  
  
    ```  
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
  
## Add a class for to the Windows Control Library project  
 Add a class to the project. It will be used to implement the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin?qualifyHint=False> and <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin?qualifyHint=False> interfaces.  
  
 **Overview of the code in this procedure**  
  
 The MessageEditorControl <xref:System.Windows.Forms.UserControl?qualifyHint=False> that was created in the previous procedure is instantiated as messageEditorControl:  
  
```  
private MessageEditorControl messageEditorControl  
```  
  
 The messageEditorControl instance is hosted within the plug-in dialog that is created by the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.CreateEditor?qualifyHint=False> method. Additionally, the messageEditorControl's <xref:System.Windows.Forms.RichTextBox?qualifyHint=False> is populated with the contents in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody?qualifyHint=False>. However, the creation of the plug-in cannot occur unless <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.SupportsContentType?qualifyHint=False> returns `true`. In the case of this editor, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.SupportsContentType?qualifyHint=False> returns `true` if the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody.ContentType?qualifyHint=False> in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody?qualifyHint=False> contains "xml".  
  
 When editing of the string body is completed and the user clicks **OK** in the plug-in dialog box, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.GetNewValue?qualifyHint=False> is called to get the edited text as a string and update the **String Body** in the request in the Web Test Performance Editor.  
  
#### To create a class and implement the IStringHttpBodyEditorPlugin interface code  
  
1.  In Solution Explorer, right-click the Windows Forms Control Library project and select **Add New Item**.  
  
2.  The **Add New Item** dialog box is displayed.  
  
3.  Select **Class**.  
  
4.  In the **Name** text box, type a meaningful name for the class, for example, `MessageEditorPlugins`.  
  
5.  Choose **Add**.  
  
     Class1 is added to the project and presented in the Code Editor.  
  
6.  In the Code Editor, add the following using statement:  
  
    ```  
    using Microsoft.VisualStudio.TestTools.WebTesting;  
    ```  
  
7.  Write or copy the following code to instantiate the XmlMessageEditor class from <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin?qualifyHint=False> interface and implement the required methods:  
  
    ```  
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
        /// <param name="initialValue">The bytes to edit.  The bytes are the payload of a BinaryHttpBody.</param>  
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
  
## Add a IBinaryHttpBodyEditorPlugin to the Class  
 Implement the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin?qualifyHint=False> interface.  
  
 **Overview of the code in this procedure**  
  
 The code implementation for the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin?qualifyHint=False> interface is similar to the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin?qualifyHint=False> covered in the previous procedure. However, the binary version uses an array of bytes to handle the binary data instead of a string.  
  
 The MessageEditorControl <xref:System.Windows.Forms.UserControl?qualifyHint=False> created in the first procedure is instantiated as messageEditorControl:  
  
```  
private MessageEditorControl messageEditorControl  
```  
  
 The messageEditorControl instance is hosted within the plug-in dialog that is created by the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.CreateEditor?qualifyHint=False> method. Additionally, the messageEditorControl's <xref:System.Windows.Forms.RichTextBox?qualifyHint=False> is populated with the contents in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody?qualifyHint=False>. However, the creation of the plug-in cannot occur unless <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.SupportsContentType?qualifyHint=False> returns `true`. In the case of this editor, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.SupportsContentType?qualifyHint=False> returns `true` if the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody.ContentType?qualifyHint=False> in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody?qualifyHint=False> contains "msbin1".  
  
 When editing of the string body is completed and the user clicks **OK** in the plug-in dialog box, <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.GetNewValue?qualifyHint=False> is called to get the edited text as a string and update the **BinaryHttpBody.Data** in the request in the Web Test Performance Editor.  
  
#### To add the IBinaryHttpBodyEditorPlugin to the class  
  
-   Write or copy the following code under the XmlMessageEditor class added in the previous procedure to instantiate the Msbin1MessageEditor class from <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin?qualifyHint=False> interface and implement the required methods:  
  
    ```  
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
            /// Create a UserControl to edit the specified bytes.  This control will be hosted in the  
            /// plugin dialog which provides OK and Cancel buttons.  
            /// </summary>  
            /// <param name="contentType">The content type of the BinaryHttpBody.</param>  
            /// <param name="initialValue">The bytes to edit.  The bytes are the payload of a BinaryHttpBody.</param>  
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
  
## Build and Deploy the Plug-Ins  
  
#### To build and deploy the resulting dll for the IStringHttpBodyEditorPlugin and IBinaryHttpBodyEditorPlugin  
  
1.  On the Build menu, choose Build <Windows Form Control Library project name\>.  
  
2.  Close all instances of Visual Studio.  
  
    > [!NOTE]
    >  This makes sure that the .dll file isn't locked before you try to copy it.  
  
3.  Copy the resulting .dll file from your projects bin\debug folder (for example, MessageEditors.dll) to %ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\PrivateAssemblies\WebTestPlugins.  
  
4.  Open Visual Studio.  
  
     The .dll should now be registered with Visual Studio.  
  
## Verify the Plug-Ins Using a Web Performance Test  
  
#### To test your plug-ins  
  
1.  Create a Test Project.  
  
2.  Create a Web performance test and enter a URL in the browser to a Web service, for example, http://dev.virtualearth.net/webservices/v1/metadata/searchservice/dev.virtualearth.net.webservices.v1.search.wsdl.  
  
3.  When you finish the recording, in the Web Performance Test Editor, expand the request for the Web service and select either a **String Body** or a **Binary Body**.  
  
4.  In the Properties window, Select either String Body or Binary Body and choose the ellipsis (…).  
  
     The **Edit HTTP Body Data** dialog box is displayed.  
  
5.  You can now edit the data and choose OK. This invokes the applicable GetNewValue method to update the contents in the <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody?qualifyHint=False>.  
  
## Compiling the Code  
  
-   Verify that the Targeted framework for the Windows Control Library project is .NET Framework 4.5. By default, Windows Control Library projects target the .NET Framework 4.5 Client framework which will not allow the inclusion of the Microsoft.VisualStudio.QualityTools.WebTestFramework reference.  
  
     For more information, see [Application Page, Project Designer (C#)](../VS_IDE/Application-Page--Project-Designer--C#-.md).  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.CreateEditor?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.SupportsContentType?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IStringHttpBodyEditorPlugin.GetNewValue?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.CreateEditor?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.SupportsContentType?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IBinaryHttpBodyEditorPlugin.GetNewValue?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody?qualifyHint=False>   
 <xref:Microsoft.VisualStudio.TestTools.WebTesting.IHttpBody.ContentType?qualifyHint=False>   
 <xref:System.Windows.Forms.UserControl?qualifyHint=False>   
 <xref:System.Windows.Forms.RichTextBox?qualifyHint=False>   
 [Create custom code and plug-ins for load tests](../dv_TeamTestALM/Create-custom-code-and-plug-ins-for-load-tests.md)   
 [How to: Create a Request-Level Plug-In](../dv_TeamTestALM/How-to--Create-a-Request-Level-Plug-In.md)   
 [Coding a custom extraction rule for a web performance test](../dv_TeamTestALM/Coding-a-custom-extraction-rule-for-a-web-performance-test.md)   
 [Coding a custom validation rule for a web performance test](../dv_TeamTestALM/Coding-a-custom-validation-rule-for-a-web-performance-test.md)   
 [How to: Create a Load Test Plug-In](../dv_TeamTestALM/How-to--Create-a-Load-Test-Plug-In.md)   
 [How to: Create a Coded Web Performance Test](../Topic/How%20to:%20Create%20a%20Coded%20Web%20Performance%20Test.md)   
 [How to: Create a Visual Studio Add-In for the Web Performance Test Results Viewer](../dv_TeamTestALM/How-to--Create-a-Visual-Studio-Add-In-for-the-Web-Performance-Test-Results-Viewer.md)