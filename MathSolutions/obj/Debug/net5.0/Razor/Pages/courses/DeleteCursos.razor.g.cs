#pragma checksum "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\DeleteCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "174727a5b7712ca98a18dad6ce003a94e6df1dba"
// <auto-generated/>
#pragma warning disable 1591
namespace MathSolutions.Pages.courses
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
#line 10 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\DeleteCursos.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\DeleteCursos.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\DeleteCursos.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\DeleteCursos.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cursos/delete/{id:int}")]
    public partial class DeleteCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Eliminar curso</h1>\n\n");
            __builder.AddMarkupContent(1, "<h2>??Estas seguro que desea borrar a este curso de la base de datos?</h2>\n\n");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-outline-primary");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\DeleteCursos.razor"
                                                  ConfirmDelete

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Eliminar");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\n");
            __builder.AddMarkupContent(7, "<a class=\"btn btn-outline-danger\" href=\"/cursos\">Cancelar</a>");
        }
        #pragma warning restore 1998
#nullable restore
#line 17 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\DeleteCursos.razor"
      
    [Parameter]

    public int id { get; set; }

    Curso curso;

    protected override async Task OnInitializedAsync()
    {
        curso = await http.GetFromJsonAsync<Curso>($"api/Profesor/Curso/{id}");

    }

    private async Task ConfirmDelete()
    {
        var response = await http.DeleteAsync($"api/Profesor/EliminarCurso/{id}");
        if (response.IsSuccessStatusCode)
        {
            NavigationManager.NavigateTo("/cursos");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
