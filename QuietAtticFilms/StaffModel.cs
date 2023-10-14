using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuietAtticFilms
{
    internal class StaffModel
    {
        public int ?id { get; set; }
        public string ?stId { get; set; }
        public string ?name { get; set; }
        public string ?nic { get; set; }
        public string ?contact { get; set; }
        public string ?role { get; set; }

        public StaffModel(int? id, string? stId, string? name, string? nic, string? contact, string? role)
        {
            this.id = id;
            this.stId = stId;
            this.name = name;
            this.nic = nic;
            this.contact = contact;
            this.role = role;
        }

        public StaffModel(string? stId, string? name, string? nic, string? contact, string? role)
        {
            this.stId = stId;
            this.name = name;
            this.nic = nic;
            this.contact = contact;
            this.role = role;
        }

        public StaffModel()
        {
        }
    }
}
