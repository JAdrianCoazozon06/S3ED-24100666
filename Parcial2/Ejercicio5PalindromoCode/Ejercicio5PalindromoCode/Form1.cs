namespace Ejercicio5PalindromoCode
{
    public partial class Form1 : Form
    {
        char[] Pila = new char[1000];
        int TopePila = -1;
        int Longitud = 0;
        String Palabra = "";
        String PalabraV = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            PalabraV = "";
            TopePila = -1;
            Longitud = txtPalabra.Text.Length;
            Palabra = txtPalabra.Text;


            for (int i = 0; i < Longitud; i++)
            {
                TopePila++;
                Pila[TopePila] = Palabra[i];
            }

            for (int i = 0; i < Longitud; i++)
            {
                PalabraV = PalabraV + Pila[TopePila];
                    TopePila--;
            }
            if (Palabra == PalabraV)
            {
                MessageBox.Show("“Es una palabra Palindroma”"+Palabra+"  "+PalabraV);
            }
            else
            {
                MessageBox.Show("“Es una palabra no Palindroma”" + Palabra + "  " + PalabraV);
            }
        }
    }
}
