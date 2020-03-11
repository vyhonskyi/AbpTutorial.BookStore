using System;
using System.Collections.Generic;
using System.Text;
using AbpTutorial.BookStore.Localization;
using Volo.Abp.Application.Services;

namespace AbpTutorial.BookStore
{
    /* Inherit your application services from this class.
     */
    public abstract class BookStoreAppService : ApplicationService
    {
        protected BookStoreAppService()
        {
            LocalizationResource = typeof(BookStoreResource);
        }
    }
}
