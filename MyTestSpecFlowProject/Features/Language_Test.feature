Feature: This test suite contains test scenarios for Profile Page Language feature

Scenario Outline: Add a New Language
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Language tab
When User adds a new language record <language> <level>
Then Mars portal should save the new language record <language>

Examples: 
| language        | level                   |
#| 'Add Language'  | 'Choose Language Level' |
| 'Spanish'       | 'Basic'                 |
| 'Arabic'        | 'Conversational'        |
| 'French'        | 'Fluent'                |
| 'Chinese'       | 'Native/Bilingual'      |

#Scenario Outline: Edit an existing language record
#Given User choose the update option
#When User updates language record <language> <level>
##Then Mars portal should save the updated language record <language>
#
#Examples: 
#| language  | level            |
#| 'Marathi' | 'Conversational' |

#Scenario Outline: Edit four language records
#Given I have a record with four record page
#When I click on the edit button of each record
#Then Each record is in edit mode
#When I update information of each record <oldlanguage> <oldlevel> <newlanguage> <newlevel>
#Then Changes are saved successfully for each record

#Examples: 
#| oldlanguage | oldlevel            | newlanguage  | newlevel           |
#| 'Spanish'    | 'Basic'            | 'Hindi'      | 'Conversational'   |
#| 'Arabic'     | 'Conversational'   | 'Arabic'     | 'Fluent'           |
#| 'French'     | 'Fluent'           | 'Malayalam'  | 'Fluent'           |
#| 'Chinese'    | 'Native/Bilingual' | 'Chinese'    | 'Native/Bilingual' |




#Scenario Outline: Delete a language record
#Given User logs into Mars portal
#And User navigates to Profile page
#And User selects the Language tab
#When User deletes language record 
##Then the language record  should be deleted 

#Examples: 
#| language |
#| 'Spanish'  |



Scenario Outline: B.Update an existing Language 
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Language tab
When User updates language record <newlanguage> <newlevel>
#Then Mars portal should save the updated language record <newlanguage> <newlevel>


#Examples: 
#| old language | new language       | old level        | new level        |
#| 'Spanish'    | 'Hindi'            | 'Basic'          | 'Conversational' |
#| 'Arabic'     | 'Arabic'           | 'Conversational' | 'Fluent'         |
#| 'French'     | 'Chinese'          | 'Fluent'         | 'Fluent'         |

Examples: 
| newlanguage         | newlevel          |
| 'Hindi'             |  'Conversational' |
##| 'Arabic'           | 'Fluent'          |
##| 'Chinese'          | 'Fluent'          | 

Scenario Outline: C.Update the language field of an existing language
Given User logs into Mars portal
And User navigates to Profile page
And User selects the Language tab
When User updates language value <oldlanguagevalue> <newlanguagevalue>
#Then Mars portal should save the updated language record <oldlanguagevalue> <newlanguagevalue>

Examples: 
| oldlanguagevalue | newlanguagevalue |
| 'Hindi'          | 'Marathi'        |



