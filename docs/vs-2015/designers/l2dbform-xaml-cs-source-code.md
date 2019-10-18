---
title: "L2DBForm.xaml.cs Source Code | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-designers
ms.topic: conceptual
ms.assetid: 5a40dad3-6763-4576-b3ad-874df3f2c8d9
caps.latest.revision: 4
author: gewarren
ms.author: gewarren
manager: jillfra
---
# L2DBForm.xaml.cs Source Code
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This topic contains the contents and description of the C# source code in the file L2DBForm.xaml.cs. The L2XDBForm partial class contained in this file can be divided into three logical sections: data members and the `OnRemove` and `OnAddBook` button click event handlers.  
  
## Data Members  
 Two private data members are used to associate this class to the window resources used in L2DBForm.xaml.  
  
- The namespace variable `myBooks` is initialized to `"http://www.mybooks.com"`.  
  
- The member `bookList` is initialized in the constructor to the CDATA string in L2DBForm.xaml with the following line:  
  
    ```  
    bookList = (XElement)((ObjectDataProvider)Resources["LoadedBooks"]).Data;  
    ```  
  
## OnAddBook Event Handler  
 This method contains the following three statements:  
  
- The first conditional statement is used for input validation.  
  
- The second statement creates a new <xref:System.Xml.Linq.XElement> from the string values the user entered in the **Add New Book** user interface (UI) section.  
  
- The last statement adds this new book element to the data provider in L2DBForm.xaml. Consequently, dynamic data binding will automatically update the UI with this new item; no extra user-supplied code is required.  
  
## OnRemove Event Handler  
 The `OnRemove` handler is more complicated than the `OnAddBook` handler for two reasons. First, because the raw XML contains preserved white space, matching newlines must also be removed with the book entry. Second, as a convenience, the selection, which was on the deleted item, is reset to the previous one in the list.  
  
 However the core work of removing the selected book item is accomplished by only two statements:  
  
- First, the book element associated with the currently selected item in the list box is retrieved:  
  
  ```  
  XElement selBook = (XElement)lbBooks.SelectedItem;   
  ```  
  
- Then, this element is deleted from the data provider:  
  
  ```  
  selBook.Remove();  
  ```  
  
  Again, dynamic data binding assures that the program's UI is automatically updated.  
  
## Example  
  
### Description  
  
### Code  
  
```csharp  
using System;  
using System.Linq;  
using System.Collections;  
using System.Collections.Generic;  
using System.Diagnostics;  
using System.Text;  
using System.Windows;  
using System.Windows.Controls;  
using System.Windows.Data;  
using System.Windows.Input;  
using System.Xml;  
using System.Xml.Linq;  
  
namespace LinqToXmlDataBinding {  
    /// <summary>  
    /// Interaction logic for L2XDBForm.xaml  
    /// </summary>  
  
    public partial class L2XDBForm : System.Windows.Window   
    {  
        XNamespace mybooks = "http://www.mybooks.com";  
        XElement bookList;  
  
        public L2XDBForm()   
        {  
            InitializeComponent();  
            bookList = (XElement)((ObjectDataProvider)Resources["LoadedBooks"]).Data;  
        }  
  
        void OnRemoveBook(object sender, EventArgs e)   
        {  
            int index = lbBooks.SelectedIndex;  
            if (index < 0) return;  
  
            XElement selBook = (XElement)lbBooks.SelectedItem;  
            //Get next node before removing element.  
            XNode nextNode = selBook.NextNode;  
            selBook.Remove();  
  
            //Remove any matching newline node.  
            if (nextNode != null && nextNode.ToString().Trim().Equals(""))  
            { nextNode.Remove(); }  
  
            //Set selected item.   
            if (lbBooks.Items.Count > 0)  
            {  lbBooks.SelectedItem = lbBooks.Items[index > 0 ? index - 1 : 0]; }  
        }  
  
        void OnAddBook(object sender, EventArgs e)   
        {  
            if (String.IsNullOrEmpty(tbAddID.Text) ||  
                String.IsNullOrEmpty(tbAddValue.Text))  
            {  
                MessageBox.Show("Please supply both a Book ID and a Value!", "Entry Error!");  
                return;   
            }  
            XElement newBook = new XElement(  
                                mybooks + "book",  
                                new XAttribute("id", tbAddID.Text),  
                                tbAddValue.Text);  
            bookList.Add("  ", newBook, "\r\n");  
        }  
    }  
}  
  
```  
  
### Comments  
 For the associated XAML source for these handlers, see [L2DBForm.xaml Source Code](../designers/l2dbform-xaml-source-code.md).  
  
## See also  
 [Walkthrough: LinqToXmlDataBinding Example](../designers/walkthrough-linqtoxmldatabinding-example.md)   
 [L2DBForm.xaml Source Code](../designers/l2dbform-xaml-source-code.md)
