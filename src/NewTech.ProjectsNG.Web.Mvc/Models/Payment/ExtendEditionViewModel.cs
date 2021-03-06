﻿using System.Collections.Generic;
using NewTech.ProjectsNG.Editions.Dto;
using NewTech.ProjectsNG.MultiTenancy.Payments;

namespace NewTech.ProjectsNG.Web.Models.Payment
{
    public class ExtendEditionViewModel
    {
        public EditionSelectDto Edition { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}