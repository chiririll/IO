using System;
using System.Collections.Generic;

namespace IO
{
    public class TransferModel
    {
        private readonly Memory cpuMemory;
        private readonly Memory externalMemory;

        private float msSpeed = 0;

        private List<int> blocksToTransfer;
        private int blocksTransfered = 0;

        public TransferModel(Memory cpuMemory, Memory externalMemory)
        {
            this.cpuMemory = cpuMemory;
            this.externalMemory = externalMemory;
        }
        
        public bool DirectionToCpu { get; private set; }
        public bool Transfering { get; private set; }
        public int BytesInBlock { get; private set; }
        
        public int TransferedBits { get; private set; }
        public int TotalBits { get; private set; }

        private Memory TargetMem => DirectionToCpu ? cpuMemory : externalMemory;
        private Memory SourceMem => DirectionToCpu ? externalMemory : cpuMemory;

        public event Action StateChanged;
        public event Action ProgressUpdate;
        public event Action TransferStarted;
        public event Action TransferCompleted;
        public event Action TransferEnded;

        public void Tick(int deltaTime)
        {
            if (!Transfering) return;

            TransferedBits += Convert.ToInt32(deltaTime * msSpeed);

            if (TransferedBits >= TotalBits)
            {
                TransferedBits = TotalBits;
                ProgressUpdate?.Invoke();
                
                Transfering = false;
                blocksTransfered = 0;
                blocksToTransfer = null;

                TransferCompleted?.Invoke();
                TransferEnded?.Invoke();
                StateChanged?.Invoke();
                return;
            }

            if (TransferedBits > blocksTransfered * BytesInBlock * 8)
            {
                TargetMem.RecieveBlock();
                SourceMem.TransmitBlock(blocksToTransfer[blocksTransfered]);
                
                blocksTransfered++;
            }

            ProgressUpdate?.Invoke();
        }

        public void SetBlockSize(int blockSize)
        {
            BytesInBlock = blockSize;
        }

        public void SetSpeed(int speed)
        {
            msSpeed = speed / 1000f;
        }

        public void SwitchDirection()
        {
            DirectionToCpu = !DirectionToCpu;
            StateChanged?.Invoke();
        }

        public void StartTransfer()
        {
            blocksToTransfer = SourceMem.GetBlocksInSelection();
            if (blocksToTransfer == null) throw new System.ArgumentException();
            if (!TargetMem.EnoughSpaceToTransfer(blocksToTransfer.Count)) throw new System.OutOfMemoryException();

            TransferedBits = 0;
            TotalBits = blocksToTransfer.Count * BytesInBlock * 8;
            blocksTransfered = 0;

            Transfering = true;
            TransferStarted?.Invoke();
            StateChanged?.Invoke();
        }

        public void CancelTransfer()
        {
            TransferedBits = 0;
            TotalBits = 0;
            
            blocksTransfered = 0;
            blocksToTransfer = null;

            Transfering = false;

            TransferEnded?.Invoke();
            StateChanged?.Invoke();
        }
    }
}
