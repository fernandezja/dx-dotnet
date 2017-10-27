﻿using MercadoPago.DataStructures.Customer.Card;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MercadoPago.Resources
{
    public class Card : MPBase
    {
        #region Actions

        public static List<Card> LoadAll(String customerId)
        {
            return LoadAll(customerId, WITHOUT_CACHE);
        }
        
        [GETEndpoint("/v1/customers/:customer_id/cards")]
        public static List<Card> LoadAll(String customerId, bool useCache)
        {
            return (List<Card>)ProcessMethodBulk<Card>(typeof(Card), "LoadAll", customerId, useCache);
        }

        public static Card Load(string customerId, string id)
        {
            return Load(customerId, id, WITHOUT_CACHE);
        }

        [GETEndpoint("/v1/customers/:customer_id/cards/:id")]
        public static Card Load(string customerId, string id, bool useCache)
        {            
            return (Card)ProcessMethod<Card>(typeof(Card), "Load", customerId, id, useCache);
        }

        [POSTEndpoint("/v1/customers/:customer_id/cards/")]
        public Card Save()
        {
            return (Card)ProcessMethod<Card>("Save", WITHOUT_CACHE);
        }

        [PUTEndpoint("/v1/customers/:customer_id/cards/:id")]
        public Card Update()
        {
            return (Card)ProcessMethod<Card>("Update", WITHOUT_CACHE);
        }

        [DELETEEndpoint("/v1/customers/:customer_id/cards/:id")]
        public Card Delete()
        {
            return (Card)ProcessMethod("Delete", WITHOUT_CACHE);
        }

        #endregion

        #region Properties

        private string _token;
        private string _id;
        private string _customer_id;
        private int _expiration_month;
        private int _expiration_year;
        private string _first_six_digits;
        private string _last_four_digits;
        private PaymentMethod _payment_method;
        private SecurityCode _security_code;
        private Issuer _issuer;
        private CardHolder _card_holder;
        private DateTime? _date_created;
        private DateTime? _date_last_updated; 

        #endregion

        #region Accessors

        public string Token { get => _token; set => _token = value; }
        public string Id { get => _id; set => _id = value; }
        public string CustomerId { get => _customer_id; set => _customer_id = value; }
        public int ExpirationMonth { get => _expiration_month; set => _expiration_month = value; }
        public int ExpirationYear { get => _expiration_year; set => _expiration_year = value; }
        public string FirstSixDigits { get => _first_six_digits; set => _first_six_digits = value; }
        public string LastFourDigits { get => _last_four_digits; set => _last_four_digits = value; }
        public PaymentMethod PaymentMethod { get => _payment_method; set => _payment_method = value; }
        public SecurityCode SecurityCode { get => _security_code; set => _security_code = value; }
        public Issuer Issuer { get => Issuer; set => _issuer = value; }
        public CardHolder CardHolder { get => _card_holder; set => _card_holder = value; }
        public DateTime? DateCreated { get => _date_created; set => _date_created = value; }
        public DateTime? DateLastUpdated { get => _date_last_updated; set => _date_last_updated = value; }

        #endregion
    }
}
