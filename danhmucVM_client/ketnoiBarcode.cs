﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using System.Data;

namespace danhmucVM_client
{
    class ketnoiBarcode
    {
        #region khoitao
        private ketnoiBarcode()
        {
            string connstring = @"Data source=databarcode.db;version=3;new=false";
            connection = new SQLiteConnection(connstring);
        }

        private static SQLiteConnection connection = null;

        private static ketnoiBarcode _instance = null;
        public static ketnoiBarcode Khoitao()
        {
            if (_instance == null)
                _instance = new ketnoiBarcode();
            return _instance;
        }
        public void Open()
        {
            if (connection.State != ConnectionState.Open)
            {
                try
                {
                    connection.Open();
                }
                catch (Exception)
                {

                    return;
                }

            }
        }

        public void Close()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
        #endregion

        public string laymasp(string barcode)
        {
            string sql = string.Format("SELECT masp FROM data WHERE barcode='{0}'", barcode);
            string h = null;
            SQLiteCommand cmd = new SQLiteCommand(sql, connection);
            Open();
            SQLiteDataReader dtr = cmd.ExecuteReader();
            while (dtr.Read())
            {
                h = dtr["masp"].ToString();
            }
            Close();
            if (h != null)
            {
                int vitri = h.IndexOf("-");
                h = h.Substring(0, vitri);
            }

            return h;
        }
    }
}
