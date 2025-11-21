# Summary

- **Title:** Edit Loan Entry
- **Description:** Administrators can edit existing loan entries
- **Pre-condition:** User must be Administrator & entry must exists and be in DRAFT mode
- **Pos-condition:** Entry's information is updated

# Flow

### Normal Flow

1. User initiates the edit loan entry process.
2. User selects the entry
3. User provides the new information, such as:
    - ID of Category
    - Borrow money added or removed
    - Date
    - List of tags
    - Comment
4. System validates the information provided
5. System updates the loan entry
6. System used the current date has date of last change

### Exception (4) [Information is invalid]

5. System informs to user that information provided is invalid

### Exception (5) [Entry is not into DRAFT mode and borrow money, category, date or comment were changed]

6. System informs to user that such information can not be changed if entry is not in draft mode