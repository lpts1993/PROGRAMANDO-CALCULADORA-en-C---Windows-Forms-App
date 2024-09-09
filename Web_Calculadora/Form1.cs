namespace Web_Calculadora
{
    public partial class Form1 : Form
    {

        double num1=0,num2=0;
        char operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //boton cerrar
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //boton minimizar
            WindowState = FormWindowState.Minimized;    
        }
        //agregar numero 
        private void agregarnumero(object sender, EventArgs e) 
        {
            var boton = ((Button)sender);
            if (txt_resultado.Text == "0")
                txt_resultado.Text = "";
            txt_resultado.Text += boton.Text;


        }

        private void btn_igual_Click(object sender, EventArgs e)
        {
            //boton igual
            num2 = Convert.ToDouble(txt_resultado.Text);
            if (operador == '+')
            {
                txt_resultado.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txt_resultado.Text);
            }
            else if (operador == '-') 
            {
                txt_resultado.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txt_resultado.Text);
            }
            else if (operador == '*')
            {
                txt_resultado.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txt_resultado.Text);
            }
            else if (operador == '/')
            {
                if (txt_resultado.Text != "0")
                {
                    txt_resultado.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(txt_resultado.Text);
                }
                else 
                {
                    MessageBox.Show("No se puede dividir para cero..");
                }
            }
        }

        //boton quitar d euno en uno
        private void btn_quitar_Click(object sender, EventArgs e)
        {
            
            if (txt_resultado.Text.Length>1)
            {
                txt_resultado.Text = txt_resultado.Text.Substring(0, txt_resultado.Text.Length-1);
            }
            else
            {
                txt_resultado.Text = "0";
            }
        }


        //boton quitar todo
        private void btn_borrartodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txt_resultado.Text = "0";

        }

        //borrar solo el numero 
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            txt_resultado.Text = "0";

        }

        //singo punto
        private void btn_punto_Click(object sender, EventArgs e)
        {
            if (!txt_resultado.Text.Contains(".")) 
            {
                txt_resultado.Text += ".";
            }
        }


        // agregar el signo menor o mayor para 
        //ponerle el numero como positivo o negativo
        private void btn_signo_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txt_resultado.Text);
            num1 *= -1;
            txt_resultado.Text = num1.ToString();
        }

        //operador
        private void clickoperador(object sender, EventArgs e) 
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txt_resultado.Text);
            operador = Convert.ToChar(boton.Tag);

            if (operador == '²')
            {
                num1 = Math.Pow(num1, 2);
                txt_resultado.Text = num1.ToString();
            }
            else if (operador == '√')
            {
                num1 = Math.Sqrt(num1);
                txt_resultado.Text = num1.ToString();
            }
            else 
            {
                
                txt_resultado.Text = "0";
            }



            
        }

       
    }
}