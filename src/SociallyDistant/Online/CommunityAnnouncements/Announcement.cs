﻿using System;

namespace SociallyDistant.Online.CommunityAnnouncements
{
    public class Announcement
    {
        public string Title { get; }
        public string Link { get; }
        public string Excerpt { get; }
        public DateTime Date { get; }
        
        public Announcement(AnnouncementObject json)
        {
            Title = json.Title;
            Link = json.Link;
            Excerpt = json.Content;

            Date = json.Created;
        }
    }
}