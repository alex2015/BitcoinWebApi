// Copyright (c) 2014 - 2016 George Kimionis
// See the accompanying file LICENSE for the Software License Aggrement

using Lib.CoinParameters.Bitcoin;
using Lib.Services.RpcServices.RpcService;

namespace Lib.Services.Coins.Bitcoin
{
    public class BitcoinService : CoinService, IBitcoinService
    {
        public BitcoinService(bool useTestnet = false) : base(useTestnet)
        {
        }

        public BitcoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword)
        {
        }

        public BitcoinService(string daemonUrl, string rpcUsername, string rpcPassword, string walletPassword, short rpcRequestTimeoutInSeconds)
            : base(daemonUrl, rpcUsername, rpcPassword, walletPassword, rpcRequestTimeoutInSeconds)
        {
        }

        public BitcoinConstants.Constants Constants => BitcoinConstants.Constants.Instance;
    }
}