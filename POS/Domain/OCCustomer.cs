using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POS.Domain
{
    class OCCustomer
    {
        private int customerId;
        private int storeId;
        private string firstName;
        private string lastName;
        private string email;
        private string telephone;
        private string fax;
        private string password;
        private string salt;
        private string cart;
        private string wishList;
        private string newsletter;
        private int addressId;
        private int customerGroupId;
        private string ip;
        private bool status;
        private bool approved;
        private string token;
        private DateTime dateAdded;

        public int CustomerId
        {
            get { return this.customerId; }
            set { this.customerId = value; }
        }

        public int StoreId
        {
            get { return this.storeId; }
            set { this.storeId = value; }
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
    }
}
