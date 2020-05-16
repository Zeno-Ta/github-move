using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using cryptinop_cpo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace cryptinopWeb.Controllers
{
    [Authorize]
    public class CategorieActiviteController : Controller
    {
        // GET: CategorieActivite
        string APIurl = "http://localhost:5004/";

        public async Task<ActionResult> Index()
        {
            List<Categorie> CatgInfo = new List<Categorie>();

            using (var client = new HttpClient())
            {
                //Passing service base url  
                client.BaseAddress = new Uri(APIurl);

                client.DefaultRequestHeaders.Clear();

                //Define request data format  
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //Sending request to find web api REST service resource GetCategorie using HttpClient  
                HttpResponseMessage Res = await client.GetAsync("api/CategorieActivite/");

                //Checking the response is successful or not which is sent using HttpClient  
                if (Res.IsSuccessStatusCode)
                {
                    //Storing the response details recieved from web api   
                    var response = Res.Content.ReadAsStringAsync().Result;

                    //Deserializing the response recieved from web api and storing into the Employee list  
                    CatgInfo = JsonConvert.DeserializeObject<List<Categorie>>(response);

                }
                //returning the employee list to view  
                return View(CatgInfo);
            }
        }

        // GET: CategorieActivite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategorieActivite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategorieActivite/Create
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

        // GET: CategorieActivite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CategorieActivite/Edit/5
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

        // GET: CategorieActivite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CategorieActivite/Delete/5
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