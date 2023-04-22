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

        
        public event Action SizeChanged;

        public void Resize(int size)
        {
            this.memory = new CellType[size];
            this.Selection = new Selection(size);
            ReserveCells();

            SizeChanged?.Invoke();
        }

        private void ReserveCells()
        {
            for (int i = 0; i < memory.Length && i < reservedCount; i++)
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
