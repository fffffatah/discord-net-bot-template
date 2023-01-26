﻿using Discord;

namespace Bot.Models
{
    public class Activity : IActivity
    {
        public string? Name { get; set; }

        public ActivityType Type { get; set; }

        public ActivityProperties Flags { get; set; }

        public string? Details { get; set; }
    }
}
