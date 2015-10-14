using System.Data.Entity.ModelConfiguration;

namespace WoBlog.Entities.Models.Mapping
{
    public class T_UserMap : EntityTypeConfiguration<T_User>
    {
        public T_UserMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.U_UserName)
                .HasMaxLength(50);

            this.Property(t => t.U_PassWord)
                .HasMaxLength(50);

            this.Property(t => t.U_NickName)
                .HasMaxLength(50);

            this.Property(t => t.U_Sex)
                .HasMaxLength(20);

            this.Property(t => t.U_PasswordSalt)
                .HasMaxLength(50);

            this.Property(t => t.G_InputPerson)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_User");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.U_UserName).HasColumnName("U_UserName");
            this.Property(t => t.U_PassWord).HasColumnName("U_PassWord");
            this.Property(t => t.U_NickName).HasColumnName("U_NickName");
            this.Property(t => t.U_Sex).HasColumnName("U_Sex");
            this.Property(t => t.U_PasswordSalt).HasColumnName("U_PasswordSalt");
            this.Property(t => t.U_Age).HasColumnName("U_Age");
            this.Property(t => t.G_Note).HasColumnName("G_Note");
            this.Property(t => t.G_InputDate).HasColumnName("G_InputDate");
            this.Property(t => t.G_InputPerson).HasColumnName("G_InputPerson");
        }
    }
}
