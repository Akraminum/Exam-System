using EExamSystem.Infrastructure.DataBase;
using EExamSystem.Infrastructure.Entities.Certificates;
using EExamSystem.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace EExamSystem.Infrastructure.Repositories
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly ApplicationDbContext _DbContext;

        public CertificateRepository(ApplicationDbContext DbContext)
        {
            _DbContext = DbContext;
        }

        /* Filter
        public async Task<List<Certificate>> FilterAsync(Expression<Func<Certificate, bool>> filter)
        {
            var _data = await _DbContext.Certificates.Where(filter).ToListAsync();
            return _data;
        }*/

        public async Task<Certificate> GetByIdAsync(int id)
        {
            var _data = await _DbContext.Certificates.Include(c => c.Category).SingleOrDefaultAsync(a => a.Id == id);
            return _data;
        }

        public async Task<Certificate> GetListByCategoryIdAsync(int id)
        {
            var _data = await _DbContext.Certificates.Include(a => a.Category).SingleOrDefaultAsync(a => a.CategoryId == id);
            return _data;
        }

        public async Task<List<Certificate>> GetListAsync()
        {
            var _data = await _DbContext.Certificates.Include(c => c.Category).ToListAsync();
            return _data;
        }

        public async Task<Certificate> AddAsync(Certificate input)
        {
            await _DbContext.Certificates.AddAsync(input);
            await _DbContext.SaveChangesAsync();
            var _data = await GetByIdAsync(input.Id);
            return _data;
        }

        public async Task<List<Certificate>> AddRangeAsync(List<Certificate> input)
        {
            await _DbContext.Certificates.AddRangeAsync(input);
            await _DbContext.SaveChangesAsync();
            var _data = await GetListByList(input);
            return _data;
        }

        public async Task<Certificate> UpdateAsync(Certificate input)
        {
            _DbContext.Certificates.Update(input);
            await _DbContext.SaveChangesAsync();
            var _data = await GetByIdAsync(input.Id);
            return _data;

        }

        public async Task<List<Certificate>> UpdateRangeAsync(List<Certificate> input)
        {
            _DbContext.Certificates.UpdateRange(input);
            await _DbContext.SaveChangesAsync();
            var _data = await GetListByList(input);
            return _data;
        }

        public async Task DeleteAsync(int id)
        {
            var _data = await _DbContext.Certificates.FindAsync(id);
            _DbContext.Certificates.Remove(_data);
            await _DbContext.SaveChangesAsync();
        }


        private async Task<List<Certificate>> GetListByList(List<Certificate> input)
        {
            var _list = new List<Certificate>() { };
            foreach (var certificate in input)
            {
                var item = await _DbContext.Certificates.Include(c => c.Category).FirstOrDefaultAsync(a => a.Id == certificate.Id);
                _list.Add(item);
            }
            return _list;
        }

    }
}
