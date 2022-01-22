using System.Threading.Tasks;
using AdsAgency.Documents.Domain.Abstractions;
using AdsAgency.Documents.Domain.Models;
using AdsAgency.Documents.Web.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace AdsAgency.Documents.Web.Controllers
{
    [Route("documents")]
    public class DocumentsController : ControllerBase
    {
        private readonly IDocumentService _documentService;

        public DocumentsController(IDocumentService documentService)
        {
            _documentService = documentService;
        }

        [HttpGet]
        public IActionResult GetAll(GetDocumentModel model)
        {
            
            return Ok();
        }
        
        [HttpPost]
        public async Task<IActionResult> Create(DocumentBase document)
        {
            await _documentService.Create(document);
            
            return Ok();
        }
    }
}