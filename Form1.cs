namespace S3_Ejercicio02_ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int categ = int.Parse(txtcateg.Text);
            int dias = int.Parse(txtdias.Text);
            float precio = 0.00f;
            switch (categ)
            {
                case 3:
                    if (dias <= 5)
                    {
                        precio = 100.00f * dias;

                    }
                    else if (dias <= 10)
                    {
                        precio = 85.00f * dias;
                    }
                    else if ((dias >= 11))
                    {
                        precio = 70.00f * dias;
                    }
                    break;
                case 5:
                    if (dias <= 5)
                    {
                        precio = 300.00f * dias;

                    }
                    else if (dias <= 10)
                    {
                        precio = 270.00f * dias;
                    }
                    else if ((dias >= 11))
                    {
                        precio = 250.00f * dias;
                    }
                    break;
            }
            precio += dias * 7.00f;
            lblresult.Text= "el precio sería: " + precio;
        }
    }
}