using Microsoft.AspNetCore.Components;
using PP.Attractions;
using System.Threading.Tasks;

namespace PP.Blazor.Pages
{
    public partial class Index
    {
        [Inject]
        private IAttractionAppService AttractionAppService { get; set; }
        private AttractionDto attraction = new AttractionDto();

        protected async override Task OnInitializedAsync()
        {
            attraction = await AttractionAppService.GetOne(System.Guid.Parse("2EA5C79F-C268-8BC0-A785-39FB355C16B6"));
        }
    }
}
