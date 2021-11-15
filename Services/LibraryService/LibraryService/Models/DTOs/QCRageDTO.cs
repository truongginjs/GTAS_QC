namespace LibraryService.Models.DTOs
{
    public class QCRageDTO
    {
        public int OfferedQtyFrom { get; set; }
        public int OfferedQtyTo { get; set; }
        public int SampleSize { get; set; }
        public int AllowMajorDefect { get; set; }
    }
}