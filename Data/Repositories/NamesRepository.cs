using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DndMauiApp.Data.Repositories.Interfaces;

namespace DndMauiApp.Data.Repositories
{
	public class NamesRepository : INamesRepository
	{
		public async Task<NamesRepository> GetAsync(Guid id)
		{
			throw new NotImplementedException();
		}

		public async Task<IEnumerable<NamesRepository>> GetAllAsync()
		{
			throw new NotImplementedException();
		}

		public async Task<NamesRepository> AddAsync(NamesRepository entity)
		{
			throw new NotImplementedException();
		}

		public async Task<NamesRepository> UpdateAsync(NamesRepository entity)
		{
			throw new NotImplementedException();
		}

		public async Task<NamesRepository> DeleteAsync(NamesRepository entity)
		{
			throw new NotImplementedException();
		}
	}
}
