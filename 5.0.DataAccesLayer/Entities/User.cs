

using _5._0.DataAccesLayer.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace _5._0.DataAccesLayer.Entities
{
    [Table("tuser")]
    public class User : EntityGeneric
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]

        public string idUser { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public string firsName { get; set; }
        public string surName { get; set; }
        public string dni { get; set; }
        public DateTime birthDate { get; set; }
        public bool gender { get; set; }

    }
}
