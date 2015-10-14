using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WoBlog.Entities.Models.Mapping
{
    public class T_MenuTreeMap : EntityTypeConfiguration<T_MenuTree>
    {
        public T_MenuTreeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.M_Text)
                .HasMaxLength(50);

            this.Property(t => t.M_IconCls)
                .HasMaxLength(50);

            this.Property(t => t.M_Url)
                .HasMaxLength(50);

            this.Property(t => t.M_State)
                .HasMaxLength(50);

            this.Property(t => t.G_Note)
                .HasMaxLength(50);

            this.Property(t => t.G_InputPerson)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_MenuTree");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.M_TreeNum).HasColumnName("M_TreeNum");
            this.Property(t => t.M_ParentTreeNum).HasColumnName("M_ParentTreeNum");
            this.Property(t => t.M_Text).HasColumnName("M_Text");
            this.Property(t => t.M_IsChecked).HasColumnName("M_IsChecked");
            this.Property(t => t.M_SortOrder).HasColumnName("M_SortOrder");
            this.Property(t => t.M_IconCls).HasColumnName("M_IconCls");
            this.Property(t => t.M_Url).HasColumnName("M_Url");
            this.Property(t => t.M_State).HasColumnName("M_State");
            this.Property(t => t.G_Note).HasColumnName("G_Note");
            this.Property(t => t.G_InputDate).HasColumnName("G_InputDate");
            this.Property(t => t.G_InputPerson).HasColumnName("G_InputPerson");
        }
    }
}
