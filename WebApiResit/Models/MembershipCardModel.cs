using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApiResit.Models
{
    public class MembershipCardModel
    {


        public int ID
        {
            get;
            set;
        }



        public string MembershipCardCode
        {
            get;
            set;
        }
        public string EnterpriseAccNo
        {
            get;
            set;
        }


        public string MembershipCardFee
        {
            get;
            set;
        }


        public string MembershipCardType
        {
            get;
            set;
        }
        public string RowStatus
        {
            get;
            set;
        }




        public string ExpiredDate
        {
            get;
            set;
        }

        public string MembershipCardBackgroundImg
        {
            get;
            set;
        }


        public string CreatedDate
        {
            get;
            set;
        }




        public string CreatedBy
        {
            get;
            set;
        }





        public string StartDate
        {
            get;
            set;
        }


        public string MembershipCardName
        {
            get;
            set;
        }

        public string MembershipCardFeePaymentCycle
        {
            get;
            set;
        }

        public string StrExpiredDate
        {
            get;
            set;
        }

        public string isValidLifeTime
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }

      public string ModifiedDate
        {
            get;
            set;
        }


      public MembershipCardModel() { }

        //test






    }
}