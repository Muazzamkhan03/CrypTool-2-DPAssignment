using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkspaceManagerModel.Model.Interfaces
{
    public class ExecutionLogView : IUpdateableView
    {
        // ***** Receives notifications and appends to the live log panel. *****

        public void update(IEditor state)
        {
            // Will have the relevant implementation.
        }

        public void updateStatus(IEditor state)
        {
            // Will have the relevant implementation.
        }
    }
}
