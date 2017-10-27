﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace MercadoPago.DataStructures.Preference
{
    public struct Payer
    {
        #region Properties 
        [StringLength(256)]
        private string _name;
        [StringLength(256)]
        private string _surname;
        [StringLength(256)]
        private string _email;
        private Phone? _phone;
        private Identification? _identification;
        private Address? _address;
        private DateTime? _date_created; 
        #endregion

        #region Accessors
        /// <summary>
        /// Buyer name
        /// </summary>
        public string Name {
            get => _name; 
            set => _name = value;
        }
        /// <summary>
        /// Buyer last name
        /// </summary>
        public string Surname {
            get => _surname; 
            set => _surname = value;
        }
        /// <summary>
        /// Buyer e-mail address
        /// </summary>
        public string Email {
            get => _email; 
            set => _email = value;
        }
        /// <summary>
        /// Buyer phone
        /// </summary>
        public Phone? Phone { 
            get => _phone; 
            set => _phone = value; 
        }
        /// <summary>
        /// Personal identification
        /// </summary>
        public Identification? Identification 
        { 
            get => _identification; 
            set => _identification = value; 
        }
        /// <summary>
        /// Buyer address
        /// </summary>
        public Address? Address
        {
            get => _address;
            set => _address = value;
        }
        /// <summary>
        /// Registration date
        /// </summary>
        public DateTime? Date_created 
        { 
            get => _date_created;
            set => _date_created = value;
        } 
        #endregion
    }
}
