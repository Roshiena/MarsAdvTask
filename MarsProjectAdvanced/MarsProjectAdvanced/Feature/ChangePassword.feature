Feature: ChangePassword

As a user
I want to change my password
So that I can keep my account secure

@changepassword
Scenario Outline: Change Password in the profile
	When I change '<Current Password>' , '<New Password>' and '<Confirm Password>' in the profile
	Then The '<Current Password>' , '<New Password>' and '<Confirm Password>' should be changed in the profile

Examples: 
| Current Password | New Password | Confirm Password |
| okokok           | nonono       | nonono           |