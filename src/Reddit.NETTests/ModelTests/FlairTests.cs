﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reddit.NET;
using Reddit.NET.Models.Structures;
using System;
using System.Collections.Generic;

namespace Reddit.NETTests.ModelTests
{
    [TestClass]
    public class FlairTests : BaseTests
    {
        public FlairTests() : base() { }

        [TestMethod]
        public void UserFlair()
        {
            List<Flair> flairs = reddit.Models.Flair.UserFlair(testData["Subreddit"]);

            Assert.IsNotNull(flairs);
        }

        [TestMethod]
        public void UserFlairV2()
        {
            List<FlairV2> flairs = reddit.Models.Flair.UserFlairV2(testData["Subreddit"]);

            Assert.IsNotNull(flairs);
        }

        [TestMethod]
        public void ClearFlairTemplates()
        {
            GenericContainer res1 = reddit.Models.Flair.ClearFlairTemplates("LINK_FLAIR", testData["Subreddit"]);
            GenericContainer res2 = reddit.Models.Flair.ClearFlairTemplates("USER_FLAIR", testData["Subreddit"]);

            Validate(res1);
            Validate(res2);
        }

        [TestMethod]
        public void DeleteFlair()
        {
            GenericContainer res = reddit.Models.Flair.DeleteFlair("KrisCraig", testData["Subreddit"]);

            Validate(res);
        }

        [TestMethod]
        public void Create()
        {
            GenericContainer res = reddit.Models.Flair.Create("", "", "KrisCraig", "Test User Flair", testData["Subreddit"]);

            Validate(res);
        }

        [TestMethod]
        public void FlairConfig()
        {
            GenericContainer res = reddit.Models.Flair.FlairConfig(true, "right", true, "right", true, testData["Subreddit"]);

            Validate(res);
        }

        [TestMethod]
        public void FlairCSV()
        {
            List<ActionResult> res = reddit.Models.Flair.FlairCSV("KrisCraig,Human," + Environment.NewLine + "RedditDotNetBot,Robot,", testData["Subreddit"]);

            Assert.IsNotNull(res);
            Assert.IsTrue(res.Count == 2);
            foreach (ActionResult actionResult in res)
            {
                Assert.IsTrue(actionResult.Ok);
            }
        }

        [TestMethod]
        public void FlairList()
        {
            FlairListResultContainer res = reddit.Models.Flair.FlairList("", "", "", testData["Subreddit"]);

            Assert.IsNotNull(res);
        }

        [TestMethod]
        public void FlairSelector()
        {
            FlairSelectorResultContainer res = reddit.Models.Flair.FlairSelector(null, testData["Subreddit"]);
            FlairSelectorResultContainer resUser = reddit.Models.Flair.FlairSelector("KrisCraig", testData["Subreddit"]);
            FlairSelectorResultContainer resLink = reddit.Models.Flair.FlairSelector(null, "RedditDotNETBot", "t3_9rirb3");

            Assert.IsNotNull(res);
            Assert.IsNotNull(resUser);
            Assert.IsNotNull(resLink);
        }

        [TestMethod]
        public void LinkFlair()
        {
            List<Flair> flairs = reddit.Models.Flair.LinkFlair(testData["Subreddit"]);

            Assert.IsNotNull(flairs);
        }

        [TestMethod]
        public void LinkFlairV2()
        {
            List<FlairV2> flairs = reddit.Models.Flair.LinkFlairV2(testData["Subreddit"]);

            Assert.IsNotNull(flairs);
        }

        [TestMethod]
        public void SetFlairEnabled()
        {
            GenericContainer res = reddit.Models.Flair.SetFlairEnabled(true, testData["Subreddit"]);

            Validate(res);
        }

        [TestMethod]
        public void FlairTemplate()
        {
            GenericContainer resLink = reddit.Models.Flair.FlairTemplate("", "", "LINK_FLAIR", DateTime.Now.ToString("fffffff"), false, testData["Subreddit"]);
            GenericContainer resUser = reddit.Models.Flair.FlairTemplate("", "", "USER_FLAIR", DateTime.Now.ToString("fffffff"), false, testData["Subreddit"]);

            Validate(resLink);
            Validate(resUser);
        }

        [TestMethod]
        public void CreateAndDeleteFlairTemplate()
        {
            FlairV2 linkFlair = reddit.Models.Flair.FlairTemplateV2("#88AAFF", "", "LINK_FLAIR", false,
                    "V2-" + DateTime.Now.ToString("fffffff"), "dark", false, testData["Subreddit"]);
            FlairV2 userFlair = reddit.Models.Flair.FlairTemplateV2("#88AAFF", "", "USER_FLAIR", false,
                    "V2-" + DateTime.Now.ToString("fffffff"), "dark", false, testData["Subreddit"]);

            Assert.IsNotNull(linkFlair);
            Assert.IsNotNull(userFlair);

            GenericContainer resLink = reddit.Models.Flair.DeleteFlairTemplate(linkFlair.Id, testData["Subreddit"]);
            GenericContainer resUser = reddit.Models.Flair.DeleteFlairTemplate(userFlair.Id, testData["Subreddit"]);

            Validate(resLink);
            Validate(resUser);
        }
    }
}
