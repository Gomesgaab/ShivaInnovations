using System;

namespace ShivaInnovations
{
    class ControlCPF
    {

        public Boolean Validarcpf(string cpf)
        {
            bool valid = true;



            // Verificar se o CPF possui 11 dígitos
            if (cpf.Length != 11)
            {
                valid = false; // se for diferente de 11 retorna falso
            }

            // Verificar se todos os dígitos são iguais (CPF inválido)
            if (valid)
            {
                for (byte i = 0; i < 10; i++)
                {
                    var temp = new string(Convert.ToChar(i), 11);
                    if (cpf == temp)
                    {
                        valid = false;
                        break;
                    }// fim do se

                }// fim do para
            }// fim so se

            // verificar os digitos de controle do cpf "00"
            if (valid)
            {
                var j = 0;
                var d1 = 0; // guardar o primeiro digito
                var d2 = 0; // guardar o segundo digito

                // validando o primeiro digito de controle
                for (int i = 10; i > 1; i--)
                {
                    d1 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }// fim

                // resto da divisão
                d1 = (d1 * 10) % 11;
                if (d1 == 10)
                {
                    d1 = 0;
                }// fim

                // verificando se o primeiro número e valido
                if (d1 != Convert.ToInt32(cpf.Substring(9, 1)))
                {
                    valid = false;
                }// f im

                // validar segundo número
                j = 0;

                for (int i = 10; i > 1; i--)
                {
                    d2 += Convert.ToInt32(cpf.Substring(j, 1)) * i;
                    j++;
                }// fim

                // resto da divisão
                d2 = (d2 * 10) % 11;
                if (d2 == 10)
                {
                    d2 = 0;
                }// fim

                // verificando se o primeiro número e valido
                if (d2 != Convert.ToInt32(cpf.Substring(10, 1)))
                {
                    valid = false;
                }// fim
            }
            valid = true;
            return valid;
        }// fim metodo
    }// fim classe 
}// fim projeto
