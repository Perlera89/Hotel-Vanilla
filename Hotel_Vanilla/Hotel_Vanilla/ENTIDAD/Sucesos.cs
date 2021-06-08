using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.ENTIDAD
{
    public class Sucesos
    {
        [DisplayName("Id")]
        public int idSuceso { get; set; }
        [DisplayName("Fecha")]
        public DateTime? fechaSuceso { get; set; }
        [DisplayName("Tipo")]
        public string tipoSuceso { get; set; }
        [DisplayName("Descripcion")]
        public string descripcion { get; set; }

    }
}
