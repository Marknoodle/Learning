#pragma checksum "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778693421c47a72abb7b27dd667a32051262ac6a"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\_Imports.razor"
using WebApplication1;

#line default
#line hidden
#line 7 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\_Imports.razor"
using WebApplication1.Shared;

#line default
#line hidden
    [Microsoft.AspNetCore.Components.Layouts.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<h1>Hello, world!</h1>\r\n\r\nWelcome to your new app.\r\n\r\n");
            builder.OpenComponent<WebApplication1.Pages.Counter>(1);
            builder.AddAttribute(2, "IncrementAmount", Microsoft.AspNetCore.Components.RuntimeHelpers.TypeCheck<System.Int32>(
#line 7 "C:\Users\MHOLCOMB\Learning\blazor_test\WebApplication1\Pages\Index.razor"
                          10

#line default
#line hidden
            ));
            builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591