using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_EJECUCION
{
    public partial class Form1 : Form
    {//textbox nombre completo
     //crear instancia del control texBox
        #region
        TextBox txtNombre = new TextBox();
        TextBox txtCURP = new TextBox();
        TextBox txtcorreo = new TextBox();
        TextBox txtNumerotelefono1 = new TextBox();
        #endregion
        public Form1()
        {//crear cajas de texto en tiempo de ejecución
            InitializeComponent();
            this.txtNumerotelefono1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerotelefono1_KeyPress);
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress); 
            this.txtCURP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCURP_KeyPress);
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {   //Entidad federativa  utilisamos un COMBOBOX
            //creamos la instancia del control 
            ComboBox cmBestado = new ComboBox();
            cmBestado.Font = new Font("Times New Roman", 14);
            //sirve para que se posicione arriba 
            cmBestado.Top = Left = 350;
            //sirve para que se posicione a la izquierda  
            cmBestado.Left = 200;
            this.Controls.Add(cmBestado);
            //Agregar al combobox las entidades federativas o estados que en este caso seran los de méxico
            cmBestado.Items.Add("Aguascalientes");
            cmBestado.Items.Add("Baja California");
            cmBestado.Items.Add("Baja California Sur");
            cmBestado.Items.Add("Campeche");
            cmBestado.Items.Add("Coahuila de Zaragoza");
            cmBestado.Items.Add("Colima");
            cmBestado.Items.Add("Chiapas");
            cmBestado.Items.Add("Chihuahua");
            cmBestado.Items.Add("Ciudad de México");
            cmBestado.Items.Add("Durango");
            cmBestado.Items.Add("Guanajuato");
            cmBestado.Items.Add("Guerrero");
            cmBestado.Items.Add("Hidalgo");
            cmBestado.Items.Add("Jalisco");
            cmBestado.Items.Add("México");
            cmBestado.Items.Add("Michoacán");
            cmBestado.Items.Add("Morelos");
            cmBestado.Items.Add("Nayarit");
            cmBestado.Items.Add(" Nuevo León");
            cmBestado.Items.Add("Oaxaca");
            cmBestado.Items.Add("Puebla");
            cmBestado.Items.Add("Querétaro");
            cmBestado.Items.Add("Quintana Roo");
            cmBestado.Items.Add("San Luis Potosí");
            cmBestado.Items.Add("Sinaloa");
            cmBestado.Items.Add("Sonora");
            cmBestado.Items.Add("Tabasco");
            cmBestado.Items.Add("Tamaulipas");
            cmBestado.Items.Add("Tlaxcala");
            cmBestado.Items.Add("Veracruz");
            cmBestado.Items.Add("Yucatán ");
            cmBestado.Items.Add("Zacatecas");

            //Agregamos un label para los estados de mexico
            //creamos la instancia del control
            Label lbEstado = new Label();
            lbEstado.Name = "lbEstado";
            lbEstado.Font = new Font("Times New Roman", 14);
            lbEstado.Top = Left = 350;
            lbEstado.Left = 20;
            lbEstado.Size = new Size(180, 20);
            lbEstado.Text = "Entidad Federativa";
            this.Controls.Add(lbEstado);


            //LABEL
            Label lbRegistrate = new Label();
            lbRegistrate.Name = "lbRegistrate";
            lbRegistrate.Font = new Font("Times New Roman", 14);
            lbRegistrate.Top = Left = 50;
            lbRegistrate.Left = 245;
            lbRegistrate.Size = new Size(200, 20);
            lbRegistrate.Text = "Registro de becas";
            this.Controls.Add(lbRegistrate);

            Label lbEdad = new Label();
            lbEdad.Name = "lbEdad";
            lbEdad.Font = new Font("Times New Roman", 14);
            lbEdad.Top = Left = 150;
            lbEdad.Left = 20;
            //lbEdad.Size = new Size(200, 20);
            lbEdad.Text = "Edad";
            this.Controls.Add(lbEdad);

            Label lbNombre = new Label();
            lbNombre.Name = "lbNombre";
            lbNombre.Font = new Font("Times New Roman", 14);
            lbNombre.Top = Left = 100;
            lbNombre.Left = 20;
            lbNombre.Text = "Nombre";
            this.Controls.Add(lbNombre);

            Label lbSexo = new Label();
            lbSexo.Font = new Font("Times New Roman", 14);
            lbSexo.Top = Left = 150;
            lbSexo.Left = 570;
            lbSexo.Text = "Hombre";
            lbSexo.Name = "lbSexoF";
            this.Controls.Add(lbSexo);

            Label lbSexoF = new Label();
            lbSexoF.Font = new Font("Times New Roman", 14);
            lbSexoF.Top = Left = 150;
            lbSexoF.Left = 440;
            lbSexoF.Text = "Mujer";
            lbSexoF.Name = "lbSexoF";
            this.Controls.Add(lbSexoF);

            //RADIOBUTTON-SEXO MUJER
            //sirve para que el ususario eliga su sexo si es mujer 
            //instanciamos el control
            RadioButton RbSexoF = new RadioButton();
           RbSexoF.Name = "RbSexoF";
            RbSexoF.Font = new Font("Times New Roman", 14);
            RbSexoF.Top = Left = 150;
            RbSexoF.Left = 420;
            //RbSexoF.Text = "Mujer";
            this.Controls.Add(RbSexoF);

            RadioButton RbSexoH = new RadioButton();
            RbSexoH.Name = "RbSexoH";
            RbSexoH.Font = new Font("Times New Roman", 14);
            //RbSexoF.Text = "Hombre";
            RbSexoH.Top = Left = 150;
            RbSexoH.Left = 550;
            //RbSexoF.Text = "Sexo";
            this.Controls.Add(RbSexoH);

            Label lbCurp = new Label();
            lbCurp.Name = "lbCurp";
            lbCurp.Font = new Font("Times New Roman", 14);
            lbCurp.Top = Left = 200;
            lbCurp.Left = 20;
            lbCurp.Text = "CURP";
            this.Controls.Add(lbCurp);

            Label lbNumtelefono = new Label();
            lbNumtelefono.Name = "lbNumtelefono";
            lbNumtelefono.Font = new Font("Times New Roman", 14);
            lbNumtelefono.Top = Left = 250;
            lbNumtelefono.Left = 20;
            lbNumtelefono.Size = new Size(180, 20);
            lbNumtelefono.Text = "Número de telefono";
            this.Controls.Add(lbNumtelefono);

            Label lbCorreo = new Label();
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Font = new Font("Times New Roman", 14);
            lbCorreo.Top = Left = 300;
            lbCorreo.Left = 20;
            lbCorreo.Size = new Size(180, 20);
            lbCorreo.Text = "Correo electrónico";
            this.Controls.Add(lbCorreo);

            //TEXBOX
            TextBox txtEdad =new  TextBox();
            txtEdad.Name = "Edad";
            txtEdad.Top = Left = 150;
            txtEdad.Left = 200;
            txtEdad.Size = new Size(80, 20);
            this.Controls.Add(txtEdad);

            TextBox txtNumerotelefono = new TextBox();
            txtNumerotelefono.Name = "Numero de telefono";
            txtNumerotelefono.Top = Left = 250;
            txtNumerotelefono.Left = 200;
            txtNumerotelefono.Size = new Size(200, 20);
            this.Controls.Add(txtNumerotelefono);

            TextBox txtCURP = new TextBox();
            txtCURP.Name = "CURP";
            txtCURP.Top = Left = 200;
            txtCURP.Left = 200;
            txtCURP.Size = new Size(200, 20);
            this.Controls.Add(txtCURP);

            TextBox txtcorreo = new TextBox();
            txtcorreo.Name = "correo";
            txtcorreo.Top = Left = 300;
            txtcorreo.Left = 200;
            txtcorreo.Size = new Size(200, 20);
            this.Controls.Add(txtcorreo);

            TextBox txtNombre1 = new TextBox();
            txtNombre1.Name = "Nombre";
            txtNombre1.Top = Left = 100;
            txtNombre1.Left = 200;
            txtNombre1.Size = new Size(200, 20);
            this.Controls.Add(txtNombre1);


            //Boton para registrarte
            Button buttonRegistro = new Button();
            buttonRegistro.Name = "Registrate";
            buttonRegistro.Text = buttonRegistro.Name;// "soy nuevo";
            buttonRegistro.Top = Left = 440;
            buttonRegistro.Left = 120;
            buttonRegistro.Size = new Size(100, 40);
            buttonRegistro.Font = new Font("Times New Roman", 14);
            //buttonRegistro.Height = 480;
            //buttonRegistro.Width = 185;
            buttonRegistro.FlatStyle = FlatStyle.Flat;
            //Este control hay que ponerlo en el from1
            this.Controls.Add(buttonRegistro);

            //GROUPBOX
            //GroupBox GroupBoxRegistro = new GroupBox();
            //GroupBoxRegistro.Name = "¡Registrate!";
            //GroupBoxRegistro.Size = new Size(Width, Height);
            //GroupBoxRegistro.Text = GroupBoxRegistro.Name;
            //GroupBoxRegistro.Font = new Font("Times New Roman", 20);
            //this.Controls.Add(GroupBoxRegistro);
        }
        private void txtCURP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 13 || e.KeyChar >= 16)
            {
                // devuelve un true si el evento esta controlado, en caso contrario un false
                e.Handled = true;
                //devuelve el valor
                return;
            }
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 31 || e.KeyChar >= 33)
            {
                // devuelve un true si el evento esta controlado, en caso contrario un false
                e.Handled = true;
                //devuelve el valor
                return;
            }
        }
        private void txtcorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 13 || e.KeyChar >= 16)
            {
                // devuelve un true si el evento esta controlado, en caso contrario un false
                e.Handled = true;
                //devuelve el valor
                return;
            }
        }
        private void txtNumerotelefono1_KeyPress(object sender, KeyPressEventArgs e)
        {//
            if (e.KeyChar >= 00 && e.KeyChar <= 07 || e.KeyChar >= 09 && e.KeyChar <= 31 || e.KeyChar >= 33)
            {
                // devuelve un true si el evento esta controlado, en caso contrario un false
                e.Handled = true;
                //devuelve el valor
                return;
            }
        }
    }
}
