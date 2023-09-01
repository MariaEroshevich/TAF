Feature: FooterNavigation
	As a user interested in EPAM Company
	I want to be able to review Footer
	In order to be able to get required info about the Company

Scenario: Epam Site - Footer - Check Investors Link Navigation
	Given I navigate to Landing page of Epam site
	And I accept all cookies on Epam site
	When I click on 'Investors' link on Footer on Epam site
	Then I check that Investors page is opened
