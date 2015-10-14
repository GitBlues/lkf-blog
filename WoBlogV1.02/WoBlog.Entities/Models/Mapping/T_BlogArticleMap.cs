using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace WoBlog.Entities.Models.Mapping
{
    public class T_BlogArticleMap : EntityTypeConfiguration<T_BlogArticle>
    {
        public T_BlogArticleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Article_Title, t.Article_Hits, t.Article_IsTop, t.Article_State, t.Article_PublishTime, t.Article_UpdateTime, t.Article_Category_ID, t.G_InputDate });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Article_Title)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Article_Description)
                .HasMaxLength(1000);

            this.Property(t => t.Article_ImageUrl)
                .HasMaxLength(500);

            this.Property(t => t.Article_Tag)
                .HasMaxLength(4000);

            this.Property(t => t.Article_Hits)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Article_State)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Article_UserName)
                .HasMaxLength(50);

            this.Property(t => t.Article_UserIP)
                .HasMaxLength(50);

            this.Property(t => t.Article_Category_ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.G_Note)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("T_BlogArticle");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Article_Title).HasColumnName("Article_Title");
            this.Property(t => t.Article_Content).HasColumnName("Article_Content");
            this.Property(t => t.Article_Description).HasColumnName("Article_Description");
            this.Property(t => t.Article_ImageUrl).HasColumnName("Article_ImageUrl");
            this.Property(t => t.Article_Tag).HasColumnName("Article_Tag");
            this.Property(t => t.Article_Hits).HasColumnName("Article_Hits");
            this.Property(t => t.Article_IsTop).HasColumnName("Article_IsTop");
            this.Property(t => t.Article_State).HasColumnName("Article_State");
            this.Property(t => t.Article_UserID).HasColumnName("Article_UserID");
            this.Property(t => t.Article_UserName).HasColumnName("Article_UserName");
            this.Property(t => t.Article_UserIP).HasColumnName("Article_UserIP");
            this.Property(t => t.Article_PublishTime).HasColumnName("Article_PublishTime");
            this.Property(t => t.Article_UpdateTime).HasColumnName("Article_UpdateTime");
            this.Property(t => t.Article_Category_ID).HasColumnName("Article_Category_ID");
            this.Property(t => t.G_Note).HasColumnName("G_Note");
            this.Property(t => t.G_InputDate).HasColumnName("G_InputDate");
        }
    }
}
