
using BlabberApp.Domain.Interfaces;

namespace BlabberApp.Domain.Entities
{

    public class Blab : BaseDatum
    {

        private System.DateTime _dttm;

        public System.DateTime DTTM
        {
            get { return this._dttm; }
            set { this._dttm = value; }
        }

        private System.DateTime _lastlogindttm;

        public System.DateTime lastloginDTTM
        {
            get { return this._lastlogindttm; }
            set { this._lastlogindttm = value; }
        }


        private string _message;
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        private string _userId;
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }


        public string getSysId()
        {
            return " ";
        }
    }
}