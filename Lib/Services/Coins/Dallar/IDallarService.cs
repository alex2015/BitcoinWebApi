// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using Lib.CoinParameters.Dallar;
using Lib.Services.Coins.Base;

namespace Lib.Services.Coins.Dallar
{
    public interface IDallarService : ICoinService, IDallarConstants
    {
        decimal GetEstimateFeeForSendToAddress(string Address, decimal Amount);
    }
}