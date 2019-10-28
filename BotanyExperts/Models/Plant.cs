namespace BotanyExperts.Models
{
    public class Plant
    {
        public int PlantId { get; set; }
        public bool MakeSeeds { get; set; }
        public bool HasRoots { get; set; }
        public bool MakeFlowers { get; set; }
        public string CommonName { get; set; }
        public string ScientificName { get; set; }
        public string ImgUrl { get; set; }
    }
}