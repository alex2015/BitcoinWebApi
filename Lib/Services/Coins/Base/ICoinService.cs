// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using Lib.CoinParameters.Base;
using Lib.Services.RpcServices.RpcExtenderService;
using Lib.Services.RpcServices.RpcService;

namespace Lib.Services.Coins.Base
{
    public interface ICoinService : IRpcService, IRpcExtenderService, ICoinParameters
    {
    }
}