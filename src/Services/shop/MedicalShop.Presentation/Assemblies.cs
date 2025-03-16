using Medicals.Application.Commands.Medicals.CreateMedical;
using MedicalShop.Infrastructure;
using System.Reflection;

namespace MedicalShop.Presentation;

    public static class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(ProductEntity).Assembly;
        public static readonly Assembly ApplicationAssembly = typeof(CreateProductCommand).Assembly;
        public static readonly Assembly InfrastructureAssembly = typeof(ApplicationDbContext).Assembly;
    }

