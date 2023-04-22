using System;
using System.Collections;
using System.Collections.Generic;

namespace IO
{
    public class Memory : IEnumerable<Memory.CellType>
    {
        private int reservedCount;

        private CellType[] memory;
        
        public Memory(int size, int reservedCount = 0)
        {
            this.reservedCount = reservedCount;
            
            this.memory = new CellType[size];
            this.Selection = new Selection(size);

            ReserveCells();
        }

        public int Size => memory.Length;
        public IReadOnlyList<CellType> Cells => memory;
        public Selection Selection { get; private set; }

        public IEnumerator<CellType> GetEnumerator() => null;
        IEnumerator IEnumerable.GetEnumerator() => memory.GetEnumerator();

        public event Action MemoryUpdate;

        public void ClearCellsInSelection()
        {
            if (!Selection.Valid)
            {
                return;
            }

            for (int i = Selection.From; i <= Selection.To; i++) 
            {
                if (memory[i] == CellType.Reserved) continue;

                memory[i] = CellType.Empty;
            }

            MemoryUpdate?.Invoke();
        }

        public void FillCellsInSelection()
        {
            if (!Selection.Valid)
            {
                return;
            }

            for (int i = Selection.From; i <= Selection.To; i++)
            {
                if (memory[i] == CellType.Reserved) continue;

                memory[i] = CellType.Filled;
            }

            MemoryUpdate?.Invoke();
        }

        public void Resize(int size)
        {
            if (size == Size) return;

            this.memory = new CellType[size];
            this.Selection = new Selection(size);
            ReserveCells();

            MemoryUpdate?.Invoke();
        }

        public List<int> GetBlocksInSelection()
        {
            if (!Selection.Valid) 
            { 
                return null; 
            }

            var blocks = new List<int>();
            for (int i = Selection.From; i <= Selection.To; i++)
            {
                if (memory[i] != CellType.Filled) continue;
                blocks.Add(i);
            }
            return blocks;
        }

        public bool EnoughSpaceToTransfer(int count)
        {
            foreach (var block in memory) 
            {
                if (block != CellType.Empty) continue;
                if (--count <= 0) break;
            }
            return count <= 0;
        }

        public void TransmitBlock(int block)
        {
            memory[block] = CellType.Empty;
            MemoryUpdate?.Invoke();
        }

        public void RecieveBlock()
        {
            for (var i = 0; i < memory.Length; i++)
            {
                if (memory[i] != CellType.Empty) continue;

                memory[i] = CellType.Filled;
                MemoryUpdate?.Invoke();
                return;
            }
        }

        private void ReserveCells()
        {
            for (var i = 0; i < memory.Length && i < reservedCount; i++)
            {
                memory[i] = CellType.Reserved;
            }
        }

        public enum CellType
        {
            Empty = 0,
            Filled,
            Reserved
        }
    }
}
