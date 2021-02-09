using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSystem
{
     public class Questions
    {
        public int q_id { get; set; }
        public string q_title { get; set; }

        public string q_opa { get; set; }
        public string q_opb { get; set; }
        public string q_opc { get; set; }
        public string q_opcorrect { get; set; }
        public string q_fk_ex { get; set; }
    }
}
