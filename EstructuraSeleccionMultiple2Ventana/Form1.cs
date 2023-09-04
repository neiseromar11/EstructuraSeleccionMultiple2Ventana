namespace EstructuraSeleccionMultiple2Ventana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int categoria = int.Parse(txtcat.Text);

            float estadia = float.Parse(txtestadia.Text);

            float costo = 0.0f;
            switch (categoria)
            {
                case 1:
                    if (estadia >= 11)
                    {
                        costo = 70;

                    }
                    else if (estadia <= 10 && estadia >= 6)
                    {
                        costo = 85;
                    }
                    else
                    {
                        costo = 100;
                    }


                    break;
                case 2:
                    if (estadia >= 11)
                    {
                        costo = 250;

                    }
                    else if (estadia <= 10 && estadia >= 6)
                    {
                        costo = 270;
                    }
                    else
                    {
                        costo = 300;
                    }


                    break;

                default:
                    Console.WriteLine("Ingrese opciones validas");
                    break;

            }
            float total = estadia * costo;
            float desayuno = estadia * 7;
            float totalneto = total + desayuno;

            txttotal.Text = Convert.ToString(total);
            txtdesayuno.Text = Convert.ToString(desayuno);
            txttotalneto.Text = Convert.ToString(totalneto);




        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcat.Clear();
            txtdesayuno.Clear();
            txttotal.Clear();
            txtestadia.Clear();
            txttotalneto.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}