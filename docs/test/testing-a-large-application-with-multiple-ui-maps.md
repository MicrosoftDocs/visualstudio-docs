---
title: "Testing a Large Application with Multiple UI Maps | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "coded UI tests, multiple UI maps"
  - "coded UI tests, for large applications"
ms.assetid: 6e1ae9ec-e9b1-458a-bd96-0eb15e46f1d5
caps.latest.revision: 22
ms.author: "douge"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Testing a Large Application with Multiple UI Maps
This topic discusses how to use coded UI tests when you are testing a large application by using multiple UI maps.  
  
 **Requirements**  
  
-   Visual Studio Enterprise  
  
 When you create a new coded UI test, the [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] testing framework generates code for the test by default in a <xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap> class. For more information about how to record coded UI tests, see [Creating Coded UI Tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate) and [Anatomy of a Coded UI Test](../test/anatomy-of-a-coded-ui-test.md).  
  
 The generated code for the UI Map contains a class for each object that the test interacts with. For each generated method, a companion class for method parameters is generated specifically for that method. If there are a large number of objects, pages, and forms and controls in your application, the UI Map can grow very large. Also, if several people are working on tests, the application becomes unwieldy with a single large UI Map file.  
  
 Using multiple UI Map files can provide the following benefits:  
  
-   Each map can be associated with a logical subset of the application. This makes changes easier to manage.  
  
-   Each tester can work on a section of the application and check in their code without interfering with other testers working on other sections of the application.  
  
-   Additions to the application UI can be scaled incrementally with minimal effect on tests for other parts of the UI.  
  
## Do you need multiple UI Maps?  
 Create multiple UI Maps in each of these types of situations:  
  
-   Several complex sets of composite UI controls that together perform a logical operation, such as a registration page in a Web site, or the purchase page of a shopping cart.  
  
-   An independent set of controls that are accessed from various points of the application, such as a wizard with several pages of operations. If each page of a wizard is especially complex, you could create separate UI Maps for each page.  
  
## Adding Multiple UI Maps  
  
#### To add a UI Map to your coded UI test project  
  
1.  In **Solution Explorer**, to create a folder in your coded UI test project to store all the UI Maps, right-click the coded UI test project file, point to **Add** and then choose **New Folder**. For example, you could name it `UIMaps`.  
  
     The new folder is displayed under the coded UI test project.  
  
2.  Right-click the `UIMaps` folder, point to **Add**, and then choose **New Item**.  
  
     The **Add New Item** dialog box is displayed.  
  
    > [!NOTE]
    >  You must be in a coded UI test project to add a new coded UI test map.  
  
3.  Select **Coded UI Test Map** from the list.  
  
     In the **Name** box, enter a name for the new UI Map. Use the name of the component or page that the map will represent, for example, `HomePageMap`.  
  
4.  Choose **Add**.  
  
     The [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] window minimizes and the **Coded UI Test Builder** dialog box is displayed.  
  
5.  Record the actions for the first method and choose **Generate Code**.  
  
6.  After you have recorded all actions and assertions for the first component or page and grouped them into methods, close the **Coded UI Test Builder** dialog box.  
  
7.  Continue to create UI Maps. Record the actions and assertions, group them into methods for each component, and then generate the code.  
  
 In many cases, the top level window of your application remains constant for all wizards, forms, and pages. Although each UI Map has a class for the top level window, all maps are probably referring to the same top level window within which all components of your application run. Coded UI tests search for controls hierarchically from the top down, starting from the top level window, so in a complex application, the real top level window could be duplicated in every UI Map. If the real top level window is duplicated, multiple modifications will result if that window changes. This could cause performance problems when you switch between UI Maps.  
  
 To minimize this effect, you can use the `CopyFrom()` method to ensure that the new top level window in that UI Map is the same as the main top level window.  
  
## Example  
 The following example is part of a utility class that provides access to each component and their child controls which are represented by the classes generated in the various UI Maps.  
  
 For this example, a Web application named `Contoso` has a Home Page, a Product Page, and a Shopping Cart Page. Each of these pages share a common top level window which is the browser window. There is a UI Map for each page and the utility class has code similar to the following:  
  
```  
using ContosoProject.UIMaps;  
using ContosoProject.UIMaps.HomePageClasses;  
using ContosoProject.UIMaps.ProductPageClasses;  
using ContosoProject.UIMaps.ShoppingCartClasses;  
  
namespace ContosoProject  
{  
    public class TestRunUtility  
    {  
        // Private fields for the properties  
        private HomePage homePage = null;  
        private ProductPage productPage = null;  
        private ShoppingCart shoppingCart = null;  
  
        public TestRunUtility()  
        {  
            homePage = new HomePage();  
        }  
  
        // Properties that get each UI Map  
        public HomePage HomePage  
        {  
            get { return homePage; }  
            set { homePage = value; }  
        }  
  
        // Gets the ProductPage from the ProductPageMap.  
        public ProductPage ProductPageObject  
        {  
            get  
            {  
                if (productPage == null)  
                {  
                    // Instantiate a new page from the UI Map classes  
                    productPage = new ProductPage();  
  
                    // Since the Product Page and Home Page both use  
                    // the same browser page as the top level window,  
                    // get the top level window properties from the  
                    // Home Page.  
                    productPage.UIContosoFinalizeWindow.CopyFrom(  
                        HomePage.UIContosoWindowsIWindow);  
                }  
                return productPage;  
            }  
        }  
  
    // Continue to create properties for each page, getting the   
    // page object from the corresponding UI Map and copying the   
    // top level window properties from the Home Page.  
}  
```  
  
## See Also  
 <xref:Microsoft.VisualStudio.TestTools.UITest.Common.UIMap.UIMap>   
 <xref:Microsoft.VisualStudio.TestTools.UITesting.BrowserWindow.CopyFrom%2A>   
 [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)   
 [Creating Coded UI Tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate)   
 [Anatomy of a Coded UI Test](../test/anatomy-of-a-coded-ui-test.md)
