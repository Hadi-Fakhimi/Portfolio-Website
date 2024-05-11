using Resume.Domain.ViewModels.Education;
using Resume.Domain.ViewModels.Experience;
using Resume.Domain.ViewModels.Skill;
using System.Collections.Generic;

namespace Resume.Domain.ViewModels.Page
{
    public class ResumePageViewModel
    {
        public List<EducationViewModel> Education { get; set; }
        public List<ExperienceViewModel> Experience { get; set; }
        public List<SkillViewModel> Skill { get; set; }


    }
}
