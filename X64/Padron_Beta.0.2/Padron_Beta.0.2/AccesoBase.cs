using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;


namespace Padron_Beta._0._2
{
    public class AccesoBase
    {
        public SQLiteConnection _conexion;
        public SQLiteCommand _comando;
        static List<Empresa> lista;
        public string GetFechaHasta;
        private int band;




        //public AccesoBase()
        //{
        //    this._conexion = new SQLiteConnection("Data Source = D:/PadronSQLite/PadronSQlite33.sqlite3"); //accedo a la propiedad que agregué. para instanciar al SqlConnection.
        //    this._comando = new SQLiteCommand(); //instancio el sqlcommand
        //    this._comando.CommandType = CommandType.Text; // le paso al CommandTye del sqlCommand instanciado, la propiedad del enumerado.
        //    this._comando.Connection = this._conexion; // le paso al Connection del sqlCommand instanciado, el objeto de tipo sqlConnection instanciado.


        //}
        public AccesoBase(string dire)
        {
            this._conexion = new SQLiteConnection("Data Source =" + dire); //accedo a la propiedad que agregué. para instanciar al SqlConnection.
            this._comando = new SQLiteCommand(); //instancio el sqlcommand
            this._comando.CommandType = CommandType.Text; // le paso al CommandTye del sqlCommand instanciado, la propiedad del enumerado.
            this._comando.Connection = this._conexion; // le paso al Connection del sqlCommand instanciado, el objeto de tipo sqlConnection instanciado.


        }


        static AccesoBase()
        {
            AccesoBase.lista = new List<Empresa>();
        }




        public Empresa BuscarEmpresa(Empresa aux)
        {
            foreach (Empresa item in lista)
            {
                if (item.cuit == aux.cuit)
                {
                    aux.fecha = item.fecha[0].ToString() + item.fecha[1].ToString() + "-" + item.fecha[2].ToString() + item.fecha[3].ToString() + "-" + item.fecha[4].ToString() + item.fecha[5].ToString() + item.fecha[6].ToString() + item.fecha[7].ToString();
                    aux.alicuota = item.alicuota;
                    aux.NroRetencion = item.NroRetencion;
                    return aux;
                }
            }
            return null;
        }



        public List<Empresa> TraerTodos()
        {
            try
            {
                _comando.CommandText = "SELECT field2,field4,field5,field9,field10 FROM Ret";
                this._conexion.Open();// ABRO LA CONEXION A LA BD

                SQLiteDataReader lector;
                lector = this._comando.ExecuteReader();

                while (lector.Read())
                {
                    Empresa e = new Empresa();
                    e.fecha = lector["field2"].ToString();
                    e.cuit = lector["field5"].ToString();
                    e.alicuota = lector["field9"].ToString();
                    e.NroRetencion = lector["field10"].ToString();
                    if (band == 0)
                    {
                        GetFechaHasta = lector["field4"].ToString();
                        band++;
                    }
                    lista.Add(e);
                }

                lector.Close();
                this._conexion.Close();

            }
            catch
            {
                MessageBox.Show("No se pudo conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return lista;

        }

        public Empresa buscarCuit(Empresa aux)
        {
            try
            {
                _comando.CommandText = "SELECT field2,field4,field5,field9,field10 FROM Ret";
                this._conexion.Open();// ABRO LA CONEXION A LA BD

                SQLiteDataReader lector;
                lector = this._comando.ExecuteReader();

                while (lector.Read())
                {

                    if (aux.cuit == lector["field5"].ToString())
                    {
                        aux.fecha = lector["field2"].ToString();
                        aux.cuit = lector["field5"].ToString();
                        aux.alicuota = lector["field9"].ToString();
                        aux.NroRetencion = lector["field10"].ToString();
                        if (band == 0)
                        {
                            GetFechaHasta = lector["field4"].ToString();
                            band++;
                        }
                    }
                }
                lector.Close();
                this._conexion.Close();

            }
            catch
            {
                MessageBox.Show("No se pudo conectar con la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return aux;

        }



        public string Mostrar(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (Empresa item in AccesoBase.lista)
            {
                if (s == item.cuit)
                {
                    sb.AppendLine(item.ToString());
                    return sb.ToString();
                }
            }
            return "Nada";
        }


    }
}
