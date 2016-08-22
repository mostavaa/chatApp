using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simpleChat
{
    public class myUser : user
    {
        
        public user BaseUser
        {
            get {
                user usr = new user();
                usr.id = this.id;
                usr.username = this.username;
                usr.password = this.password;
                usr.msgs = new HashSet<msg>(this.msgs);
                return usr;
            }
        }
        
        #region ctors
        public myUser()
        {
            this.username = "";
            this.password = "";
            this.id = Guid.NewGuid();
        }
        public myUser(Guid id, string username, string password)
            : this(username, password)
        {
            this.id = id;
        }
        public myUser(string username, string password)
            : this()
        {
            this.username = username;
            this.password = password;
        }
        public myUser(string username, string password, ICollection<msg> msgs)
            : this(username, password)
        {
            this.msgs = msgs;
        }

        //List<Child> lstChild = lstParent.Select(parent => new Child(parent)).ToList();
        public myUser(user parentToCopy):this(parentToCopy.username, parentToCopy.password, new HashSet<msg>(parentToCopy.msgs))
        {
            this.id = parentToCopy.id;   
        }
        
        #endregion

        public myUser Clone()
        {
            myUser newObject = new myUser(this.username, this.password, new HashSet<msg>(this.msgs));
            newObject.id = this.id;
            return newObject;
        }
        public bool Equals(myUser obj)
        {
            return (this.password == obj.password
                && this.username == obj.username
                );
        }

        //implicitly cast
        /*
        public static implicit operator myUser(user usr)
        {
            myUser newUser = new myUser(usr.id , usr.username , usr.password);
            newUser.msgs = new HashSet<msg> (usr.msgs);
            return newUser;
        }
        */

        public static myUser findUserByUserName(string username)
        {
            chatAppEntities1 db = new chatAppEntities1();
            if (db.users.Where(o => o.username == username).Count() > 0)
            {
                return new myUser(db.users.Where(o => o.username == username).First());
            }
            else
            {
                return null;
            }
        }

        public void AddNewOne()
        {
            chatAppEntities1 db = new chatAppEntities1();
            db.users.Add(this.BaseUser);
            db.SaveChanges();
        }
        public static myUser getLoggedUser()
        {
            if (HttpContext.Current.Session["username"] == null)
                return null;
            else
            {
                return myUser.findUserByUserName(HttpContext.Current.Session["username"].ToString());
            }
        }
        public static bool isLogged()
        {
            myUser usr =  myUser.getLoggedUser();
            if (usr == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void login(string username)
        {
            HttpContext.Current.Session["username"]= username;
        }
        /*
        public void login()
        {
            HttpContext.Current.Session["username"] = this.username;

        }*/
        public static void logOut()
        {
            HttpContext.Current.Session["username"] = null;
        }
        /*
        public void logOut()
        {
            HttpContext.Current.Session["username"] = null;
        }*/
    }
}