using ProjectRESTAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectRESTAPI.Data
{
    public interface ICourse : ICrud<Course>
    {
        Task<IEnumerable<Course>> GetByCourseName(string coursename);
    }
}
