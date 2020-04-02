using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using EmployeeApplicationModel.Models;
using Newtonsoft.Json;

namespace EmployeeApplication.Services
{
    public class SkillService
    {
        public async Task<Skills[]> GetSkillsAsync(int Id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                string uri = "https://localhost:44354/Skill/{" + Id + "}";
                using (System.IO.Stream stream = await httpClient.GetStreamAsync(new Uri(uri)))
                {
                    List<Skills> skills = new List<Skills>();
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
                                    skills.Add(serializer.Deserialize<Skills>(reader));
                                }
                            }
                        }
                    }
                    return skills.ToArray();
                }
            }
        }
    }
}
