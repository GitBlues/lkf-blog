using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WoBlog.Entities.Models.Mapping
{
    public class T_BlogCategoryMap : EntityTypeConfiguration<T_BlogCategory>
    {
        public T_BlogCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Categoty_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.G_Note)
                .HasMaxLength(50);

            this.Property(t => t.G_InputPerson)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_BlogCategory");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Categoty_Name).HasColumnName("Categoty_Name");
            this.Property(t => t.Categoty_ParentID).HasColumnName("Categoty_ParentID");
            this.Property(t => t.Categoty_State).HasColumnName("Categoty_State");
            this.Property(t => t.Categoty_SortID).HasColumnName("Categoty_SortID");
            this.Property(t => t.Categoty_ArticleCount).HasColumnName("Categoty_ArticleCount");
            this.Property(t => t.Categoty_CreateTime).HasColumnName("Categoty_CreateTime");
            this.Property(t => t.G_Note).HasColumnName("G_Note");
            this.Property(t => t.G_InputDate).HasColumnName("G_InputDate");
            this.Property(t => t.G_InputPerson).HasColumnName("G_InputPerson");
        }
    }
}
