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
    
    public class IMessageContractViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IMessageContractContract
    {
        private Sideshow.Views.IMessageContract _view;
        public IMessageContractViewToContractAddInAdapter(Sideshow.Views.IMessageContract view)
        {
            _view = view;
        }
        public System.AddIn.Contract.IListContract<Start9.Api.Contracts.IMessageEntryContract> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<Sideshow.Views.IMessageEntry, Start9.Api.Contracts.IMessageEntryContract>(_view.Entries, Sideshow.Adapters.IMessageEntryAddInAdapter.ViewToContractAdapter, Sideshow.Adapters.IMessageEntryAddInAdapter.ContractToViewAdapter);
            }
        }
        internal Sideshow.Views.IMessageContract GetSourceView()
        {
            return _view;
        }
    }
}

