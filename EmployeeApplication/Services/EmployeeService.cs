using EmployeeApplicationModel.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace EmployeeApplication.Services
{
    public class EmployeeService
    {
        public async Task<IEnumerable<Employees>> GetEmployeesAsync()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (System.IO.Stream stream = await httpClient.GetStreamAsync(new Uri("https://localhost:44354/Employee")))
                {
                    List<Employees> employees = new List<Employees>();
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
                                    employees.Add(serializer.Deserialize<Employees>(reader));
                                }
                            }
                        }
                    }
                    return employees.ToArray();
                }
            }
        }

        public async Task<Employees> GetEmployeeAsync(int Id)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                using (System.IO.Stream stream = await httpClient.GetStreamAsync(new Uri("https://localhost:44354/Employee/Id")))
                {
                    return await System.Text.Json.JsonSerializer.DeserializeAsync<Employees>(stream);
                }
            }
        }
    }
}
