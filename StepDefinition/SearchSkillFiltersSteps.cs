using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class SearchSkillFiltersSteps
    {
        SearchByFilters searchSkill = new SearchByFilters();
        [Given(@"I go to search skill")]
        public void GivenIGoToSearchSkill()
        {
            
            searchSkill.SearchSkills();
        }
        [Given(@"I click on search button")]
        public void GivenIClickOnSearchButton()
        {
            searchSkill.Search();
        }
        [Given(@"I click on search using filter Online")]
        public void GivenIClickOnSearchUsingFilterOnline()
        {
            searchSkill.FilterOnline();
        }
        [Given(@"I click on search using filter Onsite")]
        public void GivenIClickOnSearchUsingFilterOnsite()
        {
            searchSkill.FilterOnSite();
        }
        [Given(@"I click on search using filter ShowAll")]
        public void GivenIClickOnSearchUsingFilterShowAll()
        {
            searchSkill.FilterShowAll();
        }

    }
}
