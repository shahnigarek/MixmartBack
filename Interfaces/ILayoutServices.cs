using MixmartBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MixmartBackEnd.Interfaces
{
    public interface ILayoutServices
    {
        Task<Dictionary<string, string>> GetSettingsAsync();

        Task<AppUser> GetUserAsync();
    }
}
