using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.TeamFoundation.Client;
using Microsoft.TeamFoundation.TestManagement.Client;
using Microsoft.TeamFoundation.WorkItemTracking.Client;

namespace Tfswork
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri CollectionUri = (args.Length < 1) ? new Uri("http://desktop-anh3ro7:8080/tfs/DefaultCollection/") : new Uri(args[0]);
            TfsTeamProjectCollection tpc = new TfsTeamProjectCollection(CollectionUri);
            WorkItemStore wis = tpc.GetService<WorkItemStore>();  // To get work items service
            ITestManagementTeamProject tm = tpc.GetService<ITestManagementService>().GetTeamProject("TechBrothers");
        }
    }
}
