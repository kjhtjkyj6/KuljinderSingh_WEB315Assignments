#pragma checksum "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "347258a814cf745850445127246a3253f35696f4"
// <auto-generated/>
#pragma warning disable 1591
namespace KuljinderSinghChatApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using KuljinderSinghChatApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\singh\OneDrive\Documents\Github\KuljinderSingh_WEB315Assignments\KuljinderSinghChatApp\Client\_Imports.razor"
using KuljinderSinghChatApp.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\n\nWelcome to your new app.\n\n");
            __builder.OpenComponent<KuljinderSinghChatApp.Client.Shared.SurveyPrompt>(1);
            __builder.AddAttribute(2, "Title", "How is Blazor working for you?");
            __builder.CloseComponent();
            __builder.AddMarkupContent(3, "\n");
            __builder.OpenComponent<KuljinderSinghChatApp.Client.Chat>(4);
            __builder.AddAttribute(5, "fixName", "Kuljinder Singh");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
