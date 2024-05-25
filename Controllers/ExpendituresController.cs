using ASP.Net_Templating.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP.Net_Templating.Controllers
{
    public class ExpenditureController : Controller 
    {
        [Route("/{controller}/Display")]
        public IActionResult DisplaySumExpenditures()
        {
            List<Expenditure> depenses = new List<Expenditure>();

            depenses.Add(new Expenditure { Id = 1, Date = new DateOnly(2024, 05, 2), Name = "Chips", Price = 2.35M });
            depenses.Add(new Expenditure { Id = 2, Date = new DateOnly(2024, 05, 18), Name = "Saumon", Price = 13.80M }); 
            depenses.Add(new Expenditure { Id = 3, Date = new DateOnly(2024, 05, 24), Name = "Sneakers", Price = 5.75M }); 

            decimal sommeDepenses = 0; 

            for (int i = 0; i < depenses.Count; i++)
            {
                // Arrondi de 2 chiffres après la virgule
                decimal arrondiDepense = Math.Round(depenses[i].Price, 2);  

                sommeDepenses += arrondiDepense;
            }

            ViewData["somme"] = sommeDepenses; 

            return View(depenses); 
        }
    }
}
