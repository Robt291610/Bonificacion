using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bonificacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            int horas_normales, horas_extra;
            double pago_por_hora, pago_hora_extra;
            byte nhijos;
            double sueldo_bruto, sueldo_neto, bonificacion;
            bool marcado;

            horas_normales = Convert.ToInt32(txthorasnormales.Text);
            horas_extra = Convert.ToInt32(txthorasextratrabajadas.Text);
            pago_por_hora = Convert.ToDouble(txtpagoporhoranormal.Text);
            pago_hora_extra = Convert.ToDouble(txtpagoporhoraextra.Text);
            nhijos = Convert.ToByte(nphijos.Value);
            marcado = Convert.ToBoolean(checkbonificacion.Checked);

            bonificacion = 0.0D;

            sueldo_bruto = (horas_normales * pago_por_hora) + (horas_extra * pago_hora_extra);


            if (marcado == true) 
            {
                bonificacion = nhijos * 20;
            
            }

            sueldo_neto = sueldo_bruto + bonificacion;

            txtsueldobruto.Text = Convert.ToString(sueldo_bruto);
            txtbonificacion.Text = Convert.ToString(bonificacion);
            txtsueldoneto.Text = Convert.ToString(sueldo_neto);



        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txthorasnormales.Clear();
            txtpagoporhoranormal.Clear();
            txthorasextratrabajadas.Clear();
            txtpagoporhoraextra.Clear();
            nphijos.Value = 0;
            txtsueldobruto.Clear();
            txtbonificacion.Clear();
            txtsueldoneto.Clear();
            checkbonificacion.Checked = false;



        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
