using System.Text.Json.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace OOP_Web_Api_Example.Controllers
{
	public class ExampleController : ControllerBase
	{
		[HttpGet]
		[Route("Example")]
		public async Task<IActionResult> Index()
		{
			var result = await GetValue();

			return Ok(result);
		}

		private async Task<JsonPlaceholderModel> GetValue()
		{
			HttpClient client = new HttpClient();

			var result = await client.GetAsync("https://jsonplaceholder.typicode.com/comments/1");

			var returnString = await result.Content.ReadAsStringAsync();

			return JsonConvert.DeserializeObject<JsonPlaceholderModel>(returnString);
		}
	}

	public class JsonPlaceholderModel
	{
		public int PostId { get; set; }
		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Body { get; set; }
	}
}
