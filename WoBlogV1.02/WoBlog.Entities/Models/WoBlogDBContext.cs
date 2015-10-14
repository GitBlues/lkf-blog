using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using WoBlog.Entities.Models.Mapping;

namespace WoBlog.Entities.Models
{
    public partial class WoBlogDBContext : DbContext
    {
        static WoBlogDBContext()
        {
            Database.SetInitializer<WoBlogDBContext>(null);
        }

        public WoBlogDBContext()
            : base("Name=WoBlogDBContext")
        {
        }

        public DbSet<T_BlogArticle> T_BlogArticle { get; set; }
        public DbSet<T_BlogCategory> T_BlogCategory { get; set; }
        public DbSet<T_BlogTag> T_BlogTag { get; set; }
        public DbSet<T_MenuTree> T_MenuTree { get; set; }
        public DbSet<T_User> T_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //�Ƴ�һ�Զ�ļ���ɾ��
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new T_BlogArticleMap());
            modelBuilder.Configurations.Add(new T_BlogCategoryMap());
            modelBuilder.Configurations.Add(new T_BlogTagMap());
            modelBuilder.Configurations.Add(new T_MenuTreeMap());
            modelBuilder.Configurations.Add(new T_UserMap());
        }
    }
}
