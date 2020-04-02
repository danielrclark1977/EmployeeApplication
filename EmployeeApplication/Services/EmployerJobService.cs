using EmployeeApplicationModel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeApplication.Services
{
    public class EmployerJobService
    {
        private List<Jobs> employers = new List<Jobs>();
        public async Task<Jobs[]> GetJobsAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (System.IO.Stream stream = await httpClient.GetStreamAsync(new Uri("https://localhost:44354/EmployerJob")))
                {
                    List<Jobs> jobs = new List<Jobs>();
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
                                    jobs.Add(serializer.Deserialize<Jobs>(reader));
                                }
                            }
                        }
                    }
                    return jobs.ToArray();
                }
            }
        }
    }
}
