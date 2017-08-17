using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Padron_Beta._0._2
{
    public partial class Form1 : Form
    {

        AccesoBase ab = new AccesoBase("D:/PadronSQLite/PadronSQlite3.sqlite3");

        public Form1()
        {
            InitializeComponent();
            rtxt.Text = "Carga Lista";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

                rtxt.Text = ab.Mostrar(txtBuscar.Text);

                Empresa aux = new Empresa(txtBuscar.Text);
                ab.BuscarEmpresa(aux);

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dgv);
                fila.Cells[0].Value = aux.fecha;
                fila.Cells[1].Value = aux.cuit;
                fila.Cells[2].Value = aux.alicuota;
                fila.Cells[3].Value = aux.NroRetencion;
                this.dgv.Rows.Add(fila);

        }

        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            
            try
            {
                progressBar1.Value = 0;
                Empresa aux = new Empresa(txtBuscar.Text);
                ab.buscarCuit(aux);
                rtxt.Text = aux.ToString();
                string FechaSeparada = aux.fecha[0].ToString() + aux.fecha[1].ToString() + "-" + aux.fecha[2].ToString() + aux.fecha[3].ToString() + "-" + aux.fecha[4].ToString() + aux.fecha[5].ToString() + aux.fecha[6].ToString() + aux.fecha[7].ToString();
                lblFechaHasta.Text = ab.GetFechaHasta[0].ToString() + ab.GetFechaHasta[1].ToString() + "-" + ab.GetFechaHasta[2].ToString() + ab.GetFechaHasta[3].ToString() + "-" + ab.GetFechaHasta[4].ToString() + ab.GetFechaHasta[5].ToString() + ab.GetFechaHasta[6].ToString() + ab.GetFechaHasta[7].ToString();

                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(this.dgv);
                fila.Cells[0].Value = FechaSeparada;
                fila.Cells[1].Value = aux.cuit;
                fila.Cells[2].Value = aux.alicuota;
                fila.Cells[3].Value = aux.NroRetencion;
                this.dgv.Rows.Add(fila);
                progressBar1.Increment(100);
            }
            catch
            {
                MessageBox.Show("Error al crear DataGridView" ,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            ProgressBar barra = new ProgressBar();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            
            try
            {
                progressBar1.Value = 0;
                rtxt.Text = "Cargando Base de Datos, Espere!!!";
                ab.TraerTodos();
                if ( txtBuscar.Text != "")
                {

                    rtxt.Text = "Listo para usar";
                }
                else
                    rtxt.Text = "";
                progressBar1.Increment(100);

                lblFechaHasta.Text = ab.GetFechaHasta[0].ToString() + ab.GetFechaHasta[1].ToString() + "-" + ab.GetFechaHasta[2].ToString() + ab.GetFechaHasta[3].ToString() + "-" + ab.GetFechaHasta[4].ToString() + ab.GetFechaHasta[5].ToString() + ab.GetFechaHasta[6].ToString() + ab.GetFechaHasta[7].ToString();



            }
            catch
            {
                MessageBox.Show("Falta la base de datos o no es un cuit valido","Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void abrirBaseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Archivo = new OpenFileDialog();
            Archivo.Title = "Seleccione una base de datos SQLite3";
            Archivo.Filter = "sqlite3 Files (.sqlite3)|*.sqlite3|All Files (*.*)|*.*";
            Archivo.Multiselect = false; // elimina la seleccion multiple de archivos
            Archivo.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); //directorio por defecto

            if (Archivo.ShowDialog() == DialogResult.OK)// si todo esta ok puedo seleccionar el archivo y actualizó la ubicación de la Base SQlite3
            {
                ab._conexion = new System.Data.SQLite.SQLiteConnection("Data Source =" + Archivo.FileName);
                ab._comando = new System.Data.SQLite.SQLiteCommand(); //instancio el sqlcommand
                ab._comando.CommandType = CommandType.Text; // le paso al CommandTye del sqlCommand instanciado, la propiedad del enumerado.
                ab._comando.Connection = ab._conexion; // le paso al Connection del sqlCommand instanciado, el objeto de tipo sqlConnection instanciado.

            }
            Archivo.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)//captura la tecla enter y realiza la busqueda
        {
            if(e.KeyChar == '\r' && txtBuscar.Text != "")
            btnBuscar2.PerformClick();
            
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)//Limpia las columnas del DataGrid
        {
            this.dgv.Rows.Clear();
            this.dgv.Refresh();
        }


    }
}
