﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Crm.CEP.Customers
{
    public class CustomerDto : AuditedEntityDto<long>
    {
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }


       // [DataType(DataType.Date)]
        public string DOB { get; set; }

        public string Gender { get; set; }

        public string Nationality { get; set; }

        public string MaritalStatus { get; set; }

        public string LoyaltyId { get; set; }

        public string LoyaltyStatus { get; set; }

        //[DataType(DataType.Date)]
        public string LoyaltyExpiryDate { get; set; }

        public string MembershipStatus { get; set; }

       // [DataType(DataType.Date)]
        public string? JoiningDate { get; set; }

        public string PhoneNo { get; set; }

        public string EmailId { get; set; }
    }
}
