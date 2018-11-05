﻿// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using Lib.Services;

namespace Lib.CoinParameters.Base
{
    public interface ICoinParameters
    {
        CoinService.CoinParameters Parameters { get; }
    }
}