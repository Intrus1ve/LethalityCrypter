#pragma checksum "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Pages\Packages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e042682ecc23553e0057e1b83b89a4c3907c0d6a"
// <auto-generated/>
#pragma warning disable 1591
namespace LethalityCrypter.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using LethalityCrypter.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\_Imports.razor"
using LethalityCrypter.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/packages")]
    public partial class Packages : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"container-fluid\">\r\n    \r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            <div class=\"page-title-box\">\r\n                <h4 class=\"page-title\">Packages</h4>\r\n                <hr>\r\n            </div>\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-lg-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"pricingTable1 text-center\">\r\n                                <h6 class=\"title1 py-3 mt-2 mb-0\">Shared Monthly</h6>\r\n                                <ul class=\"list-unstyled pricing-content-2\">\r\n                                    <li>Startup</li>\r\n                                    <li>Obfuscator</li>\r\n                                    <li>FUD</li>\r\n                                    <li>Shared stub</li>\r\n                                    <li>And other features</li>\r\n                                </ul>\r\n                                <hr class=\"hr-dashed my-4\">\r\n                                <div class=\"text-center\">\r\n                                    <h3 class=\"amount\">$40.00<small class=\"font-12 text-muted\">/mo</small></h3>\r\n                                </div>\r\n                                <div class=\"d-grid\">\r\n                                    <a href=\"https://t.me/lethalitycrypter\" class=\"btn btn-primary btn-skew btn-outline-dashed py-2\"><span>Go Telegram</span></a>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div> \r\n                </div>\r\n\r\n                <div class=\"col-lg-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"pricingTable1 text-center\">\r\n                                <span class=\"badge bg-warning ml-auto a-animate-blink\">POPULAR</span>\r\n\r\n                                <h6 class=\"title1 py-3 mt-2 mb-0\">Private Monthly</h6>\r\n                                <ul class=\"list-unstyled pricing-content-2\">\r\n                                    <li>Startup</li>\r\n                                    <li>Obfuscator</li>\r\n                                    <li>7/24 FUD</li>\r\n                                    <li>Shared stub</li>\r\n                                    <li>And other features</li>\r\n                                </ul>\r\n                                <hr class=\"hr-dashed my-4\">\r\n                                <div class=\"text-center\">\r\n                                    <h3 class=\"amount\">$80.00<small class=\"font-12 text-muted\">/mo</small></h3>\r\n                                </div>\r\n                                <div class=\"d-grid\">\r\n                                    <a href=\"https://t.me/lethalitycrypter\" class=\"btn btn-primary btn-skew btn-outline-dashed py-2\"><span>Go Telegram</span></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n                <div class=\"col-lg-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"pricingTable1 text-center\">\r\n                                <h6 class=\"title1 py-3 mt-2 mb-0\">Shared 3 Monthly</h6>\r\n                                <ul class=\"list-unstyled pricing-content-2\">\r\n                                    <li>Startup</li>\r\n                                    <li>Obfuscator</li>\r\n                                    <li>FUD</li>\r\n                                    <li>Shared stub</li>\r\n                                    <li>And other features</li>\r\n                                </ul>\r\n                                <hr class=\"hr-dashed my-4\">\r\n                                <div class=\"text-center\">\r\n                                    <h3 class=\"amount\">$80.00<small class=\"font-12 text-muted\">/3 mo</small></h3>\r\n                                </div>\r\n                                <div class=\"d-grid\">\r\n                                    <a href=\"https://t.me/lethalitycrypter\" class=\"btn btn-primary btn-skew btn-outline-dashed py-2\"><span>Go Telegram</span></a>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div> \r\n                </div>\r\n\r\n                <div class=\"col-lg-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"pricingTable1 text-center\">\r\n\r\n                                <h6 class=\"title1 py-3 mt-2 mb-0\">Private 3 Monthly</h6>\r\n                                <ul class=\"list-unstyled pricing-content-2\">\r\n                                    <li>Startup</li>\r\n                                    <li>Obfuscator</li>\r\n                                    <li>7/24 FUD</li>\r\n                                    <li>Shared stub</li>\r\n                                    <li>And other features</li>\r\n                                </ul>\r\n                                <hr class=\"hr-dashed my-4\">\r\n                                <div class=\"text-center\">\r\n                                    <h3 class=\"amount\">$220.00<small class=\"font-12 text-muted\">/3 mo</small></h3>\r\n                                </div>\r\n                                <div class=\"d-grid\">\r\n                                    <a href=\"https://t.me/lethalitycrypter\" class=\"btn btn-primary btn-skew btn-outline-dashed py-2\"><span>Go Telegram</span></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n\r\n                <div class=\"col-lg-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"pricingTable1 text-center\">\r\n                                <h6 class=\"title1 py-3 mt-2 mb-0\">Shared Lifetime</h6>\r\n                                <ul class=\"list-unstyled pricing-content-2\">\r\n                                    <li>Startup</li>\r\n                                    <li>Obfuscator</li>\r\n                                    <li>FUD</li>\r\n                                    <li>Shared stub</li>\r\n                                    <li>And other features</li>\r\n                                </ul>\r\n                                <hr class=\"hr-dashed my-4\">\r\n                                <div class=\"text-center\">\r\n                                    <h3 class=\"amount\">$500.00<small class=\"font-12 text-muted\">/lifetime</small></h3>\r\n                                </div>\r\n                                <div class=\"d-grid\">\r\n                                    <a href=\"https://t.me/lethalitycrypter\" class=\"btn btn-primary btn-skew btn-outline-dashed py-2\"><span>Go Telegram</span></a>\r\n                                </div>\r\n\r\n                            </div>\r\n                        </div>\r\n                    </div> \r\n                </div>\r\n\r\n                <div class=\"col-lg-3\">\r\n                    <div class=\"card\">\r\n                        <div class=\"card-body\">\r\n                            <div class=\"pricingTable1 text-center\">\r\n                                <h6 class=\"title1 py-3 mt-2 mb-0\">Private Lifetime</h6>\r\n                                <ul class=\"list-unstyled pricing-content-2\">\r\n                                    <li>Startup</li>\r\n                                    <li>Obfuscator</li>\r\n                                    <li>7/24 FUD</li>\r\n                                    <li>Shared stub</li>\r\n                                    <li>And other features</li>\r\n                                </ul>\r\n                                <hr class=\"hr-dashed my-4\">\r\n                                <div class=\"text-center\">\r\n                                    <h3 class=\"amount\">$1000.00<small class=\"font-12 text-muted\">/lifetime</small></h3>\r\n                                </div>\r\n                                <div class=\"d-grid\">\r\n                                    <a href=\"https://t.me/lethalitycrypter\" class=\"btn btn-primary btn-skew btn-outline-dashed py-2\"><span>Go Telegram</span></a>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n    \r\n\r\n\r\n</div>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
