namespace PriLalo.Services.Data.News
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using PriLalo.Web.ViewModels.Admins;
    using PriLalo.Web.ViewModels.News;

    public interface INewsService
    {
        Task AddNewsAsync(AddNewsInputModel input);

        Task EditNewsAsync(EditNewsInputModel input, int id);

        IEnumerable<NewsViewModel> GetAllNews<T>(int page, int itemsPerPage);

        IEnumerable<NewsViewModel> GetAllNewsWithDeleted<T>(int page, int itemsPerPage);

        int GetCount();

        IEnumerable<NewsViewModel> GetLastThreeNews<T>();

        NewsViewModel GetById<T>(int id);

        Task DeleteNews(int id);

        Task UnDeleteNews(int id);
    }
}
