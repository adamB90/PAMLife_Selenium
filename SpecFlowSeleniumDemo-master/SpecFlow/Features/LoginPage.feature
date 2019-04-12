Feature: LoginPage

@LoginPage
Scenario: Login button exists
	Given I have navigated to my test site
	When the login page loads
	Then the login button should display on the page
