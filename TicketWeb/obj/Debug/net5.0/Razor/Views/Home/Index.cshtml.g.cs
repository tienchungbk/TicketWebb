#pragma checksum "D:\Test\TicketWeb\TicketWeb\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56b6153697e6e8bc63ad384bef137c035827b46f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Test\TicketWeb\TicketWeb\Views\_ViewImports.cshtml"
using TicketWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Test\TicketWeb\TicketWeb\Views\_ViewImports.cshtml"
using TicketWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56b6153697e6e8bc63ad384bef137c035827b46f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fb632d47e17aa42a9fa559e95a81be29ee3cc51", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://olala.vn/search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("accept-charset", new global::Microsoft.AspNetCore.Html.HtmlString("UTF-8"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("home-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Test\TicketWeb\TicketWeb\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";
    Layout = "_LayoutPortal";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"app\">\r\n    <main class=\"main-wrap\">\r\n        <div class=\"sidebar-left\">\r\n            <a href=\"index.html\" class=\"logo-collapse\">\r\n                <img src=\"images/logo_ex.png\"");
            BeginWriteAttribute("alt", " alt=\"", 262, "\"", 268, 0);
            EndWriteAttribute();
            WriteLiteral(@">
            </a>
            <div class=""nav-menu"">
                <ul class=""menu-list"">
                    <li class=""menu-item active"">
                        <a href=""index.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""images/datve.svg""");
            BeginWriteAttribute("alt", " alt=\"", 590, "\"", 596, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Đặt vé máy bay"">
                            </span>
                            <span class=""menu-text"">Đặt vé máy bay</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""khuyen-mai.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""images/km.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1011, "\"", 1017, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Khuyến mại"">
                            </span>
                            <span class=""menu-text"">Khuyến mãi</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""cam-nang.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""images/camnang.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1427, "\"", 1433, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Cẩm nang du lịch"">
                            </span>
                            <span class=""menu-text"">Cẩm nang du lịch</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""thanh-toan.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""images/thanhtoan.svg""");
            BeginWriteAttribute("alt", " alt=\"", 1859, "\"", 1865, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Thanh toán"">
                            </span>
                            <span class=""menu-text"">Thanh toán</span>
                        </a>
                    </li>
                    <li class=""menu-item"">
                        <a href=""lien-he.html"" class=""menu-link"">
                            <span class=""icon"">
                                <img src=""images/lienhe.svg""");
            BeginWriteAttribute("alt", " alt=\"", 2273, "\"", 2279, 0);
            EndWriteAttribute();
            WriteLiteral(@" title=""Liên hệ"">
                            </span>
                            <span class=""menu-text"">Liên hệ</span>
                        </a>
                    </li>
                </ul>
            </div>
            <div class=""user_fix"">
                <div class=""login"">
                    <a href=""javascript:;"" data-toggle=""modal"" data-target=""#loginModal""
                       class=""d-flex align-items-center"">
                        <p class=""ic_user"">
                            <img src=""images/ic_user.png""");
            BeginWriteAttribute("alt", " alt=\"", 2828, "\"", 2834, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        </p>
                        <span>Đăng nhập</span>
                    </a>
                </div>
            </div>
        </div>
        <div class=""main-box container"" style=""background: url('https://www.airlinequality.com/wp-content/uploads/2019/06/about-us-image.jpg?fbclid=IwAR39T01wf_YdCKoJrvxRr-TuxF-0K859uLTFOuvvEOMTvFOWkyu9531ka3o');"">
            <div class=""search-box"" id=""do-my-vue"">
                <div class=""search-box-title"">
                    <h4>Đặt vé máy bay</h4>
                </div>
                <div class=""search-box-content"">
                    <ul class=""nav nav-pills mb-3"" id=""pills-tab"">
                        <li class=""nav-item"">
                            <a class=""tab-link active"" id=""return-tab"" href=""javascript:;"" onclick=""changeTrip()"">
                                Khứ
                                hồi
                            </a>
                        </li>
                        <li class=""nav-item"">
    ");
            WriteLiteral(@"                        <a class=""tab-link"" id=""onway-tab"" href=""javascript:;"" onclick=""changeTrip(true)"">
                                Một
                                chiều
                            </a>
                        </li>
                    </ul>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "56b6153697e6e8bc63ad384bef137c035827b46f9871", async() => {
                WriteLiteral(@"
                        <input type=""hidden"" name=""type"" v-model=""type"">
                        <div class=""tab-content"" id=""pills-tabContent"">
                            <div class=""tab-pane fade show active"" id=""return"" role=""tabpanel""
                                 aria-labelledby=""return-tab"">
                                <div class=""box-flight d-flex flex-wrap"">
                                    <div class=""d-flex city-box align-items-center"">
                                        <div class=""city-box-item city-start"" ref=""city_start"">
                                            <span class=""city-box-title"">Chọn nơi xuất phát</span>
                                            <div class=""select-city"" data-type=""start"">
                                                <input type=""text"" class=""input-city"" id=""keyboard_start""
                                                       data-type=""start"" onfocus=""focusSearch('city_start')""
                                                   ");
                WriteLiteral(@"    onkeyup=""app.suggestAirport(this.value)"">
                                                <div class=""holder"" onclick=""showCity('city_start')"">
                                                    <span class=""city"">Khu Vực</span>
                                                    <span class=""country"">Quốc gia</span>
                                                </div>
                                                <div class=""selected"" onclick=""showCity('city_start')"">
                                                    <span class=""city"" v-html=""themeCity('start')""></span>
                                                    <span class=""country"" v-html=""themeCountry('start')""></span>
                                                </div>
                                                <input type=""hidden"" name=""start"" class=""value"" id=""start""
                                                       :value=""cityCode('start')"">
                                            </div>
             ");
                WriteLiteral(@"                               <div class=""drop-list"">
                                                <ul class=""city-list"" id=""suggest_start"" v-show=""showingSuggest()"">
                                                    <li v-for=""item in suggest""
                                                        :class=""{'city-item': true, 'city-item-active': activeSuggest('start', item.value)}"">
                                                        <a href=""#"" class=""link-item""
                                                           onclick=""choiceAirport('start', item.value)"">
                                                            <span class=""city"" v-text=""item.label""></span>
                                                            <span class=""code-city"" v-text=""item.value""></span>
                                                        </a>
                                                    </li>
                                                </ul>
                                     ");
                WriteLiteral(@"           <div class=""list-his"" v-show=""showingHistory()"">
                                                    <div class=""title"">
                                                        <a href=""javascript:;"" class=""del-his""
                                                           onclick=""clearHistory()"">Xóa</a>
                                                    </div>
                                                    <ul>
                                                        <li class=""his-item"" v-for=""item in historyArr""
                                                            style=""cursor: pointer""
                                                            onclick=""loadHistory(item.start, item.end)"">
                                                            <div class=""d-flex align-items-center"">
                                                                <div class=""item-city"">
                                                                    <span class=""city"">
        ");
                WriteLiteral(@"                                                                <span class=""name""
                                                                              v-text=""item.start.city""></span> ({{
                                                                            item.start.code }})
                                                                    </span>
                                                                    <br />
                                                                    <span class=""country""
                                                                          v-text=""item.start.country""></span>
                                                                </div>
                                                                <span><i class=""fa fa-exchange""></i></span>
                                                                <div class=""item-city"">
                                                                    <span class=""city"">
             ");
                WriteLiteral(@"                                                           <span class=""name""
                                                                              v-text=""item.end.city""></span> ({{
                                                                            item.end.code }})
                                                                    </span>
                                                                    <br />
                                                                    <span class=""country""
                                                                          v-text=""item.end.country""></span>
                                                                </div>
                                                            </div>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
             ");
                WriteLiteral("                           </div>\r\n                                        <span class=\"ic_flight-center pt-4\">\r\n                                            <img src=\"images/ic_flight-gray.png\"");
                BeginWriteAttribute("alt", "\r\n                                                 alt=\"", 10584, "\"", 10640, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                        </span>
                                        <div class=""city-box-item city-end"" ref=""city_end"">
                                            <span class=""city-box-title"">Chọn nơi đến</span>
                                            <div class=""select-city"" data-type=""end"">
                                                <input type=""text"" class=""input-city"" id=""keyboard_end""
                                                       data-type=""end"" onfocus=""focusSearch('city_end')""
                                                       onkeyup=""app.suggestAirport(this.value)"">
                                                <div class=""holder"" onclick=""showCity('city_end')"">
                                                    <span class=""city"">Khu Vực</span>
                                                    <span class=""country"">Quốc gia</span>
                                                </div>
                                                <div c");
                WriteLiteral(@"lass=""selected"" onclick=""showCity('city_end')"">
                                                    <span class=""city"" v-html=""themeCity('end')""></span>
                                                    <span class=""country"" v-html=""themeCountry('end')""></span>
                                                </div>
                                                <input type=""hidden"" name=""destination"" class=""value"" id=""end""
                                                       :value=""cityCode('end')"">
                                            </div>
                                            <div class=""drop-list"">
                                                <ul class=""city-list"" id=""suggest_end"" v-show=""showingSuggest()"">
                                                    <li v-for=""item in suggest""
                                                        :class=""{'city-item': true, 'city-item-active': activeSuggest('end', item.value)}"">
                                                 ");
                WriteLiteral(@"       <a href=""#"" class=""link-item""
                                                           onclick=""choiceAirport('end', item.value)"">
                                                            <span class=""city"" v-text=""item.label""></span>
                                                            <span class=""code-city"" v-text=""item.value""></span>
                                                        </a>
                                                    </li>
                                                </ul>
                                                <div class=""list-his"" v-show=""showingHistory()"">
                                                    <div class=""title"">
                                                        <a href=""javascript:;"" class=""del-his""
                                                           onclick=""clearHistory()"">Xóa</a>
                                                    </div>
                                                    <ul>
       ");
                WriteLiteral(@"                                                 <li class=""his-item"" v-for=""item in historyArr""
                                                            style=""cursor: pointer""
                                                            onclick=""loadHistory(item.start, item.end)"">
                                                            <div class=""d-flex align-items-center"">
                                                                <div class=""item-city"">
                                                                    <span class=""city"">
                                                                        <span class=""name""
                                                                              v-text=""item.start.city""></span> ({{
                                                                            item.start.code }})
                                                                    </span>
                                                                    <br />");
                WriteLiteral(@"
                                                                    <span class=""country""
                                                                          v-text=""item.start.country""></span>
                                                                </div>
                                                                <span><i class=""fa fa-exchange""></i></span>
                                                                <div class=""item-city"">
                                                                    <span class=""city"">
                                                                        <span class=""name""
                                                                              v-text=""item.end.city""></span> ({{
                                                                            item.end.code }})
                                                                    </span>
                                                                    <br />
       ");
                WriteLiteral(@"                                                             <span class=""country""
                                                                          v-text=""item.end.country""></span>
                                                                </div>
                                                            </div>
                                                        </li>
                                                    </ul>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""box-select-day"">
                                        <div class=""d-flex align-items-center"">
                                            <div class=""day-item"">
                                                <span class=""box-title"">ngày đi</span>
                                                <div class=""box-se");
                WriteLiteral(@"lect d-flex flex-column-reverse"">
                                                    <span class=""js-t2-cn"" v-text=""showDateName(start.time)""></span>
                                                    <input type=""text""
                                                           class=""content-date-input js-date-begin-show day-null p-0""
                                                           placeholder=""Chọn"" v-model=""start.time""
                                                           name=""departure_date"">
                                                    <input type=""text""
                                                           class=""content-date-input js-date-begin day-null p-0""
                                                           placeholder=""Chọn"" readonly=""readonly"">
                                                </div>
                                            </div>
                                            <div class=""day-item"" v-show=""!isOneWay"">
                ");
                WriteLiteral(@"                                <span class=""box-title"">ngày Về</span>
                                                <div class=""box-select d-flex flex-column-reverse"">
                                                    <span class=""js-t2-cn"" v-text=""showDateName(end.time)""></span>
                                                    <input type=""text""
                                                           class=""content-date-input js-date-end-show day-null p-0""
                                                           placeholder=""Chọn"" v-model=""end.time"" name=""return_date"">
                                                    <input type=""text""
                                                           class=""content-date-input js-date-end day-null p-0""
                                                           placeholder=""Chọn"" readonly=""readonly"">
                                                </div>
                                            </div>
                                    ");
                WriteLiteral(@"    </div>
                                    </div>
                                    <div class=""count-box w-100"">
                                        <div class=""d-flex"">
                                            <div class=""count-item d-flex"">
                                                <div class=""title-box"">
                                                    <span class=""type"">Người lớn</span>
                                                    <span class=""old"">≥ 12 tuổi</span>
                                                </div>
                                                <div class=""box-input"">
                                                    <span class=""btn_change-val""
                                                          onclick=""changeNumber('adult', true)"">-</span>
                                                    <input type=""text"" v-model=""adults"" name=""adults"" id=""adults""
                                                           readonly>
          ");
                WriteLiteral(@"                                          <span class=""btn_change-val""
                                                          onclick=""changeNumber('adult')"">+</span>
                                                </div>
                                            </div>
                                            <div class=""count-item d-flex"">
                                                <div class=""title-box"">
                                                    <span class=""type"">Trẻ em</span>
                                                    <span class=""old"">2 < 12 tuổi</span>
                                                </div>
                                                <div class=""box-input"">
                                                    <span class=""btn_change-val""
                                                          onclick=""changeNumber('children', true)"">-</span>
                                                    <input type=""text"" v-model=""children"" name=""ch");
                WriteLiteral(@"ildren""
                                                           id=""children"" readonly>
                                                    <span class=""btn_change-val""
                                                          onclick=""changeNumber('children')"">+</span>
                                                </div>
                                            </div>
                                            <div class=""count-item d-flex"">
                                                <div class=""title-box"">
                                                    <span class=""type"">Trẻ em</span>
                                                    <span class=""old"">
                                                        < 2 tuổi
                                                    </span>
                                                </div>
                                                <div class=""box-input"">
                                                    <span class=""btn_chang");
                WriteLiteral(@"e-val""
                                                          onclick=""changeNumber('infant', true)"">-</span>
                                                    <input type=""text"" v-model=""infant"" name=""infant"" id=""infant""
                                                           readonly>
                                                    <span class=""btn_change-val""
                                                          onclick=""changeNumber('infant')"">+</span>
                                                </div>
                                            </div>
                                            <div class=""check_min-price d-flex align-items-center"">
                                                <input type=""checkbox"" class=""input_check-price""");
                BeginWriteAttribute("id", " id=\"", 22693, "\"", 22698, 0);
                EndWriteAttribute();
                WriteLiteral(@" name=""price"">
                                                <a href=""javascript:;"" class=""btn_search"" onclick=""submit()"">
                                                    Tìm
                                                    chuyến bay
                                                </a>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
