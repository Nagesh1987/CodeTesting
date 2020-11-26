using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLib1
{
    public class PayPalPayment
    {
        public string TransactionID { get; set; }
        public string ReceiptID { get; set; }
        public double GrossTotal { get; set; }
        public double Tax { get; set; }
        public string Currency { get; set; }
        public string PaymentStatus { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public string TransactionType { get; set; }
        public string ReceiverID { get; set; }
        public string ReceiverEmail { get; set; }
        public string BusinessEmail { get; set; }
        public string PayerID { get; set; }
        public string PayerEmail { get; set; }
        public string PayerFirstName { get; set; }
        public string PayerLastName { get; set; }
        public string PayerStatus { get; set; }
        public string TestIPN { get; set; }
        public double PaymentFee { get; set; }
        public string TxToken { get; set; }
        public string ItemName { get; set; }
        public string SubscriberID { get; set; }
        public string Custom { get; set; }
        public string Pending_reason { get; set; }
        public string Reason_code { get; set; }
        public string Exchange_rate { get; set; }
        public string Echeck_time_processed { get; set; }
        public string Parent_txn_id { get; set; }

        public Guid PayPalInternalTransactionId { get; set; }
        public bool IsProcessed { get; set; }
    }

    public class user
    {
        public string ID { get; set; }
        public string name { get; set; }
        public DateTime DOB { get; set; }
    }
    public class usercomparer : IComparer<user>
    {
        public int Compare(user x, user y)
        {
            var zz = x.ID.CompareTo(y.ID);
            var ww = x.DOB.CompareTo(y.DOB);
            return zz == ww ? -1 : 0;
        }
    }
}
