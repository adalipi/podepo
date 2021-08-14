using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Logging;

namespace WEB
{
    public class IndexBase : ComponentBase
    {
        protected int x = 5;

        [Inject]
        ILogger<IndexBase> log { get; set; }

        public IndexBase()
        {
            x = 10;
        }

        public string Ani()
        {
            log.LogInformation("qyqyq");
            return "anbiu";
        }
    }
}
