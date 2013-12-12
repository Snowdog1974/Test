using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using System.Data.SqlTypes;
using System.IO;
using SystemAndersson.Anet.BI.LoginSQL;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace Filestreamtest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        const UInt32 DESIRED_ACCESS_READ = 0x00000000;
        const UInt32 DESIRED_ACCESS_WRITE = 0x00000001;
        const UInt32 DESIRED_ACCESS_READWRITE = 0x00000002;

        const UInt32 SQL_FILESTREAM_OPEN_NO_FLAGS = 0x00000000;
        bool bCommit = false;

        [DllImport("sqlncli10.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        static extern SafeFileHandle OpenSqlFilestream(
                    string FilestreamPath,
                    UInt32 DesiredAccess,
                    UInt32 OpenOptions,
                    byte[] FilestreamTransactionContext,
                    UInt32 FilestreamTransactionContextLength,
                    Int64 AllocationSize);    


        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           Servers srv = new Servers();
         //  SqlConnection conn =srv.CreateConnection(@"utv-server\sqlexpress","AnetCompany01");
           SqlConnection conn =srv.CreateConnection(@"ankal-win7x64\sqlexpress","AnetCompany01");
           
           savefilestream(conn, new FileStream( @"C:\temp\Reports\noparams.rpt",
           FileMode.Open, FileAccess.Read));
        }


        //public void savefilestream(SqlConnection objSqlCon, FileStream file)
        //{
        //byte[] buffer = new byte[(int)file.Length];   
        //    file.Read(buffer, 0, buffer.Length);

        //    if (file.Length > 0)
        //    {

        //        objSqlCon.Open();
        //        SqlTransaction objSqlTran = objSqlCon.BeginTransaction();

        //        SqlCommand objSqlCmd = new SqlCommand("FileAdd", objSqlCon, objSqlTran);
        //        objSqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter objSqlParam1 = new SqlParameter("@SystemNumber", SqlDbType.Int);
        //        objSqlParam1.Value = "1";

        //        SqlParameter objSqlParam2 = new SqlParameter("@FileType", SqlDbType.VarChar, 4);
        //        objSqlParam2.Value = System.IO.Path.GetExtension(textBox1.Text);

        //        SqlParameter objSqlParamOutput = new SqlParameter("@filepath", SqlDbType.VarChar, -1);
        //        objSqlParamOutput.Direction = ParameterDirection.Output;

        //        objSqlCmd.Parameters.Add(objSqlParam2);
        //        objSqlCmd.Parameters.Add(objSqlParam1);
        //        objSqlCmd.Parameters.Add(objSqlParamOutput);


        //        objSqlCmd.ExecuteNonQuery();

        //        string Path = objSqlCmd.Parameters["@filepath"].Value.ToString();

        //        objSqlCmd = new SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objSqlCon, objSqlTran);

        //        byte[] objContext = (byte[])objSqlCmd.ExecuteScalar();


        //        SqlFileStream objSqlFileStream = new SqlFileStream(Path, objContext, FileAccess.Write);

        //        objSqlFileStream.Write(buffer, 0, buffer.Length);
        //        objSqlFileStream.Close();

        //        objSqlTran.Commit();
        //    }
        //}

        //public void savefilestream(SqlConnection objSqlCon, FileStream file)
        //{
        //    byte[] buffer = new byte[(int)file.Length];
        //    file.Read(buffer, 0, buffer.Length);

        //    if (file.Length > 0)
        //    {

        //        objSqlCon.Open();
        //        SqlTransaction objSqlTran = objSqlCon.BeginTransaction();

        //        SqlCommand objSqlCmd = new SqlCommand("SpDocumentInsert", objSqlCon, objSqlTran);
        //        objSqlCmd.CommandType = CommandType.StoredProcedure;

        //        SqlParameter objSqlParam1 = new SqlParameter("@aDocumentNo", SqlDbType.Int);
        //        objSqlParam1.Value = "1";

        //        SqlParameter objSqlParam2 = new SqlParameter("@aDescription", SqlDbType.VarChar, 4);
        //        objSqlParam2.Value = System.IO.Path.GetExtension(file.Name);

        //        SqlParameter objSqlParam3 = new SqlParameter("@aLinkRowId", SqlDbType.BigInt);
        //        objSqlParam3.Value = "1";

        //        SqlParameter objSqlParam4 = new SqlParameter("@aLinkTableId", SqlDbType.VarChar, 4);
        //        objSqlParam4.Value = "AC01";
                
        //        SqlParameter objSqlParamOutput = new SqlParameter("@aDocument", SqlDbType.Binary, -1);
        //        objSqlParamOutput.Direction = ParameterDirection.Output;

        //        objSqlCmd.Parameters.Add(objSqlParam2);
        //        objSqlCmd.Parameters.Add(objSqlParam1);
        //        objSqlCmd.Parameters.Add(objSqlParam3);
        //        objSqlCmd.Parameters.Add(objSqlParam4);
        //        objSqlCmd.Parameters.Add(objSqlParamOutput);


        //        objSqlCmd.ExecuteNonQuery();

        //        string Path = objSqlCmd.Parameters["@filepath"].Value.ToString();

        //        objSqlCmd = new SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()", objSqlCon, objSqlTran);

        //        byte[] objContext = (byte[])objSqlCmd.ExecuteScalar();


        //        SqlFileStream objSqlFileStream = new SqlFileStream(Path, objContext, FileAccess.Write);

        //        objSqlFileStream.Write(buffer, 0, buffer.Length);
        //        objSqlFileStream.Close();

        //        objSqlTran.Commit();
        //    }
        //}

      

        public void savefilestream(SqlConnection objSqlCon, FileStream file)
        {
            objSqlCon.Open();
            byte[] buffer = new byte[(int)file.Length];
            file.Read(buffer, 0, buffer.Length);
            // (2) insert empty blob in the database

            SqlTransaction tx = objSqlCon.BeginTransaction();
            SqlCommand cmd = new SqlCommand("SpDocumentInsert", objSqlCon, tx);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
           
            SqlParameter objSqlParam1 = new SqlParameter("@aDocumentNo", SqlDbType.Int);
                    objSqlParam1.Value = "2";

                    SqlParameter objSqlParam2 = new SqlParameter("@aDescription", SqlDbType.VarChar, 4);
                    objSqlParam2.Value = System.IO.Path.GetExtension(file.Name);

                    SqlParameter objSqlParam3 = new SqlParameter("@aLinkRowId", SqlDbType.BigInt);
                    objSqlParam3.Value = "2";

                    SqlParameter objSqlParam4 = new SqlParameter("@aLinkTableId", SqlDbType.VarChar, 4);
                    objSqlParam4.Value = "AC01";

                    SqlParameter objSqlParamOutput = new SqlParameter("@aDocument", SqlDbType.Binary, -1);
                    objSqlParamOutput.Direction = ParameterDirection.Output;

                    cmd.Parameters.Add(objSqlParam2);
                    cmd.Parameters.Add(objSqlParam1);
                    cmd.Parameters.Add(objSqlParam3);
                    cmd.Parameters.Add(objSqlParam4);
                    cmd.Parameters.Add(objSqlParamOutput);
            
            
            SqlDataReader r = cmd.ExecuteReader(
           System.Data.CommandBehavior.SingleRow);
            r.Read();
            string DocumentGUID = r[0].ToString();
            string path = r[1].ToString();
            r.Close();
            // (3) get the transaction context
           SqlCommand cmd2 = new SqlCommand("SELECT GET_FILESTREAM_TRANSACTION_CONTEXT()",
               objSqlCon, tx);
            Object obj = cmd2.ExecuteScalar();
            byte[] txCtx = (byte[])obj;
            // (4) open the filestream to the blob
            SafeFileHandle handle = OpenSqlFilestream(path, DESIRED_ACCESS_WRITE,SQL_FILESTREAM_OPEN_NO_FLAGS, txCtx, (UInt32)txCtx.Length, 0);

            // (5) open a Filestream to write the blob
            FileStream output = new FileStream(handle, FileAccess.Write, buffer.Length, false);
            output.Write(buffer, 0, buffer.Length);
            output.Close();


            if (handle != null && !handle.IsClosed)
                handle.Close();

            bCommit = true;

            //SqlFileStream objSqlFileStream = new SqlFileStream(path, txCtx, FileAccess.Write);

            //        objSqlFileStream.Write(buffer, 0, buffer.Length);
            //        objSqlFileStream.Close();

            //        tx.Commit();
            //        objSqlCon.Close();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {

          byte[] b = ReadFile(textBox1.Text);
           
            string s = Encoding.ASCII.GetString(b);
          
            
            MessageBox.Show(s);

            //StreamReader streamReader = new StreamReader(textBox1.Text);
            //string text = streamReader.ReadToEnd();
            //streamReader.Close();
            //MessageBox.Show(text);


        }

        public static byte[] ReadFile(string filePath)
        {
            byte[] buffer;
            FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {
                int length = (int)fileStream.Length;  // get file length
                buffer = new byte[length];            // create buffer
                int count;                            // actual number of bytes read
                int sum = 0;                          // total number of bytes read

                // read until Read method returns 0 (end of the stream has been reached)
                while ((count = fileStream.Read(buffer, sum, length - sum)) > 0)
                    sum += count;  // sum is a buffer offset for next reading
            }
            finally
            {
                fileStream.Close();
            }
            return buffer;
        }


    }
}
