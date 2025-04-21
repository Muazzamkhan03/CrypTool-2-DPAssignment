using CrypTool.PluginBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CrypCloud.Core.CloudComponent
{
    public class AIOptimizedCloudComponent : ACloudComponent
    {
        // ***** Integrates a machine learning module to dynamically choose the best parameters for each encryption block. *****

        public override ISettings Settings { get; }

        public override UserControl Presentation { get; set; }

        public override event PropertyChangedEventHandler PropertyChanged;
        public override event StatusChangedEventHandler OnPluginStatusChanged;
        public override event PluginProgressChangedEventHandler OnPluginProgressChanged;

        public override List<byte[]> CalculateBlock(BigInteger blockId, CancellationToken cancelToken)
        {
            // Can be implemented later with an actual implementation
            return new List<byte[]>();
        }

        public override List<byte[]> MergeBlockResults(IEnumerable<byte[]> oldResultList, IEnumerable<byte[]> newResultList)
        {
            // Can be implemented later with an actual implementation
            return new List<byte[]>();
        }

        public override void Dispose()
        {

        }

        public override void Execute()
        {

        }

        public override void Initialize()
        {

        }

        public override void PostExecution()
        {

        }

        public override void PreExecutionLocal()
        {

        }

        public override void StopLocal()
        {

        }
    }
}
