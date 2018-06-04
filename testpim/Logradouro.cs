using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testpim
{
    public class Logradouro
    {
        public String Endereco { get; set; }
        public String Numero { get; set; }
        public String Complemento { get; set; }
        public String Bairro { get; set; }
        public String CEP { get; set; }
        public Cidade Cidade { get; set; }

        public Logradouro()
        {
            Cidade = new Cidade();
        }
    }
}