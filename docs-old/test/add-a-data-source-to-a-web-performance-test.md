---
title: "Add a data source to a web performance test"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
helpviewer_keywords: 
  - "Web performance tests, walkthroughs"
  - "Web performance tests, data binding (database)"
ms.assetid: 2ada376d-f168-455d-9643-6acb535360c1
caps.latest.revision: 96
ms.author: "ahomer"
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
# Add a data source to a web performance test
Bind data to provide different values to the same test, for example, to provide different values to your form post parameters.  
  
 ![Binding data to a web performance test](../test/media/web_test_databinding_conceptual.png "Web_Test_DataBinding_Conceptual")  
  
 We’re going to use a sample ASP.NET app. It has three .aspx pages – the default page, a Red page, and a Blue page. The default page has a radio control to choose either red or blue and a submit button. The other two .aspx pages are very simple. One has a label named Red and the other has a label named Blue. When you choose submit on the default page, we display one of the other pages. You can create an app like that, [download](http://code.msdn.microsoft.com/Sample-ColorWebApp-76ff7506) our sample, or just follow along with your own web app.  
  
 ![Running the web app to be tested](../test/media/web_test_databinding_runwebapp.png "Web_Test_DataBinding_RunWebApp")  
  
 Your solution should also include a web performance test that browses through the pages of the web application similar to the ColorWebAppTest project created in [Record and run a web performance test](assetId:///bd0a82fd-cec0-4861-bc09-e1b0b2d258ef).  
  
 ![Solution with web performance test](../test/media/web_test_databinding_solution.png "Web_Test_DataBinding_Solution")  
  
##  <a name="AddingDataBindingWebTest_CreateSQLDB"></a> Create a SQL database  
  
1.  If you don’t have Visual Studio Enterprise, get it [here](http://go.microsoft.com/fwlink/?LinkID=268018).  
  
2.  Create a SQL database.  
  
     ![Add a new SQL database](../test/media/web_test_databinding_sql_addnewdb.png "Web_Test_DataBinding_SQL_AddNewDB")  
  
3.  Create a database project.  
  
     ![Create new project from database](../test/media/web_test_databinding_sql_addnewdbproject.png "Web_Test_DataBinding_SQL_AddNewDBProject")  
  
4.  Add a table to the database project.  
  
     ![Add a new table to the database project](../test/media/web_test_databinding_sql_addnewdbtablename.png "Web_Test_DataBinding_SQL_AddNewDBTableName")  
  
5.  Add fields to the table.  
  
     ![Add fields to the table](../test/media/web_test_databinding_sql_addnewdbaddfields.png "Web_Test_DataBinding_SQL_AddNewDBAddFields")  
  
6.  Publish the database project.  
  
     ![Publish database project from Solution Explorer](../test/media/web_test_databinding_sql_addnewdbpublish.png "Web_Test_DataBinding_SQL_AddNewDBPublish")  
  
7.  Add data to the fields.  
  
     ![Add data to the fields](../test/media/web_test_databinding_sql_addnewfieldsadddata.png "Web_Test_DataBinding_SQL_AddNewFieldsAddData")  
  
##  <a name="AddingDataBindingWebTest_AddSQLData"></a> Add the data source  
  
1.  Add a data source.  
  
     ![Add data source to web performance test](../test/media/web_test_databinding_sql_adddatasource.png "Web_Test_DataBinding_SQL_AddDataSource")  
  
2.  Choose the type of data source and name it.  
  
     ![Name the database source](../test/media/web_test_databinding_sql_adddatasourcedialog.png "Web_Test_DataBinding_SQL_AddDataSourceDialog")  
  
3.  Create a connection.  
  
     ![Choose new connection](../test/media/web_test_databinding_sql_adddatasourcedialogconnectionnew.png "Web_Test_DataBinding_SQL_AddDataSourceDialogConnectionNew")  
  
     Enter the connection details.  
  
     ![Enter the SQL database connection properties](../test/media/web_test_databinding_sql_adddatasourcedialogconnection.png "Web_Test_DataBinding_SQL_AddDataSourceDialogConnection")  
  
4.  Select the table that you want to use for your test.  
  
     ![Add the Color table as the data source](../test/media/web_test_databinding_sql_adddatasourcedialogaddtable.png "Web_Test_DataBinding_SQL_AddDataSourceDialogAddTable")  
  
     The table is bound to the test.  
  
     ![Data Sources node add to the web performance test](../test/media/web_test_databinding_requestnodeadded_mdb.png "Web_Test_DataBinding_RequestNodeAdded_MDB")  
  
5.  Save the test.  
  
##  <a name="AddingDataBindingWebTest_BindSQLData"></a> Bind the data  
  
1.  Bind the ColorName field.  
  
     ![Bind the ColorName field to RadioButtonList1 value](../test/media/web_test_databinding_sql_binddatasource.png "Web_Test_DataBinding_SQL_BindDataSource")  
  
2.  Open the Local.testsettings file in Solution Explorer and select the one run per data source row option.  
  
     ![Edit the test settings file](../test/media/web_test_databinding_sql_testsettings.png "Web_Test_DataBinding_SQL_TestSettings")  
  
3.  Save the web performance test.  
  
##  <a name="AddingDataBindingWebPerfTest_RunToVerify"></a> Run the test with the data  
  
1.  Run the test.  
  
     ![Run the web performance test to verify binding](../test/media/web_test_databinding_sql_runtest.png "Web_Test_DataBinding_SQL_RunTest")  
  
     The two runs are displayed for each data row. Run 1 sends a request for the page Red.aspx, and Run 2 sends a request for the page Blue.aspx.  
  
     ![Test run results](../test/media/web_test_databinding_sql_runresults.png "Web_Test_DataBinding_SQL_RunResults")  
  
     When you bind to a data source, you could violate the default response URL rule. In this case, the error in Run 2 is caused by the rule which expects the Red.aspx page from the original test recording, but the data binding now directs it to the Blue.aspx page.  
  
2.  Correct the validation error by deleting the Response URL validation rule and running the test again.  
  
     ![Delete the response URL validation rule](../test/media/web_test_databinding_sql_deleteresponseurl.png "Web_Test_DataBinding_SQL_DeleteResponseURL")  
  
     The web performance test now passes using data binding.  
  
     ![Test passes using data binding](../test/media/web_test_databinding_sql_deleteresponseurlrunresults.png "Web_Test_DataBinding_SQL_DeleteResponseURLRunResults")  
  
## Q & A  
  
### Q: What databases can I use as a data source?  
 **A:** You can use the following:  
  
-   Microsoft SQL Azure.  
  
-   Any version of Microsoft SQL Server 2005 or later.  
  
-   Microsoft SQL Server database file (including SQL Express).  
  
-   Microsoft ODBC.  
  
-   Microsoft Access file using the .NET Framework provider for OLE DB.  
  
-   Oracle 7.3, 8i, 9i, or 10g.  
  
###  <a name="AddingDataBindingWebTest_QA_CSVFile"></a> Q: How do I use a comma separated value (CSV) text file as a data source?  
 **A:** Here's how:  
  
1.  Create a folder to organize your projects database artifacts and add an item.  
  
     ![Add new item to the Data folder](../test/media/web_test_databinding_foldernewitem.png "Web_Test_DataBinding_FolderNewItem")  
  
2.  Create a text file.  
  
     ![Name the new text file ColorData.csv](../test/media/web_test_databinding_foldernewitemtextfile.png "Web_Test_DataBinding_FolderNewItemTextFile")  
  
3.  Edit the text file and add the following:  
  
    ```  
    ColorId, ColorName  
    0,Red  
    1,Blue  
    ```  
  
4.  Use the steps in [Binding the SQL data](#AddingDataBindingWebTest_BindSQLData), but choose CSV file as your data source.  
  
     ![Enter a name and choose CSV file](../test/media/web_test_databinding_adddatasourcedialog.png "Web_Test_DataBinding_AddDataSourceDialog")  
  
###  <a name="AddingDataBindingWebTest_QA_CSVFileNoHeaders"></a> Q: What if my existing CSV file does not contain column headers?  
 **A:** If you can’t add column headers, you can use a schema description file to treat the CSV file as a database.  
  
1.  Add a new text file named schema.ini.  
  
     ![Add a schema.ini file](../test/media/web_test_databinding_schemafile.png "Web_Test_DataBinding_SchemaFile")  
  
2.  Edit the schema.ini file to add the information that describes the structure of your data. For example, a schema file describing the CSV file might look like this:  
  
    ```  
    [testdata.csv]  
    ColNameHeader=False  
  
    ```  
  
3.  Add a data source to the test.  
  
     ![Add data source to web performance test](../test/media/web_test_databinding_sql_adddatasource.png "Web_Test_DataBinding_SQL_AddDataSource")  
  
4.  If you’re using a schema.ini file, choose Database (not CSV file) as the data source and name it.  
  
     ![Add database data source](../test/media/web_test_databinding_adddatasourcecolortext.png "Web_Test_DataBinding_AddDataSourceColorText")  
  
5.  Create a new connection.  
  
     ![Choose new connection](../test/media/web_test_databinding_sql_adddatasourcedialogconnectionnew.png "Web_Test_DataBinding_SQL_AddDataSourceDialogConnectionNew")  
  
6.  Select the .NET Framework Data Provider for OLE DB.  
  
     ![Select the .NET framework OLE DB data provider](../test/media/web_test_databinding_adddatasourcecolortext2.png "Web_Test_DataBinding_AddDataSourceColorText2")  
  
7.  Choose Advanced.  
  
     ![Choose Advanced](../test/media/web_test_databinding_advanced.png "Web_Test_DataBinding_Advanced")  
  
8.  For the Provider property, select Microsoft.Jet.OLEDB.4.0, and then set Extended Properties to Text;HDR=NO.  
  
     ![Apply advanced properties](../test/media/web_test_databinding_advancedproperties.png "Web_Test_DataBinding_AdvancedProperties")  
  
9. Type the name of the folder that contains the schema file and test your connection.  
  
     ![Enter the path to the data folder](../test/media/web_test_databinding_adddatasourcecolortext5.png "Web_Test_DataBinding_AddDataSourceColorText5")  
  
10. Select the CSV file that you want to use.  
  
     ![Select the text file](../test/media/web_test_databinding_adddatasourcecolortext6.png "Web_Test_DataBinding_AddDataSourceColorText6")  
  
     After you finish, the CSV file appears as a table.  
  
     ![Data source added to test](../test/media/web_test_databinding_adddatasourcecolortext7.png "Web_Test_DataBinding_AddDataSourceColorText7")  
  
###  <a name="AddingDataBindingWebTest_QA_XMLFile"></a> Q: How do I use an XML file as a data source?  
 **A:** Yes.  
  
1.  Create a folder to organize your projects database artifacts and add an item.  
  
     ![Add new item to the Data folder](../test/media/web_test_databinding_foldernewitem.png "Web_Test_DataBinding_FolderNewItem")  
  
2.  Create an XML file.  
  
     ![Add ColorData.xml file](../test/media/web_test_databinding_additemxmlfile.png "Web_Test_DataBinding_AddItemXMLFile")  
  
3.  Edit the XML file and add your data:  
  
    ```  
    <?xml version="1.0" encoding="utf-8" ?>  
    <ColorData>  
        <Color>  
            <ColorId>0</ColorId>  
            <ColorName>Red</ColorName>  
        </Color>  
        <Color>  
            <ColorId>1</ColorId>  
            <ColorName>Blue</ColorName>  
        </Color>  
    </ColorData>  
  
    ```  
  
4.  Use the steps in [Binding the SQL data](#AddingDataBindingWebTest_BindSQLData), but choose XML file as your data source.  
  
     ![Enter a name and choose XML file](../test/media/web_test_databinding_adddatasourcedialogxml.png "Web_Test_DataBinding_AddDataSourceDialogXML")  
  
###  <a name="AddingDataBindingWebTest_QA_WebServiceRequest"></a> Q: Can I add data binding to a web service request that uses SOAP?  
 **A:** Yes, you must change the SOAP XML manually.  
  
1.  Choose the web service request in the request tree and in the Properties window, choose the ellipsis (…) in the String Body property.  
  
     ![Edit the web service string body](../test/media/web_test_databinding_webservicerequest.png "Web_Test_DataBinding_WebServiceRequest")  
  
2.  Replace values in the SOAP body with data bound values by using the following syntax:  
  
    ```  
    {{DataSourceName.TableName.ColumnName}}  
    ```  
  
     For example, if you have the following code:  
  
    ```  
    <?xml version="1.0" encoding="utf-8"?>  
    <soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">  
        <soap:Body>  
            <CheckStatus xmlns="http://tempuri.org/">  
                <userName>string</userName> <password>string</password> <orderID>int</orderID>  
            </CheckStatus>  
        </soap:Body>  
    </soap:Envelope>  
    ```  
  
     You can change it to this:  
  
    ```  
    <?xml version="1.0" encoding="utf-8"?>  
    <soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">  
        <soap:Body>  
            <CheckStatus xmlns="http://tempuri.org/">  
                <userName>{{DataSourceName.Users.Name}}</userName> <password>{{DataSourceName.Users.Password}}</password> <orderID>{{DataSourceName.Orders.OrderID}}</orderID>  
            </CheckStatus>  
        </soap:Body>  
    </soap:Envelope>  
    ```  
  
3.  Save the test.