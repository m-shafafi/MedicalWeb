using MedicalShop.Domain.Base;
using MedicalShop.Domain.News;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalShop.Domain.Menu.Models
{
    public class Menu_MainMenu : BaseEntity
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public class MainMenuConfiguration : IEntityTypeConfiguration<Menu_MainMenu>
        {
            public void Configure(EntityTypeBuilder<Menu_MainMenu> builder)
            {
                builder.HasKey(x => x.ID);
                builder.Property(p => p.Name).IsRequired();
                builder.Property(p => p.CreatedDate).IsRequired();
                builder.Property(p => p.UpdatedDate).IsRequired();
            }
        }
    }
}
