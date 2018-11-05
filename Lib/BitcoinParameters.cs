using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class BitcoinParameters
    {
        public BitcoinParameters(string daemonUrl,
            string rpcUsername,
            string rpcPassword,
            string walletPassword,
            short rpcRequestTimeoutInSeconds)
        {
            DaemonUrl = daemonUrl;
            UseTestnet = false;
            IgnoreConfigFiles = true;
            RpcUsername = rpcUsername;
            RpcPassword = rpcPassword;
            WalletPassword = walletPassword;

            if (!IgnoreConfigFiles)
            {
                DaemonUrl = ConfigurationManager.AppSettings.Get("Bitcoin_DaemonUrl");
                DaemonUrlTestnet = ConfigurationManager.AppSettings.Get("Bitcoin_DaemonUrl_Testnet");
                RpcUsername = ConfigurationManager.AppSettings.Get("Bitcoin_RpcUsername");
                RpcPassword = ConfigurationManager.AppSettings.Get("Bitcoin_RpcPassword");
                WalletPassword = ConfigurationManager.AppSettings.Get("Bitcoin_WalletPassword");
            }

            CoinShortName = "BTC";
            CoinLongName = "Bitcoin";
            IsoCurrencyCode = "XBT";

            TransactionSizeBytesContributedByEachInput = 148;
            TransactionSizeBytesContributedByEachOutput = 34;
            TransactionSizeFixedExtraSizeInBytes = 10;

            FreeTransactionMaximumSizeInBytes = 1000;
            FreeTransactionMinimumOutputAmountInCoins = 0.01M;
            FreeTransactionMinimumPriority = 57600000;
            FeePerThousandBytesInCoins = 0.0001M;
            MinimumTransactionFeeInCoins = 0.0001M;
            MinimumNonDustTransactionAmountInCoins = 0.0000543M;

            TotalCoinSupplyInCoins = 21000000;
            EstimatedBlockGenerationTimeInMinutes = 10;
            BlocksHighestPriorityTransactionsReservedSizeInBytes = 50000;

            BaseUnitName = "Satoshi";
            BaseUnitsPerCoin = 100000000;
            CoinsPerBaseUnit = 0.00000001M;
        }

        public string BaseUnitName { get; set; }
        public uint BaseUnitsPerCoin { get; set; }
        public int BlocksHighestPriorityTransactionsReservedSizeInBytes { get; set; }
        public int BlockMaximumSizeInBytes { get; set; }
        public string CoinShortName { get; set; }
        public string CoinLongName { get; set; }
        public decimal CoinsPerBaseUnit { get; set; }
        public string DaemonUrl { private get; set; }
        public string DaemonUrlTestnet { private get; set; }
        public double EstimatedBlockGenerationTimeInMinutes { get; set; }
        public int ExpectedNumberOfBlocksGeneratedPerDay => (int)EstimatedBlockGenerationTimeInMinutes * GlobalConstants.MinutesInADay;
        public decimal FeePerThousandBytesInCoins { get; set; }
        public short FreeTransactionMaximumSizeInBytes { get; set; }
        public decimal FreeTransactionMinimumOutputAmountInCoins { get; set; }
        public int FreeTransactionMinimumPriority { get; set; }
        public bool IgnoreConfigFiles { get; }
        public string IsoCurrencyCode { get; set; }
        public decimal MinimumNonDustTransactionAmountInCoins { get; set; }
        public decimal MinimumTransactionFeeInCoins { get; set; }
        public decimal OneBaseUnitInCoins => CoinsPerBaseUnit;
        public uint OneCoinInBaseUnits => BaseUnitsPerCoin;
        public string RpcPassword { get; set; }
        public short RpcRequestTimeoutInSeconds { get; set; }
        public string RpcUsername { get; set; }
        public string SelectedDaemonUrl => !UseTestnet ? DaemonUrl : DaemonUrlTestnet;
        public ulong TotalCoinSupplyInCoins { get; set; }
        public int TransactionSizeBytesContributedByEachInput { get; set; }
        public int TransactionSizeBytesContributedByEachOutput { get; set; }
        public int TransactionSizeFixedExtraSizeInBytes { get; set; }
        public bool UseTestnet { get; set; }
        public string WalletPassword { get; set; }
    }
}
