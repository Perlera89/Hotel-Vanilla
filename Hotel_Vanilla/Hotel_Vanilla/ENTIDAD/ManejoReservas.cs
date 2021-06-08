using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.ENTIDAD
{
    public class ManejoReservas
    {
        public int idReserva { get; set; }
        public DateTime fechaReserva { get; set; }
        public DateTime fechaCheckIn { get; set; }
        public DateTime? fechaCheckOut { get; set; }
        public int numeroDias { get; set; }
        public decimal? pagoAdelantado { get; set; }
        public decimal? descuento { get; set; }
        public decimal? total { get; set; }
        public int? idHabitacion_FK { get; set; }
        public int? idHuesped_FK { get; set; }

    }

    
}
