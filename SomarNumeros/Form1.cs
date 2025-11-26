namespace SomarNumeros
{
    public partial class Frm_TelaInicial : Form
    {
        public Frm_TelaInicial()
        {
            InitializeComponent();
        }

        private void Btn_Somar_Click(object sender, EventArgs e)
        {
            string entradaUmText = Txt_EntradaUm.Text;
            string entradaDoisText = Txt_EntradaDois.Text;

            if (string.IsNullOrEmpty(entradaUmText) || string.IsNullOrEmpty(entradaDoisText))
            {
                MessageBox.Show("Por favor, preencha os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!double.TryParse(entradaUmText, out double entradaUm) || !double.TryParse(entradaDoisText, out double entradaDois))
            {
                MessageBox.Show("Por favor, insira um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double resultado = entradaUm + entradaDois;

            Lbl_Resultado.Text = resultado.ToString();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_EntradaUm.Clear();
            Txt_EntradaDois.Clear();
            Lbl_Resultado.Text = "-";
            Txt_EntradaUm.Focus();
        }

    }
}
