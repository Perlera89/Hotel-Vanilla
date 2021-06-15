using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.ENTIDAD
{
    public class TipoHabitaciones
    {
        public int idTipoHabitacion { get; set; }
        public string Tipodehabitacion { get; set; }
        [DisplayName("Ocupantes")]
        public string numeroOcupantes { get; set; }
    }

    public class sp_MostrarTipoHabitaciones
    {
        public int idTipoHabitacion { get; set; }
        public string tipo { get; set; }
        public int numeroOcupantes { get; set; }
    }
}
