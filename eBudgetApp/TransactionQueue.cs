using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBudgetApp
{
    /***************************************************************
    * Name        : TransactionQueue
    * Author      : Michael Harmon
    * Created     : 4/27/2020
    ***************************************************************/
    public class TransactionQueue
    {
        private int maxQueueSize = 100;
        private Transaction[] transQueue;
        private int rear = 0;
        private int front = 0;
        private int size = 0;

        /**************************************************************
        * Constructors
        ***************************************************************/
        /**************************************************************
        * Name: TransactionQueue
        * Description: Default no-arg constructor
        * Input parameters: none
        ***************************************************************/
        public TransactionQueue()
        {
            this.transQueue = new Transaction[maxQueueSize];
        }

        /**************************************************************
        * Name: Enqueue
        * Description: Enqueue a transaction to our queue
        * Input: None
        * Output: None or string if empty
        ***************************************************************/
        public string Enqueue(Transaction transaction)
        {
            if (IsFull())
            {
                return "Your queue is full.";
            }
            else
            {
                this.transQueue[rear] = transaction;
                rear += 1;
                return "Queued Transaction";
            }
        }

       /**************************************************************
       * Name: Dequeue
       * Description: Dequeue a transaction from the queue
       * Input: None
       * Output: None or string if empty
       ***************************************************************/
        public string Dequeue()
        {
            if (IsEmpty())
            {
                string emptyQueue = "You have no transactions.";

                return emptyQueue;
            }

            Transaction trans = this.transQueue[front];
            this.transQueue[front] = null;
            front += 1;
            string dequeuedItem = "Removed transaction.";
            return dequeuedItem;

        }

        /**************************************************************
        * Name: IsEmpty
        * Description: Checks if queue is empty
        * Input: None
        * Output: boolean
        ***************************************************************/
        public bool IsEmpty()
        {
            if (front < 0 || front > rear)
            {
                return true;
            }

            return false;
        }

        /**************************************************************
        * Name: IsFull
        * Description: Checks if queue is full
        * Input: None
        * Output: boolean
        ***************************************************************/
        public bool IsFull()
        {
            if (rear == maxQueueSize)
            {
                return true;
            }

            return false;
        }

        /**************************************************************
        * Name: Size
        * Description: Checks size of queue
        * Input: None
        * Output: int
        ***************************************************************/
        public int Size()
        {
            size = 0;

            foreach (Transaction t in this.transQueue)
            {
                if (t != null)
                {
                    size += 1;
                }
            }
            return size;
        }

    }
}
