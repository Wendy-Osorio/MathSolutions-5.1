#pragma checksum "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c71f7ee0312834fe44c06b5a4ca714ffdd23338"
// <auto-generated/>
#pragma warning disable 1591
namespace MathSolutions.Pages.Teachers
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using MathSolutions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\_Imports.razor"
using MathSolutions.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profesores")]
    public partial class Profesores : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"tittle\"><div class=\"tittle_content\"><h1>Profesores</h1></div>\n\n    <div class=\"tittle_btn\"><a href=\"/profesores/add\" class=\"btn btn-outline-success\"><i class=\"oi oi-plus\"></i>\n            &nbsp;\n            Agregar\n        </a></div></div>\n\n");
            __builder.AddMarkupContent(1, "<p>Tabla de Profesores</p>");
#nullable restore
#line 26 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
 if (profesores == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 29 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>ID</th>\n                <th>Nombre</th>\n                <th>Correo</th>\n                <th>Redes Sociales</th>\n                <th>Descripci??n</th>\n                <th>Opciones</th></tr></thead>\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 44 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
             foreach (var profesor in profesores)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "td");
#nullable restore
#line 47 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
__builder.AddContent(9, profesor.IdProfesor);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\n                    ");
            __builder.OpenElement(11, "td");
#nullable restore
#line 48 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
__builder.AddContent(12, profesor.NombreCompleto);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n                    ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 49 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
__builder.AddContent(15, profesor.Correo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                    ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 50 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
__builder.AddContent(18, profesor.RedesSociales);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\n                    ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 51 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
__builder.AddContent(21, profesor.Descripcion);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\n                    ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "span");
            __builder.AddAttribute(25, "class", "icon");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "href", "/profesores/update/" + (
#nullable restore
#line 54 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
                                                         profesor.IdProfesor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "class", "oi oi-pencil");
            __builder.AddAttribute(29, "title", "Editar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\n                        &nbsp;\n                        &nbsp;\n                        &nbsp;\n                        ");
            __builder.OpenElement(31, "span");
            __builder.AddAttribute(32, "class", "icon");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "href", "/profesores/delete/" + (
#nullable restore
#line 60 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
                                                         profesor.IdProfesor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "oi oi-trash");
            __builder.AddAttribute(36, "title", "Eliminar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 69 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Teachers\Profesores.razor"
       
    private readonly string api = "api/CuentaProfesor/TodosLosProfesores";
    private IList<Profesor> profesores;



    protected override async Task OnInitializedAsync()
    {
        profesores = await http.GetFromJsonAsync<IList<Profesor>>(api);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
