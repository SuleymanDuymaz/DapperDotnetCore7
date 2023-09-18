using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UI.Dtos.BottomGridDtos;

namespace UI.ViewComponents.HomePage
{
    public class BottomGridComponentPartial:ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public BottomGridComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:44333/api/BottomGrids");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultBottomGridDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
