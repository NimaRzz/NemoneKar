#pragma checksum "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7ffd88e0ac6b947c053ec3cfb81bbe6a246d2a9ba15acc03ed2920d2e142bed0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Cues_FilterCues), @"mvc.1.0.view", @"/Areas/Admin/Views/Cues/FilterCues.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"7ffd88e0ac6b947c053ec3cfb81bbe6a246d2a9ba15acc03ed2920d2e142bed0", @"/Areas/Admin/Views/Cues/FilterCues.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Cues_FilterCues : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-select"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("customer"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("show-first-numbered-page", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("show-last-numbered-page", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query-string-key-page-no", "Page", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("query-string-key-page-size", "PageSize", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("gap-size", new global::Microsoft.AspNetCore.Html.HtmlString("2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Sweetalert2/sweetalert2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::LazZiya.TagHelpers.PagingTagHelper __LazZiya_TagHelpers_PagingTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
  
    ViewData["Title"] = "FilterCues";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    int pageNumber = 1;
    int pageSize = 20;

#line default
#line hidden
#nullable disable

            WriteLiteral(@"
<div class=""row w-100"">
    <div class=""col-12"">
        <div class=""card"">
            <div class=""card-body"">

                <h4 class=""mt-0 header-title"">گزارش سرنخ ها</h4>
                <br />
                <div class=""form-group row"">
                    <label for=""customer"" class=""col-sm-2 col-form-label text-right"">مشتری:</label>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ffd88e0ac6b947c053ec3cfb81bbe6a246d2a9ba15acc03ed2920d2e142bed07660", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = 
#nullable restore
#line 21 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                                                                          ViewBag.Customers

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""form-group row"">
                    <label for=""from"" class=""col-sm-2 col-form-label text-right"">از تاریخ:</label>
                    <div class=""col-sm-10"">
                        <input class=""form-control"" type=""text"" id=""from"">
                    </div>
                </div>
                <div class=""form-group row"">
                    <label for=""to"" class=""col-sm-2 col-form-label text-right"">تا تاریخ:</label>
                    <div class=""col-sm-10"">
                        <input class=""form-control"" type=""text"" id=""to"">
                    </div>
                </div>

                <button onclick=""Filter()"" class=""btn btn-success"">اعمال فیلتر</button>
                <br />

                <table class=""table mb-0"" id=""my-table"">
                    <thead>
                        <tr>
                            <th>Id</th>
                            <th>مشتری</th>
                            <th>توضیحات</th>");
            WriteLiteral("\n                            <th>تاریخ</th>\r\n                            <th class=\"tabledit-toolbar-column\"></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                         foreach (var item in Model.CuesFilter)
                        {



#line default
#line hidden
#nullable disable

            WriteLiteral("                            <tr>\r\n                                <th>");
            Write(
#nullable restore
#line 56 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                     item.CueId

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n                                <th>\r\n\r\n                                    ");
            Write(
#nullable restore
#line 59 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                     item.Customer

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(";\r\n\r\n\r\n                                </th>\r\n                                <th>\r\n\r\n                                    ");
            Write(
#nullable restore
#line 65 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                     item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(";\r\n\r\n                                </th>\r\n                                <th>");
            Write(
#nullable restore
#line 68 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                     item.ShowDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</th>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 71 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"


                        }

#line default
#line hidden
#nullable disable

            WriteLiteral("                    </tbody>\r\n                </table><!--end table-->\r\n            </div><!--end card-body-->\r\n            <div class=\"pagination-product\">\r\n                <nav aria-label=\"Page navigation example\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("paging", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ffd88e0ac6b947c053ec3cfb81bbe6a246d2a9ba15acc03ed2920d2e142bed013459", async() => {
                WriteLiteral("\r\n                    ");
            }
            );
            __LazZiya_TagHelpers_PagingTagHelper = CreateTagHelper<global::LazZiya.TagHelpers.PagingTagHelper>();
            __tagHelperExecutionContext.Add(__LazZiya_TagHelpers_PagingTagHelper);
            __LazZiya_TagHelpers_PagingTagHelper.TotalRecords = 
#nullable restore
#line 79 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                            Model.Rows

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("total-records", __LazZiya_TagHelpers_PagingTagHelper.TotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.PageNo = 
#nullable restore
#line 80 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                      pageNumber==0?1:pageNumber

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("page-no", __LazZiya_TagHelpers_PagingTagHelper.PageNo, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.PageSize = 
#nullable restore
#line 81 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                        pageSize==0?20:pageNumber

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("page-size", __LazZiya_TagHelpers_PagingTagHelper.PageSize, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext = 
#nullable restore
#line 82 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                            true

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("show-prev-next", __LazZiya_TagHelpers_PagingTagHelper.ShowPrevNext, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages = 
#nullable restore
#line 83 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                              false

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-pages", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalPages, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords = 
#nullable restore
#line 84 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                                false

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("show-total-records", __LazZiya_TagHelpers_PagingTagHelper.ShowTotalRecords, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav = 
#nullable restore
#line 85 "C:\Users\Asus\Source\Repos\NimaRzz\Repository-Main\MainProject\MainProject.Mvc\Areas\Admin\Views\Cues\FilterCues.cshtml"
                                                true

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("show-page-size-nav", __LazZiya_TagHelpers_PagingTagHelper.ShowPageSizeNav, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __LazZiya_TagHelpers_PagingTagHelper.QueryStringKeyPageNo = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __LazZiya_TagHelpers_PagingTagHelper.QueryStringKeyPageSize = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            BeginWriteTagHelperAttribute();
            WriteLiteral("@");
            WriteLiteral("(Request.QueryString.Value)");
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("query-string-value", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </nav>\r\n            </div>\r\n        </div><!--end card-->\r\n    </div> <!-- end col -->\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7ffd88e0ac6b947c053ec3cfb81bbe6a246d2a9ba15acc03ed2920d2e142bed019589", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ffd88e0ac6b947c053ec3cfb81bbe6a246d2a9ba15acc03ed2920d2e142bed020792", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>

       
            function Filter() {

            var From = $('#from').val();
            var To = $('#to').val();
            var Customer = $('#customer').val();

            var postData = {
                'From' : From,
                'To' : To,
                'Customer' : Customer
            };


            $.ajax({
                contentType: 'application/x-www-form-urlencoded',
                dataType: 'json',
                type: 'POST',
                url: '/admin/users/FilterReport',
                data: postData,
                success: function (data) {
                    if (data.isSuccess == true) {

                        });
                    }
                    else {
                        swal.fire(
                            'هشدار',
                            data.message,
                            'warning'
                        );
                    }
                },
                error: function (req");
                WriteLiteral(@"uest, status, error) {
                    alert(request.responseText);
                }

            });
        kamaDatepicker('from', {

            placeholder: 'YYYY/MM/DD',
            format: 'YYYY/MM/DD',
            forceFarsiDigits: true,
            markToday: true,
            markHolidays: true,
            highlightSelectedDay: true,
            gotoToday: true

        });

        kamaDatepicker('to', {

            placeholder: 'YYYY/MM/DD',
            format: 'YYYY/MM/DD',
            forceFarsiDigits: true,
            markToday: true,
            markHolidays: true,
            highlightSelectedDay: true,
            gotoToday: true

        });

    </script>
");
            }
            );
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
