using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.ENTIDAD
{
    public class Habitaciones
    {
        public int idHabitacion { get; set; }
        public string numeroHabitacion { get; set; }
        public decimal tarifa { get; set; }
        public int? idTipoHabitacion_FK { get; set; }



    }

}

