﻿using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Crm.CEP.Terms
{
    public interface ITerms: ICrudAppService<
            TermsDto,
            long,
            PagedAndSortedResultRequestDto,
            CreateUpdateTermsDto>
    {
    }
   
}
