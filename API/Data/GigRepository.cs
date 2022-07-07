using API.Interfaces;
using AutoMapper;

namespace API.Data
{
    public class GigRepository: IGigRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public GigRepository(DataContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }
    }
}