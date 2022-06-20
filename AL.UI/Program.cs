using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using AL.Aplicacion.Entidades;
using AL.Aplicacion.Interfaces;
using AL.Aplicacion.UseCases;
using AL.Repositorios.Context;
using AL.Repositorios;
using (var context = new RepositorioContext())
{
    context.Database.EnsureCreated();
}
RepositorioCurso rCurso = new RepositorioCurso();
RepositorioEstudiante rEstudiante = new RepositorioEstudiante();
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddTransient<AgregarCursoUseCase>();
builder.Services.AddTransient<ListarCursosUseCase>();
builder.Services.AddTransient<EliminarCursoUseCase>();
builder.Services.AddTransient<GetCursoUseCase>();
builder.Services.AddTransient<ModificarCursoUseCase>();
builder.Services.AddTransient<AgregarEstudianteUseCase>();
builder.Services.AddTransient<ListarEstudiantesUseCase>();
builder.Services.AddTransient<EliminarEstudianteUseCase>();
builder.Services.AddTransient<GetEstudianteUseCase>();
builder.Services.AddTransient<ModificarEstudianteUseCase>();
builder.Services.AddTransient<EstaInscriptoUseCase>();
builder.Services.AddTransient<AgregarInscripcionUseCase>();
builder.Services.AddTransient<ListarInscripcionesUseCase>();
builder.Services.AddTransient<EliminarInscripcionUseCase>();
builder.Services.AddTransient<BuscarInscripcionUseCase>();
builder.Services.AddTransient<ModificarInscripcionUseCase>();
builder.Services.AddScoped<IRepositorioCurso, RepositorioCurso>();
builder.Services.AddScoped<IRepositorioEstudiante, RepositorioEstudiante>();
builder.Services.AddScoped<IRepositorioInscripcion, RepositorioInscripciones>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();