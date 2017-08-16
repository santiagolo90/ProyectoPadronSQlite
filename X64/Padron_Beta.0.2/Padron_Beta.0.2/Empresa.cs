using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padron_Beta._0._2
{

    public class Empresa
    {

        public string tipo;
        public string fecha;
        public string desde;
        public string hasta;
        public string cuit;
        public string tipoC;
        public string marcaABS;
        public string marcaCA;
        public string alicuota;
        public string NroRetencion;
        public string campo10;

        //public Empresa(string tipo, string fecha, string desde, string hasta, string cuit, string tipoC, string marcaABS, string marcaCA, string alicuota, string NroRetencion, string campo10)
        //    : this()
        //{
        //    this.tipo = tipo;
        //    this.fecha = fecha;
        //    this.desde = desde;
        //    this.hasta = hasta;
        //    this.cuit = cuit;
        //    this.tipoC = tipoC;
        //    this.marcaABS = marcaABS;
        //    this.marcaCA = marcaCA;
        //    this.alicuota = alicuota;
        //    this.NroRetencion = NroRetencion;
        //    this.campo10 = campo10;

        //}
        public Empresa(string fecha, string hasta, string cuit, string alicuota, string NroRetencion)
            : this(cuit)
        {
            this.fecha = fecha;
            this.hasta = hasta;
            this.alicuota = alicuota;
            this.NroRetencion = NroRetencion;

        }
        public Empresa(string cuit)
            : this()
        {
            this.cuit = cuit;
        }

        public Empresa()
        { }


        public override string ToString()
        {
            try
            {

                StringBuilder sb = new StringBuilder();
                //sb.AppendLine("Fecha: " + this.fecha);
                sb.AppendLine("Fecha: " + this.fecha[0] + this.fecha[1] + "-" + this.fecha[2] + this.fecha[3] + "-" + this.fecha[4] + this.fecha[5] + this.fecha[6] + this.fecha[7]);
                sb.AppendLine("CUIT " + this.cuit);
                sb.AppendLine("Alicuota: " + this.alicuota);
                sb.AppendLine("Numero Retencion: " + this.NroRetencion);
                //sb.AppendLine((aux[0] + aux[1] + "-" + aux[2] + aux[3]));

                return sb.ToString();
            }
            catch
            {
                //MessageBox.Show("Error al mostrar Empresa");
                return "";
            }
        }
    }
}
