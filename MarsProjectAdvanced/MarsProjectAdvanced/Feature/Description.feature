Feature: Description

As a seller
I want to add Description on my Profile
So that people seeking for skills can look into my Description

@newdescription
Scenario: D1 Add Description in the Profile
    When I add Description to profile
	Then The Description should be added to the profile successfully


@editdescription
Scenario: D2 Edit Description in the Profile
    When I edit Description in profile
	Then The Description should be edited in the profile successfully
