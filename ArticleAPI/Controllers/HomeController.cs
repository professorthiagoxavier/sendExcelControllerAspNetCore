using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArticleAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ArticleAPI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public IActionResult ReadFile()
        {


            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Import(List<IFormFile> files)
        {
            var article = new Article();
            string awaitForDone ;
            using (var reader = new StreamReader(files.FirstOrDefault().OpenReadStream()))
            {
                while (reader.Peek() >= 0)
                {
                    var linha = await reader.ReadLineAsync();


                    if (linha.StartsWith("PT"))
                        article.Publicacao = linha.Substring(3);

                    if (linha.StartsWith("AU"))
                    {
                        
                    }

                    if (linha.StartsWith("LA"))
                        article.Language = linha.Substring(3);

                    if (linha.StartsWith("CR"))
                    {



                    }


                }
            }
            return Ok(article);
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Home/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}