namespace frmCalculoIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //atribui o numero do campo peso à variável
            decimal peso = numPeso.Value;
            decimal altura = numAltura.Value;

            decimal imc = peso / (altura * altura);


            //MessageBox.Show(imc.ToString());
            lblImc.Text = imc.ToString("N2");
            int x = 0;
            if (imc >= 40)
            {
                x = 728;
                txtMensagem.Text = "Você está com obesidade mórbida";

            }

            else if ((imc >= 35) && (imc <= 39.9m))
            {
                x = 654;
                txtMensagem.Text = "Você está com obesidade grau 2";
                //lblSeta.Location = new Point(654, 393);
                lblSeta.Visible = true;

            }

            else if ((imc >= 30) && (imc <= 34.9m))
            {
                x = 576;
                txtMensagem.Text = "Você está com obesidade grau 1";
                //lblSeta.Location = new Point(576, 395);
                lblSeta.Visible = true;
            }

            else if ((imc >= 25) && (imc <= 29.9m))
            {
                x = 506;
                txtMensagem.Text = "Você está com sobrepeso";
                // lblSeta.Location = new Point(506, 395);
                lblSeta.Visible = true;
            }

            else if ((imc >= 18.5m) && (imc <= 24.9m))
            {
                x = 429;
                txtMensagem.Text = "Você está com o peso ideal";
                // lblSeta.Location = new Point(429, 395);
                lblSeta.Visible = true;
            }

            else if (imc < 18.5m)
            {
                x = 356;
                txtMensagem.Text = "Você está abaixo o peso ideal";
                lblSeta.Visible = true;
            }

            lblSeta.Location = new Point(x, 395);

        }


    }
}