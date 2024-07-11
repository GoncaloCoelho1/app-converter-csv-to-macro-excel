using static Google.Protobuf.Compiler.CodeGeneratorResponse.Types;
using System.Runtime.Intrinsics.Arm;

namespace ProjetoAlgoritmo.Funcoes
{
    internal class GenerateMacro
    {
        public void GenerateVbaMacro(string[] lines, string directoryPath, string macroType)
        {
            string vbaMacro = CreateMacroHeader(macroType);

            foreach (string line in lines)
            {
                string[] values = line.Split(',');
                vbaMacro += GenerateVbaLine(values, macroType);
            }

            vbaMacro += "End Sub";

            SaveVbaMacroToFile(vbaMacro, directoryPath, macroType);
        }

        private string CreateMacroHeader(string macroType)
        {

            string macroName;

            if (macroType == "Vendas")
            {
                macroName = "MacroVendas";
            }
            else
            {
                macroName = "MacroFaturas";
            }

            return $@"Sub {macroName}()
                        Dim ws As Worksheet
                        Set ws = ThisWorkbook.Sheets(1)
                        Dim startCell As Range
                        Set startCell = ws.Application.ActiveCell
                        Dim nextRow As Long
                        nextRow = startCell.Row
                        ";
        }

        private string GenerateVbaLine(string[] values, string macroType)
        {
            if (macroType == "Vendas")
            {
                return GenerateVbaLineForVendas(values);
            }
            else if (macroType == "Faturas")
            {
                return GenerateVbaLineForFaturas(values);
            }
            return string.Empty;
        }

        private string GenerateVbaLineForVendas(string[] values)
        {
            CodigoToNomeMapper mapper = new CodigoToNomeMapper();
            string nome = mapper.CodigoToNome(values[1]);

            return $"ws.Cells(nextRow, startCell.Column).Value = \"{values[0]}\"\n" +  // Numero CPA
                   $"ws.Cells(nextRow, startCell.Column + 2).Value = \"{nome}\"\n" + // Nome
                   $"ws.Cells(nextRow, startCell.Column + 3).Value = \"{values[2]}\"\n" + // NIF
                   $"ws.Cells(nextRow, startCell.Column + 5).Value = \"{values[3]}\"\n" + // Quantidade Vendida
                   $"ws.Cells(nextRow, startCell.Column + 6).Value = \"{values[4]}\"\n" + // Preço Unitário de Venda
                   $"ws.Cells(nextRow, startCell.Column + 7).Value = \"{values[5]}\"\n" + // Data
                   $"ws.Cells(nextRow, startCell.Column + 8).Value = \"{values[6]}\"\n" + // Exceção
                   "nextRow = nextRow + 1\n";
        }

        private string GenerateVbaLineForFaturas(string[] values)
        {
            return $"ws.Cells(nextRow, startCell.Column).Value = \"{values[0]}\"\n" +  // Numero de Procedimento
                   $"ws.Cells(nextRow, startCell.Column + 1).Value = \"{values[1]}\"\n" + // Numero de Compromisso
                   $"ws.Cells(nextRow, startCell.Column + 2).Value = \"{values[2]}\"\n" + // Tipo de Documento
                   $"ws.Cells(nextRow, startCell.Column + 3).Value = \"{values[3]}\"\n" + // Numero do Documento
                   $"ws.Cells(nextRow, startCell.Column + 4).Value = \"{values[4]}\"\n" + // Data de Emissão
                   $"ws.Cells(nextRow, startCell.Column + 5).Value = \"{values[5]}\"\n" + // Referencia Interna
                   $"ws.Cells(nextRow, startCell.Column + 6).Value = \"{values[6]}\"\n" + // Prazo de Pagamento
                   $"ws.Cells(nextRow, startCell.Column + 7).Value = \"{values[7]}\"\n" + // Numero da Fatura
                   $"ws.Cells(nextRow, startCell.Column + 8).Value = \"{values[8]}\"\n" + // NIF da Entidade
                   $"ws.Cells(nextRow, startCell.Column + 9).Value = \"{values[9]}\"\n" + // Numero da Encomenda
                   $"ws.Cells(nextRow, startCell.Column + 10).Value = \"{values[10]}\"\n" + // Codigo Artigo SPMS
                   $"ws.Cells(nextRow, startCell.Column + 11).Value = \"{values[11]}\"\n" + // Designação do Artigo
                   $"ws.Cells(nextRow, startCell.Column + 12).Value = \"{values[12]}\"\n" + // AIM / CDM
                   $"ws.Cells(nextRow, startCell.Column + 13).Value = \"{values[13]}\"\n" + // Tipo de Unidade
                   $"ws.Cells(nextRow, startCell.Column + 14).Value = \"{values[14]}\"\n" + // Quantidade
                   $"ws.Cells(nextRow, startCell.Column + 15).Value = \"{values[15]}\"\n" + // Preço Unitário
                   $"ws.Cells(nextRow, startCell.Column + 16).Value = \"{values[16]}\"\n" + // Taxa de IVA
                   $"ws.Cells(nextRow, startCell.Column + 17).Value = \"{values[17]}\"\n" + // Tipo de Nota de Crédito
                   $"ws.Cells(nextRow, startCell.Column + 18).Value = \"{values[18]}\"\n" + // Observações
                   $"ws.Cells(nextRow, startCell.Column + 19).Value = \"{values[19]}\"\n" + // CHNM
                   $"ws.Cells(nextRow, startCell.Column + 20).Value = \"{values[20]}\"\n" + // NPDM
                   $"ws.Cells(nextRow, startCell.Column + 21).Value = \"{values[21]}\"\n" + // Marca Comercial
                   $"ws.Cells(nextRow, startCell.Column + 22).Value = \"{values[22]}\"\n" + // Numero de CPA
                   "nextRow = nextRow + 1\n";
        }

        private void SaveVbaMacroToFile(string vbaMacro, string directoryPath, string macroType)
        {
            string fileName;

            if (macroType == "Vendas")
            {
                fileName = "macro-vendas.bas";
            }
            else
            {
                fileName = "macro-faturas.bas";
            }

            string filePath = Path.Combine(directoryPath, fileName);
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.Write(vbaMacro);
                }
                MessageBox.Show($"A macro para o excel de {macroType.ToLower()} foi criada no diretorio: \n{directoryPath}\n com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
