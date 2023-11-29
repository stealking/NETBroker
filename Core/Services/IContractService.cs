﻿using Core.Models.Requests;
using Core.Models.Requests.Contracts;
using Core.Models.Response.Contracts;

namespace Core.Services
{
    public interface IContractService : IServiceBase<ContractResponse, IRequest, ContractParameters>
    {
        Task<ContractDetailResponse?> GetDetail(int id);
        Task<(int, int)> VerifyContract(int contractId);
    }
}
