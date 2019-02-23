using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using Model;
namespace Shop.Controllers
{
    public class AchievementsController : ApiController
    {
        AchievementssBll dal = new AchievementssBll();
        [HttpGet]
        public List<Achievements> GetAchievements()
        {
            return dal.GetAchievements();
        }
        [HttpGet]
        public List<Achievements> GetAchievements_1()
        {
            return dal.GetAchievements();
        }
    }
}
