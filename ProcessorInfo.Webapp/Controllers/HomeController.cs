using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using ProcessorInfo.Models;
using ProcessorInfo.Repository.Data;
using ProcessorInfo.Webapp.Models;
using System.Data;
using System.Diagnostics;

namespace ProcessorInfo.Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<SiteUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ProcessorInfoDbContext _db;
        private readonly IEmailSender _emailSender;

        BlobServiceClient serviceClient;
        BlobContainerClient containerClient;

        public HomeController(ILogger<HomeController> logger, UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager, ProcessorInfoDbContext db, IEmailSender emailSender)
        {
            _logger = logger;
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            _emailSender = emailSender;
            serviceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=processorinfostorageacc;AccountKey=H5R28IGtvhTXGhaeNDqjHRLVNwwyWUp+hwfOy+dk7/tvf39djt3aa32vIOTGqm/9VTZgrV0pYBeb+AStv9YUkg==;EndpointSuffix=core.windows.net");
            containerClient = serviceClient.GetBlobContainerClient("processorinfo");

        }
        public async Task<IActionResult> DelegateAdmin()
        {
            var principal = this.User;
            var user = await _userManager.GetUserAsync(principal);
            var role = new IdentityRole()
            {
                Name = "Admin"
            };
            if (!await _roleManager.RoleExistsAsync("Admin"))
            {
                await _roleManager.CreateAsync(role);
            }
            await _userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Index));
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
            await _userManager.RemoveFromRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Users));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GrantAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
            await _userManager.AddToRoleAsync(user, "Admin");
            return RedirectToAction(nameof(Users));
        }
        #region Views

        [Authorize(Roles = "Admin")]
        public IActionResult Users()
        {
            return View(_userManager.Users);
        }

        public IActionResult Index()
        {
            return View(_db.Processors);
        }

        public IActionResult BrandView()
        {
            return View(_db.Brands);
        }
        public IActionResult ChipsetView()
        {
            return View(_db.Chipsets);
        }
        public IActionResult Statistics()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        #endregion

        #region Add
        [Authorize]
        public IActionResult AddProcessor()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddProcessor([FromForm] Processor processor, [FromForm] IFormFile photoUpload)
        {
            BlobClient blobClient = containerClient.GetBlobClient(processor.ProcessorId + "_" +processor.Name.Replace(" ", "").ToLower());
            using (var uploadFileStream = photoUpload.OpenReadStream())
            {
                await blobClient.UploadAsync(uploadFileStream, true);
            }
            blobClient.SetAccessTier(AccessTier.Cool);
            processor.PhotoUrl = blobClient.Uri.AbsoluteUri;

            _db.Processors.Add(processor);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Authorize]
        public IActionResult AddChipset()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddChipset([FromForm] Chipset chipset, [FromForm] IFormFile photoUpload)
        {
            BlobClient blobClient = containerClient.GetBlobClient(chipset.ChipsetId + "_" + chipset.Name.Replace(" ", "").ToLower());
            using (var uploadFileStream = photoUpload.OpenReadStream())
            {
                await blobClient.UploadAsync(uploadFileStream, true);
            }
            blobClient.SetAccessTier(AccessTier.Cool);
            chipset.PhotoUrl = blobClient.Uri.AbsoluteUri;

            _db.Chipsets.Add(chipset);
            _db.SaveChanges();
            return RedirectToAction(nameof(ChipsetView));
        }

        [Authorize]
        public IActionResult AddBrand()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddBrand([FromForm] Brand brand, [FromForm] IFormFile photoUpload)
        {
            BlobClient blobClient = containerClient.GetBlobClient(brand.BrandId + "_" + brand.Name.Replace(" ", "").ToLower());
            using (var uploadFileStream = photoUpload.OpenReadStream())
            {
                await blobClient.UploadAsync(uploadFileStream, true);
            }
            blobClient.SetAccessTier(AccessTier.Cool);
            brand.PhotoUrl = blobClient.Uri.AbsoluteUri;

            _db.Brands.Add(brand);
            _db.SaveChanges();
            return RedirectToAction(nameof(BrandView));
        }

        #endregion

        #region Update

        [Authorize(Roles = "Admin")]
        public IActionResult UpdateBrand(int id)
        {
            var brand = _db.Brands.FirstOrDefault(b => b.BrandId == id);
            if (brand == null)
            {
                return NotFound();
            }
            return View(brand);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult UpdateBrand(int id, [FromForm] Brand updatedBrand)
        {
            var brand = _db.Brands.FirstOrDefault(b => b.BrandId == id);
            if (brand == null)
            {
                return NotFound();
            }

            brand.Name = updatedBrand.Name;

            _db.Brands.Update(brand);
            _db.SaveChanges();
            return RedirectToAction(nameof(BrandView));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult UpdateProcessor(int id)
        {
            var processor = _db.Processors.FirstOrDefault(p => p.ProcessorId == id);
            if (processor == null)
            {
                return NotFound();
            }
            return View(processor);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult UpdateProcessor(int id, [FromForm] Processor updatedProcessor)
        {
            var processor = _db.Processors.FirstOrDefault(p => p.ProcessorId == id);
            if (processor == null)
            {
                return NotFound();
            }

            processor.Name = updatedProcessor.Name;
            processor.PerformanceCores = updatedProcessor.PerformanceCores;
            processor.EfficencyCores = updatedProcessor.EfficencyCores;
            processor.TotalThreads = updatedProcessor.TotalThreads;
            processor.MaxTurboFrequency = updatedProcessor.MaxTurboFrequency;
            processor.Cache = updatedProcessor.Cache;
            processor.IntegratedGraphics = updatedProcessor.IntegratedGraphics;

            _db.Processors.Update(processor);
            _db.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public IActionResult UpdateChipset(int id)
        {
            var chipset = _db.Chipsets.FirstOrDefault(c => c.ChipsetId == id);
            if (chipset == null)
            {
                return NotFound();
            }
            return View(chipset);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public IActionResult UpdateChipset(int id, [FromForm] Chipset updatedChipset)
        {
            var chipset = _db.Chipsets.FirstOrDefault(c => c.ChipsetId == id);
            if (chipset == null)
            {
                return NotFound();
            }

            chipset.Name = updatedChipset.Name;

            _db.Chipsets.Update(chipset);
            _db.SaveChanges();
            return RedirectToAction(nameof(ChipsetView));
        }

        #endregion

    }
}