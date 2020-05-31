using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using VacationApp.Models;

namespace VacationApp.Services
{
    public class RequestService
    {
        public async Task<string> ReadCaseCountByState(string name)
        {
            using (HttpClient http = new HttpClient())
            {
                string url = $"https://covidtracking.com/api/v1/states/{name}/current.json";

                string jsonResult = await http.GetStringAsync(url);

                StateInfo info = Newtonsoft.Json.JsonConvert.DeserializeObject<StateInfo>(jsonResult);

                return info.total;
            }
        }
    }
}
