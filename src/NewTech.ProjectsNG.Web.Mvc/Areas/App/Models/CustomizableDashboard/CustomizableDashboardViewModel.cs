﻿using NewTech.ProjectsNG.DashboardCustomization;
using NewTech.ProjectsNG.DashboardCustomization.Dto;

namespace NewTech.ProjectsNG.Web.Areas.App.Models.CustomizableDashboard
{
    public class CustomizableDashboardViewModel
    {
        public DashboardOutput DashboardOutput { get; }

        public Dashboard UserDashboard { get; }

        public CustomizableDashboardViewModel(
            DashboardOutput dashboardOutput,
            Dashboard userDashboard)
        {
            DashboardOutput = dashboardOutput;
            UserDashboard = userDashboard;
        }
    }
}