namespace QCService.Models
{
    public class DefectTypeDTO
    {
        
        public string Code { get; set; }
        public string Name { get; set; }
        public string ReasonsJson { get; set; }
        public string SolutionsJson { get; set; }
        public string HandlersJson { get; set; }
        public string CompletionTime { get; set; }
    }
}