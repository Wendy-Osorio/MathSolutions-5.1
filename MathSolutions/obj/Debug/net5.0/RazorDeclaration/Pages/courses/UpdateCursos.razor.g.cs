// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 51 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 54 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/cursos/update/{id:int}")]
    public partial class UpdateCursos : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
      
    [Parameter]

    public bool isUpdate { get; set; } = false;

    public int id { get; set; }

    Curso curso = new Curso();

    protected async Task UpdateCurso()
    {
        HttpResponseMessage response;

        response = await http.PutAsJsonAsync<Curso>($"api/Profesor/ModificarCurso/{curso.IdCurso}", curso!);

        NavigationManager.NavigateTo("/cursos");
    }


    async Task OnFileChange(InputFileChangeEventArgs e) 
    {
        var format = "file/pdf";

        var resizedFile = await e.File.RequestImageFileAsync(format, 300, 300);

        var buffer = new byte[resizedFile.Size];

        await resizedFile.OpenReadStream().ReadAsync(buffer);

        var fileData = $"data:{format};base64,{Convert.ToBase64String(buffer)}";

        curso.Material = fileData;

        Console.WriteLine(curso.Material);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
