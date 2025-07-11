using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Entities.ViewModels.MissionTheme
{
    public class UpsertMissionThemeRequestModel
    {
        public int Id { get; set; }
        public string ThemeName { get; set; }
        public string Status { get; set; }
    }
}
