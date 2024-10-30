using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Client : User
    {
        public Client()
        {
            Rol = (Domain.Enums.RolEnum.cliente);
        }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Adress { get; set; }
        [JsonIgnore]
        public Cart Cart { get; set; }
    }
}
