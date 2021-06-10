using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Vanilla.ENTIDAD
{
    class spBuscarHuesped
    {
        [DisplayName("Id")]
        public int idHuesped { get; set; }
        [DisplayName("Nombres")]
        public string nombres { get; set; }
        [DisplayName("Apellidos")]
        public string apellidos { get; set; }
        [DisplayName("Direccion")]
        public string direccion { get; set; }
        [DisplayName("Telefono")]
        public string telefono { get; set; }
        [DisplayName("Correo")]
        public string correo { get; set; }
        [DisplayName("Estado")]
        public string nombreEstado { get; set; }
    }
}
