#pragma checksum "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c0da26f3e926dd53fd7b89167fe0544eae1d97c"
// <auto-generated/>
#pragma warning disable 1591
namespace LethalityCrypter.Client.Shared
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
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
 if (LethalityCrypter.Client.Providers.AuthProvider.CurrentUser != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "sidebar");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenComponent<LethalityCrypter.Client.Shared.NavMenu>(4);
            __builder.CloseComponent();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.AddContent(7, "    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddMarkupContent(10, "\r\n        ");
            __builder.OpenElement(11, "div");
            __builder.AddMarkupContent(12, "\r\n            ");
#nullable restore
#line 13 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
__builder.AddContent(13, Body);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 16 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
}

else
{
    #region Login
    if (!WantRegister)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "        ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "container-md");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row vh-100 d-flex justify-content-center");
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-12 align-self-center");
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "card-body");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row");
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "col-lg-4 mx-auto");
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "card");
            __builder.AddMarkupContent(38, "\r\n                                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "card-body pt-0");
            __builder.AddMarkupContent(41, "\r\n                                        ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "my-4");
            __builder.AddMarkupContent(44, "\r\n                                            ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "form-group mb-2");
            __builder.AddMarkupContent(47, "\r\n                                                ");
            __builder.AddMarkupContent(48, "<label class=\"form-label\" for=\"username\">Mail</label>\r\n                                                ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "email");
            __builder.AddAttribute(51, "class", "form-control");
            __builder.AddAttribute(52, "id", "mail");
            __builder.AddAttribute(53, "name", "mail");
            __builder.AddAttribute(54, "placeholder", "Type your username");
            __builder.AddAttribute(55, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                          (e) => { Mail = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                        Mail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Mail = __value, Mail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n\r\n                                            ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "form-group");
            __builder.AddMarkupContent(62, "\r\n                                                ");
            __builder.AddMarkupContent(63, "<label class=\"form-label\" for=\"userpassword\">Password</label>\r\n                                                ");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "password");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "name", "password");
            __builder.AddAttribute(68, "id", "userpassword");
            __builder.AddAttribute(69, "placeholder", "Type your password");
            __builder.AddAttribute(70, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                                             (e) => { Password = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 39 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                       Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n\r\n                                            ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "form-group mb-0 row");
            __builder.AddMarkupContent(77, "\r\n                                                ");
            __builder.OpenElement(78, "div");
            __builder.AddAttribute(79, "class", "col-12");
            __builder.AddMarkupContent(80, "\r\n                                                    ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "d-grid mt-3");
            __builder.AddMarkupContent(83, "\r\n                                                        ");
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "class", "btn btn-primary");
            __builder.AddAttribute(86, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                  Login

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(87, "data-toggle", "modal");
            __builder.AddAttribute(88, "data-target", "#exampleModalCenter");
            __builder.AddMarkupContent(89, "Login <i class=\"fas fa-sign-in-alt ms-1\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n                                        ");
            __builder.OpenElement(95, "div");
            __builder.AddAttribute(96, "class", "m-3 text-center text-muted");
            __builder.AddMarkupContent(97, "\r\n                                            ");
            __builder.OpenElement(98, "a");
            __builder.AddAttribute(99, "class", "mb-0");
            __builder.AddAttribute(100, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                      ((e) => { WantRegister = true; })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(101, "href", "");
            __builder.AddContent(102, "Do you want register?");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                         if (Error)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(105, "                                            <hr class=\"hr-dashed mt-4\">\r\n                                            ");
            __builder.OpenElement(106, "h4");
            __builder.AddAttribute(107, "class", "fw-semibold text-danger font-18 text-center");
#nullable restore
#line 57 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
__builder.AddContent(108, ErrorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 58 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(118, "\r\n");
#nullable restore
#line 67 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
    }
    #endregion

    #region Register
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(119, "        ");
            __builder.OpenElement(120, "div");
            __builder.AddAttribute(121, "class", "container-md");
            __builder.AddMarkupContent(122, "\r\n            ");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "row vh-100 d-flex justify-content-center");
            __builder.AddMarkupContent(125, "\r\n                ");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-12 align-self-center");
            __builder.AddMarkupContent(128, "\r\n                    ");
            __builder.OpenElement(129, "div");
            __builder.AddAttribute(130, "class", "card-body");
            __builder.AddMarkupContent(131, "\r\n                        ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "row");
            __builder.AddMarkupContent(134, "\r\n                            ");
            __builder.OpenElement(135, "div");
            __builder.AddAttribute(136, "class", "col-lg-4 mx-auto");
            __builder.AddMarkupContent(137, "\r\n                                ");
            __builder.OpenElement(138, "div");
            __builder.AddAttribute(139, "class", "card");
            __builder.AddMarkupContent(140, "\r\n                                    ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "card-body pt-0");
            __builder.AddMarkupContent(143, "\r\n                                        ");
            __builder.OpenElement(144, "div");
            __builder.AddAttribute(145, "class", "my-4");
            __builder.AddMarkupContent(146, "\r\n                                            ");
            __builder.OpenElement(147, "div");
            __builder.AddAttribute(148, "class", "form-group mb-2");
            __builder.AddMarkupContent(149, "\r\n                                                ");
            __builder.AddMarkupContent(150, "<label class=\"form-label\" for=\"username\">Mail</label>\r\n                                                ");
            __builder.OpenElement(151, "input");
            __builder.AddAttribute(152, "type", "email");
            __builder.AddAttribute(153, "class", "form-control");
            __builder.AddAttribute(154, "id", "mail");
            __builder.AddAttribute(155, "name", "mail");
            __builder.AddAttribute(156, "placeholder", "Type your mail");
            __builder.AddAttribute(157, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                      (e) => { Mail = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(158, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 84 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                    Mail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(159, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Mail = __value, Mail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(160, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(161, "\r\n\r\n                                            ");
            __builder.OpenElement(162, "div");
            __builder.AddAttribute(163, "class", "form-group mb-2");
            __builder.AddMarkupContent(164, "\r\n                                                ");
            __builder.AddMarkupContent(165, "<label class=\"form-label\" for=\"username\">Display Name</label>\r\n                                                ");
            __builder.OpenElement(166, "input");
            __builder.AddAttribute(167, "type", "email");
            __builder.AddAttribute(168, "class", "form-control");
            __builder.AddAttribute(169, "id", "displayname");
            __builder.AddAttribute(170, "name", "displayname");
            __builder.AddAttribute(171, "placeholder", "Type your name");
            __builder.AddAttribute(172, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                                           (e) => { DisplayName = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(173, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 89 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                  DisplayName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(174, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DisplayName = __value, DisplayName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(175, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(176, "\r\n\r\n                                            ");
            __builder.OpenElement(177, "div");
            __builder.AddAttribute(178, "class", "form-group mb-2");
            __builder.AddMarkupContent(179, "\r\n                                                ");
            __builder.AddMarkupContent(180, "<label class=\"form-label\" for=\"userpassword\">Password</label>\r\n                                                ");
            __builder.OpenElement(181, "input");
            __builder.AddAttribute(182, "type", "password");
            __builder.AddAttribute(183, "class", "form-control");
            __builder.AddAttribute(184, "name", "password");
            __builder.AddAttribute(185, "id", "password");
            __builder.AddAttribute(186, "placeholder", "Type your password");
            __builder.AddAttribute(187, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                                         (e) => { Password = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(188, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 94 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                   Password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(189, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Password = __value, Password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n\r\n                                            ");
            __builder.OpenElement(192, "div");
            __builder.AddAttribute(193, "class", "form-group mb-2");
            __builder.AddMarkupContent(194, "\r\n                                                ");
            __builder.AddMarkupContent(195, "<label class=\"form-label\" for=\"userpassword\">Password Again</label>\r\n                                                ");
            __builder.OpenElement(196, "input");
            __builder.AddAttribute(197, "type", "password");
            __builder.AddAttribute(198, "class", "form-control");
            __builder.AddAttribute(199, "name", "passwordagain");
            __builder.AddAttribute(200, "id", "passwordagain");
            __builder.AddAttribute(201, "placeholder", "Type your pasword again");
            __builder.AddAttribute(202, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                                                             (e) => { PasswordAgain = (string)e.Value;}

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(203, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 99 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                                                                                                  PasswordAgain

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(204, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => PasswordAgain = __value, PasswordAgain));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(205, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(206, "\r\n\r\n                                            ");
            __builder.OpenElement(207, "div");
            __builder.AddAttribute(208, "class", "form-group mb-0 row");
            __builder.AddMarkupContent(209, "\r\n                                                ");
            __builder.OpenElement(210, "div");
            __builder.AddAttribute(211, "class", "col-12");
            __builder.AddMarkupContent(212, "\r\n                                                    ");
            __builder.OpenElement(213, "div");
            __builder.AddAttribute(214, "class", "d-grid mt-3");
            __builder.AddMarkupContent(215, "\r\n                                                        ");
            __builder.OpenElement(216, "button");
            __builder.AddAttribute(217, "class", "btn btn-primary");
            __builder.AddAttribute(218, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 105 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                                                  Register

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(219, "data-toggle", "modal");
            __builder.AddAttribute(220, "data-target", "#exampleModalCenter");
            __builder.AddMarkupContent(221, "Register <i class=\"fas fa-sign-in-alt ms-1\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(222, "\r\n                                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\r\n                                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(224, "\r\n                                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(225, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(226, "\r\n\r\n                                        ");
            __builder.OpenElement(227, "div");
            __builder.AddAttribute(228, "class", "m-3 text-center text-muted");
            __builder.AddMarkupContent(229, "\r\n                                            ");
            __builder.OpenElement(230, "a");
            __builder.AddAttribute(231, "class", "mb-0");
            __builder.AddAttribute(232, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 112 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                                                      ((e) => { WantRegister = false; })

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(233, "href", "");
            __builder.AddContent(234, "Do you want login?");
            __builder.CloseElement();
            __builder.AddMarkupContent(235, "\r\n                                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(236, "\r\n\r\n");
#nullable restore
#line 115 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                         if (Error)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(237, "                                            <hr class=\"hr-dashed mt-4\">\r\n                                            ");
            __builder.OpenElement(238, "h4");
            __builder.AddAttribute(239, "class", "fw-semibold text-danger font-18 text-center");
#nullable restore
#line 118 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
__builder.AddContent(240, ErrorMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(241, "\r\n");
#nullable restore
#line 119 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(242, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(243, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(244, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(245, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(246, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(247, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(248, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(249, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(250, "\r\n");
#nullable restore
#line 128 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
    }
    #endregion
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(251, "\r\n\r\n");
            __builder.AddMarkupContent(252, "<style>\r\n    app {\r\n        position: relative;\r\n        display: flex;\r\n        flex-direction: column;\r\n    }\r\n\r\n    .top-row {\r\n        height: 3.5rem;\r\n        display: flex;\r\n        align-items: center;\r\n    }\r\n\r\n    .main {\r\n        flex: 1;\r\n    }\r\n\r\n        .main .top-row {\r\n            background-color: #f7f7f7;\r\n            border-bottom: 1px solid #d6d5d5;\r\n            justify-content: flex-end;\r\n        }\r\n\r\n            .main .top-row a:first-child {\r\n                overflow: hidden;\r\n                text-overflow: ellipsis;\r\n            }\r\n\r\n    .sidebar .oi {\r\n        width: 2rem;\r\n        font-size: 1.1rem;\r\n        vertical-align: text-top;\r\n        top: -2px;\r\n    }\r\n\r\n    .content {\r\n        padding-top: 1.1rem;\r\n    }\r\n\r\n    .valid.modified:not([type=checkbox]) {\r\n        outline: 1px solid #26b050;\r\n    }\r\n\r\n    .invalid {\r\n        outline: 1px solid red;\r\n    }\r\n\r\n    .validation-message {\r\n        color: red;\r\n    }\r\n\r\n    #blazor-error-ui {\r\n        background: lightyellow;\r\n        bottom: 0;\r\n        box-shadow: 0 -1px 2px rgba(0, 0, 0, 0.2);\r\n        display: none;\r\n        left: 0;\r\n        padding: 0.6rem 1.25rem 0.7rem 1.25rem;\r\n        position: fixed;\r\n        width: 100%;\r\n        z-index: 1000;\r\n    }\r\n\r\n        #blazor-error-ui .dismiss {\r\n            cursor: pointer;\r\n            position: absolute;\r\n            right: 0.75rem;\r\n            top: 0.5rem;\r\n        }\r\n\r\n    @media (max-width: 767.98px) {\r\n        .main .top-row:not(.auth) {\r\n            display: none;\r\n        }\r\n\r\n        .main .top-row.auth {\r\n            justify-content: space-between;\r\n        }\r\n\r\n        .sidebar {\r\n            display: none\r\n        }\r\n    }\r\n\r\n    @media (min-width: 768px) {\r\n        app {\r\n            flex-direction: row;\r\n        }\r\n\r\n        .sidebar {\r\n            width: 250px;\r\n            height: 100vh;\r\n            position: sticky;\r\n            top: 0;\r\n        }\r\n\r\n        .main .top-row {\r\n            position: sticky;\r\n            top: 0;\r\n        }\r\n\r\n        .main > div {\r\n            padding-left: 2rem !important;\r\n            padding-right: 1.5rem !important;\r\n        }\r\n\r\n        .sidebar .collapse {\r\n            /* Never collapse the sidebar for wide screens */\r\n            display: block;\r\n        }\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 132 "C:\Users\Administrator\Desktop\LethalityCrypter\LethalityCrypter\Client\Shared\MainLayout.razor"
       
    private string Mail { get; set; }

    private string Password { get; set; }
    private string PasswordAgain { get; set; }
    private string DisplayName { get; set; }

    private bool Error { get; set; }

    private string ErrorMessage { get; set; }

    public bool WantRegister { get; set; } = false;

    private async Task Login()
    {
        var result = await LethalityCrypter.Client.Providers.AuthProvider.LoginAsync(Mail, Password);

        if(LethalityCrypter.Client.Providers.AuthProvider.CurrentUser != null)
        {
            await cookie.SetValue("id", result, 999);
        }
        else
        {
            ErrorMessage = result;
            Error = true;
        }
    }

    private async Task Register()
    {
        if (Password == PasswordAgain)
        {
            var result = await LethalityCrypter.Client.Providers.AuthProvider.RegisterAsync(Mail, Password, DisplayName);

            GiveError(result);
        }
        else GiveError("Please check your passwords. They are not equal.");

    }


    private void GiveError(string message)
    {
        ErrorMessage = message;
        Error = true;
    }

    protected override async Task OnInitializedAsync()
    {
        var token = await cookie.GetValue("token");
        if(!string.IsNullOrEmpty(token))
        {
            LethalityCrypter.Client.Providers.AuthProvider.CurrentUser = await LethalityCrypter.Client.Providers.AuthProvider.Auth.GetUserAsync(token);
            await cookie.DeleteCookie("token");
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private LethalityCrypter.Client.Providers.ICookie cookie { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
