using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Windows;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using SystemAndersson.Anet.BI.LoginSQL;
using Microsoft.Office.Interop.Word;
using Microsoft.Win32;
using System.Windows.Xps.Packaging;
using Microsoft.Office.Interop.Excel;

namespace Filestreamtest
{
    public class FilestreamControl
    {
        const UInt32 DESIRED_ACCESS_READ = 0x00000000;
        const UInt32 DESIRED_ACCESS_WRITE = 0x00000001;
        const UInt32 DESIRED_ACCESS_READWRITE = 0x00000002;

        const UInt32 SQL_FILESTREAM_OPEN_NO_FLAGS = 0x00000000;

        [DllImport("sqlncli10.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern SafeFileHandle OpenSqlFilestream(
                    string FilestreamPath,
                    UInt32 DesiredAccess,
                    UInt32 OpenOptions,
                    byte[] FilestreamTransactionContext,
                    UInt32 FilestreamTransactionContextLength,
                    Int64 AllocationSize);




        public FilestreamControl()
        {

        }




        public static void Get(string filename, string blobID)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            SqlCommand cmd = null;

            try
            {
                cn = GetConnection();
                tx = cn.BeginTransaction();
                cmd = new SqlCommand("SpDocumentGet", cn, tx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aDocumentGUID", new System.Guid(blobID));
                SqlDataReader r = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                r.Read();
                string path = r[0].ToString();
                string Exstension = r[1].ToString();
                r.Close();

                // get the transaction context
                cmd = new SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", cn, tx);
                Object obj = cmd.ExecuteScalar();
                byte[] txCtx = (byte[])obj;

                // open the filestream to the blob
                SafeFileHandle handle = OpenSqlFilestream(
                         path,
                         DESIRED_ACCESS_READ,
                         SQL_FILESTREAM_OPEN_NO_FLAGS,
                         txCtx,
                         (UInt32)txCtx.Length,
                         0);

                // open a Filestream to read the blob
                FileStream blob = new FileStream(
                        handle,
                        FileAccess.Read);

                byte[] buffer = new byte[(int)blob.Length];
                blob.Read(buffer, 0, buffer.Length);
                blob.Close();

                if (handle != null && !handle.IsClosed)
                    handle.Close();


                // write out the blob to a file
                filename = filename + Exstension;
                FileStream output = new FileStream(
                        filename,
                        FileMode.Create);
                output.Write(buffer, 0, buffer.Length);
                output.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (cn != null)
                {
                    tx.Commit();
                    cn.Close();
                }
            }
        }

        public static FileStream Get(string blobID)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            SqlCommand cmd = null;
            FileStream result = null;

            try
            {
                cn = GetConnection();
                tx = cn.BeginTransaction();
                cmd = new SqlCommand("SpDocumentGet", cn, tx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aDocumentGUID", new System.Guid(blobID));
                SqlDataReader r = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                r.Read();
                string path = r[0].ToString();
                string Extension = r[1].ToString();
                
                r.Close();

                // get the transaction context
                cmd = new SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", cn, tx);
                Object obj = cmd.ExecuteScalar();
                byte[] txCtx = (byte[])obj;

                // open the filestream to the blob
                SafeFileHandle handle = OpenSqlFilestream(
                         path,
                         DESIRED_ACCESS_READ,
                         SQL_FILESTREAM_OPEN_NO_FLAGS,
                         txCtx,
                         (UInt32)txCtx.Length,
                         0);

                // open a Filestream to read the blob
                FileStream blob = new FileStream(
                        handle,
                        FileAccess.Read);
                result = blob;
                //byte[] buffer = new byte[(int)blob.Length];
                //blob.Read(buffer, 0, buffer.Length);
                //blob.Close();
                //result = ByteArrayToObject(buffer);
               // if (handle != null && !handle.IsClosed)
                //    handle.Close();
                
                
              
           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (cn != null)
                {
                  //  tx.Commit();
                  //  cn.Close();
                }
            }
            return result;
        }


        public Bitmap Get2(string blobID)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            SqlCommand cmd = null;
           
            try
            {
                cn = GetConnection();
                tx = cn.BeginTransaction();
                cmd = new SqlCommand("SpDocumentGet", cn, tx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aDocumentGUID", new System.Guid(blobID));
                SqlDataReader r = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                r.Read();
                string path = r[0].ToString();
                string Extension = r[1].ToString();

                r.Close();

                // get the transaction context
                cmd = new SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", cn, tx);
                Object obj = cmd.ExecuteScalar();
                byte[] txCtx = (byte[])obj;

                // open the filestream to the blob
                SafeFileHandle handle = OpenSqlFilestream(
                         path,
                         DESIRED_ACCESS_READ,
                         SQL_FILESTREAM_OPEN_NO_FLAGS,
                         txCtx,
                         (UInt32)txCtx.Length,
                         0);

                // open a Filestream to read the blob
                FileStream blob = new FileStream(
                        handle,
                        FileAccess.Read);

                byte[] buffer = new byte[(int)blob.Length];
                blob.Read(buffer, 0, buffer.Length);

               MemoryStream ms = new MemoryStream(buffer);
                Bitmap bmp = new Bitmap(ms);

                if (handle != null && !handle.IsClosed)
                    handle.Close();

                blob.Close();

               
                
              return bmp;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
            finally
            {
                if (cn != null)
                {
                    tx.Commit();
                    cn.Close();
                }
            }
            
        }



        public static void Put(string filename)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            SqlCommand cmd = null;
            SqlCommand cmd2 = null;
            bool bCommit = false;

            try
            {
                // read in the file to be saved as a blob in the database
                FileStream input = new FileStream(filename, FileMode.Open, FileAccess.Read);
                byte[] buffer = new byte[(int)input.Length];
                input.Read(buffer, 0, buffer.Length);

                cn = GetConnection();
                tx = cn.BeginTransaction();
                cmd = new SqlCommand("SpDocumentInsert", cn, tx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlParameter objSqlParam1 = new SqlParameter("@aDocumentNo", SqlDbType.Int);
                objSqlParam1.Value = "2";

                SqlParameter objSqlParam2 = new SqlParameter("@aExtension", SqlDbType.VarChar, 4);
                objSqlParam2.Value = System.IO.Path.GetExtension(input.Name);

                SqlParameter objSqlParam5 = new SqlParameter("@aDescription", SqlDbType.VarChar, 50);
                objSqlParam5.Value = System.IO.Path.GetFileNameWithoutExtension(input.Name);

                SqlParameter objSqlParam3 = new SqlParameter("@aLinkRowId", SqlDbType.BigInt);
                objSqlParam3.Value = "2";

                SqlParameter objSqlParam4 = new SqlParameter("@aLinkTableId", SqlDbType.VarChar, 4);
                objSqlParam4.Value = "AC42";

                SqlParameter objSqlParamOutput = new SqlParameter("@aDocument", SqlDbType.Binary, -1);
                objSqlParamOutput.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(objSqlParam2);
                cmd.Parameters.Add(objSqlParam1);
                cmd.Parameters.Add(objSqlParam3);
                cmd.Parameters.Add(objSqlParam4);
                cmd.Parameters.Add(objSqlParam5);
                cmd.Parameters.Add(objSqlParamOutput);


                SqlDataReader r = cmd.ExecuteReader(System.Data.CommandBehavior.SingleRow);
                r.Read();
                string DocumentGUID = r[0].ToString();
                string path = r[1].ToString();
                r.Close();
                
               

                // get the transaction context
                cmd2 = new SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", cn, tx);
                Object obj = cmd2.ExecuteScalar();
                byte[] txCtx = (byte[])obj;

                // open the filestream to the blob
                SafeFileHandle handle = OpenSqlFilestream(
                         path,
                         DESIRED_ACCESS_WRITE,
                         SQL_FILESTREAM_OPEN_NO_FLAGS,
                         txCtx,
                         (UInt32)txCtx.Length,
                         0);

                // open a Filestream to write the blob
                FileStream output = new FileStream(
                        handle,
                        FileAccess.Write,
                        buffer.Length,
                        false);
                output.Write(
                    buffer,
                    0,
                    buffer.Length);
                output.Close();

                if (handle != null && !handle.IsClosed)
                    handle.Close();

                bCommit = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (cn != null)
                {
                    switch (bCommit)
                    {
                        case true:
                            tx.Commit();
                            break;

                        case false:
                            tx.Rollback();
                            break;
                    }

                    cn.Close();
                }
            }
        }

        static SqlConnection GetConnection()
        {
            // TODO: edit connection string to specify your database
            //SqlConnection cn = new SqlConnection(
            //    @"Integrated Security=true;server=ankal-win7x64\sqlexpress;Initial Catalog=AnetCompany01");
           SqlConnection cn = new SqlConnection(
                @"Integrated Security=true;server=utv-server\sqlexpress;Initial Catalog=AnetCompany01");
           
           
            cn.Open();

            return cn;
        }


        static SqlConnection GetConnectionNo()
        {
            // TODO: edit connection string to specify your database
            SqlConnection cn = new SqlConnection();
            //    @"Integrated Security=true;server=ankal-win7x64\sqlexpress;Initial Catalog=AnetCompany01");
            Servers srv = new Servers();
            cn=srv.CreateConnection(@"ankal-win7x64\sqlexpress", "AnetCompany01", "Andersson", "Andersson");
            
            cn.Open();

            return cn;
        }

        public static void Delete(string blobID, long DocumentId, long LinkRowId, string LinkTableId)
        {
            SqlConnection cn = null;
            SqlTransaction tx = null;
            SqlCommand cmd = null;
         

            try
            {
                cn = GetConnection();
                tx = cn.BeginTransaction();
                cmd = new SqlCommand("SpDocumentDelete", cn, tx);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@aDocumentGUID", new System.Guid(blobID));
                cmd.Parameters.AddWithValue("@aDocumentId", DocumentId);
                cmd.Parameters.AddWithValue("@aLinkRowId", LinkRowId);
                cmd.Parameters.AddWithValue("@aLinkTableId", LinkTableId);
                SqlDataReader r = cmd.ExecuteReader();
                r.Close();
              
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (cn != null)
                {
                    tx.Commit();
                    cn.Close();
                }
            }
           
        }

        /// <summary>

        /// This method takes a Word document full path and new XPS document full path and name

        /// and returns the new XpsDocument

        /// </summary>

        /// <param name="wordDocName"></param>

        /// <param name="xpsDocName"></param>

        /// <returns></returns>

        public XpsDocument ConvertWordDocToXPSDoc(string wordDocName, string xpsDocName)
        {

            // Create a WordApplication and add Document to it

            Microsoft.Office.Interop.Word.Application

                wordApplication = new Microsoft.Office.Interop.Word.Application();

            wordApplication.Documents.Add(wordDocName);





            Document doc = wordApplication.ActiveDocument;

            // You must make sure you have Microsoft.Office.Interop.Word.Dll version 12.

            // Version 11 or previous versions do not have WdSaveFormat.wdFormatXPS option

            try
            {

                doc.SaveAs(xpsDocName, WdSaveFormat.wdFormatXPS);

                wordApplication.Quit();



                XpsDocument xpsDoc = new XpsDocument(xpsDocName, System.IO.FileAccess.Read);

                return xpsDoc;

            }

            catch (Exception exp)
            {

                string str = exp.Message;

            }

            return null;

        }


        public XpsDocument ConvertExcelDocToXPSDoc(string excelDocName, string xpsDocName)
        {

            string paramExportFilePath = xpsDocName;
            XlFixedFormatType paramExportFormat = XlFixedFormatType.xlTypeXPS;
            XlFixedFormatQuality paramExportQuality = 
            XlFixedFormatQuality.xlQualityStandard;
            bool paramOpenAfterPublish = false;
            bool paramIncludeDocProps = true;
            bool paramIgnorePrintAreas = true;
            object paramFromPage = Type.Missing;
            object paramToPage = Type.Missing;
            object paramMissing = Type.Missing;
            
               Microsoft.Office.Interop.Excel.Application

               excelApplication = new Microsoft.Office.Interop.Excel.Application();
                Workbook excelWorkBook = null;



            try
            {
                // Open the source workbook.
                excelWorkBook = excelApplication.Workbooks.Open(excelDocName,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing);

                // Save it in the target format.
                if (excelWorkBook != null)
                    excelWorkBook.ExportAsFixedFormat(paramExportFormat,
                        paramExportFilePath, paramExportQuality,
                        paramIncludeDocProps, paramIgnorePrintAreas, paramFromPage,
                        paramToPage, paramOpenAfterPublish,
                        paramMissing);
                
            }
            catch (Exception ex)
            {
                // Respond to the error.
            }
            finally
            {
                // Close the workbook object.
                if (excelWorkBook != null)
                {
                    excelWorkBook.Close(false, paramMissing, paramMissing);
                    excelWorkBook = null;
                }

                // Quit Excel and release the ApplicationClass object.
                if (excelApplication != null)
                {
                    excelApplication.Quit();
                    excelApplication = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();

            }
            XpsDocument xpsDoc = new XpsDocument(xpsDocName, System.IO.FileAccess.Read);

            return xpsDoc;

          
        }

        public string ConvertExcelDocToPdfDoc(string excelDocName, string pdfDocName)
        {

            string paramExportFilePath = pdfDocName;
            XlFixedFormatType paramExportFormat = XlFixedFormatType.xlTypePDF;
            XlFixedFormatQuality paramExportQuality =
            XlFixedFormatQuality.xlQualityStandard;
            bool paramOpenAfterPublish = false;
            bool paramIncludeDocProps = true;
            bool paramIgnorePrintAreas = true;
            object paramFromPage = Type.Missing;
            object paramToPage = Type.Missing;
            object paramMissing = Type.Missing;

            Microsoft.Office.Interop.Excel.Application

            excelApplication = new Microsoft.Office.Interop.Excel.Application();
            Workbook excelWorkBook = null;



            try
            {
                // Open the source workbook.
                excelWorkBook = excelApplication.Workbooks.Open(excelDocName,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing, paramMissing, paramMissing,
                    paramMissing, paramMissing);

                // Save it in the target format.
                if (excelWorkBook != null)
                    excelWorkBook.ExportAsFixedFormat(paramExportFormat,
                        paramExportFilePath, paramExportQuality,
                        paramIncludeDocProps, paramIgnorePrintAreas, paramFromPage,
                        paramToPage, paramOpenAfterPublish,
                        paramMissing);

            }
            catch (Exception ex)
            {
                // Respond to the error.
            }
            finally
            {
                // Close the workbook object.
                if (excelWorkBook != null)
                {
                    excelWorkBook.Close(false, paramMissing, paramMissing);
                    excelWorkBook = null;
                }

                // Quit Excel and release the ApplicationClass object.
                if (excelApplication != null)
                {
                    excelApplication.Quit();
                    excelApplication = null;
                }

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();

            }
            

            return pdfDocName;

          

        }

        public string ConvertWordDocToPdfDoc(string wordDocName, string pdfDocName)
        {

              // Create a WordApplication and add Document to it

            Microsoft.Office.Interop.Word.Application

                wordApplication = new Microsoft.Office.Interop.Word.Application();

            wordApplication.Documents.Add(wordDocName);





            Document doc = wordApplication.ActiveDocument;

            // You must make sure you have Microsoft.Office.Interop.Word.Dll version 12.

            // Version 11 or previous versions do not have WdSaveFormat.wdFormatXPS option

            try
            {

                doc.SaveAs(pdfDocName, WdSaveFormat.wdFormatPDF);

                wordApplication.Quit();



                return pdfDocName;

            }

            catch (Exception exp)
            {

                string str = exp.Message;

            }

            return null;

        


        }

        /// <summary>
        /// Function to get object from byte array
        /// </summary>
        /// <param name="_ByteArray">byte array to get object</param>
        /// <returns>object</returns>
        //public object ByteArrayToObject(byte[] _ByteArray)
        //{
        //    try
        //    {
        //        // convert byte array to memory stream
        //        System.IO.MemoryStream _MemoryStream = new System.IO.MemoryStream(_ByteArray);

        //        // create new BinaryFormatter
        //        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter _BinaryFormatter
        //                    = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

        //        // set memory stream position to starting point
        //        _MemoryStream.Position = 0;

        //        // Deserializes a stream into an object graph and return as a object.
        //        return _BinaryFormatter.Deserialize(_MemoryStream);
        //    }
        //    catch (Exception _Exception)
        //    {
        //        // Error
        //      MessageBox.Show(_Exception.ToString());
        //    }

        //    // Error occured, return null
        //    return null;
        //}

        /// <summary>
        /// Convert a byte array to an Object.
        /// Copied from http://snippets.dzone.com/posts/show/3897
        /// </summary>
        /// <param name="arrBytes">
        /// The byte[] array to be converted.
        /// </param>
        /// <returns>
        /// The object to which the byte array is converted.
        /// </returns>
        public static object ByteArrayToObject(byte[] arrBytes)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();

            memStream.Write(arrBytes, 0, arrBytes.Length);
            memStream.Seek(0, SeekOrigin.Begin);

            object obj = (object)binForm.Deserialize(memStream);

            return obj;
        }





    }
}
