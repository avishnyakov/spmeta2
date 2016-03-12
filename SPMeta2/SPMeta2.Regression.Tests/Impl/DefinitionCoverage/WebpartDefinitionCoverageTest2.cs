﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using SPMeta2.BuiltInDefinitions;
using SPMeta2.Containers;
using SPMeta2.Containers.Standard;
using SPMeta2.Definitions;
using SPMeta2.Definitions.Base;
using SPMeta2.Definitions.Webparts;
using SPMeta2.Regression.Tests.Impl.Scenarios.Base;
using SPMeta2.Standard.Services.Webparts;
using SPMeta2.Syntax.Default;
using SPMeta2.Standard.Definitions.Webparts;
using SPMeta2.Enumerations;
using SPMeta2.Regression.Definitions;
using SPMeta2.Standard.Definitions;
using SPMeta2.Standard.Enumerations;
using SPMeta2.Containers.Extensions;
using SPMeta2.Containers.Services;
using SPMeta2.Extensions;
using SPMeta2.Models;
using SPMeta2.Regression.Definitions.Extended;
using SPMeta2.Attributes.Regression;

namespace SPMeta2.Regression.Tests.Impl.DefinitionCoverage
{
    [TestClass]
    public class WebpartDefinitionCoverageTest : SPMeta2RegresionScenarioTestBase
    {
        #region internal

        [ClassInitializeAttribute]
        public static void Init(TestContext context)
        {
            InternalInit();
        }

        [ClassCleanupAttribute]
        public static void Cleanup()
        {
            InternalCleanup();
        }

        #endregion

		#region internal

		public static bool UseWikiPages = true;
		public static bool UseWebPartPages = true;
		public static bool UsePublishingPages = true;

		public static bool UseListPages = true;
		public static bool UseLibraryPages = true;

		public static bool UseSubWebs = true;

		#endregion

        #region pre-generated tests
 
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_WebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<WebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_BlogAdminWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<BlogAdminWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_BlogLinksWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<BlogLinksWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_BlogMonthQuickLaunchDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<BlogMonthQuickLaunchDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_DataFormWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<DataFormWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_GettingStartedWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<GettingStartedWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ImageWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ImageWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_MembersWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<MembersWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_PageViewerWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<PageViewerWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_PictureLibrarySlideshowWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<PictureLibrarySlideshowWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SilverlightWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SilverlightWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SimpleFormWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SimpleFormWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SPTimelineWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SPTimelineWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_UserCodeWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<UserCodeWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_UserDocsWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<UserDocsWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_UserTasksWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<UserTasksWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_XmlWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<XmlWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ClientWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ClientWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ScriptEditorWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ScriptEditorWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ContentEditorWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ContentEditorWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ListViewWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ListViewWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_XsltListViewWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<XsltListViewWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_CategoryWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<CategoryWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_CommunityAdminWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<CommunityAdminWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_CommunityJoinWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<CommunityJoinWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_DocumentSetContentsWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<DocumentSetContentsWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_DocumentSetPropertiesWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<DocumentSetPropertiesWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_MyMembershipWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<MyMembershipWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ProjectSummaryWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ProjectSummaryWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_RefinementScriptWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<RefinementScriptWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_RSSAggregatorWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<RSSAggregatorWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SearchBoxScriptWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SearchBoxScriptWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SearchNavigationWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SearchNavigationWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SiteDocumentsDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SiteDocumentsDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SocialCommentWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SocialCommentWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_TableOfContentsWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<TableOfContentsWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_TagCloudWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<TagCloudWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ContactFieldControlDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ContactFieldControlDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ContentBySearchWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ContentBySearchWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ContentByQueryWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ContentByQueryWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_ResultScriptWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<ResultScriptWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SiteFeedWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SiteFeedWebPartDefinition>();
        }
		
		[TestMethod]
        [TestCategory("Regression.DefinitionCoverage.WebpartDefinitions")]
		[SiteCollectionIsolation]
        public void CanDeploy_SummaryLinkWebPartDefinition_To_AllPageTypes() 
        {
            DeployWebpartOnSupportedHosts<SummaryLinkWebPartDefinition>();
        }
		       
	    #endregion

    #region utils

        private void DeployWebpartOnSupportedHosts<TWebpartType>()
            where TWebpartType : WebPartDefinitionBase, new()
        {
            var siteModel = SPMeta2Model.NewSiteModel(site =>
            {
                site.AddSiteFeature(BuiltInSiteFeatures.SharePointServerPublishingInfrastructure.Inherit(def =>
                {
                    def.Enable = true;
					def.ForceActivate = true;
                }));

                site.AddSiteFeature(BuiltInSiteFeatures.EnableAppSideLoading.Inherit(def =>
                {
                    def.Enable = true;
					def.ForceActivate = true;
                }));
            });

            var model = SPMeta2Model.NewWebModel(web =>
            {
				web.AddWebFeature(BuiltInWebFeatures.SharePointServerPublishing.Inherit(def =>
                {
                    def.Enable = true;
					def.ForceActivate = true;
                }));

				web.AddWebFeature(BuiltInWebFeatures.WikiPageHomePage.Inherit(def =>
                {
                    def.Enable = true;
					def.ForceActivate = true;
                }));

                // always deploy to root web 
                FillWebWithTheTestwebPartSuite<TWebpartType>(web);

				if(UseSubWebs) {
					// and then sub web too
					web.AddRandomWeb(subWeb =>
					{
						subWeb.AddWebFeature(BuiltInWebFeatures.SharePointServerPublishing.Inherit(def =>
						{
							def.Enable = true;
							def.ForceActivate = true;
						}));

						subWeb.AddWebFeature(BuiltInWebFeatures.WikiPageHomePage.Inherit(def =>
						{
							def.Enable = true;
							def.ForceActivate = true;
						}));

						FillWebWithTheTestwebPartSuite<TWebpartType>(subWeb);
					});
				}
            });

            WithDisabledPropertyUpdateValidation(() =>
            {
                TestModel(siteModel, model);
            });
        }

        protected bool ShoudValidatePresenceOnListViews(WebPartDefinitionBase webPartDefinition)
        {
            var result = true;

            // Investigate 'ListViewWebPartDefinition' provision specifics on list views #646
            // https://github.com/SubPointSolutions/spmeta2/issues/646
            if (webPartDefinition is ListViewWebPartDefinition)
            {
                result = false;
            }

            return result;
        }

        protected bool ShoudValidatePresenceOnLibraryViews(WebPartDefinitionBase webPartDefinition)
        {
            var result = true;

            // Investigate 'ListViewWebPartDefinition' provision specifics on list views #646
            // https://github.com/SubPointSolutions/spmeta2/issues/646
            if (webPartDefinition is ListViewWebPartDefinition)
            {
                result = false;
            }

            return result;
        }

        protected virtual void FillWebWithTheTestwebPartSuite<TWebpartType>(WebModelNode currentWeb)
            where TWebpartType : WebPartDefinitionBase, new()
        {
            var initialDef = ModelGeneratorService.GetRandomDefinition(typeof(TWebpartType)) as TWebpartType;

            var wikiWebPartDef = initialDef.Clone<TWebpartType>();
            var webpartPageWebPartDef = initialDef.Clone<TWebpartType>();
			var publishingPageWebPartDef = initialDef.Clone<TWebpartType>();

			// Some web part provision on wiki page give empty markup #693
			// https://github.com/SubPointSolutions/spmeta2/issues/693
			var webpartPageWebPartAddToPageContentDef1 = initialDef.Clone<TWebpartType>();

			webpartPageWebPartAddToPageContentDef1.Title = Rnd.String();
			webpartPageWebPartAddToPageContentDef1.Id = "g_" + Guid.NewGuid().ToString("D").Replace('-', '_');
			webpartPageWebPartAddToPageContentDef1.ZoneId = "wpz";
			webpartPageWebPartAddToPageContentDef1.AddToPageContent = true;

			var webpartPageWebPartAddToPageContentDef2 = initialDef.Clone<TWebpartType>();

			webpartPageWebPartAddToPageContentDef2.Title = Rnd.String();
			webpartPageWebPartAddToPageContentDef2.Id = "g_" + Guid.NewGuid().ToString("D").Replace('-', '_');
			webpartPageWebPartAddToPageContentDef2.ZoneId = "wpz";
			webpartPageWebPartAddToPageContentDef2.AddToPageContent = true;

            var listWebPartDef = initialDef.Clone<TWebpartType>();
            var docWebPartDef = initialDef.Clone<TWebpartType>();

            // ensure for the client web part
            currentWeb.AddRandomApp();

            currentWeb
                /// for the Pages lib & pubnlishing pages
                .AddWebFeature(BuiltInWebFeatures.SharePointServerPublishing.Inherit(def =>
                {
                    def.Enable = true;
					def.ForceActivate = true;
                }))

                .AddHostList(BuiltInListDefinitions.SitePages, list =>
                {
                    var webpartPageName = string.Empty;
                    var wikiPageName = string.Empty;
					var wikiPageNameAddToPageContent = string.Empty;

					if(UseWikiPages) {
						list
							// 1 - wiki pages
							.AddRandomWikiPage(page =>
							{
								wikiPageName = (page.Value as WikiPageDefinition).FileName;
								page.AddDefinitionNode(wikiWebPartDef);
							});

						ValidateWebPartPresenceForPage(list, wikiPageName, wikiWebPartDef);
					}

					if(UseWebPartPages) {
						list
							// 2- web part pages
							.AddRandomWebPartPage(page =>
							{
								webpartPageName = (page.Value as WebPartPageDefinition).FileName;
								page.AddDefinitionNode(webpartPageWebPartDef);
							});

						ValidateWebPartPresenceForPage(list, webpartPageName, webpartPageWebPartDef);
					}

					if(UseWikiPages) {
						list
							/// 3- adding to the web part page as .AddToPageContent
							.AddRandomWikiPage(page =>
							{
								page.RegExcludeFromValidation();

								wikiPageNameAddToPageContent = (page.Value as WikiPageDefinition).FileName;
                            
								page.AddDefinitionNode(webpartPageWebPartAddToPageContentDef1);
								page.AddDefinitionNode(webpartPageWebPartAddToPageContentDef2);
							});

						ValidateWebPartPresenceForPage(list, wikiPageNameAddToPageContent, webpartPageWebPartAddToPageContentDef1);
						ValidateWebPartPresenceForPage(list, wikiPageNameAddToPageContent, webpartPageWebPartAddToPageContentDef2);
					}
                });

	            // 3 - publishing pages
               currentWeb.AddHostList(BuiltInListDefinitions.Pages, list =>
                {
                    var publishingPageName = string.Empty;

					if(UsePublishingPages) {			
					
						list
							.AddRandomPublishingPage(page =>
							{
								(page.Value as PublishingPageDefinition).PageLayoutFileName =
									BuiltInPublishingPageLayoutNames.BlankWebPartPage;
								publishingPageName = (page.Value as PublishingPageDefinition).FileName;

								page.AddDefinitionNode(publishingPageWebPartDef);
							});

						ValidateWebPartPresenceForPage(list, publishingPageName, publishingPageWebPartDef);
					}
                });

				if(UseListPages) {
					// 4 - list related routines - OOTB views, custom views & forms
					currentWeb.AddRandomList(list =>
					{
						// OOTB view
						list.AddHostListView(BuiltInListViewDefinitions.Lists.AllItems, listView =>
						{
							listView.AddDefinitionNode(listWebPartDef.Inherit());
						});

						if (ShoudValidatePresenceOnListViews(initialDef))
							ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.AllItems.Url, listWebPartDef);

						// custom view
						var customView = ModelGeneratorService.GetRandomDefinition<ListViewDefinition>(def =>
						{
							def.Url = Rnd.AspxFileName();
						});

						list.AddListView(customView, listView =>
						{
							listView.AddDefinitionNode(listWebPartDef.Inherit());
						});

						if (ShoudValidatePresenceOnListViews(initialDef))
							ValidateWebPartPresenceForPage(list, customView.Url, listWebPartDef);

						// OOTB forms, new - edit - view
						list.AddHostListView(BuiltInListViewDefinitions.Lists.NewForm, listView =>
						{
							listView.AddDefinitionNode(listWebPartDef.Inherit());
						});

						ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.NewForm.Url, listWebPartDef);

						list.AddHostListView(BuiltInListViewDefinitions.Lists.EditForm, listView =>
						{
							listView.AddDefinitionNode(listWebPartDef.Inherit());
						});


						ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.EditForm.Url, listWebPartDef);

						list.AddHostListView(BuiltInListViewDefinitions.Lists.DispForm, listView =>
						{
							listView.AddDefinitionNode(listWebPartDef.Inherit());
						});


						ValidateWebPartPresenceForPage(list, BuiltInListViewDefinitions.Lists.DispForm.Url, listWebPartDef);
					});
				}

				if(UseLibraryPages) {
					// 5 - OOTB list view form on the library
					currentWeb.AddRandomDocumentLibrary(list =>
					{
						// OOTB view

						list.AddHostListView(BuiltInListViewDefinitions.Libraries.AllItems, listView =>
						{
							listView.AddDefinitionNode(docWebPartDef.Inherit());
						});

						if (ShoudValidatePresenceOnLibraryViews(initialDef))
							ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.AllItems.Url, docWebPartDef);

						// custom view
						var customView = ModelGeneratorService.GetRandomDefinition<ListViewDefinition>(def =>
						{
							def.Url = Rnd.AspxFileName();
						});

						list.AddListView(customView, listView =>
						{
							listView.AddDefinitionNode(docWebPartDef.Inherit());
						});

						if (ShoudValidatePresenceOnLibraryViews(initialDef))
							ValidateWebPartPresenceForPage(list, "Forms/" + customView.Url, docWebPartDef);

						// OOTB new - edit - view forms
						// upload, NOPE!
						//list.AddHostListView(BuiltInListViewDefinitions.Libraries.Upload, listView =>
						//{
						//    listView.AddDefinitionNode(docWebPartDef.Inherit());
						//});

						//ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.Upload.Url, docWebPartDef);

						list.AddHostListView(BuiltInListViewDefinitions.Libraries.EditForm, listView =>
						{
							listView.AddDefinitionNode(docWebPartDef.Inherit());
						});

						ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.EditForm.Url, docWebPartDef);

						list.AddHostListView(BuiltInListViewDefinitions.Libraries.DispForm, listView =>
						{
							listView.AddDefinitionNode(docWebPartDef.Inherit());
						});

						ValidateWebPartPresenceForPage(list, "Forms/" + BuiltInListViewDefinitions.Libraries.DispForm.Url, docWebPartDef);
					});
				}
            ;

            // all web parts chrom
            currentWeb.WithNodesOfType<WebPartDefinitionBase>(node =>
            {
                var wp = node.Value as WebPartDefinitionBase;

                wp.ChromeType = BuiltInPartChromeType.TitleAndBorder;
                wp.ChromeState = BuiltInPartChromeState.Normal;
            });
        }

        protected void ValidateWebPartPresenceForPage(ModelNode list, string pageName, WebPartDefinitionBase wp)
        {
            ValidateWebPartPresenceForPage(list, pageName, new[] { wp });
        }

        protected void ValidateWebPartPresenceForPage(ModelNode list, string pageName,
            IEnumerable<WebPartDefinitionBase> wps)
        {
            list.AddDefinitionNode(new WebpartPresenceOnPageDefinition
            {
                PageFileName = pageName,
                WebPartDefinitions = new List<WebPartDefinitionBase>(wps)
            }, def =>
            {
                def.RegExcludeFromEventsValidation();
            });
        }

        #endregion
    }

}