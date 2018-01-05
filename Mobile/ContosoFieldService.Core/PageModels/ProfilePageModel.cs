﻿using System.Collections.ObjectModel;
using FreshMvvm;

namespace ContosoFieldService.PageModels
{
    public class ProfilePageModel : FreshBasePageModel
    {
        public ObservableCollection<Stats> Statistics { get; set; }

        public override void Init(object initData)
        {
            base.Init(initData);

            Statistics = new ObservableCollection<Stats>();

            Statistics.Add(new Stats { Title = "Jobs Completed", Label1 = "August", Label2 = "July", Value1 = "203", Value2 = "434" });
            Statistics.Add(new Stats { Title = "Assigned Jobs", Label1 = "In Progress", Label2 = "Waiting", Value1 = "2", Value2 = "8" });
            Statistics.Add(new Stats { Title = "Order Status", Label1 = "Ready", Label2 = "On Order", Value1 = "2", Value2 = "4" });
            Statistics.Add(new Stats { Title = "Hours Worked", Label1 = "August", Label2 = "July", Value1 = "341", Value2 = "1954" });
            Statistics.Add(new Stats { Title = "Distance Travelled)", Label1 = "August", Label2 = "July", Value1 = "293km", Value2 = "211km" });
            Statistics.Add(new Stats { Title = "Holiday", Label1 = "Remaining", Label2 = "Used", Value1 = "20", Value2 = "4" });

        }
    }

    public class Stats
    {
        public string Title { get; set; }
        public string Value1 { get; set; }
        public string Label1 { get; set; }
        public string Value2 { get; set; }
        public string Label2 { get; set; }
    }
}