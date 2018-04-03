Feature: Fstoppers
	Precondition: there is a user on steam (previously created by hands), the user is logged on steam

Background: 
	Given First Opened main page
	Given Enter the site

@tag
Scenario: Verifying the change of user name
	Given Click on the profile icon in the upper right corner, select the Edit Profile drop-down menu
	When Change the name and surname: fill in the input fields with new passwords, save the changes
	Then Check the values on the opened profile page
	When Return default values name
	Then Close browser
	
@tag
Scenario: Check password change
	Given Click on the profile icon in the upper right corner, select the Edit Profile drop-down menu
	When Click on the button "Account Settings" under the profile photo
		And Change the password: fill in the input fields with the old and new password, save the changes
		And Click on the profile icon in the upper right corner, select the Logout Out drop-down menu
	Then Enter the site with a new password
	When Return default values password
	Then Close browser
	
@tag
Scenario: Check group entry
	When On the panel at the top of the site, point to Groups, click Join to the first group
		And Click on Groups, and go to the page with groups
	Then Check whether the status in the group has changed
	Then Close browser

@tag
Scenario: Check the news
	Given In the news panel, select the ORIGINALS tab
	When Go to the page with the first news
	Then Compare the name of the news
	Then Close browser

@tag
Scenario: Checking the Search
	Given On the panel at the top of the site, Articles, click Browse all categories
	When Choose Nature
		And Remember the name of the author of the first publication, and enter in the search field the reference at the top of the page
	Then Click on the Members tab, check the author's profile
	Then Close browser