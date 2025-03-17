using Products.Application.Products.Commands.Product.CreateMedical;
using Products.Domain.Products.Models;
using Products.Infrastructure;
using System.Reflection;

namespace Products.Presentation;

public static class Assemblies
    {
        public static readonly Assembly EntityAssembly = typeof(ProductEntity).Assembly;
        public static readonly Assembly ApplicationAssembly = typeof(CreateProductCommand).Assembly;
        public static readonly Assembly InfrastructureAssembly = typeof(ApplicationDbContext).Assembly;
    }

