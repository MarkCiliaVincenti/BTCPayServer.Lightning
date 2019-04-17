using System.Collections.Generic;

namespace BTCPayServer.Lightning.Eclair.Models
{
    public class ChannelResponse
    {
        public string NodeId { get; set; }
        public string ChannelId { get; set; }
        public string State { get; set; }
        public ChannelData Data { get; set; }

        public partial class ChannelData
        {
            public Commitments Commitments { get; set; }
            public string ShortChannelId { get; set; }
            public bool Buried { get; set; }
            public ChannelAnnouncement ChannelAnnouncement { get; set; }
            public ChannelUpdate ChannelUpdate { get; set; }
        }

        public partial class ChannelAnnouncement
        {
            public string NodeSignature1 { get; set; }
            public string NodeSignature2 { get; set; }
            public string BitcoinSignature1 { get; set; }
            public string BitcoinSignature2 { get; set; }
            public string Features { get; set; }
            public string ChainHash { get; set; }
            public string ShortChannelId { get; set; }
            public string NodeId1 { get; set; }
            public string NodeId2 { get; set; }
            public string BitcoinKey1 { get; set; }
            public string BitcoinKey2 { get; set; }
        }

        public partial class ChannelUpdate
        {
            public string Signature { get; set; }
            public string ChainHash { get; set; }
            public string ShortChannelId { get; set; }
            public long Timestamp { get; set; }
            public long MessageFlags { get; set; }
            public long ChannelFlags { get; set; }
            public long CltvExpiryDelta { get; set; }
            public long HtlcMinimumMsat { get; set; }
            public long FeeBaseMsat { get; set; }
            public long FeeProportionalMillionths { get; set; }
            public long HtlcMaximumMsat { get; set; }
        }

        public partial class Commitments
        {
            public LocalParams LocalParams { get; set; }
            public RemoteParams RemoteParams { get; set; }
            public long ChannelFlags { get; set; }
            public LocalCommit LocalCommit { get; set; }
            public RemoteCommit RemoteCommit { get; set; }
            public Changes LocalChanges { get; set; }
            public Changes RemoteChanges { get; set; }
            public long LocalNextHtlcId { get; set; }
            public long RemoteNextHtlcId { get; set; }
            public OriginChannels OriginChannels { get; set; }
            public string RemoteNextCommitInfo { get; set; }
            public CommitInput CommitInput { get; set; }
            public object RemotePerCommitmentSecrets { get; set; }
            public string ChannelId { get; set; }
        }

        public partial class CommitInput
        {
            public string OutPoint { get; set; }
            public long AmountSatoshis { get; set; }
        }

        public partial class Changes
        {
            public List<object> Proposed { get; set; }
            public List<object> Signed { get; set; }
            public List<object> Acked { get; set; }
        }

        public partial class LocalCommit
        {
            public long Index { get; set; }
            public Spec Spec { get; set; }
            public PublishableTxs PublishableTxs { get; set; }
        }

        public partial class PublishableTxs
        {
            public string CommitTx { get; set; }
            public List<object> HtlcTxsAndSigs { get; set; }
        }

        public partial class Spec
        {
            public List<object> Htlcs { get; set; }
            public long FeeratePerKw { get; set; }
            public long ToLocalMsat { get; set; }
            public long ToRemoteMsat { get; set; }
        }

        public partial class LocalParams
        {
            public string NodeId { get; set; }
            public ChannelKeyPath ChannelKeyPath { get; set; }
            public long DustLimitSatoshis { get; set; }
            public long MaxHtlcValueInFlightMsat { get; set; }
            public long ChannelReserveSatoshis { get; set; }
            public long HtlcMinimumMsat { get; set; }
            public long ToSelfDelay { get; set; }
            public long MaxAcceptedHtlcs { get; set; }
            public bool IsFunder { get; set; }
            public string DefaultFinalScriptPubKey { get; set; }
            public string GlobalFeatures { get; set; }
            public long LocalFeatures { get; set; }
        }

        public partial class ChannelKeyPath
        {
            public List<long> Path { get; set; }
        }

        public partial class OriginChannels
        {
        }

        public partial class RemoteCommit
        {
            public long Index { get; set; }
            public Spec Spec { get; set; }
            public string Txid { get; set; }
            public string RemotePerCommitmentPoint { get; set; }
        }

        public partial class RemoteParams
        {
            public string NodeId { get; set; }
            public long DustLimitSatoshis { get; set; }
            public long MaxHtlcValueInFlightMsat { get; set; }
            public long ChannelReserveSatoshis { get; set; }
            public long HtlcMinimumMsat { get; set; }
            public long ToSelfDelay { get; set; }
            public long MaxAcceptedHtlcs { get; set; }
            public string FundingPubKey { get; set; }
            public string RevocationBasepoint { get; set; }
            public string PaymentBasepoint { get; set; }
            public string DelayedPaymentBasepoint { get; set; }
            public string HtlcBasepoint { get; set; }
            public string GlobalFeatures { get; set; }
            public string LocalFeatures { get; set; }
        }

    }
}