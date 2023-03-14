namespace Ej6Aleatorios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void CreateNumber(object sender, EventArgs e)
        {
            label2.Text = "El numero introducido no aparece";
            int cantidad = 0;
            int numero = (int)numericUpDown1.Value;
            label1.Text = "";
            int[] lista_aleatorios = new int[20];
            Random aleatorio = new Random();
            for (int i = 0; i < 20; i++) {
                
                lista_aleatorios[i] = aleatorio.Next(0, 99);
                label1.Text += lista_aleatorios[i] + " ";
                if (numero == lista_aleatorios[i])
                {
                    cantidad++;
                    label2.Text = "El numero introducido y aparece " + cantidad + "veces";
                }
            }
            
            

        }

       
    }
    
}