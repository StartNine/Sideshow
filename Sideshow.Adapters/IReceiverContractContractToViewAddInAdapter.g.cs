//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sideshow.Adapters
{
    
    public class IReceiverContractContractToViewAddInAdapter : Sideshow.Views.IReceiverContract
    {
        private Start9.Api.Contracts.IReceiverContractContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IReceiverContractContractToViewAddInAdapter()
        {
        }
        public IReceiverContractContractToViewAddInAdapter(Start9.Api.Contracts.IReceiverContractContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public System.Collections.Generic.IList<Sideshow.Views.IReceiverEntry> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIList<Start9.Api.Contracts.IReceiverEntryContract, Sideshow.Views.IReceiverEntry>(_contract.Entries, Sideshow.Adapters.IReceiverEntryAddInAdapter.ContractToViewAdapter, Sideshow.Adapters.IReceiverEntryAddInAdapter.ViewToContractAdapter);
            }
        }
        internal Start9.Api.Contracts.IReceiverContractContract GetSourceContract()
        {
            return _contract;
        }
    }
}

