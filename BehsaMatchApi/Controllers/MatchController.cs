using BehsaMatchApi.Model;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace BehsaMatchApi.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        
    

        private readonly ILogger<MatchController> _logger;

        public MatchController(ILogger<MatchController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> TestApi()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, "https://portal.behsacorp.com/rest/confiforms/1.0/get/101613581/TestAPI/7a098331-3a09-4515-ad93-34ab67e6adf2");
            request.Headers.Add("Authorization", "Basic YS5lc2hnaGl6YWRlaDpBZUA0MzIxNDMyMTQzMjE=");
            request.Headers.Add("Cookie", "JSESSIONID=1FBA1604488FD05C2FAC973D12CBBB5A; cookiesession1=678ADA69B4AB2307942B990C8693E41C");
            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var body = await response.Content.ReadAsStringAsync();

            GeneralResponse res = JsonConvert.DeserializeObject<GeneralResponse>(body);

            return Ok(res);
            //string apiUrl = "https://portal.behsacorp.com/rest/confiforms/1.0/get/101613581/TestAPI/7a098331-3a09-4515-ad93-34ab67e6adf2";
            //string username = "a.eshghizadeh";
            //string password = "Ae@432143214321";

            //// Create a HttpClient with Basic Authentication
            //HttpClient client = new HttpClient();
            //string authHeaderValue = Convert.ToBase64String(Encoding.ASCII.GetBytes($"{username}:{password}"));
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
            //string responseBody = "";
            //try
            //{
            //    HttpResponseMessage response = await client.GetAsync(apiUrl);

            //    if (response.IsSuccessStatusCode)
            //    {
            //         responseBody = await response.Content.ReadAsStringAsync();

            //    }
            //    else
            //    {

            //    }
            //}
            //catch (HttpRequestException ex)
            //{

            //}
            //finally
            //{
            //    client.Dispose();
            //}
            //return Ok(responseBody);
        }


        [HttpGet]
        public async Task<IActionResult> TestCheckStringApi(string input)
        {

            return Ok();
            
        }

        [HttpGet]
        public async Task<IActionResult> TestCheckDecimalApi(decimal input)
        {

            return Ok();

        }
    }
}