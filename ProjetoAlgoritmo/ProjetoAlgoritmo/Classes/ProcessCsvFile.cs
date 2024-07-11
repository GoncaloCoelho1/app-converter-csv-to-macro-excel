using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAlgoritmo.Funcoes
{
    internal class ProcessCsvFile
    {
        public void ProcessCsvFiles(string filePath, string macroType)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                // Obtém o diretório do ficheiro CSV
                string directoryPath = Path.GetDirectoryName(filePath);

                // Chama o método para gerar a macro VBA dentro do mesmo diretorio do ficheiro csv inserido
                GenerateMacro generator = new GenerateMacro();
                generator.GenerateVbaMacro(lines, directoryPath, macroType);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}