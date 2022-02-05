using MarsQA_1.SpecflowPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace MarsQA_1.StepDefinition
{
    [Binding]
    public class ChangePasswordSteps
    {

        ChangePassword ChgpwdObj = new ChangePassword();
        //Reset password
        [Given(@"User should able to reset password")]
        public void GivenUserShouldAbleToResetPassword()
        {
            //Change Password
           ChgpwdObj.changePassword();
          
        }

    }
}
