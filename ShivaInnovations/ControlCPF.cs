using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShivaInnovations
{
    class ControlCPF
    {
        public bool ValidarCPF(string cpf)
        {
            // Remover caracteres não numéricos do CPF
            cpf = new string(cpf.Where(char.IsDigit).ToArray());

            // Verificar se o CPF possui 11 dígitos
            if (cpf.Length != 11)
                return false;

            // Verificar se todos os dígitos são iguais (CPF inválido)
            if (cpf.All(digit => digit == cpf[0]))
                return false;

            // Calcular os dígitos verificadores
            int[] weights1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] weights2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            int sum1 = 0;
            for (int i = 0; i < 9; i++)
                sum1 += int.Parse(cpf[i].ToString()) * weights1[i];

            int remainder1 = sum1 % 11;
            remainder1 = remainder1 < 2 ? 0 : 11 - remainder1;

            int sum2 = 0;
            for (int i = 0; i < 10; i++)
                sum2 += int.Parse(cpf[i].ToString()) * weights2[i];

            int remainder2 = sum2 % 11;
            remainder2 = remainder2 < 2 ? 0 : 11 - remainder2;

            // Verificar se os dígitos verificadores calculados coincidem com os dígitos do CPF
            return cpf.EndsWith(remainder1.ToString() + remainder2.ToString());
        }

      
    }// fim classe 
}// fim projeto
