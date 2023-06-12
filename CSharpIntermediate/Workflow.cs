using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Workflow
    {
        public IList<IActivity> Activities { get; private set; }

        public Workflow()
        {
            Activities = new List<IActivity>();
        }

        public void RegistrateActivity(IActivity activity)
        {
            if(activity == null) 
                throw new ArgumentNullException(nameof(activity));

            Activities.Add(activity);
        }
    }
}
