Feature: Footer
	As a user interested in EPAM Company
	I want to be able to review Footer
	In order to get information about Company

Scenario: Epam Site - Footer - Check Investors Link
	Given I navigate to Landing Page of Epam site
	And I accept all cookies on Epam Site
	When I click 'Investors' link on Footer of Epam site
	Then I check that Investors page is opened