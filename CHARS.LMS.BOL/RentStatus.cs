using System;
using System.Collections.Generic;
using System.Text;

namespace CHARS.LMS.BOL
{
    public class RentStatusInfo
    {
        public RentStatusInfo()
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

        private string mDescription;
        public string Description
        {
            get { return mDescription; }
            set { mDescription = value; }
        }

        private string mRentStatus;
        public string RentStatus
        {
            get { return mRentStatus; }
            set { mRentStatus = value; }
        }


        #endregion

        #region "Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mTS = "0";
            mUD = "0";
            mCode = "";
            mDescription = "";
            mRentStatus = "";
        }
        #endregion



    }
}
