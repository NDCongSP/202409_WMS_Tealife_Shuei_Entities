using FBT.ShareModels.Commons;

namespace FBT.ShareModels.Entities
{
    public class DeliveryCompany : AuditEntityBase
    {
        public string DeliveryCompanyId { get; set; }
        public string DeliveryCompanyCode { get; set; }
        public string DeliveryCompanyName { get; set; }
        public string ParentDeliveryCompanyCode { get; set; }
        public string ParentDeliveryCompanyName { get; set; }
        public bool UsingApi { get; set; }
        public int? WeightMin { get; set; }
        public int? WeightMax { get; set; }
        public string ServiceLevel { get; set; }
        public string MobileRequirement { get; set; }
        public string ChCustomerRequirement { get; set; }
        public string ChAddressRequirement { get; set; }
        public string NavDeliveryCompanyCode { get; set; }
        public string MgtCarrierCode { get; set; }
        public string MgtTitle { get; set; }
        public string LabelExportModel { get; set; }
        public decimal? DefaultPriceRestriction { get; set; }
        public decimal? DefaultWeightRestriction { get; set; }
        public long? DefaultQtyRestriction { get; set; }
    }
}
