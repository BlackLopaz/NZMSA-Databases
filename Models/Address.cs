using System;
using NZMSA_mkmu260_Databases.Data;
using NZMSA_mkmu260_Databases.Controllers;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NZMSA_mkmu260_Databases.Models
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int addressId { get; set; }
        public int studentId { get; set; }
        public string streetNumber { get; set; }
        public string street { get; set; }
        public string suburb { get; set; }
        public string city { get; set; }
        public int postcode { get; set; }
        public string country { get; set; }
    }
}
