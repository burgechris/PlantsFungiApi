namespace BotanyExperts.Models
{
    public class Fungus
    {
        public int FungusId { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public bool CanMove { get; set; }
        public bool EatsOtherThings { get; set; }
        public bool IsMultiCellular { get; set; }
        public string ImgUrl { get; set; }


    }
}