using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagement.Website.Models
{
    public class PaymentRequryVewModel
    {

    }
    public class RootResponse {
        public List<PayInstrument> payInstrument { get; set; }
    }
    public class PayInstrument
    {
        public SettlementDetails settlementDetails { get; set; }
        public MerchDetails merchDetails { get; set; }
        public PayDetails payDetails { get; set; }
        public PayModeSpecificData payModeSpecificData { get; set; }
        public ResponseDetails responseDetails { get; set; }
    }
    public class MerchDetails
    {
        public int merchId { get; set; }
        public string password { get; set; }
        public string merchTxnId { get; set; }
        public string merchTxnDate { get; set; }
    }

    public class SettlementDetails
    {
        public string reconStatus { get; set; }
        public DateTime settlementDate { get; set; }
        public double settlementAmount { get; set; }
    }



    public class PayDetails
    {
        public long atomTxnId { get; set; }
        public string product { get; set; }
        public double amount { get; set; }
        public double surchargeAmount { get; set; }
        public double totalAmount { get; set; }
        public string txnStatusCode { get; set; }
    }

    public class PayModeSpecificData
    {
        public string subChannel { get; set; }
        public BankDetails bankDetails { get; set; }
    }

    public class BankDetails
    {
        public string bankTxnId { get; set; }
        public string otsBankName { get; set; }
        public string cardMaskNumber { get; set; }
    }

    public class ResponseDetails
    {
        public string statusCode { get; set; }
        public string message { get; set; }
        public string description { get; set; }
    }
}