// Pseudocode For E2E Customer Registration
// Positive Path - Large Service Plan

[Test]
public void RegisterCusomerData()
{
// Open Registration Wizard
  var Wizard = new Wizard();

// Enter Customer Email address
  wizard.EnterEmailAddress("customer.email@example.com"); // can be taken from a test data file too

// Select Plan
  wizard.SelectServicePlan("Large"); // can be taken from a test data file too

// Enter Password
  wizard.EnterPassword("validPassword123#"); // can be taken from a test data file too

// Submit
  wizard.Submit();

// Validate the confirmation display
Assert.True(wizard.ConfirmationDisplayed());
Assert.Equal("customer.email@example.com", wizard.GetConfirmationDetail("Email"); 
Assert.Equal("Large", wizard.GetConfirmationDetail("ServicePlan");
Assert.Equal("Submitted", wizard.GetSubmissionStatus());
Assert.NotNull(wizard.GetRegistrationID()); // check if we can validate the regex instead of not null. Should be unique

}
