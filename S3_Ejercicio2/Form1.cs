namespace S3_Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string categoria = this.txtCat.Text;
            int dias = int.Parse(this.txtDias.Text);

            switch (categoria)
            {
                case "tres estrellas":
                    switch (dias)
                    {
                        case < 0:
                            txtCosto.Text = "ERROR";
                            break;
                        case <= 5:
                            double precio = dias * 100 + dias * 7;
                            txtCosto.Text = precio.ToString() + " soles";
                            break;
                        case <= 10:
                            precio = dias * 85 + dias * 7;
                            txtCosto.Text = precio.ToString() + " soles";
                            break;
                        case >= 11:
                            precio = dias * 70 + dias * 7;
                            txtCosto.Text = precio.ToString() + " soles";
                            break;
                    }
                    break;
            }
            switch (categoria)
            {
                case "cinco estrellas":
                    switch (dias)
                    {
                        case < 0:
                            txtCosto.Text = "ERROR";
                            break;
                        case <= 5:
                            double precio = dias * 300 + dias * 7;
                            txtCosto.Text = precio.ToString() + " soles";
                            break;
                        case <= 10:
                            precio = dias * 270 + dias * 7;
                            txtCosto.Text = precio.ToString() + " soles";
                            break;
                        case >= 11:
                            precio = dias * 250 + dias * 7;
                            txtCosto.Text = precio.ToString() + " soles";
                            break;
                    }
                    break;
            }
 
        }
    }
}