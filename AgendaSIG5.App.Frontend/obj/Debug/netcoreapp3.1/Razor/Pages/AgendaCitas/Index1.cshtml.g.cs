#pragma checksum "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6894713c567fd0698f13644f9f2ad172f1ad2329"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AgendaSIG5.App.Frontend.Pages.AgendaCitas.Pages_AgendaCitas_Index1), @"mvc.1.0.razor-page", @"/Pages/AgendaCitas/Index1.cshtml")]
namespace AgendaSIG5.App.Frontend.Pages.AgendaCitas
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
#line 1 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\_ViewImports.cshtml"
using AgendaSIG5.App.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6894713c567fd0698f13644f9f2ad172f1ad2329", @"/Pages/AgendaCitas/Index1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ad34b0f541e58f8333ad4d134f2e3f782475c41", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AgendaCitas_Index1 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Crear1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Detalles1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Editar1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Listado de Citas Médicas</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6894713c567fd0698f13644f9f2ad172f1ad23294677", async() => {
                WriteLiteral("Registrar Cita Médica");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<table class=""table table-striped"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Fecha</th>	
			<th scope=""col"">Hora</th>
			<th scope=""col"">Sede</th>			
            <th scope=""col"">Nombre Paciente</th>
            <th scope=""col"">Nombre Médico</th>
            <th scope=""col"">Especilidad</th>
            <th scope=""col"">Detalles Consulta</th>
            <th colspan=""2"" scope=""col"">Acciones</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
         foreach (var agenda in Model.agendaCitas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(agenda.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(agenda.FechaCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(agenda.HoraCita);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 29 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                      
                        Model.GetSede(agenda.FK_Id_Sede);
                        Model.GetCiudad(Model.sede.FK_Id_Ciudad);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 33 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(Model.NombreCiudad);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 33 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                                     Write(Model.NombreSede);

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 36 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                      
                        var paciente = Model.GetPersona(agenda.FK_Id_Paciente);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 39 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(paciente.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                                Write(paciente.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("               \r\n                </td>\t\t\t\t\r\n                <td>\r\n");
#nullable restore
#line 42 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                      
                        var medico = Model.GetPersona(@agenda.FK_Id_Medico);
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    ");
#nullable restore
#line 45 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(medico.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 45 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                              Write(medico.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n                </td>\r\n\t\t\t\t<td>");
#nullable restore
#line 47 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(medico.Especialidad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 48 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
               Write(agenda.Notas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6894713c567fd0698f13644f9f2ad172f1ad232911125", async() => {
                WriteLiteral("Detalle");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                                                                          WriteLiteral(agenda.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6894713c567fd0698f13644f9f2ad172f1ad232913444", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 50 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
                                                                        WriteLiteral(agenda.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 52 "C:\Users\JHON RUIZ\Documents\GitHub\Agendamiento\AgendaSIG5.App.Frontend\Pages\AgendaCitas\Index1.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AgendaSIG5.App.Frontend.Pages.AgendaCitas.Index1Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendaSIG5.App.Frontend.Pages.AgendaCitas.Index1Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AgendaSIG5.App.Frontend.Pages.AgendaCitas.Index1Model>)PageContext?.ViewData;
        public AgendaSIG5.App.Frontend.Pages.AgendaCitas.Index1Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
