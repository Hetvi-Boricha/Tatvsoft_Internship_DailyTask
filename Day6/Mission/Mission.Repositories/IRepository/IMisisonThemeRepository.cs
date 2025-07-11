using Mission.Entities.ViewModels.MissionTheme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Repositories.IRepository
{
    public interface IMissionThemeRepository
    {
        Task AddMissionThemeAsync(UpsertMissionThemeRequestModel model);

        Task<List<MissionThemeResponseModel>> GetMissionThemeListAsync();

        Task<MissionThemeResponseModel?> GetMissionThemeByIdAsync(int missionThemeId);
        Task<bool> UpdateMissionThemeAsync(UpsertMissionThemeRequestModel model);

        Task<bool> DeleteMissionTheme(int id);
    }
}
