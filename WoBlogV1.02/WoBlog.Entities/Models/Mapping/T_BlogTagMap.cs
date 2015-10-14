using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WoBlog.Entities.Models.Mapping
{
    public class T_BlogTagMap : EntityTypeConfiguration<T_BlogTag>
    {
        public T_BlogTagMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Tag_Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.G_Note)
                .HasMaxLength(50);

            this.Property(t => t.G_InputPerson)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_BlogTag");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Tag_Name).HasColumnName("Tag_Name");
            this.Property(t => t.Tag_ParentID).HasColumnName("Tag_ParentID");
            this.Property(t => t.Tag_State).HasColumnName("Tag_State");
            this.Property(t => t.Tag_SortID).HasColumnName("Tag_SortID");
            this.Property(t => t.Tag_ArticleCount).HasColumnName("Tag_ArticleCount");
            this.Property(t => t.G_Note).HasColumnName("G_Note");
            this.Property(t => t.G_InputDate).HasColumnName("G_InputDate");
            this.Property(t => t.G_InputPerson).HasColumnName("G_InputPerson");
        }
    }
}
