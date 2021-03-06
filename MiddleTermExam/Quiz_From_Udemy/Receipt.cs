﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiddleTermExam
{
     public class Receipt
    {
        //Question1:constructor name ?? whey it is wrong when setting it to Receipt?
        //Answer1: no answer. errors dismiss by themselves

        //Question2: how to manage the arguments in the constructor?
        //Answer2: in the sample, it defines another set of arguments below.
        //        And transfer values from these arguments to the Properties

        //Question3: how to write the get and set?
        //Answer3: get has the key word "return".
        
        //private variables
        private int receiptNumber;
        private string dateOfPurchase;
        private int customerNumber;
        private string customerFirstName;
        private string customerLastName;
        private string customerPhoneNumber;
        private int itemNumber;
        private decimal unitPrice;
        private int qtyPurchased;

        //Constructor
        public Receipt(int rNum, string doPur, int cNum, string cFName, string cLName,
                        string cPNumber, int iNum, decimal uPrice, int qty)
        {
            ReceiptNumber = rNum;
            DateOfPurchase = doPur;
            CustomerNumber = cNum;
            CustomerFirstName = cFName;
            CustomerLastName = cLName;
            customerPhoneNumber = cPNumber;
            ItemNumber = iNum;
            UnitPrice = uPrice;
            QtyPurchased = qty;
        }
        public int ReceiptNumber
        {
            get
            {
                return receiptNumber;
            }
            set
            {
                if (value > 0)
                {
                    receiptNumber = value;
                }
            }
        }

        public string DateOfPurchase
        {
            get
            {
                return dateOfPurchase;
            }
            set
            {
                dateOfPurchase = value;
            }
        }
        public int CustomerNumber
        {
            get
            {
                return customerNumber;
            }
            set
            {
                if (value > 0)
                {
                    customerNumber = value;
                }
            }
        }

        public string CustomerFirstName
        {
            get
            {
                return customerFirstName;
            }
            set
            {
                customerFirstName = value;
            }
        }

        public string CustomerLastName
        {
            get
            {
                return customerLastName;
            }
            set
            {
                customerLastName = value;
            }
        }

        public string CustomerPhoneNumber
        {
            get
            {
                return customerPhoneNumber;
            }
            set
            {
                customerPhoneNumber = value;
            }
        }

        public int ItemNumber
        {
            get
            {
                return itemNumber;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    itemNumber = value;
                }
            }
        }
        public decimal UnitPrice
        {
            get
            {
                return unitPrice;
            }
            set
            {
                if (value > 0 && value < 9999)
                {
                    unitPrice = value;
                }
            }
        }

        public int QtyPurchased
        {
            get => QtyPurchased = qtyPurchased;
            set
            {
                if (value > 0)
                    qtyPurchased = value;
            }
        }

        public decimal Calculation()
        {
            return qtyPurchased * unitPrice;
        }
    }
}
