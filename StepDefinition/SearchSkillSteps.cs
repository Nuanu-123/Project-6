using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class SearchSkillSteps
    {
        SearchSkill searchSkill = new SearchSkill();

        //search using category
        [Given(@"I navigate to search skill")]
        public void GivenINavigateToSearchSkill()
        {
            
            searchSkill.Search_skill();
        }
        [When(@"I try to search skill using category")]
        public void WhenITryToSearchSkillUsingCategory()
        {
           
            searchSkill.SearchCategory();
        }
        [Then(@"I am able to see skills based on category")]
        public void ThenIAmAbleToSeeSkillsBasedOnCategory()
        {
            
            searchSkill.SearchSucessfull();
        }

        //search using name
        [Given(@"I navigate to the Search skill")]
        public void GivenINavigateToTheSearchSkill()
        {
          
            searchSkill.Search_Skill();
        }

        [When(@"I try to search skill using name")]
        public void WhenITryToSearchSkillUsingName()
        {
          
            searchSkill.SearchName();
        }
        [Then(@"I am able to see skill based on given name")]
        public void ThenIAmAbleToSeeSkillBasedOnGivenName()
        {
            searchSkill.SearchNameSuccesfull();
        }

    }
}
