using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using RelevantCodes.ExtentReports;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class AvailabilityTargetSteps
    {
        AvailabilityTarget LocAvailobj = new AvailabilityTarget();
        [Given(@"I try to add Availabily Time and Target to profile details")]
        public void GivenITryToAddAvailabilyTimeAndTargetToProfileDetails()
        {
            
            //Add profile
           
            LocAvailobj.EnterDetails();
        }

    }
}
