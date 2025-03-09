
using FBT.ShareModels.Commons;
using System.ComponentModel.DataAnnotations.Schema;

namespace FBT.ShareModels.Entities
{
    [Table("CountryMasters")]
    public class CountryMaster : AuditEntityBase,IDataKeyFilter
    {
        public int Id { get; set; }
        public string CountryIsoNumeric { get; set; }
        public string CountryIso2 { get; set; }
        public string CountryIso3 { get; set; }
        public string CountryNameEn { get; set; }
        public string DataKey { get; set; }
    }
}