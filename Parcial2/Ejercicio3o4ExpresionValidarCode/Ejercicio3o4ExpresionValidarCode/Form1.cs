namespace Ejercicio3o4ExpresionValidarCode
{
    public partial class Form1 : Form
    {
        char[] Pila = new char[1000];
        int TopePila = -1;
        int Longitud = 0;
        String Expresion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEvaluarExpresion_Click(object sender, EventArgs e)
        {
            TopePila = -1;
            Expresion = txtExpresion.Text;
            Longitud=Expresion.Length;
            for (int i = 0; i < Longitud; i++)
            {

                if (Expresion[i] == '(' || Expresion[i] == '[' || Expresion[i]=='{')
                {
                    TopePila++;
                    Pila[TopePila] = Expresion[i];
                }
                else
                {
                    if (Expresion[i] == ')' || Expresion[i] == ']' || Expresion[i] == '}')
                    {
                        if (TopePila > -1)
                        {
                            if (Expresion[i] == ')' || Pila[TopePila] == '(')
                            {
                                TopePila--;
                            }
                            else
                            {
                                if (Expresion[i] == ']' || Pila[TopePila] == '[')
                                {
                                    TopePila--;
                                }
                                else
                                {
                                    if (Expresion[i] == '}' || Pila[TopePila] == '{')
                                    {
                                        TopePila--;
                                    }
                                    else
                                    {
                                        i=Longitud;
                                        TopePila = 100;
                                    }
                                }
                            }
                        }
                        else
                        {
                              i = Longitud;
                            TopePila = 100;

                        }
                    }
                    else
                    {

                    }
                }
            }
            if (TopePila == -1)
            {
                MessageBox.Show("La expresion esta bien balanceada");
            }
            else
            {
                MessageBox.Show("La expresion no esta bien balanceada");
               
            }

        }
    }
}
