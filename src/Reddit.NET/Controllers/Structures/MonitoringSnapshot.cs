﻿using Reddit.NET.Exceptions;
using System;
using System.Collections.Generic;

namespace Reddit.NET.Controllers.Structures
{
    public class MonitoringSnapshot
    {
        public List<string> BestPosts;
        public List<string> HotPosts;
        public List<string> NewPosts;
        public List<string> RisingPosts;
        public List<string> TopPosts;
        public List<string> ControversialPosts;
        public List<string> ModQueuePosts;
        public List<string> ModQueueReportsPosts;
        public List<string> ModQueueSpamPosts;
        public List<string> ModQueueUnmoderatedPosts;
        public List<string> ModQueueEditedPosts;
        public List<string> PrivateMessagesInbox;
        public List<string> PrivateMessagesUnread;
        public List<string> PrivateMessagesSent;

        public MonitoringSnapshot(List<string> bestPosts = null, List<string> hotPosts = null, List<string> newPosts = null, List<string> risingPosts = null, 
            List<string> topPosts = null, List<string> controversialPosts = null, List<string> modQueuePosts = null, List<string> modQueueReportsPosts = null, 
            List<string> modQueueSpamPosts = null, List<string> modQueueUnmoderatedPosts = null, List<string> modQueueEditedPosts = null, 
            List<string> privateMessagesInbox = null, List<string> privateMessagesUnread = null, List<string> privateMessagesSent = null)
        {
            BestPosts = (bestPosts ?? new List<string>());
            HotPosts = (hotPosts ?? new List<string>());
            NewPosts = (newPosts ?? new List<string>());
            RisingPosts = (risingPosts ?? new List<string>());
            TopPosts = (topPosts ?? new List<string>());
            ControversialPosts = (controversialPosts ?? new List<string>());
            ModQueuePosts = (modQueuePosts ?? new List<string>());
            ModQueueReportsPosts = (modQueueReportsPosts ?? new List<string>());
            ModQueueSpamPosts = (modQueueSpamPosts ?? new List<string>());
            ModQueueUnmoderatedPosts = (modQueueUnmoderatedPosts ?? new List<string>());
            ModQueueEditedPosts = (modQueueEditedPosts ?? new List<string>());
            PrivateMessagesInbox = (privateMessagesInbox ?? new List<string>());
            PrivateMessagesUnread = (privateMessagesUnread ?? new List<string>());
            PrivateMessagesSent = (privateMessagesSent ?? new List<string>());
        }

        public ref List<string> Get(string key)
        {
            switch (key)
            {
                default:
                    throw new RedditControllerException("Unrecognized key.");
                case "BestPosts":
                    return ref BestPosts;
                case "HotPosts":
                    return ref HotPosts;
                case "NewPosts":
                    return ref NewPosts;
                case "RisingPosts":
                    return ref RisingPosts;
                case "TopPosts":
                    return ref TopPosts;
                case "ControversialPosts":
                    return ref ControversialPosts;
                case "ModQueuePosts":
                    return ref ModQueuePosts;
                case "ModQueueReportsPosts":
                    return ref ModQueueReportsPosts;
                case "ModQueueSpamPosts":
                    return ref ModQueueSpamPosts;
                case "ModQueueUnmoderatedPosts":
                    return ref ModQueueUnmoderatedPosts;
                case "ModQueueEditedPosts":
                    return ref ModQueueEditedPosts;
                case "PrivateMessagesInbox":
                    return ref PrivateMessagesInbox;
                case "PrivateMessagesUnread":
                    return ref PrivateMessagesUnread;
                case "PrivateMessagesSent":
                    return ref PrivateMessagesSent;
            }
        }

        public void Add(MonitoringSnapshot monitoringSnapshot)
        {
            if (monitoringSnapshot != null)
            {
                Add(monitoringSnapshot.BestPosts, ref BestPosts);
                Add(monitoringSnapshot.HotPosts, ref HotPosts);
                Add(monitoringSnapshot.NewPosts, ref NewPosts);
                Add(monitoringSnapshot.RisingPosts, ref RisingPosts);
                Add(monitoringSnapshot.TopPosts, ref TopPosts);
                Add(monitoringSnapshot.ControversialPosts, ref ControversialPosts);
                Add(monitoringSnapshot.ModQueuePosts, ref ModQueuePosts);
                Add(monitoringSnapshot.ModQueueReportsPosts, ref ModQueueReportsPosts);
                Add(monitoringSnapshot.ModQueueSpamPosts, ref ModQueueSpamPosts);
                Add(monitoringSnapshot.ModQueueUnmoderatedPosts, ref ModQueueUnmoderatedPosts);
                Add(monitoringSnapshot.ModQueueEditedPosts, ref ModQueueEditedPosts);
                Add(monitoringSnapshot.PrivateMessagesInbox, ref PrivateMessagesInbox);
                Add(monitoringSnapshot.PrivateMessagesUnread, ref PrivateMessagesUnread);
                Add(monitoringSnapshot.PrivateMessagesSent, ref PrivateMessagesSent);
            }
        }

        private void Add(List<string> addList, ref List<string> dest)
        {
            foreach (string item in addList)
            {
                if (!dest.Contains(item))
                {
                    dest.Add(item);
                }
            }
        }

        public void Remove(MonitoringSnapshot monitoringSnapshot)
        {
            if (monitoringSnapshot != null)
            {
                Remove(monitoringSnapshot.BestPosts, ref BestPosts);
                Remove(monitoringSnapshot.HotPosts, ref HotPosts);
                Remove(monitoringSnapshot.NewPosts, ref NewPosts);
                Remove(monitoringSnapshot.RisingPosts, ref RisingPosts);
                Remove(monitoringSnapshot.TopPosts, ref TopPosts);
                Remove(monitoringSnapshot.ControversialPosts, ref ControversialPosts);
                Remove(monitoringSnapshot.ModQueuePosts, ref ModQueuePosts);
                Remove(monitoringSnapshot.ModQueueReportsPosts, ref ModQueueReportsPosts);
                Remove(monitoringSnapshot.ModQueueSpamPosts, ref ModQueueSpamPosts);
                Remove(monitoringSnapshot.ModQueueUnmoderatedPosts, ref ModQueueUnmoderatedPosts);
                Remove(monitoringSnapshot.ModQueueEditedPosts, ref ModQueueEditedPosts);
                Remove(monitoringSnapshot.PrivateMessagesInbox, ref PrivateMessagesInbox);
                Remove(monitoringSnapshot.PrivateMessagesUnread, ref PrivateMessagesUnread);
                Remove(monitoringSnapshot.PrivateMessagesSent, ref PrivateMessagesSent);
            }
        }

        private void Remove(List<string> removeList, ref List<string> dest)
        {
            foreach (string item in removeList)
            {
                if (dest.Contains(item))
                {
                    dest.Remove(item);
                }
            }
        }

        public int Count()
        {
            return (BestPosts.Count
                + HotPosts.Count
                + NewPosts.Count
                + RisingPosts.Count
                + ControversialPosts.Count
                + ModQueuePosts.Count
                + ModQueueReportsPosts.Count
                + ModQueueSpamPosts.Count
                + ModQueueUnmoderatedPosts.Count
                + ModQueueEditedPosts.Count
                + PrivateMessagesInbox.Count
                + PrivateMessagesUnread.Count
                + PrivateMessagesSent.Count);
        }
    }
}
