using System.Threading.Tasks;

namespace AbpTutorial.BookStore.Data
{
    public interface IBookStoreDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
