using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.ENTIDAD
{
    class spBuscarHabitacion
    {
        [DisplayName("Id")]
        public int idHabitacion { get; set; }
        [DisplayName("Codigo de habitacion")]
        public string numeroHabitacion { get; set; }
        [DisplayName("Tarifa")]
        public decimal tarifa { get; set; }
        [DisplayName("Tipo de habitacion")]
        public string tipo { get; set; }
    }
}
