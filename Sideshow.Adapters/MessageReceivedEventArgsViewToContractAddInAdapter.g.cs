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
    
    public class MessageReceivedEventArgsViewToContractAddInAdapter : System.AddIn.Pipeline.ContractBase, Start9.Api.Contracts.IMessageReceivedEventArgsContract
    {
        private Sideshow.Views.MessageReceivedEventArgs _view;
        public MessageReceivedEventArgsViewToContractAddInAdapter(Sideshow.Views.MessageReceivedEventArgs view)
        {
            _view = view;
        }
        public Start9.Api.Contracts.IMessageContract Message
        {
            get
            {
                return Sideshow.Adapters.IMessageAddInAdapter.ViewToContractAdapter(_view.Message);
            }
        }
        internal Sideshow.Views.MessageReceivedEventArgs GetSourceView()
        {
            return _view;
        }
    }
}

