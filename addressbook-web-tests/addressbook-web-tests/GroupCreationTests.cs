using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
       
        [Test]
        public void NewAddressGroupTest()
        {
            GoToHomePage();
            Login(new AccountData("admin","secret"));
            GoToGroupsPage();
            InitNewGroupCreation();
            GroupData group = new GroupData("nast");
            group.Header = "nast";
            group.Footer = "nast";
            FillGroupForm(group);
            SubmitGroupCreation();
            ReturnToGroupsPage();
            //driver.FindElement(By.LinkText("Logout")).Click();
        }
  
    }
}
