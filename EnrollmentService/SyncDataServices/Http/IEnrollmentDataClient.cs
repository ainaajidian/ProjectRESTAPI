using EnrollmentService.Dtos;
using System.Threading.Tasks;

namespace EnrollmentService.SyncDataServices.Http
{
    public interface IEnrollmentDataClient
    {
        Task EnrollmentCreateFromPaymentService(EnrollmentCreateDto enrollment);
    }
}