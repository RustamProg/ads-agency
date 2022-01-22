using System.Threading.Tasks;
using AdsAgency.Documents.Domain.Models;

namespace AdsAgency.Documents.Domain.Abstractions
{
    public interface IDocumentService
    {
        Task Create(DocumentBase document);
    }
}