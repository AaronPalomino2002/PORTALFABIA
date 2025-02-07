using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace PORTALFABIA.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<PORTALFABIA.Models.RegisterViewModel> DataRegistro{ get;set;}
    public DbSet<PORTALFABIA.Models.Login> DataHome { get;set;}
    public DbSet<PORTALFABIA.Models.Alumno> DataAlumnos { get;set;}
    public DbSet<PORTALFABIA.Models.Inscripciones> DataInscripciones { get;set;}
    public DbSet<PORTALFABIA.Models.Talleres> DataTalleres { get;set;}
    public DbSet<PORTALFABIA.Models.Certificados> DataCertificados { get;set;}
    public DbSet<PORTALFABIA.Models.Contacto> DataContacto { get;set;}
    public DbSet<PORTALFABIA.Models.Carrera> DataCarrera{ get;set;}
    public DbSet<PORTALFABIA.Models.Facultad> DataFacultad{ get;set;}
    public DbSet<PORTALFABIA.Models.Campanas> DataCampanas{ get;set;}
    public DbSet<PORTALFABIA.Models.Categoria> DataCategoria{ get;set;}
    public DbSet<PORTALFABIA.Models.SubCategoria> DataSubCategoria{ get;set;}
    public DbSet<PORTALFABIA.Models.EventosInscripciones> DataEventosInscripciones{ get;set;}
}
