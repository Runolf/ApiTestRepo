using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsumeAPI_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Get api/Employee
            {

                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:44301/api/");

                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Response = client.GetAsync("Employee").Result;

                Response.EnsureSuccessStatusCode();

                string Content = Response.Content.ReadAsStringAsync().Result;


                IEnumerable<Employee> Employees = JsonConvert.DeserializeObject<Employee[]>(Content);

                foreach (Employee Employee in Employees)
                {
                    Console.WriteLine($"{Employee.ID} : {Employee.Lastname} {Employee.Firstname}");
                }
            }
            #endregion

            #region Get api/Employee/15
            //{
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:53657/api/");

            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //HttpResponseMessage Response = client.GetAsync("Employee/15").Result;

            //Response.EnsureSuccessStatusCode();

            //string Content = Response.Content.ReadAsStringAsync().Result;

            //Employee Employee = JsonConvert.DeserializeObject<Employee>(Content);

            //Console.WriteLine($"{Employee.ID} : {Employee.Lastname} {Employee.Firstname}");
            //}
            #endregion

            #region Get api/Employee/BySectionID/1110
            {
                //HttpClient client = new HttpClient();
                //client.BaseAddress = new Uri("http://localhost:53657/api/");

                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //HttpResponseMessage Response = client.GetAsync("Employee/BySectionID/1110").Result;

                //Response.EnsureSuccessStatusCode();

                //string Content = Response.Content.ReadAsStringAsync().Result;

                //IEnumerable<Employee> Employees = JsonConvert.DeserializeObject<Employee[]>(Content);

                //foreach (Employee Employee in Employees)
                //{
                //    Console.WriteLine($"{Employee.Id} : {Employee.LastName} {Employee.FirstName}");
                //}
            }
            #endregion


             Employee st = new Employee() {Lastname = "Lisam", Firstname = "Alexi"};
                #region Post
                {
                    //HttpClient client = new HttpClient();
                    //client.BaseAddress = new Uri("http://localhost:44301/api/");

                    //client.DefaultRequestHeaders.Accept.Clear();
                    //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    //string json = JsonConvert.SerializeObject(st);
                        
                    //HttpContent JsonContent = new StringContent(json);

                    //JsonContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

                    //HttpResponseMessage Response = client.PostAsync("Employee", JsonContent).Result;

                    //Response.EnsureSuccessStatusCode();

                    //string Content = Response.Content.ReadAsStringAsync().Result;

                    //st = JsonConvert.DeserializeObject<Employee>(Content);

                    //Console.WriteLine($"{st.ID} : {st.Lastname} {st.Firstname}");
                }
                #endregion

                #region Put
                {
            //    st.LastName = "Smith";
            //st.FirstName = "Hannibal";

            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("http://localhost:53657/api/");

            //client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //string json = JsonConvert.SerializeObject(st);
            //HttpContent JsonContent = new StringContent(json);
            //JsonContent.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            //HttpResponseMessage Response = client.PutAsync("Employee/" + st.Id, JsonContent).Result;
                                               
            //Response.EnsureSuccessStatusCode();

            //string Content = Response.Content.ReadAsStringAsync().Result;

            //bool result = JsonConvert.DeserializeObject<bool>(Content);

            //Console.WriteLine(result);
            }
            #endregion

            #region Delete
            //{
            //    HttpClient client = new HttpClient();
            //    client.BaseAddress = new Uri("http://localhost:53657/api/");

            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //    HttpResponseMessage Response = client.DeleteAsync("Employee/" + st.Id).Result;

            //    Response.EnsureSuccessStatusCode();

            //    string Content = Response.Content.ReadAsStringAsync().Result;

            //    bool result = JsonConvert.DeserializeObject<bool>(Content);

            //    Console.WriteLine(result);
            //}
            #endregion

            Console.ReadLine();




        }
    }
}
