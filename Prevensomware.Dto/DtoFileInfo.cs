namespace Prevensomware.Dto
{
    public class DtoFileInfo : DtoBase
    {
        public string OriginalExtension { get; set; }
        public string ReplacedExtension { get; set; }
        public string OriginalPath { get; set; }
        public string ReplacedPath { get; set; }
    }
}