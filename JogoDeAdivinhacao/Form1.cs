using System.Configuration;
using System.Drawing.Text;

namespace JogoDeAdivinhacao
{
    public partial class Form1 : Form
    {
        private int NumeroSorteado;
        private int Tentativa;





        public Form1()
        {
            InitializeComponent();
            //Random random = new Random();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            NumeroSorteado = random.Next(1, 101);
            Tentativa = 0;
            //txtDigite.Clear();
            //txtDigite.Focus();

            int ValorMinimo = Convert.ToInt32(txtDigite.Text);
            int ValorMaximo = Convert.ToInt32(txtDigite.Text);


            if (int.TryParse(txtDigite.Text, out int btnSortear))
            {
                Tentativa++;
                lblTentativa.Text = $"Tentativas: {Tentativa}";


                if (ValorMinimo < 1 || ValorMaximo > 100)
                {
                    MessageBox.Show("Digite um número valido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }

                if (NumeroSorteado == Tentativa)
                {
                    MessageBox.Show("Você acertou o número!", "Parabéns", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if (NumeroSorteado > Tentativa)
                {
                    MessageBox.Show("Chute muito alto", "Não foi dessa vez", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (NumeroSorteado < Tentativa)
                {
                    MessageBox.Show("Chute muito baixo", "Não foi dessa vez", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                //else 
                //{
                //    MessageBox.Show("Tente novamente.", "Não foi dessa vez!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
            }



            Random randNum = new Random();





        }

        private void lblDica_Click(object sender, EventArgs e)
        {

        }
    }
}