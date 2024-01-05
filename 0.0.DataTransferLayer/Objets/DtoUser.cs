
using _0._0.DataTransferLayer.Generic;

namespace _0._0.DataTransferLayer.Objets
{
    public class DtoUser:DtoGeneric
    {
        public string idUser { get; set; }
        public string password { get; set; }
        public string firstName { get; set; }
        public string surName { get; set; }
        public string dni { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }
    }
}
