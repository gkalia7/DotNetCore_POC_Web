using DotNetCore_POC_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace DotNetCore_POC_Web.Controllers {
    public class SearchController : Controller {
        private readonly ILogger<SearchController> _logger;

        public SearchController(ILogger<SearchController> logger) {
            _logger = logger;
        }

        // GET: SearchController
        public ActionResult Index() {
            return View();
        }

        [HttpPost]
        public IActionResult Index(SearchParameterModel searchParameters) {
            if(ModelState.IsValid) {
                //now call for api from here
                string certId = searchParameters.CertId;
                DateTime startDate = searchParameters.StartDate;
                DateTime endDate = searchParameters.EndDate;

                // if api returns false then show not found

                //otherwise create template for table on searchresult method
                IList<FinalSearchResultModel> finalSearchResultList = new List<FinalSearchResultModel>() {
                new FinalSearchResultModel() {
                    Name = "Gaurav Kalia",
                    City = "Amritsar",
                    Pincode = "143001",
                    Country = "India"
                },new FinalSearchResultModel() {
                    Name = "Taran Kalia",
                    City = "Chandigarh",
                    Pincode = "160047",
                    Country = "India"
                },new FinalSearchResultModel() {
                    Name = "Harjot Singh",
                    City = "Chandigarh",
                    Pincode = "160001",
                    Country = "India"
                },new FinalSearchResultModel() {
                    Name = "Saurav Kalia",
                    City = "Delhi",
                    Pincode = "110001",
                    Country = "India"
                }
                };
                return View("SearchResult", finalSearchResultList);
            }
            else
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
