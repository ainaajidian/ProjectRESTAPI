using PaymentService.Models;
using System.Threading.Tasks;

namespace PaymentService.Data
{
    public interface IEnrollment
    {
        Task EnrollmentCreate(Enrollment enrollment);
    }
}
