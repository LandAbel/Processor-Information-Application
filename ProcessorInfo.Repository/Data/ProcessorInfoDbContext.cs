using Microsoft.EntityFrameworkCore;
using ProcessorInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ProcessorInfo.Repository.Data
{
    public partial class ProcessorInfoDbContext : IdentityDbContext
    {
        public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Processor> Processors { get; set; }
        public virtual DbSet<Chipset> Chipsets { get; set; }
        public virtual DbSet<SiteUser> SiteUsers { get; set; }

        public ProcessorInfoDbContext(DbContextOptions<ProcessorInfoDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Processor>(entity =>
            {
                entity.HasOne(processor => processor.Brand)
                    .WithMany(brand => brand.Processors)
                    .HasForeignKey(processor => processor.BrandId)
                    .OnDelete(DeleteBehavior.Cascade);
            });
            modelBuilder.Entity<Processor>(entity =>
            {
                entity.HasOne(proc => proc.Chipset)
                .WithMany(chipset => chipset.Processors)
                .HasForeignKey(processor => processor.ChipsetId)
                .OnDelete(DeleteBehavior.Cascade);
            });
            base.OnModelCreating(modelBuilder);
            #region data
            //Adattal való feltöltés
            modelBuilder.Entity<Brand>().HasData(new Brand[]
            {
                new Brand() {BrandId=1,Name= "INTEL", PhotoUrl="https://processorinfostorageacc.blob.core.windows.net/processorinfo/intel-new-logo-16x9.jpg.rendition.intel.web.1648.927.jpg"},
                new Brand() { BrandId = 2, Name = "AMD", PhotoUrl="https://processorinfostorageacc.blob.core.windows.net/processorinfo/AMD_Logo.svg.png" },
                new Brand() { BrandId = 3, Name = "QUALCOMM" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/mobile.jpg"},

            });
            modelBuilder.Entity<Chipset>().HasData(new Chipset[]
            {
                new Chipset() { ChipsetId = 1, Name = "Z790", PhotoUrl="https://processorinfostorageacc.blob.core.windows.net/processorinfo/z790-chipset-blockdiagram-4.png" },
                new Chipset() { ChipsetId = 2, Name = "Z690", PhotoUrl="https://processorinfostorageacc.blob.core.windows.net/processorinfo/z690.jpg" },
                new Chipset() { ChipsetId = 3, Name = "Z590" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/z590.jpg"},
                new Chipset() { ChipsetId = 4, Name = "Z490" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/Intel-Z490-Chipset-Diagram.jpg"},
                new Chipset() { ChipsetId = 5, Name = "Z390" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/z390.png"},
                new Chipset() { ChipsetId = 8, Name = "AM4" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/amd-b550-chipset-block-diagram.png"},
                new Chipset() { ChipsetId = 9, Name = "AM5" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/c11947df-28fa-44df-9c0f-55142218f797_6083x2097.jpg"},
                new Chipset() { ChipsetId = 10, Name = "Mobile" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/mobile.jpg"},

            });
            modelBuilder.Entity<Processor>().HasData(new Processor[]
            {
                new Processor() {ProcessorId =1, BrandId=1,ChipsetId=1, PerformanceCores=8,EfficencyCores=16,TotalThreads=32,MaxTurboFrequency=5.8,Cache=36,IntegratedGraphics=true,Name= "Intel Core i9-13900K", PhotoUrl="https://processorinfostorageacc.blob.core.windows.net/processorinfo/13900k.jpg"},
                new Processor() { ProcessorId = 2, BrandId = 1, ChipsetId = 2, PerformanceCores = 8, EfficencyCores = 8, TotalThreads = 24, MaxTurboFrequency = 5.5, Cache = 30, IntegratedGraphics = true, Name = "Intel Core i9-12900KS",PhotoUrl="https://processorinfostorageacc.blob.core.windows.net/processorinfo/12900ks.jpg" },
                new Processor() { ProcessorId = 3, BrandId = 1, ChipsetId = 3, PerformanceCores = 8, EfficencyCores = 0, TotalThreads = 16, MaxTurboFrequency = 5.2, Cache = 16, IntegratedGraphics = true, Name = "Intel Core i9-11900K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/11900k.jpg"},
                new Processor() { ProcessorId = 4, BrandId = 1, ChipsetId = 4, PerformanceCores = 10, EfficencyCores = 0, TotalThreads = 20, MaxTurboFrequency = 5.3, Cache = 20, IntegratedGraphics = true, Name = "Intel Core i9-10900K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/10900k.jpg"},
                new Processor() { ProcessorId = 5, BrandId = 1, ChipsetId = 5, PerformanceCores = 8, EfficencyCores = 0, TotalThreads = 16, MaxTurboFrequency = 5, Cache = 16, IntegratedGraphics = true, Name = "Intel Core i9-9900K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/9900k.jpg"},
                new Processor() { ProcessorId = 6, BrandId = 1, ChipsetId = 1, PerformanceCores = 8, EfficencyCores = 8, TotalThreads = 24, MaxTurboFrequency = 5.4, Cache = 30, IntegratedGraphics = true, Name = "Intel Core i9-13700K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/13700kf.jpg"},
                new Processor() { ProcessorId = 8, BrandId = 1, ChipsetId = 2, PerformanceCores = 8, EfficencyCores = 4, TotalThreads = 20, MaxTurboFrequency = 5.0, Cache = 25, IntegratedGraphics = true, Name = "Intel Core i9-12700K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/12700k.jpg"},
                new Processor() { ProcessorId = 9, BrandId = 1, ChipsetId = 3, PerformanceCores = 8, EfficencyCores = 0, TotalThreads = 16, MaxTurboFrequency = 5.0, Cache = 16, IntegratedGraphics = true, Name = "Intel Core i9-11700K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/11700k.jpg"},
                new Processor() { ProcessorId = 10, BrandId = 1, ChipsetId = 4, PerformanceCores = 8, EfficencyCores = 0, TotalThreads = 16, MaxTurboFrequency = 5.1, Cache = 16, IntegratedGraphics = true, Name = "Intel Core i9-10700K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/10700k.jpg"},
                new Processor() { ProcessorId = 11, BrandId = 1, ChipsetId = 6, PerformanceCores = 8, EfficencyCores = 0, TotalThreads = 8, MaxTurboFrequency = 4.9, Cache = 12, IntegratedGraphics = true, Name = "Intel Core i7-9700K" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/9700k.jpg"},
                new Processor() { ProcessorId = 13, BrandId = 1, ChipsetId = 1, PerformanceCores = 8, EfficencyCores = 8, TotalThreads = 24, MaxTurboFrequency = 5.4, Cache = 30, IntegratedGraphics = false, Name = "Intel Core i9-13700KF" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/13700kf.jpg"},
                new Processor() { ProcessorId = 15, BrandId = 2, ChipsetId = 8, PerformanceCores = 16, TotalThreads = 32, MaxTurboFrequency = 4.9, Cache = 72, IntegratedGraphics = false, Name = "AMD Ryzen 9 5950X" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/743796831.amd-ryzen-9-5950x-16-core-3-4ghz-am4-box-without-fan-and-heatsink.jpg"},
                new Processor() { ProcessorId = 16, BrandId = 2, ChipsetId = 9, PerformanceCores = 16, TotalThreads = 32, MaxTurboFrequency = 5.7, Cache = 81, IntegratedGraphics = false, Name = "AMD Ryzen 9 7950X" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/7950X.jpg"},
                new Processor() { ProcessorId = 17, BrandId = 2, ChipsetId = 8, PerformanceCores = 10, TotalThreads = 20, MaxTurboFrequency = 4.7, Cache = 60, IntegratedGraphics = false, Name = "AMD Ryzen 7 5750X" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/5750X.jpg"},
                new Processor() { ProcessorId = 18, BrandId = 3, ChipsetId = 10, PerformanceCores = 8, TotalThreads = 8, MaxTurboFrequency = 2.84, Cache = 6.8, IntegratedGraphics = true, Name = "Snapdragon 865 5G" , PhotoUrl = "https://processorinfostorageacc.blob.core.windows.net/processorinfo/snapdragon.jpg"},
            });
            #endregion 
        }
    }
}
