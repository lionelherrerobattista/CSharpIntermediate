using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var videoUploader = new VideoUploader();
            var videoEncoder = new VideoEncoder();
            var emailNotifier = new EmailNotifier();
            var dbCommand = new DbCommand();
            var workflow = new Workflow();
            var workflowEngine = new WorkflowEngine();

            // Load activities
            workflow.RegistrateActivity(videoUploader);
            workflow.RegistrateActivity(videoEncoder);
            workflow.RegistrateActivity(emailNotifier);
            workflow.RegistrateActivity(dbCommand);

            // Run workflow
            workflowEngine.Run(workflow);
        }
    }
}
