using System;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System.Xml;
using System.Text;
using System.IO;

namespace ContactPreUpdate
{
    public class ContactpreUpdate : IPlugin
    {
        public void Execute(IServiceProvider serviceProvider)
        {
            var context = (IPluginExecutionContext)serviceProvider.GetService(typeof(IPluginExecutionContext));
            var contact = (Entity)context.InputParameters["Target"];
            contact.Attributes.Add("Description", "Updated From Plugin");
            //throw new NotImplementedException();
        }
    }
}
