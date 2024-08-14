namespace PracticaUnoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.S:
                        MessageBox.Show("Guardar acción realizada", "Informacion");
                        break;
                    case Keys.D:
                        MessageBox.Show("Abrir accion realizada", "Informacion");
                        break;
                }
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Verificar si el caracter es una letra
            if(char.IsLetter(e.KeyChar))
            {
                //Convierte el caracter a mayuscula
               e.KeyChar= char.ToUpper(e.KeyChar);
                
            }
            else if ((char.IsControl(e.KeyChar)))
            {
                //Si no es una letra ni una tecla de control, cancelar el evento
                e.Handled = true;
            }
        }
    }
}
