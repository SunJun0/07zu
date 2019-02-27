using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
namespace BLL
{
    public class AchievementssBll
    {
        AchievementssDal dal = new AchievementssDal();
        public List<Achievements> GetAchievements()
        {
            return dal.GetAchievements();
        }
        public List<Achievements> GetAchievements_1()
        {
            return dal.GetAchievements_1();
        }

    }
}
