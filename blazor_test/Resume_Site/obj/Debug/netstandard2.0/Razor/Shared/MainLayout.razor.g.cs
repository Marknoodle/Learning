#pragma checksum "C:\Users\markh\Learning\blazor_test\Resume_Site\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ab2f25955f17a8bba9e55caae984f2b7381bdde"
// <auto-generated/>
#pragma warning disable 1591
namespace Resume_Site.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "C:\Users\markh\Learning\blazor_test\Resume_Site\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#line 2 "C:\Users\markh\Learning\blazor_test\Resume_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 3 "C:\Users\markh\Learning\blazor_test\Resume_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Layouts;

#line default
#line hidden
#line 4 "C:\Users\markh\Learning\blazor_test\Resume_Site\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#line 5 "C:\Users\markh\Learning\blazor_test\Resume_Site\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 6 "C:\Users\markh\Learning\blazor_test\Resume_Site\_Imports.razor"
using Resume_Site;

#line default
#line hidden
#line 7 "C:\Users\markh\Learning\blazor_test\Resume_Site\_Imports.razor"
using Resume_Site.Shared;

#line default
#line hidden
    public class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.RenderTree.RenderTreeBuilder builder)
        {
            builder.OpenElement(0, "div");
            builder.AddAttribute(1, "class", "sidebar");
            builder.AddMarkupContent(2, "\r\n    ");
            builder.OpenComponent<Resume_Site.Shared.NavMenu>(3);
            builder.CloseComponent();
            builder.AddMarkupContent(4, "\r\n");
            builder.CloseElement();
            builder.AddMarkupContent(5, "\r\n\r\n");
            builder.OpenElement(6, "div");
            builder.AddAttribute(7, "class", "main");
            builder.AddMarkupContent(8, "\r\n    ");
            builder.AddMarkupContent(9, "<div class=\"top-row px-4\">\r\n        <a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\">About</a>\r\n    </div>\r\n\r\n    ");
            builder.OpenElement(10, "div");
            builder.AddAttribute(11, "class", "content px-4");
            builder.AddMarkupContent(12, "\r\n        ");
            builder.AddContent(13, 
#line 13 "C:\Users\markh\Learning\blazor_test\Resume_Site\Shared\MainLayout.razor"
         Body

#line default
#line hidden
            );
            builder.AddMarkupContent(14, "\r\n    ");
            builder.CloseElement();
            builder.AddMarkupContent(15, "\r\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
