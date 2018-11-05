using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcUsingBootstrapTemplate.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        [Column("AdAccount_Domain")]
        public string AdAccountDomain { get; set; }
        [Column("AdAccount_Name")]
        public string AdAccountName { get; set; }
    }
}
