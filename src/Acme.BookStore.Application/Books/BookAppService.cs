using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.BookStore.Books
{
    public class BookAppService : CrudAppService<
            Book, //The Book entity
            BookDto, //Used to show books
            long, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateBookDto>,
        IBookAppService
    {
        public BookAppService(IRepository<Book, long> repository) : base(repository)
        {
        }
    }
}
