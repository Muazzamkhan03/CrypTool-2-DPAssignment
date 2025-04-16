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
    public class BasicCloudComponent : ACloudComponent
    {
        public override ISettings Settings { get; }

        public override UserControl Presentation { get; set; }

        public override event PropertyChangedEventHandler PropertyChanged;
        public override event StatusChangedEventHandler OnPluginStatusChanged;
        public override event PluginProgressChangedEventHandler OnPluginProgressChanged;

        public override List<byte[]> CalculateBlock(BigInteger blockId, CancellationToken cancelToken)
        {

            return new List<byte[]> { BitConverter.GetBytes((int)blockId ^ 0xFF) };
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

        public override List<byte[]> MergeBlockResults(IEnumerable<byte[]> oldResultList, IEnumerable<byte[]> newResultList)
        {

            return oldResultList.Concat(newResultList).ToList();
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
