using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PractiaFiguraHerencia
{
    public partial class Form1 : Form
    {

        private String valueSelected = "";
        float value1 = 0;
        float value2 = 0;
        Figura figura;
        protected bool calculosRealizados = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            figurebox.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrarOpciones();
        }

        /// <summary>
        /// Método encargado de visualizar los diferentes componentes del Form en 
        /// función a lo que haya elegido el usuario en la ComboBox.
        /// </summary>
        private void mostrarOpciones()
        {

            if (figurebox.SelectedItem == null)
            {
                MessageBox.Show("¡Selecciona una figura!");
            }
            else if (figurebox.SelectedItem.ToString() == "Triángulo")
            {
                label1.Visible = false;
                valueSelected = figurebox.SelectedItem.ToString();
                figuralbl.Visible = true;
                figuralbl.Text = valueSelected;
                value1lbl.Text = "Base";
                value1lbl.Visible = true;
                value1box.Visible = true;
                value2lbl.Text = "Altura";
                value2lbl.Visible = true;
                value2box.Visible = true;
                figurebox.Visible = false;
                btnCalcular.Visible = true;
                btnReset.Visible = true;
                btnSelect.Visible = false;
            }
            else if (figurebox.SelectedItem.ToString() == "Círculo")
            {
                label1.Visible = false;
                valueSelected = figurebox.SelectedItem.ToString();
                figuralbl.Visible = true;
                figuralbl.Text = valueSelected;
                value1lbl.Text = "Radio";
                value1lbl.Visible = true;
                value1box.Visible = true;
                figurebox.Visible = false;
                btnSelect.Visible = false;
                btnCalcular.Visible = true;
                btnReset.Visible = true;
            }
            else if (figurebox.SelectedItem.ToString() == "Rectángulo")
            {
                label1.Visible = false;
                valueSelected = figurebox.SelectedItem.ToString();
                figuralbl.Visible = true;
                figuralbl.Text = valueSelected;
                value1lbl.Text = "Base";
                value1lbl.Visible = true;
                value1box.Visible = true;
                value2lbl.Text = "Altura";
                value2lbl.Visible = true;
                value2box.Visible = true;
                figurebox.Visible = false;
                btnSelect.Visible = false;
                btnCalcular.Visible = true;
                btnReset.Visible = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            realizarCalculos();
            if (calculosRealizados) { 
            resultlbl.Text = "Perímetro :   " + value1 + "   Área :  " + value2;
            resultlbl.Visible = true;
            }
        }

        /// <summary>
        /// Método encargado de calcular el área y perímetro de cada figura en función
        /// a sus valores.
        /// </summary>
        private void realizarCalculos()
        {
            if(valueSelected == "Triángulo")
            {
                float.TryParse(value1box.Text, out value1);
                float.TryParse(value2box.Text, out value2);
                try { 
                figura = new Triángulo(value1, value2);
                figura.calcularPerímetro();
                figura.calcularÁrea();
                value1 = figura.getPerímetro();
                value2 = figura.getÁrea();
                calculosRealizados = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnReset.PerformClick();
                    calculosRealizados = false;
                }
                
            }else if(valueSelected == "Rectángulo")
            {
                float.TryParse(value1box.Text, out value1);
                float.TryParse(value2box.Text, out value2);
                try
                {
                    figura = new Rectángulo(value1, value2);
                    figura.calcularPerímetro();
                    figura.calcularÁrea();
                    value1 = figura.getPerímetro();
                    value2 = figura.getÁrea();
                    calculosRealizados = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnReset.PerformClick();
                    calculosRealizados = false;
                }
            }
            else if(valueSelected == "Círculo")
            {
                float.TryParse(value1box.Text, out value1);
                try
                {
                    figura = new Círculo(value1);
                    figura.calcularPerímetro();
                    figura.calcularÁrea();
                    value1 = figura.getPerímetro();
                    value2 = figura.getÁrea();
                    calculosRealizados = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    btnReset.PerformClick();
                    calculosRealizados = false;
                }
            }
        }

        /// <summary>
        /// Este botón se encargará de resetear el formulario para elegir otra figura
        /// geométrica diferente. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            value1lbl.Visible = false;
            value1box.Visible = false;
            value2box.Visible = false;
            value2lbl.Visible = false;
            label1.Visible = true;
            figurebox.Enabled = true;
            figurebox.Visible = true;
            btnCalcular.Visible = false;
            btnReset.Visible = false;
            figuralbl.Visible = false;
            resultlbl.Visible = false;
            btnSelect.Visible = true;
            value1box.Text = "";
            value2box.Text = "";
        }
    }
}
