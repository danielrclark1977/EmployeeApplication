using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using EmployeeApplicationModel.Models;
using Newtonsoft.Json;

namespace EmployeeApplication.Services
{
    public class EmployerService
    {
        private List<Employers> employers = new List<Employers>(); 
        public async Task<Employers[]> GetEmployersAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (System.IO.Stream stream = await httpClient.GetStreamAsync(new Uri("https://localhost:44354/Employer")))
                {
                    List<Employers> employers = new List<Employers>();
                    JsonSerializer serializer = new JsonSerializer();
                    using (System.IO.StreamReader sr = new System.IO.StreamReader(stream))
                    {
                        using (JsonReader reader = new JsonTextReader(sr))
                        {
                            while (reader.Read())
                            {
                                // deserialize only when there's "{" character in the stream
                                if (reader.TokenType == JsonToken.StartObject)
                                {
                                    employers.Add(serializer.Deserialize<Employers>(reader));
                                }
                            }
                        }
                    }
                    return employers.ToArray();
                }
            }
        }
    }
}
