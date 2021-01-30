﻿using System.Collections.Generic;
using NewTech.ProjectsNG.Editions.Dto;
using NewTech.ProjectsNG.MultiTenancy.Payments;

namespace NewTech.ProjectsNG.Web.Models.Payment
{
    public class UpgradeEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public PaymentPeriodType PaymentPeriodType { get; set; }

        public SubscriptionPaymentType SubscriptionPaymentType { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}