﻿using System.CodeDom;

namespace Sdl.Web.Tridion.Templates.Tests
{
    internal static class TestFixture
    {
        internal const string ExampleSiteWebDavUrl = "/webdav/400 Example Site";
        internal const string AutoTestParentWebDavUrl = "/webdav/401 Automated Test Parent";

        internal const string ExampleSiteHomePageWebDavUrl = ExampleSiteWebDavUrl + "/Home/000 Home.tpg";
        internal const string ArticleDcpPageWebDavUrl = AutoTestParentWebDavUrl + "/Home/Test Article (Dynamic) Page.tpg";
        internal const string MediaManagerPageWebDavUrl = AutoTestParentWebDavUrl + "/Home/Regression/MediaManager.tpg";
        internal const string FlickrTestPageWebDavUrl = AutoTestParentWebDavUrl + "/Home/Regression/Flickr Test.tpg";
        internal const string SmartTargetPageWebDavUrl = AutoTestParentWebDavUrl + "/Home/Smoke/Smart Target Smoke Test.tpg";
        internal const string Tsi811PageWebDavUrl = AutoTestParentWebDavUrl + "/Home/Regression/TSI-811 Test Page.tpg";
        internal const string Tsi1758PageWebDavUrl = AutoTestParentWebDavUrl + "/Home/Regression/TSI-1758 Test Page.tpg";
        internal const string Tsi1946PageWebDavUrl = AutoTestParentWebDavUrl + "/Home/Regression/TSI-1946 Test Page.tpg";

        internal const string ArticleDcpId = "tcm:1065-9712/tcm:1065-9711-32";

    }
}