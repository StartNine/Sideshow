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
    
    public class IConfigurationViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IConfigurationContract
    {
        private Sideshow.Views.IConfiguration _view;
        public IConfigurationViewToContractAddInAdapter(Sideshow.Views.IConfiguration view)
        {
            _view = view;
        }
        public System.AddIn.Contract.IListContract<Start9.Api.Contracts.IConfigurationEntryContract> Entries
        {
            get
            {
                return System.AddIn.Pipeline.CollectionAdapters.ToIListContract<Sideshow.Views.IConfigurationEntry, Start9.Api.Contracts.IConfigurationEntryContract>(_view.Entries, Sideshow.Adapters.IConfigurationEntryAddInAdapter.ViewToContractAdapter, Sideshow.Adapters.IConfigurationEntryAddInAdapter.ContractToViewAdapter);
            }
        }
        internal Sideshow.Views.IConfiguration GetSourceView()
        {
            return _view;
        }
    }
}

