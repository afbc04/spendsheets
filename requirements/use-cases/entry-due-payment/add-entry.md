# Summary

- **Title:** Add Due Paymente Entry
- **Description:** Administrators can create due payment entry
- **Pre-condition:** User must be Administrator
- **Pos-condition:** System has a new entry

# Flow

### Normal Flow

1. User initiates the add due payment entry process.
2. User provides:
    - Category _(Optional)_
    - Money to be paid or to received
    - Begin Date _(Optional)_
    - Scheduled Due Date
    - List of tags _(Optional)_
    - Comment _(Optional)_
3. System validates the information provided
4. System fills the missing information, such as:
    - If no date, date is the current date
    - Status is DRAFT
    - Date of last change is the current date
    - Date of creation is the current date
    - Type is Due Payment
5. System saves the new entry, providing the ID to the user 

### Alternative Flow (4) [User marked entry as not draft]

4.1. System fills the missing information, such as:
    - If no date, date is the current date
    - Status is PENDING _(SCHEDULED case begin date is later)_
    - Date of last change is the current date
    - Date of Creation of entry is the current date
    - Type is Due Payment
4.2. _Back to step 5_

### Exception (3) [Information is invalid]

4. System informs to user that information provided is invalid
