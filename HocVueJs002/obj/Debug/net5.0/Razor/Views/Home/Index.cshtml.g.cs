#pragma checksum "C:\Users\RelaxDell\source\repos\tungtran85\chovuejs2022\HocVueJs002\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3370a3f156100cfc36712b39727883ae40af1276"
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
#line 1 "C:\Users\RelaxDell\source\repos\tungtran85\chovuejs2022\HocVueJs002\Views\_ViewImports.cshtml"
using HocVueJs002;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RelaxDell\source\repos\tungtran85\chovuejs2022\HocVueJs002\Views\_ViewImports.cshtml"
using HocVueJs002.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3370a3f156100cfc36712b39727883ae40af1276", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4535295284c181dfc14e2ca87018ffe3b8751a6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/abc"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\RelaxDell\source\repos\tungtran85\chovuejs2022\HocVueJs002\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    .dachon{
        color:red;
    }
    .xongroi
    {
        text-decoration: line-through;
        color:red;
    }
</style>
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
<div id=""idAppVuejs"">
    <input type=""text""  v-model=""changeName"" /> <br />

    <h2 class=""dachon""> Lap trinh vuejs</h2>
");
            WriteLiteral("    <br />\r\n");
            WriteLiteral(@"    <input type=""text"" :disabled=""inputDisable"" value=""This text is disable"" />
    <br />
   <span v-bind:myproperty=""myVariable"">Binding property tag html</span>
   <br />
   <span :myproperty=""myVariable"">Binding property tag html ngang gon</span>
   <br />

   <span>Binding truc tiep bien</span>
   {{message}} 
   <br />
   Name is change when you input text:
   <br />
   <input type='text' v-model=""message""/>
   
   <br />

");
            WriteLiteral(@"   <br />
   <input type=""text"" v-model=""listName[0]"" />
   <input type=""text"" v-model=""listName[1]"" />
   <br />

   <input type=""text"" v-model=""chanle.Name""/>
   <input type=""text"" v-model=""chanle.Tuoi""/>
   <button v-on:click="" chanle.Name='1', chanle.Tuoi='2' "">
       Chanle.Name = 1, Chanle.Tuoi = 2
   </button>
   <br />
   <button v-on:click=""dosomething()"">
       Click Me
   </button>
   <br />
   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3370a3f156100cfc36712b39727883ae40af12765307", async() => {
                WriteLiteral(@"
       <span>Do something</span>
       <input type='text' v-model=""message""/>
       <br />
       <button type=""submit"" v-on:click.prevent="" message='from khong submit nua, ma chi an su kien nay thoi.' "">
           button in form
       </button>
   ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
   <br />

   <input ref=""anhxaelement"" type=""text"" value=""chi can goi this.$fres.anhxaelement = $('#ID') ""  />
   <br />
   <div v-show=""an_hien"">Lap Trinh Vien: an/hien theo bien an_hien v-show / v-hide</div>
   <button v-on:click=""an_hien = ! an_hien"" >An/Hien</button>
   <br /><br />
   <div v-if=""an_hien""> v-if: khong co element. khac v-show: chi set display:none  </div>
   <button v-on:click=""an_hien = ! an_hien"" >Add element cua v-if</button>

   <br />
   <button v-on:click=""an_hien = ! an_hien"" >only show one
       <span v-if=""an_hien"">An</span>
       <span v-else>Hien</span>
   </button>
   <br /> List rendering: v-for (v-bind:key)<br />
   <div v-for=""(task, index ) in tasks"" :key=""index"">
       {{task}}
   </div>
   <br /><br />
   TODO List:
   <br />
   <input type=""text"" v-model=""newTask"" />
   <button v-on:click=""todotasks.push({noidung:newTask, trangthai:false})"">Them task</button>
   
   <br />
   <div v-for=""(todo, index ) in todotasks"" :key=""index"">
       <");
            WriteLiteral(@"input type=""checkbox"" v-model=""todo.trangthai"" />
       <span :class=""{xongroi: todo.trangthai}""> {{todo.noidung}} </span> 
   </div>
   <br />
   Mothods: nho phai co ""s"".
   <button v-on:click=""addTask()"">Them task = method</button>
   <br />
   <br />
   <span>Watch la gi: theo doi su thay doi du lieu.</span>
   <br />
   <span>Hooks - mounted </span> 
   <br />
   <span>Component -  </span> 
   <br />
   <span>Props: day du lieu tu cha vo component con</span>
   <hr />
   <span>Danh sach viet gon: </span>
   <br />
   Filter: 
   <br />
   Bien: <span>{{tongtien}}</span>
   <br />
   Display: 
   <span>
       {{tongtien | dauChamPhanTach}}
   </span>
   <br />
   Filter de format data.
   <button v-on:click=""tongtien += 1000"">Cong them 1k</button>
</div>
<script type=""text/javascript"" src=""https://cdn.jsdelivr.net/npm/vue""></script>
<script>
    var app = new Vue(
        {
            el: '#idAppVuejs',
            data: {
              tongtien: 1000000,
          ");
            WriteLiteral(@"    newTask:'',
              todotasks: [
                {noidung:'di cho', trangthai:false },
                {noidung:'di ve sinh', trangthai:false },
                {noidung:'code', trangthai:false },
                {noidung:'nau an', trangthai:false},
                {noidung:'ngu', trangthai:false}
              ],
              tasks: ['di cho','nau an','di ve sinh','code','ngu'],
              an_hien: true,
              chanle: {Name:'chanelName', Tuoi: 'chanaltuoi'},
              message : 'Enter message here!',
              isShowName: true,
              myVariable: ""value variable"",
              inputDisable: true,
              selected: true,
              changeName: 'name will be change.',
              listName: ['name so 1','name so 2']
            },
            methods: {
                addTask: function(){
                    this.todotasks.push({ 
                        noidung: this.newTask, 
                        trangthai:false
                    }");
            WriteLiteral(@");
                }
            },
            watch: {
                newTask: function(newvalue, oldValue){
                    //console.log('new task change');
                    console.log(oldValue);
                    console.log(newvalue);
                }
            },
            mounted(){
                //call api thi show waiting.
            },
            filters: {
                dauChamPhanTach: function(sotien){
                    return sotien.toFixed(2).replace(/\d(?=(\d{3})+\.)/g,'$&,');
                }
            }
}); 
</script>
");
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
