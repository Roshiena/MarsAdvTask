Feature: Skill

As a seller
I want to add, edit and delete skills on my Profile
So that people seeking for skills can look into my details

@addskills
Scenario Outline: B1 Add Skills in the Profile
    When I add '<Skills>' and '<Level>' to profile
	Then The '<Skills>' and '<Level>' should be added to the profile successfully

Examples:
| Skills   | Level        |
| Cooking  | Expert       |
| Teaching | Beginner     |
| PetCare  | Intermediate |

@editskills
Scenario Outline: B2 Edit Skills in the Profile
    When I edit '<Skills>' and '<Level>' to profile
    Then The '<Skills>' and '<Level>' should be edited to the profile successfully

Examples: 
| Skills  | Level    |
| Writing | Beginner |

@deleteskills
Scenario Outline: B3 Delete Skills in the Profile
    When I delete '<Skills>' and '<Level>' from profile
	Then The '<Skills>' and '<Level>' should be deleted from the profile successfully

Examples: 
| Skills  | Level  |
| Cooking | Expert |
