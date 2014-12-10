using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DrawTools.Classes;
using DrawTools.GUI;
using System.Data.OleDb;

namespace DrawTools.Data {
    
    //this class handles everything with the database
    class AccessDB {

        private string conString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=imageDB.accdb;Persist Security Info=False;";
        private OleDbConnection con;
        private OleDbCommand command;
        private OleDbParameter param;
        private OleDbDataReader reader;

        public AccessDB()
        {
            try {
                con = new OleDbConnection(conString);
            }
            catch {

            }
        }

        public void Save(string name, byte[] blob)
        {
            con.Open();

            this.StartReader();

            while (reader.Read()) {

                if (name.Equals((string)reader["imagename"])) {

                    if (MessageBox.Show("This name is taken, do you want to overwrite?", "", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {

                            this.UpdateImage(name, blob);
                    }
                    
                    con.Close();
                    return;
                }
            }

            this.InsertImage(name, blob);

            con.Close();
        }

        public List<byte[]> LoadBlobs()
        {
            List<byte[]> listAllBlobs = new List<byte[]>();
            
            con.Open();
            
            this.StartReader();
            
            while (reader.Read())
                listAllBlobs.Add((byte[])reader["image"]);
                
            con.Close();

            return listAllBlobs;
        }
        
        public List<string> LoadNames()
        {
            List<string> listAllNames = new List<string>();
            
            con.Open();

            this.StartReader();

            while (reader.Read())
                listAllNames.Add((string)reader["imagename"]);

            con.Close();

            return listAllNames;
        }

        private void UpdateImage(string name, byte[] blob)
        {
            command = new OleDbCommand("UPDATE imagesTable SET [image]=@img WHERE [imagename]='" + name + "'", con);
            
            this.BlobParam(blob);
            command.ExecuteNonQuery();
        }

        private void InsertImage(string name, byte[] blob)
        {
            command = new OleDbCommand("insert into imagesTable values ('" + name + "', @img)", con);

            this.BlobParam(blob);
            command.ExecuteNonQuery();
        }

        private void StartReader()
        {
            command = new OleDbCommand("select * from imagesTable", con);
            reader = command.ExecuteReader();
        }

        private void BlobParam(byte[] blob)
        {
            param = new OleDbParameter("@img", OleDbType.LongVarBinary, blob.Length);
            param.Value = blob;
            command.Parameters.Add(param);
        }
    }
}
