using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//<Snippet1>
using Microsoft.VisualStudio.Tools.Applications;
//</Snippet1>

namespace DataWriter
{
    // To test the InitializeCachedDataSet behavior: 
    // 1. Run SQL Server (or Express) with AdventureWorksLT database. 
    //    Edit app.config in AdventureWorksDataSet as necessary to connect to your database instance.
    // 2. Build AdventureWorksDataSet.
    // 3. Comment out the Fill method call in the Startup event handler of AdventureWorksReport. 
    // 4. Build AdventureWorksReport. Optionally run it to verify that the ListObject is empty.
    // 5. In this code file below, uncomment InitializeCachedDataSet in Main.
    // 6. In InitializeCachedDataSet, modify the workbook path as necessary.
    // 7. Build and run DataWriter. 
    // 8. Open AdventureWorksReport.xlsx from \bin folder. Verify ListObject now has data.

    // To test the ModifyCachedDataSet behavior: 
    // 1. Run SQL Server (or Express) with AdventureWorksLT database. 
    //    Edit app.config in AdventureWorksDataSet as necessary to connect to your database instance.
    // 2. Build AdventureWorksDataSet.
    // 3. Build and run AdventureWorksReport. Verify the ListObject has data.
    // 4. Save and close workbook with same name and to the same location (that is, the \bin folder).
    // 5. In this code file below, uncomment ModifyCachedDataSet in Main.
    // 6. In ModifyCachedDataSet, modify the workbook path as necessary.
    // 7. Build and run DataWriter. 
    // 8. Open AdventureWorksReport.xlsx from \bin folder. Verify the ListPrices have changed.
    class Program
    {
        static void Main(string[] args)
        {
            //InitializeCachedDataSet();
            //ModifyCachedDataSet();
            //ReadCachedDataSet();
        }

        static private void InitializeCachedDataSet()
        {
            //<Snippet2>
            //<Snippet3>
            AdventureWorksDataSet.AdventureWorksLTDataSet productDataSet = 
                new AdventureWorksDataSet.AdventureWorksLTDataSet();
            AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter productTableAdapter =
                new AdventureWorksDataSet.AdventureWorksLTDataSetTableAdapters.ProductTableAdapter();

            string workbookPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) +
                @"\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx";
            ServerDocument serverDocument1 = null;
            //</Snippet3>

            //<Snippet4>
            try
            {
                productTableAdapter.Fill(productDataSet.Product);
                Console.WriteLine("The local dataset is filled.");

                serverDocument1 = new ServerDocument(workbookPath);
                CachedDataHostItem dataHostItem1 =
                    serverDocument1.CachedData.HostItems["AdventureWorksReport.Sheet1"];
                CachedDataItem dataItem1 = dataHostItem1.CachedData["adventureWorksLTDataSet"];

                // Initialize the worksheet dataset with the local dataset.
                if (dataItem1 != null)
                {
                    dataItem1.SerializeDataInstance(productDataSet);
                    serverDocument1.Save();
                    Console.WriteLine("The data is saved to the data cache.");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("The data object is not found in the data cache.");
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("The specified workbook does not exist.");
            }
            finally
            {
                if (serverDocument1 != null)
                {
                    serverDocument1.Close();
                }

                Console.WriteLine("\n\nPress Enter to close the application.");
                Console.ReadLine();
            }
            //</Snippet4>
            //</Snippet2>
        }

        static private void ModifyCachedDataSet()
        {
            //<Snippet5>
            //<Snippet6>
            AdventureWorksDataSet.AdventureWorksLTDataSet productDataSet =
                new AdventureWorksDataSet.AdventureWorksLTDataSet();
            string workbookPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) +
                @"\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx";
            ServerDocument serverDocument1 = null;
            //</Snippet6>

            //<Snippet7>
            try
            {
                serverDocument1 = new ServerDocument(workbookPath);
                CachedDataHostItem dataHostItem1 =
                    serverDocument1.CachedData.HostItems["AdventureWorksReport.Sheet1"];
                CachedDataItem dataItem1 = dataHostItem1.CachedData["adventureWorksLTDataSet"];

                if (dataItem1 != null)
                {
                    Console.WriteLine("Before reading data from the cache dataset, the local dataset has " +
                        "{0} rows.", productDataSet.Product.Rows.Count.ToString());

                    // Read the cached data from the worksheet dataset into the local dataset.
                    System.IO.StringReader schemaReader = new System.IO.StringReader(dataItem1.Schema);
                    System.IO.StringReader xmlReader = new System.IO.StringReader(dataItem1.Xml);
                    productDataSet.ReadXmlSchema(schemaReader);
                    productDataSet.ReadXml(xmlReader);

                    Console.WriteLine("After reading data from the cache dataset, the local dataset has " +
                        "{0} rows.", productDataSet.Product.Rows.Count.ToString());

                    // Modify the prices of each product in the local dataset.
                    foreach (AdventureWorksDataSet.AdventureWorksLTDataSet.ProductRow row in 
                             productDataSet.Product.Rows)
                    {
                        if (row.ProductCategoryID < 20)
                        {
                            row.ListPrice = row.ListPrice + (row.ListPrice * (Decimal).10);
                        }
                        else
                        {
                            row.ListPrice = row.ListPrice - (row.ListPrice * (Decimal).10);
                        }
                    }

                    // Write the modified local dataset to the worksheet dataset using the DiffGram format.
                    System.Text.StringBuilder stringIn = new System.Text.StringBuilder();
                    System.IO.StringWriter stringOut = new System.IO.StringWriter(stringIn);
                    productDataSet.WriteXml(stringOut, System.Data.XmlWriteMode.DiffGram);
                    dataItem1.Xml = stringIn.ToString();

                    serverDocument1.Save();
                    Console.WriteLine("The product prices have been modified.");
                }
                else
                {
                    Console.WriteLine("The data object is not found in the data cache.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("The specified workbook does not exist.");
            }
            catch (System.Xml.XmlException)
            {
                Console.WriteLine("The data object has invalid XML information.");
            }
            finally
            {
                if (serverDocument1 != null)
                {
                    serverDocument1.Close();
                }

                Console.WriteLine("\n\nPress Enter to close the application.");
                Console.ReadLine();
            }
            //</Snippet7>
            //</Snippet5>
        }


        static private void ReadCachedDataSet()
        {
            //<Snippet9>
            //<Snippet10>
            AdventureWorksDataSet.AdventureWorksLTDataSet productDataSet =
                new AdventureWorksDataSet.AdventureWorksLTDataSet();
            string workbookPath = System.Environment.GetFolderPath(
                Environment.SpecialFolder.MyDocuments) +
                @"\AdventureWorksReport\bin\Debug\AdventureWorksReport.xlsx";
            ServerDocument serverDocument1 = null;
            //</Snippet10>

            //<Snippet11>
            try
            {
                serverDocument1 = new ServerDocument(workbookPath);
                CachedDataHostItem dataHostItem1 =
                    serverDocument1.CachedData.HostItems["AdventureWorksReport.Sheet1"];
                CachedDataItem dataItem1 = dataHostItem1.CachedData["adventureWorksLTDataSet"];

                if (dataItem1 != null)
                {
                    Console.WriteLine("Before reading data from the cache dataset, the local dataset has " +
                        "{0} rows.", productDataSet.Product.Rows.Count.ToString());

                    // Read the cached data from the worksheet dataset into the local dataset.
                    System.IO.StringReader schemaReader = new System.IO.StringReader(dataItem1.Schema);
                    System.IO.StringReader xmlReader = new System.IO.StringReader(dataItem1.Xml);
                    productDataSet.ReadXmlSchema(schemaReader);
                    productDataSet.ReadXml(xmlReader);

                    Console.WriteLine("After reading data from the cache dataset, the local dataset has " +
                        "{0} rows.", productDataSet.Product.Rows.Count.ToString());
                }
                else
                {
                    Console.WriteLine("The data object is not found in the data cache.");
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("The specified workbook does not exist.");
            }
            catch (System.Xml.XmlException)
            {
                Console.WriteLine("The data object has invalid XML information.");
            }
            finally
            {
                if (serverDocument1 != null)
                {
                    serverDocument1.Close();
                }

                Console.WriteLine("\n\nPress Enter to close the application.");
                Console.ReadLine();
            }
            //</Snippet11>
            //</Snippet9>
        }


        // Todo: Consider refactoring out ModifyCachedDataSet into these helper methods.
        //private static void FillLocalDataSet(
        //    AdventureWorksDataSet.AdventureWorksLTDataSet dataSetToFill, CachedDataItem cachedItem)
        //{
        //    if (dataSetToFill != null)
        //    {
        //        Console.WriteLine("Before reading data from the cache dataset, the local dataset has " +
        //            "{0} rows.", dataSetToFill.Product.Rows.Count.ToString());

        //        // Read the cached data from the worksheet dataset into the local dataset.
        //        System.IO.StringReader schemaReader = new System.IO.StringReader(cachedItem.Schema);
        //        System.IO.StringReader xmlReader = new System.IO.StringReader(cachedItem.Xml);
        //        dataSetToFill.ReadXmlSchema(schemaReader);
        //        dataSetToFill.ReadXml(xmlReader);

        //        Console.WriteLine("After reading data from the cache dataset, the local dataset has " +
        //            "{0} rows.", dataSetToFill.Product.Rows.Count.ToString());
        //    }
        //}

        //private static void ModifyLocalDataSet(AdventureWorksDataSet.AdventureWorksLTDataSet dataSetToModify)
        //{
        //    foreach (AdventureWorksDataSet.AdventureWorksLTDataSet.ProductRow row in dataSetToModify.Product.Rows)
        //    {
        //        if (row.ProductCategoryID < 20)
        //        {
        //            row.ListPrice = row.ListPrice + (row.ListPrice * (Decimal).10);
        //        }
        //        else
        //        {
        //            row.ListPrice = row.ListPrice - (row.ListPrice * (Decimal).10);
        //        }
        //    }
        //}

        //private static void SaveChangesToCachedDataSet(
        //    AdventureWorksDataSet.AdventureWorksLTDataSet dataSetToFill, CachedDataItem cachedItem)
        //{
        //    System.Text.StringBuilder stringIn = new System.Text.StringBuilder();
        //    System.IO.StringWriter stringOut = new System.IO.StringWriter(stringIn);
        //    dataSetToFill.WriteXml(stringOut, System.Data.XmlWriteMode.DiffGram);

        //    cachedItem.Xml = stringIn.ToString();
        //}
    }
}