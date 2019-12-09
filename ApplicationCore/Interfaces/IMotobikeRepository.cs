using System.Collections.Generic;
using ApplicationCore.Entities;

namespace ApplicationCore.Interfaces
{
    public interface IMotobikeRepository : IRepository<Motobike>
    {
        IEnumerable<string> GetTypes();
        IEnumerable<string> GetColors();
    }
}