using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuietAtticFilms
{
    internal class LocationModel
    {
        public int ?id { get; set; }
        public int ?proId { get; set; }
        public string ?lId { get; set; }
        public string ?name { get; set; }
        public List<PropertyModel> ?PropertyList { get; set; }

        public LocationModel(int? id, int? proId, string? lId, string? name, List<PropertyModel>? propertyList)
        {
            this.id = id;
            this.proId = proId;
            this.lId = lId;
            this.name = name;
            PropertyList = propertyList;
        }

        public LocationModel(int? proId, string? lId, string? name, List<PropertyModel>? propertyList)
        {
            this.proId = proId;
            this.lId = lId;
            this.name = name;
            PropertyList = propertyList;
        }

        public LocationModel()
        {
        }
    }
}
