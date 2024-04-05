using Microsoft.AspNetCore.Mvc;
using TestLearningProjects.Models;

namespace TestLearningProjects.Controllers
{
    public class PassingListJSToController : Controller
    {
        public ActionResult SenddingList()
        {
            return View();
        }

        [HttpPost]
        public void ReceiveList(List<PassingList> rcList)
        {
            //Save Into Database Or Do Smth Else 
            rcList.ForEach(rc =>
            {
                Console.WriteLine(rc);
            });
        }
    }
}
