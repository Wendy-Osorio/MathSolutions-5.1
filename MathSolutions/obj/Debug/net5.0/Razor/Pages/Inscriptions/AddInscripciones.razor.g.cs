#pragma checksum "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ca6c41154bb354fdb15aa42a84311fc175927ec"
// <auto-generated/>
#pragma warning disable 1591
namespace MathSolutions.Pages.Inscriptions
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
#line 22 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
using MathSolutions.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
using MathSolutions.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/inscripcions/add")]
    public partial class AddInscripciones : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Agregar una nueva inscripcion</h1>\n\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 5 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
                  inscripcion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "form");
                __builder2.AddAttribute(5, "class", "container-border");
                __builder2.AddAttribute(6, "onsubmit", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 6 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
                                              Save

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "mb-2");
                __builder2.AddMarkupContent(9, "<label class=\"col-form-label\" for=\"name\">ID del estudiante</label>\n            ");
                __Blazor.MathSolutions.Pages.Inscriptions.AddInscripciones.TypeInference.CreateInputNumber_0(__builder2, 10, 11, "form-control", 12, "email", 13, 
#nullable restore
#line 9 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
                                                            inscripcion.IdEstudiante

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inscripcion.IdEstudiante = __value, inscripcion.IdEstudiante)), 15, () => inscripcion.IdEstudiante);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\n\n        ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "mb-2");
                __builder2.AddMarkupContent(19, "<label class=\"col-form-label\" for=\"name\">ID del curso</label>\n            ");
                __Blazor.MathSolutions.Pages.Inscriptions.AddInscripciones.TypeInference.CreateInputNumber_1(__builder2, 20, 21, "form-control", 22, "redessociales", 23, 
#nullable restore
#line 14 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
                                                            inscripcion.IdCurso

#line default
#line hidden
#nullable disable
                , 24, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => inscripcion.IdCurso = __value, inscripcion.IdCurso)), 25, () => inscripcion.IdCurso);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\n\n        ");
                __builder2.AddMarkupContent(27, "<button type=\"submit\" class=\"btn btn-outline-primary\">Guardar</button>\n        ");
                __builder2.AddMarkupContent(28, "<a class=\"btn btn-outline-danger\" href=\"/inscripcions\">Cancelar</a>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\osori\OneDrive\Escritorio\TAREAS\Quinto Cuatrimestre\Proyecto MathSolutions\Pagina web con blazor\MathSolutions-main\MathSolutions 5.1\MathSolutions\Pages\Inscriptions\AddInscripciones.razor"
      
    [Parameter]

    public bool isUpdate { get; set; } = false;

    public int id { get; set; }

    //bool loading = true;

    //IList<Inscripcion> inscripcions;

    Inscripcion inscripcion = new Inscripcion();

    //protected override async Task OnInitializedAsync()
    //{
    //    inscripcions = await http.GetFromJsonAsync<IList<Inscripcion>>("api/inscripcion");
    //    isUpdate = id != 0;
    //    if (isUpdate)
    //    {
    //        var response = await http.GetFromJsonAsync<Inscripcion>($"api/inscripcion/{id}");
    //        if (response != null)
    //        {
    //            inscripcion = response;

    //        }
    //    }
    //    loading = false;
    //}

    protected async Task Save()
    {
        HttpResponseMessage response;
        if (isUpdate)
        {
            response = await http.PutAsJsonAsync<Inscripcion>($"api/inscripcion/{id}", inscripcion!);
        }
        else
        {
            response = await http.PostAsJsonAsync<Inscripcion>("api/inscripcion", inscripcion!);
        }
        Inscripcion Saved = response.Content.ReadFromJsonAsync<Inscripcion>().Result;
        NavigationManager.NavigateTo("/inscripcions");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.MathSolutions.Pages.Inscriptions.AddInscripciones
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "id", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
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
