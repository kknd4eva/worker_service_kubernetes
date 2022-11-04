using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerService.Models;

namespace WorkerService.Services
{
    public interface IFelineService
    {
        Task<FelineFact> GetFelineFact();
    }
}
