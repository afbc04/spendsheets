# Summary

- **Title:** Edit Due Payment Entry
- **Description:** Administrators can edit existing due payment entries
- **Pre-condition:** User must be Administrator & entry must exists
- **Pos-condition:** Entry's information is updated

# Flow

### Normal Flow

1. User initiates the edit due payment entry process.
2. User selects the entry
3. User provides the new information, such as:
    - ID of Category
    - Money to be paid
    - Begin Date
    - Due Date
    - List of tags
    - Comment
4. System validates the information provided
5. System updates the due payment entry
6. System used the current date has date of last change

### Exception (4) [Information is invalid]

5. System informs to user that information provided is invalid

### Exception (5) [Entry is not into DRAFT mode and money, category, begin or scheduled due date or comment were changed]

6. System informs to user that such information can not be changed if entry is not in draft mode