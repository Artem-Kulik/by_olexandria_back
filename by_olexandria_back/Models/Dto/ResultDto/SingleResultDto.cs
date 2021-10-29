using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace by_olexandria_back.Models.Dto.ResultDto
{
    public class SingleResultDto<T> : ResultDto
    {
        public T Data { get; set; }
    }
}
