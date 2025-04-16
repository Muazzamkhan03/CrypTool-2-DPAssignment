using CrypTool.PluginBase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace CrypCloud.Core.CloudComponent
{
    public class EncryptedCloudComponent : ACloudComponent
    {
        private readonly AesCryptoServiceProvider aes = new AesCryptoServiceProvider();

        public override ISettings Settings { get; }

        public override UserControl Presentation { get; set; }

        public override event PropertyChangedEventHandler PropertyChanged;
        public override event StatusChangedEventHandler OnPluginStatusChanged;
        public override event PluginProgressChangedEventHandler OnPluginProgressChanged;

        public override List<byte[]> CalculateBlock(BigInteger blockId, CancellationToken cancelToken)
        {
            byte[] blockData = BitConverter.GetBytes((int)blockId);
            return new List<byte[]> { Encrypt(blockData) };
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
            // Keep encrypted results separate for security reasons
            return oldResultList.Union(newResultList).ToList();
        }

        private byte[] Encrypt(byte[] data)
        {
            var encryptor = aes.CreateEncryptor();
            return encryptor.TransformFinalBlock(data, 0, data.Length);
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
