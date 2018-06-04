using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testpim
{
    public class Validacao
    {
        public bool ValidarCpf(string Cpf)//Metódo que retorna verdadeiro se o Cpf foi considerado válido e falso se ele for inválido
        {
            if (Cpf == "")
            {
                return false;
            } else { 
                int[] Dig1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] Dig2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
                string ArmazenaCpf = "";
                string Digito;
                int soma, resto, x;

                if (Cpf.Length != 11)
                {
                    Cpf = Cpf.Trim();//Tira espaços em branco
                    Cpf = Cpf.Replace(",", "").Replace("-", "");//Coloca espaços vazios onde era vírgula e traço
                }

                ArmazenaCpf = Cpf.Substring(0, 9);//Recebe os 9 primeiros digitos do CPF
                if ((Cpf != "00000000000") && (Cpf != "11111111111") && (Cpf != "22222222222") && (Cpf != "33333333333") && (Cpf != "44444444444") && (Cpf != "55555555555") && (Cpf != "66666666666") && (Cpf != "77777777777") && (Cpf != "88888888888") && (Cpf != "99999999999"))//Verifica se os 11 dígitos correspondem a valores que não sejam todos eles iguais
                {
                    //Digito1
                    soma = 0;
                    for (x = 0; x < 9; x++)
                    {
                        soma += int.Parse(ArmazenaCpf[x].ToString()) * Dig1[x];//Faz a multiplicação dos dígitos por suas respectivas posições
                    }
                    resto = soma % 11;//verifica resto da divisão
                    if (resto < 2)
                    {
                        resto = 0;
                    }  else {
                        resto = 11 - resto;
                    }
                  
                    Digito = resto.ToString();
                    ArmazenaCpf = ArmazenaCpf + Digito;
                    //Digito 2
                    soma = 0;
                    for (x = 0; x < 10; x++)
                    {
                        soma += int.Parse(ArmazenaCpf[x].ToString()) * Dig2[x];//Faz a multiplicação dos dígitos por suas respectivas posições
                    }
                    resto = soma % 11;// verifica resto da divisão por 11
                    if (resto < 2)
                    {
                        resto = 0;
                    } else {
                        resto = 11 - resto;
                    }

                    Digito = resto.ToString();
                    ArmazenaCpf = ArmazenaCpf + Digito;
                    return Cpf.EndsWith(Digito);//retorna valor de Cpf válido
                } else {
                    return false;//retorna falaso para CPf não válido
                }
            }
        }

        public bool ValidarEmail(string Email)//Metódo que retorna verdadeiro se o Email foi considerado válido e falso se ele for inválido
        {
            if (Email == "")
            {
                return false;
            } else  {
                bool verificar = Email.Contains("@") && (Email.Contains(".com"));
                return verificar;
            } 
        }

        public bool ValidaCnpj(string cnpj)//Metódo que retorna verdadeiro se o Cnpj foi considerado válido e falso se ele for inválido
        {

            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            int soma;

            int resto;

            string digito;

            string tempCnpj;

            cnpj = cnpj.Trim();

            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)

                return false;

            tempCnpj = cnpj.Substring(0, 12);

            soma = 0;

            for (int i = 0; i < 12; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = resto.ToString();

            tempCnpj = tempCnpj + digito;

            soma = 0;

            for (int i = 0; i < 13; i++)

                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];

            resto = (soma % 11);

            if (resto < 2)

                resto = 0;

            else

                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cnpj.EndsWith(digito);

        }

    }
}

