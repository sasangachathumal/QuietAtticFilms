using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuietAtticFilms
{
    internal class PropertyModel
    {
        public int ?id { get; set; }
        public string ?propId { get; set; }
        public string ?name { get; set; }
        public string ?propType { get; set; }

        public PropertyModel(int? id, string? propId, string? name, string? propType)
        {
            this.id = id;
            this.propId = propId;
            this.name = name;
            this.propType = propType;
        }

        public PropertyModel(string? propId, string? name, string? propType)
        {
            this.propId = propId;
            this.name = name;
            this.propType = propType;
        }

        public PropertyModel()
        {
        }
    }
}
