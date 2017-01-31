using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class RentDetailInfo
    {
        public RentDetailInfo()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mTS;
        private string mUD;
        #endregion

        #region "public member"
        public string Ask
        {
            get { return mAsk; }
            set { mAsk = value; }
        }
        public string TS
        {
            get { return mTS; }
            set { mTS = value; }
        }
        public string UD
        {
            get { return mUD; }
            set { mUD = value; }
        }

     

        private string mBookSyskey;
        public string BookID
        {
            get { return mBookSyskey; }
            set { mBookSyskey = value; }
        }
   

        private string mRentDate;
        public string RentDate
        {
            get { return mRentDate; }
            set { mRentDate = value; }
        }

     
        private string mExpireDate;
        public string ExpireDate
        {
            get { return mExpireDate; }
            set { mExpireDate = value; }
        }

        private string mRentStatus;
        public string RentStatus
        {
            get { return mRentStatus; }
            set { mRentStatus = value; }
        }

        private string mReturnDate;
        public string ReturnDate
        {
            get { return mReturnDate; }
            set { mReturnDate = value; }
        }


        private string mOverDueDate;
        public string OverDueDate
        {
            get { return mOverDueDate; }
            set { mOverDueDate = value; }
        }

       


        #endregion

        #region "Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mBookSyskey = "0";
           
            mRentDate = "";
            mExpireDate = "";
            mRentStatus = "0";
            mReturnDate = "0";
            mOverDueDate = "";
        }
        #endregion



    }
}
