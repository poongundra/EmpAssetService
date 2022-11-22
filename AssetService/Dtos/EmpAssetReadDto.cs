namespace EmpAssetService.Dtos
{
    public class EmpAssetReadDto
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string AssetType { get; set; }
        public string AssetName { get; set; }
        public DateTime GivenDate { get; set; }
        public string GivenBy { get; set; }
        public string Notes { get; set; }
        public DateTime ReturnDate { get; set; }
        public string ReturnedTo { get; set; }
        public string ReturnNote { get; set; }
        public string Status { get; set; }
    }
}
