using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab3
{
    // Методы для сортировок
    public partial class MainForm
    {
        int[] _array;
        int[] _sorted;
        int[] _parallelSorted;
        Semaphore _start = new Semaphore(0, 1),
            _first = new Semaphore(1, 1),
            _second = new Semaphore(1, 1);

        private void GenerateArray(int size)
        {
            Random random = new Random();
            _array = new int[size];
            _sorted = new int[size];
            _parallelSorted = new int[size];
            for (int i = 0; i < size; i++)
            {
                _array[i] = random.Next(-100, 100);
            }
        }

        private void SleepIf(bool sleep)
        {
            if (sleep) { Thread.Sleep(100); }
        }

        private void SortBubble(int[] sorted, bool inc = true, bool sleep = false)
        {
            if (sorted == null) { return; }

            int size = sorted.Count();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (useCritical.Checked) { Monitor.Enter(this); }
                    if ((inc && sorted[j] > sorted[j + 1])
                        || (!inc && sorted[j] < sorted[j + 1]))
                    {
                        SleepIf(sleep);
                        int c = sorted[j]; SleepIf(sleep);
                        sorted[j] = sorted[j + 1]; SleepIf(sleep);
                        sorted[j + 1] = c; SleepIf(sleep);
                    }
                    if (useCritical.Checked) { Monitor.Exit(this); }
                }
            }
        }

        private void SortSelection(int[] sorted, bool inc = true, bool sleep = false)
        {
            if (sorted == null) { return; }

            int size = sorted.Count();
            for (int i = 0; i < size - 1; i++)
            {
                int min_max = i;
                if (useCritical.Checked) { Monitor.Enter(this); }
                for (int j = i + 1; j < size; j++)
                {
                    if ((inc && sorted[j] < sorted[min_max])
                        || (!inc && sorted[j] > sorted[min_max]))
                    {
                        min_max = j;
                    }
                }
                if (min_max != i)
                {
                    SleepIf(sleep);
                    int c = sorted[i]; SleepIf(sleep);
                    sorted[i] = sorted[min_max]; SleepIf(sleep);
                    sorted[min_max] = c; SleepIf(sleep);
                }
                if (useCritical.Checked) { Monitor.Exit(this); }
            }
        }

        private void SortParallel()
        {
            Thread bubble = new Thread(() =>
            {
                _first.WaitOne();
                _start.WaitOne();

                SortBubble(_parallelSorted, true, true);

                _first.Release();
            });
            bubble.Name = "BubbleSort";
            bubble.Start();

            Thread selection = new Thread(() =>
            {
                _second.WaitOne();
                _start.Release();

                SortSelection(_parallelSorted, true, true);

                _second.Release();
            });
            selection.Name = "SelectionSort";
            selection.Start();

            Thread.Sleep(1000);
            _first.WaitOne(); _first.Release();
            _second.WaitOne(); _second.Release();
        }

        private void SortIncDec()
        {
            Thread bubbleInc = new Thread(() =>
            {
                _first.WaitOne();
                _start.WaitOne();

                SortBubble(_parallelSorted, true, true);

                _first.Release();
            });
            bubbleInc.Name = "IncSort";
            bubbleInc.Start();

            Thread bubbleDec = new Thread(() =>
            {
                _second.WaitOne();
                _start.Release();

                SortBubble(_parallelSorted, false, true);

                _second.Release();
            });
            bubbleDec.Name = "DecSort";
            bubbleDec.Start();

            Thread.Sleep(1000);
            _first.WaitOne(); _first.Release();
            _second.WaitOne(); _second.Release();
        }
    }
}
