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
    
    public class IModuleContractToViewAddInAdapter : Sideshow.Views.IModule
    {
        private Start9.Api.Contracts.IModuleContract _contract;
        private System.AddIn.Pipeline.ContractHandle _handle;
        static IModuleContractToViewAddInAdapter()
        {
        }
        public IModuleContractToViewAddInAdapter(Start9.Api.Contracts.IModuleContract contract)
        {
            _contract = contract;
            _handle = new System.AddIn.Pipeline.ContractHandle(contract);
        }
        public Sideshow.Views.IConfiguration Configuration
        {
            get
            {
                return Sideshow.Adapters.IConfigurationAddInAdapter.ContractToViewAdapter(_contract.Configuration);
            }
            set
            {
                _contract.Configuration = Sideshow.Adapters.IConfigurationAddInAdapter.ViewToContractAdapter(value);
            }
        }
        public Sideshow.Views.IMessageContract MessageContract
        {
            get
            {
                return Sideshow.Adapters.IMessageContractAddInAdapter.ContractToViewAdapter(_contract.MessageContract);
            }
        }
        public Sideshow.Views.IReceiverContract ReceiverContract
        {
            get
            {
                return Sideshow.Adapters.IReceiverContractAddInAdapter.ContractToViewAdapter(_contract.ReceiverContract);
            }
        }
        public void Initialize(Sideshow.Views.IHost host)
        {
            _contract.Initialize(Sideshow.Adapters.IHostAddInAdapter.ViewToContractAdapter(host));
        }
        internal Start9.Api.Contracts.IModuleContract GetSourceContract()
        {
            return _contract;
        }
    }
}

