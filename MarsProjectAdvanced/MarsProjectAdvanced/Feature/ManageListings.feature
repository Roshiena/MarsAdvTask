Feature: ManageListings

As seller
I want to edit and delete class Listings
So I can keep my Listings updated

@editmanagelistings
Scenario: E1 Edit Manage Listings
	Given I have navigated to Manage Listings Page
	When I edit Manage Listings
	Then Then Manage Listings should be edited

@deletemanagelistings
Scenario: E2 Delete Manage Listings
	Given I have navigated to Manage Listings Page
	When I delete Manage Listings
	Then The Manage Listings should be deleted