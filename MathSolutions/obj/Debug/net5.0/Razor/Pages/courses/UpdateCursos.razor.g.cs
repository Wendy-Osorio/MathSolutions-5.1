#pragma checksum "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77b253eb8421b0f1a9983d7d9945291345d225b7"
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
            __builder.OpenElement(0, "h1");
#nullable restore
#line 3 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
__builder.AddContent(1, isUpdate ? $"Editar curso[id: {curso.IdCurso}]":"");

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                  curso

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(6, "form");
                __builder2.AddAttribute(7, "class", "container-border");
                __builder2.AddAttribute(8, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 6 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                              UpdateCurso

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "mb-2");
                __builder2.AddMarkupContent(11, "<label class=\"col-form-label\" for=\"titulo\">Titulo</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(12);
                __builder2.AddAttribute(13, "class", "form-control");
                __builder2.AddAttribute(14, "id", "titulo");
                __builder2.AddAttribute(15, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                                          curso.Titulo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.Titulo = __value, curso.Titulo))));
                __builder2.AddAttribute(17, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.Titulo));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\n\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "mb-2");
                __builder2.AddMarkupContent(21, "<label class=\"col-form-label\" for=\"fechainicio\">Fecha de Inicio</label>\n            ");
                __Blazor.MathSolutions.Pages.courses.UpdateCursos.TypeInference.CreateInputDate_0(__builder2, 22, 23, "form-control", 24, "fechainicio", 25, 
#nullable restore
#line 18 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                                          curso.FechaInicio

#line default
#line hidden
#nullable disable
                , 26, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.FechaInicio = __value, curso.FechaInicio)), 27, () => curso.FechaInicio);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\n\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "mb-2");
                __builder2.AddMarkupContent(31, "<label class=\"col-form-label\" for=\"fechacierre\">Fecha de Cierre</label>\n            ");
                __Blazor.MathSolutions.Pages.courses.UpdateCursos.TypeInference.CreateInputDate_1(__builder2, 32, 33, "form-control", 34, "fechacierre", 35, 
#nullable restore
#line 23 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                                          curso.FechaCierre

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.FechaCierre = __value, curso.FechaCierre)), 37, () => curso.FechaCierre);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\n\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "mb-2");
                __builder2.AddMarkupContent(41, "<label class=\"col-form-label\" for=\"linkReunion\">Link de laReunion</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "class", "form-control");
                __builder2.AddAttribute(44, "id", "linkReunion");
                __builder2.AddAttribute(45, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                                          curso.LinkReunion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.LinkReunion = __value, curso.LinkReunion))));
                __builder2.AddAttribute(47, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.LinkReunion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\n\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "mb-2 form-control-file");
                __builder2.AddMarkupContent(51, "<label class=\"col-form-label\" for=\"material\">Material: </label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(52);
                __builder2.AddAttribute(53, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                 OnFileChange

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\n\n        ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "mb-2");
                __builder2.AddMarkupContent(57, "<label class=\"col-form-label\" for=\"descripcion\">Descripci??n</label>\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(58);
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "id", "descripcion");
                __builder2.AddAttribute(61, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 39 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                                          curso.Descripcion

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.Descripcion = __value, curso.Descripcion))));
                __builder2.AddAttribute(63, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => curso.Descripcion));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\n\n        ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "mb-2");
                __builder2.AddMarkupContent(67, "<label class=\"col-form-label\" for=\"idprofesor\">ID del Profesor</label>\n            ");
                __Blazor.MathSolutions.Pages.courses.UpdateCursos.TypeInference.CreateInputNumber_2(__builder2, 68, 69, "form-control", 70, "idprofesor", 71, 
#nullable restore
#line 44 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\courses\UpdateCursos.razor"
                                                            curso.IdProfesor

#line default
#line hidden
#nullable disable
                , 72, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => curso.IdProfesor = __value, curso.IdProfesor)), 73, () => curso.IdProfesor);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\n        ");
                __builder2.AddMarkupContent(75, "<button type=\"submit\" class=\"btn btn-outline-primary\">Guardar</button>\n        ");
                __builder2.AddMarkupContent(76, "<a class=\"btn btn-outline-danger\" href=\"/cursos\">Cancelar</a>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
namespace __Blazor.MathSolutions.Pages.courses.UpdateCursos
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
