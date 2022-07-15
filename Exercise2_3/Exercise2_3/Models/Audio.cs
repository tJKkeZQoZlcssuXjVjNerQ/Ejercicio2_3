using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Exercise2_3.Models
{
    public class Audio
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string path { get; set; }
        [MaxLength(100)]
        public string descripcion { get; set; }
  
    }
}
