using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jobAdvertisementApp.Enums
{
    public interface IResponse<T> : IResponse
    {
        T Data { get; set; }

        List<CustomValidationError> ValidationErrors { get; set; }
    }
}
