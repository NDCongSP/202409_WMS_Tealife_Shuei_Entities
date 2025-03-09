namespace FBT.ShareModels
{
    public enum EnumPackingListStatus
    {
        Picked = 3,
        Packing = 4,
        Packed = 5,
        All = 8,//dùng cho việc tìm kiếm, chọn toàn bộ các trạng thái của shipment ở packing list master
    }
}