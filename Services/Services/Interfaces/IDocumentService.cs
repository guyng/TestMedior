using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services.Interfaces
{
	public interface IDocumentService
	{
		Task<> GetDocuments();
		Task AddDocument();
		Task UpdateDocument();
		Task DeleteDocument();
	}
}
