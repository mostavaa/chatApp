using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleChat
{
    public class myMsg :msg  

    {
        /*
        public msg BaseMsg
        {
            get { return this.Clone() ; }
        }
        */
        #region ctors
        public myMsg()
        {
            this.textMsg = "";
            this.userId = Guid.Empty;
            this.msgDate = DateTime.Now;
            this.toId = null;
            this.user = new user();
        }
        public myMsg(string txtMsg , Guid userId):this()
        {
            this.textMsg = txtMsg;
            this.userId = userId;
            this.msgDate = DateTime.Now;
        }
        public myMsg(string txtMsg, Guid userId , DateTime msgDate):this(txtMsg,userId)
        {
            this.msgDate = msgDate;
        }
        public myMsg(string txtMsg, Guid userId , Guid toId):this(txtMsg , userId)
        {
            this.toId = toId;
        }
        public myMsg(string txtMsg, Guid userId, DateTime msgDate , Guid? toId):this(txtMsg , userId , msgDate)
        {
            this.toId = toId;
        }
        public myMsg(string txtMsg, Guid userId, DateTime msgDate, Guid? toId , user usr)
            :this(txtMsg , userId, msgDate , toId)
        {
            this.user = usr;
        }
        #endregion
        /*
        public static explicit operator myMsg(msg msg)
        {

            myMsg newObject = new myMsg(msg.textMsg, msg.userId, msg.msgDate, msg.toId);

            newObject.user = new user();
            newObject.user.id = msg.user.id;
            newObject.user.password = msg.user.password;
            newObject.user.msgs = new HashSet<msg>(msg.user.msgs);


            newObject.id = msg.id;

            return newObject;
        }
        */
        public myMsg Clone()
        {

            myMsg newObject = new myMsg(this.textMsg, this.userId, this.msgDate, this.toId);

            newObject.user = new user();
            newObject.user.id = this.user.id;
            newObject.user.password = this.user.password;
            newObject.user.msgs = new HashSet<msg>(this.user.msgs);


            newObject.id = this.id;
            return newObject;
        }
        public  bool Equals(myMsg obj)
        {
            return (this.textMsg == obj.textMsg
                && this.toId== obj.toId
                && obj.msgDate == this.msgDate
                && obj.userId==this.userId
                );
        }
    }
}