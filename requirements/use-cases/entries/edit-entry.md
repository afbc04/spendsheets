# Summary

- **Title:** Edit Entry
- **Description:** Administrators can edit existing entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Entry's information is updated

# Flow

### Normal Flow

1. User initiates the edit entry process.
2. User selects the entry
3. User provides the new information, such as:
    - ID of Category
    - Money expected in the end
    - Begin Date
    - Scheduled Due Date
    - List of tags
    - Description
    - Is it visible?
4. System checks if entry can be edited
5. System validates the information provided
6. System updates the entry
7. System used the current date has date of last change
8. System updates entry indicating it was not system generated anymore

### Exception (5) [Information is invalid]

5.1. System informs to user that information provided is invalid
