using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class RentHeaderInfo //add by bba ddd  2/1/2017
    {
        public RentHeaderInfo()
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

        private string mCode;
        public string Code
        {
            get { return mCode; }
            set { mCode = value; }
        }

      

        private string mMemberSyskey;
        public string MemberID
        {
            get { return mMemberSyskey; }
            set { mMemberSyskey = value; }
        }


        private string mRentDate;
        public string RentDate
        {
            get { return mRentDate; }
            set { mRentDate = value; }
        }

        private string mRemark;
        public string Remark
        {
            get { return mRemark; }
            set { mRemark = value; }
        }
        


        #endregion

        #region "Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mCode = "";
            mMemberSyskey = "0";     
            mRentDate = "";
            mRemark = "";
        }
        #endregion


      
   }
}
