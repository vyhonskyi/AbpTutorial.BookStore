using AbpTutorial.BookStore.MongoDB;
using Volo.Abp.Modularity;

namespace AbpTutorial.BookStore
{
    [DependsOn(
        typeof(BookStoreMongoDbTestModule)
        )]
    public class BookStoreDomainTestModule : AbpModule
    {

    }
}