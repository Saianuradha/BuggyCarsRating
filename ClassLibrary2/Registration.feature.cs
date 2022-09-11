﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace BuggyCarsRating
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Registration", SourceFile="Registration.feature", SourceLine=0)]
    public partial class RegistrationFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "Registration.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Registration", null, ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("To test the Registarion with valid information", new string[] {
                "Positive"}, SourceLine=2)]
        public void ToTestTheRegistarionWithValidInformation()
        {
            string[] tagsOfScenario = new string[] {
                    "Positive"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("To test the Registarion with valid information", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 3
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 4
 testRunner.Given("I register on the site using Anu4, Anu4, Radha4, Test@1234567, Test@1234567 as in" +
                        "put", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 5
 testRunner.When("verify registration is a success", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 6
 testRunner.Then("I use created credentials to log in successfully using Anu4, Test@1234567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        public virtual void RegisterWithDuplicateUserInformation(string login, string firstName, string lastName, string password, string confirmPassword, string message, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "Negative"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Login", login);
            argumentsOfScenario.Add("First Name", firstName);
            argumentsOfScenario.Add("Last Name", lastName);
            argumentsOfScenario.Add("Password", password);
            argumentsOfScenario.Add("Confirm Password", confirmPassword);
            argumentsOfScenario.Add("message", message);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Register with duplicate user information", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 10
    testRunner.Given("I\'m on the Registration page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 11
    testRunner.When(string.Format("I submit Login \"{0}\", First Name \"{1}\", Last Name \"{2}\", Password \"{3}\" ,Confirm " +
                            "Password \"{4}\"", login, firstName, lastName, password, confirmPassword), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
    testRunner.Then(string.Format("I should see an error message \"{0}\"", message), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Register with duplicate user information, Variant 0", new string[] {
                "Negative"}, SourceLine=15)]
        public void RegisterWithDuplicateUserInformation_Variant0()
        {
#line 9
 this.RegisterWithDuplicateUserInformation("Anu4", "Anu4", "RAdha4", "Test@1234567", "Test@1234567", "InvalidParameterException", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Register with duplicate user information, Variant 1", new string[] {
                "Negative"}, SourceLine=15)]
        public void RegisterWithDuplicateUserInformation_Variant1()
        {
#line 9
 this.RegisterWithDuplicateUserInformation("Anu4", "Anu4", "Radha4", "Te@11111", "Te@11111", "User already exists", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Register with duplicate user information, Variant 2", new string[] {
                "Negative"}, SourceLine=15)]
        public void RegisterWithDuplicateUserInformation_Variant2()
        {
#line 9
 this.RegisterWithDuplicateUserInformation("Anu4", "Anu4", "RAdha4", "Te@1111", "Te@1111", "minimum password length", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Register with duplicate user information, Variant 3", new string[] {
                "Negative"}, SourceLine=15)]
        public void RegisterWithDuplicateUserInformation_Variant3()
        {
#line 9
 this.RegisterWithDuplicateUserInformation("Anu4", "Anu4", "RAdha4", "11111111", "11111111", "InvalidPasswordException", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Register with duplicate user information, Variant 4", new string[] {
                "Negative"}, SourceLine=15)]
        public void RegisterWithDuplicateUserInformation_Variant4()
        {
#line 9
 this.RegisterWithDuplicateUserInformation("Anu4", "Anu4", "RAdha4", "A1111111", "A1111111", "InvalidPasswordException", ((string[])(null)));
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Register with duplicate user information, Variant 5", new string[] {
                "Negative"}, SourceLine=15)]
        public void RegisterWithDuplicateUserInformation_Variant5()
        {
#line 9
 this.RegisterWithDuplicateUserInformation("Anu4", "Anu4", "RAdha4", "a1111111", "a1111111", "InvalidPasswordException", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
