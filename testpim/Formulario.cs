using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testpim
{
    public class Formulario
    {
        public void RetiraMascaras(MaskedTextBox maskedTextBox)//Metódo que Retira Máscaras do MaskedTextBox de acordo com MaskedTextBox passado como parâmetro
        {
            maskedTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
        }

        public void LimpaTextBoxs(TextBox textbox)//Metódo que Limpa os dados do TextBox de acordo com TextBox passado como parâmetro
        {
            textbox.Clear();
        }

        public void LimpaMaskedTextBoxs(MaskedTextBox maskedTextBox)//Metódo que Limpa os dados do MaskedTextBox de acordo com MaskedTextBox passado como parâmetro
        {
            maskedTextBox.Clear();
        }

        public void IncluirMascaras(MaskedTextBox maskedTextBox)//Metódo que Devolve as Máscaras do MaskedTextBox de acordo com MaskedTextBox passado como parâmetro
        {
            maskedTextBox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }
    }
}
