using Microsoft.EntityFrameworkCore;

namespace BotanyExperts.Models
{
    public class BotanyExpertsContext : DbContext
    {
        public BotanyExpertsContext(DbContextOptions<BotanyExpertsContext> options)
            : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Plant>()
                .HasData(
                    new Plant { PlantId = 1, MakeSeeds = false, HasRoots = false, MakeFlowers = false, CommonName = "Seagrapes", ScientificName = "Caulerpa lentillifera", ImgUrl = "https://en.wikipedia.org/wiki/Caulerpa_lentillifera#/media/File:Umibudou_at_Miyakojima01s3s2850.jpg"},
                    new Plant { PlantId = 2, MakeSeeds = true, HasRoots = true, MakeFlowers = false, CommonName = "Pondarosa Pine", ScientificName = "Pinus ponderosa", ImgUrl = "https://static.spokanecity.org/photos/2012/06/05/ponderosa-pine/16x10/Full/ponderosa-pine.jpg"},
                    new Plant { PlantId = 3, MakeSeeds = true, HasRoots = true, MakeFlowers = true, CommonName = "Venus Flytrap", ScientificName = "Dionaea muscipula", ImgUrl = "https://en.wikipedia.org/wiki/Venus_flytrap#/media/File:Venus_Flytrap_showing_trigger_hairs.jpg"},
                    new Plant { PlantId = 4, MakeSeeds = false, HasRoots = false, MakeFlowers = false, CommonName = "Wolf Lichen", ScientificName = "Letharia vulpina", ImgUrl = "https://en.wikipedia.org/wiki/Lichen#/media/File:Letharia_vulpina_JHollinger_crop.jpg"},
                    new Plant { PlantId = 5, MakeSeeds = true, HasRoots = true, MakeFlowers = false, CommonName = "Lady Fern", ScientificName = "Athyrium filix-femina", ImgUrl = "https://d6p0gevo8s9lm.cloudfront.net/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/C/0/C01BDA65B214C5F174B470048D11E31D.jpg"},
                    new Plant { PlantId = 6, MakeSeeds = true, HasRoots = true, MakeFlowers = true, CommonName = "Pineapple", ScientificName = "Ananas comosus", ImgUrl = "https://en.wikipedia.org/wiki/Pineapple#/media/File:Flowering_Pineapple_Sept_4_2011.jpg"}
            );

            builder.Entity<Fungus>()
                .HasData(
                    new Fungus { FungusId = 1, EatsOtherThings = true, IsMultiCellular = true, CommonName = "Golden Chanterelle", ScientificName = "Cantharellus cibarius", ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/9/9a/Chanterelle_Cantharellus_cibarius.jpg"},
                    new Fungus { FungusId = 2, EatsOtherThings = true, IsMultiCellular = true, CommonName = "Fly Agaric", ScientificName = "Amanita muscaria", ImgUrl = "https://en.wikipedia.org/wiki/Amanita_muscaria#/media/File:2006-10-25_Amanita_muscaria_crop.jpg"},
                    new Fungus { FungusId = 3, EatsOtherThings = true, IsMultiCellular = true, CommonName = "Sac Fungi", ScientificName = "Sarcoscypha coccinea", ImgUrl = "https://en.wikipedia.org/wiki/Ascomycota#/media/File:Scarlet_elf_cap_cadnant_dingle.jpg"},
                    new Fungus { FungusId = 4, EatsOtherThings = true, IsMultiCellular = false, CommonName = "Microsporidia", ScientificName = "Fibrillanosema crangonycis", ImgUrl = "https://en.wikipedia.org/wiki/Microsporidia#/media/File:Fibrillanosema_spore.jpg"}, new Fungus { FungusId = 5, EatsOtherThings = true, IsMultiCellular = false, CommonName = "Baker's Yeast", ScientificName = "Saccharomyces cerevisiae", ImgUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Saccharomyces_cerevisiae_SEM.jpg/440px-Saccharomyces_cerevisiae_SEM.jpg"}

                );
        }
    }
}