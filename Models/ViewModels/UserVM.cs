using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace WebLearningMVCEF.Models.ViewModels
{
    public class UserVM
    {
        public User User { get; set; }
        public IEnumerable<SelectListItem> RolesTypesDropDown { get; set; }
    }
}
