using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace IvmpDotNet.ServiceHost {
    public class Host {
        private void Closing(IAsyncResult res) {

        }

        private void Opening(IAsyncResult res) {
            Console.WriteLine("The service is ready at {0}");
            Console.WriteLine("Press <Enter> to stop the service.");
            Console.ReadLine();

        }

        async public Task StartAsync() {
            //Uri baseAddress = new Uri("http://localhost:8080/hello");

            //using (System.ServiceModel.ServiceHost host = new System.ServiceModel.ServiceHost(typeof(IvmpDotNet.Core.IvmpDotNetCore), baseAddress)) {
            //    // Enable metadata publishing.
            //    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            //    smb.HttpGetEnabled = true;
            //    smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
            //    host.Description.Behaviors.Add(smb);

            //    // Open the ServiceHost to start listening for messages. Since
            //    // no endpoints are explicitly configured, the runtime will create
            //    // one endpoint per base address for each service contract implemented
            //    // by the service.
            //    host.BeginOpen(Opening, null);


            //    // Close the ServiceHost.
            //    //host.Close();
            //}
        }
    }
}
