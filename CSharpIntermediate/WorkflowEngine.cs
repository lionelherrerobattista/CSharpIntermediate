using System;

namespace CSharpIntermediate
{
    public class WorkflowEngine
    {
        public void Run(Workflow workflow)
        {
            if (workflow == null)
                throw new ArgumentNullException(nameof(workflow));
            
            foreach (var activity in workflow.Activities)
                activity.Execute();
        }
    }
}
