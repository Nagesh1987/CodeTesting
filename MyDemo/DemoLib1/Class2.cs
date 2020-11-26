using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DemoLib1
{
    public class Class2
    {
        public PayPalPayment Parse(string postData, bool IsIPN)
        {
            PayPalPayment obj = new PayPalPayment();
            try
            {
                char PDTchar = ' ';
                char IPNchar = '&';
                char CurrentChar = IsIPN ? IPNchar : PDTchar;
                String sKey, sValue;
                String[] StringArray = postData.Split(CurrentChar);
                StringArray = StringArray.Where(x => x.Contains("=")).ToArray();
                int i;
                for (i = 0; i < StringArray.Length - 1; i++)
                {
                    String[] StringArray1 = StringArray[i].Split('=');
                    sKey = StringArray1[0];
                    sValue = HttpUtility.UrlDecode(StringArray1[1]);
                    switch (sKey)
                    {
                        case "mc_gross": obj.GrossTotal = String.IsNullOrEmpty(sValue) ? 0 : Convert.ToDouble(sValue); break;
                        //case "item_number1": obj.ParentInvoiceNumber = Convert.ToString(sValue); break;
                        case "invoice": obj.PayPalInternalTransactionId = String.IsNullOrEmpty(sValue) ? Guid.Empty : Guid.Parse(sValue); break;
                        case "custom": obj.Custom = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "payment_status": obj.PaymentStatus = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "first_name": obj.PayerFirstName = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "last_name": obj.PayerLastName = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "mc_fee": obj.PaymentFee = String.IsNullOrEmpty(sValue) ? 0 : Convert.ToDouble(sValue); break;
                        case "payer_email": obj.PayerEmail = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "Tx Token": obj.TxToken = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "business": obj.BusinessEmail = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "receiver_email": obj.ReceiverEmail = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "item_name": obj.ItemName = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "mc_currency": obj.Currency = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "txn_id": obj.TransactionID = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "subsc_id": obj.SubscriberID = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "payer_id": obj.PayerID = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "receiver_id": obj.ReceiverID = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "receipt_id": obj.ReceiptID = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "payment_date": obj.PaymentDate = GetDateByPayPalDateFormat(sValue); break;
                        case "test_ipn": obj.TestIPN = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "payer_status": obj.PayerStatus = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "payment_type": obj.PaymentType = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "pending_reason": obj.Pending_reason = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "reason_code": obj.Reason_code = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "exchange_rate": obj.Exchange_rate = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "echeck_time_processed": obj.Echeck_time_processed = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                        case "parent_txn_id": obj.Parent_txn_id = String.IsNullOrEmpty(sValue) ? String.Empty : Convert.ToString(sValue); break;
                    }
                }
                //var zero = 0;               // to be removed later
                //var res = 10 / zero;        // throws exception, to be removed later
            }
            catch (Exception ex)
            {

            }
            return obj;
        }

        public DateTime GetDateByPayPalDateFormat(string dateStr)
        {
            DateTime outputSGDate;
            try
            {
                // Remove PDT from Date string
                string newDateStr = dateStr.Remove(dateStr.Length - 3);
                DateTime outputPDTDate = Convert.ToDateTime(newDateStr);

                // Convert FROM PDT TO SGT
                var pacificZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");
                var sgZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");
                outputSGDate = TimeZoneInfo.ConvertTime(outputPDTDate, pacificZone, sgZone);
            }
            catch (Exception ex)
            {
                outputSGDate = new DateTime();
            }
            return outputSGDate;
        }
    }
}
