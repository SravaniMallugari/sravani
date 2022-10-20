Feature: CaluculatorFeature

A short summary of the feature

@tag1
Scenario: Successfullogin
	Given the userid is testuser_2 
	And the password is Test@153
	When successful login
	Then the result should be loggedin
Scenario:Successfullogout
    Given the input is 1
	When successful logout
	Then the result1 should be loggedout successfully
Scenario:AddToCart
    Given the prodname is product
	And the quantity is 1
	When Added to the cart
	Then the output should be added successfully