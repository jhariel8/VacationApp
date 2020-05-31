using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace VacationApp.Services
{
    public interface IRequestService
    {
        Task<string> ReadCaseCountByState(string name);
    }
}
