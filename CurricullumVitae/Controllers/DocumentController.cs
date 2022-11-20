using CurricullumVitae.Data.Access;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CurricullumVitae.Controllers
{
    public class DocumentController : Controller
    {
        private readonly IDocumentRepository _documentRepo;
        private readonly IHttpContextAccessor _contextAccessor;
        private readonly IProfilePictureRepository _profilePicRepo;
        private readonly IEducationRepository _educationRepo;
        private readonly IExtraRepository _extraRepo;
        private readonly IWorkExperienceRepository _workExperienceRepo;

        public DocumentController(IDocumentRepository documentRepo, IHttpContextAccessor contextAccessor, IProfilePictureRepository profilePicRepo, IEducationRepository educationRepo, IExtraRepository extraRepo, IWorkExperienceRepository workExperienceRepo)
        {
            _documentRepo = documentRepo;
            _contextAccessor = contextAccessor;
            _profilePicRepo = profilePicRepo;
            _educationRepo = educationRepo;
            _extraRepo = extraRepo;
            _workExperienceRepo = workExperienceRepo;
        }


        // GET: DocumentController
        public async Task<ActionResult> Index()
        {
            var rv = await _documentRepo.Get();
            return View(rv);
        }

        // GET: DocumentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DocumentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DocumentController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DocumentController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DocumentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DocumentController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
