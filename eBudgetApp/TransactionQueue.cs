using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    public class TransactionQueue
    {
        private int maxQueueSize = 100;
        private Transaction[] transQueue;
        private int rear = 0;
        private int front = 0;
        private int size = 0;

        public TransactionQueue()
        {
            this.transQueue = new Transaction[maxQueueSize];
        }

        public void Enqueue(Transaction transaction)
        {
            this.transQueue[rear] = transaction;
            rear += 1;
        }
    }
}
