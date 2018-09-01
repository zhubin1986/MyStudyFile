using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyMVC.Models;
using StudyMod;

namespace MyMVC.Controllers
{
    public class MyStudyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult MyOrgChartTest()
        {
            var list = GetData(); 
            string strList= Newtonsoft.Json.JsonConvert.SerializeObject(list);
            //strList = strList.Replace(",\"SubList\":[],\"FMod\":null", "");
            //strList = strList.Replace(",\"FMod\":null", "");
            //strList = strList.Replace('"', '\'');
            ViewBag.OrgChartData = strList;

            return View();
        }
        
        public JsonResult GetDataList()
        {
            return Json(GetData());
        }

        public JobMod GetData() {

            //reList.Add(new JobMod() { Id = 1, Fid = 0, JobName = "总经理", Level = 1 });
            //reList.Add(new JobMod() { Id = 2, Fid = 0, JobName = "董事长", Level = 1 });
            //reList[0].SubList = new List<JobMod>();
            //reList[0].SubList.Add(new JobMod() { Id = 3, Fid = 1, JobName = "风控部", Level = 2 });
            //reList[0].SubList.Add(new JobMod() { Id = 4, Fid = 1, JobName = "会计部", Level = 2 });
            //reList[0].SubList.Add(new JobMod() { Id = 5, Fid = 1, JobName = "食堂", Level = 2 });
            //reList[0].SubList[0].SubList = new List<JobMod>();
            //reList[0].SubList[0].SubList.Add(new JobMod() { Id = 6, Fid = 3, JobName = "总监", Level = 3 });
            JobMod mod1 = new JobMod() { Id = 1, Fid = 0, JobName = "总经理", Level = 1 };
            JobMod mod2 = new JobMod() { Id = 2, Fid = 0, JobName = "董事长", Level = 1 };
            JobMod mod3 = new JobMod() { Id = 3, Fid = 1, JobName = "风控部", Level = 2 };
            JobMod mod6 = new JobMod() { Id = 6, Fid = 3, JobName = "总监", Level = 3 };
            mod3.SubList.Add(mod6);
            mod1.SubList.Add(mod3);
            JobMod mod4 = new JobMod() { Id = 4, Fid = 1, JobName = "会计部", Level = 2 };
            mod1.SubList.Add(mod4);
            JobMod mod5 = new JobMod() { Id = 5, Fid = 1, JobName = "食堂", Level = 2 };
            mod1.SubList.Add(mod5);
            return mod1;
        }


    }
}
