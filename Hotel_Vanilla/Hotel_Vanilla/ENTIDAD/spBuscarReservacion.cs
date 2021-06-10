using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.ENTIDAD
{
    class spBuscarReservacion
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Habitacion { get; set; }
        [DisplayName("Reserva")]
        public DateTime Fechareserva { get; set; }
        [DisplayName("Check in")]
        public DateTime Checkin { get; set; }
        [DisplayName("Check out")]
        public DateTime? Checkout { get; set; }
        public int Dias { get; set; }
        public int Ocupantes { get; set; }
        [DisplayName("Adelantado")]
        public decimal? Pagoadelantado { get; set; }
        public string Tipo { get; set; }
        public decimal? Descuento { get; set; }
        public decimal? Total { get; set; }
    }
}
