using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Categorys;
using EExamSystem.Infrastructure.Repositories.IRepositories;

namespace EExamSystem.Infrastructure.Repositories
{
    public class CategoryRepository : GenericRepository<Category, int>, ICategoryRepository
    {
        public readonly ApplicationDbContext Context;

        public CategoryRepository(ApplicationDbContext db) : base(db)

        {
            Context = db;
        }


    }
}
