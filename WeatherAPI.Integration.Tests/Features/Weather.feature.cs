﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.4.0.0
//      SpecFlow Generator Version:2.4.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SeleniumTests.Specs.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.4.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("WeatherAPI", Description="\tIn order to have a happy holiday\r\n\tAs a holiday maker\r\n\tI want to be able to rec" +
        "eive weather forecast", SourceFile="Features\\Weather.feature", SourceLine=0)]
    public partial class WeatherAPIFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Weather.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "WeatherAPI", "\tIn order to have a happy holiday\r\n\tAs a holiday maker\r\n\tI want to be able to rec" +
                    "eive weather forecast", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void AHappyHolidayMaker(string city, string day, string minimumTemperature, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "WeatherAPI-FunctionalTests"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("A happy holiday maker", null, @__tags);
#line 7
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 8
 testRunner.Given(string.Format("I like to holiday in {0}", city), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.And(string.Format("I only like to holiday on {0}", day), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I look up the weather forecast", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
 testRunner.Then("I receive the weather forecast", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 12
 testRunner.And(string.Format("the temperature is warmer than {0} degrees", minimumTemperature), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("A happy holiday maker, Sydney,AU", new string[] {
                "WeatherAPI-FunctionalTests"}, SourceLine=15)]
        public virtual void AHappyHolidayMaker_SydneyAU()
        {
#line 7
this.AHappyHolidayMaker("Sydney,AU", "Thursday", "10", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("WeatherAPI rejects the request that does not provide API Key", SourceLine=17)]
        public virtual void WeatherAPIRejectsTheRequestThatDoesNotProvideAPIKey()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WeatherAPI rejects the request that does not provide API Key", null, ((string[])(null)));
#line 18
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 19
 testRunner.Given("I like to holiday", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 20
 testRunner.When("I look up the weather forecast without providing API Key", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 21
 testRunner.Then("I receive Unauthorised error", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("WeatherAPI returns a json type response when Response mode is set to json", SourceLine=22)]
        public virtual void WeatherAPIReturnsAJsonTypeResponseWhenResponseModeIsSetToJson()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WeatherAPI returns a json type response when Response mode is set to json", null, ((string[])(null)));
#line 23
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 24
 testRunner.Given("I like to holiday", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 25
 testRunner.When("I set response type as json", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 26
 testRunner.And("I look up the weather forecast", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
 testRunner.Then("the response returned is in json format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("WeatherAPI returns a XML type response when Response mode is set to xml", SourceLine=28)]
        public virtual void WeatherAPIReturnsAXMLTypeResponseWhenResponseModeIsSetToXml()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WeatherAPI returns a XML type response when Response mode is set to xml", null, ((string[])(null)));
#line 29
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 30
 testRunner.Given("I like to holiday", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 31
 testRunner.When("I set response type as xml", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 32
 testRunner.And("I look up the weather forecast", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 33
 testRunner.Then("the response returned is in XML format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("WeatherAPI\'s default Response mode is JSON", SourceLine=34)]
        public virtual void WeatherAPIsDefaultResponseModeIsJSON()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WeatherAPI\'s default Response mode is JSON", null, ((string[])(null)));
#line 35
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 36
 testRunner.Given("I like to holiday", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 37
 testRunner.When("I do not set response type", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 38
 testRunner.And("I look up the weather forecast", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.Then("the response returned is in JSON format", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion