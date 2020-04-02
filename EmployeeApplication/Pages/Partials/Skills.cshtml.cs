using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using EmployeeApplicationModel.Models;
using EmployeeApplication.Services;

namespace EmployeeApplication.Pages
{
    public class SkillsModel : PageModel
    {
        List<Skills> skills = new List<Skills>();
        SkillService skillService = new SkillService();
        public void OnGet()
        {
            skills.AddRange(skillService.GetSkillsAsync(1).Result);
        }
    }
}