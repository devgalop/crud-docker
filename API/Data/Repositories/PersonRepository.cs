using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Data.Entities;
using API.Data.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace API.Data.Repositories
{
    public class PersonRepository : IGenericRepository<Person>
    {
        private readonly DataContext _dataContext;
        public PersonRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(Person model)
        {
            await _dataContext.People.AddAsync(model);
        }

        public void Delete(Person model)
        {
            _dataContext.People.Remove(model);
        }

        public async Task<Person?> Get(Guid id)
        {
            return await _dataContext.People.Where(p => p.Id == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            return await _dataContext.People.ToListAsync();
        }

        public void Update(Person model)
        {
            _dataContext.People.Update(model);
        }
    }
}