using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Threading;

namespace Task1
{
    public partial class Task1 : Form
    {
        public int itemId;
        public TestQueue testQueue;
        //==================================================================================================================
        public Task1()
        {
            testQueue = new TestQueue();
            testQueue.queue = new Queue<object>();
            testQueue.onPop += new Action<object>(testQueue_onPop);

            itemId = 0;
            InitializeComponent();
        }
        //==================================================================================================================
        void testQueue_onPop(object obj)
        {
            Action action = () =>
            {
                lstPop.Items.Add((int)obj);
                FillPushList();
                btnPop.Enabled = true;
            };
            Invoke(action);
        }
        //==================================================================================================================
        private void btnPush_Click(object sender, EventArgs e)
        {
            testQueue.Push(itemId);
            itemId++;

            FillPushList();
        }
        //==================================================================================================================
        private void btnPop_Click(object sender, EventArgs e)
        {
            testQueue.Pop();
            btnPop.Enabled = false;
        }
        //==================================================================================================================
        public void FillPushList()
        {
            lstPush.Items.Clear();
            for (int i = 0; i < testQueue.queue.Count; i++)
            {
                lstPush.Items.Add(testQueue.queue.ElementAt(i));
            }
        }
        //==================================================================================================================
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            testQueue.isStop = true;
        }
        //==================================================================================================================
    }

    public class TestQueue
    {
        public Queue<object> queue { get; set; }
        public event Action<object> onPop;
        public bool isStop;
        //========================================================================================================
        public TestQueue()
        {
            isStop = false;
            queue = new Queue<object>();
        }
        //========================================================================================================
        public void Push(object item)
        {
            queue.Enqueue(item);
        }
        //========================================================================================================
        public void Pop1()
        {
            onPop(queue.Dequeue());
        }
        //========================================================================================================
        public void Pop(bool isStop = false)
        {
            Thread _threadPop = new Thread(thread_Pop);
            _threadPop.Start();
        }
        //========================================================================================================
        public void thread_Pop()
        {
            if (queue.Count == 0)
            {
                while (true)
                {
                    if (isStop) return;
                    if (queue.Count == 0) continue;

                    onPop(queue.Dequeue());
                    return;
                }
            }
            onPop(queue.Dequeue());
        }
        //========================================================================================================
    }
}
