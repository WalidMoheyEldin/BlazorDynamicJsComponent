using BlazorDynamicJsComponent.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorDynamicJsComponent.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HtmlComponentsController : ControllerBase
    {
        private static readonly HtmlComponent[] Components = new HtmlComponent[]
        {
            new HtmlComponent{
                Element = HtmlElement.button,
                Content = "Click me",
                Events = new Dictionary<HtmlElementEvent, string>()
                {
                    { HtmlElementEvent.onClick, @"alert('Hi from click event');" },
                    { HtmlElementEvent.onMouseOver, "console.log('Hi from mouse over event');" }
                }
            },
            new HtmlComponent{
                Element = HtmlElement.checkbox,
                Content = "Is True",
                Events = new Dictionary<HtmlElementEvent, string>()
                {
                    { HtmlElementEvent.onChange, "var isTrue = this.checked; alert(`My value changed from ${!isTrue} to ${isTrue}`);" }
                }
            }
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public HtmlComponentsController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<HtmlComponent> Get()
        {
            return Components;
        }
    }
}
