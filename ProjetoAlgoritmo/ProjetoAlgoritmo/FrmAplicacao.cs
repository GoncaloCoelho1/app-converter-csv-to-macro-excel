using MySql.Data.MySqlClient;
using ProjetoAlgoritmo.Funcoes;

namespace ProjetoAlgoritmo
{
    public partial class FrmAplicacao : Form
    {

        public FrmAplicacao()
        {
            InitializeComponent();
        }

        private void buttonCsvVendas_click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string macroType = "Vendas";
                string filePath = openFileDialog.FileName;
                ProcessCsvFile vendas_file = new ProcessCsvFile();
                vendas_file.ProcessCsvFiles(filePath, macroType);

            }
        }
                        
        private void buttonCsvFaturas_click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string macroType = "Faturas";
                string filePath = openFileDialog.FileName;
                ProcessCsvFile faturas_file = new ProcessCsvFile();
                faturas_file.ProcessCsvFiles(filePath, macroType);

            }
        }
    }
}
